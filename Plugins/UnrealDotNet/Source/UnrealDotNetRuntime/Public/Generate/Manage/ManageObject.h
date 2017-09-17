#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageObject.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageObject : public UObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void BeginDestroy() override;
	
	virtual void FinishDestroy() override;
	
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
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
