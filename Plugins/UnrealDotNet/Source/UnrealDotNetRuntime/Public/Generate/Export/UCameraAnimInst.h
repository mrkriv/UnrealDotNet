#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCameraAnimInst.h"
#include "Runtime/Engine/Classes/Camera/CameraAnimInst.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraAnimInst.h:18

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UCameraAnimInst_BasePlayScale_GET(UCameraAnimInst* Ptr) { return Ptr->BasePlayScale; }
	DOTNET_EXPORT void E_PROP_UCameraAnimInst_BasePlayScale_SET(UCameraAnimInst* Ptr, float Value) { Ptr->BasePlayScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnimInst_CurrentBlendWeight_GET(UCameraAnimInst* Ptr) { return Ptr->CurrentBlendWeight; }
	DOTNET_EXPORT void E_PROP_UCameraAnimInst_CurrentBlendWeight_SET(UCameraAnimInst* Ptr, float Value) { Ptr->CurrentBlendWeight = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnimInst_CurTime_GET(UCameraAnimInst* Ptr) { return Ptr->CurTime; }
	DOTNET_EXPORT void E_PROP_UCameraAnimInst_CurTime_SET(UCameraAnimInst* Ptr, float Value) { Ptr->CurTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnimInst_InitialCamToWorld_GET(UCameraAnimInst* Ptr) { return (INT_PTR)&(Ptr->InitialCamToWorld); }
	DOTNET_EXPORT void E_PROP_UCameraAnimInst_InitialCamToWorld_SET(UCameraAnimInst* Ptr, INT_PTR Value) { Ptr->InitialCamToWorld = *(FTransform*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnimInst_InitialFOV_GET(UCameraAnimInst* Ptr) { return Ptr->InitialFOV; }
	DOTNET_EXPORT void E_PROP_UCameraAnimInst_InitialFOV_SET(UCameraAnimInst* Ptr, float Value) { Ptr->InitialFOV = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnimInst_LastCameraLoc_GET(UCameraAnimInst* Ptr) { return (INT_PTR)&(Ptr->LastCameraLoc); }
	DOTNET_EXPORT void E_PROP_UCameraAnimInst_LastCameraLoc_SET(UCameraAnimInst* Ptr, INT_PTR Value) { Ptr->LastCameraLoc = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnimInst_PlayRate_GET(UCameraAnimInst* Ptr) { return Ptr->PlayRate; }
	DOTNET_EXPORT void E_PROP_UCameraAnimInst_PlayRate_SET(UCameraAnimInst* Ptr, float Value) { Ptr->PlayRate = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnimInst_TransientScaleModifier_GET(UCameraAnimInst* Ptr) { return Ptr->TransientScaleModifier; }
	DOTNET_EXPORT void E_PROP_UCameraAnimInst_TransientScaleModifier_SET(UCameraAnimInst* Ptr, float Value) { Ptr->TransientScaleModifier = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraAnimInst_UserPlaySpaceMatrix_GET(UCameraAnimInst* Ptr) { return (INT_PTR)&(Ptr->UserPlaySpaceMatrix); }
	DOTNET_EXPORT void E_PROP_UCameraAnimInst_UserPlaySpaceMatrix_SET(UCameraAnimInst* Ptr, INT_PTR Value) { Ptr->UserPlaySpaceMatrix = *(FMatrix*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCameraAnimInst(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCameraAnimInst>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_AdvanceAnim(UCameraAnimInst* Self, float DeltaTime, bool bJump)
	{
		auto _p0 = DeltaTime;
		auto _p1 = bJump;
		Self->AdvanceAnim(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_ApplyToView(UCameraAnimInst* Self, INT_PTR InOutPOV)
	{
		auto& _p0 = *(FMinimalViewInfo*)InOutPOV;
		Self->ApplyToView(_p0);
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_ApplyTransientScaling(UCameraAnimInst* Self, float Scalar)
	{
		auto _p0 = Scalar;
		Self->ApplyTransientScaling(_p0);
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_GetCurrentTime(UCameraAnimInst* Self)
	{
		return Self->GetCurrentTime();
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_SetCurrentTime(UCameraAnimInst* Self, float NewTime)
	{
		auto _p0 = NewTime;
		Self->SetCurrentTime(_p0);
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_SetDuration(UCameraAnimInst* Self, float NewDuration)
	{
		auto _p0 = NewDuration;
		Self->SetDuration(_p0);
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_SetScale(UCameraAnimInst* Self, float NewDuration)
	{
		auto _p0 = NewDuration;
		Self->SetScale(_p0);
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_SetStopAutomatically(UCameraAnimInst* Self, bool bNewStopAutoMatically)
	{
		auto _p0 = bNewStopAutoMatically;
		Self->SetStopAutomatically(_p0);
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_Stop(UCameraAnimInst* Self, bool bImmediate)
	{
		auto _p0 = bImmediate;
		Self->Stop(_p0);
	}

	DOTNET_EXPORT auto E_UCameraAnimInst_Update(UCameraAnimInst* Self, float NewRate, float NewScale, float NewBlendInTime, float NewBlendOutTime, float NewDuration)
	{
		auto _p0 = NewRate;
		auto _p1 = NewScale;
		auto _p2 = NewBlendInTime;
		auto _p3 = NewBlendOutTime;
		auto _p4 = NewDuration;
		Self->Update(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_BeginDestroy(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_FinishDestroy(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_PostCDOContruct(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_PostEditImport(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_PostInitProperties(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_PostLoad(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_PostNetReceive(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_PostRepNotifies(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageCameraAnimInst*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_PreDestroyFromReplication(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_PreNetReceive(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_ShutdownAfterError(UObject* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UCameraAnimInst_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageCameraAnimInst*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
