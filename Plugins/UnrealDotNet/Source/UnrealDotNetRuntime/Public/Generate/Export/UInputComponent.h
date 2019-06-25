#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageInputComponent.h"
#include "Runtime/Engine/Classes/Components/InputComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:675

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UInputComponent_bBlockInput_GET(UInputComponent* Ptr) { return Ptr->bBlockInput; }
	DOTNET_EXPORT void E_PROP_UInputComponent_bBlockInput_SET(UInputComponent* Ptr, uint8 Value) { Ptr->bBlockInput = Value; }
	
	DOTNET_EXPORT auto E_PROP_UInputComponent_Priority_GET(UInputComponent* Ptr) { return Ptr->Priority; }
	DOTNET_EXPORT void E_PROP_UInputComponent_Priority_SET(UInputComponent* Ptr, int32 Value) { Ptr->Priority = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UInputComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UInputComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UInputComponent_AddActionBinding(UInputComponent* Self, INT_PTR Binding)
	{
		auto _p0 = *(FInputActionBinding*)Binding;
		return (INT_PTR) new FInputActionBinding(Self->AddActionBinding(_p0));
	}

	DOTNET_EXPORT auto E_UInputComponent_BindAxis(UInputComponent* Self, char* AxisName)
	{
		auto _p0 = ConvertFromManage_FName(AxisName);
		return (INT_PTR) new FInputAxisBinding(Self->BindAxis(_p0));
	}

	DOTNET_EXPORT auto E_UInputComponent_ClearActionBindings(UInputComponent* Self)
	{
		Self->ClearActionBindings();
	}

	DOTNET_EXPORT auto E_UInputComponent_ClearBindingValues(UInputComponent* Self)
	{
		Self->ClearBindingValues();
	}

	DOTNET_EXPORT auto E_UInputComponent_ConditionalBuildKeyMap(UInputComponent* Self, UPlayerInput* PlayerInput)
	{
		auto _p0 = PlayerInput;
		Self->ConditionalBuildKeyMap(_p0);
	}

	DOTNET_EXPORT auto E_UInputComponent_GetActionBinding(UInputComponent* Self, int32 BindingIndex)
	{
		auto _p0 = BindingIndex;
		return (INT_PTR) new FInputActionBinding(Self->GetActionBinding(_p0));
	}

	DOTNET_EXPORT auto E_UInputComponent_GetAxisValue(UInputComponent* Self, char* AxisName)
	{
		auto _p0 = ConvertFromManage_FName(AxisName);
		return Self->GetAxisValue(_p0);
	}

	DOTNET_EXPORT auto E_UInputComponent_GetNumActionBindings(UInputComponent* Self)
	{
		return Self->GetNumActionBindings();
	}

	DOTNET_EXPORT auto E_UInputComponent_HasBindings(UInputComponent* Self)
	{
		return Self->HasBindings();
	}

	DOTNET_EXPORT auto E_UInputComponent_RemoveActionBinding(UInputComponent* Self, int32 BindingIndex)
	{
		auto _p0 = BindingIndex;
		Self->RemoveActionBinding(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_Activate(UActorComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		((UManageInputComponent*)Self)->_Supper__Activate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_BeginPlay(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_CreateRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_Deactivate(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__Deactivate();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_DestroyComponent(UActorComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		((UManageInputComponent*)Self)->_Supper__DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_DestroyRenderState_Concurrent(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_InitializeComponent(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__InitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_InvalidateLightingCacheDetailed(UActorComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		((UManageInputComponent*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_OnActorEnableCollisionChanged(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_OnComponentCreated(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__OnComponentCreated();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_OnComponentDestroyed(UActorComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		((UManageInputComponent*)Self)->_Supper__OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_OnCreatePhysicsState(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__OnCreatePhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_OnDestroyPhysicsState(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__OnDestroyPhysicsState();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_OnRegister(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__OnRegister();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_OnRep_IsActive(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__OnRep_IsActive();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_OnUnregister(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__OnUnregister();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_RegisterComponentTickFunctions(UActorComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((UManageInputComponent*)Self)->_Supper__RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_SendRenderDynamicData_Concurrent(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__SendRenderDynamicData_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_SendRenderTransform_Concurrent(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_SetActive(UActorComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		((UManageInputComponent*)Self)->_Supper__SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_SetAutoActivate(UActorComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		((UManageInputComponent*)Self)->_Supper__SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_SetComponentTickEnabled(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageInputComponent*)Self)->_Supper__SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_SetComponentTickEnabledAsync(UActorComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		((UManageInputComponent*)Self)->_Supper__SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_ToggleActive(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__ToggleActive();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_UninitializeComponent(UActorComponent* Self)
	{
		((UManageInputComponent*)Self)->_Supper__UninitializeComponent();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_BeginDestroy(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_FinishDestroy(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_PostCDOContruct(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_PostEditImport(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_PostInitProperties(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_PostLoad(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_PostNetReceive(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_PostRepNotifies(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageInputComponent*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_PreDestroyFromReplication(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_PreNetReceive(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_ShutdownAfterError(UObject* Self)
	{
		((UManageInputComponent*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageInputComponent*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UInputComponent_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageInputComponent*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
