#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Engine/EngineTypes.h"
#include "ManageEngineTypes.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3430

UCLASS()
class UNREALDOTNETRUNTIME_API UManageEngineTypes : public UEngineTypes
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	UFUNCTION(BlueprintCallable, Category = "C#")
	FString GetProperty(const FString& Property);
	
	UFUNCTION(BlueprintCallable, Category = "C#")
	void SetProperty(const FString& Property, const FString& Value);
	
	
public:
	
	virtual void BeginDestroy() override;
	
	virtual void FinishDestroy() override;
	
	virtual void MarkAsEditorOnlySubobject() override;
	
	virtual void PostCDOContruct() override;
	
	virtual void PostEditImport() override;
	
	virtual void PostInitProperties() override;
	
	virtual void PostLoad() override;
	
	virtual void PostNetReceive() override;
	
	virtual void PostRename(UObject* OldOuter, const FName OldName) override;
	
	virtual void PostRepNotifies() override;
	
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	
	virtual void PreDestroyFromReplication() override;
	
	virtual void PreNetReceive() override;
	
	virtual void ShutdownAfterError() override;
	
	virtual void AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject) override;
	
	virtual void CreateCluster() override;
	
	virtual void OnClusterMarkedAsPendingKill() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
