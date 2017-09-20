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
	DOTNET_EXPORT EComponentCreationMethod E_PROP_UActorComponent_CreationMethod_GET(INT_PTR Ptr) { return ((UActorComponent*)Ptr)->CreationMethod; }
	DOTNET_EXPORT void E_PROP_UActorComponent_CreationMethod_SET(INT_PTR Ptr, EComponentCreationMethod Value) { ((UActorComponent*)Ptr)->CreationMethod = Value; }
	
	DOTNET_EXPORT INT_PTR E_PROP_UActorComponent_PrimaryComponentTick_GET(INT_PTR Ptr) { return (INT_PTR)&((UActorComponent*)Ptr)->PrimaryComponentTick; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UActorComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UActorComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT void E_UActorComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		(Self)->Activate(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_AddTickPrerequisiteActor(UActorComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		(Self)->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_AddTickPrerequisiteComponent(UActorComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		(Self)->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT bool E_UActorComponent_AllowReregistration(UActorComponent* Self)
	{
		return (Self)->AllowReregistration();
	}

	DOTNET_EXPORT void E_UActorComponent_ApplyWorldOffset(UActorComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		(Self)->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT void E_UActorComponent_BeginPlay(UActorComponent* Self)
	{
		(Self)->BeginPlay();
	}

	DOTNET_EXPORT bool E_UActorComponent_CanEverAffectNavigation(UActorComponent* Self)
	{
		return (Self)->CanEverAffectNavigation();
	}

	DOTNET_EXPORT bool E_UActorComponent_ComponentHasTag(UActorComponent* Self, char* Tag)
	{
		auto _p0 = FName(UTF8_TO_TCHAR(Tag));
		return (Self)->ComponentHasTag(_p0);
	}

	DOTNET_EXPORT bool E_UActorComponent_ComponentIsInPersistentLevel(UActorComponent* Self, bool bIncludeLevelStreamingPersistent)
	{
		auto _p0 = bIncludeLevelStreamingPersistent;
		return (Self)->ComponentIsInPersistentLevel(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_CreatePhysicsState(UActorComponent* Self)
	{
		(Self)->CreatePhysicsState();
	}

	DOTNET_EXPORT void E_UActorComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->CreateRenderState_Concurrent_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_Deactivate(UActorComponent* Self)
	{
		(Self)->Deactivate();
	}

	DOTNET_EXPORT void E_UActorComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		(Self)->DestroyComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_DestroyPhysicsState(UActorComponent* Self)
	{
		(Self)->DestroyPhysicsState();
	}

	DOTNET_EXPORT void E_UActorComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->DestroyRenderState_Concurrent_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_DetermineUCSModifiedProperties(UActorComponent* Self)
	{
		(Self)->DetermineUCSModifiedProperties();
	}

	DOTNET_EXPORT void E_UActorComponent_DoDeferredRenderUpdates_Concurrent(UActorComponent* Self)
	{
		(Self)->DoDeferredRenderUpdates_Concurrent();
	}

	DOTNET_EXPORT float E_UActorComponent_GetComponentTickInterval(UActorComponent* Self)
	{
		return (Self)->GetComponentTickInterval();
	}

	DOTNET_EXPORT bool E_UActorComponent_GetIsReplicated(UActorComponent* Self)
	{
		return (Self)->GetIsReplicated();
	}

	DOTNET_EXPORT ENetMode E_UActorComponent_GetNetMode(UActorComponent* Self)
	{
		return (Self)->GetNetMode();
	}

	DOTNET_EXPORT ObjectPointerDescription E_UActorComponent_GetOwner(UActorComponent* Self)
	{
		return MakePrtDesc((Self)->GetOwner());
	}

	DOTNET_EXPORT void E_UActorComponent_HandleCanEverAffectNavigationChange(UActorComponent* Self, bool bForceUpdate)
	{
		auto _p0 = bForceUpdate;
		((E_PROTECTED_WRAP_UActorComponent*)Self)->HandleCanEverAffectNavigationChange_WRAP(_p0);
	}

	DOTNET_EXPORT bool E_UActorComponent_HasBeenCreated(UActorComponent* Self)
	{
		return (Self)->HasBeenCreated();
	}

	DOTNET_EXPORT bool E_UActorComponent_HasBeenInitialized(UActorComponent* Self)
	{
		return (Self)->HasBeenInitialized();
	}

	DOTNET_EXPORT bool E_UActorComponent_HasBegunPlay(UActorComponent* Self)
	{
		return (Self)->HasBegunPlay();
	}

	DOTNET_EXPORT void E_UActorComponent_InitializeComponent(UActorComponent* Self)
	{
		(Self)->InitializeComponent();
	}

	DOTNET_EXPORT void E_UActorComponent_InvalidateLightingCache(UActorComponent* Self)
	{
		(Self)->InvalidateLightingCache();
	}

	DOTNET_EXPORT void E_UActorComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		(Self)->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT bool E_UActorComponent_IsBeingDestroyed(UActorComponent* Self)
	{
		return (Self)->IsBeingDestroyed();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsComponentTickEnabled(UActorComponent* Self)
	{
		return (Self)->IsComponentTickEnabled();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsCreatedByConstructionScript(UActorComponent* Self)
	{
		return (Self)->IsCreatedByConstructionScript();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsEditableWhenInherited(UActorComponent* Self)
	{
		return (Self)->IsEditableWhenInherited();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsNetMode(UActorComponent* Self, ENetMode Mode)
	{
		auto _p0 = Mode;
		return (Self)->IsNetMode(_p0);
	}

	DOTNET_EXPORT bool E_UActorComponent_IsNetSimulating(UActorComponent* Self)
	{
		return (Self)->IsNetSimulating();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsNetStartupComponent(UActorComponent* Self)
	{
		return (Self)->IsNetStartupComponent();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsOwnerRunningUserConstructionScript(UActorComponent* Self)
	{
		return (Self)->IsOwnerRunningUserConstructionScript();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsOwnerSelected(UActorComponent* Self)
	{
		return (Self)->IsOwnerSelected();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsPhysicsStateCreated(UActorComponent* Self)
	{
		return (Self)->IsPhysicsStateCreated();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsRegistered(UActorComponent* Self)
	{
		return (Self)->IsRegistered();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsRenderStateCreated(UActorComponent* Self)
	{
		return (Self)->IsRenderStateCreated();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsRenderStateDirty(UActorComponent* Self)
	{
		return (Self)->IsRenderStateDirty();
	}

	DOTNET_EXPORT bool E_UActorComponent_IsRenderTransformDirty(UActorComponent* Self)
	{
		return (Self)->IsRenderTransformDirty();
	}

	DOTNET_EXPORT void E_UActorComponent_K2_DestroyComponent(UActorComponent* Self, UObject* Object)
	{
		auto _p0 = Object;
		(Self)->K2_DestroyComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_MarkForNeededEndOfFrameRecreate(UActorComponent* Self)
	{
		(Self)->MarkForNeededEndOfFrameRecreate();
	}

	DOTNET_EXPORT void E_UActorComponent_MarkForNeededEndOfFrameUpdate(UActorComponent* Self)
	{
		(Self)->MarkForNeededEndOfFrameUpdate();
	}

	DOTNET_EXPORT void E_UActorComponent_MarkRenderDynamicDataDirty(UActorComponent* Self)
	{
		(Self)->MarkRenderDynamicDataDirty();
	}

	DOTNET_EXPORT void E_UActorComponent_MarkRenderStateDirty(UActorComponent* Self)
	{
		(Self)->MarkRenderStateDirty();
	}

	DOTNET_EXPORT void E_UActorComponent_MarkRenderTransformDirty(UActorComponent* Self)
	{
		(Self)->MarkRenderTransformDirty();
	}

	DOTNET_EXPORT void E_UActorComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		(Self)->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT void E_UActorComponent_OnComponentCreated(UActorComponent* Self)
	{
		(Self)->OnComponentCreated();
	}

	DOTNET_EXPORT void E_UActorComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		(Self)->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_OnRegister(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnRegister_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_OnRep_IsActive(UActorComponent* Self)
	{
		(Self)->OnRep_IsActive();
	}

	DOTNET_EXPORT void E_UActorComponent_OnUnregister(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnUnregister_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_ReceiveBeginPlay(UActorComponent* Self)
	{
		(Self)->ReceiveBeginPlay();
	}

	DOTNET_EXPORT void E_UActorComponent_ReceiveTick(UActorComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		(Self)->ReceiveTick(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RecreatePhysicsState(UActorComponent* Self)
	{
		(Self)->RecreatePhysicsState();
	}

	DOTNET_EXPORT void E_UActorComponent_RecreateRenderState_Concurrent(UActorComponent* Self)
	{
		(Self)->RecreateRenderState_Concurrent();
	}

	DOTNET_EXPORT void E_UActorComponent_RegisterAllComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		(Self)->RegisterAllComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RegisterComponent(UActorComponent* Self)
	{
		(Self)->RegisterComponent();
	}

	DOTNET_EXPORT void E_UActorComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((E_PROTECTED_WRAP_UActorComponent*)Self)->RegisterComponentTickFunctions_WRAP(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RegisterComponentWithWorld(UActorComponent* Self, UWorld* InWorld)
	{
		auto _p0 = InWorld;
		(Self)->RegisterComponentWithWorld(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RemoveTickPrerequisiteActor(UActorComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		(Self)->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_RemoveTickPrerequisiteComponent(UActorComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		(Self)->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_ReregisterComponent(UActorComponent* Self)
	{
		(Self)->ReregisterComponent();
	}

	DOTNET_EXPORT void E_UActorComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->SendRenderTransform_Concurrent_WRAP();
	}

	DOTNET_EXPORT void E_UActorComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		(Self)->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT void E_UActorComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		(Self)->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetCanEverAffectNavigation(UActorComponent* Self, bool bRelevant)
	{
		auto _p0 = bRelevant;
		(Self)->SetCanEverAffectNavigation(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		(Self)->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		(Self)->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetComponentTickInterval(UActorComponent* Self, float TickInterval)
	{
		auto _p0 = TickInterval;
		(Self)->SetComponentTickInterval(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetIsNetStartupComponent(UActorComponent* Self, bool bInIsNetStartupComponent)
	{
		auto _p0 = bInIsNetStartupComponent;
		(Self)->SetIsNetStartupComponent(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetIsReplicated(UActorComponent* Self, bool ShouldReplicate)
	{
		auto _p0 = ShouldReplicate;
		(Self)->SetIsReplicated(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetNetAddressable(UActorComponent* Self)
	{
		(Self)->SetNetAddressable();
	}

	DOTNET_EXPORT void E_UActorComponent_SetTickableWhenPaused(UActorComponent* Self, bool bTickableWhenPaused)
	{
		auto _p0 = bTickableWhenPaused;
		(Self)->SetTickableWhenPaused(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_SetTickGroup(UActorComponent* Self, ETickingGroup NewTickGroup)
	{
		auto _p0 = NewTickGroup;
		(Self)->SetTickGroup(_p0);
	}

	DOTNET_EXPORT void E_UActorComponent_ToggleActive(UActorComponent* Self)
	{
		(Self)->ToggleActive();
	}

	DOTNET_EXPORT void E_UActorComponent_UninitializeComponent(UActorComponent* Self)
	{
		(Self)->UninitializeComponent();
	}

	DOTNET_EXPORT void E_UActorComponent_UnregisterComponent(UActorComponent* Self)
	{
		(Self)->UnregisterComponent();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
