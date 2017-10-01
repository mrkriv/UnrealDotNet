#pragma once

#include "Windows/MinimalWindowsApi.h"
#include "TimerManager.h"

#include "CoreShell.generated.h"

DECLARE_LOG_CATEGORY_EXTERN(DotNetShell, Log, All);
DECLARE_LOG_CATEGORY_EXTERN(DotNetRuntime, Log, All);

#define MAX_INVOKE_ARGUMENT_SIZE 96

class UManagerObject;

UCLASS()
class UNREALDOTNETRUNTIME_API UCoreShell : public UObject
{
	GENERATED_BODY()

	static struct ICLRRuntimeHost4* Host;
	static FString AssemblyGuid;
	static DWORD DomainID;
	static char InvokeArgumentBuffer[MAX_INVOKE_ARGUMENT_SIZE];
	static TSharedPtr<UManagerObject> ManagerInstance;

	static struct ICLRRuntimeHost4* CreateHost(const FString& coreCLRPath);
	static DWORD CreateDomain(struct ICLRRuntimeHost4* Host, const FString& targetAppPath);

#if WITH_EDITOR
	static void UpdateGameLib();
	static void OnDirectoryChanged(const TArray<struct FFileChangeData>& FileChanges);
#endif

public:

	static FString UnrealEngine_Assemble;
	static FString GameLogic_Assemble;

#if WITH_EDITOR
	static FSimpleDelegate OnAssembleLoad;
#endif

	UFUNCTION(BlueprintCallable, Category = DotNet)
	static FString RunStaticScript(const FString& FullClassName, const FString& Method, const FString& Argument);

	UFUNCTION(BlueprintCallable, Category = DotNet, meta = (WorldContext = "WorldContextObject"))
	static void CreateDotNetManager(UObject* WorldContextObject);

	UFUNCTION(BlueprintCallable, Category = DotNet, meta = (WorldContext = "WorldContextObject"))
	static UManagerObject* GetDotNetManager();
	
	UFUNCTION(BlueprintCallable, Category = DotNet, meta = (WorldContext = "WorldContextObject"))
	static void DestroyDotNetManager();

	static void Initialize();
	static void Uninitialize();

	static void* GetMethodPtr(const FString& Assemble, const FString& FullClassName, const FString& Method);
	static void GC();

	template<typename... ArgumentT>
	static void InvokeInWrapper(const FString& FullClassName, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef void(__stdcall InvokeFp)(ArgumentT...);

		auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, FullClassName, Method);

		if (manageMethod != NULL)
		{
			manageMethod(Aruments...);
		}
	}

	template<typename ReturtType, int Stop, typename... ArgumentT>
	static ReturtType InvokeInWrapper(const FString& FullClassName, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef ReturtType(__stdcall InvokeFp)(ArgumentT...);

		auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, FullClassName, Method);

		if (manageMethod != NULL)
		{
			return manageMethod(Aruments...);
		}

		return ReturtType();
	}


	static void InvokeInObject(UObject* Object, const FString& Method)
	{
		typedef void(__stdcall InvokeFp)(UObject*, char*);

		const static auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, "UnrealEngine.NativeManager", "Invoke");

		if (manageMethod != NULL)
		{
			manageMethod(Object, TCHAR_TO_UTF8(*Method));
		}
	}

	template<typename... ArgumentT>
	static void InvokeInObject(UObject* Object, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef void(__stdcall InvokeFp)(UObject*, char*, void*, int);

		const static auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, "UnrealEngine.NativeManager", "Invoke");

		if (manageMethod != NULL)
		{
			auto len = CopyParamsToArray(InvokeArgumentBuffer, Aruments...);

			manageMethod(Object, TCHAR_TO_UTF8(*Method), InvokeArgumentBuffer, len);
		}
	}

	static void InvokeEventInObject(UObject* Object, const FString& Method)
	{
		typedef void(__stdcall InvokeFp)(UObject*, char*);

		const static auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, "UnrealEngine.NativeManager", "InvokeEvent");

		if (manageMethod != NULL)
		{
			manageMethod(Object, TCHAR_TO_UTF8(*Method));
		}
	}

	template<typename... ArgumentT>
	static void InvokeEventInObject(UObject* Object, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef void(__stdcall InvokeFp)(UObject*, char*, void*, int);

		const static auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, "UnrealEngine.NativeManager", "InvokeEvent");

		if (manageMethod != NULL)
		{
			auto len = CopyParamsToArray(InvokeArgumentBuffer, Aruments...);

			manageMethod(Object, TCHAR_TO_UTF8(*Method), InvokeArgumentBuffer, len);
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
};
