#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/AudioComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:108

class E_PROTECTED_WRAP_UAudioComponent : protected UAudioComponent
{
public:
	void PlayInternal_WRAP(const float StartTime, const float FadeInDuration, const float FadeVolumeLevel)
	{
		PlayInternal(StartTime, FadeInDuration, FadeVolumeLevel);
	}

	bool MoveComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		return MoveComponentImpl(Delta, NewRotation, bSweep, Hit, MoveFlags, Teleport);
	}

	void OnChildAttached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildAttached(ChildComponent);
	}

	void OnChildDetached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildDetached(ChildComponent);
	}

	void OnHiddenInGameChanged_WRAP()
	{
		OnHiddenInGameChanged();
	}

	void OnVisibilityChanged_WRAP()
	{
		OnVisibilityChanged();
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
	DOTNET_EXPORT auto E_PROP_UAudioComponent_AutoAttachLocationRule_GET(UAudioComponent* Ptr) { return Ptr->AutoAttachLocationRule; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_AutoAttachLocationRule_SET(UAudioComponent* Ptr, EAttachmentRule Value) { Ptr->AutoAttachLocationRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_AutoAttachRotationRule_GET(UAudioComponent* Ptr) { return Ptr->AutoAttachRotationRule; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_AutoAttachRotationRule_SET(UAudioComponent* Ptr, EAttachmentRule Value) { Ptr->AutoAttachRotationRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_AutoAttachScaleRule_GET(UAudioComponent* Ptr) { return Ptr->AutoAttachScaleRule; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_AutoAttachScaleRule_SET(UAudioComponent* Ptr, EAttachmentRule Value) { Ptr->AutoAttachScaleRule = Value; }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_AutoAttachSocketName_GET(UAudioComponent* Ptr) { return ConvertToManage_StringWrapper(Ptr->AutoAttachSocketName); }
	DOTNET_EXPORT void E_PROP_UAudioComponent_AutoAttachSocketName_SET(UAudioComponent* Ptr, char* Value) { Ptr->AutoAttachSocketName = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_UAudioComponent_bAutoManageAttachment_GET(UAudioComponent* Ptr) { return Ptr->bAutoManageAttachment; }
	DOTNET_EXPORT void E_PROP_UAudioComponent_bAutoManageAttachment_SET(UAudioComponent* Ptr, uint8 Value) { Ptr->bAutoManageAttachment = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UAudioComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UAudioComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UAudioComponent_Activate(UAudioComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_BeginDestroy(UAudioComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UAudioComponent_Deactivate(UAudioComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetAudioComponentUserID(UAudioComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetAudioComponentUserID());
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetDetailedInfoInternal(UAudioComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsReadyForOwnerToAutoDestroy(UAudioComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnRegister(UAudioComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnUnregister(UAudioComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnUpdateTransform(UAudioComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_PlayInternal(UAudioComponent* Self, float StartTime, float FadeInDuration, float FadeVolumeLevel)
	{
		auto _p0 = StartTime;
		auto _p1 = FadeInDuration;
		auto _p2 = FadeVolumeLevel;
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->PlayInternal_WRAP(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UAudioComponent_PostLoad(UAudioComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetSoundParameter(UAudioComponent* Self, INT_PTR Param)
	{
		auto _p0 = *(FAudioComponentParam*)Param;
		Self->SetSoundParameter(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_ApplyWorldOffset(UAudioComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_CalcBoundingCylinder(UAudioComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_CanAttachAsChild(UAudioComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_DestroyComponent(UAudioComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_DetachFromComponent(UAudioComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_DetachFromParent(UAudioComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_DoesSocketExist(UAudioComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetCollisionObjectType(UAudioComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetCollisionResponseToChannel(UAudioComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetComponentVelocity(UAudioComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetSocketLocation(UAudioComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetSocketQuaternion(UAudioComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetSocketRotation(UAudioComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetSocketTransform(UAudioComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UAudioComponent_HasAnySockets(UAudioComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsAnySimulatingPhysics(UAudioComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsPrecomputedLightingValid(UAudioComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsSimulatingPhysics(UAudioComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsVisible(UAudioComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsVisibleInEditor(UAudioComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsWorldGeometry(UAudioComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UAudioComponent_MoveComponentImpl(UAudioComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR Hit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)Hit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UAudioComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnAttachmentChanged(UAudioComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnChildAttached(UAudioComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnChildDetached(UAudioComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnComponentDestroyed(UAudioComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnHiddenInGameChanged(UAudioComponent* Self)
	{
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnVisibilityChanged(UAudioComponent* Self)
	{
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UAudioComponent_PostNetReceive(UAudioComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UAudioComponent_PostRepNotifies(UAudioComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UAudioComponent_PreNetReceive(UAudioComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UAudioComponent_PropagateLightingScenarioChange(UAudioComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetRelativeScale3D(UAudioComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_ShouldCollideWhenPlacing(UAudioComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UAudioComponent_ShouldCreateRenderState(UAudioComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UAudioComponent_UpdatePhysicsVolume(UAudioComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_AddTickPrerequisiteActor(UAudioComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_AddTickPrerequisiteComponent(UAudioComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_BeginPlay(UAudioComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UAudioComponent_CreateRenderState_Concurrent(UAudioComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UAudioComponent_DestroyRenderState_Concurrent(UAudioComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetComponentClassCanReplicate(UAudioComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetReadableName(UAudioComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UAudioComponent_HasValidPhysicsState(UAudioComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UAudioComponent_InitializeComponent(UAudioComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UAudioComponent_InvalidateLightingCacheDetailed(UAudioComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsActive(UAudioComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsEditorOnly(UAudioComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsNameStableForNetworking(UAudioComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsNavigationRelevant(UAudioComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsSupportedForNetworking(UAudioComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UAudioComponent_MarkAsEditorOnlySubobject(UAudioComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UAudioComponent_NeedsLoadForClient(UAudioComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UAudioComponent_NeedsLoadForEditorGame(UAudioComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UAudioComponent_NeedsLoadForServer(UAudioComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnActorEnableCollisionChanged(UAudioComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnComponentCreated(UAudioComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnCreatePhysicsState(UAudioComponent* Self)
	{
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnDestroyPhysicsState(UAudioComponent* Self)
	{
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UAudioComponent_PostInitProperties(UAudioComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UAudioComponent_PostRename(UAudioComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_RegisterComponentTickFunctions(UAudioComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_RemoveTickPrerequisiteActor(UAudioComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_RemoveTickPrerequisiteComponent(UAudioComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_RequiresGameThreadEndOfFrameRecreate(UAudioComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UAudioComponent_RequiresGameThreadEndOfFrameUpdates(UAudioComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UAudioComponent_SendRenderDynamicData_Concurrent(UAudioComponent* Self)
	{
		((E_PROTECTED_WRAP_UAudioComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UAudioComponent_SendRenderTransform_Concurrent(UAudioComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetActive(UAudioComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetAutoActivate(UAudioComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetComponentTickEnabled(UAudioComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_SetComponentTickEnabledAsync(UAudioComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_ShouldActivate(UAudioComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UAudioComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UAudioComponent_ShouldCreatePhysicsState(UAudioComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UAudioComponent_ToggleActive(UAudioComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UAudioComponent_UninitializeComponent(UAudioComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UAudioComponent_AreNativePropertiesIdenticalTo(UAudioComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_CheckDefaultSubobjectsInternal(UAudioComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UAudioComponent_FinishDestroy(UAudioComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UAudioComponent_GetDesc(UAudioComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsAsset(UAudioComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsFullNameStableForNetworking(UAudioComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsLocalizedResource(UAudioComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsPostLoadThreadSafe(UAudioComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsReadyForFinishDestroy(UAudioComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UAudioComponent_IsSafeForRootSet(UAudioComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UAudioComponent_Modify(UAudioComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_NotifyObjectReferenceEliminated(UAudioComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UAudioComponent_PostCDOContruct(UAudioComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UAudioComponent_PostEditImport(UAudioComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UAudioComponent_PostSaveRoot(UAudioComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UAudioComponent_PreDestroyFromReplication(UAudioComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UAudioComponent_ShutdownAfterError(UAudioComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UAudioComponent_AddToCluster(UAudioComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UAudioComponent_CanBeClusterRoot(UAudioComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UAudioComponent_CanBeInCluster(UAudioComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UAudioComponent_CreateCluster(UAudioComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UAudioComponent_OnClusterMarkedAsPendingKill(UAudioComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
