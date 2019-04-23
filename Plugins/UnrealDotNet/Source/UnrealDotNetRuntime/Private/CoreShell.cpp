#include "UnrealDotNetRuntime.h"
#include "CoreShell.h"
#include "Misc/Paths.h"
#include "Export.inl"

#if WITH_EDITOR
#include "IDirectoryWatcher.h"
#include "DirectoryWatcherModule.h"

#include "Framework/Notifications/NotificationManager.h"
#include "Widgets/Notifications/SNotificationList.h"
#endif

#pragma warning(push)
#pragma warning(disable:4458)
#pragma warning(disable:4005)
#pragma warning(disable:4668)

#include "MSCOREE.h"

// TODO: ���������� �� ��� �� ����� ���������-���������
#include "Windows/WindowsSystemIncludes.h"
#include "Windows/WIndowsPlatform.h"
#include "Windows/WindowsPlatformProcess.h"
#include <string>

#pragma warning(pop)

DEFINE_LOG_CATEGORY(DotNetShell);
DEFINE_LOG_CATEGORY(DotNetRuntime);

UCoreShell* UCoreShell::Instance;

void UCoreShell::Initialize()
{
	Instance = (UCoreShell*)UCoreShell::StaticClass()->ClassDefaultObject;
}

UCoreShell::UCoreShell()
{
	LoadConfig();
	LoadCLR();
	LoadMetadata();

#if WITH_EDITOR
	IDirectoryWatcher* DirectoryWatcher = FModuleManager::Get().LoadModuleChecked<FDirectoryWatcherModule>(TEXT("DirectoryWatcher")).Get();
	if (DirectoryWatcher)
	{
		FDelegateHandle DirectoryChangedHandle;
		auto callback = IDirectoryWatcher::FDirectoryChanged::CreateLambda([=](const TArray<FFileChangeData>& files) {
			for (auto& change : files)
			{
				if (FPaths::GetCleanFilename(change.Filename) == FPaths::GetCleanFilename(Hotreload_HookFile))
				{
					UpdateGameLib();
					return;
				}
			}
		});

		DirectoryWatcher->RegisterDirectoryChangedCallback_Handle(Domain_Path, callback, DirectoryChangedHandle);
	}
#endif
}

void UCoreShell::LoadConfig()
{
	CoreCLR_Path		= FPaths::ConvertRelativePathToFull(FPaths::ProjectPluginsDir() / "UnrealDotNet" / "Binaries" / "Win64" / "dotenet_clr" / "");
	Dependencies_Path	= FPaths::ConvertRelativePathToFull(FPaths::ProjectPluginsDir() / "UnrealDotNet" / "Binaries" / "Win64" / "dotenet_libs" / "");
	Domain_Path			= FPaths::ConvertRelativePathToFull(FPaths::ProjectPluginsDir() / "UnrealDotNet" / "Binaries" / "Win64" / "");

	CoreCLR_DLL			= FString("coreclr.dll");

	Hotreload_Path			= Domain_Path / "temp";
	Hotreload_AssembleMask	= Hotreload_Path / "g";
	Hotreload_HookFile		= Hotreload_Path / "hotreload";

	UnrealEngine_Assemble	= FString("UnrealEngine, Version=1.0.0.0, Culture=neutral");
	GameLogic_Assemble		= FString("GameLogic, Version=1.0.0.0, Culture=neutral");
}

void UCoreShell::LoadCLR()
{
	Host = CreateHost(CoreCLR_Path / CoreCLR_DLL);
	DomainID = CreateDomain(Host, Domain_Path);

	auto name = InvokeInWrapper<char*, 0>("UnrealEngine.NativeManager", "GetGameLogicAssemblyName");

	if (name != NULL)
	{
		auto assemblys = InvokeInWrapper<char*, 0>("UnrealEngine.NativeManager", "GetAssemblys");
		auto version = InvokeInWrapper<char*, 0>("UnrealEngine.NativeManager", "GetVersion");
		GameLogic_Assemble = FString(UTF8_TO_TCHAR(name));

		UE_LOG(DotNetShell, Log, TEXT("CLR has been loaded"));
		UE_LOG(DotNetShell, Log, TEXT("Host version %s"), UTF8_TO_TCHAR(version));
		UE_LOG(DotNetShell, Log, TEXT("Loaded assemblys:\n%s"), UTF8_TO_TCHAR(assemblys));
	}
	else
	{
		UE_LOG(DotNetShell, Error, TEXT("Failed load game logic assemble"));
#if WITH_EDITOR
		FSlateNotificationManager::Get().AddNotification(FNotificationInfo(FText::FromString("Failed load game logic assemble")));
#endif
	}
}

#if WITH_EDITOR
void UCoreShell::UpdateGameLib()
{
	if (Host == NULL)
		return;

	FString NewAssemblyGuid;
	if (!FFileHelper::LoadFileToString(NewAssemblyGuid, *Hotreload_HookFile))
		return;

	NewAssemblyGuid.TrimEndInline();
	if (NewAssemblyGuid == AssemblyGuid)
		return;

	auto path = Hotreload_AssembleMask + NewAssemblyGuid + ".dll";
	InvokeInWrapper<void, 0, char*>("UnrealEngine.NativeManager", "ReloadGameLogicAssembly", TCHAR_TO_UTF8(*path));
	
	auto name = InvokeInWrapper<char*, 0>("UnrealEngine.NativeManager", "GetGameLogicAssemblyName");
	if (name != NULL)
	{
		AssemblyGuid = NewAssemblyGuid;
		GameLogic_Assemble = FString(UTF8_TO_TCHAR(name));
		LoadMetadata();

		FSlateNotificationManager::Get().AddNotification(FNotificationInfo(FText::FromString("Game logic assemble reloaded")));
		UE_LOG(DotNetShell, Log, TEXT("Hot reload done, current game logic assembly: %s"), *GameLogic_Assemble);

		if (OnAssembleLoad.IsBound())
			OnAssembleLoad.Execute();
	}
	else
	{
		FSlateNotificationManager::Get().AddNotification(FNotificationInfo(FText::FromString("Failed reloaded game logic assemble")));
		UE_LOG(DotNetShell, Error, TEXT("Hot reload for net core failed :("));
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

	ICLRRuntimeHost4* host;
	auto pfnGetCLRRuntimeHost = reinterpret_cast<FnGetCLRRuntimeHost>((INT_PTR)::GetProcAddress(coreCLR, "GetCLRRuntimeHost"));

	if (!pfnGetCLRRuntimeHost)
	{
		UE_LOG(DotNetShell, Error, TEXT("Not found host lib '%s'"), *coreCLRPath);
		return NULL;
	}

	HRESULT hr = pfnGetCLRRuntimeHost(IID_ICLRRuntimeHost4, (IUnknown**)& host);

	hr = host->SetStartupFlags
	(
		static_cast<STARTUP_FLAGS>
		(
			STARTUP_FLAGS::STARTUP_CONCURRENT_GC |						// Use concurrent GC
			STARTUP_FLAGS::STARTUP_SINGLE_APPDOMAIN |					// All code executes in the default AppDomain
																		// (required to use the runtimeHost->ExecuteAssembly helper function)
			STARTUP_FLAGS::STARTUP_LOADER_OPTIMIZATION_SINGLE_DOMAIN	// Prevents domain-neutral loading
		)
	);

	hr = host->Start();

	if (FAILED(hr))
	{
		UE_LOG(DotNetShell, Error, TEXT("Failed to start the runtime. Code:%x"), hr);
		return NULL;
	}
	else
	{
		UE_LOG(DotNetShell, Log, TEXT("Dotnet host started"));
	}

	return host;
}

DWORD UCoreShell::CreateDomain(ICLRRuntimeHost4* host, const FString& targetAppPath)
{
	if (host == NULL)
	{
		UE_LOG(DotNetShell, Error, TEXT("CoreCLR is not load"));
		return -1;
	}

	FString assemblies;
	AppendAssembliesInDirectory(assemblies, CoreCLR_Path);
	AppendAssembliesInDirectory(assemblies, Dependencies_Path);

	FString appPaths = targetAppPath;
	FString appNiPaths = targetAppPath + L";" + targetAppPath + L"NI";
	FString nativeDllSearchDirectories = appPaths + L";" + CoreCLR_Path + L";" + Dependencies_Path + L";";
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
		*assemblies,
		*appPaths,
		*appNiPaths,
		*nativeDllSearchDirectories,
		*platformResourceRoots,
		*appDomainCompatSwitch
	};

	HRESULT hr = host->CreateAppDomainWithManager
	(
		std::wstring(*FString("UnrealDotNet")).c_str(),
		appDomainFlags,
		NULL,
		NULL,
		sizeof(propertyKeys) / sizeof(wchar_t*),
		propertyKeys,
		propertyValues,
		&domainId);

	return FAILED(hr) ? -1 : domainId;
}

void UCoreShell::AppendAssembliesInDirectory(FString& assemblies, const FString& dir)
{
	static const FString TpaExtensions[] = { "*.dll", "*.exe" };

	for (int i = 0; i < _countof(TpaExtensions); i++)
	{
		FString searchMask = dir + TpaExtensions[i];

		WIN32_FIND_DATAW findData;
		HANDLE fileHandle = FindFirstFileW(*searchMask, &findData);

		if (fileHandle != INVALID_HANDLE_VALUE)
		{
			do
			{
				FString file = dir + FString(findData.cFileName);
				assemblies += file + L";";
			} while (FindNextFileW(fileHandle, &findData));

			FindClose(fileHandle);
		}
	}
}

void UCoreShell::Uninitialize()
{
	if (Instance != NULL)
	{
		if (Instance->Host != NULL)
		{
			Instance->Host->UnloadAppDomain(Instance->DomainID, true);
			Instance->Host->Stop();
			Instance->Host->Release();
		}

		Instance = NULL;
	}
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

FString UCoreShell::RunStatic(const FString& FullClassName, const FString& Method, const FString& Argument)
{
	typedef char*(__stdcall InvokeFp)(char*, char*, char*);

	const auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, "UnrealEngine.NativeManager", "InvokeStatic");

	if (manageMethod == NULL)
		return FString("");

	auto str = manageMethod(TCHAR_TO_UTF8(*FullClassName), TCHAR_TO_UTF8(*Method), TCHAR_TO_UTF8(*Argument));
	return str ? FString(UTF8_TO_TCHAR(str)) : FString("");
}

void UCoreShell::LoadMetadata()
{
	auto json_source = InvokeInWrapper<char*, 0>("UnrealEngine.NativeManager", "GetMetadata");
	auto metadata = FString(UTF8_TO_TCHAR(json_source));

	checkf(metadata.Len() > 0, TEXT("Failed load metadata from manage lib. Please check 'dotenet_clr' and 'dotenet_libs' folder."));

	TSharedPtr<FJsonObject> json;
	TSharedRef<TJsonReader<TCHAR>> JsonReader = TJsonReaderFactory<TCHAR>::Create(metadata);

	FJsonSerializer::Deserialize(JsonReader, json);

	Metadata = FDotnetMetadata(json);
}