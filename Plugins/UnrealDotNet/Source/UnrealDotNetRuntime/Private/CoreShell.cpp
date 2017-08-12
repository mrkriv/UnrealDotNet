#include "UnrealDotNet.h"
#include "CoreShell.h"
#include "Misc/Paths.h"
#include "ExportForDotnetLib.inl"

//             |
//             |
//             |
// Поный треш \ /
//             `

#pragma warning(push)
#pragma warning(disable:4005)
#pragma warning(disable:4668)

#include "inc/mscoree.h"
#include "Windows/WindowsSystemIncludes.h"
#include "Windows/WIndowsPlatform.h"
#include "Windows/WindowsPlatformProcess.h"
#include <string>

#pragma warning(pop)

DEFINE_LOG_CATEGORY(CoreShell);
DEFINE_LOG_CATEGORY(NetCoreRuntime);

ICLRRuntimeHost2* UCoreShell::Host = NULL;
DWORD UCoreShell::DomainID = 0;

static const FString PluginName = "UnrealDotNet";
static const FString CoreCLR_Path = FPaths::ConvertRelativePathToFull(FPaths::GamePluginsDir() / PluginName / "Resources\\Dotnet\\1.1.2\\");
static const FString DotnetLib_Path = FPaths::ConvertRelativePathToFull(FPaths::GamePluginsDir() / PluginName / "Binaries\\Win64\\netcoreapp1.1\\");
static const FString CoreCLR_Name = "coreclr.dll";
static const FString Dotnet_Namespace = "GameLogic";
static const FString Dotnet_Assemble = "GameLogic, Version=1.0.0.0, Culture=neutral";
static const FString TpaExtensions[] = { "*.dll", "*.exe" };

extern "C" UNREALDOTNETRUNTIME_API void Call_ULOG_E(char* Message) { UE_LOG(NetCoreRuntime, Error, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" UNREALDOTNETRUNTIME_API void Call_ULOG_W(char* Message) { UE_LOG(NetCoreRuntime, Warning, TEXT("%s"), UTF8_TO_TCHAR(Message)); }
extern "C" UNREALDOTNETRUNTIME_API void Call_ULOG_L(char* Message) { UE_LOG(NetCoreRuntime, Log, TEXT("%s"), UTF8_TO_TCHAR(Message)); }

void UCoreShell::Initialize()
{
	Host = CreateHost(CoreCLR_Path / CoreCLR_Name);
	DomainID = CreateDomain(Host, DotnetLib_Path);
}

ICLRRuntimeHost2* UCoreShell::CreateHost(const FString& coreCLRPath)
{
	HMODULE coreCLR = LoadLibraryExW(*coreCLRPath, NULL, 0);

	if (!coreCLR)
	{
		UE_LOG(CoreShell, Error, TEXT("ERROR - coreCLR dll not found\n"));
		return NULL;
	}

	ICLRRuntimeHost2* Host;
	auto pfnGetCLRRuntimeHost = reinterpret_cast<FnGetCLRRuntimeHost>((INT_PTR)::GetProcAddress(coreCLR, "GetCLRRuntimeHost"));

	if (!pfnGetCLRRuntimeHost)
	{
		UE_LOG(CoreShell, Error, TEXT("ERROR - not found host lib:\n%s\n"), *coreCLRPath);
		return NULL;
	}

	HRESULT hr = pfnGetCLRRuntimeHost(IID_ICLRRuntimeHost2, (IUnknown**)&Host);

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
		UE_LOG(CoreShell, Error, TEXT("ERROR - Failed to start the runtime.\nError code:%x\n"), hr);
		return NULL;
	}
	else
	{
		UE_LOG(CoreShell, Log, TEXT("Runtime started\n\n"));
	}

	return Host;
}

DWORD UCoreShell::CreateDomain(ICLRRuntimeHost2* Host, const FString& targetAppPath)
{
	if (Host == NULL)
		return -1;

	FString trustedPlatformAssemblies;

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

	//nativeDllSearchDirectories += L"D:\\ue4\\DotUnrealExample\\Plugins\\UnrealDotNet\\Binaries\\Win64;";
	//nativeDllSearchDirectories += L"D:\\ue4\\DotUnrealExample\\Binaries\\Win64;";

	int appDomainFlags =
		// APPDOMAIN_FORCE_TRIVIAL_WAIT_OPERATIONS |		// Do not pump messages during wait
		// APPDOMAIN_SECURITY_SANDBOXED |					// Causes assemblies not from the TPA list to be loaded as partially trusted
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
		L"Unreal Host AppDomain",		// Friendly AD name
		appDomainFlags,
		NULL,							// Optional AppDomain manager assembly name
		NULL,							// Optional AppDomain manager type (including namespace)
		sizeof(propertyKeys) / sizeof(wchar_t*),
		propertyKeys,
		propertyValues,
		&domainId);

	return FAILED(hr) ? -1 : domainId;
}

void UCoreShell::Uninitialize()
{
	Host->UnloadAppDomain(DomainID, true);
	Host->Stop();
	Host->Release();
}

void UCoreShell::ReloadDotnetHost()
{
	Host->UnloadAppDomain(DomainID, true);
	DomainID = CreateDomain(Host, DotnetLib_Path);
}

void* UCoreShell::GetMethodPtr(const FString& Assemble, const FString& FullClassName, const FString& Method)
{
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
		UE_LOG(CoreShell, Error, TEXT("Not found manage method %s.%s in %"), *FullClassName, *Method, *Assemble);
	}

	return manageMethod;
}

FString UCoreShell::RunStaticScript(const FString& FullClassName, const FString& Method, const FString& Argument)
{
	typedef char*(__stdcall InvokeFp)(char*);

	InvokeFp* manageMethod = (InvokeFp*)GetMethodPtr(Dotnet_Assemble, FullClassName, Method);

	if (manageMethod == NULL)
		return "";

	auto str = manageMethod(TCHAR_TO_UTF8(*Argument));
	return FString(UTF8_TO_TCHAR(str));
}