#pragma once

#include "Windows/MinimalWindowsApi.h"
#include "CoreShell.generated.h"

DECLARE_LOG_CATEGORY_EXTERN(CoreShell, Log, All);
DECLARE_LOG_CATEGORY_EXTERN(NetCoreRuntime, Log, All);

static const FString Wrapper_Namespace = "UnrealEngine";
static const FString Wrapper_Assemble = "UnrealDotNetWrapper, Version=1.0.0.0, Culture=neutral";

UCLASS()
class UNREALDOTNETRUNTIME_API UCoreShell : public UObject
{
	GENERATED_BODY()

	static struct ICLRRuntimeHost2* Host;
	static DWORD DomainID;

	static struct ICLRRuntimeHost2* CreateHost(const FString& coreCLRPath);
	static DWORD CreateDomain(struct ICLRRuntimeHost2* Host, const FString& targetAppPath);

public:

	UFUNCTION(BlueprintCallable, Category = DotNet)
	static void ReloadDotnetHost();

	UFUNCTION(BlueprintCallable, Category = DotNet)
	static FString RunStaticScript(const FString& FullClassName, const FString& Method, const FString& Argument);

	static void* GetMethodPtr(const FString& Assemble, const FString& FullClassName, const FString& Method);

	template<typename... ArgumentT>
	static void InvokeInWrapper(const FString& FullClassName, const FString& Method, ArgumentT... Aruments)
	{
		typedef void(__stdcall InvokeFp)(ArgumentT...);

		auto manageMethod = (InvokeFp*)GetMethodPtr(Wrapper_Assemble, FullClassName, Method);

		if (manageMethod != NULL)
		{
			manageMethod(Aruments...);
		}
	}

	template<typename ReturtT, typename... ArgumentT>
	static ReturtT InvokeInWrapper(const FString& FullClassName, const FString& Method, ArgumentT... Aruments)
	{
		typedef ReturtT(__stdcall InvokeFp)(ArgumentT...);

		InvokeFp* manageMethod = (InvokeFp*)GetMethodPtr(Wrapper_Assemble, FullClassName, Method);

		if (manageMethod != NULL)
		{
			return manageMethod(Aruments...);
		}

		return ReturtT();
	}

	static void Initialize();
	static void Uninitialize();
};
