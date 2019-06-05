#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageSkyLightComponent.h"
#include "Runtime/Engine/Classes/Components/SkyLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkyLightComponent.h:96

class E_PROTECTED_WRAP_USkyLightComponent : protected USkyLightComponent
{
public:
	void UpdateLimitedRenderingStateFast_WRAP()
	{
		UpdateLimitedRenderingStateFast();
	}

	void UpdateOcclusionRenderingStateFast_WRAP()
	{
		UpdateOcclusionRenderingStateFast();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_bCaptureEmissiveOnly_GET(USkyLightComponent* Ptr) { return Ptr->bCaptureEmissiveOnly; }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_bCaptureEmissiveOnly_SET(USkyLightComponent* Ptr, bool Value) { Ptr->bCaptureEmissiveOnly = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_bLowerHemisphereIsBlack_GET(USkyLightComponent* Ptr) { return Ptr->bLowerHemisphereIsBlack; }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_bLowerHemisphereIsBlack_SET(USkyLightComponent* Ptr, bool Value) { Ptr->bLowerHemisphereIsBlack = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_Contrast_GET(USkyLightComponent* Ptr) { return Ptr->Contrast; }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_Contrast_SET(USkyLightComponent* Ptr, float Value) { Ptr->Contrast = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_CubemapResolution_GET(USkyLightComponent* Ptr) { return Ptr->CubemapResolution; }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_CubemapResolution_SET(USkyLightComponent* Ptr, int32 Value) { Ptr->CubemapResolution = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_LowerHemisphereColor_GET(USkyLightComponent* Ptr) { return (INT_PTR)&(Ptr->LowerHemisphereColor); }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_LowerHemisphereColor_SET(USkyLightComponent* Ptr, INT_PTR Value) { Ptr->LowerHemisphereColor = *(FLinearColor*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_MinOcclusion_GET(USkyLightComponent* Ptr) { return Ptr->MinOcclusion; }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_MinOcclusion_SET(USkyLightComponent* Ptr, float Value) { Ptr->MinOcclusion = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_OcclusionExponent_GET(USkyLightComponent* Ptr) { return Ptr->OcclusionExponent; }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_OcclusionExponent_SET(USkyLightComponent* Ptr, float Value) { Ptr->OcclusionExponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_OcclusionMaxDistance_GET(USkyLightComponent* Ptr) { return Ptr->OcclusionMaxDistance; }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_OcclusionMaxDistance_SET(USkyLightComponent* Ptr, float Value) { Ptr->OcclusionMaxDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_SkyDistanceThreshold_GET(USkyLightComponent* Ptr) { return Ptr->SkyDistanceThreshold; }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_SkyDistanceThreshold_SET(USkyLightComponent* Ptr, float Value) { Ptr->SkyDistanceThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_USkyLightComponent_SourceCubemapAngle_GET(USkyLightComponent* Ptr) { return Ptr->SourceCubemapAngle; }
	DOTNET_EXPORT void E_PROP_USkyLightComponent_SourceCubemapAngle_SET(USkyLightComponent* Ptr, float Value) { Ptr->SourceCubemapAngle = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USkyLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USkyLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USkyLightComponent_IsOcclusionSupported(USkyLightComponent* Self)
	{
		return Self->IsOcclusionSupported();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_RecaptureSky(USkyLightComponent* Self)
	{
		Self->RecaptureSky();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SanitizeCubemapSize(USkyLightComponent* Self)
	{
		Self->SanitizeCubemapSize();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(USkyLightComponent* Self)
	{
		Self->SetBlendDestinationCaptureIsDirty();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetCaptureIsDirty(USkyLightComponent* Self)
	{
		Self->SetCaptureIsDirty();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetIndirectLightingIntensity(USkyLightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetIndirectLightingIntensity(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetIntensity(USkyLightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetIntensity(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetLightColor(USkyLightComponent* Self, INT_PTR NewLightColor)
	{
		auto _p0 = *(FLinearColor*)NewLightColor;
		Self->SetLightColor(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetLowerHemisphereColor(USkyLightComponent* Self, INT_PTR InLowerHemisphereColor)
	{
		auto& _p0 = *(FLinearColor*)InLowerHemisphereColor;
		Self->SetLowerHemisphereColor(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetMinOcclusion(USkyLightComponent* Self, float InMinOcclusion)
	{
		auto _p0 = InMinOcclusion;
		Self->SetMinOcclusion(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetOcclusionContrast(USkyLightComponent* Self, float InOcclusionContrast)
	{
		auto _p0 = InOcclusionContrast;
		Self->SetOcclusionContrast(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetOcclusionExponent(USkyLightComponent* Self, float InOcclusionExponent)
	{
		auto _p0 = InOcclusionExponent;
		Self->SetOcclusionExponent(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_SetVolumetricScatteringIntensity(USkyLightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetVolumetricScatteringIntensity(_p0);
	}

	DOTNET_EXPORT auto E_USkyLightComponent_UpdateLimitedRenderingStateFast(USkyLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->UpdateLimitedRenderingStateFast_WRAP();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_UpdateOcclusionRenderingStateFast(USkyLightComponent* Self)
	{
		((E_PROTECTED_WRAP_USkyLightComponent*)Self)->UpdateOcclusionRenderingStateFast_WRAP();
	}

	DOTNET_EXPORT auto E_USkyLightComponent_UpdateSkyCaptureContents(USkyLightComponent* Self, UWorld* WorldToUpdate)
	{
		auto _p0 = WorldToUpdate;
		Self->UpdateSkyCaptureContents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_UpdateLightGUIDs(ULightComponentBase* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__UpdateLightGUIDs();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageSkyLightComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageSkyLightComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageSkyLightComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_Deactivate(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageSkyLightComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageSkyLightComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageSkyLightComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnRegister(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageSkyLightComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageSkyLightComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageSkyLightComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSkyLightComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSkyLightComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_BeginDestroy(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_FinishDestroy(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PostCDOContruct(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PostEditImport(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PostInitProperties(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PostLoad(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PostNetReceive(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PostRepNotifies(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageSkyLightComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_PreNetReceive(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__USkyLightComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageSkyLightComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
