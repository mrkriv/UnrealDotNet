#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePawnNoiseEmitterComponent.h"
#include "Runtime/Engine/Classes/Components/PawnNoiseEmitterComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

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
		auto& _p2 = *(FVector*)NoiseLocation;
		Self->MakeNoise(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_BeginPlay(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_Deactivate(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_OnRegister(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_OnUnregister(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_ToggleActive(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_BeginDestroy(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_FinishDestroy(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_PostCDOContruct(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_PostEditImport(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_PostInitProperties(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_PostLoad(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_PostNetReceive(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_PostRepNotifies(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_PreNetReceive(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_ShutdownAfterError(UObject* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UPawnNoiseEmitterComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManagePawnNoiseEmitterComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
