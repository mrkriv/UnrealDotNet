#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCameraModifier_CameraShake.h"
#include "Runtime/Engine/Classes/Camera/CameraModifier_CameraShake.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraModifier_CameraShake.h:33

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCameraModifier_CameraShake(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCameraModifier_CameraShake>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCameraModifier_CameraShake_RemoveAllCameraShakes(UCameraModifier_CameraShake* Self, bool bImmediately)
	{
		auto _p0 = bImmediately;
		Self->RemoveAllCameraShakes(_p0);
	}

	DOTNET_EXPORT auto E_UCameraModifier_CameraShake_RemoveCameraShake(UCameraModifier_CameraShake* Self, UCameraShake* ShakeInst, bool bImmediately)
	{
		auto _p0 = ShakeInst;
		auto _p1 = bImmediately;
		Self->RemoveCameraShake(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCameraModifier_CameraShake_SaveShakeInExpiredPool(UCameraModifier_CameraShake* Self, UCameraShake* ShakeInst)
	{
		auto _p0 = ShakeInst;
		Self->SaveShakeInExpiredPool(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_RemoveAllCameraShakes(UCameraModifier_CameraShake* Self, bool bImmediately)
	{
		auto _p0 = bImmediately;
		((UManageCameraModifier_CameraShake*)Self)->_Supper__RemoveAllCameraShakes(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_DisableModifier(UCameraModifier* Self, bool bImmediate)
	{
		auto _p0 = bImmediate;
		((UManageCameraModifier_CameraShake*)Self)->_Supper__DisableModifier(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_EnableModifier(UCameraModifier* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__EnableModifier();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_ToggleModifier(UCameraModifier* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__ToggleModifier();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_UpdateAlpha(UCameraModifier* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManageCameraModifier_CameraShake*)Self)->_Supper__UpdateAlpha(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_BeginDestroy(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_FinishDestroy(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_PostCDOContruct(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_PostEditImport(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_PostInitProperties(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_PostLoad(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_PostNetReceive(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_PostRepNotifies(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageCameraModifier_CameraShake*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_PreDestroyFromReplication(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_PreNetReceive(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_ShutdownAfterError(UObject* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CameraShake_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageCameraModifier_CameraShake*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
