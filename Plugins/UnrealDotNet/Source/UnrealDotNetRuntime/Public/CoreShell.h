#pragma once

#include "Windows/MinimalWindowsApi.h"
#include "CoreShell.generated.h"

DECLARE_LOG_CATEGORY_EXTERN(CoreShell, Log, All);

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

	static void Initialize();
	static void Uninitialize();
};
