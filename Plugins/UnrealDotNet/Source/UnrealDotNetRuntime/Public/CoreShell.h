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
	static void InvokeInWrapper(const FString& FullClassName, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef void(__stdcall InvokeFp)(ArgumentT...);

		auto manageMethod = (InvokeFp*)GetMethodPtr(Wrapper_Assemble, FullClassName, Method);

		if (manageMethod != NULL)
		{
			manageMethod(Aruments...);
		}
	}
	
	template<typename ReturtT, typename... ArgumentT>
	static ReturtT InvokeInWrapper(const FString& FullClassName, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef ReturtT(__stdcall InvokeFp)(ArgumentT...);

		auto manageMethod = (InvokeFp*)GetMethodPtr(Wrapper_Assemble, FullClassName, Method);

		if (manageMethod != NULL)
		{
			return manageMethod(Aruments...);
		}

		return ReturtT();
	}


	static void InvokeInObject(UObject* Object, const FString& Method)
	{
		typedef void(__stdcall InvokeFp)(UObject*, char*);

		const static auto manageMethod = (InvokeFp*)GetMethodPtr(Wrapper_Assemble, "UnrealEngine.UObject", "Invoke");

		if (manageMethod != NULL)
		{
			manageMethod(Object, TCHAR_TO_UTF8(*Method));
		}
	}

private:
	template<typename T>
	static size_t CopyParamsToArray(char* dist, const T& arg)
	{
		*(T*)dist = arg;
		return sizeof(T);
	}

	template<typename T, typename... Args>
	static size_t CopyParamsToArray(char* dist, const T& arg, Args&&... args)
	{
		*(T*)dist = arg;
		return sizeof(T) + CopyParamsToArray(dist + sizeof(T), args...);
	}

public:
	template<typename... ArgumentT>
	static void InvokeInObject(UObject* Object, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef void(__stdcall InvokeFp)(UObject*, char*, void*, int);

		const static auto manageMethod = (InvokeFp*)GetMethodPtr(Wrapper_Assemble, "UnrealEngine.UObject", "Invoke");

		if (manageMethod != NULL)
		{
			static char buffer[96];
			auto len = CopyParamsToArray(buffer, Aruments...);

			manageMethod(Object, TCHAR_TO_UTF8(*Method), buffer, len);
		}
	}

	static void Initialize();
	static void Uninitialize();
};
