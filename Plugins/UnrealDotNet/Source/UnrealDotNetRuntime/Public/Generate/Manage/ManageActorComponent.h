#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Components/ActorComponent.h"
#include "ManageActorComponent.generated.h"

UCLASS()
class UNREALDOTNETRUNTIME_API UManageActorComponent : public UActorComponent
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	public:
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	
public:
	
	virtual void Activate(bool bReset) override;
	
	virtual void BeginPlay() override;
	
	virtual void Deactivate() override;
	
	virtual void DestroyComponent(bool bPromoteChildren) override;
	
	virtual void InitializeComponent() override;
	
	virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) override;
	
	virtual void OnActorEnableCollisionChanged() override;
	
	virtual void OnComponentCreated() override;
	
	virtual void OnComponentDestroyed(bool bDestroyingHierarchy) override;
	
	virtual void SetActive(bool bNewActive, bool bReset) override;
	
	virtual void SetAutoActivate(bool bNewAutoActivate) override;
	
	virtual void SetComponentTickEnabled(bool bEnabled) override;
	
	virtual void SetComponentTickEnabledAsync(bool bEnabled) override;
	
	virtual void ToggleActive() override;
	
	virtual void UninitializeComponent() override;
	
	virtual void UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport) override;
	
protected:
	
	virtual void CreateRenderState_Concurrent() override;
	
	virtual void DestroyRenderState_Concurrent() override;
	
	virtual void OnCreatePhysicsState() override;
	
	virtual void OnDestroyPhysicsState() override;
	
	virtual void OnRegister() override;
	
	virtual void OnUnregister() override;
	
	virtual void RegisterComponentTickFunctions(bool bRegister) override;
	
	virtual void SendRenderDynamicData_Concurrent() override;
	
	virtual void SendRenderTransform_Concurrent() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
