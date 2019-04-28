#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
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

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
