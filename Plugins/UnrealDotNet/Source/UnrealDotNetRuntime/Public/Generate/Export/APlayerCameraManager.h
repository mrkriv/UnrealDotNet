#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Generate/Manage/ManagePlayerCameraManager.h"
#include "Runtime/Engine/Classes/Camera/PlayerCameraManager.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\PlayerCameraManager.h:172

class E_PROTECTED_WRAP_APlayerCameraManager : protected APlayerCameraManager
{
public:
	void ClearCachedPPBlends_WRAP()
	{
		ClearCachedPPBlends();
	}

	void SetCameraCacheTime_WRAP(float InTime)
	{
		SetCameraCacheTime(InTime);
	}

	void SetLastFrameCameraCacheTime_WRAP(float InTime)
	{
		SetLastFrameCameraCacheTime(InTime);
	}

};


extern "C"
{
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_BlendParams_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->BlendParams); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_BlendParams_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->BlendParams = *(FViewTargetTransitionParams*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_BlendTimeToGo_GET(APlayerCameraManager* Ptr) { return Ptr->BlendTimeToGo; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_BlendTimeToGo_SET(APlayerCameraManager* Ptr, float Value) { Ptr->BlendTimeToGo = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_CameraCache_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->CameraCache); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_CameraCache_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->CameraCache = *(FCameraCacheEntry*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_CameraStyle_GET(APlayerCameraManager* Ptr) { return ConvertToManage_StringWrapper(Ptr->CameraStyle); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_CameraStyle_SET(APlayerCameraManager* Ptr, char* Value) { Ptr->CameraStyle = ConvertFromManage_FName(Value); }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_ColorScale_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->ColorScale); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_ColorScale_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->ColorScale = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_ColorScaleInterpDuration_GET(APlayerCameraManager* Ptr) { return Ptr->ColorScaleInterpDuration; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_ColorScaleInterpDuration_SET(APlayerCameraManager* Ptr, float Value) { Ptr->ColorScaleInterpDuration = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_ColorScaleInterpStartTime_GET(APlayerCameraManager* Ptr) { return Ptr->ColorScaleInterpStartTime; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_ColorScaleInterpStartTime_SET(APlayerCameraManager* Ptr, float Value) { Ptr->ColorScaleInterpStartTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_DefaultAspectRatio_GET(APlayerCameraManager* Ptr) { return Ptr->DefaultAspectRatio; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_DefaultAspectRatio_SET(APlayerCameraManager* Ptr, float Value) { Ptr->DefaultAspectRatio = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_DefaultFOV_GET(APlayerCameraManager* Ptr) { return Ptr->DefaultFOV; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_DefaultFOV_SET(APlayerCameraManager* Ptr, float Value) { Ptr->DefaultFOV = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_DefaultOrthoWidth_GET(APlayerCameraManager* Ptr) { return Ptr->DefaultOrthoWidth; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_DefaultOrthoWidth_SET(APlayerCameraManager* Ptr, float Value) { Ptr->DefaultOrthoWidth = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_DesiredColorScale_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->DesiredColorScale); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_DesiredColorScale_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->DesiredColorScale = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_FadeAlpha_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->FadeAlpha); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_FadeAlpha_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->FadeAlpha = *(FVector2D*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_FadeAmount_GET(APlayerCameraManager* Ptr) { return Ptr->FadeAmount; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_FadeAmount_SET(APlayerCameraManager* Ptr, float Value) { Ptr->FadeAmount = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_FadeColor_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->FadeColor); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_FadeColor_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->FadeColor = *(FLinearColor*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_FadeTime_GET(APlayerCameraManager* Ptr) { return Ptr->FadeTime; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_FadeTime_SET(APlayerCameraManager* Ptr, float Value) { Ptr->FadeTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_FadeTimeRemaining_GET(APlayerCameraManager* Ptr) { return Ptr->FadeTimeRemaining; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_FadeTimeRemaining_SET(APlayerCameraManager* Ptr, float Value) { Ptr->FadeTimeRemaining = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_FreeCamDistance_GET(APlayerCameraManager* Ptr) { return Ptr->FreeCamDistance; }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_FreeCamDistance_SET(APlayerCameraManager* Ptr, float Value) { Ptr->FreeCamDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_FreeCamOffset_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->FreeCamOffset); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_FreeCamOffset_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->FreeCamOffset = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_LastFrameCameraCache_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->LastFrameCameraCache); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_LastFrameCameraCache_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->LastFrameCameraCache = *(FCameraCacheEntry*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_OriginalColorScale_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->OriginalColorScale); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_OriginalColorScale_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->OriginalColorScale = *(FVector*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_PCOwner_GET(APlayerCameraManager* Ptr) { return ConvertToManage_ObjectPointerDescription(Ptr->PCOwner); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_PCOwner_SET(APlayerCameraManager* Ptr, APlayerController* Value) { Ptr->PCOwner = Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_PendingViewTarget_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->PendingViewTarget); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_PendingViewTarget_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->PendingViewTarget = *(FTViewTarget*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_ViewTarget_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->ViewTarget); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_ViewTarget_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->ViewTarget = *(FTViewTarget*)Value; }
	
	DOTNET_EXPORT auto E_PROP_APlayerCameraManager_ViewTargetOffset_GET(APlayerCameraManager* Ptr) { return (INT_PTR)&(Ptr->ViewTargetOffset); }
	DOTNET_EXPORT void E_PROP_APlayerCameraManager_ViewTargetOffset_SET(APlayerCameraManager* Ptr, INT_PTR Value) { Ptr->ViewTargetOffset = *(FVector*)Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_APlayerCameraManager(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<APlayerCameraManager>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_AddCachedPPBlend(APlayerCameraManager* Self, INT_PTR PPSettings, float BlendWeight)
	{
		auto& _p0 = *(FPostProcessSettings*)PPSettings;
		auto _p1 = BlendWeight;
		Self->AddCachedPPBlend(_p0, _p1);
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_ClearCachedPPBlends(APlayerCameraManager* Self)
	{
		((E_PROTECTED_WRAP_APlayerCameraManager*)Self)->ClearCachedPPBlends_WRAP();
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_GetCameraCachePOV(APlayerCameraManager* Self)
	{
		return (INT_PTR) new FMinimalViewInfo(Self->GetCameraCachePOV());
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_GetCameraCacheTime(APlayerCameraManager* Self)
	{
		return Self->GetCameraCacheTime();
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_GetLastFrameCameraCachePOV(APlayerCameraManager* Self)
	{
		return (INT_PTR) new FMinimalViewInfo(Self->GetLastFrameCameraCachePOV());
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_GetLastFrameCameraCacheTime(APlayerCameraManager* Self)
	{
		return Self->GetLastFrameCameraCacheTime();
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_GetLockedFOV(APlayerCameraManager* Self)
	{
		return Self->GetLockedFOV();
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_SetCameraCachePOV(APlayerCameraManager* Self, INT_PTR InPOV)
	{
		auto& _p0 = *(FMinimalViewInfo*)InPOV;
		Self->SetCameraCachePOV(_p0);
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_SetCameraCacheTime(APlayerCameraManager* Self, float InTime)
	{
		auto _p0 = InTime;
		((E_PROTECTED_WRAP_APlayerCameraManager*)Self)->SetCameraCacheTime_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_SetLastFrameCameraCachePOV(APlayerCameraManager* Self, INT_PTR InPOV)
	{
		auto& _p0 = *(FMinimalViewInfo*)InPOV;
		Self->SetLastFrameCameraCachePOV(_p0);
	}

	DOTNET_EXPORT auto E_APlayerCameraManager_SetLastFrameCameraCacheTime(APlayerCameraManager* Self, float InTime)
	{
		auto _p0 = InTime;
		((E_PROTECTED_WRAP_APlayerCameraManager*)Self)->SetLastFrameCameraCacheTime_WRAP(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_BeginPlay(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__BeginPlay();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_ClearCrossLevelReferences(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__ClearCrossLevelReferences();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_Destroyed(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__Destroyed();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_ForceNetRelevant(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__ForceNetRelevant();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_ForceNetUpdate(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__ForceNetUpdate();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_GatherCurrentMovement(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__GatherCurrentMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_InvalidateLightingCacheDetailed(AActor* Self, bool bTranslationOnly)
	{
		auto _p0 = bTranslationOnly;
		((AManagePlayerCameraManager*)Self)->_Supper__InvalidateLightingCacheDetailed(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_K2_DestroyActor(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__K2_DestroyActor();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_LifeSpanExpired(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__LifeSpanExpired();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_MarkComponentsAsPendingKill(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__MarkComponentsAsPendingKill();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_NotifyActorBeginCursorOver(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__NotifyActorBeginCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_NotifyActorEndCursorOver(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__NotifyActorEndCursorOver();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_OnRep_AttachmentReplication(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__OnRep_AttachmentReplication();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_OnRep_Instigator(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__OnRep_Instigator();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_OnRep_Owner(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__OnRep_Owner();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_OnRep_ReplicatedMovement(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__OnRep_ReplicatedMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_OnRep_ReplicateMovement(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__OnRep_ReplicateMovement();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_OnReplicationPausedChanged(AActor* Self, bool bIsReplicationPaused)
	{
		auto _p0 = bIsReplicationPaused;
		((AManagePlayerCameraManager*)Self)->_Supper__OnReplicationPausedChanged(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_OutsideWorldBounds(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__OutsideWorldBounds();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostActorCreated(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostActorCreated();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostInitializeComponents(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostNetInit(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostNetInit();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostNetReceiveLocationAndRotation(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostNetReceiveLocationAndRotation();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostNetReceivePhysicState(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostNetReceivePhysicState();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostNetReceiveRole(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostNetReceiveRole();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostRegisterAllComponents(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostUnregisterAllComponents(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostUnregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PreInitializeComponents(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PreInitializeComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PreRegisterAllComponents(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PreRegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PrestreamTextures(AActor* Self, float Seconds, bool bEnableStreaming, int32 CinematicTextureGroups)
	{
		auto _p0 = Seconds;
		auto _p1 = bEnableStreaming;
		auto _p2 = CinematicTextureGroups;
		((AManagePlayerCameraManager*)Self)->_Supper__PrestreamTextures(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_RegisterActorTickFunctions(AActor* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		((AManagePlayerCameraManager*)Self)->_Supper__RegisterActorTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_RegisterAllComponents(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__RegisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_ReregisterAllComponents(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__ReregisterAllComponents();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_RerunConstructionScripts(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__RerunConstructionScripts();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_Reset(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__Reset();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_RewindForReplay(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__RewindForReplay();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_SetActorHiddenInGame(AActor* Self, bool bNewHidden)
	{
		auto _p0 = bNewHidden;
		((AManagePlayerCameraManager*)Self)->_Supper__SetActorHiddenInGame(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_SetLifeSpan(AActor* Self, float InLifespan)
	{
		auto _p0 = InLifespan;
		((AManagePlayerCameraManager*)Self)->_Supper__SetLifeSpan(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_SetReplicateMovement(AActor* Self, bool bInReplicateMovement)
	{
		auto _p0 = bInReplicateMovement;
		((AManagePlayerCameraManager*)Self)->_Supper__SetReplicateMovement(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_TearOff(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__TearOff();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_TeleportSucceeded(AActor* Self, bool bIsATest)
	{
		auto _p0 = bIsATest;
		((AManagePlayerCameraManager*)Self)->_Supper__TeleportSucceeded(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_Tick(AActor* Self, float DeltaSeconds)
	{
		auto _p0 = DeltaSeconds;
		((AManagePlayerCameraManager*)Self)->_Supper__Tick(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_TornOff(AActor* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__TornOff();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_UnregisterAllComponents(AActor* Self, bool bForReregister)
	{
		auto _p0 = bForReregister;
		((AManagePlayerCameraManager*)Self)->_Supper__UnregisterAllComponents(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_BeginDestroy(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__BeginDestroy();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_FinishDestroy(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__FinishDestroy();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_MarkAsEditorOnlySubobject(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostCDOContruct(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostCDOContruct();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostEditImport(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostEditImport();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostInitProperties(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostInitProperties();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostLoad(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostLoad();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostNetReceive(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostRepNotifies(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PostRepNotifies();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PostSaveRoot(UObject* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		((AManagePlayerCameraManager*)Self)->_Supper__PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PreDestroyFromReplication(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_PreNetReceive(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__PreNetReceive();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_ShutdownAfterError(UObject* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__ShutdownAfterError();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_CreateCluster(UObjectBaseUtility* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__CreateCluster();
	}

	DOTNET_EXPORT auto E__Supper__APlayerCameraManager_OnClusterMarkedAsPendingKill(UObjectBaseUtility* Self)
	{
		((AManagePlayerCameraManager*)Self)->_Supper__OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
