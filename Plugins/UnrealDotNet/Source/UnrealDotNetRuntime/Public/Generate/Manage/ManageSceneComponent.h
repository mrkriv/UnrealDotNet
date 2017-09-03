#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageSceneComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageSceneComponent : public USceneComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditDefaultsOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void DetachFromParent(bool bMaintainWorldPosition, bool bCallModify) override;
	
	virtual void OnAttachmentChanged() override;
	
	virtual void PropagateLightingScenarioChange() override;
	
	virtual void SetRelativeScale3D(FVector NewScale3D) override;
	
	virtual void UpdatePhysicsVolume(bool bTriggerNotifiers) override;
	
protected:
	
	virtual void OnChildAttached(USceneComponent* ChildComponent) override;
	
	virtual void OnChildDetached(USceneComponent* ChildComponent) override;
	
	virtual void OnHiddenInGameChanged() override;
	
	virtual void OnVisibilityChanged() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
