#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "Runtime/Engine/Classes/Components/PawnNoiseEmitterComponent.h"
#include "ManagePawnNoiseEmitterComponent.generated.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

UCLASS()
class UNREALDOTNETRUNTIME_API UManagePawnNoiseEmitterComponent : public UPawnNoiseEmitterComponent
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
	
	virtual void MakeNoise(AActor* NoiseMaker, float Loudness, const FVector& NoiseLocation) override;
	
	virtual void Activate(bool bReset) override;
	
	virtual void AddTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	
	virtual void AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	
	virtual void ApplyWorldOffset(const FVector& InOffset, bool bWorldShift) override;
	
	virtual void BeginDestroy() override;
	
	virtual void BeginPlay() override;
	
	virtual void CreateRenderState_Concurrent() override;
	
	virtual void Deactivate() override;
	
	virtual void DestroyComponent(bool bPromoteChildren) override;
	
	virtual void DestroyRenderState_Concurrent() override;
	
	virtual void InitializeComponent() override;
	
	virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) override;
	
	virtual void MarkAsEditorOnlySubobject() override;
	
	virtual void OnActorEnableCollisionChanged() override;
	
	virtual void OnComponentCreated() override;
	
	virtual void OnComponentDestroyed(bool bDestroyingHierarchy) override;
	
	virtual void OnRegister() override;
	
	virtual void OnUnregister() override;
	
	virtual void PostInitProperties() override;
	
	virtual void PostLoad() override;
	
	virtual void PostNetReceive() override;
	
	virtual void PostRename(UObject* OldOuter, const FName OldName) override;
	
	virtual void PreNetReceive() override;
	
	virtual void RegisterComponentTickFunctions(bool bRegister) override;
	
	virtual void RemoveTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	
	virtual void RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	
	virtual void SendRenderTransform_Concurrent() override;
	
	virtual void SetActive(bool bNewActive, bool bReset) override;
	
	virtual void SetAutoActivate(bool bNewAutoActivate) override;
	
	virtual void SetComponentTickEnabled(bool bEnabled) override;
	
	virtual void SetComponentTickEnabledAsync(bool bEnabled) override;
	
	virtual void ToggleActive() override;
	
	virtual void UninitializeComponent() override;
	
	virtual void UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport) override;
	
	virtual void FinishDestroy() override;
	
	virtual void PostCDOContruct() override;
	
	virtual void PostEditImport() override;
	
	virtual void PostRepNotifies() override;
	
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	
	virtual void PreDestroyFromReplication() override;
	
	virtual void ShutdownAfterError() override;
	
	virtual void AddToCluster(UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject) override;
	
	virtual void CreateCluster() override;
	
	virtual void OnClusterMarkedAsPendingKill() override;
	
protected:
	
	virtual void OnCreatePhysicsState() override;
	
	virtual void OnDestroyPhysicsState() override;
	
	virtual void SendRenderDynamicData_Concurrent() override;
	
}
;
PRAGMA_ENABLE_DEPRECATION_WARNINGS
