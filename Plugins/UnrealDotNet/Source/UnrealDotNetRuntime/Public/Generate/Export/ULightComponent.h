#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/LightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightComponent.h:40

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ULightComponent_BloomScale_GET(ULightComponent* Ptr) { return Ptr->BloomScale; }
	DOTNET_EXPORT void E_PROP_ULightComponent_BloomScale_SET(ULightComponent* Ptr, float Value) { Ptr->BloomScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_BloomThreshold_GET(ULightComponent* Ptr) { return Ptr->BloomThreshold; }
	DOTNET_EXPORT void E_PROP_ULightComponent_BloomThreshold_SET(ULightComponent* Ptr, float Value) { Ptr->BloomThreshold = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_bUseRayTracedDistanceFieldShadows_GET(ULightComponent* Ptr) { return Ptr->bUseRayTracedDistanceFieldShadows; }
	DOTNET_EXPORT void E_PROP_ULightComponent_bUseRayTracedDistanceFieldShadows_SET(ULightComponent* Ptr, bool Value) { Ptr->bUseRayTracedDistanceFieldShadows = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_ContactShadowLength_GET(ULightComponent* Ptr) { return Ptr->ContactShadowLength; }
	DOTNET_EXPORT void E_PROP_ULightComponent_ContactShadowLength_SET(ULightComponent* Ptr, float Value) { Ptr->ContactShadowLength = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_DisabledBrightness_GET(ULightComponent* Ptr) { return Ptr->DisabledBrightness; }
	DOTNET_EXPORT void E_PROP_ULightComponent_DisabledBrightness_SET(ULightComponent* Ptr, float Value) { Ptr->DisabledBrightness = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_IESBrightnessScale_GET(ULightComponent* Ptr) { return Ptr->IESBrightnessScale; }
	DOTNET_EXPORT void E_PROP_ULightComponent_IESBrightnessScale_SET(ULightComponent* Ptr, float Value) { Ptr->IESBrightnessScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_LightFunctionFadeDistance_GET(ULightComponent* Ptr) { return Ptr->LightFunctionFadeDistance; }
	DOTNET_EXPORT void E_PROP_ULightComponent_LightFunctionFadeDistance_SET(ULightComponent* Ptr, float Value) { Ptr->LightFunctionFadeDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_LightFunctionScale_GET(ULightComponent* Ptr) { return (INT_PTR)&(Ptr->LightFunctionScale); }
	DOTNET_EXPORT void E_PROP_ULightComponent_LightFunctionScale_SET(ULightComponent* Ptr, INT_PTR Value) { Ptr->LightFunctionScale = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_LightingChannels_GET(ULightComponent* Ptr) { return (INT_PTR)&(Ptr->LightingChannels); }
	DOTNET_EXPORT void E_PROP_ULightComponent_LightingChannels_SET(ULightComponent* Ptr, INT_PTR Value) { Ptr->LightingChannels = *(FLightingChannels*)Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_MaxDistanceFadeRange_GET(ULightComponent* Ptr) { return Ptr->MaxDistanceFadeRange; }
	DOTNET_EXPORT void E_PROP_ULightComponent_MaxDistanceFadeRange_SET(ULightComponent* Ptr, float Value) { Ptr->MaxDistanceFadeRange = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_MaxDrawDistance_GET(ULightComponent* Ptr) { return Ptr->MaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_ULightComponent_MaxDrawDistance_SET(ULightComponent* Ptr, float Value) { Ptr->MaxDrawDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_MinRoughness_DEPRECATED_GET(ULightComponent* Ptr) { return Ptr->MinRoughness_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_ULightComponent_MinRoughness_DEPRECATED_SET(ULightComponent* Ptr, float Value) { Ptr->MinRoughness_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_PreviewShadowMapChannel_GET(ULightComponent* Ptr) { return Ptr->PreviewShadowMapChannel; }
	DOTNET_EXPORT void E_PROP_ULightComponent_PreviewShadowMapChannel_SET(ULightComponent* Ptr, int32 Value) { Ptr->PreviewShadowMapChannel = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_RayStartOffsetDepthScale_GET(ULightComponent* Ptr) { return Ptr->RayStartOffsetDepthScale; }
	DOTNET_EXPORT void E_PROP_ULightComponent_RayStartOffsetDepthScale_SET(ULightComponent* Ptr, float Value) { Ptr->RayStartOffsetDepthScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_ShadowBias_GET(ULightComponent* Ptr) { return Ptr->ShadowBias; }
	DOTNET_EXPORT void E_PROP_ULightComponent_ShadowBias_SET(ULightComponent* Ptr, float Value) { Ptr->ShadowBias = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_ShadowMapChannel_DEPRECATED_GET(ULightComponent* Ptr) { return Ptr->ShadowMapChannel_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_ULightComponent_ShadowMapChannel_DEPRECATED_SET(ULightComponent* Ptr, int32 Value) { Ptr->ShadowMapChannel_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_ShadowResolutionScale_GET(ULightComponent* Ptr) { return Ptr->ShadowResolutionScale; }
	DOTNET_EXPORT void E_PROP_ULightComponent_ShadowResolutionScale_SET(ULightComponent* Ptr, float Value) { Ptr->ShadowResolutionScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_ShadowSharpen_GET(ULightComponent* Ptr) { return Ptr->ShadowSharpen; }
	DOTNET_EXPORT void E_PROP_ULightComponent_ShadowSharpen_SET(ULightComponent* Ptr, float Value) { Ptr->ShadowSharpen = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_SpecularScale_GET(ULightComponent* Ptr) { return Ptr->SpecularScale; }
	DOTNET_EXPORT void E_PROP_ULightComponent_SpecularScale_SET(ULightComponent* Ptr, float Value) { Ptr->SpecularScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponent_Temperature_GET(ULightComponent* Ptr) { return Ptr->Temperature; }
	DOTNET_EXPORT void E_PROP_ULightComponent_Temperature_SET(ULightComponent* Ptr, float Value) { Ptr->Temperature = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULightComponent_AffectsBounds(ULightComponent* Self, INT_PTR InBounds)
	{
		auto& _p0 = *(FBoxSphereBounds*)InBounds;
		return Self->AffectsBounds(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_AffectsPrimitive(ULightComponent* Self, UPrimitiveComponent* Primitive)
	{
		auto _p0 = Primitive;
		return Self->AffectsPrimitive(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_GetBoundingBox(ULightComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetBoundingBox());
	}

	DOTNET_EXPORT auto E_ULightComponent_GetBoundingSphere(ULightComponent* Self)
	{
		return (INT_PTR) new FSphere(Self->GetBoundingSphere());
	}

	DOTNET_EXPORT auto E_ULightComponent_GetLightPosition(ULightComponent* Self)
	{
		return (INT_PTR) new FVector4(Self->GetLightPosition());
	}

	DOTNET_EXPORT auto E_ULightComponent_SetAffectDynamicIndirectLighting(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectDynamicIndirectLighting(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetAffectTranslucentLighting(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectTranslucentLighting(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetBloomScale(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBloomScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetBloomThreshold(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBloomThreshold(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetEnableLightShaftBloom(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetEnableLightShaftBloom(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetForceCachedShadowsForMovablePrimitives(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetForceCachedShadowsForMovablePrimitives(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetIESBrightnessScale(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetIESBrightnessScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetIndirectLightingIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetIndirectLightingIntensity(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetIntensity(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightColor(ULightComponent* Self, INT_PTR NewLightColor, bool bSRGB)
	{
		auto _p0 = *(FLinearColor*)NewLightColor;
		auto _p1 = bSRGB;
		Self->SetLightColor(_p0, _p1);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightFunctionDisabledBrightness(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetLightFunctionDisabledBrightness(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightFunctionFadeDistance(ULightComponent* Self, float NewLightFunctionFadeDistance)
	{
		auto _p0 = NewLightFunctionFadeDistance;
		Self->SetLightFunctionFadeDistance(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetLightFunctionScale(ULightComponent* Self, INT_PTR NewLightFunctionScale)
	{
		auto _p0 = *(FVector*)NewLightFunctionScale;
		Self->SetLightFunctionScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetShadowBias(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetShadowBias(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetSpecularScale(ULightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetSpecularScale(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetTemperature(ULightComponent* Self, float NewTemperature)
	{
		auto _p0 = NewTemperature;
		Self->SetTemperature(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetTransmission(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetTransmission(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetUseIESBrightness(ULightComponent* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetUseIESBrightness(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponent_SetVolumetricScatteringIntensity(ULightComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetVolumetricScatteringIntensity(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
