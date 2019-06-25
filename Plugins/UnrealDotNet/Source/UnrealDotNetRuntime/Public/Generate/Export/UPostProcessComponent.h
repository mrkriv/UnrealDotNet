#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/PostProcessComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PostProcessComponent.h:21

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UPostProcessComponent_BlendRadius_GET(UPostProcessComponent* Ptr) { return Ptr->BlendRadius; }
	DOTNET_EXPORT void E_PROP_UPostProcessComponent_BlendRadius_SET(UPostProcessComponent* Ptr, float Value) { Ptr->BlendRadius = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPostProcessComponent_BlendWeight_GET(UPostProcessComponent* Ptr) { return Ptr->BlendWeight; }
	DOTNET_EXPORT void E_PROP_UPostProcessComponent_BlendWeight_SET(UPostProcessComponent* Ptr, float Value) { Ptr->BlendWeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPostProcessComponent_Priority_GET(UPostProcessComponent* Ptr) { return Ptr->Priority; }
	DOTNET_EXPORT void E_PROP_UPostProcessComponent_Priority_SET(UPostProcessComponent* Ptr, float Value) { Ptr->Priority = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPostProcessComponent_Settings_GET(UPostProcessComponent* Ptr) { return (INT_PTR)&(Ptr->Settings); }
	DOTNET_EXPORT void E_PROP_UPostProcessComponent_Settings_SET(UPostProcessComponent* Ptr, INT_PTR Value) { Ptr->Settings = *(FPostProcessSettings*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPostProcessComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPostProcessComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
