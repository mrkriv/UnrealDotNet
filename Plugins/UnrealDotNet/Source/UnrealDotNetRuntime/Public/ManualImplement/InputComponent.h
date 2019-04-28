#pragma once

#include "CoreMinimal.h"
#include "CoreShell.h"
#include "DotnetMetadata.h"
#include "Runtime/Engine/Classes/Components/InputComponent.h"

extern "C"
{
	DOTNET_EXPORT void E_UInputComponent_BindAction(UInputComponent* Self, unsigned int EventId, char* ActionName, const EInputEvent KeyEvent)
	{
		auto actionName = UTF8_TO_TCHAR(ActionName);

		FInputActionBinding binding(actionName, KeyEvent);

		binding.ActionDelegate.GetDelegateForManualSet().BindLambda([EventId]() {
			UCoreShell::GetInstance()->InvokeEventById(EventId);
		});

		Self->AddActionBinding(MoveTemp(binding));
	}

	DOTNET_EXPORT void E_UInputComponent_BindAxis_Event(UInputComponent* Self, unsigned int EventId, char* AxisName)
	{
		auto axisName = UTF8_TO_TCHAR(AxisName);

		FInputAxisBinding binding(axisName);
		
		binding.AxisDelegate.GetDelegateForManualSet().BindLambda([EventId](float value) {
			UCoreShell::GetInstance()->InvokeEventById(EventId, value);
		});

		Self->AxisBindings.Emplace(MoveTemp(binding));
	}
}