#include "UnrealDotNetRuntime.h"
#include "CoreShell.h"
#include "Misc/Paths.h"
#include "DotnetExport.inl"

#if WITH_EDITOR
#include "IDirectoryWatcher.h"
#include "DirectoryWatcherModule.h"
#endif

#pragma warning(push)
#pragma warning(disable:4458)

#pragma warning(push)
#pragma warning(disable:4005)
#pragma warning(disable:4668)

#include "inc/MSCOREE.h"

// TODO: Переписать на что то менее платформо-зависимое
#include "Windows/WindowsSystemIncludes.h"
#include "Windows/WIndowsPlatform.h"
#include "Windows/WindowsPlatformProcess.h"
#include <string>

#pragma warning(pop)

DEFINE_LOG_CATEGORY(DotNetShell);
DEFINE_LOG_CATEGORY(DotNetRuntime);

static const FString PluginName = "UnrealDotNet";
static const FString CoreCLR_Name = "coreclr.dll";

#if WITH_EDITOR
static const FString CoreCLR_Path = FPaths::ConvertRelativePathToFull(FPaths::GamePluginsDir() / PluginName / "Dotnet" / "2.0.0\\");
static const FString Domain_Path = FPaths::ConvertRelativePathToFull(FPaths::GamePluginsDir() / PluginName / "Binaries" / "Win64");
static const FString HotreloadHook_Filename = "HotReload\\hotreload";
#else
static const FString CoreCLR_Path = FPaths::ConvertRelativePathToFull(FPaths::GamePluginsDir() / PluginName / "Dotnet" / "2.0.0\\");
static const FString Domain_Path = FPaths::ConvertRelativePathToFull(FPaths::GamePluginsDir() / PluginName / "Dotnet" / "GameLogic");
#endif

FString UCoreShell::AssemblyGuid;
FString UCoreShell::UnrealEngine_Assemble = "UnrealEngine, Version=1.0.0.0, Culture=neutral";
FString UCoreShell::GameLogic_Assemble = "GameLogic, Version=1.0.0.0, Culture=neutral";

ICLRRuntimeHost4* UCoreShell::Host = NULL;
DWORD UCoreShell::DomainID = 0;

void UCoreShell::Initialize()
{
	Host = CreateHost(CoreCLR_Path / CoreCLR_Name);
	DomainID = CreateDomain(Host, Domain_Path);

#if WITH_EDITOR
	IDirectoryWatcher* DirectoryWatcher = FModuleManager::Get().LoadModuleChecked<FDirectoryWatcherModule>(TEXT("DirectoryWatcher")).Get();
	if (DirectoryWatcher)
	{
		FDelegateHandle DirectoryChangedHandle;
		auto Callback = IDirectoryWatcher::FDirectoryChanged::CreateStatic(&UCoreShell::OnDirectoryChanged);
		DirectoryWatcher->RegisterDirectoryChangedCallback_Handle(Domain_Path, Callback, DirectoryChangedHandle);
	}
#endif
}

#if WITH_EDITOR
void UCoreShell::OnDirectoryChanged(const TArray<FFileChangeData>& FileChanges)
{
	for (auto& change : FileChanges)
	{
		if (FPaths::GetCleanFilename(change.Filename) == FPaths::GetCleanFilename(HotreloadHook_Filename))
		{
			UpdateGameLib();
			return;
		}
	}
}

void UCoreShell::UpdateGameLib()
{
	if (Host == NULL)
		return;

	FString NewAssemblyGuid;
	if (FFileHelper::LoadFileToString(NewAssemblyGuid, *(Domain_Path / HotreloadHook_Filename)))
	{
		NewAssemblyGuid = NewAssemblyGuid.TrimTrailing();
		if (NewAssemblyGuid == AssemblyGuid)
			return;

		AssemblyGuid = NewAssemblyGuid;

		char* name = InvokeInWrapper<char*, 0, char*, char*>("UnrealEngine.NativeManager", "UpdateGameLib", TCHAR_TO_UTF8(*Domain_Path), TCHAR_TO_UTF8(*AssemblyGuid));
		GameLogic_Assemble = FString(UTF8_TO_TCHAR(name));

		if (GameLogic_Assemble.IsEmpty())
		{
			UE_LOG(DotNetShell, Error, TEXT("Hot reload for net core failed :("));
		}
		else
		{
			UE_LOG(DotNetShell, Log, TEXT("Hot reload done, current assembly: %s"), *GameLogic_Assemble);
		}
	}
}
#endif

ICLRRuntimeHost4* UCoreShell::CreateHost(const FString& coreCLRPath)
{
	HMODULE coreCLR = LoadLibraryExW(*coreCLRPath, NULL, 0);

	if (!coreCLR)
	{
		UE_LOG(DotNetShell, Error, TEXT("CoreCLR dll not found '%s'"), *coreCLRPath);
		return NULL;
	}

	ICLRRuntimeHost4* Host;
	auto pfnGetCLRRuntimeHost = reinterpret_cast<FnGetCLRRuntimeHost>((INT_PTR)::GetProcAddress(coreCLR, "GetCLRRuntimeHost"));

	if (!pfnGetCLRRuntimeHost)
	{
		UE_LOG(DotNetShell, Error, TEXT("Not found host lib '%s'"), *coreCLRPath);
		return NULL;
	}

	HRESULT hr = pfnGetCLRRuntimeHost(IID_ICLRRuntimeHost4, (IUnknown**)&Host);

	hr = Host->SetStartupFlags
	(
		static_cast<STARTUP_FLAGS>
		(
			STARTUP_FLAGS::STARTUP_CONCURRENT_GC |						// Use concurrent GC
			STARTUP_FLAGS::STARTUP_SINGLE_APPDOMAIN |					// All code executes in the default AppDomain
																		// (required to use the runtimeHost->ExecuteAssembly helper function)
			STARTUP_FLAGS::STARTUP_LOADER_OPTIMIZATION_SINGLE_DOMAIN	// Prevents domain-neutral loading
			)
	);

	hr = Host->Start();

	if (FAILED(hr))
	{
		UE_LOG(DotNetShell, Error, TEXT("Failed to start the runtime. Code:%x"), hr);
		return NULL;
	}
	else
	{
		UE_LOG(DotNetShell, Log, TEXT("Dotnet host started"));
	}

	return Host;
}

DWORD UCoreShell::CreateDomain(ICLRRuntimeHost4* Host, const FString& targetAppPath)
{
	if (Host == NULL)
	{
		UE_LOG(DotNetShell, Error, TEXT("CoreCLR is not load"));
		return -1;
	}

	FString trustedPlatformAssemblies;

	static const FString TpaExtensions[] = { "*.dll", "*.exe" };
	for (int i = 0; i < _countof(TpaExtensions); i++)
	{
		FString searchMask = CoreCLR_Path + TpaExtensions[i];

		WIN32_FIND_DATAW findData;
		HANDLE fileHandle = FindFirstFileW(*searchMask, &findData);

		if (fileHandle != INVALID_HANDLE_VALUE)
		{
			do
			{
				FString file = CoreCLR_Path + FString(findData.cFileName);
				trustedPlatformAssemblies += file + L";";
			} while (FindNextFileW(fileHandle, &findData));

			FindClose(fileHandle);
		}
	}

	FString appPaths = targetAppPath;
	FString appNiPaths = targetAppPath + L";" + targetAppPath + L"NI";
	FString nativeDllSearchDirectories = appPaths + L";" + CoreCLR_Path + L";";
	FString platformResourceRoots = appPaths;
	FString appDomainCompatSwitch = L"UseLatestBehaviorWhenTFMNotSpecified";

	int appDomainFlags =
		// APPDOMAIN_FORCE_TRIVIAL_WAIT_OPERATIONS |		// Do not pump messages during wait
		APPDOMAIN_SECURITY_SANDBOXED |					// Causes assemblies not from the TPA list to be loaded as partially trusted
		APPDOMAIN_ENABLE_PLATFORM_SPECIFIC_APPS |			// Enable platform-specific assemblies to run
		APPDOMAIN_ENABLE_PINVOKE_AND_CLASSIC_COMINTEROP |	// Allow PInvoking from non-TPA assemblies
		APPDOMAIN_DISABLE_TRANSPARENCY_ENFORCEMENT;			// Entirely disables transparency checks

	DWORD domainId;

	const wchar_t* propertyKeys[] = {
		L"TRUSTED_PLATFORM_ASSEMBLIES",
		L"APP_PATHS",
		L"APP_NI_PATHS",
		L"NATIVE_DLL_SEARCH_DIRECTORIES",
		L"PLATFORM_RESOURCE_ROOTS",
		L"AppDomainCompatSwitch"
	};

	const wchar_t* propertyValues[] =
	{
		*trustedPlatformAssemblies,
		*appPaths,
		*appNiPaths,
		*nativeDllSearchDirectories,
		*platformResourceRoots,
		*appDomainCompatSwitch
	};

	HRESULT hr = Host->CreateAppDomainWithManager
	(
		std::wstring(*PluginName).c_str(),
		appDomainFlags,
		NULL,
		NULL,
		sizeof(propertyKeys) / sizeof(wchar_t*),
		propertyKeys,
		propertyValues,
		&domainId);

	return FAILED(hr) ? -1 : domainId;
}

void UCoreShell::Uninitialize()
{
	if (Host == NULL)
		return;

	Host->UnloadAppDomain(DomainID, true);
	Host->Stop();
	Host->Release();
}

void* UCoreShell::GetMethodPtr(const FString& Assemble, const FString& FullClassName, const FString& Method)
{
	if (Host == NULL)
	{
		UE_LOG(DotNetShell, Error, TEXT("CoreCLR is not load"));
		return NULL;
	}

	void* manageMethod = NULL;
	HRESULT hr = Host->CreateDelegate
	(
		DomainID,
		std::wstring(*Assemble).c_str(),
		std::wstring(*FullClassName).c_str(),
		std::wstring(*Method).c_str(),
		(INT_PTR*)&manageMethod
	);

	if (manageMethod == NULL)
	{
		UE_LOG(DotNetShell, Error, TEXT("Not found manage method %s.%s in %s"), *FullClassName, *Method, *Assemble);
	}

	return manageMethod;
}

FString UCoreShell::RunStaticScript(const FString& FullClassName, const FString& Method, const FString& Argument)
{
	typedef char*(__stdcall InvokeFp)(char*);

	InvokeFp* manageMethod = (InvokeFp*)GetMethodPtr(GameLogic_Assemble, FullClassName, Method);

	if (manageMethod == NULL)
		return "";

	auto str = manageMethod(TCHAR_TO_UTF8(*Argument));
	return FString(UTF8_TO_TCHAR(str));
}

#pragma warning(pop)