#pragma once

#include "Windows/MinimalWindowsApi.h"
#include "TimerManager.h"
#include "DotnetMetadata.h"
#include "DotnetTypeName.h"

#include "CoreShell.generated.h"

DECLARE_LOG_CATEGORY_EXTERN(DotNetShell, Log, All);
DECLARE_LOG_CATEGORY_EXTERN(DotNetRuntime, Log, All);

#define MAX_INVOKE_ARGUMENT_SIZE 1024

UCLASS()
class UNREALDOTNETRUNTIME_API UCoreShell : public UObject
{
	GENERATED_BODY()

	static UCoreShell* Instance;

	char InvokeArgumentBuffer[MAX_INVOKE_ARGUMENT_SIZE] = { 0 };
	struct ICLRRuntimeHost4* Host;
	DWORD DomainID;

	FString AssemblyGuid;
	FString UnrealEngine_Assemble;
	FString GameLogic_Assemble;

	FString CoreCLR_DLL;
	FString CoreCLR_Path;
	FString Domain_Path;
	FString Dependencies_Path;

	FString Hotreload_Path;
	FString Hotreload_HookFile;
	FString Hotreload_AssembleMask;


	void* GetMethodPtr(const FString& Assemble, const FString& FullClassName, const FString& Method);
	struct ICLRRuntimeHost4* CreateHost(const FString& coreCLRPath);
	DWORD CreateDomain(struct ICLRRuntimeHost4* Host, const FString& targetAppPath);
	void AppendAssembliesInDirectory(FString& assemblies, const FString& dir);
	void LoadConfig();
	void LoadCLR();
	void LoadMetadata();

public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly)
	FDotnetMetadata Metadata;

#if WITH_EDITOR
	FSimpleDelegate OnAssembleLoad;
	void UpdateGameLib();
#endif

	UCoreShell();

	static void Initialize();
	static void Uninitialize();

	UFUNCTION(BlueprintPure, Category = DotNet, meta = (DisplayName = "dotNet"))
	static UCoreShell* GetInstance() { return Instance; }

	UFUNCTION(BlueprintCallable, Category = DotNet)
	FString RunStatic(const FString& FullClassName, const FString& Method, const FString& Argument);


	template<typename... ArgumentT>
	void InvokeInWrapper(const FString& FullClassName, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef void(__stdcall InvokeFp)(ArgumentT...);

		auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, FullClassName, Method);

		if (manageMethod == NULL)
			return;

		try
		{
			manageMethod(Aruments...);
		}
		catch (...)
		{
			UE_LOG(DotNetShell, Error, TEXT("Unhandled exception in %s.%s"), *FullClassName, *Method);
		}
	}

	template<typename ReturtType, int Stop, typename... ArgumentT>
	ReturtType InvokeInWrapper(const FString& FullClassName, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef ReturtType(__stdcall InvokeFp)(ArgumentT...);

		auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, FullClassName, Method);

		if (manageMethod == NULL)
			return ReturtType();

		try
		{
			return manageMethod(Aruments...);
		}
		catch (...)
		{
			UE_LOG(DotNetShell, Error, TEXT("Unhandled exception in %s.%s"), *FullClassName, *Method);
			return ReturtType();
		}
	}

	template<typename... ArgumentT>
	void InvokeInObject(UObject* Object, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef void(__stdcall InvokeFp)(UObject*, char*, void*, int);

		const auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, "UnrealEngine.NativeManager", "Invoke");

		if (manageMethod == NULL)
			return;

		auto len = CopyParamsToArray(InvokeArgumentBuffer, Aruments...);

		try 
		{
			manageMethod(Object, TCHAR_TO_UTF8(*Method), InvokeArgumentBuffer, len);
		}
		catch  (...)
		{
			UE_LOG(DotNetShell, Error, TEXT("Unhandled exception in %s of object %s"), *Method, *Object->GetName());
		}
	}

	template<typename... ArgumentT>
	void InvokeEventInObject(UObject* Object, const FString& Method, const ArgumentT&... Aruments)
	{
		typedef void(__stdcall InvokeFp)(UObject*, char*, void*, int);

		const static auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, "UnrealEngine.NativeManager", "InvokeEvent");

		if (manageMethod == NULL)
			return;

		auto len = CopyParamsToArray(InvokeArgumentBuffer, Aruments...);

		try
		{
			manageMethod(Object, TCHAR_TO_UTF8(*Method), InvokeArgumentBuffer, len);
		}
		catch (...)
		{
			UE_LOG(DotNetShell, Error, TEXT("Unhandled exception in %s of object %s"), *Method, *Object->GetName());
		}
	}

	template<typename... ArgumentT>
	void InvokeEventById(unsigned int EventId, const ArgumentT&... Aruments)
	{
		typedef void(__stdcall InvokeFp)(unsigned int, void*, int);

		const static auto manageMethod = (InvokeFp*)GetMethodPtr(UnrealEngine_Assemble, "UnrealEngine.NativeManager", "InvokeEventById");

		if (manageMethod == NULL)
			return;

		auto len = CopyParamsToArray(InvokeArgumentBuffer, Aruments...);

		try
		{
			manageMethod(EventId, InvokeArgumentBuffer, len);
		}
		catch (...)
		{
			UE_LOG(DotNetShell, Error, TEXT("Unhandled exception in call event by id %d"), EventId);
		}
	}

private:
	template<typename T, typename... Args>
	static size_t CopyParamsToArray(char* dist, const T& arg, Args&... args)
	{
		*(T*)dist = arg;
		return sizeof(T) + CopyParamsToArray(dist + sizeof(T), args...);
	}

	template<typename T>
	static size_t CopyParamsToArray(char* dist, const T& arg)
	{
		*(T*)dist = arg;
		return sizeof(T);
	}

	static size_t CopyParamsToArray(char* dist)
	{
		return 0;
	}
};
