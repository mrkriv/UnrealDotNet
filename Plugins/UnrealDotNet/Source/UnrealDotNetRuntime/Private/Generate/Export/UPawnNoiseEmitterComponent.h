#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/PawnNoiseEmitterComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

class E_PROTECTED_WRAP_UPawnNoiseEmitterComponent : protected UPawnNoiseEmitterComponent
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
	DOTNET_EXPORT auto E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_GET(UPawnNoiseEmitterComponent* Ptr) { return (INT_PTR)&(Ptr->LastRemoteNoisePosition); }
	DOTNET_EXPORT void E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_SET(UPawnNoiseEmitterComponent* Ptr, INT_PTR Value) { Ptr->LastRemoteNoisePosition = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_GET(UPawnNoiseEmitterComponent* Ptr) { return Ptr->NoiseLifetime; }
	DOTNET_EXPORT void E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_SET(UPawnNoiseEmitterComponent* Ptr, float Value) { Ptr->NoiseLifetime = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPawnNoiseEmitterComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPawnNoiseEmitterComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetLastNoiseTime(UPawnNoiseEmitterComponent* Self, bool bSourceWithinNoiseEmitter)
	{
		auto _p0 = bSourceWithinNoiseEmitter;
		return Self->GetLastNoiseTime(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(UPawnNoiseEmitterComponent* Self, bool bSourceWithinNoiseEmitter)
	{
		auto _p0 = bSourceWithinNoiseEmitter;
		return Self->GetLastNoiseVolume(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_MakeNoise(UPawnNoiseEmitterComponent* Self, AActor* NoiseMaker, float Loudness, INT_PTR NoiseLocation)
	{
		auto _p0 = NoiseMaker;
		auto _p1 = Loudness;
		auto _p2 = *(FVector*)NoiseLocation;
		Self->MakeNoise(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_Activate(UPawnNoiseEmitterComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_AddTickPrerequisiteActor(UPawnNoiseEmitterComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_AddTickPrerequisiteComponent(UPawnNoiseEmitterComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_ApplyWorldOffset(UPawnNoiseEmitterComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_BeginDestroy(UPawnNoiseEmitterComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_BeginPlay(UPawnNoiseEmitterComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_CreateRenderState_Concurrent(UPawnNoiseEmitterComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_Deactivate(UPawnNoiseEmitterComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_DestroyComponent(UPawnNoiseEmitterComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_DestroyRenderState_Concurrent(UPawnNoiseEmitterComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetComponentClassCanReplicate(UPawnNoiseEmitterComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetReadableName(UPawnNoiseEmitterComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_HasValidPhysicsState(UPawnNoiseEmitterComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_InitializeComponent(UPawnNoiseEmitterComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_InvalidateLightingCacheDetailed(UPawnNoiseEmitterComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsActive(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsEditorOnly(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsNameStableForNetworking(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsNavigationRelevant(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsReadyForOwnerToAutoDestroy(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsSupportedForNetworking(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_MarkAsEditorOnlySubobject(UPawnNoiseEmitterComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_NeedsLoadForClient(UPawnNoiseEmitterComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_NeedsLoadForEditorGame(UPawnNoiseEmitterComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_NeedsLoadForServer(UPawnNoiseEmitterComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_OnActorEnableCollisionChanged(UPawnNoiseEmitterComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_OnComponentCreated(UPawnNoiseEmitterComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_OnComponentDestroyed(UPawnNoiseEmitterComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_OnCreatePhysicsState(UPawnNoiseEmitterComponent* Self)
	{
		((E_PROTECTED_WRAP_UPawnNoiseEmitterComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_OnDestroyPhysicsState(UPawnNoiseEmitterComponent* Self)
	{
		((E_PROTECTED_WRAP_UPawnNoiseEmitterComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_OnRegister(UPawnNoiseEmitterComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_OnUnregister(UPawnNoiseEmitterComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PostInitProperties(UPawnNoiseEmitterComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PostLoad(UPawnNoiseEmitterComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PostNetReceive(UPawnNoiseEmitterComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PostRename(UPawnNoiseEmitterComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PreNetReceive(UPawnNoiseEmitterComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_RegisterComponentTickFunctions(UPawnNoiseEmitterComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_RemoveTickPrerequisiteActor(UPawnNoiseEmitterComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_RemoveTickPrerequisiteComponent(UPawnNoiseEmitterComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_RequiresGameThreadEndOfFrameRecreate(UPawnNoiseEmitterComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_RequiresGameThreadEndOfFrameUpdates(UPawnNoiseEmitterComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_SendRenderDynamicData_Concurrent(UPawnNoiseEmitterComponent* Self)
	{
		((E_PROTECTED_WRAP_UPawnNoiseEmitterComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_SendRenderTransform_Concurrent(UPawnNoiseEmitterComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_SetActive(UPawnNoiseEmitterComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_SetAutoActivate(UPawnNoiseEmitterComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_SetComponentTickEnabled(UPawnNoiseEmitterComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_SetComponentTickEnabledAsync(UPawnNoiseEmitterComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_ShouldActivate(UPawnNoiseEmitterComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPawnNoiseEmitterComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_ShouldCreatePhysicsState(UPawnNoiseEmitterComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_ShouldCreateRenderState(UPawnNoiseEmitterComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_ToggleActive(UPawnNoiseEmitterComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_UninitializeComponent(UPawnNoiseEmitterComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_UpdateComponentToWorld(UPawnNoiseEmitterComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->UpdateComponentToWorld(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_AreNativePropertiesIdenticalTo(UPawnNoiseEmitterComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_CheckDefaultSubobjectsInternal(UPawnNoiseEmitterComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_FinishDestroy(UPawnNoiseEmitterComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetDesc(UPawnNoiseEmitterComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_GetDetailedInfoInternal(UPawnNoiseEmitterComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsAsset(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsFullNameStableForNetworking(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsLocalizedResource(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsPostLoadThreadSafe(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsReadyForFinishDestroy(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_IsSafeForRootSet(UPawnNoiseEmitterComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_Modify(UPawnNoiseEmitterComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_NotifyObjectReferenceEliminated(UPawnNoiseEmitterComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PostCDOContruct(UPawnNoiseEmitterComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PostEditImport(UPawnNoiseEmitterComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PostRepNotifies(UPawnNoiseEmitterComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PostSaveRoot(UPawnNoiseEmitterComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_PreDestroyFromReplication(UPawnNoiseEmitterComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_ShutdownAfterError(UPawnNoiseEmitterComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_AddToCluster(UPawnNoiseEmitterComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_CanBeClusterRoot(UPawnNoiseEmitterComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_CanBeInCluster(UPawnNoiseEmitterComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_CreateCluster(UPawnNoiseEmitterComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UPawnNoiseEmitterComponent_OnClusterMarkedAsPendingKill(UPawnNoiseEmitterComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
