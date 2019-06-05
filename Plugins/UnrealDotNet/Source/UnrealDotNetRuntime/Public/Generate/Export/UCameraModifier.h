#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCameraModifier.h"
#include "Runtime/Engine/Classes/Camera/CameraModifier.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraModifier.h:22

class E_PROTECTED_WRAP_UCameraModifier : protected UCameraModifier
{
public:
	float GetTargetAlpha_WRAP()
	{
		return GetTargetAlpha();
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_UCameraModifier_Priority_GET(UCameraModifier* Ptr) { return Ptr->Priority; }
	DOTNET_EXPORT void E_PROP_UCameraModifier_Priority_SET(UCameraModifier* Ptr, uint8 Value) { Ptr->Priority = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCameraModifier(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCameraModifier>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCameraModifier_AddedToCamera(UCameraModifier* Self, APlayerCameraManager* Camera)
	{
		auto _p0 = Camera;
		Self->AddedToCamera(_p0);
	}

	DOTNET_EXPORT auto E_UCameraModifier_BlueprintModifyCamera(UCameraModifier* Self, float DeltaTime, INT_PTR ViewLocation, INT_PTR ViewRotation, float FOV, INT_PTR NewViewLocation, INT_PTR NewViewRotation, float NewFOV)
	{
		auto _p0 = DeltaTime;
		auto _p1 = *(FVector*)ViewLocation;
		auto _p2 = *(FRotator*)ViewRotation;
		auto _p3 = FOV;
		auto& _p4 = *(FVector*)NewViewLocation;
		auto& _p5 = *(FRotator*)NewViewRotation;
		auto& _p6 = NewFOV;
		Self->BlueprintModifyCamera(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_UCameraModifier_BlueprintModifyPostProcess(UCameraModifier* Self, float DeltaTime, float PostProcessBlendWeight, INT_PTR PostProcessSettings)
	{
		auto _p0 = DeltaTime;
		auto& _p1 = PostProcessBlendWeight;
		auto& _p2 = *(FPostProcessSettings*)PostProcessSettings;
		Self->BlueprintModifyPostProcess(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UCameraModifier_DisableModifier(UCameraModifier* Self, bool bImmediate)
	{
		auto _p0 = bImmediate;
		Self->DisableModifier(_p0);
	}

	DOTNET_EXPORT auto E_UCameraModifier_EnableModifier(UCameraModifier* Self)
	{
		Self->EnableModifier();
	}

	DOTNET_EXPORT auto E_UCameraModifier_GetTargetAlpha(UCameraModifier* Self)
	{
		return ((E_PROTECTED_WRAP_UCameraModifier*)Self)->GetTargetAlpha_WRAP();
	}

	DOTNET_EXPORT auto E_UCameraModifier_GetViewTarget(UCameraModifier* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetViewTarget());
	}

	DOTNET_EXPORT auto E_UCameraModifier_GetWorld(UCameraModifier* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetWorld());
	}

	DOTNET_EXPORT auto E_UCameraModifier_IsDisabled(UCameraModifier* Self)
	{
		return Self->IsDisabled();
	}

	DOTNET_EXPORT auto E_UCameraModifier_ModifyCamera(UCameraModifier* Self, float DeltaTime, INT_PTR InOutPOV)
	{
		auto _p0 = DeltaTime;
		auto& _p1 = *(FMinimalViewInfo*)InOutPOV;
		return Self->ModifyCamera(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCameraModifier_ProcessViewRotation(UCameraModifier* Self, AActor* ViewTarget, float DeltaTime, INT_PTR OutViewRotation, INT_PTR OutDeltaRot)
	{
		auto _p0 = ViewTarget;
		auto _p1 = DeltaTime;
		auto& _p2 = *(FRotator*)OutViewRotation;
		auto& _p3 = *(FRotator*)OutDeltaRot;
		return Self->ProcessViewRotation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UCameraModifier_ToggleModifier(UCameraModifier* Self)
	{
		Self->ToggleModifier();
	}

	DOTNET_EXPORT auto E_UCameraModifier_UpdateAlpha(UCameraModifier* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		Self->UpdateAlpha(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_DisableModifier(UCameraModifier* Self, bool bImmediate)
	{
		auto _p0 = bImmediate;
		((UManageCameraModifier*)Self)->_Supper__DisableModifier(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_EnableModifier(UCameraModifier* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__EnableModifier();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_ToggleModifier(UCameraModifier* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__ToggleModifier();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_UpdateAlpha(UCameraModifier* Self, float DeltaTime)
	{
		auto _p0 = DeltaTime;
		((UManageCameraModifier*)Self)->_Supper__UpdateAlpha(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_BeginDestroy(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_FinishDestroy(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_PostCDOContruct(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_PostEditImport(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_PostInitProperties(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_PostLoad(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_PostNetReceive(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_PostRepNotifies(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageCameraModifier*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_PreDestroyFromReplication(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_PreNetReceive(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_ShutdownAfterError(UObject* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UCameraModifier_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageCameraModifier*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
