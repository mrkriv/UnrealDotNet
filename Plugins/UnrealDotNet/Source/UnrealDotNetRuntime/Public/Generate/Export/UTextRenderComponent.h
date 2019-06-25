#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageTextRenderComponent.h"
#include "Runtime/Engine/Classes/Components/TextRenderComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\TextRenderComponent.h:44

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_HorizSpacingAdjust_GET(UTextRenderComponent* Ptr) { return Ptr->HorizSpacingAdjust; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_HorizSpacingAdjust_SET(UTextRenderComponent* Ptr, float Value) { Ptr->HorizSpacingAdjust = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_InvDefaultSize_GET(UTextRenderComponent* Ptr) { return Ptr->InvDefaultSize; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_InvDefaultSize_SET(UTextRenderComponent* Ptr, float Value) { Ptr->InvDefaultSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_Text_GET(UTextRenderComponent* Ptr) { return ConvertToManage_StringWrapper(Ptr->Text); }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_Text_SET(UTextRenderComponent* Ptr, char* Value) { Ptr->Text = ConvertFromManage_FText(Value); }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_VertSpacingAdjust_GET(UTextRenderComponent* Ptr) { return Ptr->VertSpacingAdjust; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_VertSpacingAdjust_SET(UTextRenderComponent* Ptr, float Value) { Ptr->VertSpacingAdjust = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_WorldSize_GET(UTextRenderComponent* Ptr) { return Ptr->WorldSize; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_WorldSize_SET(UTextRenderComponent* Ptr, float Value) { Ptr->WorldSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_XScale_GET(UTextRenderComponent* Ptr) { return Ptr->XScale; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_XScale_SET(UTextRenderComponent* Ptr, float Value) { Ptr->XScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTextRenderComponent_YScale_GET(UTextRenderComponent* Ptr) { return Ptr->YScale; }
	DOTNET_EXPORT void E_PROP_UTextRenderComponent_YScale_SET(UTextRenderComponent* Ptr, float Value) { Ptr->YScale = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UTextRenderComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UTextRenderComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetTextLocalSize(UTextRenderComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetTextLocalSize());
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_GetTextWorldSize(UTextRenderComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetTextWorldSize());
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_InitializeMIDCache(UTextRenderComponent* Self)
	{
		Self->InitializeMIDCache();
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_K2_SetText(UTextRenderComponent* Self, char* Value)
	{
		auto _p0 = ConvertFromManage_FText(Value);
		Self->K2_SetText(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetHorizontalAlignment(UTextRenderComponent* Self, EHorizTextAligment Value)
	{
		auto _p0 = Value;
		Self->SetHorizontalAlignment(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetHorizSpacingAdjust(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetHorizSpacingAdjust(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetText(UTextRenderComponent* Self, char* Value)
	{
		auto _p0 = ConvertFromManage_FString(Value);
		Self->SetText(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetText_o1(UTextRenderComponent* Self, char* Value)
	{
		auto _p0 = ConvertFromManage_FText(Value);
		Self->SetText(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetVerticalAlignment(UTextRenderComponent* Self, EVerticalTextAligment Value)
	{
		auto _p0 = Value;
		Self->SetVerticalAlignment(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetVertSpacingAdjust(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetVertSpacingAdjust(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetWorldSize(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetWorldSize(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetXScale(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetXScale(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_SetYScale(UTextRenderComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetYScale(_p0);
	}

	DOTNET_EXPORT auto E_UTextRenderComponent_ShutdownMIDCache(UTextRenderComponent* Self)
	{
		Self->ShutdownMIDCache();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnComponentCollisionSettingsChanged();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		((UManageTextRenderComponent*)Self)->_Supper__SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		((UManageTextRenderComponent*)Self)->_Supper__SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageTextRenderComponent*)Self)->_Supper__SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		((UManageTextRenderComponent*)Self)->_Supper__SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		((UManageTextRenderComponent*)Self)->_Supper__SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		((UManageTextRenderComponent*)Self)->_Supper__SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		((UManageTextRenderComponent*)Self)->_Supper__SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__UnWeldChildren();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__UnWeldFromParent();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__UpdatePhysicsToRBChannels();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageTextRenderComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageTextRenderComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageTextRenderComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_Deactivate(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageTextRenderComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageTextRenderComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageTextRenderComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnRegister(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageTextRenderComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageTextRenderComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageTextRenderComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageTextRenderComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageTextRenderComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_BeginDestroy(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_FinishDestroy(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PostCDOContruct(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PostEditImport(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PostInitProperties(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PostLoad(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PostNetReceive(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PostRepNotifies(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageTextRenderComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_PreNetReceive(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UTextRenderComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageTextRenderComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
