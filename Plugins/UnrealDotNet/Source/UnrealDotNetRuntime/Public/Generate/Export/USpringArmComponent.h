#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageSpringArmComponent.h"
#include "Runtime/Engine/Classes/GameFramework/SpringArmComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

class E_PROTECTED_WRAP_USpringArmComponent : protected USpringArmComponent
{
public:
	FVector BlendLocations_WRAP(const FVector& DesiredArmLocation, const FVector& TraceHitLocation, bool bHitSomething, float DeltaTime)
	{
		return BlendLocations(DesiredArmLocation, TraceHitLocation, bHitSomething, DeltaTime);
	}

	void UpdateDesiredArmLocation_WRAP(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		UpdateDesiredArmLocation(bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_bIsCameraFixed_GET(USpringArmComponent* Ptr) { return Ptr->bIsCameraFixed; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_bIsCameraFixed_SET(USpringArmComponent* Ptr, bool Value) { Ptr->bIsCameraFixed = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_CameraLagMaxDistance_GET(USpringArmComponent* Ptr) { return Ptr->CameraLagMaxDistance; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_CameraLagMaxDistance_SET(USpringArmComponent* Ptr, float Value) { Ptr->CameraLagMaxDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_CameraLagMaxTimeStep_GET(USpringArmComponent* Ptr) { return Ptr->CameraLagMaxTimeStep; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_CameraLagMaxTimeStep_SET(USpringArmComponent* Ptr, float Value) { Ptr->CameraLagMaxTimeStep = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_CameraLagSpeed_GET(USpringArmComponent* Ptr) { return Ptr->CameraLagSpeed; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_CameraLagSpeed_SET(USpringArmComponent* Ptr, float Value) { Ptr->CameraLagSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_CameraRotationLagSpeed_GET(USpringArmComponent* Ptr) { return Ptr->CameraRotationLagSpeed; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_CameraRotationLagSpeed_SET(USpringArmComponent* Ptr, float Value) { Ptr->CameraRotationLagSpeed = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_PreviousArmOrigin_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->PreviousArmOrigin); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_PreviousArmOrigin_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->PreviousArmOrigin = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_PreviousDesiredLoc_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->PreviousDesiredLoc); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_PreviousDesiredLoc_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->PreviousDesiredLoc = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_PreviousDesiredRot_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->PreviousDesiredRot); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_PreviousDesiredRot_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->PreviousDesiredRot = *(FRotator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_ProbeSize_GET(USpringArmComponent* Ptr) { return Ptr->ProbeSize; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_ProbeSize_SET(USpringArmComponent* Ptr, float Value) { Ptr->ProbeSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_SocketOffset_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->SocketOffset); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_SocketOffset_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->SocketOffset = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_TargetArmLength_GET(USpringArmComponent* Ptr) { return Ptr->TargetArmLength; }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_TargetArmLength_SET(USpringArmComponent* Ptr, float Value) { Ptr->TargetArmLength = Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_TargetOffset_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->TargetOffset); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_TargetOffset_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->TargetOffset = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_USpringArmComponent_UnfixedCameraPosition_GET(USpringArmComponent* Ptr) { return (INT_PTR)&(Ptr->UnfixedCameraPosition); }
	DOTNET_EXPORT void E_PROP_USpringArmComponent_UnfixedCameraPosition_SET(USpringArmComponent* Ptr, INT_PTR Value) { Ptr->UnfixedCameraPosition = *(FVector*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_USpringArmComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<USpringArmComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_BlendLocations(USpringArmComponent* Self, INT_PTR DesiredArmLocation, INT_PTR TraceHitLocation, bool bHitSomething, float DeltaTime)
	{
		auto& _p0 = *(FVector*)DesiredArmLocation;
		auto& _p1 = *(FVector*)TraceHitLocation;
		auto _p2 = bHitSomething;
		auto _p3 = DeltaTime;
		return (INT_PTR) new FVector(((E_PROTECTED_WRAP_USpringArmComponent*)Self)->BlendLocations_WRAP(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetTargetRotation(USpringArmComponent* Self)
	{
		return (INT_PTR) new FRotator(Self->GetTargetRotation());
	}

	DOTNET_EXPORT auto E_USpringArmComponent_GetUnfixedCameraPosition(USpringArmComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetUnfixedCameraPosition());
	}

	DOTNET_EXPORT auto E_USpringArmComponent_IsCollisionFixApplied(USpringArmComponent* Self)
	{
		return Self->IsCollisionFixApplied();
	}

	DOTNET_EXPORT auto E_USpringArmComponent_UpdateDesiredArmLocation(USpringArmComponent* Self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		auto _p0 = bDoTrace;
		auto _p1 = bDoLocationLag;
		auto _p2 = bDoRotationLag;
		auto _p3 = DeltaTime;
		((E_PROTECTED_WRAP_USpringArmComponent*)Self)->UpdateDesiredArmLocation_WRAP(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_UpdateDesiredArmLocation(USpringArmComponent* Self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
	{
		auto _p0 = bDoTrace;
		auto _p1 = bDoLocationLag;
		auto _p2 = bDoRotationLag;
		auto _p3 = DeltaTime;
		((UManageSpringArmComponent*)Self)->_Supper__UpdateDesiredArmLocation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageSpringArmComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageSpringArmComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageSpringArmComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_Deactivate(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageSpringArmComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageSpringArmComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageSpringArmComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnRegister(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageSpringArmComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageSpringArmComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageSpringArmComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSpringArmComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageSpringArmComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_BeginDestroy(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_FinishDestroy(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PostCDOContruct(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PostEditImport(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PostInitProperties(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PostLoad(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PostNetReceive(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PostRepNotifies(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageSpringArmComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_PreNetReceive(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__USpringArmComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageSpringArmComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
