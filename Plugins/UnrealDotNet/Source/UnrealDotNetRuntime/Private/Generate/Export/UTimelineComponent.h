#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/TimelineComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\TimelineComponent.h:391

class E_PROTECTED_WRAP_UTimelineComponent : protected UTimelineComponent
{
public:
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
	
	DOTNET_EXPORT INT_PTR E_NewObject_UTimelineComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UTimelineComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UTimelineComponent_Activate(UTimelineComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_Deactivate(UTimelineComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetIgnoreTimeDilation(UTimelineComponent* Self)
	{
		return Self->GetIgnoreTimeDilation();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetPlaybackPosition(UTimelineComponent* Self)
	{
		return Self->GetPlaybackPosition();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetPlayRate(UTimelineComponent* Self)
	{
		return Self->GetPlayRate();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetTimelineLength(UTimelineComponent* Self)
	{
		return Self->GetTimelineLength();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsLooping(UTimelineComponent* Self)
	{
		return Self->IsLooping();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsPlaying(UTimelineComponent* Self)
	{
		return Self->IsPlaying();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsReadyForOwnerToAutoDestroy(UTimelineComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsReversing(UTimelineComponent* Self)
	{
		return Self->IsReversing();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_Play(UTimelineComponent* Self)
	{
		Self->Play();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PlayFromStart(UTimelineComponent* Self)
	{
		Self->PlayFromStart();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_Reverse(UTimelineComponent* Self)
	{
		Self->Reverse();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_ReverseFromEnd(UTimelineComponent* Self)
	{
		Self->ReverseFromEnd();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetDirectionPropertyName(UTimelineComponent* Self, char* DirectionPropertyName)
	{
		auto _p0 = ConvertFromManage_FName(DirectionPropertyName);
		Self->SetDirectionPropertyName(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetIgnoreTimeDilation(UTimelineComponent* Self, bool bNewIgnoreTimeDilation)
	{
		auto _p0 = bNewIgnoreTimeDilation;
		Self->SetIgnoreTimeDilation(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetLooping(UTimelineComponent* Self, bool bNewLooping)
	{
		auto _p0 = bNewLooping;
		Self->SetLooping(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetNewTime(UTimelineComponent* Self, float NewTime)
	{
		auto _p0 = NewTime;
		Self->SetNewTime(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetPlaybackPosition(UTimelineComponent* Self, float NewPosition, bool bFireEvents, bool bFireUpdate)
	{
		auto _p0 = NewPosition;
		auto _p1 = bFireEvents;
		auto _p2 = bFireUpdate;
		Self->SetPlaybackPosition(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetPlayRate(UTimelineComponent* Self, float NewRate)
	{
		auto _p0 = NewRate;
		Self->SetPlayRate(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetPropertySetObject(UTimelineComponent* Self, UObject* NewPropertySetObject)
	{
		auto _p0 = NewPropertySetObject;
		Self->SetPropertySetObject(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetTimelineLength(UTimelineComponent* Self, float NewLength)
	{
		auto _p0 = NewLength;
		Self->SetTimelineLength(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetTimelineLengthMode(UTimelineComponent* Self, ETimelineLengthMode NewLengthMode)
	{
		auto _p0 = NewLengthMode;
		Self->SetTimelineLengthMode(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_Stop(UTimelineComponent* Self)
	{
		Self->Stop();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_AddTickPrerequisiteActor(UTimelineComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_AddTickPrerequisiteComponent(UTimelineComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_ApplyWorldOffset(UTimelineComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_BeginDestroy(UTimelineComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_BeginPlay(UTimelineComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_CreateRenderState_Concurrent(UTimelineComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_DestroyComponent(UTimelineComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_DestroyRenderState_Concurrent(UTimelineComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetComponentClassCanReplicate(UTimelineComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetReadableName(UTimelineComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UTimelineComponent_HasValidPhysicsState(UTimelineComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_InitializeComponent(UTimelineComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_InvalidateLightingCacheDetailed(UTimelineComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsActive(UTimelineComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsEditorOnly(UTimelineComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsNameStableForNetworking(UTimelineComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsNavigationRelevant(UTimelineComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsSupportedForNetworking(UTimelineComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_MarkAsEditorOnlySubobject(UTimelineComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_NeedsLoadForClient(UTimelineComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_NeedsLoadForEditorGame(UTimelineComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_NeedsLoadForServer(UTimelineComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_OnActorEnableCollisionChanged(UTimelineComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_OnComponentCreated(UTimelineComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_OnComponentDestroyed(UTimelineComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_OnCreatePhysicsState(UTimelineComponent* Self)
	{
		((E_PROTECTED_WRAP_UTimelineComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_OnDestroyPhysicsState(UTimelineComponent* Self)
	{
		((E_PROTECTED_WRAP_UTimelineComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_OnRegister(UTimelineComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_OnUnregister(UTimelineComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PostInitProperties(UTimelineComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PostLoad(UTimelineComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PostNetReceive(UTimelineComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PostRename(UTimelineComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PreNetReceive(UTimelineComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_RegisterComponentTickFunctions(UTimelineComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_RemoveTickPrerequisiteActor(UTimelineComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_RemoveTickPrerequisiteComponent(UTimelineComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_RequiresGameThreadEndOfFrameRecreate(UTimelineComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_RequiresGameThreadEndOfFrameUpdates(UTimelineComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SendRenderDynamicData_Concurrent(UTimelineComponent* Self)
	{
		((E_PROTECTED_WRAP_UTimelineComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SendRenderTransform_Concurrent(UTimelineComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetActive(UTimelineComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetAutoActivate(UTimelineComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetComponentTickEnabled(UTimelineComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_SetComponentTickEnabledAsync(UTimelineComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_ShouldActivate(UTimelineComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UTimelineComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_ShouldCreatePhysicsState(UTimelineComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_ShouldCreateRenderState(UTimelineComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_ToggleActive(UTimelineComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_UninitializeComponent(UTimelineComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_UpdateComponentToWorld(UTimelineComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateComponentToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_AreNativePropertiesIdenticalTo(UTimelineComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_CheckDefaultSubobjectsInternal(UTimelineComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_FinishDestroy(UTimelineComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetDesc(UTimelineComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UTimelineComponent_GetDetailedInfoInternal(UTimelineComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsAsset(UTimelineComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsFullNameStableForNetworking(UTimelineComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsLocalizedResource(UTimelineComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsPostLoadThreadSafe(UTimelineComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsReadyForFinishDestroy(UTimelineComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_IsSafeForRootSet(UTimelineComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_Modify(UTimelineComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_NotifyObjectReferenceEliminated(UTimelineComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PostCDOContruct(UTimelineComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PostEditImport(UTimelineComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PostRepNotifies(UTimelineComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PostSaveRoot(UTimelineComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_PreDestroyFromReplication(UTimelineComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_ShutdownAfterError(UTimelineComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_AddToCluster(UTimelineComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UTimelineComponent_CanBeClusterRoot(UTimelineComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_CanBeInCluster(UTimelineComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_CreateCluster(UTimelineComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UTimelineComponent_OnClusterMarkedAsPendingKill(UTimelineComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
