#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/BillboardComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BillboardComponent.h:19

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_ScreenSize_GET(UBillboardComponent* Ptr) { return Ptr->ScreenSize; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_ScreenSize_SET(UBillboardComponent* Ptr, float Value) { Ptr->ScreenSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_U_GET(UBillboardComponent* Ptr) { return Ptr->U; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_U_SET(UBillboardComponent* Ptr, float Value) { Ptr->U = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_UL_GET(UBillboardComponent* Ptr) { return Ptr->UL; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_UL_SET(UBillboardComponent* Ptr, float Value) { Ptr->UL = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_V_GET(UBillboardComponent* Ptr) { return Ptr->V; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_V_SET(UBillboardComponent* Ptr, float Value) { Ptr->V = Value; }
	
	DOTNET_EXPORT auto E_PROP_UBillboardComponent_VL_GET(UBillboardComponent* Ptr) { return Ptr->VL; }
	DOTNET_EXPORT void E_PROP_UBillboardComponent_VL_SET(UBillboardComponent* Ptr, float Value) { Ptr->VL = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBillboardComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBillboardComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UBillboardComponent_SetUV(UBillboardComponent* Self, int32 NewU, int32 NewUL, int32 NewV, int32 NewVL)
	{
		auto _p0 = NewU;
		auto _p1 = NewUL;
		auto _p2 = NewV;
		auto _p3 = NewVL;
		Self->UBillboardComponent::SetUV(_p0, _p1, _p2, _p3);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
