#include "UnrealDotNet.h"
#include "CoreShell.h"
#include "ExportForDotnetLib.inl"
#include <windows.h>

#pragma optimize("", off)

DEFINE_LOG_CATEGORY(CoreShell);

ICLRRuntimeHost2* UCoreShell::Host = NULL;
DWORD UCoreShell::DomainID = 0;

static const FString coreCLRDirectory = L"C:\\Program Files\\dotnet\\shared\\Microsoft.NETCore.App\\1.1.2\\";
static const FString coreCLRDll = L"coreclr.dll";
static const FString tpaExtensions[] =
{
	L"*.dll"
};

void UCoreShell::Initialize()
{
	Host = CreateHost(coreCLRDirectory / coreCLRDll);
	DomainID = CreateDomain(Host, "D:\\ue4\\DotUnrealExample\\Plugins\\UnrealDotNet\\Binaries\\Win64\\netcoreapp1.1\\");

	typedef char*(__stdcall InvokeFp)();

	InvokeFp* manageMethod = NULL;
	HRESULT hr = Host->CreateDelegate
	(
		DomainID, 
		L"UnrealDotNetWrapper, Version=1.0.0.0, Culture=neutral",
		L"UnrealDotNetWrapper.Program", L"Main",
		(INT_PTR*)&manageMethod
	);

	FString str = manageMethod();
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
	auto pfnGetCLRRuntimeHost = (FnGetCLRRuntimeHost)::GetProcAddress(coreCLR, "GetCLRRuntimeHost");

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

	for (int i = 0; i < _countof(tpaExtensions); i++)
	{
		FString searchMask = coreCLRDirectory + tpaExtensions[i];

		WIN32_FIND_DATAW findData;
		HANDLE fileHandle = FindFirstFileW(*searchMask, &findData);

		if (fileHandle != INVALID_HANDLE_VALUE)
		{
			do
			{
				FString file = coreCLRDirectory + FString(findData.cFileName);
				trustedPlatformAssemblies += file + L";";
			} while (FindNextFileW(fileHandle, &findData));

			FindClose(fileHandle);
		}
	}

	FString appPaths = targetAppPath;
	FString appNiPaths = targetAppPath + L";" + targetAppPath + L"NI";
	FString nativeDllSearchDirectories = appPaths + L";" + coreCLRDirectory + L";";
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

typedef int(__stdcall InvokeFp)(INT_PTR method, INT_PTR obj);

int UCoreShell::RunTest()
{
	InvokeFp* manageMethod = NULL;
	HRESULT hr = Host->CreateDelegate
	(
		DomainID, L"Managed, Version=1.0.0.0, Culture=neutral",
		L"Managed.Program", L"Invoke",
		(INT_PTR*)&manageMethod
	);

	//auto impl = NewObject<UCoreShell>();
	//auto m = &UCoreShell::Calc;

	//return manageMethod(*(INT_PTR*)&m, (INT_PTR)impl);
	return 0;
}

#pragma optimize("", on)
