#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageDirectionalLightComponent.h"
#include "Runtime/Engine/Classes/Components/DirectionalLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DirectionalLightComponent.h:18

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_CascadeDistributionExponent_GET(UDirectionalLightComponent* Ptr) { return Ptr->CascadeDistributionExponent; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_CascadeDistributionExponent_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->CascadeDistributionExponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_CascadeTransitionFraction_GET(UDirectionalLightComponent* Ptr) { return Ptr->CascadeTransitionFraction; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_CascadeTransitionFraction_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->CascadeTransitionFraction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_DistanceFieldShadowDistance_GET(UDirectionalLightComponent* Ptr) { return Ptr->DistanceFieldShadowDistance; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_DistanceFieldShadowDistance_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->DistanceFieldShadowDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_DynamicShadowCascades_GET(UDirectionalLightComponent* Ptr) { return Ptr->DynamicShadowCascades; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_DynamicShadowCascades_SET(UDirectionalLightComponent* Ptr, int32 Value) { Ptr->DynamicShadowCascades = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_DynamicShadowDistanceMovableLight_GET(UDirectionalLightComponent* Ptr) { return Ptr->DynamicShadowDistanceMovableLight; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_DynamicShadowDistanceMovableLight_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->DynamicShadowDistanceMovableLight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_DynamicShadowDistanceStationaryLight_GET(UDirectionalLightComponent* Ptr) { return Ptr->DynamicShadowDistanceStationaryLight; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_DynamicShadowDistanceStationaryLight_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->DynamicShadowDistanceStationaryLight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_FarShadowCascadeCount_GET(UDirectionalLightComponent* Ptr) { return Ptr->FarShadowCascadeCount; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_FarShadowCascadeCount_SET(UDirectionalLightComponent* Ptr, int32 Value) { Ptr->FarShadowCascadeCount = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_FarShadowDistance_GET(UDirectionalLightComponent* Ptr) { return Ptr->FarShadowDistance; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_FarShadowDistance_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->FarShadowDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_LightmassSettings_GET(UDirectionalLightComponent* Ptr) { return (INT_PTR)&(Ptr->LightmassSettings); }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_LightmassSettings_SET(UDirectionalLightComponent* Ptr, INT_PTR Value) { Ptr->LightmassSettings = *(FLightmassDirectionalLightSettings*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_LightShaftOverrideDirection_GET(UDirectionalLightComponent* Ptr) { return (INT_PTR)&(Ptr->LightShaftOverrideDirection); }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_LightShaftOverrideDirection_SET(UDirectionalLightComponent* Ptr, INT_PTR Value) { Ptr->LightShaftOverrideDirection = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_LightSourceAngle_GET(UDirectionalLightComponent* Ptr) { return Ptr->LightSourceAngle; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_LightSourceAngle_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->LightSourceAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_LightSourceSoftAngle_GET(UDirectionalLightComponent* Ptr) { return Ptr->LightSourceSoftAngle; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_LightSourceSoftAngle_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->LightSourceSoftAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_OcclusionDepthRange_GET(UDirectionalLightComponent* Ptr) { return Ptr->OcclusionDepthRange; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_OcclusionDepthRange_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->OcclusionDepthRange = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_OcclusionMaskDarkness_GET(UDirectionalLightComponent* Ptr) { return Ptr->OcclusionMaskDarkness; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_OcclusionMaskDarkness_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->OcclusionMaskDarkness = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_ShadowDistanceFadeoutFraction_GET(UDirectionalLightComponent* Ptr) { return Ptr->ShadowDistanceFadeoutFraction; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_ShadowDistanceFadeoutFraction_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->ShadowDistanceFadeoutFraction = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_TraceDistance_GET(UDirectionalLightComponent* Ptr) { return Ptr->TraceDistance; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_TraceDistance_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->TraceDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDirectionalLightComponent_WholeSceneDynamicShadowRadius_DEPRECATED_GET(UDirectionalLightComponent* Ptr) { return Ptr->WholeSceneDynamicShadowRadius_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UDirectionalLightComponent_WholeSceneDynamicShadowRadius_DEPRECATED_SET(UDirectionalLightComponent* Ptr, float Value) { Ptr->WholeSceneDynamicShadowRadius_DEPRECATED = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDirectionalLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDirectionalLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetCascadeDistributionExponent(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetCascadeDistributionExponent(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetCascadeTransitionFraction(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetCascadeTransitionFraction(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetDynamicShadowCascades(UDirectionalLightComponent* Self, int32 NewValue)
	{
		auto _p0 = NewValue;
		Self->SetDynamicShadowCascades(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetDynamicShadowDistanceMovableLight(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetDynamicShadowDistanceMovableLight(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetDynamicShadowDistanceStationaryLight(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetDynamicShadowDistanceStationaryLight(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetEnableLightShaftOcclusion(UDirectionalLightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetEnableLightShaftOcclusion(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetLightShaftOverrideDirection(UDirectionalLightComponent* Self, INT_PTR NewValue)
	{
		auto _p0 = *(FVector*)NewValue;
		Self->SetLightShaftOverrideDirection(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetOcclusionMaskDarkness(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetOcclusionMaskDarkness(_p0);
	}

	DOTNET_EXPORT auto E_UDirectionalLightComponent_SetShadowDistanceFadeoutFraction(UDirectionalLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetShadowDistanceFadeoutFraction(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_UpdateLightGUIDs(ULightComponentBase* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__UpdateLightGUIDs();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageDirectionalLightComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageDirectionalLightComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageDirectionalLightComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_Deactivate(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageDirectionalLightComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageDirectionalLightComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageDirectionalLightComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnRegister(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageDirectionalLightComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageDirectionalLightComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageDirectionalLightComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageDirectionalLightComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageDirectionalLightComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_BeginDestroy(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_FinishDestroy(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PostCDOContruct(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PostEditImport(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PostInitProperties(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PostLoad(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PostNetReceive(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PostRepNotifies(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageDirectionalLightComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_PreNetReceive(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UDirectionalLightComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageDirectionalLightComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
