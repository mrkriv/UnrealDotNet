#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/AIModule/Classes/Actions/PawnAction.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction.h:47

class E_PROTECTED_WRAP_UPawnAction : protected UPawnAction
{
public:
	bool Activate_WRAP()
	{
		return Activate();
	}

	UPawnActionsComponent* GetOwnerComponent_WRAP()
	{
		return GetOwnerComponent();
	}

	bool HasBeenStarted_WRAP()
	{
		return HasBeenStarted();
	}

	void OnPopped_WRAP()
	{
		OnPopped();
	}

	bool Pause_WRAP(const UPawnAction* PausedBy)
	{
		return Pause(PausedBy);
	}

	bool PushChildAction_WRAP(UPawnAction& Action)
	{
		return PushChildAction(Action);
	}

	bool Resume_WRAP()
	{
		return Resume();
	}

	void SetOwnerComponent_WRAP(UPawnActionsComponent* Component)
	{
		SetOwnerComponent(Component);
	}

	bool Start_WRAP()
	{
		return Start();
	}

	void StopWaitingForMessages_WRAP()
	{
		StopWaitingForMessages();
	}

	void Tick_WRAP(float DeltaTime)
	{
		Tick(DeltaTime);
	}

	void TickAction_WRAP(float DeltaTime)
	{
		TickAction(DeltaTime);
	}

};


extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnAction(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnAction>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnAction_Activate(UPawnAction* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnAction*)Self)->Activate_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_GetChildAction(UPawnAction* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetChildAction());
	}

	DOTNET_EXPORT auto E_UPawnAction_GetController(UPawnAction* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetController());
	}

	DOTNET_EXPORT auto E_UPawnAction_GetDisplayName(UPawnAction* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDisplayName());
	}

	DOTNET_EXPORT auto E_UPawnAction_GetInstigator(UPawnAction* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetInstigator());
	}

	DOTNET_EXPORT auto E_UPawnAction_GetOwnerComponent(UPawnAction* Self)
	{
		return ConvertToManage_ObjectPointerDescription(((E_PROTECTED_WRAP_UPawnAction*)Self)->GetOwnerComponent_WRAP());
	}

	DOTNET_EXPORT auto E_UPawnAction_GetParentAction(UPawnAction* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetParentAction());
	}

	DOTNET_EXPORT auto E_UPawnAction_GetPawn(UPawnAction* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetPawn());
	}

	DOTNET_EXPORT auto E_UPawnAction_GetPriorityName(UPawnAction* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetPriorityName());
	}

	DOTNET_EXPORT auto E_UPawnAction_GetStateDescription(UPawnAction* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetStateDescription());
	}

	DOTNET_EXPORT auto E_UPawnAction_HasActionObserver(UPawnAction* Self)
	{
		return Self->HasActionObserver();
	}

	DOTNET_EXPORT auto E_UPawnAction_HasBeenStarted(UPawnAction* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnAction*)Self)->HasBeenStarted_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_IsActive(UPawnAction* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UPawnAction_IsBeingAborted(UPawnAction* Self)
	{
		return Self->IsBeingAborted();
	}

	DOTNET_EXPORT auto E_UPawnAction_IsFinished(UPawnAction* Self)
	{
		return Self->IsFinished();
	}

	DOTNET_EXPORT auto E_UPawnAction_IsPaused(UPawnAction* Self)
	{
		return Self->IsPaused();
	}

	DOTNET_EXPORT auto E_UPawnAction_OnPopped(UPawnAction* Self)
	{
		((E_PROTECTED_WRAP_UPawnAction*)Self)->OnPopped_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_Pause(UPawnAction* Self, UPawnAction* PausedBy)
	{
		auto _p0 = PausedBy;
		return ((E_PROTECTED_WRAP_UPawnAction*)Self)->Pause_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_PushChildAction(UPawnAction* Self, UPawnAction& Action)
	{
		auto& _p0 = Action;
		return ((E_PROTECTED_WRAP_UPawnAction*)Self)->PushChildAction_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_Resume(UPawnAction* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnAction*)Self)->Resume_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_SetOwnerComponent(UPawnAction* Self, UPawnActionsComponent* Component)
	{
		auto _p0 = Component;
		((E_PROTECTED_WRAP_UPawnAction*)Self)->SetOwnerComponent_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_ShouldPauseMovement(UPawnAction* Self)
	{
		return Self->ShouldPauseMovement();
	}

	DOTNET_EXPORT auto E_UPawnAction_Start(UPawnAction* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnAction*)Self)->Start_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_StopWaitingForMessages(UPawnAction* Self)
	{
		((E_PROTECTED_WRAP_UPawnAction*)Self)->StopWaitingForMessages_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_Tick(UPawnAction* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((E_PROTECTED_WRAP_UPawnAction*)Self)->Tick_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_TickAction(UPawnAction* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((E_PROTECTED_WRAP_UPawnAction*)Self)->TickAction_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_WantsTick(UPawnAction* Self)
	{
		return Self->WantsTick();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
