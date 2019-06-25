#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/EngineMessage.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\EngineMessage.h:11

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UEngineMessage_EnteredMessage_GET(UEngineMessage* Ptr) { return ConvertToManage_StringWrapper(Ptr->EnteredMessage); }
	DOTNET_EXPORT void E_PROP_UEngineMessage_EnteredMessage_SET(UEngineMessage* Ptr, char* Value) { Ptr->EnteredMessage = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngineMessage_FailedPlaceMessage_GET(UEngineMessage* Ptr) { return ConvertToManage_StringWrapper(Ptr->FailedPlaceMessage); }
	DOTNET_EXPORT void E_PROP_UEngineMessage_FailedPlaceMessage_SET(UEngineMessage* Ptr, char* Value) { Ptr->FailedPlaceMessage = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngineMessage_GlobalNameChange_GET(UEngineMessage* Ptr) { return ConvertToManage_StringWrapper(Ptr->GlobalNameChange); }
	DOTNET_EXPORT void E_PROP_UEngineMessage_GlobalNameChange_SET(UEngineMessage* Ptr, char* Value) { Ptr->GlobalNameChange = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngineMessage_LeftMessage_GET(UEngineMessage* Ptr) { return ConvertToManage_StringWrapper(Ptr->LeftMessage); }
	DOTNET_EXPORT void E_PROP_UEngineMessage_LeftMessage_SET(UEngineMessage* Ptr, char* Value) { Ptr->LeftMessage = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngineMessage_MaxedOutMessage_GET(UEngineMessage* Ptr) { return ConvertToManage_StringWrapper(Ptr->MaxedOutMessage); }
	DOTNET_EXPORT void E_PROP_UEngineMessage_MaxedOutMessage_SET(UEngineMessage* Ptr, char* Value) { Ptr->MaxedOutMessage = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngineMessage_NewPlayerMessage_GET(UEngineMessage* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewPlayerMessage); }
	DOTNET_EXPORT void E_PROP_UEngineMessage_NewPlayerMessage_SET(UEngineMessage* Ptr, char* Value) { Ptr->NewPlayerMessage = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngineMessage_NewSpecMessage_GET(UEngineMessage* Ptr) { return ConvertToManage_StringWrapper(Ptr->NewSpecMessage); }
	DOTNET_EXPORT void E_PROP_UEngineMessage_NewSpecMessage_SET(UEngineMessage* Ptr, char* Value) { Ptr->NewSpecMessage = ConvertFromManage_FString(Value); }
	
	DOTNET_EXPORT auto E_PROP_UEngineMessage_SpecEnteredMessage_GET(UEngineMessage* Ptr) { return ConvertToManage_StringWrapper(Ptr->SpecEnteredMessage); }
	DOTNET_EXPORT void E_PROP_UEngineMessage_SpecEnteredMessage_SET(UEngineMessage* Ptr, char* Value) { Ptr->SpecEnteredMessage = ConvertFromManage_FString(Value); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UEngineMessage(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UEngineMessage>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
