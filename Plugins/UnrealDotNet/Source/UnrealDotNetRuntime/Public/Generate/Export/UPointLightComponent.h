#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePointLightComponent.h"
#include "Runtime/Engine/Classes/Components/PointLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PointLightComponent.h:18

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPointLightComponent_LightFalloffExponent_GET(UPointLightComponent* Ptr) { return Ptr->LightFalloffExponent; }
	DOTNET_EXPORT void E_PROP_UPointLightComponent_LightFalloffExponent_SET(UPointLightComponent* Ptr, float Value) { Ptr->LightFalloffExponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPointLightComponent_SoftSourceRadius_GET(UPointLightComponent* Ptr) { return Ptr->SoftSourceRadius; }
	DOTNET_EXPORT void E_PROP_UPointLightComponent_SoftSourceRadius_SET(UPointLightComponent* Ptr, float Value) { Ptr->SoftSourceRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPointLightComponent_SourceLength_GET(UPointLightComponent* Ptr) { return Ptr->SourceLength; }
	DOTNET_EXPORT void E_PROP_UPointLightComponent_SourceLength_SET(UPointLightComponent* Ptr, float Value) { Ptr->SourceLength = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPointLightComponent_SourceRadius_GET(UPointLightComponent* Ptr) { return Ptr->SourceRadius; }
	DOTNET_EXPORT void E_PROP_UPointLightComponent_SourceRadius_SET(UPointLightComponent* Ptr, float Value) { Ptr->SourceRadius = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPointLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPointLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetLightFalloffExponent(UPointLightComponent* Self, float NewLightFalloffExponent)
	{
		auto _p0 = NewLightFalloffExponent;
		Self->SetLightFalloffExponent(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetSoftSourceRadius(UPointLightComponent* Self, float bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetSoftSourceRadius(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetSourceLength(UPointLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetSourceLength(_p0);
	}

	DOTNET_EXPORT auto E_UPointLightComponent_SetSourceRadius(UPointLightComponent* Self, float bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetSourceRadius(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_UpdateLightGUIDs(ULightComponentBase* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__UpdateLightGUIDs();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManagePointLightComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManagePointLightComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManagePointLightComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_BeginPlay(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_Deactivate(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManagePointLightComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManagePointLightComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManagePointLightComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnRegister(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnUnregister(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManagePointLightComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManagePointLightComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManagePointLightComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManagePointLightComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManagePointLightComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_ToggleActive(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_BeginDestroy(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_FinishDestroy(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PostCDOContruct(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PostEditImport(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PostInitProperties(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PostLoad(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PostNetReceive(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PostRepNotifies(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePointLightComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_PreNetReceive(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_ShutdownAfterError(UObject* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPointLightComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePointLightComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
