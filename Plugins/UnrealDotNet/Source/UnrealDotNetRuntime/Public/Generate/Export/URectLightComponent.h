#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/RectLightComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\RectLightComponent.h:20

extern "C"
{
	DOTNET_EXPORT auto E_PROP_URectLightComponent_BarnDoorAngle_GET(URectLightComponent* Ptr) { return Ptr->BarnDoorAngle; }
	DOTNET_EXPORT void E_PROP_URectLightComponent_BarnDoorAngle_SET(URectLightComponent* Ptr, float Value) { Ptr->BarnDoorAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_URectLightComponent_BarnDoorLength_GET(URectLightComponent* Ptr) { return Ptr->BarnDoorLength; }
	DOTNET_EXPORT void E_PROP_URectLightComponent_BarnDoorLength_SET(URectLightComponent* Ptr, float Value) { Ptr->BarnDoorLength = Value; }
	
	DOTNET_EXPORT auto E_PROP_URectLightComponent_SourceHeight_GET(URectLightComponent* Ptr) { return Ptr->SourceHeight; }
	DOTNET_EXPORT void E_PROP_URectLightComponent_SourceHeight_SET(URectLightComponent* Ptr, float Value) { Ptr->SourceHeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_URectLightComponent_SourceWidth_GET(URectLightComponent* Ptr) { return Ptr->SourceWidth; }
	DOTNET_EXPORT void E_PROP_URectLightComponent_SourceWidth_SET(URectLightComponent* Ptr, float Value) { Ptr->SourceWidth = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_URectLightComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<URectLightComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_URectLightComponent_SetBarnDoorAngle(URectLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBarnDoorAngle(_p0);
	}

	DOTNET_EXPORT auto E_URectLightComponent_SetBarnDoorLength(URectLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetBarnDoorLength(_p0);
	}

	DOTNET_EXPORT auto E_URectLightComponent_SetSourceHeight(URectLightComponent* Self, float NewValue)
	{
		auto _p0 = NewValue;
		Self->SetSourceHeight(_p0);
	}

	DOTNET_EXPORT auto E_URectLightComponent_SetSourceWidth(URectLightComponent* Self, float bNewValue)
	{
		auto _p0 = bNewValue;
		Self->SetSourceWidth(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
