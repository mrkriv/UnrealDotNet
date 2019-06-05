#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageSpectatorPawnMovement.h"
#include "Runtime/Engine/Classes/GameFramework/SpectatorPawnMovement.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawnMovement.h:15

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_USpectatorPawnMovement(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USpectatorPawnMovement>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_ApplyControlInputToVelocity(UFloatingPawnMovement* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManageSpectatorPawnMovement*)Self)->_Supper__ApplyControlInputToVelocity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_StopActiveMovement(UNavMovementComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__StopActiveMovement();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnTeleported(UMovementComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnTeleported();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_SetPlaneConstraintEnabled(UMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSpectatorPawnMovement*)Self)->_Supper__SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_SnapUpdatedComponentToPlane(UMovementComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_StopMovementImmediately(UMovementComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__StopMovementImmediately();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_UpdateComponentVelocity(UMovementComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_UpdateTickRegistration(UMovementComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageSpectatorPawnMovement*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_BeginPlay(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_Deactivate(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageSpectatorPawnMovement*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_InitializeComponent(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageSpectatorPawnMovement*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnComponentCreated(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnRegister(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnUnregister(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageSpectatorPawnMovement*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageSpectatorPawnMovement*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageSpectatorPawnMovement*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSpectatorPawnMovement*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSpectatorPawnMovement*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_ToggleActive(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_UninitializeComponent(UActorComponent* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_BeginDestroy(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_FinishDestroy(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_PostCDOContruct(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_PostEditImport(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_PostInitProperties(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_PostLoad(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_PostNetReceive(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_PostRepNotifies(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageSpectatorPawnMovement*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_PreDestroyFromReplication(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_PreNetReceive(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_ShutdownAfterError(UObject* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__USpectatorPawnMovement_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageSpectatorPawnMovement*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
