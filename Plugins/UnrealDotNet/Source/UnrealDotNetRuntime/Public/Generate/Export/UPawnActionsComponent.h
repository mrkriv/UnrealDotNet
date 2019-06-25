#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePawnActionsComponent.h"
#include "Runtime/AIModule/Classes/Actions/PawnActionsComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnActionsComponent.h:78

class E_PROTECTED_WRAP_UPawnActionsComponent : protected UPawnActionsComponent
{
public:
	APawn* CacheControlledPawn_WRAP()
	{
		return CacheControlledPawn();
	}

	void UpdateAILogicLock_WRAP()
	{
		UpdateAILogicLock();
	}

	void UpdateCurrentAction_WRAP()
	{
		UpdateCurrentAction();
	}

};


extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnActionsComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnActionsComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnActionsComponent_CacheControlledPawn(UPawnActionsComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(((E_PROTECTED_WRAP_UPawnActionsComponent*)Self)->CacheControlledPawn_WRAP());
	}

	DOTNET_EXPORT auto E_UPawnActionsComponent_GetActionEventsQueueSize(UPawnActionsComponent* Self)
	{
		return Self->GetActionEventsQueueSize();
	}

	DOTNET_EXPORT auto E_UPawnActionsComponent_GetControlledPawn(UPawnActionsComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetControlledPawn());
	}

	DOTNET_EXPORT auto E_UPawnActionsComponent_GetController(UPawnActionsComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetController());
	}

	DOTNET_EXPORT auto E_UPawnActionsComponent_GetCurrentAction(UPawnActionsComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetCurrentAction());
	}

	DOTNET_EXPORT auto E_UPawnActionsComponent_SetControlledPawn(UPawnActionsComponent* Self, APawn* NewPawn)
	{
		auto _p0 = NewPawn;
		Self->SetControlledPawn(_p0);
	}

	DOTNET_EXPORT auto E_UPawnActionsComponent_UpdateAILogicLock(UPawnActionsComponent* Self)
	{
		((E_PROTECTED_WRAP_UPawnActionsComponent*)Self)->UpdateAILogicLock_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnActionsComponent_UpdateCurrentAction(UPawnActionsComponent* Self)
	{
		((E_PROTECTED_WRAP_UPawnActionsComponent*)Self)->UpdateCurrentAction_WRAP();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManagePawnActionsComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_BeginPlay(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_Deactivate(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManagePawnActionsComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManagePawnActionsComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManagePawnActionsComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_OnRegister(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_OnUnregister(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManagePawnActionsComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManagePawnActionsComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManagePawnActionsComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManagePawnActionsComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManagePawnActionsComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_ToggleActive(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_BeginDestroy(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_FinishDestroy(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_PostCDOContruct(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_PostEditImport(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_PostInitProperties(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_PostLoad(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_PostNetReceive(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_PostRepNotifies(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePawnActionsComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_PreNetReceive(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_ShutdownAfterError(UObject* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPawnActionsComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePawnActionsComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
