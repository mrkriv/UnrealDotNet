#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/TouchInterface.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\TouchInterface.h:56

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UTouchInterface_ActivationDelay_GET(UTouchInterface* Ptr) { return Ptr->ActivationDelay; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_ActivationDelay_SET(UTouchInterface* Ptr, float Value) { Ptr->ActivationDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_ActiveOpacity_GET(UTouchInterface* Ptr) { return Ptr->ActiveOpacity; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_ActiveOpacity_SET(UTouchInterface* Ptr, float Value) { Ptr->ActiveOpacity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_bPreventRecenter_GET(UTouchInterface* Ptr) { return Ptr->bPreventRecenter; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_bPreventRecenter_SET(UTouchInterface* Ptr, bool Value) { Ptr->bPreventRecenter = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_InactiveOpacity_GET(UTouchInterface* Ptr) { return Ptr->InactiveOpacity; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_InactiveOpacity_SET(UTouchInterface* Ptr, float Value) { Ptr->InactiveOpacity = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_StartupDelay_GET(UTouchInterface* Ptr) { return Ptr->StartupDelay; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_StartupDelay_SET(UTouchInterface* Ptr, float Value) { Ptr->StartupDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_TimeUntilDeactive_GET(UTouchInterface* Ptr) { return Ptr->TimeUntilDeactive; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_TimeUntilDeactive_SET(UTouchInterface* Ptr, float Value) { Ptr->TimeUntilDeactive = Value; }
	
	DOTNET_EXPORT auto E_PROP_UTouchInterface_TimeUntilReset_GET(UTouchInterface* Ptr) { return Ptr->TimeUntilReset; }
	DOTNET_EXPORT void E_PROP_UTouchInterface_TimeUntilReset_SET(UTouchInterface* Ptr, float Value) { Ptr->TimeUntilReset = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UTouchInterface(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UTouchInterface>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
