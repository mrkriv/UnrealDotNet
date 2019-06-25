#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageFloatingPawnMovement.h"
#include "Runtime/Engine/Classes/GameFramework/FloatingPawnMovement.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\FloatingPawnMovement.h:22

class E_PROTECTED_WRAP_UFloatingPawnMovement : protected UFloatingPawnMovement
{
public:
	void ApplyControlInputToVelocity_WRAP(float DeltaTime)
	{
		ApplyControlInputToVelocity(DeltaTime);
	}

	bool LimitWorldBounds_WRAP()
	{
		return LimitWorldBounds();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UFloatingPawnMovement_Acceleration_GET(UFloatingPawnMovement* Ptr) { return Ptr->Acceleration; }
	DOTNET_EXPORT void E_PROP_UFloatingPawnMovement_Acceleration_SET(UFloatingPawnMovement* Ptr, float Value) { Ptr->Acceleration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UFloatingPawnMovement_Deceleration_GET(UFloatingPawnMovement* Ptr) { return Ptr->Deceleration; }
	DOTNET_EXPORT void E_PROP_UFloatingPawnMovement_Deceleration_SET(UFloatingPawnMovement* Ptr, float Value) { Ptr->Deceleration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UFloatingPawnMovement_MaxSpeed_GET(UFloatingPawnMovement* Ptr) { return Ptr->MaxSpeed; }
	DOTNET_EXPORT void E_PROP_UFloatingPawnMovement_MaxSpeed_SET(UFloatingPawnMovement* Ptr, float Value) { Ptr->MaxSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_UFloatingPawnMovement_TurningBoost_GET(UFloatingPawnMovement* Ptr) { return Ptr->TurningBoost; }
	DOTNET_EXPORT void E_PROP_UFloatingPawnMovement_TurningBoost_SET(UFloatingPawnMovement* Ptr, float Value) { Ptr->TurningBoost = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UFloatingPawnMovement(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UFloatingPawnMovement>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UFloatingPawnMovement_ApplyControlInputToVelocity(UFloatingPawnMovement* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((E_PROTECTED_WRAP_UFloatingPawnMovement*)Self)->ApplyControlInputToVelocity_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UFloatingPawnMovement_LimitWorldBounds(UFloatingPawnMovement* Self)
	{
		return ((E_PROTECTED_WRAP_UFloatingPawnMovement*)Self)->LimitWorldBounds_WRAP();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_ApplyControlInputToVelocity(UFloatingPawnMovement* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManageFloatingPawnMovement*)Self)->_Supper__ApplyControlInputToVelocity(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_StopActiveMovement(UNavMovementComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__StopActiveMovement();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnTeleported(UMovementComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__OnTeleported();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_SetPlaneConstraintEnabled(UMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageFloatingPawnMovement*)Self)->_Supper__SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_SnapUpdatedComponentToPlane(UMovementComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_StopMovementImmediately(UMovementComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__StopMovementImmediately();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_UpdateComponentVelocity(UMovementComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_UpdateTickRegistration(UMovementComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageFloatingPawnMovement*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_BeginPlay(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_Deactivate(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageFloatingPawnMovement*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_InitializeComponent(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageFloatingPawnMovement*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnComponentCreated(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageFloatingPawnMovement*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnRegister(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnUnregister(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageFloatingPawnMovement*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageFloatingPawnMovement*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageFloatingPawnMovement*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageFloatingPawnMovement*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageFloatingPawnMovement*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_ToggleActive(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_UninitializeComponent(UActorComponent* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_BeginDestroy(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_FinishDestroy(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_PostCDOContruct(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_PostEditImport(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_PostInitProperties(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_PostLoad(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_PostNetReceive(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_PostRepNotifies(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageFloatingPawnMovement*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_PreDestroyFromReplication(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_PreNetReceive(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_ShutdownAfterError(UObject* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UFloatingPawnMovement_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageFloatingPawnMovement*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
