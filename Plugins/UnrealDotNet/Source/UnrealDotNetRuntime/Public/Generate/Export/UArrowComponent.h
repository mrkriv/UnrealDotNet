#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/ArrowComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ArrowComponent.h:19

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UArrowComponent_ArrowSize_GET(UArrowComponent* Ptr) { return Ptr->ArrowSize; }
	DOTNET_EXPORT void E_PROP_UArrowComponent_ArrowSize_SET(UArrowComponent* Ptr, float Value) { Ptr->ArrowSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UArrowComponent_bIsScreenSizeScaled_GET(UArrowComponent* Ptr) { return Ptr->bIsScreenSizeScaled; }
	DOTNET_EXPORT void E_PROP_UArrowComponent_bIsScreenSizeScaled_SET(UArrowComponent* Ptr, bool Value) { Ptr->bIsScreenSizeScaled = Value; }
	
	DOTNET_EXPORT auto E_PROP_UArrowComponent_ScreenSize_GET(UArrowComponent* Ptr) { return Ptr->ScreenSize; }
	DOTNET_EXPORT void E_PROP_UArrowComponent_ScreenSize_SET(UArrowComponent* Ptr, float Value) { Ptr->ScreenSize = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UArrowComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UArrowComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UArrowComponent_SetArrowColor(UArrowComponent* Self, INT_PTR NewColor)
	{
		auto _p0 = *(FLinearColor*)NewColor;
		Self->SetArrowColor(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
