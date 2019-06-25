#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageInterpToMovementComponent.h"
#include "Runtime/Engine/Classes/Components/InterpToMovementComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:61

class E_PROTECTED_WRAP_UInterpToMovementComponent : protected UInterpToMovementComponent
{
public:
	float CalculateNewTime_WRAP(float TimeNow, float Delta, FHitResult& HitResult, bool InBroadcastEvent, bool& OutStopped, float& OutTimeRemainder)
	{
		return CalculateNewTime(TimeNow, Delta, HitResult, InBroadcastEvent, OutStopped, OutTimeRemainder);
	}

	FVector ComputeMoveDelta_WRAP(float Time)
	{
		return ComputeMoveDelta(Time);
	}

	bool HandleHitWall_WRAP(const FHitResult& Hit, float TimeTick, const FVector& MoveDelta)
	{
		return HandleHitWall(Hit, TimeTick, MoveDelta);
	}

	void ReverseDirection_WRAP(const FHitResult& Hit, float Time, bool InBroadcastEvent)
	{
		ReverseDirection(Hit, Time, InBroadcastEvent);
	}

	void UpdateControlPoints_WRAP(bool InForceUpdate)
	{
		UpdateControlPoints(InForceUpdate);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UInterpToMovementComponent_BehaviourType_GET(UInterpToMovementComponent* Ptr) { return Ptr->BehaviourType; }
	DOTNET_EXPORT void E_PROP_UInterpToMovementComponent_BehaviourType_SET(UInterpToMovementComponent* Ptr, EInterpToBehaviourType Value) { Ptr->BehaviourType = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInterpToMovementComponent_Duration_GET(UInterpToMovementComponent* Ptr) { return Ptr->Duration; }
	DOTNET_EXPORT void E_PROP_UInterpToMovementComponent_Duration_SET(UInterpToMovementComponent* Ptr, float Value) { Ptr->Duration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInterpToMovementComponent_MaxSimulationIterations_GET(UInterpToMovementComponent* Ptr) { return Ptr->MaxSimulationIterations; }
	DOTNET_EXPORT void E_PROP_UInterpToMovementComponent_MaxSimulationIterations_SET(UInterpToMovementComponent* Ptr, int32 Value) { Ptr->MaxSimulationIterations = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInterpToMovementComponent_MaxSimulationTimeStep_GET(UInterpToMovementComponent* Ptr) { return Ptr->MaxSimulationTimeStep; }
	DOTNET_EXPORT void E_PROP_UInterpToMovementComponent_MaxSimulationTimeStep_SET(UInterpToMovementComponent* Ptr, float Value) { Ptr->MaxSimulationTimeStep = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInterpToMovementComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInterpToMovementComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_AddControlPointPosition(UInterpToMovementComponent* Self, INT_PTR Pos, bool bPositionIsRelative)
	{
		auto _p0 = *(FVector*)Pos;
		auto _p1 = bPositionIsRelative;
		Self->AddControlPointPosition(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CalculateNewTime(UInterpToMovementComponent* Self, float TimeNow, float Delta, INT_PTR HitResult, bool InBroadcastEvent, bool OutStopped, float OutTimeRemainder)
	{
		auto _p0 = TimeNow;
		auto _p1 = Delta;
		auto& _p2 = *(FHitResult*)HitResult;
		auto _p3 = InBroadcastEvent;
		auto& _p4 = OutStopped;
		auto& _p5 = OutTimeRemainder;
		return ((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->CalculateNewTime_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_CheckStillInWorld(UInterpToMovementComponent* Self)
	{
		return Self->CheckStillInWorld();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ComputeMoveDelta(UInterpToMovementComponent* Self, float Time)
	{
		auto _p0 = Time;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->ComputeMoveDelta_WRAP(_p0));
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_FinaliseControlPoints(UInterpToMovementComponent* Self)
	{
		Self->FinaliseControlPoints();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_GetSimulationTimeStep(UInterpToMovementComponent* Self, float RemainingTime, int32 Iterations)
	{
		auto _p0 = RemainingTime;
		auto _p1 = Iterations;
		return Self->GetSimulationTimeStep(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_HandleHitWall(UInterpToMovementComponent* Self, INT_PTR Hit, float TimeTick, INT_PTR MoveDelta)
	{
		auto& _p0 = *(FHitResult*)Hit;
		auto _p1 = TimeTick;
		auto& _p2 = *(FVector*)MoveDelta;
		return ((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->HandleHitWall_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_HasStoppedSimulation(UInterpToMovementComponent* Self)
	{
		return Self->HasStoppedSimulation();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ResetControlPoints(UInterpToMovementComponent* Self)
	{
		Self->ResetControlPoints();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_RestartMovement(UInterpToMovementComponent* Self, float InitialDirection)
	{
		auto _p0 = InitialDirection;
		Self->RestartMovement(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ReverseDirection(UInterpToMovementComponent* Self, INT_PTR Hit, float Time, bool InBroadcastEvent)
	{
		auto& _p0 = *(FHitResult*)Hit;
		auto _p1 = Time;
		auto _p2 = InBroadcastEvent;
		((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->ReverseDirection_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_ShouldUseSubStepping(UInterpToMovementComponent* Self)
	{
		return Self->ShouldUseSubStepping();
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_StopSimulating(UInterpToMovementComponent* Self, INT_PTR HitResult)
	{
		auto& _p0 = *(FHitResult*)HitResult;
		Self->StopSimulating(_p0);
	}

	DOTNET_EXPORT auto E_UInterpToMovementComponent_UpdateControlPoints(UInterpToMovementComponent* Self, bool InForceUpdate)
	{
		auto _p0 = InForceUpdate;
		((E_PROTECTED_WRAP_UInterpToMovementComponent*)Self)->UpdateControlPoints_WRAP(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_UpdateControlPoints(UInterpToMovementComponent* Self, bool InForceUpdate)
	{
		auto _p0 = InForceUpdate;
		((UManageInterpToMovementComponent*)Self)->_Supper__UpdateControlPoints(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnTeleported(UMovementComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__OnTeleported();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_SetPlaneConstraintEnabled(UMovementComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageInterpToMovementComponent*)Self)->_Supper__SetPlaneConstraintEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_SnapUpdatedComponentToPlane(UMovementComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__SnapUpdatedComponentToPlane();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_StopMovementImmediately(UMovementComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__StopMovementImmediately();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_UpdateComponentVelocity(UMovementComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__UpdateComponentVelocity();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_UpdateTickRegistration(UMovementComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__UpdateTickRegistration();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageInterpToMovementComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_Deactivate(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageInterpToMovementComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageInterpToMovementComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageInterpToMovementComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnRegister(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageInterpToMovementComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageInterpToMovementComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageInterpToMovementComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageInterpToMovementComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageInterpToMovementComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_BeginDestroy(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_FinishDestroy(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_PostCDOContruct(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_PostEditImport(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_PostInitProperties(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_PostLoad(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_PostNetReceive(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_PostRepNotifies(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageInterpToMovementComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_PreNetReceive(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UInterpToMovementComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageInterpToMovementComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
