#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/DrawFrustumComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DrawFrustumComponent.h:18

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UDrawFrustumComponent_FrustumAngle_GET(UDrawFrustumComponent* Ptr) { return Ptr->FrustumAngle; }
	DOTNET_EXPORT void E_PROP_UDrawFrustumComponent_FrustumAngle_SET(UDrawFrustumComponent* Ptr, float Value) { Ptr->FrustumAngle = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDrawFrustumComponent_FrustumAspectRatio_GET(UDrawFrustumComponent* Ptr) { return Ptr->FrustumAspectRatio; }
	DOTNET_EXPORT void E_PROP_UDrawFrustumComponent_FrustumAspectRatio_SET(UDrawFrustumComponent* Ptr, float Value) { Ptr->FrustumAspectRatio = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDrawFrustumComponent_FrustumEndDist_GET(UDrawFrustumComponent* Ptr) { return Ptr->FrustumEndDist; }
	DOTNET_EXPORT void E_PROP_UDrawFrustumComponent_FrustumEndDist_SET(UDrawFrustumComponent* Ptr, float Value) { Ptr->FrustumEndDist = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDrawFrustumComponent_FrustumStartDist_GET(UDrawFrustumComponent* Ptr) { return Ptr->FrustumStartDist; }
	DOTNET_EXPORT void E_PROP_UDrawFrustumComponent_FrustumStartDist_SET(UDrawFrustumComponent* Ptr, float Value) { Ptr->FrustumStartDist = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDrawFrustumComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDrawFrustumComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
