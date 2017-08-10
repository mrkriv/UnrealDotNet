#pragma once

#include "inc/mscoree.h"
#include "CoreShell.generated.h"

DECLARE_LOG_CATEGORY_EXTERN(CoreShell, Log, All);

UCLASS()
class UNREALDOTNETRUNTIME_API UCoreShell : public UObject
{
	GENERATED_BODY()

	static ICLRRuntimeHost2* Host;
	static DWORD DomainID;

	static ICLRRuntimeHost2* CreateHost(const FString& coreCLRPath);
	static DWORD CreateDomain(ICLRRuntimeHost2* Host, const FString& targetAppPath);

public:

	UFUNCTION(BlueprintCallable, Category = UnrealDotNet)
	static int RunTest();

	static void Initialize();
	static void Uninitialize();
};
