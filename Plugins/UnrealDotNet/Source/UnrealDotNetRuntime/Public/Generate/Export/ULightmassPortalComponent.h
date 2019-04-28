#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/LightmassPortalComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightmassPortalComponent.h:12

extern "C"
{
	DOTNET_EXPORT auto E_PROP_ULightmassPortalComponent_PreviewBox_GET(ULightmassPortalComponent* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PreviewBox); }
	DOTNET_EXPORT void E_PROP_ULightmassPortalComponent_PreviewBox_SET(ULightmassPortalComponent* Ptr, UBoxComponent* Value) { Ptr->PreviewBox = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_ULightmassPortalComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<ULightmassPortalComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
