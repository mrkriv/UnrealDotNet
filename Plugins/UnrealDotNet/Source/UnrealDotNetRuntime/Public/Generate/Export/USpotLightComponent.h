#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageSpotLightComponent.h"
#include "Runtime/Engine/Classes/Components/SpotLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SpotLightComponent.h:16

extern "C"
{
	DOTNET_EXPORT auto E_PROP_USpotLightComponent_InnerConeAngle_GET(USpotLightComponent* Ptr) { return Ptr->InnerConeAngle; }
	DOTNET_EXPORT void E_PROP_USpotLightComponent_InnerConeAngle_SET(USpotLightComponent* Ptr, float Value) { Ptr->InnerConeAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpotLightComponent_LightShaftConeAngle_GET(USpotLightComponent* Ptr) { return Ptr->LightShaftConeAngle; }
	DOTNET_EXPORT void E_PROP_USpotLightComponent_LightShaftConeAngle_SET(USpotLightComponent* Ptr, float Value) { Ptr->LightShaftConeAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpotLightComponent_OuterConeAngle_GET(USpotLightComponent* Ptr) { return Ptr->OuterConeAngle; }
	DOTNET_EXPORT void E_PROP_USpotLightComponent_OuterConeAngle_SET(USpotLightComponent* Ptr, float Value) { Ptr->OuterConeAngle = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USpotLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USpotLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetCosHalfConeAngle(USpotLightComponent* Self)
	{
		return Self->GetCosHalfConeAngle();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_GetHalfConeAngle(USpotLightComponent* Self)
	{
		return Self->GetHalfConeAngle();
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SetInnerConeAngle(USpotLightComponent* Self, float NewInnerConeAngle)
	{
		auto _p0 = NewInnerConeAngle;
		Self->SetInnerConeAngle(_p0);
	}

	DOTNET_EXPORT auto E_USpotLightComponent_SetOuterConeAngle(USpotLightComponent* Self, float NewOuterConeAngle)
	{
		auto _p0 = NewOuterConeAngle;
		Self->SetOuterConeAngle(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_UpdateLightGUIDs(ULightComponentBase* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__UpdateLightGUIDs();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageSpotLightComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageSpotLightComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageSpotLightComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_Deactivate(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageSpotLightComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageSpotLightComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageSpotLightComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnRegister(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageSpotLightComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageSpotLightComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageSpotLightComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSpotLightComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSpotLightComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_BeginDestroy(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_FinishDestroy(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PostCDOContruct(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PostEditImport(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PostInitProperties(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PostLoad(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PostNetReceive(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PostRepNotifies(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageSpotLightComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_PreNetReceive(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__USpotLightComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageSpotLightComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
