#pragma once

// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreShell.h"
#include "ManageObject.h"
#include "TypeConvertor.h"
#include "Runtime/Engine/Classes/Components/InputComponent.h"
#include "ManageInputComponent.generated.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:675

UCLASS()
class UNREALDOTNETRUNTIME_API UManageInputComponent : public UInputComponent, public IManageObject
{
	GENERATED_BODY()
	
public:
	bool bIsManageAttach = false;
	bool AddWrapperIfNotAttach() override;
	void SetManageType(const FDotnetTypeName& ManageType) override;
	
	UPROPERTY(EditAnywhere, BlueprintReadOnly, Category = "C#")
	FDotnetTypeName ManageClassName;
	
	virtual void Activate(bool bReset) override;
	virtual void BeginPlay() override;
	virtual void CreateRenderState_Concurrent() override;
	virtual void Deactivate() override;
	virtual void DestroyComponent(bool bPromoteChildren) override;
	virtual void DestroyRenderState_Concurrent() override;
	virtual void InitializeComponent() override;
	virtual void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly) override;
	virtual void OnActorEnableCollisionChanged() override;
	virtual void OnComponentCreated() override;
	virtual void OnComponentDestroyed(bool bDestroyingHierarchy) override;
	virtual void OnCreatePhysicsState() override;
	virtual void OnDestroyPhysicsState() override;
	virtual void OnRegister() override;
	virtual void OnRep_IsActive() override;
	virtual void OnUnregister() override;
	virtual void RegisterComponentTickFunctions(bool bRegister) override;
	virtual void SendRenderDynamicData_Concurrent() override;
	virtual void SendRenderTransform_Concurrent() override;
	virtual void SetActive(bool bNewActive, bool bReset) override;
	virtual void SetAutoActivate(bool bNewAutoActivate) override;
	virtual void SetComponentTickEnabled(bool bEnabled) override;
	virtual void SetComponentTickEnabledAsync(bool bEnabled) override;
	virtual void ToggleActive() override;
	virtual void UninitializeComponent() override;
	virtual void BeginDestroy() override;
	virtual void FinishDestroy() override;
	virtual void MarkAsEditorOnlySubobject() override;
	virtual void PostCDOContruct() override;
	virtual void PostEditImport() override;
	virtual void PostInitProperties() override;
	virtual void PostLoad() override;
	virtual void PostNetReceive() override;
	virtual void PostRepNotifies() override;
	virtual void PostSaveRoot(bool bCleanupIsRequired) override;
	virtual void PreDestroyFromReplication() override;
	virtual void PreNetReceive() override;
	virtual void ShutdownAfterError() override;
	virtual void CreateCluster() override;
	virtual void OnClusterMarkedAsPendingKill() override;
	
	void _Supper__Activate(bool bReset);
	void _Supper__BeginPlay();
	void _Supper__CreateRenderState_Concurrent();
	void _Supper__Deactivate();
	void _Supper__DestroyComponent(bool bPromoteChildren);
	void _Supper__DestroyRenderState_Concurrent();
	void _Supper__InitializeComponent();
	void _Supper__InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
	void _Supper__OnActorEnableCollisionChanged();
	void _Supper__OnComponentCreated();
	void _Supper__OnComponentDestroyed(bool bDestroyingHierarchy);
	void _Supper__OnCreatePhysicsState();
	void _Supper__OnDestroyPhysicsState();
	void _Supper__OnRegister();
	void _Supper__OnRep_IsActive();
	void _Supper__OnUnregister();
	void _Supper__RegisterComponentTickFunctions(bool bRegister);
	void _Supper__SendRenderDynamicData_Concurrent();
	void _Supper__SendRenderTransform_Concurrent();
	void _Supper__SetActive(bool bNewActive, bool bReset);
	void _Supper__SetAutoActivate(bool bNewAutoActivate);
	void _Supper__SetComponentTickEnabled(bool bEnabled);
	void _Supper__SetComponentTickEnabledAsync(bool bEnabled);
	void _Supper__ToggleActive();
	void _Supper__UninitializeComponent();
	void _Supper__BeginDestroy();
	void _Supper__FinishDestroy();
	void _Supper__MarkAsEditorOnlySubobject();
	void _Supper__PostCDOContruct();
	void _Supper__PostEditImport();
	void _Supper__PostInitProperties();
	void _Supper__PostLoad();
	void _Supper__PostNetReceive();
	void _Supper__PostRepNotifies();
	void _Supper__PostSaveRoot(bool bCleanupIsRequired);
	void _Supper__PreDestroyFromReplication();
	void _Supper__PreNetReceive();
	void _Supper__ShutdownAfterError();
	void _Supper__CreateCluster();
	void _Supper__OnClusterMarkedAsPendingKill();
};

PRAGMA_ENABLE_DEPRECATION_WARNINGS
