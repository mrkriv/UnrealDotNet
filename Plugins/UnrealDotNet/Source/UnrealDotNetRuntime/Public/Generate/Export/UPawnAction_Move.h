#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePawnAction_Move.h"
#include "Runtime/AIModule/Classes/Actions/PawnAction_Move.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_Move.h:27

class E_PROTECTED_WRAP_UPawnAction_Move : protected UPawnAction_Move
{
public:
	void ClearPath_WRAP()
	{
		ClearPath();
	}

	void ClearPendingRepath_WRAP()
	{
		ClearPendingRepath();
	}

	void ClearTimers_WRAP()
	{
		ClearTimers();
	}

	void DeferredPerformMoveAction_WRAP()
	{
		DeferredPerformMoveAction();
	}

	bool IsPartialPathAllowed_WRAP()
	{
		return IsPartialPathAllowed();
	}

	bool PerformMoveAction_WRAP()
	{
		return PerformMoveAction();
	}

	void TryToRepath_WRAP()
	{
		TryToRepath();
	}

};


extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnAction_Move(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnAction_Move>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_CheckAlreadyAtGoal(UPawnAction_Move* Self, AAIController& Controller, INT_PTR TestLocation, float Radius)
	{
		auto& _p0 = Controller;
		auto& _p1 = *(FVector*)TestLocation;
		auto _p2 = Radius;
		return Self->CheckAlreadyAtGoal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_CheckAlreadyAtGoal_o1(UPawnAction_Move* Self, AAIController& Controller, AActor& TestGoal, float Radius)
	{
		auto& _p0 = Controller;
		auto& _p1 = TestGoal;
		auto _p2 = Radius;
		return Self->CheckAlreadyAtGoal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_ClearPath(UPawnAction_Move* Self)
	{
		((E_PROTECTED_WRAP_UPawnAction_Move*)Self)->ClearPath_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_ClearPendingRepath(UPawnAction_Move* Self)
	{
		((E_PROTECTED_WRAP_UPawnAction_Move*)Self)->ClearPendingRepath_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_ClearTimers(UPawnAction_Move* Self)
	{
		((E_PROTECTED_WRAP_UPawnAction_Move*)Self)->ClearTimers_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_DeferredPerformMoveAction(UPawnAction_Move* Self)
	{
		((E_PROTECTED_WRAP_UPawnAction_Move*)Self)->DeferredPerformMoveAction_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_EnableChildAbortionOnPathUpdate(UPawnAction_Move* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->EnableChildAbortionOnPathUpdate(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_EnableGoalLocationProjectionToNavigation(UPawnAction_Move* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->EnableGoalLocationProjectionToNavigation(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_EnablePathUpdateOnMoveGoalLocationChange(UPawnAction_Move* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->EnablePathUpdateOnMoveGoalLocationChange(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_EnableStrafing(UPawnAction_Move* Self, bool bNewStrafing)
	{
		auto _p0 = bNewStrafing;
		Self->EnableStrafing(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_IsPartialPathAllowed(UPawnAction_Move* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnAction_Move*)Self)->IsPartialPathAllowed_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_PerformMoveAction(UPawnAction_Move* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnAction_Move*)Self)->PerformMoveAction_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_SetAcceptableRadius(UPawnAction_Move* Self, float NewAcceptableRadius)
	{
		auto _p0 = NewAcceptableRadius;
		Self->SetAcceptableRadius(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_SetAllowPartialPath(UPawnAction_Move* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->SetAllowPartialPath(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_SetFinishOnOverlap(UPawnAction_Move* Self, bool bNewFinishOnOverlap)
	{
		auto _p0 = bNewFinishOnOverlap;
		Self->SetFinishOnOverlap(_p0);
	}

	DOTNET_EXPORT auto E_UPawnAction_Move_TryToRepath(UPawnAction_Move* Self)
	{
		((E_PROTECTED_WRAP_UPawnAction_Move*)Self)->TryToRepath_WRAP();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_Tick(UPawnAction* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManagePawnAction_Move*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_BeginDestroy(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_FinishDestroy(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_PostCDOContruct(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_PostEditImport(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_PostInitProperties(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_PostLoad(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_PostNetReceive(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_PostRepNotifies(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePawnAction_Move*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_PreNetReceive(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_ShutdownAfterError(UObject* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPawnAction_Move_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePawnAction_Move*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
