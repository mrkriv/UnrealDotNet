#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageBrainComponent.h"
#include "Runtime/AIModule/Classes/BrainComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BrainComponent.h:117

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UBrainComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UBrainComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UBrainComponent_Cleanup(UBrainComponent* Self)
	{
		Self->Cleanup();
	}

	DOTNET_EXPORT auto E_UBrainComponent_GetAIOwner(UBrainComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetAIOwner());
	}

	DOTNET_EXPORT auto E_UBrainComponent_GetDebugInfoString(UBrainComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDebugInfoString());
	}

	DOTNET_EXPORT auto E_UBrainComponent_IsPaused(UBrainComponent* Self)
	{
		return Self->IsPaused();
	}

	DOTNET_EXPORT auto E_UBrainComponent_IsRunning(UBrainComponent* Self)
	{
		return Self->IsRunning();
	}

	DOTNET_EXPORT auto E_UBrainComponent_PauseLogic(UBrainComponent* Self, char* Reason)
	{
		auto _p0 = ConvertFromManage_FString(Reason);
		Self->PauseLogic(_p0);
	}

	DOTNET_EXPORT auto E_UBrainComponent_RequestLogicRestartOnUnlock(UBrainComponent* Self)
	{
		Self->RequestLogicRestartOnUnlock();
	}

	DOTNET_EXPORT auto E_UBrainComponent_RestartLogic(UBrainComponent* Self)
	{
		Self->RestartLogic();
	}

	DOTNET_EXPORT auto E_UBrainComponent_StopLogic(UBrainComponent* Self, char* Reason)
	{
		auto _p0 = ConvertFromManage_FString(Reason);
		Self->StopLogic(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_Cleanup(UBrainComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__Cleanup();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_RestartLogic(UBrainComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__RestartLogic();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageBrainComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_Deactivate(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageBrainComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageBrainComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageBrainComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_OnRegister(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageBrainComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageBrainComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageBrainComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageBrainComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageBrainComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_BeginDestroy(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_FinishDestroy(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_PostCDOContruct(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_PostEditImport(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_PostInitProperties(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_PostLoad(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_PostNetReceive(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_PostRepNotifies(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageBrainComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_PreNetReceive(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UBrainComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageBrainComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
