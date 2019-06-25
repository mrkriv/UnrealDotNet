#pragma once
// This file was created automatically, do not modify the contents of this file.

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManageCameraShake.h"
#include "Runtime/Engine/Classes/Camera/CameraShake.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\CameraShake.h:136

extern "C"
{
	DOTNET_EXPORT auto E_PROP_UCameraShake_AnimBlendInTime_GET(UCameraShake* Ptr) { return Ptr->AnimBlendInTime; }
	DOTNET_EXPORT void E_PROP_UCameraShake_AnimBlendInTime_SET(UCameraShake* Ptr, float Value) { Ptr->AnimBlendInTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_AnimBlendOutTime_GET(UCameraShake* Ptr) { return Ptr->AnimBlendOutTime; }
	DOTNET_EXPORT void E_PROP_UCameraShake_AnimBlendOutTime_SET(UCameraShake* Ptr, float Value) { Ptr->AnimBlendOutTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_AnimInst_GET(UCameraShake* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->AnimInst); }
	DOTNET_EXPORT void E_PROP_UCameraShake_AnimInst_SET(UCameraShake* Ptr, UCameraAnimInst* Value) { Ptr->AnimInst = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_AnimPlayRate_GET(UCameraShake* Ptr) { return Ptr->AnimPlayRate; }
	DOTNET_EXPORT void E_PROP_UCameraShake_AnimPlayRate_SET(UCameraShake* Ptr, float Value) { Ptr->AnimPlayRate = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_AnimScale_GET(UCameraShake* Ptr) { return Ptr->AnimScale; }
	DOTNET_EXPORT void E_PROP_UCameraShake_AnimScale_SET(UCameraShake* Ptr, float Value) { Ptr->AnimScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_FOVOscillation_GET(UCameraShake* Ptr) { return (INT_PTR)&(Ptr->FOVOscillation); }
	DOTNET_EXPORT void E_PROP_UCameraShake_FOVOscillation_SET(UCameraShake* Ptr, INT_PTR Value) { Ptr->FOVOscillation = *(FFOscillator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_LocOscillation_GET(UCameraShake* Ptr) { return (INT_PTR)&(Ptr->LocOscillation); }
	DOTNET_EXPORT void E_PROP_UCameraShake_LocOscillation_SET(UCameraShake* Ptr, INT_PTR Value) { Ptr->LocOscillation = *(FVOscillator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_OscillationBlendInTime_GET(UCameraShake* Ptr) { return Ptr->OscillationBlendInTime; }
	DOTNET_EXPORT void E_PROP_UCameraShake_OscillationBlendInTime_SET(UCameraShake* Ptr, float Value) { Ptr->OscillationBlendInTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_OscillationBlendOutTime_GET(UCameraShake* Ptr) { return Ptr->OscillationBlendOutTime; }
	DOTNET_EXPORT void E_PROP_UCameraShake_OscillationBlendOutTime_SET(UCameraShake* Ptr, float Value) { Ptr->OscillationBlendOutTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_OscillationDuration_GET(UCameraShake* Ptr) { return Ptr->OscillationDuration; }
	DOTNET_EXPORT void E_PROP_UCameraShake_OscillationDuration_SET(UCameraShake* Ptr, float Value) { Ptr->OscillationDuration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_OscillatorTimeRemaining_GET(UCameraShake* Ptr) { return Ptr->OscillatorTimeRemaining; }
	DOTNET_EXPORT void E_PROP_UCameraShake_OscillatorTimeRemaining_SET(UCameraShake* Ptr, float Value) { Ptr->OscillatorTimeRemaining = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_RandomAnimSegmentDuration_GET(UCameraShake* Ptr) { return Ptr->RandomAnimSegmentDuration; }
	DOTNET_EXPORT void E_PROP_UCameraShake_RandomAnimSegmentDuration_SET(UCameraShake* Ptr, float Value) { Ptr->RandomAnimSegmentDuration = Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_RotOscillation_GET(UCameraShake* Ptr) { return (INT_PTR)&(Ptr->RotOscillation); }
	DOTNET_EXPORT void E_PROP_UCameraShake_RotOscillation_SET(UCameraShake* Ptr, INT_PTR Value) { Ptr->RotOscillation = *(FROscillator*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UCameraShake_ShakeScale_GET(UCameraShake* Ptr) { return Ptr->ShakeScale; }
	DOTNET_EXPORT void E_PROP_UCameraShake_ShakeScale_SET(UCameraShake* Ptr, float Value) { Ptr->ShakeScale = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UCameraShake(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UCameraShake>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UCameraShake_BlueprintUpdateCameraShake(UCameraShake* Self, float DeltaTime, float Alpha, INT_PTR POV, INT_PTR ModifiedPOV)
	{
		auto _p0 = DeltaTime;
		auto _p1 = Alpha;
		auto& _p2 = *(FMinimalViewInfo*)POV;
		auto& _p3 = *(FMinimalViewInfo*)ModifiedPOV;
		Self->BlueprintUpdateCameraShake(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UCameraShake_IsFinished(UCameraShake* Self)
	{
		return Self->IsFinished();
	}

	DOTNET_EXPORT auto E_UCameraShake_IsLooping(UCameraShake* Self)
	{
		return Self->IsLooping();
	}

	DOTNET_EXPORT auto E_UCameraShake_ReceiveIsFinished(UCameraShake* Self)
	{
		return Self->ReceiveIsFinished();
	}

	DOTNET_EXPORT auto E_UCameraShake_ReceivePlayShake(UCameraShake* Self, float Scale)
	{
		auto _p0 = Scale;
		Self->ReceivePlayShake(_p0);
	}

	DOTNET_EXPORT auto E_UCameraShake_ReceiveStopShake(UCameraShake* Self, bool bImmediately)
	{
		auto _p0 = bImmediately;
		Self->ReceiveStopShake(_p0);
	}

	DOTNET_EXPORT auto E_UCameraShake_SetCurrentTimeAndApplyShake(UCameraShake* Self, float NewTime, INT_PTR POV)
	{
		auto _p0 = NewTime;
		auto& _p1 = *(FMinimalViewInfo*)POV;
		Self->SetCurrentTimeAndApplyShake(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UCameraShake_SetTempCameraAnimActor(UCameraShake* Self, AActor* Actor)
	{
		auto _p0 = Actor;
		Self->SetTempCameraAnimActor(_p0);
	}

	DOTNET_EXPORT auto E_UCameraShake_StopShake(UCameraShake* Self, bool bImmediately)
	{
		auto _p0 = bImmediately;
		Self->StopShake(_p0);
	}

	DOTNET_EXPORT auto E_UCameraShake_UpdateAndApplyCameraShake(UCameraShake* Self, float DeltaTime, float Alpha, INT_PTR InOutPOV)
	{
		auto _p0 = DeltaTime;
		auto _p1 = Alpha;
		auto& _p2 = *(FMinimalViewInfo*)InOutPOV;
		Self->UpdateAndApplyCameraShake(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_StopShake(UCameraShake* Self, bool bImmediately)
	{
		auto _p0 = bImmediately;
		((UManageCameraShake*)Self)->_Supper__StopShake(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_BeginDestroy(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_FinishDestroy(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_PostCDOContruct(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_PostEditImport(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_PostInitProperties(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_PostLoad(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_PostNetReceive(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_PostRepNotifies(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((UManageCameraShake*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_PreDestroyFromReplication(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_PreNetReceive(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_ShutdownAfterError(UObject* Self)
	{
		((UManageCameraShake*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_CreateCluster(UObjectBaseUtility* Self)
	{
		((UManageCameraShake*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__UCameraShake_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((UManageCameraShake*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
