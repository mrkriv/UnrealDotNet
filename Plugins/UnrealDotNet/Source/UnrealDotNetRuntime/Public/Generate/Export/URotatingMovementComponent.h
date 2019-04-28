#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/GameFramework/RotatingMovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

extern "C"
{
	DOTNET_EXPORT auto E_PROP_URotatingMovementComponent_PivotTranslation_GET(URotatingMovementComponent* Ptr) { return (INT_PTR)&(Ptr->PivotTranslation); }
	DOTNET_EXPORT void E_PROP_URotatingMovementComponent_PivotTranslation_SET(URotatingMovementComponent* Ptr, INT_PTR Value) { Ptr->PivotTranslation = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_URotatingMovementComponent_RotationRate_GET(URotatingMovementComponent* Ptr) { return (INT_PTR)&(Ptr->RotationRate); }
	DOTNET_EXPORT void E_PROP_URotatingMovementComponent_RotationRate_SET(URotatingMovementComponent* Ptr, INT_PTR Value) { Ptr->RotationRate = *(FRotator*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_URotatingMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<URotatingMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
