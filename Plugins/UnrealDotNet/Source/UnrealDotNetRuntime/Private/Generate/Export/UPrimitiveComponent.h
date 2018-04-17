#pragma once
PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManagerObject.h"
#include "Runtime/Engine/Classes/Components/PrimitiveComponent.h"

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:170

class E_PROTECTED_WRAP_UPrimitiveComponent : protected UPrimitiveComponent
{
public:
	bool AreAllCollideableDescendantsRelative_WRAP(bool bAllowCachedValue)
	{
		return AreAllCollideableDescendantsRelative(bAllowCachedValue);
	}

	void ClearComponentOverlaps_WRAP(bool bDoNotifies, bool bSkipNotifySelf)
	{
		ClearComponentOverlaps(bDoNotifies, bSkipNotifySelf);
	}

	void EnsurePhysicsStateCreated_WRAP()
	{
		EnsurePhysicsStateCreated();
	}

	bool MoveComponentImpl_WRAP(const FVector& Delta, const FQuat& NewRotation, bool bSweep, FHitResult* OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		return MoveComponentImpl(Delta, NewRotation, bSweep, OutHit, MoveFlags, Teleport);
	}

	void OnComponentCollisionSettingsChanged_WRAP()
	{
		OnComponentCollisionSettingsChanged();
	}

	void OnCreatePhysicsState_WRAP()
	{
		OnCreatePhysicsState();
	}

	void OnDestroyPhysicsState_WRAP()
	{
		OnDestroyPhysicsState();
	}

	void SendPhysicsTransform_WRAP(ETeleportType Teleport)
	{
		SendPhysicsTransform(Teleport);
	}

	bool SupportsStaticLighting_WRAP()
	{
		return SupportsStaticLighting();
	}

	void UpdatePhysicsToRBChannels_WRAP()
	{
		UpdatePhysicsToRBChannels();
	}

	void OnChildAttached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildAttached(ChildComponent);
	}

	void OnChildDetached_WRAP(USceneComponent* ChildComponent)
	{
		OnChildDetached(ChildComponent);
	}

	void OnHiddenInGameChanged_WRAP()
	{
		OnHiddenInGameChanged();
	}

	void OnVisibilityChanged_WRAP()
	{
		OnVisibilityChanged();
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
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_AlwaysLoadOnClient_GET(UPrimitiveComponent* Ptr) { return Ptr->AlwaysLoadOnClient; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_AlwaysLoadOnClient_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->AlwaysLoadOnClient = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_AlwaysLoadOnServer_GET(UPrimitiveComponent* Ptr) { return Ptr->AlwaysLoadOnServer; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_AlwaysLoadOnServer_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->AlwaysLoadOnServer = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bAffectDistanceFieldLighting_GET(UPrimitiveComponent* Ptr) { return Ptr->bAffectDistanceFieldLighting; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bAffectDistanceFieldLighting_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bAffectDistanceFieldLighting = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bAffectDynamicIndirectLighting_GET(UPrimitiveComponent* Ptr) { return Ptr->bAffectDynamicIndirectLighting; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bAffectDynamicIndirectLighting_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bAffectDynamicIndirectLighting = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bAllowCullDistanceVolume_GET(UPrimitiveComponent* Ptr) { return Ptr->bAllowCullDistanceVolume; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bAllowCullDistanceVolume_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bAllowCullDistanceVolume = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bAlwaysCreatePhysicsState_GET(UPrimitiveComponent* Ptr) { return Ptr->bAlwaysCreatePhysicsState; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bAlwaysCreatePhysicsState_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bAlwaysCreatePhysicsState = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bApplyImpulseOnDamage_GET(UPrimitiveComponent* Ptr) { return Ptr->bApplyImpulseOnDamage; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bApplyImpulseOnDamage_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bApplyImpulseOnDamage = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsDynamic_GET(UPrimitiveComponent* Ptr) { return Ptr->bAttachedToStreamingManagerAsDynamic; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsDynamic_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bAttachedToStreamingManagerAsDynamic = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsStatic_GET(UPrimitiveComponent* Ptr) { return Ptr->bAttachedToStreamingManagerAsStatic; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsStatic_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bAttachedToStreamingManagerAsStatic = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bCastCinematicShadow_GET(UPrimitiveComponent* Ptr) { return Ptr->bCastCinematicShadow; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bCastCinematicShadow_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bCastCinematicShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bCastDynamicShadow_GET(UPrimitiveComponent* Ptr) { return Ptr->bCastDynamicShadow; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bCastDynamicShadow_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bCastDynamicShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bCastFarShadow_GET(UPrimitiveComponent* Ptr) { return Ptr->bCastFarShadow; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bCastFarShadow_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bCastFarShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bCastHiddenShadow_GET(UPrimitiveComponent* Ptr) { return Ptr->bCastHiddenShadow; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bCastHiddenShadow_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bCastHiddenShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bCastInsetShadow_GET(UPrimitiveComponent* Ptr) { return Ptr->bCastInsetShadow; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bCastInsetShadow_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bCastInsetShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bCastShadowAsTwoSided_GET(UPrimitiveComponent* Ptr) { return Ptr->bCastShadowAsTwoSided; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bCastShadowAsTwoSided_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bCastShadowAsTwoSided = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bCastStaticShadow_GET(UPrimitiveComponent* Ptr) { return Ptr->bCastStaticShadow; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bCastStaticShadow_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bCastStaticShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bCastVolumetricTranslucentShadow_GET(UPrimitiveComponent* Ptr) { return Ptr->bCastVolumetricTranslucentShadow; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bCastVolumetricTranslucentShadow_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bCastVolumetricTranslucentShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bCheckAsyncSceneOnMove_GET(UPrimitiveComponent* Ptr) { return Ptr->bCheckAsyncSceneOnMove; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bCheckAsyncSceneOnMove_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bCheckAsyncSceneOnMove = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bForceMipStreaming_GET(UPrimitiveComponent* Ptr) { return Ptr->bForceMipStreaming; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bForceMipStreaming_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bForceMipStreaming = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bGenerateOverlapEvents_GET(UPrimitiveComponent* Ptr) { return Ptr->bGenerateOverlapEvents; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bGenerateOverlapEvents_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bGenerateOverlapEvents = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bHandledByStreamingManagerAsDynamic_GET(UPrimitiveComponent* Ptr) { return Ptr->bHandledByStreamingManagerAsDynamic; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bHandledByStreamingManagerAsDynamic_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bHandledByStreamingManagerAsDynamic = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bHasMotionBlurVelocityMeshes_GET(UPrimitiveComponent* Ptr) { return Ptr->bHasMotionBlurVelocityMeshes; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bHasMotionBlurVelocityMeshes_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bHasMotionBlurVelocityMeshes = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bHasPerInstanceHitProxies_GET(UPrimitiveComponent* Ptr) { return Ptr->bHasPerInstanceHitProxies; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bHasPerInstanceHitProxies_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bHasPerInstanceHitProxies = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bIgnoreRadialForce_GET(UPrimitiveComponent* Ptr) { return Ptr->bIgnoreRadialForce; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bIgnoreRadialForce_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bIgnoreRadialForce = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bIgnoreRadialImpulse_GET(UPrimitiveComponent* Ptr) { return Ptr->bIgnoreRadialImpulse; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bIgnoreRadialImpulse_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bIgnoreRadialImpulse = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_GET(UPrimitiveComponent* Ptr) { return Ptr->bLightAsIfStatic_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bLightAsIfStatic_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_GET(UPrimitiveComponent* Ptr) { return Ptr->bLightAttachmentsAsGroup; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bLightAttachmentsAsGroup = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bMultiBodyOverlap_GET(UPrimitiveComponent* Ptr) { return Ptr->bMultiBodyOverlap; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bMultiBodyOverlap_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bMultiBodyOverlap = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bOnlyOwnerSee_GET(UPrimitiveComponent* Ptr) { return Ptr->bOnlyOwnerSee; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bOnlyOwnerSee_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bOnlyOwnerSee = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_BoundsScale_GET(UPrimitiveComponent* Ptr) { return Ptr->BoundsScale; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_BoundsScale_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->BoundsScale = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bOwnerNoSee_GET(UPrimitiveComponent* Ptr) { return Ptr->bOwnerNoSee; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bOwnerNoSee_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bOwnerNoSee = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bReceiveMobileCSMShadows_GET(UPrimitiveComponent* Ptr) { return Ptr->bReceiveMobileCSMShadows; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bReceiveMobileCSMShadows_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bReceiveMobileCSMShadows = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bReceivesDecals_GET(UPrimitiveComponent* Ptr) { return Ptr->bReceivesDecals; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bReceivesDecals_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bReceivesDecals = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bRenderCustomDepth_GET(UPrimitiveComponent* Ptr) { return Ptr->bRenderCustomDepth; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bRenderCustomDepth_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bRenderCustomDepth = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bRenderInMainPass_GET(UPrimitiveComponent* Ptr) { return Ptr->bRenderInMainPass; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bRenderInMainPass_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bRenderInMainPass = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bRenderInMono_GET(UPrimitiveComponent* Ptr) { return Ptr->bRenderInMono; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bRenderInMono_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bRenderInMono = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bReturnMaterialOnMove_GET(UPrimitiveComponent* Ptr) { return Ptr->bReturnMaterialOnMove; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bReturnMaterialOnMove_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bReturnMaterialOnMove = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bSelectable_GET(UPrimitiveComponent* Ptr) { return Ptr->bSelectable; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bSelectable_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bSelectable = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bSelfShadowOnly_GET(UPrimitiveComponent* Ptr) { return Ptr->bSelfShadowOnly; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bSelfShadowOnly_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bSelfShadowOnly = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bSingleSampleShadowFromStationaryLights_GET(UPrimitiveComponent* Ptr) { return Ptr->bSingleSampleShadowFromStationaryLights; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bSingleSampleShadowFromStationaryLights_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bSingleSampleShadowFromStationaryLights = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bTraceComplexOnMove_GET(UPrimitiveComponent* Ptr) { return Ptr->bTraceComplexOnMove; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bTraceComplexOnMove_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bTraceComplexOnMove = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bTreatAsBackgroundForOcclusion_GET(UPrimitiveComponent* Ptr) { return Ptr->bTreatAsBackgroundForOcclusion; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bTreatAsBackgroundForOcclusion_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bTreatAsBackgroundForOcclusion = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bUseAsOccluder_GET(UPrimitiveComponent* Ptr) { return Ptr->bUseAsOccluder; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bUseAsOccluder_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bUseAsOccluder = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bUseEditorCompositing_GET(UPrimitiveComponent* Ptr) { return Ptr->bUseEditorCompositing; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bUseEditorCompositing_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bUseEditorCompositing = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bUseViewOwnerDepthPriorityGroup_GET(UPrimitiveComponent* Ptr) { return Ptr->bUseViewOwnerDepthPriorityGroup; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bUseViewOwnerDepthPriorityGroup_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bUseViewOwnerDepthPriorityGroup = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_GET(UPrimitiveComponent* Ptr) { return Ptr->bVisibleInReflectionCaptures; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bVisibleInReflectionCaptures = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(UPrimitiveComponent* Ptr) { return Ptr->CachedMaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->CachedMaxDrawDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CastShadow_GET(UPrimitiveComponent* Ptr) { return Ptr->CastShadow; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CastShadow_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->CastShadow = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CurrentTag_GET() { return UPrimitiveComponent::CurrentTag; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(UPrimitiveComponent* Ptr) { return Ptr->CustomDepthStencilValue; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(UPrimitiveComponent* Ptr, int32 Value) { Ptr->CustomDepthStencilValue = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_GET(UPrimitiveComponent* Ptr) { return Ptr->CustomDepthStencilWriteMask; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_SET(UPrimitiveComponent* Ptr, ERendererStencilMask Value) { Ptr->CustomDepthStencilWriteMask = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LastRenderTime_GET(UPrimitiveComponent* Ptr) { return Ptr->LastRenderTime; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastRenderTime_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LastRenderTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(UPrimitiveComponent* Ptr) { return Ptr->LastRenderTimeOnScreen; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LastRenderTimeOnScreen = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LastSubmitTime_GET(UPrimitiveComponent* Ptr) { return Ptr->LastSubmitTime; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LastSubmitTime_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LastSubmitTime = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(UPrimitiveComponent* Ptr) { return Ptr->LDMaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LDMaxDrawDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LightingChannels_GET(UPrimitiveComponent* Ptr) { return (INT_PTR)&(Ptr->LightingChannels); }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LightingChannels_SET(UPrimitiveComponent* Ptr, INT_PTR Value) { Ptr->LightingChannels = *(FLightingChannels*)Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LightmapType_GET(UPrimitiveComponent* Ptr) { return Ptr->LightmapType; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LightmapType_SET(UPrimitiveComponent* Ptr, ELightmapType Value) { Ptr->LightmapType = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(UPrimitiveComponent* Ptr) { return Ptr->LpvBiasMultiplier; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->LpvBiasMultiplier = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_MinDrawDistance_GET(UPrimitiveComponent* Ptr) { return Ptr->MinDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_MinDrawDistance_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->MinDrawDistance = Value; }
	
	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnBeginCursorOver(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnBeginCursorOver";
		wrapper->SourceObject = Obj;
		Obj->OnBeginCursorOver.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentBeginCursorOverSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnBeginCursorOver(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentBeginOverlap(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentBeginOverlap";
		wrapper->SourceObject = Obj;
		Obj->OnComponentBeginOverlap.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentBeginOverlapSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentBeginOverlap(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentCollisionSettingsChangedEvent";
		wrapper->SourceObject = Obj;
		Obj->OnComponentCollisionSettingsChangedEvent.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentCollisionSettingsChangedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentEndOverlap(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentEndOverlap";
		wrapper->SourceObject = Obj;
		Obj->OnComponentEndOverlap.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentEndOverlapSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentEndOverlap(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentHit(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentHit";
		wrapper->SourceObject = Obj;
		Obj->OnComponentHit.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentHitSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentHit(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentSleep(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentSleep";
		wrapper->SourceObject = Obj;
		Obj->OnComponentSleep.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentSleepSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentSleep(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentWake(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentWake";
		wrapper->SourceObject = Obj;
		Obj->OnComponentWake.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentWakeSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentWake(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnEndCursorOver(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetDotNetManager());
		wrapper->ManageDelegateName = "InvokeEvent_OnEndCursorOver";
		wrapper->SourceObject = Obj;
		Obj->OnEndCursorOver.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentEndCursorOverSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnEndCursorOver(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(UPrimitiveComponent* Ptr) { return Ptr->TranslucencySortPriority; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(UPrimitiveComponent* Ptr, int32 Value) { Ptr->TranslucencySortPriority = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_VisibilityId_GET(UPrimitiveComponent* Ptr) { return Ptr->VisibilityId; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_VisibilityId_SET(UPrimitiveComponent* Ptr, int32 Value) { Ptr->VisibilityId = Value; }
	
	
	DOTNET_EXPORT INT_PTR E_NewObject_UPrimitiveComponent(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UPrimitiveComponent>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddAngularImpulse(UPrimitiveComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddAngularImpulseInDegrees(UPrimitiveComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInDegrees(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddAngularImpulseInRadians(UPrimitiveComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddAngularImpulseInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddForce(UPrimitiveComponent* Self, INT_PTR Force, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddForce(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddForceAtLocation(UPrimitiveComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddForceAtLocationLocal(UPrimitiveComponent* Self, INT_PTR Force, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Force;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddForceAtLocationLocal(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddImpulse(UPrimitiveComponent* Self, INT_PTR Impulse, char* BoneName, bool bVelChange)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bVelChange;
		Self->AddImpulse(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddImpulseAtLocation(UPrimitiveComponent* Self, INT_PTR Impulse, INT_PTR Location, char* BoneName)
	{
		auto _p0 = *(FVector*)Impulse;
		auto _p1 = *(FVector*)Location;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->AddImpulseAtLocation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddRadialForce(UPrimitiveComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bAccelChange;
		Self->AddRadialForce(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddRadialImpulse(UPrimitiveComponent* Self, INT_PTR Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = Radius;
		auto _p2 = Strength;
		auto _p3 = Falloff;
		auto _p4 = bVelChange;
		Self->AddRadialImpulse(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddTorque(UPrimitiveComponent* Self, INT_PTR Torque, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Torque;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddTorque(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddTorqueInDegrees(UPrimitiveComponent* Self, INT_PTR Torque, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Torque;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddTorqueInDegrees(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddTorqueInRadians(UPrimitiveComponent* Self, INT_PTR Torque, char* BoneName, bool bAccelChange)
	{
		auto _p0 = *(FVector*)Torque;
		auto _p1 = ConvertFromManage_FName(BoneName);
		auto _p2 = bAccelChange;
		Self->AddTorqueInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(UPrimitiveComponent* Self, bool bAllowCachedValue)
	{
		auto _p0 = bAllowCachedValue;
		return ((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->AreAllCollideableDescendantsRelative_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AreSymmetricRotations(UPrimitiveComponent* Self, INT_PTR A, INT_PTR B, INT_PTR Scale3D)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_BeginComponentOverlap(UPrimitiveComponent* Self, INT_PTR OtherOverlap, bool bDoNotifies)
	{
		auto _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		Self->BeginComponentOverlap(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_BeginDestroy(UPrimitiveComponent* Self)
	{
		Self->BeginDestroy();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_BeginPlay(UPrimitiveComponent* Self)
	{
		Self->BeginPlay();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CalculateMass(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->CalculateMass(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CanCharacterStepUp(UPrimitiveComponent* Self, APawn* Pawn)
	{
		auto _p0 = Pawn;
		return Self->CanCharacterStepUp(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CanEditSimulatePhysics(UPrimitiveComponent* Self)
	{
		return Self->CanEditSimulatePhysics();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ClearComponentOverlaps(UPrimitiveComponent* Self, bool bDoNotifies, bool bSkipNotifySelf)
	{
		auto _p0 = bDoNotifies;
		auto _p1 = bSkipNotifySelf;
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->ClearComponentOverlaps_WRAP(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ClearMoveIgnoreActors(UPrimitiveComponent* Self)
	{
		Self->ClearMoveIgnoreActors();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ClearMoveIgnoreComponents(UPrimitiveComponent* Self)
	{
		Self->ClearMoveIgnoreComponents();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ConditionalApplyRigidBodyState(UPrimitiveComponent* Self, INT_PTR UpdatedState, INT_PTR ErrorCorrection, INT_PTR OutDeltaPos, char* BoneName)
	{
		auto _p0 = *(FRigidBodyState*)UpdatedState;
		auto _p1 = *(FRigidBodyErrorCorrection*)ErrorCorrection;
		auto _p2 = *(FVector*)OutDeltaPos;
		auto _p3 = ConvertFromManage_FName(BoneName);
		return Self->ConditionalApplyRigidBodyState(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CreateRenderState_Concurrent(UPrimitiveComponent* Self)
	{
		Self->CreateRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DestroyRenderState_Concurrent(UPrimitiveComponent* Self)
	{
		Self->DestroyRenderState_Concurrent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DispatchMouseOverEvents(UPrimitiveComponent* Self, UPrimitiveComponent* CurrentComponent, UPrimitiveComponent* NewComponent)
	{
		auto _p0 = CurrentComponent;
		auto _p1 = NewComponent;
		Self->DispatchMouseOverEvents(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DispatchWakeEvents(UPrimitiveComponent* Self, int32 WakeEvent, char* BoneName)
	{
		auto _p0 = WakeEvent;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->DispatchWakeEvents(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_EndComponentOverlap(UPrimitiveComponent* Self, INT_PTR OtherOverlap, bool bDoNotifies, bool bSkipNotifySelf)
	{
		auto _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		auto _p2 = bSkipNotifySelf;
		Self->EndComponentOverlap(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_EnsurePhysicsStateCreated(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->EnsurePhysicsStateCreated_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_FinishDestroy(UPrimitiveComponent* Self)
	{
		Self->FinishDestroy();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetAngularDamping(UPrimitiveComponent* Self)
	{
		return Self->GetAngularDamping();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetCenterOfMass(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetCenterOfMass(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetClosestPointOnCollision(UPrimitiveComponent* Self, INT_PTR Point, INT_PTR OutPointOnBody, char* BoneName)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)OutPointOnBody;
		auto _p2 = ConvertFromManage_FName(BoneName);
		return Self->GetClosestPointOnCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetCollisionObjectType(UPrimitiveComponent* Self)
	{
		return Self->GetCollisionObjectType();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetCollisionProfileName(UPrimitiveComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetCollisionProfileName());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetCollisionResponseToChannel(UPrimitiveComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		return Self->GetCollisionResponseToChannel(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetComponentVelocity(UPrimitiveComponent* Self)
	{
		return (INT_PTR) new FVector(Self->GetComponentVelocity());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetDiffuseBoost(UPrimitiveComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetDistanceToCollision(UPrimitiveComponent* Self, INT_PTR Point, INT_PTR ClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)ClosestPointOnCollision;
		return Self->GetDistanceToCollision(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetEmissiveBoost(UPrimitiveComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetInertiaTensor(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(UPrimitiveComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto _p0 = LightMapMemoryUsage;
		auto _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetLightMapResolution(UPrimitiveComponent* Self, int32 Width, int32 Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->GetLightMapResolution(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetLinearDamping(UPrimitiveComponent* Self)
	{
		return Self->GetLinearDamping();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetLODParentPrimitive(UPrimitiveComponent* Self)
	{
		return ConvertToManage_ObjectPointerDescription(Self->GetLODParentPrimitive());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetMass(UPrimitiveComponent* Self)
	{
		return Self->GetMass();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetMassScale(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->GetMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetNavigationBounds(UPrimitiveComponent* Self)
	{
		return (INT_PTR) new FBox(Self->GetNavigationBounds());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetNumMaterials(UPrimitiveComponent* Self)
	{
		return Self->GetNumMaterials();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetPhysicsAngularVelocity(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetPhysicsAngularVelocity(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetPhysicsAngularVelocityInDegrees(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetPhysicsAngularVelocityInDegrees(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetPhysicsAngularVelocityInRadians(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetPhysicsAngularVelocityInRadians(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetPhysicsLinearVelocity(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetPhysicsLinearVelocity(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(UPrimitiveComponent* Self, INT_PTR Point, char* BoneName)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetPhysicsLinearVelocityAtPoint(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetRigidBodyState(UPrimitiveComponent* Self, INT_PTR OutState, char* BoneName)
	{
		auto _p0 = *(FRigidBodyState*)OutState;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return Self->GetRigidBodyState(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetShadowIndirectOnly(UPrimitiveComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetSquaredDistanceToCollision(UPrimitiveComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = OutSquaredDistance;
		auto _p2 = *(FVector*)OutClosestPointOnCollision;
		return Self->GetSquaredDistanceToCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetStaticDepthPriorityGroup(UPrimitiveComponent* Self)
	{
		return Self->GetStaticDepthPriorityGroup();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetStaticLightMapResolution(UPrimitiveComponent* Self)
	{
		return Self->GetStaticLightMapResolution();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_HasStaticLighting(UPrimitiveComponent* Self)
	{
		return Self->HasStaticLighting();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_HasValidPhysicsState(UPrimitiveComponent* Self)
	{
		return Self->HasValidPhysicsState();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_HasValidSettingsForStaticLighting(UPrimitiveComponent* Self, bool bOverlookInvalidComponents)
	{
		auto _p0 = bOverlookInvalidComponents;
		return Self->HasValidSettingsForStaticLighting(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IgnoreActorWhenMoving(UPrimitiveComponent* Self, AActor* Actor, bool bShouldIgnore)
	{
		auto _p0 = Actor;
		auto _p1 = bShouldIgnore;
		Self->IgnoreActorWhenMoving(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IgnoreComponentWhenMoving(UPrimitiveComponent* Self, UPrimitiveComponent* Component, bool bShouldIgnore)
	{
		auto _p0 = Component;
		auto _p1 = bShouldIgnore;
		Self->IgnoreComponentWhenMoving(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_InvalidateLightingCacheDetailed(UPrimitiveComponent* Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
	{
		auto _p0 = bInvalidateBuildEnqueuedLighting;
		auto _p1 = bTranslationOnly;
		Self->InvalidateLightingCacheDetailed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsAnyRigidBodyAwake(UPrimitiveComponent* Self)
	{
		return Self->IsAnyRigidBodyAwake();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsAttachedToStreamingManager(UPrimitiveComponent* Self)
	{
		return Self->IsAttachedToStreamingManager();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsComponentIndividuallySelected(UPrimitiveComponent* Self)
	{
		return Self->IsComponentIndividuallySelected();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsEditorOnly(UPrimitiveComponent* Self)
	{
		return Self->IsEditorOnly();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsGravityEnabled(UPrimitiveComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsNavigationRelevant(UPrimitiveComponent* Self)
	{
		return Self->IsNavigationRelevant();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsOverlappingActor(UPrimitiveComponent* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsOverlappingActor(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(UPrimitiveComponent* Self)
	{
		return Self->IsPostPhysicsComponentTickEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsReadyForFinishDestroy(UPrimitiveComponent* Self)
	{
		return Self->IsReadyForFinishDestroy();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsSimulatingPhysics(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->IsSimulatingPhysics(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsWelded(UPrimitiveComponent* Self)
	{
		return Self->IsWelded();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsWorldGeometry(UPrimitiveComponent* Self)
	{
		return Self->IsWorldGeometry();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsZeroExtent(UPrimitiveComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_IsCollisionEnabled(UPrimitiveComponent* Self)
	{
		return Self->K2_IsCollisionEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(UPrimitiveComponent* Self)
	{
		return Self->K2_IsPhysicsCollisionEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(UPrimitiveComponent* Self)
	{
		return Self->K2_IsQueryCollisionEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_LineTraceComponent(UPrimitiveComponent* Self, INT_PTR TraceStart, INT_PTR TraceEnd, bool bTraceComplex, bool bShowTrace, INT_PTR HitLocation, INT_PTR HitNormal, char* BoneName, INT_PTR OutHit)
	{
		auto _p0 = *(FVector*)TraceStart;
		auto _p1 = *(FVector*)TraceEnd;
		auto _p2 = bTraceComplex;
		auto _p3 = bShowTrace;
		auto _p4 = *(FVector*)HitLocation;
		auto _p5 = *(FVector*)HitNormal;
		auto _p6 = ConvertFromManage_FName(BoneName);
		auto _p7 = *(FHitResult*)OutHit;
		return Self->K2_LineTraceComponent(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_MoveComponentImpl(UPrimitiveComponent* Self, INT_PTR Delta, INT_PTR NewRotation, bool bSweep, INT_PTR OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
	{
		auto _p0 = *(FVector*)Delta;
		auto _p1 = *(FQuat*)NewRotation;
		auto _p2 = bSweep;
		auto _p3 = (FHitResult*)OutHit;
		auto _p4 = MoveFlags;
		auto _p5 = Teleport;
		return ((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->MoveComponentImpl_WRAP(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_NeedsLoadForClient(UPrimitiveComponent* Self)
	{
		return Self->NeedsLoadForClient();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_NeedsLoadForServer(UPrimitiveComponent* Self)
	{
		return Self->NeedsLoadForServer();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnActorEnableCollisionChanged(UPrimitiveComponent* Self)
	{
		Self->OnActorEnableCollisionChanged();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnAttachmentChanged(UPrimitiveComponent* Self)
	{
		Self->OnAttachmentChanged();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnComponentDestroyed(UPrimitiveComponent* Self, bool bDestroyingHierarchy)
	{
		auto _p0 = bDestroyingHierarchy;
		Self->OnComponentDestroyed(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnCreatePhysicsState(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnCreatePhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnDestroyPhysicsState(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnDestroyPhysicsState_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnRegister(UPrimitiveComponent* Self)
	{
		Self->OnRegister();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnUnregister(UPrimitiveComponent* Self)
	{
		Self->OnUnregister();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnUpdateTransform(UPrimitiveComponent* Self, EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
	{
		auto _p0 = UpdateTransformFlags;
		auto _p1 = Teleport;
		Self->OnUpdateTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PostDuplicate(UPrimitiveComponent* Self, bool bDuplicateForPIE)
	{
		auto _p0 = bDuplicateForPIE;
		Self->PostDuplicate(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PostLoad(UPrimitiveComponent* Self)
	{
		Self->PostLoad();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PushHoveredToProxy(UPrimitiveComponent* Self, bool bInHovered)
	{
		auto _p0 = bInHovered;
		Self->PushHoveredToProxy(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PushSelectionToProxy(UPrimitiveComponent* Self)
	{
		Self->PushSelectionToProxy();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PutAllRigidBodiesToSleep(UPrimitiveComponent* Self)
	{
		Self->PutAllRigidBodiesToSleep();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PutRigidBodyToSleep(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->PutRigidBodyToSleep(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_RegisterComponentTickFunctions(UPrimitiveComponent* Self, bool bRegister)
	{
		auto _p0 = bRegister;
		Self->RegisterComponentTickFunctions(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_RigidBodyIsAwake(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return Self->RigidBodyIsAwake(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ScaleByMomentOfInertia(UPrimitiveComponent* Self, INT_PTR InputVector, char* BoneName)
	{
		auto _p0 = *(FVector*)InputVector;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->ScaleByMomentOfInertia(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SendPhysicsTransform(UPrimitiveComponent* Self, ETeleportType Teleport)
	{
		auto _p0 = Teleport;
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->SendPhysicsTransform_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SendRenderTransform_Concurrent(UPrimitiveComponent* Self)
	{
		Self->SendRenderTransform_Concurrent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsAngularVelocity(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInDegrees(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInDegrees(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInRadians(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInRadians(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(UPrimitiveComponent* Self, INT_PTR NewVel, bool bAddToCurrent)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsLinearVelocity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsPosition(UPrimitiveComponent* Self, INT_PTR NewPos)
	{
		auto _p0 = *(FVector*)NewPos;
		Self->SetAllPhysicsPosition(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllUseCCD(UPrimitiveComponent* Self, bool InUseCCD)
	{
		auto _p0 = InUseCCD;
		Self->SetAllUseCCD(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAngularDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetAngularDamping(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetBoundsScale(UPrimitiveComponent* Self, float NewBoundsScale)
	{
		auto _p0 = NewBoundsScale;
		Self->SetBoundsScale(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCachedMaxDrawDistance(UPrimitiveComponent* Self, float NewCachedMaxDrawDistance)
	{
		auto _p0 = NewCachedMaxDrawDistance;
		Self->SetCachedMaxDrawDistance(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCastShadow(UPrimitiveComponent* Self, bool NewCastShadow)
	{
		auto _p0 = NewCastShadow;
		Self->SetCastShadow(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCenterOfMass(UPrimitiveComponent* Self, INT_PTR CenterOfMassOffset, char* BoneName)
	{
		auto _p0 = *(FVector*)CenterOfMassOffset;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetCenterOfMass(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCollisionObjectType(UPrimitiveComponent* Self, ECollisionChannel Channel)
	{
		auto _p0 = Channel;
		Self->SetCollisionObjectType(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCollisionProfileName(UPrimitiveComponent* Self, char* InCollisionProfileName)
	{
		auto _p0 = ConvertFromManage_FName(InCollisionProfileName);
		Self->SetCollisionProfileName(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCollisionResponseToAllChannels(UPrimitiveComponent* Self, ECollisionResponse NewResponse)
	{
		auto _p0 = NewResponse;
		Self->SetCollisionResponseToAllChannels(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCollisionResponseToChannel(UPrimitiveComponent* Self, ECollisionChannel Channel, ECollisionResponse NewResponse)
	{
		auto _p0 = Channel;
		auto _p1 = NewResponse;
		Self->SetCollisionResponseToChannel(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCollisionResponseToChannels(UPrimitiveComponent* Self, INT_PTR NewReponses)
	{
		auto _p0 = *(FCollisionResponseContainer*)NewReponses;
		Self->SetCollisionResponseToChannels(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCullDistance(UPrimitiveComponent* Self, float NewCullDistance)
	{
		auto _p0 = NewCullDistance;
		Self->SetCullDistance(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCustomDepthStencilValue(UPrimitiveComponent* Self, int32 Value)
	{
		auto _p0 = Value;
		Self->SetCustomDepthStencilValue(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(UPrimitiveComponent* Self, ERendererStencilMask WriteMaskBit)
	{
		auto _p0 = WriteMaskBit;
		Self->SetCustomDepthStencilWriteMask(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetDepthPriorityGroup(UPrimitiveComponent* Self, ESceneDepthPriorityGroup NewDepthPriorityGroup)
	{
		auto _p0 = NewDepthPriorityGroup;
		Self->SetDepthPriorityGroup(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetEnableGravity(UPrimitiveComponent* Self, bool bGravityEnabled)
	{
		auto _p0 = bGravityEnabled;
		Self->SetEnableGravity(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetLinearDamping(UPrimitiveComponent* Self, float InDamping)
	{
		auto _p0 = InDamping;
		Self->SetLinearDamping(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetLODParentPrimitive(UPrimitiveComponent* Self, UPrimitiveComponent* InLODParentPrimitive)
	{
		auto _p0 = InLODParentPrimitive;
		Self->SetLODParentPrimitive(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetMassOverrideInKg(UPrimitiveComponent* Self, char* BoneName, float MassInKg, bool bOverrideMass)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = MassInKg;
		auto _p2 = bOverrideMass;
		Self->SetMassOverrideInKg(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetMassScale(UPrimitiveComponent* Self, char* BoneName, float InMassScale)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		auto _p1 = InMassScale;
		Self->SetMassScale(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetNotifyRigidBodyCollision(UPrimitiveComponent* Self, bool bNewNotifyRigidBodyCollision)
	{
		auto _p0 = bNewNotifyRigidBodyCollision;
		Self->SetNotifyRigidBodyCollision(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetOnlyOwnerSee(UPrimitiveComponent* Self, bool bNewOnlyOwnerSee)
	{
		auto _p0 = bNewOnlyOwnerSee;
		Self->SetOnlyOwnerSee(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetOwnerNoSee(UPrimitiveComponent* Self, bool bNewOwnerNoSee)
	{
		auto _p0 = bNewOwnerNoSee;
		Self->SetOwnerNoSee(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsAngularVelocity(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsAngularVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsAngularVelocityInDegrees(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsAngularVelocityInDegrees(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsAngularVelocityInRadians(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsAngularVelocityInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsLinearVelocity(UPrimitiveComponent* Self, INT_PTR NewVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = *(FVector*)NewVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsLinearVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(UPrimitiveComponent* Self, float NewMaxAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = NewMaxAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsMaxAngularVelocity(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInDegrees(UPrimitiveComponent* Self, float NewMaxAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = NewMaxAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsMaxAngularVelocityInDegrees(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInRadians(UPrimitiveComponent* Self, float NewMaxAngVel, bool bAddToCurrent, char* BoneName)
	{
		auto _p0 = NewMaxAngVel;
		auto _p1 = bAddToCurrent;
		auto _p2 = ConvertFromManage_FName(BoneName);
		Self->SetPhysicsMaxAngularVelocityInRadians(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(UPrimitiveComponent* Self, bool bEnable)
	{
		auto _p0 = bEnable;
		Self->SetPostPhysicsComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetReceivesDecals(UPrimitiveComponent* Self, bool bNewReceivesDecals)
	{
		auto _p0 = bNewReceivesDecals;
		Self->SetReceivesDecals(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetRenderCustomDepth(UPrimitiveComponent* Self, bool bValue)
	{
		auto _p0 = bValue;
		Self->SetRenderCustomDepth(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetRenderInMainPass(UPrimitiveComponent* Self, bool bValue)
	{
		auto _p0 = bValue;
		Self->SetRenderInMainPass(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetRenderInMono(UPrimitiveComponent* Self, bool bValue)
	{
		auto _p0 = bValue;
		Self->SetRenderInMono(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetSimulatePhysics(UPrimitiveComponent* Self, bool bSimulate)
	{
		auto _p0 = bSimulate;
		Self->SetSimulatePhysics(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(UPrimitiveComponent* Self, bool bNewSingleSampleShadowFromStationaryLights)
	{
		auto _p0 = bNewSingleSampleShadowFromStationaryLights;
		Self->SetSingleSampleShadowFromStationaryLights(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetTranslucentSortPriority(UPrimitiveComponent* Self, int32 NewTranslucentSortPriority)
	{
		auto _p0 = NewTranslucentSortPriority;
		Self->SetTranslucentSortPriority(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetUseCCD(UPrimitiveComponent* Self, bool InUseCCD, char* BoneName)
	{
		auto _p0 = InUseCCD;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetUseCCD(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(UPrimitiveComponent* Self, bool bNewUseViewOwnerDepthPriorityGroup, ESceneDepthPriorityGroup NewViewOwnerDepthPriorityGroup)
	{
		auto _p0 = bNewUseViewOwnerDepthPriorityGroup;
		auto _p1 = NewViewOwnerDepthPriorityGroup;
		Self->SetViewOwnerDepthPriorityGroup(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetWalkableSlopeOverride(UPrimitiveComponent* Self, INT_PTR NewOverride)
	{
		auto _p0 = *(FWalkableSlopeOverride*)NewOverride;
		Self->SetWalkableSlopeOverride(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldComponentAddToScene(UPrimitiveComponent* Self)
	{
		return Self->ShouldComponentAddToScene();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldCreatePhysicsState(UPrimitiveComponent* Self)
	{
		return Self->ShouldCreatePhysicsState();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldRecreateProxyOnUpdateTransform(UPrimitiveComponent* Self)
	{
		return Self->ShouldRecreateProxyOnUpdateTransform();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldRenderSelected(UPrimitiveComponent* Self)
	{
		return Self->ShouldRenderSelected();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SupportsStaticLighting(UPrimitiveComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->SupportsStaticLighting_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SyncComponentToRBPhysics(UPrimitiveComponent* Self)
	{
		Self->SyncComponentToRBPhysics();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UnWeldChildren(UPrimitiveComponent* Self)
	{
		Self->UnWeldChildren();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UnWeldFromParent(UPrimitiveComponent* Self)
	{
		Self->UnWeldFromParent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UpdatePhysicsToRBChannels(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->UpdatePhysicsToRBChannels_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UpdatePhysicsVolume(UPrimitiveComponent* Self, bool bTriggerNotifiers)
	{
		auto _p0 = bTriggerNotifiers;
		Self->UpdatePhysicsVolume(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UsesOnlyUnlitMaterials(UPrimitiveComponent* Self)
	{
		return Self->UsesOnlyUnlitMaterials();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_WakeAllRigidBodies(UPrimitiveComponent* Self)
	{
		Self->WakeAllRigidBodies();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_WakeRigidBody(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		Self->WakeRigidBody(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_WeldTo(UPrimitiveComponent* Self, USceneComponent* InParent, char* InSocketName)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(InSocketName);
		Self->WeldTo(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_WeldToImplementation(UPrimitiveComponent* Self, USceneComponent* InParent, char* ParentSocketName, bool bWeldSimulatedChild)
	{
		auto _p0 = InParent;
		auto _p1 = ConvertFromManage_FName(ParentSocketName);
		auto _p2 = bWeldSimulatedChild;
		return Self->WeldToImplementation(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ApplyWorldOffset(UPrimitiveComponent* Self, INT_PTR InOffset, bool bWorldShift)
	{
		auto _p0 = *(FVector*)InOffset;
		auto _p1 = bWorldShift;
		Self->ApplyWorldOffset(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CalcBoundingCylinder(UPrimitiveComponent* Self, float CylinderRadius, float CylinderHalfHeight)
	{
		auto _p0 = CylinderRadius;
		auto _p1 = CylinderHalfHeight;
		Self->CalcBoundingCylinder(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CanAttachAsChild(UPrimitiveComponent* Self, USceneComponent* ChildComponent, char* SocketName)
	{
		auto _p0 = ChildComponent;
		auto _p1 = ConvertFromManage_FName(SocketName);
		return Self->CanAttachAsChild(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DestroyComponent(UPrimitiveComponent* Self, bool bPromoteChildren)
	{
		auto _p0 = bPromoteChildren;
		Self->DestroyComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DetachFromComponent(UPrimitiveComponent* Self, INT_PTR DetachmentRules)
	{
		auto _p0 = *(FDetachmentTransformRules*)DetachmentRules;
		Self->DetachFromComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DetachFromParent(UPrimitiveComponent* Self, bool bMaintainWorldPosition, bool bCallModify)
	{
		auto _p0 = bMaintainWorldPosition;
		auto _p1 = bCallModify;
		Self->DetachFromParent(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DoesSocketExist(UPrimitiveComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return Self->DoesSocketExist(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetSocketLocation(UPrimitiveComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FVector(Self->GetSocketLocation(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetSocketQuaternion(UPrimitiveComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FQuat(Self->GetSocketQuaternion(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetSocketRotation(UPrimitiveComponent* Self, char* InSocketName)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		return (INT_PTR) new FRotator(Self->GetSocketRotation(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetSocketTransform(UPrimitiveComponent* Self, char* InSocketName, ERelativeTransformSpace TransformSpace)
	{
		auto _p0 = ConvertFromManage_FName(InSocketName);
		auto _p1 = TransformSpace;
		return (INT_PTR) new FTransform(Self->GetSocketTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_HasAnySockets(UPrimitiveComponent* Self)
	{
		return Self->HasAnySockets();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsAnySimulatingPhysics(UPrimitiveComponent* Self)
	{
		return Self->IsAnySimulatingPhysics();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsPrecomputedLightingValid(UPrimitiveComponent* Self)
	{
		return Self->IsPrecomputedLightingValid();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsVisible(UPrimitiveComponent* Self)
	{
		return Self->IsVisible();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsVisibleInEditor(UPrimitiveComponent* Self)
	{
		return Self->IsVisibleInEditor();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnChildAttached(UPrimitiveComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnChildAttached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnChildDetached(UPrimitiveComponent* Self, USceneComponent* ChildComponent)
	{
		auto _p0 = ChildComponent;
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnChildDetached_WRAP(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnHiddenInGameChanged(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnHiddenInGameChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnVisibilityChanged(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnVisibilityChanged_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PostNetReceive(UPrimitiveComponent* Self)
	{
		Self->PostNetReceive();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PostRepNotifies(UPrimitiveComponent* Self)
	{
		Self->PostRepNotifies();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PreNetReceive(UPrimitiveComponent* Self)
	{
		Self->PreNetReceive();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PropagateLightingScenarioChange(UPrimitiveComponent* Self)
	{
		Self->PropagateLightingScenarioChange();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetRelativeScale3D(UPrimitiveComponent* Self, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewScale3D;
		Self->SetRelativeScale3D(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldCollideWhenPlacing(UPrimitiveComponent* Self)
	{
		return Self->ShouldCollideWhenPlacing();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldCreateRenderState(UPrimitiveComponent* Self)
	{
		return Self->ShouldCreateRenderState();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_Activate(UPrimitiveComponent* Self, bool bReset)
	{
		auto _p0 = bReset;
		Self->Activate(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddTickPrerequisiteActor(UPrimitiveComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->AddTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddTickPrerequisiteComponent(UPrimitiveComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->AddTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_Deactivate(UPrimitiveComponent* Self)
	{
		Self->Deactivate();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetComponentClassCanReplicate(UPrimitiveComponent* Self)
	{
		return Self->GetComponentClassCanReplicate();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetReadableName(UPrimitiveComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetReadableName());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_InitializeComponent(UPrimitiveComponent* Self)
	{
		Self->InitializeComponent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsActive(UPrimitiveComponent* Self)
	{
		return Self->IsActive();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsNameStableForNetworking(UPrimitiveComponent* Self)
	{
		return Self->IsNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsReadyForOwnerToAutoDestroy(UPrimitiveComponent* Self)
	{
		return Self->IsReadyForOwnerToAutoDestroy();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsSupportedForNetworking(UPrimitiveComponent* Self)
	{
		return Self->IsSupportedForNetworking();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_MarkAsEditorOnlySubobject(UPrimitiveComponent* Self)
	{
		Self->MarkAsEditorOnlySubobject();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_NeedsLoadForEditorGame(UPrimitiveComponent* Self)
	{
		return Self->NeedsLoadForEditorGame();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnComponentCreated(UPrimitiveComponent* Self)
	{
		Self->OnComponentCreated();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PostInitProperties(UPrimitiveComponent* Self)
	{
		Self->PostInitProperties();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PostRename(UPrimitiveComponent* Self, UObject* OldOuter, char* OldName)
	{
		auto _p0 = OldOuter;
		auto _p1 = ConvertFromManage_FName(OldName);
		Self->PostRename(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_RemoveTickPrerequisiteActor(UPrimitiveComponent* Self, AActor* PrerequisiteActor)
	{
		auto _p0 = PrerequisiteActor;
		Self->RemoveTickPrerequisiteActor(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_RemoveTickPrerequisiteComponent(UPrimitiveComponent* Self, UActorComponent* PrerequisiteComponent)
	{
		auto _p0 = PrerequisiteComponent;
		Self->RemoveTickPrerequisiteComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_RequiresGameThreadEndOfFrameRecreate(UPrimitiveComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameRecreate();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_RequiresGameThreadEndOfFrameUpdates(UPrimitiveComponent* Self)
	{
		return Self->RequiresGameThreadEndOfFrameUpdates();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SendRenderDynamicData_Concurrent(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->SendRenderDynamicData_Concurrent_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetActive(UPrimitiveComponent* Self, bool bNewActive, bool bReset)
	{
		auto _p0 = bNewActive;
		auto _p1 = bReset;
		Self->SetActive(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAutoActivate(UPrimitiveComponent* Self, bool bNewAutoActivate)
	{
		auto _p0 = bNewAutoActivate;
		Self->SetAutoActivate(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetComponentTickEnabled(UPrimitiveComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabled(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetComponentTickEnabledAsync(UPrimitiveComponent* Self, bool bEnabled)
	{
		auto _p0 = bEnabled;
		Self->SetComponentTickEnabledAsync(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldActivate(UPrimitiveComponent* Self)
	{
		return ((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->ShouldActivate_WRAP();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ToggleActive(UPrimitiveComponent* Self)
	{
		Self->ToggleActive();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_UninitializeComponent(UPrimitiveComponent* Self)
	{
		Self->UninitializeComponent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AreNativePropertiesIdenticalTo(UPrimitiveComponent* Self, UObject* Other)
	{
		auto _p0 = Other;
		return Self->AreNativePropertiesIdenticalTo(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CheckDefaultSubobjectsInternal(UPrimitiveComponent* Self)
	{
		return Self->CheckDefaultSubobjectsInternal();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetDesc(UPrimitiveComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDesc());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetDetailedInfoInternal(UPrimitiveComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetDetailedInfoInternal());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsAsset(UPrimitiveComponent* Self)
	{
		return Self->IsAsset();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsFullNameStableForNetworking(UPrimitiveComponent* Self)
	{
		return Self->IsFullNameStableForNetworking();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsLocalizedResource(UPrimitiveComponent* Self)
	{
		return Self->IsLocalizedResource();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsPostLoadThreadSafe(UPrimitiveComponent* Self)
	{
		return Self->IsPostLoadThreadSafe();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsSafeForRootSet(UPrimitiveComponent* Self)
	{
		return Self->IsSafeForRootSet();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_Modify(UPrimitiveComponent* Self, bool bAlwaysMarkDirty)
	{
		auto _p0 = bAlwaysMarkDirty;
		return Self->Modify(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_NotifyObjectReferenceEliminated(UPrimitiveComponent* Self)
	{
		Self->NotifyObjectReferenceEliminated();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PostCDOContruct(UPrimitiveComponent* Self)
	{
		Self->PostCDOContruct();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PostEditImport(UPrimitiveComponent* Self)
	{
		Self->PostEditImport();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PostSaveRoot(UPrimitiveComponent* Self, bool bCleanupIsRequired)
	{
		auto _p0 = bCleanupIsRequired;
		Self->PostSaveRoot(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_PreDestroyFromReplication(UPrimitiveComponent* Self)
	{
		Self->PreDestroyFromReplication();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShutdownAfterError(UPrimitiveComponent* Self)
	{
		Self->ShutdownAfterError();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_AddToCluster(UPrimitiveComponent* Self, UObjectBaseUtility* ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
	{
		auto _p0 = ClusterRootOrObjectFromCluster;
		auto _p1 = bAddAsMutableObject;
		Self->AddToCluster(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CanBeClusterRoot(UPrimitiveComponent* Self)
	{
		return Self->CanBeClusterRoot();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CanBeInCluster(UPrimitiveComponent* Self)
	{
		return Self->CanBeInCluster();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_CreateCluster(UPrimitiveComponent* Self)
	{
		Self->CreateCluster();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnClusterMarkedAsPendingKill(UPrimitiveComponent* Self)
	{
		Self->OnClusterMarkedAsPendingKill();
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
