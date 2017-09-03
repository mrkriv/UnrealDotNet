#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "Components/ActorComponent.h"

class E_PROTECTED_WRAP_UActorComponent : protected UActorComponent
{
public:
	void CreateRenderState_Concurrent_WRAP()
	{
		CreateRenderState_Concurrent();
	}

	void DestroyRenderState_Concurrent_WRAP()
	{
		DestroyRenderState_Concurrent();
	}

	void HandleCanEverAffectNavigationChange_WRAP(bool bForceUpdate)
	{
		HandleCanEverAffectNavigationChange(bForceUpdate);
	}

	void OnCreatePhysicsState_WRAP()
	{
		OnCreatePhysicsState();
	}

	void OnDestroyPhysicsState_WRAP()
	{
		OnDestroyPhysicsState();
	}

	void OnRegister_WRAP()
	{
		OnRegister();
	}

	void OnUnregister_WRAP()
	{
		OnUnregister();
	}

	void RegisterComponentTickFunctions_WRAP(bool bRegister)
	{
		RegisterComponentTickFunctions(bRegister);
	}

	void SendRenderDynamicData_Concurrent_WRAP()
	{
		SendRenderDynamicData_Concurrent();
	}

	void SendRenderTransform_Concurrent_WRAP()
	{
		SendRenderTransform_Concurrent();
	}

}
;

extern "C"
{
	DOTNET_EXPORT INT_PTR E_PROP_UActorComponent_PrimaryComponentTick_GET(INT_PTR Ptr) { return (INT_PTR) new FActorComponentTickFunction(((UActorComponent*)Ptr)->PrimaryComponentTick); }
	
	DOTNET_EXPORT void E_UActorComponent_Activate(INT_PTR Self, bool bReset)
	{
		auto _p0 = bReset;
		((UActorComponent*)Self)->Activate(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_AddTickPrerequisiteActor(INT_PTR Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		((UActorComponent*)Self)->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_AddTickPrerequisiteComponent(INT_PTR Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		((UActorComponent*)Self)->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT bool E_UActorComponent_AllowReregistration(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->AllowReregistration();
	}

	DOTNET_EXPORT void E_UActorComponent_ApplyWorldOffset(INT_PTR Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		((UActorComponent*)Self)->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT void E_UActorComponent_BeginPlay(INT_PTR Self)
	{
		((UActorComponent*)Self)->BeginPlay();
	}

	DOTNET_EXPORT bool E_UActorComponent_CanEverAffectNavigation(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->CanEverAffectNavigation();
	}

	DOTNET_EXPORT bool E_UActorComponent_ComponentHasTag(INT_PTR Self, char* Tag)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(Tag));
		return ((UActorComponent*)Self)->ComponentHasTag(_p0);
	}

	DOTNET_EXPORT bool E_UActorComponent_ComponentIsInPersistentLevel(INT_PTR Self, bool bIncludeLevelStreamingPersistent)
	{
		auto _p0 = bIncludeLevelStreamingPersistent;
		return ((UActorComponent*)Self)->ComponentIsInPersistentLevel(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_CreatePhysicsState(INT_PTR Self)
	{
		((UActorComponent*)Self)->CreatePhysicsState();
	}

	DOTNET_EXPORT void E_UActorComponent_CreateRenderState_Concurrent(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->CreateRenderState_Concurrent_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_Deactivate(INT_PTR Self)
	{
		((UActorComponent*)Self)->Deactivate();
	}

	DOTNET_EXPORT void E_UActorComponent_DestroyComponent(INT_PTR Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UActorComponent*)Self)->DestroyComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_DestroyPhysicsState(INT_PTR Self)
	{
		((UActorComponent*)Self)->DestroyPhysicsState();
	}

	DOTNET_EXPORT void E_UActorComponent_DestroyRenderState_Concurrent(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->DestroyRenderState_Concurrent_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_DetermineUCSModifiedProperties(INT_PTR Self)
	{
		((UActorComponent*)Self)->DetermineUCSModifiedProperties();
	}

	DOTNET_EXPORT void E_UActorComponent_DoDeferredRenderUpdates_Concurrent(INT_PTR Self)
	{
		((UActorComponent*)Self)->DoDeferredRenderUpdates_Concurrent();
	}

	DOTNET_EXPORT float E_UActorComponent_GetComponentTickInterval(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->GetComponentTickInterval();
	}

	DOTNET_EXPORT bool E_UActorComponent_GetIsReplicated(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->GetIsReplicated();
	}

	DOTNET_EXPORT AActor* E_UActorComponent_GetOwner(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->GetOwner();
	}

	DOTNET_EXPORT void E_UActorComponent_HandleCanEverAffectNavigationChange(INT_PTR Self, bool bForceUpdate)
	{
		auto _p0 = bForceUpdate;
		((E_PROTECTED_WRAP_UActorComponent*)Self)->HandleCanEverAffectNavigationChange_WRAP(_p0);
	}

	DOTNET_EXPORT bool E_UActorComponent_HasBeenCreated(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->HasBeenCreated();
	}

	DOTNET_EXPORT bool E_UActorComponent_HasBeenInitialized(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->HasBeenInitialized();
	}

	DOTNET_EXPORT bool E_UActorComponent_HasBegunPlay(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->HasBegunPlay();
	}

	DOTNET_EXPORT void E_UActorComponent_InitializeComponent(INT_PTR Self)
	{
		((UActorComponent*)Self)->InitializeComponent();
	}

	DOTNET_EXPORT void E_UActorComponent_InvalidateLightingCache(INT_PTR Self)
	{
		((UActorComponent*)Self)->InvalidateLightingCache();
	}

	DOTNET_EXPORT void E_UActorComponent_InvalidateLightingCacheDetailed(INT_PTR Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UActorComponent*)Self)->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UActorComponent_IsBeingDestroyed(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsBeingDestroyed();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsComponentTickEnabled(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsComponentTickEnabled();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsCreatedByConstructionScript(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsCreatedByConstructionScript();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsEditableWhenInherited(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsEditableWhenInherited();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsNetSimulating(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsNetSimulating();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsNetStartupComponent(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsNetStartupComponent();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsOwnerRunningUserConstructionScript(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsOwnerRunningUserConstructionScript();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsOwnerSelected(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsOwnerSelected();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsPhysicsStateCreated(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsPhysicsStateCreated();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsRegistered(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsRegistered();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsRenderStateCreated(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsRenderStateCreated();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsRenderStateDirty(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsRenderStateDirty();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsRenderTransformDirty(INT_PTR Self)
	{
		return ((UActorComponent*)Self)->IsRenderTransformDirty();
	}

	DOTNET_EXPORT void E_UActorComponent_K2_DestroyComponent(INT_PTR Self, UObject* Object)
	{
		auto _p0 = Object;
		((UActorComponent*)Self)->K2_DestroyComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_MarkForNeededEndOfFrameRecreate(INT_PTR Self)
	{
		((UActorComponent*)Self)->MarkForNeededEndOfFrameRecreate();
	}

	DOTNET_EXPORT void E_UActorComponent_MarkForNeededEndOfFrameUpdate(INT_PTR Self)
	{
		((UActorComponent*)Self)->MarkForNeededEndOfFrameUpdate();
	}

	DOTNET_EXPORT void E_UActorComponent_MarkRenderDynamicDataDirty(INT_PTR Self)
	{
		((UActorComponent*)Self)->MarkRenderDynamicDataDirty();
	}

	DOTNET_EXPORT void E_UActorComponent_MarkRenderStateDirty(INT_PTR Self)
	{
		((UActorComponent*)Self)->MarkRenderStateDirty();
	}

	DOTNET_EXPORT void E_UActorComponent_MarkRenderTransformDirty(INT_PTR Self)
	{
		((UActorComponent*)Self)->MarkRenderTransformDirty();
	}

	DOTNET_EXPORT void E_UActorComponent_OnActorEnableCollisionChanged(INT_PTR Self)
	{
		((UActorComponent*)Self)->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT void E_UActorComponent_OnComponentCreated(INT_PTR Self)
	{
		((UActorComponent*)Self)->OnComponentCreated();
	}

	DOTNET_EXPORT void E_UActorComponent_OnComponentDestroyed(INT_PTR Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UActorComponent*)Self)->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_OnCreatePhysicsState(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_OnDestroyPhysicsState(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_OnRegister(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnRegister_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_OnRep_IsActive(INT_PTR Self)
	{
		((UActorComponent*)Self)->OnRep_IsActive();
	}

	DOTNET_EXPORT void E_UActorComponent_OnUnregister(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnUnregister_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_ReceiveTick(INT_PTR Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((UActorComponent*)Self)->ReceiveTick(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RecreatePhysicsState(INT_PTR Self)
	{
		((UActorComponent*)Self)->RecreatePhysicsState();
	}

	DOTNET_EXPORT void E_UActorComponent_RecreateRenderState_Concurrent(INT_PTR Self)
	{
		((UActorComponent*)Self)->RecreateRenderState_Concurrent();
	}

	DOTNET_EXPORT void E_UActorComponent_RegisterAllComponentTickFunctions(INT_PTR Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UActorComponent*)Self)->RegisterAllComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RegisterComponent(INT_PTR Self)
	{
		((UActorComponent*)Self)->RegisterComponent();
	}

	DOTNET_EXPORT void E_UActorComponent_RegisterComponentTickFunctions(INT_PTR Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((E_PROTECTED_WRAP_UActorComponent*)Self)->RegisterComponentTickFunctions_WRAP(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RegisterComponentWithWorld(INT_PTR Self, UWorld* InWorld)
	{
		auto _p0 = InWorld;
		((UActorComponent*)Self)->RegisterComponentWithWorld(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RemoveTickPrerequisiteActor(INT_PTR Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		((UActorComponent*)Self)->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RemoveTickPrerequisiteComponent(INT_PTR Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		((UActorComponent*)Self)->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_ReregisterComponent(INT_PTR Self)
	{
		((UActorComponent*)Self)->ReregisterComponent();
	}

	DOTNET_EXPORT void E_UActorComponent_SendRenderDynamicData_Concurrent(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_SendRenderTransform_Concurrent(INT_PTR Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->SendRenderTransform_Concurrent_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_SetActive(INT_PTR Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UActorComponent*)Self)->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT void E_UActorComponent_SetAutoActivate(INT_PTR Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UActorComponent*)Self)->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetCanEverAffectNavigation(INT_PTR Self, bool bRelevant)
	{
		auto _p0 = bRelevant;
		((UActorComponent*)Self)->SetCanEverAffectNavigation(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetComponentTickEnabled(INT_PTR Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UActorComponent*)Self)->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetComponentTickEnabledAsync(INT_PTR Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UActorComponent*)Self)->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetComponentTickInterval(INT_PTR Self, float TickInterval)
	{
		auto _p0 = TickInterval;
		((UActorComponent*)Self)->SetComponentTickInterval(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetIsNetStartupComponent(INT_PTR Self, bool bInIsNetStartupComponent)
	{
		auto _p0 = bInIsNetStartupComponent;
		((UActorComponent*)Self)->SetIsNetStartupComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetIsReplicated(INT_PTR Self, bool ShouldReplicate)
	{
		auto _p0 = ShouldReplicate;
		((UActorComponent*)Self)->SetIsReplicated(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetNetAddressable(INT_PTR Self)
	{
		((UActorComponent*)Self)->SetNetAddressable();
	}

	DOTNET_EXPORT void E_UActorComponent_SetTickableWhenPaused(INT_PTR Self, bool bTickableWhenPaused)
	{
		auto _p0 = bTickableWhenPaused;
		((UActorComponent*)Self)->SetTickableWhenPaused(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_ToggleActive(INT_PTR Self)
	{
		((UActorComponent*)Self)->ToggleActive();
	}

	DOTNET_EXPORT void E_UActorComponent_UninitializeComponent(INT_PTR Self)
	{
		((UActorComponent*)Self)->UninitializeComponent();
	}

	DOTNET_EXPORT void E_UActorComponent_UnregisterComponent(INT_PTR Self)
	{
		((UActorComponent*)Self)->UnregisterComponent();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
