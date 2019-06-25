#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageRotatingMovementComponent.h"
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

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnTeleported(UMovementComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__OnTeleported();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_SetPlaneConstraintEnabled(UMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageRotatingMovementComponent*)Self)->_Supper__SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_SnapUpdatedComponentToPlane(UMovementComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_StopMovementImmediately(UMovementComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__StopMovementImmediately();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_UpdateComponentVelocity(UMovementComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_UpdateTickRegistration(UMovementComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageRotatingMovementComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_Deactivate(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageRotatingMovementComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageRotatingMovementComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageRotatingMovementComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnRegister(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageRotatingMovementComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageRotatingMovementComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageRotatingMovementComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageRotatingMovementComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageRotatingMovementComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_BeginDestroy(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_FinishDestroy(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_PostCDOContruct(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_PostEditImport(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_PostInitProperties(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_PostLoad(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_PostNetReceive(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_PostRepNotifies(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageRotatingMovementComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_PreNetReceive(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__URotatingMovementComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageRotatingMovementComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
