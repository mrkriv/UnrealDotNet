#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/ActorComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ActorComponent.h:91

class E_PROTECTED_WRAP_UActorComponent : protected UActorComponent
{
public:
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

	void SendRenderDynamicData_Concurrent_WRAP()
	{
		SendRenderDynamicData_Concurrent();
	}

	bool ShouldActivate_WRAP()
	{
		return ShouldActivate();
	}

}
;

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_GET(UActorComponent* Ptr) { return Ptr->bAllowAnyoneToDestroyMe; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bAllowAnyoneToDestroyMe_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bAllowAnyoneToDestroyMe = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bAllowConcurrentTick_GET(UActorComponent* Ptr) { return Ptr->bAllowConcurrentTick; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bAllowConcurrentTick_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bAllowConcurrentTick = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bAutoActivate_GET(UActorComponent* Ptr) { return Ptr->bAutoActivate; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bAutoActivate_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bAutoActivate = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bAutoRegister_GET(UActorComponent* Ptr) { return Ptr->bAutoRegister; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bAutoRegister_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bAutoRegister = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bEditableWhenInherited_GET(UActorComponent* Ptr) { return Ptr->bEditableWhenInherited; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bEditableWhenInherited_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bEditableWhenInherited = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bIsActive_GET(UActorComponent* Ptr) { return Ptr->bIsActive; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bIsActive_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bIsActive = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bIsEditorOnly_GET(UActorComponent* Ptr) { return Ptr->bIsEditorOnly; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bIsEditorOnly_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bIsEditorOnly = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bNavigationRelevant_GET(UActorComponent* Ptr) { return Ptr->bNavigationRelevant; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bNavigationRelevant_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bNavigationRelevant = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bNeverNeedsRenderUpdate_GET(UActorComponent* Ptr) { return Ptr->bNeverNeedsRenderUpdate; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bNeverNeedsRenderUpdate_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bNeverNeedsRenderUpdate = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bTickInEditor_GET(UActorComponent* Ptr) { return Ptr->bTickInEditor; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bTickInEditor_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bTickInEditor = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bWantsBeginPlay_GET(UActorComponent* Ptr) { return Ptr->bWantsBeginPlay; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bWantsBeginPlay_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bWantsBeginPlay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_bWantsInitializeComponent_GET(UActorComponent* Ptr) { return Ptr->bWantsInitializeComponent; }
	DOTNET_EXPORT void E_PROP_UActorComponent_bWantsInitializeComponent_SET(UActorComponent* Ptr, uint8 Value) { Ptr->bWantsInitializeComponent = Value; }
	
	DOTNET_EXPORT auto E_PROP_UActorComponent_CreationMethod_GET(UActorComponent* Ptr) { return Ptr->CreationMethod; }
	DOTNET_EXPORT void E_PROP_UActorComponent_CreationMethod_SET(UActorComponent* Ptr, EComponentCreationMethod Value) { Ptr->CreationMethod = Value; }
	
	DOTNET_EXPORT void E_EVENT_ADD_UActorComponent_OnComponentActivated(UActorComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentActivated";
		wrapper->SourceObject = Obj;
		Obj->OnComponentActivated.AddDynamic(wrapper, &UManageEventSender::Wrapper_FActorComponentActivatedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UActorComponent_OnComponentActivated(UActorComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UActorComponent_OnComponentDeactivated(UActorComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentDeactivated";
		wrapper->SourceObject = Obj;
		Obj->OnComponentDeactivated.AddDynamic(wrapper, &UManageEventSender::Wrapper_FActorComponentDeactivateSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UActorComponent_OnComponentDeactivated(UActorComponent* Obj)
	{
	}

	DOTNET_EXPORT auto E_PROP_UActorComponent_PrimaryComponentTick_GET(UActorComponent* Ptr) { return (INT_PTR)&(Ptr->PrimaryComponentTick); }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UActorComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UActorComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UActorComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_AddTickPrerequisiteActor(UActorComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_AddTickPrerequisiteComponent(UActorComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_AllowReregistration(UActorComponent* Self)
	{
		return Self->AllowReregistration();
	}

	DOTNET_EXPORT auto E_UActorComponent_ApplyWorldOffset(UActorComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UActorComponent_BeginDestroy(UActorComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UActorComponent_BeginPlay(UActorComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UActorComponent_CanEverAffectNavigation(UActorComponent* Self)
	{
		return Self->CanEverAffectNavigation();
	}

	DOTNET_EXPORT auto E_UActorComponent_ClearNeedEndOfFrameUpdate(UActorComponent* Self)
	{
		Self->ClearNeedEndOfFrameUpdate();
	}

	DOTNET_EXPORT auto E_UActorComponent_ComponentHasTag(UActorComponent* Self, char* Tag)
	{
		auto _p0 = ConvertFromManage_FName(Tag);
		return Self->ComponentHasTag(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_ComponentIsInPersistentLevel(UActorComponent* Self, bool bIncludeLevelStreamingPersistent)
	{
		auto _p0 = bIncludeLevelStreamingPersistent;
		return Self->ComponentIsInPersistentLevel(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_CreatePhysicsState(UActorComponent* Self)
	{
		Self->CreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UActorComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UActorComponent_Deactivate(UActorComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UActorComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_DestroyPhysicsState(UActorComponent* Self)
	{
		Self->DestroyPhysicsState();
	}

	DOTNET_EXPORT auto E_UActorComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UActorComponent_DetermineUCSModifiedProperties(UActorComponent* Self)
	{
		Self->DetermineUCSModifiedProperties();
	}

	DOTNET_EXPORT auto E_UActorComponent_DoDeferredRenderUpdates_Concurrent(UActorComponent* Self)
	{
		Self->DoDeferredRenderUpdates_Concurrent();
	}

	DOTNET_EXPORT auto E_UActorComponent_GetComponentClassCanReplicate(UActorComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UActorComponent_GetComponentTickInterval(UActorComponent* Self)
	{
		return Self->GetComponentTickInterval();
	}

	DOTNET_EXPORT auto E_UActorComponent_GetIsReplicated(UActorComponent* Self)
	{
		return Self->GetIsReplicated();
	}

	DOTNET_EXPORT auto E_UActorComponent_GetNetMode(UActorComponent* Self)
	{
		return Self->GetNetMode();
	}

	DOTNET_EXPORT auto E_UActorComponent_GetOwner(UActorComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetOwner());
	}

	DOTNET_EXPORT auto E_UActorComponent_GetOwnerRole(UActorComponent* Self)
	{
		return Self->GetOwnerRole();
	}

	DOTNET_EXPORT auto E_UActorComponent_GetReadableName(UActorComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UActorComponent_GetWorld(UActorComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_UActorComponent_HandleCanEverAffectNavigationChange(UActorComponent* Self, bool bForceUpdate)
	{
		auto _p0 = bForceUpdate;
		((E_PROTECTED_WRAP_UActorComponent*)Self)->HandleCanEverAffectNavigationChange_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_HasBeenCreated(UActorComponent* Self)
	{
		return Self->HasBeenCreated();
	}

	DOTNET_EXPORT auto E_UActorComponent_HasBeenInitialized(UActorComponent* Self)
	{
		return Self->HasBeenInitialized();
	}

	DOTNET_EXPORT auto E_UActorComponent_HasBegunPlay(UActorComponent* Self)
	{
		return Self->HasBegunPlay();
	}

	DOTNET_EXPORT auto E_UActorComponent_HasValidPhysicsState(UActorComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UActorComponent_InitializeComponent(UActorComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UActorComponent_InvalidateLightingCache(UActorComponent* Self)
	{
		Self->InvalidateLightingCache();
	}

	DOTNET_EXPORT auto E_UActorComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UActorComponent_IsActive(UActorComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsBeingDestroyed(UActorComponent* Self)
	{
		return Self->IsBeingDestroyed();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsComponentTickEnabled(UActorComponent* Self)
	{
		return Self->IsComponentTickEnabled();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsCreatedByConstructionScript(UActorComponent* Self)
	{
		return Self->IsCreatedByConstructionScript();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsEditableWhenInherited(UActorComponent* Self)
	{
		return Self->IsEditableWhenInherited();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsEditorOnly(UActorComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsNameStableForNetworking(UActorComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsNavigationRelevant(UActorComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsNetMode(UActorComponent* Self, ENetMode Mode)
	{
		auto _p0 = Mode;
		return Self->IsNetMode(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_IsNetSimulating(UActorComponent* Self)
	{
		return Self->IsNetSimulating();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsNetStartupComponent(UActorComponent* Self)
	{
		return Self->IsNetStartupComponent();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsOwnerRunningUserConstructionScript(UActorComponent* Self)
	{
		return Self->IsOwnerRunningUserConstructionScript();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsOwnerSelected(UActorComponent* Self)
	{
		return Self->IsOwnerSelected();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsPhysicsStateCreated(UActorComponent* Self)
	{
		return Self->IsPhysicsStateCreated();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsReadyForOwnerToAutoDestroy(UActorComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsRegistered(UActorComponent* Self)
	{
		return Self->IsRegistered();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsRenderStateCreated(UActorComponent* Self)
	{
		return Self->IsRenderStateCreated();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsRenderStateDirty(UActorComponent* Self)
	{
		return Self->IsRenderStateDirty();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsRenderTransformDirty(UActorComponent* Self)
	{
		return Self->IsRenderTransformDirty();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsSupportedForNetworking(UActorComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UActorComponent_K2_DestroyComponent(UActorComponent* Self, UObject* Object)
	{
		auto _p0 = Object;
		Self->K2_DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_MarkAsEditorOnlySubobject(UActorComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UActorComponent_MarkForNeededEndOfFrameRecreate(UActorComponent* Self)
	{
		Self->MarkForNeededEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UActorComponent_MarkForNeededEndOfFrameUpdate(UActorComponent* Self)
	{
		Self->MarkForNeededEndOfFrameUpdate();
	}

	DOTNET_EXPORT auto E_UActorComponent_MarkRenderDynamicDataDirty(UActorComponent* Self)
	{
		Self->MarkRenderDynamicDataDirty();
	}

	DOTNET_EXPORT auto E_UActorComponent_MarkRenderStateDirty(UActorComponent* Self)
	{
		Self->MarkRenderStateDirty();
	}

	DOTNET_EXPORT auto E_UActorComponent_MarkRenderTransformDirty(UActorComponent* Self)
	{
		Self->MarkRenderTransformDirty();
	}

	DOTNET_EXPORT auto E_UActorComponent_NeedsLoadForClient(UActorComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UActorComponent_NeedsLoadForEditorGame(UActorComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UActorComponent_NeedsLoadForServer(UActorComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UActorComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UActorComponent_OnComponentCreated(UActorComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UActorComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UActorComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UActorComponent_OnRegister(UActorComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UActorComponent_OnRep_IsActive(UActorComponent* Self)
	{
		Self->OnRep_IsActive();
	}

	DOTNET_EXPORT auto E_UActorComponent_OnUnregister(UActorComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UActorComponent_PostInitProperties(UActorComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UActorComponent_PostLoad(UActorComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UActorComponent_PostNetReceive(UActorComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UActorComponent_PostRename(UActorComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UActorComponent_PreNetReceive(UActorComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UActorComponent_ReceiveBeginPlay(UActorComponent* Self)
	{
		Self->ReceiveBeginPlay();
	}

	DOTNET_EXPORT auto E_UActorComponent_ReceiveTick(UActorComponent* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		Self->ReceiveTick(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_RecreatePhysicsState(UActorComponent* Self)
	{
		Self->RecreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UActorComponent_RecreateRenderState_Concurrent(UActorComponent* Self)
	{
		Self->RecreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UActorComponent_RegisterAllComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterAllComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_RegisterComponent(UActorComponent* Self)
	{
		Self->RegisterComponent();
	}

	DOTNET_EXPORT auto E_UActorComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_RegisterComponentWithWorld(UActorComponent* Self, UWorld* InWorld)
	{
		auto _p0 = InWorld;
		Self->RegisterComponentWithWorld(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_RemoveTickPrerequisiteActor(UActorComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_RemoveTickPrerequisiteComponent(UActorComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_RequiresGameThreadEndOfFrameRecreate(UActorComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UActorComponent_RequiresGameThreadEndOfFrameUpdates(UActorComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UActorComponent_ReregisterComponent(UActorComponent* Self)
	{
		Self->ReregisterComponent();
	}

	DOTNET_EXPORT auto E_UActorComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((E_PROTECTED_WRAP_UActorComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UActorComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UActorComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UActorComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_SetCanEverAffectNavigation(UActorComponent* Self, bool bRelevant)
	{
		auto _p0 = bRelevant;
		Self->SetCanEverAffectNavigation(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_SetComponentTickInterval(UActorComponent* Self, float TickInterval)
	{
		auto _p0 = TickInterval;
		Self->SetComponentTickInterval(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_SetIsNetStartupComponent(UActorComponent* Self, bool bInIsNetStartupComponent)
	{
		auto _p0 = bInIsNetStartupComponent;
		Self->SetIsNetStartupComponent(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_SetIsReplicated(UActorComponent* Self, bool ShouldReplicate)
	{
		auto _p0 = ShouldReplicate;
		Self->SetIsReplicated(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_SetNetAddressable(UActorComponent* Self)
	{
		Self->SetNetAddressable();
	}

	DOTNET_EXPORT auto E_UActorComponent_SetTickableWhenPaused(UActorComponent* Self, bool bTickableWhenPaused)
	{
		auto _p0 = bTickableWhenPaused;
		Self->SetTickableWhenPaused(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_SetTickGroup(UActorComponent* Self, ETickingGroup NewTickGroup)
	{
		auto _p0 = NewTickGroup;
		Self->SetTickGroup(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_ShouldActivate(UActorComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UActorComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UActorComponent_ShouldCreatePhysicsState(UActorComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UActorComponent_ShouldCreateRenderState(UActorComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UActorComponent_ToggleActive(UActorComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UActorComponent_UninitializeComponent(UActorComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UActorComponent_UnregisterComponent(UActorComponent* Self)
	{
		Self->UnregisterComponent();
	}

	DOTNET_EXPORT auto E_UActorComponent_UpdateComponentToWorld(UActorComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateComponentToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UActorComponent_AreNativePropertiesIdenticalTo(UActorComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_CheckDefaultSubobjectsInternal(UActorComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UActorComponent_FinishDestroy(UActorComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UActorComponent_GetDesc(UActorComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UActorComponent_GetDetailedInfoInternal(UActorComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UActorComponent_IsAsset(UActorComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsFullNameStableForNetworking(UActorComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsLocalizedResource(UActorComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsPostLoadThreadSafe(UActorComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsReadyForFinishDestroy(UActorComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UActorComponent_IsSafeForRootSet(UActorComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UActorComponent_Modify(UActorComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_NotifyObjectReferenceEliminated(UActorComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UActorComponent_PostCDOContruct(UActorComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UActorComponent_PostEditImport(UActorComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UActorComponent_PostRepNotifies(UActorComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UActorComponent_PostSaveRoot(UActorComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UActorComponent_PreDestroyFromReplication(UActorComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UActorComponent_ShutdownAfterError(UActorComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UActorComponent_AddToCluster(UActorComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UActorComponent_CanBeClusterRoot(UActorComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UActorComponent_CanBeInCluster(UActorComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UActorComponent_CreateCluster(UActorComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UActorComponent_OnClusterMarkedAsPendingKill(UActorComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
