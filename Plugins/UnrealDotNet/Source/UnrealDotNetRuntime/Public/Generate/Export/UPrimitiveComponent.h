#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Components/PrimitiveComponent.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:172

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

	bool ComponentOverlapComponentImpl_WRAP(UPrimitiveComponent* PrimComp, const FVector Pos, const FQuat& Rot, const FCollisionQueryParams& Params)
	{
		return ComponentOverlapComponentImpl(PrimComp, Pos, Rot, Params);
	}

	void EnsurePhysicsStateCreated_WRAP()
	{
		EnsurePhysicsStateCreated();
	}

	void OnComponentCollisionSettingsChanged_WRAP()
	{
		OnComponentCollisionSettingsChanged();
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

};


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
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bForceMipStreaming_GET(UPrimitiveComponent* Ptr) { return Ptr->bForceMipStreaming; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bForceMipStreaming_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bForceMipStreaming = Value; }
	
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
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bIgnoreStreamingManagerUpdate_GET(UPrimitiveComponent* Ptr) { return Ptr->bIgnoreStreamingManagerUpdate; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bIgnoreStreamingManagerUpdate_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bIgnoreStreamingManagerUpdate = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_GET(UPrimitiveComponent* Ptr) { return Ptr->bLightAsIfStatic_DEPRECATED; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bLightAsIfStatic_DEPRECATED = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_GET(UPrimitiveComponent* Ptr) { return Ptr->bLightAttachmentsAsGroup; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bLightAttachmentsAsGroup = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bMultiBodyOverlap_GET(UPrimitiveComponent* Ptr) { return Ptr->bMultiBodyOverlap; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bMultiBodyOverlap_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bMultiBodyOverlap = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bNeverDistanceCull_GET(UPrimitiveComponent* Ptr) { return Ptr->bNeverDistanceCull; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bNeverDistanceCull_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bNeverDistanceCull = Value; }
	
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
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bReplicatePhysicsToAutonomousProxy_GET(UPrimitiveComponent* Ptr) { return Ptr->bReplicatePhysicsToAutonomousProxy; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bReplicatePhysicsToAutonomousProxy_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bReplicatePhysicsToAutonomousProxy = Value; }
	
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
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bVisibleInRayTracing_GET(UPrimitiveComponent* Ptr) { return Ptr->bVisibleInRayTracing; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bVisibleInRayTracing_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bVisibleInRayTracing = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_GET(UPrimitiveComponent* Ptr) { return Ptr->bVisibleInReflectionCaptures; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->bVisibleInReflectionCaptures = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(UPrimitiveComponent* Ptr) { return Ptr->CachedMaxDrawDistance; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(UPrimitiveComponent* Ptr, float Value) { Ptr->CachedMaxDrawDistance = Value; }
	
	DOTNET_EXPORT auto E_PROP_UPrimitiveComponent_CastShadow_GET(UPrimitiveComponent* Ptr) { return Ptr->CastShadow; }
	DOTNET_EXPORT void E_PROP_UPrimitiveComponent_CastShadow_SET(UPrimitiveComponent* Ptr, uint8 Value) { Ptr->CastShadow = Value; }
	
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
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnBeginCursorOver";
		wrapper->SourceObject = Obj;
		Obj->OnBeginCursorOver.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentBeginCursorOverSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnBeginCursorOver(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentBeginOverlap(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentBeginOverlap";
		wrapper->SourceObject = Obj;
		Obj->OnComponentBeginOverlap.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentBeginOverlapSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentBeginOverlap(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentCollisionSettingsChangedEvent";
		wrapper->SourceObject = Obj;
		Obj->OnComponentCollisionSettingsChangedEvent.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentCollisionSettingsChangedSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentEndOverlap(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentEndOverlap";
		wrapper->SourceObject = Obj;
		Obj->OnComponentEndOverlap.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentEndOverlapSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentEndOverlap(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentHit(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentHit";
		wrapper->SourceObject = Obj;
		Obj->OnComponentHit.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentHitSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentHit(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentSleep(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentSleep";
		wrapper->SourceObject = Obj;
		Obj->OnComponentSleep.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentSleepSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentSleep(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnComponentWake(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
		wrapper->ManageDelegateName = "InvokeEvent_OnComponentWake";
		wrapper->SourceObject = Obj;
		Obj->OnComponentWake.AddDynamic(wrapper, &UManageEventSender::Wrapper_FComponentWakeSignature);
	}

	DOTNET_EXPORT void E_EVENT_DEL_UPrimitiveComponent_OnComponentWake(UPrimitiveComponent* Obj)
	{
	}

	DOTNET_EXPORT void E_EVENT_ADD_UPrimitiveComponent_OnEndCursorOver(UPrimitiveComponent* Obj)
	{
		auto wrapper = NewObject<UManageEventSender>(UCoreShell::GetInstance());
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
		auto& _p0 = *(FQuat*)A;
		auto& _p1 = *(FQuat*)B;
		auto& _p2 = *(FVector*)Scale3D;
		return Self->AreSymmetricRotations(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_BeginComponentOverlap(UPrimitiveComponent* Self, INT_PTR OtherOverlap, bool bDoNotifies)
	{
		auto& _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		Self->BeginComponentOverlap(_p0, _p1);
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_ComponentOverlapComponent(UPrimitiveComponent* Self, UPrimitiveComponent* PrimComp, INT_PTR Pos, INT_PTR Rot, INT_PTR Params)
	{
		auto _p0 = PrimComp;
		auto _p1 = *(FVector*)Pos;
		auto& _p2 = *(FQuat*)Rot;
		auto& _p3 = *(FCollisionQueryParams*)Params;
		return Self->ComponentOverlapComponent(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ComponentOverlapComponent_o1(UPrimitiveComponent* Self, UPrimitiveComponent* PrimComp, INT_PTR Pos, INT_PTR Rot, INT_PTR Params)
	{
		auto _p0 = PrimComp;
		auto _p1 = *(FVector*)Pos;
		auto _p2 = *(FRotator*)Rot;
		auto& _p3 = *(FCollisionQueryParams*)Params;
		return Self->ComponentOverlapComponent(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_ComponentOverlapComponentImpl(UPrimitiveComponent* Self, UPrimitiveComponent* PrimComp, INT_PTR Pos, INT_PTR Rot, INT_PTR Params)
	{
		auto _p0 = PrimComp;
		auto _p1 = *(FVector*)Pos;
		auto& _p2 = *(FQuat*)Rot;
		auto& _p3 = *(FCollisionQueryParams*)Params;
		return ((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->ComponentOverlapComponentImpl_WRAP(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DispatchMouseOverEvents(UPrimitiveComponent* Self, UPrimitiveComponent* CurrentComponent, UPrimitiveComponent* NewComponent)
	{
		auto _p0 = CurrentComponent;
		auto _p1 = NewComponent;
		Self->DispatchMouseOverEvents(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_DispatchWakeEvents(UPrimitiveComponent* Self, ESleepEvent WakeEvent, char* BoneName)
	{
		auto _p0 = WakeEvent;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->DispatchWakeEvents(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_EndComponentOverlap(UPrimitiveComponent* Self, INT_PTR OtherOverlap, bool bDoNotifies, bool bSkipNotifySelf)
	{
		auto& _p0 = *(FOverlapInfo*)OtherOverlap;
		auto _p1 = bDoNotifies;
		auto _p2 = bSkipNotifySelf;
		Self->EndComponentOverlap(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_EnsurePhysicsStateCreated(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->EnsurePhysicsStateCreated_WRAP();
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
		auto& _p0 = *(FVector*)Point;
		auto& _p1 = *(FVector*)OutPointOnBody;
		auto _p2 = ConvertFromManage_FName(BoneName);
		return Self->GetClosestPointOnCollision(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetCollisionProfileName(UPrimitiveComponent* Self)
	{
		return ConvertToManage_StringWrapper(Self->GetCollisionProfileName());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetDiffuseBoost(UPrimitiveComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetDiffuseBoost(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetDistanceToCollision(UPrimitiveComponent* Self, INT_PTR Point, INT_PTR ClosestPointOnCollision)
	{
		auto& _p0 = *(FVector*)Point;
		auto& _p1 = *(FVector*)ClosestPointOnCollision;
		return Self->GetDistanceToCollision(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetEmissiveBoost(UPrimitiveComponent* Self, int32 ElementIndex)
	{
		auto _p0 = ElementIndex;
		return Self->GetEmissiveBoost(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetGenerateOverlapEvents(UPrimitiveComponent* Self)
	{
		return Self->GetGenerateOverlapEvents();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetInertiaTensor(UPrimitiveComponent* Self, char* BoneName)
	{
		auto _p0 = ConvertFromManage_FName(BoneName);
		return (INT_PTR) new FVector(Self->GetInertiaTensor(_p0));
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(UPrimitiveComponent* Self, int32 LightMapMemoryUsage, int32 ShadowMapMemoryUsage)
	{
		auto& _p0 = LightMapMemoryUsage;
		auto& _p1 = ShadowMapMemoryUsage;
		Self->GetLightAndShadowMapMemoryUsage(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetLightMapResolution(UPrimitiveComponent* Self, int32 Width, int32 Height)
	{
		auto& _p0 = Width;
		auto& _p1 = Height;
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetRenderMatrix(UPrimitiveComponent* Self)
	{
		return (INT_PTR) new FMatrix(Self->GetRenderMatrix());
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetRigidBodyState(UPrimitiveComponent* Self, INT_PTR OutState, char* BoneName)
	{
		auto& _p0 = *(FRigidBodyState*)OutState;
		auto _p1 = ConvertFromManage_FName(BoneName);
		return Self->GetRigidBodyState(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetShadowIndirectOnly(UPrimitiveComponent* Self)
	{
		return Self->GetShadowIndirectOnly();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_GetSquaredDistanceToCollision(UPrimitiveComponent* Self, INT_PTR Point, float OutSquaredDistance, INT_PTR OutClosestPointOnCollision)
	{
		auto& _p0 = *(FVector*)Point;
		auto& _p1 = OutSquaredDistance;
		auto& _p2 = *(FVector*)OutClosestPointOnCollision;
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_InitSweepCollisionParams(UPrimitiveComponent* Self, INT_PTR OutParams, INT_PTR OutResponseParam)
	{
		auto& _p0 = *(FCollisionQueryParams*)OutParams;
		auto& _p1 = *(FCollisionResponseParams*)OutResponseParam;
		Self->InitSweepCollisionParams(_p0, _p1);
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsGravityEnabled(UPrimitiveComponent* Self)
	{
		return Self->IsGravityEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsOverlappingActor(UPrimitiveComponent* Self, AActor* Other)
	{
		auto _p0 = Other;
		return Self->IsOverlappingActor(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsOverlappingComponent(UPrimitiveComponent* Self, UPrimitiveComponent* OtherComp)
	{
		auto _p0 = OtherComp;
		return Self->IsOverlappingComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsOverlappingComponent_o1(UPrimitiveComponent* Self, INT_PTR Overlap)
	{
		auto& _p0 = *(FOverlapInfo*)Overlap;
		return Self->IsOverlappingComponent(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(UPrimitiveComponent* Self)
	{
		return Self->IsPostPhysicsComponentTickEnabled();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsWelded(UPrimitiveComponent* Self)
	{
		return Self->IsWelded();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_IsZeroExtent(UPrimitiveComponent* Self)
	{
		return Self->IsZeroExtent();
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_BoxOverlapComponent(UPrimitiveComponent* Self, INT_PTR InBoxCentre, INT_PTR InBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, INT_PTR HitLocation, INT_PTR HitNormal, char* BoneName, INT_PTR OutHit)
	{
		auto _p0 = *(FVector*)InBoxCentre;
		auto _p1 = *(FBox*)InBox;
		auto _p2 = bTraceComplex;
		auto _p3 = bShowTrace;
		auto _p4 = bPersistentShowTrace;
		auto& _p5 = *(FVector*)HitLocation;
		auto& _p6 = *(FVector*)HitNormal;
		auto _p7 = ConvertFromManage_FName(BoneName);
		auto& _p8 = *(FHitResult*)OutHit;
		return Self->K2_BoxOverlapComponent(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7, _p8);
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_LineTraceComponent(UPrimitiveComponent* Self, INT_PTR TraceStart, INT_PTR TraceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, INT_PTR HitLocation, INT_PTR HitNormal, char* BoneName, INT_PTR OutHit)
	{
		auto _p0 = *(FVector*)TraceStart;
		auto _p1 = *(FVector*)TraceEnd;
		auto _p2 = bTraceComplex;
		auto _p3 = bShowTrace;
		auto _p4 = bPersistentShowTrace;
		auto& _p5 = *(FVector*)HitLocation;
		auto& _p6 = *(FVector*)HitNormal;
		auto _p7 = ConvertFromManage_FName(BoneName);
		auto& _p8 = *(FHitResult*)OutHit;
		return Self->K2_LineTraceComponent(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7, _p8);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_SphereOverlapComponent(UPrimitiveComponent* Self, INT_PTR InSphereCentre, float InSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, INT_PTR HitLocation, INT_PTR HitNormal, char* BoneName, INT_PTR OutHit)
	{
		auto _p0 = *(FVector*)InSphereCentre;
		auto _p1 = InSphereRadius;
		auto _p2 = bTraceComplex;
		auto _p3 = bShowTrace;
		auto _p4 = bPersistentShowTrace;
		auto& _p5 = *(FVector*)HitLocation;
		auto& _p6 = *(FVector*)HitNormal;
		auto _p7 = ConvertFromManage_FName(BoneName);
		auto& _p8 = *(FHitResult*)OutHit;
		return Self->K2_SphereOverlapComponent(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7, _p8);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_K2_SphereTraceComponent(UPrimitiveComponent* Self, INT_PTR TraceStart, INT_PTR TraceEnd, float SphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, INT_PTR HitLocation, INT_PTR HitNormal, char* BoneName, INT_PTR OutHit)
	{
		auto _p0 = *(FVector*)TraceStart;
		auto _p1 = *(FVector*)TraceEnd;
		auto _p2 = SphereRadius;
		auto _p3 = bTraceComplex;
		auto _p4 = bShowTrace;
		auto _p5 = bPersistentShowTrace;
		auto& _p6 = *(FVector*)HitLocation;
		auto& _p7 = *(FVector*)HitNormal;
		auto _p8 = ConvertFromManage_FName(BoneName);
		auto& _p9 = *(FHitResult*)OutHit;
		return Self->K2_SphereTraceComponent(_p0, _p1, _p2, _p3, _p4, _p5, _p6, _p7, _p8, _p9);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_LineTraceComponent(UPrimitiveComponent* Self, INT_PTR OutHit, INT_PTR Start, INT_PTR End, INT_PTR Params)
	{
		auto& _p0 = *(FHitResult*)OutHit;
		auto _p1 = *(FVector*)Start;
		auto _p2 = *(FVector*)End;
		auto& _p3 = *(FCollisionQueryParams*)Params;
		return Self->LineTraceComponent(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(UPrimitiveComponent* Self)
	{
		((E_PROTECTED_WRAP_UPrimitiveComponent*)Self)->OnComponentCollisionSettingsChanged_WRAP();
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_ReceiveComponentDamage(UPrimitiveComponent* Self, float DamageAmount, INT_PTR DamageEvent, AController* EventInstigator, AActor* DamageCauser)
	{
		auto _p0 = DamageAmount;
		auto& _p1 = *(FDamageEvent*)DamageEvent;
		auto _p2 = EventInstigator;
		auto _p3 = DamageCauser;
		Self->ReceiveComponentDamage(_p0, _p1, _p2, _p3);
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllMassScale(UPrimitiveComponent* Self, float InMassScale)
	{
		auto _p0 = InMassScale;
		Self->SetAllMassScale(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInDegrees(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto& _p0 = *(FVector*)NewAngVel;
		auto _p1 = bAddToCurrent;
		Self->SetAllPhysicsAngularVelocityInDegrees(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInRadians(UPrimitiveComponent* Self, INT_PTR NewAngVel, bool bAddToCurrent)
	{
		auto& _p0 = *(FVector*)NewAngVel;
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsRotation(UPrimitiveComponent* Self, INT_PTR NewRot)
	{
		auto _p0 = *(FRotator*)NewRot;
		Self->SetAllPhysicsRotation(_p0);
	}

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetAllPhysicsRotation_o1(UPrimitiveComponent* Self, INT_PTR NewRot)
	{
		auto& _p0 = *(FQuat*)NewRot;
		Self->SetAllPhysicsRotation(_p0);
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
		auto& _p0 = *(FCollisionResponseContainer*)NewReponses;
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetGenerateOverlapEvents(UPrimitiveComponent* Self, bool bInGenerateOverlapEvents)
	{
		auto _p0 = bInGenerateOverlapEvents;
		Self->SetGenerateOverlapEvents(_p0);
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_SetRigidBodyReplicatedTarget(UPrimitiveComponent* Self, INT_PTR UpdatedState, char* BoneName)
	{
		auto& _p0 = *(FRigidBodyState*)UpdatedState;
		auto _p1 = ConvertFromManage_FName(BoneName);
		Self->SetRigidBodyReplicatedTarget(_p0, _p1);
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

	DOTNET_EXPORT auto E_UPrimitiveComponent_ShouldComponentAddToScene(UPrimitiveComponent* Self)
	{
		return Self->ShouldComponentAddToScene();
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

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
