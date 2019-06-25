#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageExponentialHeightFogComponent.h"
#include "Runtime/Engine/Classes/Components/ExponentialHeightFogComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ExponentialHeightFogComponent.h:47

class E_PROTECTED_WRAP_UExponentialHeightFogComponent : protected UExponentialHeightFogComponent
{
public:
	void AddFogIfNeeded_WRAP()
	{
		AddFogIfNeeded();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_bEnableVolumetricFog_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->bEnableVolumetricFog; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_bEnableVolumetricFog_SET(UExponentialHeightFogComponent* Ptr, bool Value) { Ptr->bEnableVolumetricFog = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_bOverrideLightColorsWithFogInscatteringColors_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->bOverrideLightColorsWithFogInscatteringColors; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_bOverrideLightColorsWithFogInscatteringColors_SET(UExponentialHeightFogComponent* Ptr, bool Value) { Ptr->bOverrideLightColorsWithFogInscatteringColors = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringColor_GET(UExponentialHeightFogComponent* Ptr) { return (INT_PTR)&(Ptr->DirectionalInscatteringColor); }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringColor_SET(UExponentialHeightFogComponent* Ptr, INT_PTR Value) { Ptr->DirectionalInscatteringColor = *(FLinearColor*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringExponent_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->DirectionalInscatteringExponent; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringExponent_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->DirectionalInscatteringExponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringStartDistance_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->DirectionalInscatteringStartDistance; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_DirectionalInscatteringStartDistance_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->DirectionalInscatteringStartDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_FogCutoffDistance_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->FogCutoffDistance; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_FogCutoffDistance_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->FogCutoffDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_FogDensity_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->FogDensity; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_FogDensity_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->FogDensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_FogHeightFalloff_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->FogHeightFalloff; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_FogHeightFalloff_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->FogHeightFalloff = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_FogInscatteringColor_GET(UExponentialHeightFogComponent* Ptr) { return (INT_PTR)&(Ptr->FogInscatteringColor); }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_FogInscatteringColor_SET(UExponentialHeightFogComponent* Ptr, INT_PTR Value) { Ptr->FogInscatteringColor = *(FLinearColor*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_FogMaxOpacity_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->FogMaxOpacity; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_FogMaxOpacity_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->FogMaxOpacity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_FullyDirectionalInscatteringColorDistance_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->FullyDirectionalInscatteringColorDistance; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_FullyDirectionalInscatteringColorDistance_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->FullyDirectionalInscatteringColorDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_InscatteringColorCubemapAngle_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->InscatteringColorCubemapAngle; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_InscatteringColorCubemapAngle_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->InscatteringColorCubemapAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_InscatteringTextureTint_GET(UExponentialHeightFogComponent* Ptr) { return (INT_PTR)&(Ptr->InscatteringTextureTint); }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_InscatteringTextureTint_SET(UExponentialHeightFogComponent* Ptr, INT_PTR Value) { Ptr->InscatteringTextureTint = *(FLinearColor*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_NonDirectionalInscatteringColorDistance_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->NonDirectionalInscatteringColorDistance; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_NonDirectionalInscatteringColorDistance_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->NonDirectionalInscatteringColorDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_SecondFogData_GET(UExponentialHeightFogComponent* Ptr) { return (INT_PTR)&(Ptr->SecondFogData); }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_SecondFogData_SET(UExponentialHeightFogComponent* Ptr, INT_PTR Value) { Ptr->SecondFogData = *(FExponentialHeightFogData*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_StartDistance_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->StartDistance; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_StartDistance_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->StartDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_VolumetricFogDistance_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->VolumetricFogDistance; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_VolumetricFogDistance_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->VolumetricFogDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_VolumetricFogEmissive_GET(UExponentialHeightFogComponent* Ptr) { return (INT_PTR)&(Ptr->VolumetricFogEmissive); }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_VolumetricFogEmissive_SET(UExponentialHeightFogComponent* Ptr, INT_PTR Value) { Ptr->VolumetricFogEmissive = *(FLinearColor*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_VolumetricFogExtinctionScale_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->VolumetricFogExtinctionScale; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_VolumetricFogExtinctionScale_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->VolumetricFogExtinctionScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_VolumetricFogScatteringDistribution_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->VolumetricFogScatteringDistribution; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_VolumetricFogScatteringDistribution_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->VolumetricFogScatteringDistribution = Value; }
	
	DOTNET_EXPORT auto E_PROP_UExponentialHeightFogComponent_VolumetricFogStaticLightingScatteringIntensity_GET(UExponentialHeightFogComponent* Ptr) { return Ptr->VolumetricFogStaticLightingScatteringIntensity; }
	DOTNET_EXPORT void E_PROP_UExponentialHeightFogComponent_VolumetricFogStaticLightingScatteringIntensity_SET(UExponentialHeightFogComponent* Ptr, float Value) { Ptr->VolumetricFogStaticLightingScatteringIntensity = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UExponentialHeightFogComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UExponentialHeightFogComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_AddFogIfNeeded(UExponentialHeightFogComponent* Self)
	{
		((E_PROTECTED_WRAP_UExponentialHeightFogComponent*)Self)->AddFogIfNeeded_WRAP();
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetDirectionalInscatteringColor(UExponentialHeightFogComponent* Self, INT_PTR Value)
	{
		auto _p0 = *(FLinearColor*)Value;
		Self->SetDirectionalInscatteringColor(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetDirectionalInscatteringExponent(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetDirectionalInscatteringExponent(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetDirectionalInscatteringStartDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetDirectionalInscatteringStartDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogCutoffDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogCutoffDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogDensity(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogDensity(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogHeightFalloff(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogHeightFalloff(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogInscatteringColor(UExponentialHeightFogComponent* Self, INT_PTR Value)
	{
		auto _p0 = *(FLinearColor*)Value;
		Self->SetFogInscatteringColor(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFogMaxOpacity(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFogMaxOpacity(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetFullyDirectionalInscatteringColorDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetFullyDirectionalInscatteringColorDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetInscatteringColorCubemapAngle(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetInscatteringColorCubemapAngle(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetInscatteringTextureTint(UExponentialHeightFogComponent* Self, INT_PTR Value)
	{
		auto _p0 = *(FLinearColor*)Value;
		Self->SetInscatteringTextureTint(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetNonDirectionalInscatteringColorDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetNonDirectionalInscatteringColorDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetStartDistance(UExponentialHeightFogComponent* Self, float Value)
	{
		auto _p0 = Value;
		Self->SetStartDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFog(UExponentialHeightFogComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetVolumetricFog(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogDistance(UExponentialHeightFogComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetVolumetricFogDistance(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogEmissive(UExponentialHeightFogComponent* Self, INT_PTR NewValue)
	{
		auto _p0 = *(FLinearColor*)NewValue;
		Self->SetVolumetricFogEmissive(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogExtinctionScale(UExponentialHeightFogComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetVolumetricFogExtinctionScale(_p0);
	}

	DOTNET_EXPORT auto E_UExponentialHeightFogComponent_SetVolumetricFogScatteringDistribution(UExponentialHeightFogComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetVolumetricFogScatteringDistribution(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_Deactivate(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnRegister(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_BeginDestroy(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_FinishDestroy(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PostCDOContruct(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PostEditImport(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PostInitProperties(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PostLoad(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PostNetReceive(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PostRepNotifies(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_PreNetReceive(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UExponentialHeightFogComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageExponentialHeightFogComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
