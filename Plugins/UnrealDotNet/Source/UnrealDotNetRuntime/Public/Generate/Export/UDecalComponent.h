#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageDecalComponent.h"
#include "Runtime/Engine/Classes/Components/DecalComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

class E_PROTECTED_WRAP_UDecalComponent : protected UDecalComponent
{
public:
	void LifeSpanCallback_WRAP()
	{
		LifeSpanCallback();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UDecalComponent_bDestroyOwnerAfterFade_GET(UDecalComponent* Ptr) { return Ptr->bDestroyOwnerAfterFade; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_bDestroyOwnerAfterFade_SET(UDecalComponent* Ptr, uint8 Value) { Ptr->bDestroyOwnerAfterFade = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_DecalSize_GET(UDecalComponent* Ptr) { return (INT_PTR)&(Ptr->DecalSize); }
	DOTNET_EXPORT void E_PROP_UDecalComponent_DecalSize_SET(UDecalComponent* Ptr, INT_PTR Value) { Ptr->DecalSize = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeDuration_GET(UDecalComponent* Ptr) { return Ptr->FadeDuration; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeDuration_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeDuration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeInDuration_GET(UDecalComponent* Ptr) { return Ptr->FadeInDuration; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeInDuration_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeInDuration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeInStartDelay_GET(UDecalComponent* Ptr) { return Ptr->FadeInStartDelay; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeInStartDelay_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeInStartDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeScreenSize_GET(UDecalComponent* Ptr) { return Ptr->FadeScreenSize; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeScreenSize_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeScreenSize = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_FadeStartDelay_GET(UDecalComponent* Ptr) { return Ptr->FadeStartDelay; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_FadeStartDelay_SET(UDecalComponent* Ptr, float Value) { Ptr->FadeStartDelay = Value; }
	
	DOTNET_EXPORT auto E_PROP_UDecalComponent_SortOrder_GET(UDecalComponent* Ptr) { return Ptr->SortOrder; }
	DOTNET_EXPORT void E_PROP_UDecalComponent_SortOrder_SET(UDecalComponent* Ptr, int32 Value) { Ptr->SortOrder = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UDecalComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UDecalComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeDuration(UDecalComponent* Self)
	{
		return Self->GetFadeDuration();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeInDuration(UDecalComponent* Self)
	{
		return Self->GetFadeInDuration();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeInStartDelay(UDecalComponent* Self)
	{
		return Self->GetFadeInStartDelay();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetFadeStartDelay(UDecalComponent* Self)
	{
		return Self->GetFadeStartDelay();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetNumMaterials(UDecalComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UDecalComponent_GetTransformIncludingDecalSize(UDecalComponent* Self)
	{
		return (INT_PTR) new FTransform(Self->GetTransformIncludingDecalSize());
	}

	DOTNET_EXPORT auto E_UDecalComponent_LifeSpanCallback(UDecalComponent* Self)
	{
		((E_PROTECTED_WRAP_UDecalComponent*)Self)->LifeSpanCallback_WRAP();
	}

	DOTNET_EXPORT auto E_UDecalComponent_PushSelectionToProxy(UDecalComponent* Self)
	{
		Self->PushSelectionToProxy();
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetFadeIn(UDecalComponent* Self, float StartDelay, float Duaration)
	{
		auto _p0 = StartDelay;
		auto _p1 = Duaration;
		Self->SetFadeIn(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetFadeOut(UDecalComponent* Self, float StartDelay, float Duration, bool DestroyOwnerAfterFade)
	{
		auto _p0 = StartDelay;
		auto _p1 = Duration;
		auto _p2 = DestroyOwnerAfterFade;
		Self->SetFadeOut(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetFadeScreenSize(UDecalComponent* Self, float NewFadeScreenSize)
	{
		auto _p0 = NewFadeScreenSize;
		Self->SetFadeScreenSize(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetLifeSpan(UDecalComponent* Self, float LifeSpan)
	{
		auto _p0 = LifeSpan;
		Self->SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E_UDecalComponent_SetSortOrder(UDecalComponent* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetSortOrder(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_LifeSpanCallback(UDecalComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__LifeSpanCallback();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_DetachFromParent(USceneComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		((UManageDecalComponent*)Self)->_Supper__DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnAttachmentChanged(USceneComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnHiddenInGameChanged(USceneComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnHiddenInGameChanged();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnVisibilityChanged(USceneComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnVisibilityChanged();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PropagateLightingScenarioChange(USceneComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_UpdateBounds(USceneComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__UpdateBounds();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_UpdatePhysicsVolume(USceneComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		((UManageDecalComponent*)Self)->_Supper__UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageDecalComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_Deactivate(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageDecalComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageDecalComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageDecalComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnRegister(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageDecalComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageDecalComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageDecalComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageDecalComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageDecalComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_BeginDestroy(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_FinishDestroy(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PostCDOContruct(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PostEditImport(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PostInitProperties(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PostLoad(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PostNetReceive(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PostRepNotifies(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageDecalComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_PreNetReceive(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UDecalComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageDecalComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
