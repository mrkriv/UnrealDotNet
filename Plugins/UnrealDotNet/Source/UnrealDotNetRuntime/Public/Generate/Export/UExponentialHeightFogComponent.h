#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
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

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
