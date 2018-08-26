#pragma once

// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "IManageObject.h"
#include "Runtime/Engine/Classes/Components/ActorComponent.h"
#include "ManageActorComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\ActorComponent.h:91

UCLASS()
class UNREALDOTNETRUNTIME_API UManageActorComponent : public UActorComponent, public IManageObject
{
	GENERATED_BODY()
	
	bool bIsManageAttach = false;
	
	bool AddWrapperIfNotAttach();
	
public:
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void Activate(bool bReset) override;
	virtual void AddTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	virtual void AddTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
	virtual void ApplyWorldOffset(const FVector& InOffset, bool bWorldShift) override;
	virtual void BeginPlay() override;
	virtual void Deactivate() override;
	virtual void DestroyComponent(bool bPromoteChildren) override;
	virtual void InitializeComponent() override;
	virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) override;
	virtual void OnActorEnableCollisionChanged() override;
	virtual void OnComponentCreated() override;
	virtual void OnComponentDestroyed(bool bDestroyingHierarchy) override;
	virtual void OnRep_IsActive() override;
	virtual void RemoveTickPrerequisiteActor(AActor* PrerequisiteActor) override;
	virtual void RemoveTickPrerequisiteComponent(UActorComponent* PrerequisiteComponent) override;
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
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
