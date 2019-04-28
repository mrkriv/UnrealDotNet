#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/LightComponentBase.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightComponentBase.h:14

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ULightComponentBase_Brightness_DEPRECATED_GET(ULightComponentBase* Ptr) { return Ptr->Brightness_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_ULightComponentBase_Brightness_DEPRECATED_SET(ULightComponentBase* Ptr, float Value) { Ptr->Brightness_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponentBase_IndirectLightingIntensity_GET(ULightComponentBase* Ptr) { return Ptr->IndirectLightingIntensity; }
	DOTNET_EXPORT void E_PROP_ULightComponentBase_IndirectLightingIntensity_SET(ULightComponentBase* Ptr, float Value) { Ptr->IndirectLightingIntensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponentBase_Intensity_GET(ULightComponentBase* Ptr) { return Ptr->Intensity; }
	DOTNET_EXPORT void E_PROP_ULightComponentBase_Intensity_SET(ULightComponentBase* Ptr, float Value) { Ptr->Intensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponentBase_SamplesPerPixel_GET(ULightComponentBase* Ptr) { return Ptr->SamplesPerPixel; }
	DOTNET_EXPORT void E_PROP_ULightComponentBase_SamplesPerPixel_SET(ULightComponentBase* Ptr, int Value) { Ptr->SamplesPerPixel = Value; }
	
	DOTNET_EXPORT auto E_PROP_ULightComponentBase_VolumetricScatteringIntensity_GET(ULightComponentBase* Ptr) { return Ptr->VolumetricScatteringIntensity; }
	DOTNET_EXPORT void E_PROP_ULightComponentBase_VolumetricScatteringIntensity_SET(ULightComponentBase* Ptr, float Value) { Ptr->VolumetricScatteringIntensity = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULightComponentBase(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULightComponentBase>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_ULightComponentBase_GetLightColor(ULightComponentBase* Self)
	{
		return (INT_PTR) new FLinearColor(Self->GetLightColor());
	}

	DOTNET_EXPORT auto E_ULightComponentBase_HasStaticLighting(ULightComponentBase* Self)
	{
		return Self->HasStaticLighting();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_HasStaticShadowing(ULightComponentBase* Self)
	{
		return Self->HasStaticShadowing();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_IsMovable(ULightComponentBase* Self)
	{
		return Self->IsMovable();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetAffectReflection(ULightComponentBase* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetAffectReflection(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetCastRaytracedShadow(ULightComponentBase* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastRaytracedShadow(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetCastShadows(ULightComponentBase* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastShadows(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetCastVolumetricShadow(ULightComponentBase* Self, bool bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetCastVolumetricShadow(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_SetSamplesPerPixel(ULightComponentBase* Self, int NewValue)
	{
		auto _p0 = NewValue;
		Self->SetSamplesPerPixel(_p0);
	}

	DOTNET_EXPORT auto E_ULightComponentBase_UpdateLightGUIDs(ULightComponentBase* Self)
	{
		Self->UpdateLightGUIDs();
	}

	DOTNET_EXPORT auto E_ULightComponentBase_ValidateLightGUIDs(ULightComponentBase* Self)
	{
		Self->ValidateLightGUIDs();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
