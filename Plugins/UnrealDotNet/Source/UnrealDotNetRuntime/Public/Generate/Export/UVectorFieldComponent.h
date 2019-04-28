#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/VectorFieldComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\VectorFieldComponent.h:18

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UVectorFieldComponent_Intensity_GET(UVectorFieldComponent* Ptr) { return Ptr->Intensity; }
	DOTNET_EXPORT void E_PROP_UVectorFieldComponent_Intensity_SET(UVectorFieldComponent* Ptr, float Value) { Ptr->Intensity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UVectorFieldComponent_Tightness_GET(UVectorFieldComponent* Ptr) { return Ptr->Tightness; }
	DOTNET_EXPORT void E_PROP_UVectorFieldComponent_Tightness_SET(UVectorFieldComponent* Ptr, float Value) { Ptr->Tightness = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UVectorFieldComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UVectorFieldComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UVectorFieldComponent_SetIntensity(UVectorFieldComponent* Self, float NewIntensity)
	{
		auto _p0 = NewIntensity;
		Self->SetIntensity(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
