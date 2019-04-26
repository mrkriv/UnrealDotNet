#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/InputComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:675

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UInputComponent_bBlockInput_GET(UInputComponent* Ptr) { return Ptr->bBlockInput; }
	DOTNET_EXPORT void E_PROP_UInputComponent_bBlockInput_SET(UInputComponent* Ptr, uint8 Value) { Ptr->bBlockInput = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputComponent_Priority_GET(UInputComponent* Ptr) { return Ptr->Priority; }
	DOTNET_EXPORT void E_PROP_UInputComponent_Priority_SET(UInputComponent* Ptr, int32 Value) { Ptr->Priority = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInputComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInputComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UInputComponent_AddActionBinding(UInputComponent* Self, INT_PTR Binding)
	{
		auto _p0 = *(FInputActionBinding*)Binding;
		return (INT_PTR) new FInputActionBinding(Self->AddActionBinding(_p0));
	}

	DOTNET_EXPORT auto E_UInputComponent_BindAxis(UInputComponent* Self, char* AxisName)
	{
		auto _p0 = ConvertFromManage_FName(AxisName);
		return (INT_PTR) new FInputAxisBinding(Self->BindAxis(_p0));
	}

	DOTNET_EXPORT auto E_UInputComponent_ClearActionBindings(UInputComponent* Self)
	{
		Self->ClearActionBindings();
	}

	DOTNET_EXPORT auto E_UInputComponent_ClearBindingValues(UInputComponent* Self)
	{
		Self->ClearBindingValues();
	}

	DOTNET_EXPORT auto E_UInputComponent_ConditionalBuildKeyMap(UInputComponent* Self, UPlayerInput* PlayerInput)
	{
		auto _p0 = PlayerInput;
		Self->ConditionalBuildKeyMap(_p0);
	}

	DOTNET_EXPORT auto E_UInputComponent_GetActionBinding(UInputComponent* Self, int32 BindingIndex)
	{
		auto _p0 = BindingIndex;
		return (INT_PTR) new FInputActionBinding(Self->GetActionBinding(_p0));
	}

	DOTNET_EXPORT auto E_UInputComponent_GetAxisValue(UInputComponent* Self, char* AxisName)
	{
		auto _p0 = ConvertFromManage_FName(AxisName);
		return Self->GetAxisValue(_p0);
	}

	DOTNET_EXPORT auto E_UInputComponent_GetNumActionBindings(UInputComponent* Self)
	{
		return Self->GetNumActionBindings();
	}

	DOTNET_EXPORT auto E_UInputComponent_HasBindings(UInputComponent* Self)
	{
		return Self->HasBindings();
	}

	DOTNET_EXPORT auto E_UInputComponent_RemoveActionBinding(UInputComponent* Self, int32 BindingIndex)
	{
		auto _p0 = BindingIndex;
		Self->RemoveActionBinding(_p0);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
