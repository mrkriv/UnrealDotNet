// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:172

namespace UnrealEngine
{
	public partial class UPrimitiveComponent : USceneComponent
	{
		public UPrimitiveComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UPrimitiveComponent(UObject Parent = null, string Name = "PrimitiveComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPrimitiveComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_AlwaysLoadOnClient_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_AlwaysLoadOnClient_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_AlwaysLoadOnServer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_AlwaysLoadOnServer_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bAffectDistanceFieldLighting_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bAffectDistanceFieldLighting_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bAffectDynamicIndirectLighting_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bAffectDynamicIndirectLighting_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bAllowCullDistanceVolume_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bAllowCullDistanceVolume_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bAlwaysCreatePhysicsState_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bAlwaysCreatePhysicsState_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bApplyImpulseOnDamage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bApplyImpulseOnDamage_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsDynamic_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsDynamic_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsStatic_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsStatic_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bCastCinematicShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bCastCinematicShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bCastDynamicShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bCastDynamicShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bCastFarShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bCastFarShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bCastHiddenShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bCastHiddenShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bCastInsetShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bCastInsetShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bCastShadowAsTwoSided_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bCastShadowAsTwoSided_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bCastStaticShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bCastStaticShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bCastVolumetricTranslucentShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bCastVolumetricTranslucentShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bForceMipStreaming_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bForceMipStreaming_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bHandledByStreamingManagerAsDynamic_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bHandledByStreamingManagerAsDynamic_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bHasMotionBlurVelocityMeshes_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bHasMotionBlurVelocityMeshes_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bHasPerInstanceHitProxies_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bHasPerInstanceHitProxies_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bIgnoreRadialForce_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bIgnoreRadialForce_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bIgnoreRadialImpulse_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bIgnoreRadialImpulse_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bIgnoreStreamingManagerUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bIgnoreStreamingManagerUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bMultiBodyOverlap_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bMultiBodyOverlap_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bNeverDistanceCull_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bNeverDistanceCull_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bOnlyOwnerSee_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bOnlyOwnerSee_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_BoundsScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_BoundsScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bOwnerNoSee_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bOwnerNoSee_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bReceiveMobileCSMShadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bReceiveMobileCSMShadows_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bReceivesDecals_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bReceivesDecals_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bRenderCustomDepth_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bRenderCustomDepth_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bRenderInMainPass_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bRenderInMainPass_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bReplicatePhysicsToAutonomousProxy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bReplicatePhysicsToAutonomousProxy_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bReturnMaterialOnMove_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bReturnMaterialOnMove_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bSelectable_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bSelectable_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bSelfShadowOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bSelfShadowOnly_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bSingleSampleShadowFromStationaryLights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bSingleSampleShadowFromStationaryLights_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bTraceComplexOnMove_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bTraceComplexOnMove_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bTreatAsBackgroundForOcclusion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bTreatAsBackgroundForOcclusion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bUseAsOccluder_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bUseAsOccluder_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bUseEditorCompositing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bUseEditorCompositing_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bUseViewOwnerDepthPriorityGroup_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bUseViewOwnerDepthPriorityGroup_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bVisibleInRayTracing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bVisibleInRayTracing_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_CastShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_CastShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LastRenderTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LastRenderTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LastSubmitTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LastSubmitTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UPrimitiveComponent_LightingChannels_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LightingChannels_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_LightmapType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LightmapType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPrimitiveComponent_MinDrawDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_MinDrawDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UPrimitiveComponent_OnBeginCursorOver(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UPrimitiveComponent_OnBeginCursorOver(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UPrimitiveComponent_OnComponentBeginOverlap(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UPrimitiveComponent_OnComponentBeginOverlap(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UPrimitiveComponent_OnComponentEndOverlap(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UPrimitiveComponent_OnComponentEndOverlap(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UPrimitiveComponent_OnComponentHit(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UPrimitiveComponent_OnComponentHit(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UPrimitiveComponent_OnComponentSleep(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UPrimitiveComponent_OnComponentSleep(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UPrimitiveComponent_OnComponentWake(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UPrimitiveComponent_OnComponentWake(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_UPrimitiveComponent_OnEndCursorOver(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_UPrimitiveComponent_OnEndCursorOver(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPrimitiveComponent_VisibilityId_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_VisibilityId_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPrimitiveComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddAngularImpulse(IntPtr self, IntPtr impulse, string boneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddAngularImpulseInDegrees(IntPtr self, IntPtr impulse, string boneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddAngularImpulseInRadians(IntPtr self, IntPtr impulse, string boneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddForce(IntPtr self, IntPtr force, string boneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddForceAtLocation(IntPtr self, IntPtr force, IntPtr location, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddForceAtLocationLocal(IntPtr self, IntPtr force, IntPtr location, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddImpulse(IntPtr self, IntPtr impulse, string boneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddImpulseAtLocation(IntPtr self, IntPtr impulse, IntPtr location, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddRadialForce(IntPtr self, IntPtr origin, float radius, float strength, byte falloff, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddRadialImpulse(IntPtr self, IntPtr origin, float radius, float strength, byte falloff, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddTorque(IntPtr self, IntPtr torque, string boneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddTorqueInDegrees(IntPtr self, IntPtr torque, string boneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddTorqueInRadians(IntPtr self, IntPtr torque, string boneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(IntPtr self, bool bAllowCachedValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_AreSymmetricRotations(IntPtr self, IntPtr a, IntPtr b, IntPtr scale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_BeginComponentOverlap(IntPtr self, IntPtr otherOverlap, bool bDoNotifies);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_CalculateMass(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_CanCharacterStepUp(IntPtr self, IntPtr pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_CanEditSimulatePhysics(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ClearComponentOverlaps(IntPtr self, bool bDoNotifies, bool bSkipNotifySelf);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ClearMoveIgnoreActors(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ClearMoveIgnoreComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ComponentOverlapComponent(IntPtr self, IntPtr primComp, IntPtr pos, IntPtr rot, IntPtr @params);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ComponentOverlapComponent_o1(IntPtr self, IntPtr primComp, IntPtr pos, IntPtr rot, IntPtr @params);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ComponentOverlapComponentImpl(IntPtr self, IntPtr primComp, IntPtr pos, IntPtr rot, IntPtr @params);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_DispatchMouseOverEvents(IntPtr self, IntPtr currentComponent, IntPtr newComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_DispatchWakeEvents(IntPtr self, byte wakeEvent, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_EndComponentOverlap(IntPtr self, IntPtr otherOverlap, bool bDoNotifies, bool bSkipNotifySelf);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_EnsurePhysicsStateCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetAngularDamping(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetCenterOfMass(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetClosestPointOnCollision(IntPtr self, IntPtr point, IntPtr outPointOnBody, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UPrimitiveComponent_GetCollisionProfileName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetDiffuseBoost(IntPtr self, int elementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetDistanceToCollision(IntPtr self, IntPtr point, IntPtr closestPointOnCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetEmissiveBoost(IntPtr self, int elementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetGenerateOverlapEvents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetInertiaTensor(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(IntPtr self, int lightMapMemoryUsage, int shadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetLightMapResolution(IntPtr self, int width, int height);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetLinearDamping(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPrimitiveComponent_GetLODParentPrimitive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetMass(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetMassScale(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UPrimitiveComponent_GetNumMaterials(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsAngularVelocity(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsAngularVelocityInDegrees(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsAngularVelocityInRadians(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsLinearVelocity(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(IntPtr self, IntPtr point, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetRenderMatrix(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetRigidBodyState(IntPtr self, IntPtr outState, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetShadowIndirectOnly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetSquaredDistanceToCollision(IntPtr self, IntPtr point, float outSquaredDistance, IntPtr outClosestPointOnCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UPrimitiveComponent_GetStaticDepthPriorityGroup(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UPrimitiveComponent_GetStaticLightMapResolution(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_HasStaticLighting(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_HasValidSettingsForStaticLighting(IntPtr self, bool bOverlookInvalidComponents);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_IgnoreActorWhenMoving(IntPtr self, IntPtr actor, bool bShouldIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_IgnoreComponentWhenMoving(IntPtr self, IntPtr component, bool bShouldIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_InitSweepCollisionParams(IntPtr self, IntPtr outParams, IntPtr outResponseParam);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsAnyRigidBodyAwake(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsAttachedToStreamingManager(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsComponentIndividuallySelected(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsGravityEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsOverlappingActor(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsOverlappingComponent(IntPtr self, IntPtr otherComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsOverlappingComponent_o1(IntPtr self, IntPtr overlap);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsWelded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsZeroExtent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_BoxOverlapComponent(IntPtr self, IntPtr inBoxCentre, IntPtr inBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, IntPtr hitLocation, IntPtr hitNormal, string boneName, IntPtr outHit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_IsCollisionEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_LineTraceComponent(IntPtr self, IntPtr traceStart, IntPtr traceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, IntPtr hitLocation, IntPtr hitNormal, string boneName, IntPtr outHit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_SphereOverlapComponent(IntPtr self, IntPtr inSphereCentre, float inSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, IntPtr hitLocation, IntPtr hitNormal, string boneName, IntPtr outHit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_SphereTraceComponent(IntPtr self, IntPtr traceStart, IntPtr traceEnd, float sphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, IntPtr hitLocation, IntPtr hitNormal, string boneName, IntPtr outHit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_LineTraceComponent(IntPtr self, IntPtr outHit, IntPtr start, IntPtr end, IntPtr @params);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PushHoveredToProxy(IntPtr self, bool bInHovered);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PushSelectionToProxy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PutAllRigidBodiesToSleep(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PutRigidBodyToSleep(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ReceiveComponentDamage(IntPtr self, float damageAmount, IntPtr damageEvent, IntPtr eventInstigator, IntPtr damageCauser);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_RigidBodyIsAwake(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_ScaleByMomentOfInertia(IntPtr self, IntPtr inputVector, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SendPhysicsTransform(IntPtr self, byte teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllMassScale(IntPtr self, float inMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInDegrees(IntPtr self, IntPtr newAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInRadians(IntPtr self, IntPtr newAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(IntPtr self, IntPtr newVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsPosition(IntPtr self, IntPtr newPos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsRotation(IntPtr self, IntPtr newRot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsRotation_o1(IntPtr self, IntPtr newRot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllUseCCD(IntPtr self, bool inUseCCD);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAngularDamping(IntPtr self, float inDamping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetBoundsScale(IntPtr self, float newBoundsScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCachedMaxDrawDistance(IntPtr self, float newCachedMaxDrawDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCastShadow(IntPtr self, bool newCastShadow);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCenterOfMass(IntPtr self, IntPtr centerOfMassOffset, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionObjectType(IntPtr self, byte channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionProfileName(IntPtr self, string inCollisionProfileName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionResponseToAllChannels(IntPtr self, byte newResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionResponseToChannel(IntPtr self, byte channel, byte newResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionResponseToChannels(IntPtr self, IntPtr newReponses);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCullDistance(IntPtr self, float newCullDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCustomDepthStencilValue(IntPtr self, int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(IntPtr self, byte writeMaskBit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetDepthPriorityGroup(IntPtr self, byte newDepthPriorityGroup);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetEnableGravity(IntPtr self, bool bGravityEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetGenerateOverlapEvents(IntPtr self, bool bInGenerateOverlapEvents);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetLinearDamping(IntPtr self, float inDamping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetLODParentPrimitive(IntPtr self, IntPtr inLODParentPrimitive);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetMassOverrideInKg(IntPtr self, string boneName, float massInKg, bool bOverrideMass);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetMassScale(IntPtr self, string boneName, float inMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetNotifyRigidBodyCollision(IntPtr self, bool bNewNotifyRigidBodyCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetOnlyOwnerSee(IntPtr self, bool bNewOnlyOwnerSee);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetOwnerNoSee(IntPtr self, bool bNewOwnerNoSee);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsAngularVelocity(IntPtr self, IntPtr newAngVel, bool bAddToCurrent, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsAngularVelocityInDegrees(IntPtr self, IntPtr newAngVel, bool bAddToCurrent, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsAngularVelocityInRadians(IntPtr self, IntPtr newAngVel, bool bAddToCurrent, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsLinearVelocity(IntPtr self, IntPtr newVel, bool bAddToCurrent, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(IntPtr self, float newMaxAngVel, bool bAddToCurrent, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInDegrees(IntPtr self, float newMaxAngVel, bool bAddToCurrent, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInRadians(IntPtr self, float newMaxAngVel, bool bAddToCurrent, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetReceivesDecals(IntPtr self, bool bNewReceivesDecals);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetRenderCustomDepth(IntPtr self, bool bValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetRenderInMainPass(IntPtr self, bool bValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetRigidBodyReplicatedTarget(IntPtr self, IntPtr updatedState, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetSimulatePhysics(IntPtr self, bool bSimulate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(IntPtr self, bool bNewSingleSampleShadowFromStationaryLights);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetTranslucentSortPriority(IntPtr self, int newTranslucentSortPriority);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetUseCCD(IntPtr self, bool inUseCCD, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(IntPtr self, bool bNewUseViewOwnerDepthPriorityGroup, byte newViewOwnerDepthPriorityGroup);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ShouldComponentAddToScene(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ShouldRecreateProxyOnUpdateTransform(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ShouldRenderSelected(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_SupportsStaticLighting(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SyncComponentToRBPhysics(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_UnWeldChildren(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_UnWeldFromParent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_UpdatePhysicsToRBChannels(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_UsesOnlyUnlitMaterials(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_WakeAllRigidBodies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_WakeRigidBody(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_WeldTo(IntPtr self, IntPtr inParent, string inSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_WeldToImplementation(IntPtr self, IntPtr inParent, string parentSocketName, bool bWeldSimulatedChild);
		
		#endregion
		
		#region Property
		public byte AlwaysLoadOnClient
		{
			get => E_PROP_UPrimitiveComponent_AlwaysLoadOnClient_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_AlwaysLoadOnClient_SET(NativePointer, value);
		}

		public byte AlwaysLoadOnServer
		{
			get => E_PROP_UPrimitiveComponent_AlwaysLoadOnServer_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_AlwaysLoadOnServer_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls whether the primitive should affect dynamic distance field lighting methods.  This flag is only used if CastShadow is true.
		/// </summary>
		public byte bAffectDistanceFieldLighting
		{
			get => E_PROP_UPrimitiveComponent_bAffectDistanceFieldLighting_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAffectDistanceFieldLighting_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls whether the primitive should inject light into the Light Propagation Volume.  This flag is only used if CastShadow is true.
		/// </summary>
		public byte bAffectDynamicIndirectLighting
		{
			get => E_PROP_UPrimitiveComponent_bAffectDynamicIndirectLighting_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAffectDynamicIndirectLighting_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to accept cull distance volumes to modify cached cull distance.
		/// </summary>
		public byte bAllowCullDistanceVolume
		{
			get => E_PROP_UPrimitiveComponent_bAllowCullDistanceVolume_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAllowCullDistanceVolume_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Indicates if we'd like to create physics state all the time (for collision and simulation).
		/// <para>If you set this to false, it still will create physics state if collision or simulation activated. </para>
		/// This can help performance if you'd like to avoid overhead of creating physics state when triggers
		/// </summary>
		public byte bAlwaysCreatePhysicsState
		{
			get => E_PROP_UPrimitiveComponent_bAlwaysCreatePhysicsState_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAlwaysCreatePhysicsState_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True for damage to this component to apply physics impulse, false to opt out of these impulses.
		/// </summary>
		public byte bApplyImpulseOnDamage
		{
			get => E_PROP_UPrimitiveComponent_bApplyImpulseOnDamage_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bApplyImpulseOnDamage_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this primitive is referenced by a FDynamicTextureInstanceManager
		/// </summary>
		public byte bAttachedToStreamingManagerAsDynamic
		{
			get => E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsDynamic_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsDynamic_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this primitive is referenced by a FLevelTextureManager
		/// </summary>
		public byte bAttachedToStreamingManagerAsStatic
		{
			get => E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsStatic_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsStatic_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this component should cast shadows from lights that have bCastShadowsFromCinematicObjectsOnly enabled.
		/// <para>This is useful for characters in a cinematic with special cinematic lights, where the cost of shadowmap rendering of the environment is undesired. </para>
		/// </summary>
		public byte bCastCinematicShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastCinematicShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastCinematicShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls whether the primitive should cast shadows in the case of non precomputed shadowing.  This flag is only used if CastShadow is true.
		/// </summary>
		public byte DynamicShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastDynamicShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastDynamicShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When enabled, the component will be rendering into the far shadow cascades (only for directional lights).
		/// </summary>
		public byte FarShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastFarShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastFarShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, the primitive will cast shadows even if bHidden is true.
		/// <para>Controls whether the primitive should cast shadows when hidden. </para>
		/// This flag is only used if CastShadow is true.
		/// </summary>
		public byte HiddenShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastHiddenShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastHiddenShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this component should create a per-object shadow that gives higher effective shadow resolution.
		/// <para>Useful for cinematic character shadowing. Assumed to be enabled if bSelfShadowOnly is enabled. </para>
		/// </summary>
		public byte DynamicInsetShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastInsetShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastInsetShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this primitive should cast dynamic shadows as if it were a two sided material.
		/// </summary>
		public byte ShadowTwoSided
		{
			get => E_PROP_UPrimitiveComponent_bCastShadowAsTwoSided_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastShadowAsTwoSided_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the object should cast a static shadow from shadow casting lights.  This flag is only used if CastShadow is true.
		/// </summary>
		public byte StaticShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastStaticShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastStaticShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the object should cast a volumetric translucent shadow.
		/// <para>Volumetric translucent shadows are useful for primitives with smoothly changing opacity like particles representing a volume, </para>
		/// But have artifacts when used on highly opaque surfaces.
		/// </summary>
		public byte VolumetricTranslucentShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastVolumetricTranslucentShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastVolumetricTranslucentShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, forces mips for textures used by this component to be resident when this component's level is loaded.
		/// </summary>
		public byte bForceMipStreaming
		{
			get => E_PROP_UPrimitiveComponent_bForceMipStreaming_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bForceMipStreaming_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this primitive is handled as dynamic, although it could have no references
		/// </summary>
		public byte bHandledByStreamingManagerAsDynamic
		{
			get => E_PROP_UPrimitiveComponent_bHandledByStreamingManagerAsDynamic_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bHandledByStreamingManagerAsDynamic_SET(NativePointer, value);
		}

		public byte bHasMotionBlurVelocityMeshes
		{
			get => E_PROP_UPrimitiveComponent_bHasMotionBlurVelocityMeshes_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bHasMotionBlurVelocityMeshes_SET(NativePointer, value);
		}

		public byte bHasPerInstanceHitProxies
		{
			get => E_PROP_UPrimitiveComponent_bHasPerInstanceHitProxies_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bHasPerInstanceHitProxies_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Will ignore radial forces applied to this component.
		/// </summary>
		public byte bIgnoreRadialForce
		{
			get => E_PROP_UPrimitiveComponent_bIgnoreRadialForce_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bIgnoreRadialForce_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Will ignore radial impulses applied to this component.
		/// </summary>
		public byte bIgnoreRadialImpulse
		{
			get => E_PROP_UPrimitiveComponent_bIgnoreRadialImpulse_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bIgnoreRadialImpulse_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When true, texture streaming manager won't update the component state. Used to perform early exits when updating component.
		/// </summary>
		public byte bIgnoreStreamingManagerUpdate
		{
			get => E_PROP_UPrimitiveComponent_bIgnoreStreamingManagerUpdate_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bIgnoreStreamingManagerUpdate_SET(NativePointer, value);
		}

		public byte bLightAsIfStatic_DEPRECATED
		{
			get => E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to light this component and any attachments as a group.  This only has effect on the root component of an attachment tree.
		/// <para>When enabled, attached component shadowing settings like bCastInsetShadow, bCastVolumetricTranslucentShadow, etc, will be ignored. </para>
		/// This is useful for improving performance when multiple movable components are attached together.
		/// </summary>
		public byte bLightAttachmentsAsGroup
		{
			get => E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this component will generate individual overlaps for each overlapping physics body if it is a multi-body component. When false, this component will
		/// <para>generate only one overlap, regardless of how many physics bodies it has and how many of them are overlapping another component/body. This flag has no </para>
		/// influence on single body components.
		/// </summary>
		public byte bMultiBodyOverlap
		{
			get => E_PROP_UPrimitiveComponent_bMultiBodyOverlap_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bMultiBodyOverlap_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When enabled this object will not be culled by distance. This is ignored if a child of a HLOD.
		/// </summary>
		public byte bNeverDistanceCull
		{
			get => E_PROP_UPrimitiveComponent_bNeverDistanceCull_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bNeverDistanceCull_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If this is True, this component will only be visible when the view actor is the component's owner, directly or indirectly.
		/// </summary>
		public byte bOnlyOwnerSee
		{
			get => E_PROP_UPrimitiveComponent_bOnlyOwnerSee_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bOnlyOwnerSee_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scales the bounds of the object.
		/// <para>This is useful when using World Position Offset to animate the vertices of the object outside of its bounds. </para>
		/// Warning: Increasing the bounds of an object will reduce performance and shadow quality!
		/// <para>Currently only used by StaticMeshComponent and SkeletalMeshComponent. </para>
		/// </summary>
		public float BoundsScale
		{
			get => E_PROP_UPrimitiveComponent_BoundsScale_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_BoundsScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If this is True, this component won't be visible when the view actor is the component's owner, directly or indirectly.
		/// </summary>
		public byte bOwnerNoSee
		{
			get => E_PROP_UPrimitiveComponent_bOwnerNoSee_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bOwnerNoSee_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Mobile only:
		/// <para>If disabled this component will not receive CSM shadows. (Components that do not receive CSM may have reduced shading cost) </para>
		/// </summary>
		public byte ReceiveCSMShadows
		{
			get => E_PROP_UPrimitiveComponent_bReceiveMobileCSMShadows_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bReceiveMobileCSMShadows_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the primitive receives decals.
		/// </summary>
		public byte bReceivesDecals
		{
			get => E_PROP_UPrimitiveComponent_bReceivesDecals_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bReceivesDecals_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this component will be rendered in the CustomDepth pass (usually used for outlines)
		/// </summary>
		public byte RenderCustomDepthPass
		{
			get => E_PROP_UPrimitiveComponent_bRenderCustomDepth_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bRenderCustomDepth_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this component will be rendered in the main pass (z prepass, basepass, transparency)
		/// </summary>
		public byte bRenderInMainPass
		{
			get => E_PROP_UPrimitiveComponent_bRenderInMainPass_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bRenderInMainPass_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True if physics should be replicated to autonomous proxies. This should be true for
		/// <para>server-authoritative simulations, and false for client authoritative simulations. </para>
		/// </summary>
		public byte bReplicatePhysicsToAutonomousProxy
		{
			get => E_PROP_UPrimitiveComponent_bReplicatePhysicsToAutonomousProxy_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bReplicatePhysicsToAutonomousProxy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, component sweeps will return the material in their hit result.
		/// <see cref="MoveComponent"/>
		/// </summary>
		public byte bReturnMaterialOnMove
		{
			get => E_PROP_UPrimitiveComponent_bReturnMaterialOnMove_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bReturnMaterialOnMove_SET(NativePointer, value);
		}

		public byte bSelectable
		{
			get => E_PROP_UPrimitiveComponent_bSelectable_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bSelectable_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When enabled, the component will only cast a shadow on itself and not other components in the world.
		/// <para>This is especially useful for first person weapons, and forces bCastInsetShadow to be enabled. </para>
		/// </summary>
		public byte bSelfShadowOnly
		{
			get => E_PROP_UPrimitiveComponent_bSelfShadowOnly_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bSelfShadowOnly_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the whole component should be shadowed as one from stationary lights, which makes shadow receiving much cheaper.
		/// <para>When enabled shadowing data comes from the volume lighting samples precomputed by Lightmass, which are very sparse. </para>
		/// This is currently only used on stationary directional lights.
		/// </summary>
		public byte bSingleSampleShadowFromStationaryLights
		{
			get => E_PROP_UPrimitiveComponent_bSingleSampleShadowFromStationaryLights_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bSingleSampleShadowFromStationaryLights_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, component sweeps with this component should trace against complex collision during movement (for example, each triangle of a mesh).
		/// <para>If false, collision will be resolved against simple collision bounds instead. </para>
		/// <see cref="MoveComponent"/>
		/// </summary>
		public byte bTraceComplexOnMove
		{
			get => E_PROP_UPrimitiveComponent_bTraceComplexOnMove_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bTraceComplexOnMove_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Treat this primitive as part of the background for occlusion purposes. This can be used as an optimization to reduce the cost of rendering skyboxes, large ground planes that are part of the vista, etc.
		/// </summary>
		public byte bTreatAsBackgroundForOcclusion
		{
			get => E_PROP_UPrimitiveComponent_bTreatAsBackgroundForOcclusion_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bTreatAsBackgroundForOcclusion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to render the primitive in the depth only pass.
		/// <para>This should generally be true for all objects, and let the renderer make decisions about whether to render objects in the depth only pass. </para>
		/// @todo - if any rendering features rely on a complete depth only pass, this variable needs to go away.
		/// </summary>
		public byte bUseAsOccluder
		{
			get => E_PROP_UPrimitiveComponent_bUseAsOccluder_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bUseAsOccluder_SET(NativePointer, value);
		}

		public byte bUseEditorCompositing
		{
			get => E_PROP_UPrimitiveComponent_bUseEditorCompositing_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bUseEditorCompositing_SET(NativePointer, value);
		}

		public byte bUseViewOwnerDepthPriorityGroup
		{
			get => E_PROP_UPrimitiveComponent_bUseViewOwnerDepthPriorityGroup_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bUseViewOwnerDepthPriorityGroup_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this component will be visible in ray tracing effects. Turning this off will remove it from ray traced reflections, shadows, etc.
		/// </summary>
		public byte bVisibleInRayTracing
		{
			get => E_PROP_UPrimitiveComponent_bVisibleInRayTracing_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bVisibleInRayTracing_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this component will be visible in reflection captures.
		/// </summary>
		public byte bVisibleInReflectionCaptures
		{
			get => E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The distance to cull this primitive at.
		/// <para>A CachedMaxDrawDistance of 0 indicates that the primitive should not be culled by distance. </para>
		/// </summary>
		public float CurrentMaxDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls whether the primitive component should cast a shadow or not.
		/// <para>This flag is ignored (no shadows will be generated) if all materials on this component have an Unlit shading model. </para>
		/// </summary>
		public byte CastShadow
		{
			get => E_PROP_UPrimitiveComponent_CastShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CastShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3)
		/// </summary>
		public int CustomDepthStencilValue
		{
			get => E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Mask used for stencil buffer writes.
		/// </summary>
		public ERendererStencilMask CustomDepthStencilWriteMask
		{
			get => (ERendererStencilMask)E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CustomDepthStencilWriteMask_SET(NativePointer, (byte)value);
		}

		public float LastRenderTime
		{
			get => E_PROP_UPrimitiveComponent_LastRenderTime_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastRenderTime_SET(NativePointer, value);
		}

		public float LastRenderTimeOnScreen
		{
			get => E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastRenderTimeOnScreen_SET(NativePointer, value);
		}

		public float LastSubmitTime
		{
			get => E_PROP_UPrimitiveComponent_LastSubmitTime_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LastSubmitTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object.
		/// </summary>
		public float DesiredMaxDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Channels that this component should be in.  Lights with matching channels will affect the component.
		/// <para>These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing. </para>
		/// </summary>
		public FLightingChannels LightingChannels
		{
			get => E_PROP_UPrimitiveComponent_LightingChannels_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LightingChannels_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls the type of lightmap used for this component.
		/// </summary>
		public ELightmapType LightmapType
		{
			get => (ELightmapType)E_PROP_UPrimitiveComponent_LightmapType_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LightmapType_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Multiplier used to scale the Light Propagation Volume light injection bias, to reduce light bleeding.
		/// <para>Set to 0 for no bias, 1 for default or higher for increased biasing (e.g. for </para>
		/// thin geometry such as walls)
		/// </summary>
		public float LpvBiasMultiplier
		{
			get => E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The minimum distance at which the primitive should be rendered,
		/// <para>measured in world space units from the center of the primitive's bounding sphere to the camera position. </para>
		/// </summary>
		public float MinDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_MinDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_MinDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Translucent objects with a lower sort priority draw behind objects with a higher priority.
		/// <para>Translucent objects with the same priority are rendered from back-to-front based on their bounds origin. </para>
		/// Ignored if the object is not translucent.  The default priority is zero.
		/// <para>Warning: This should never be set to a non-default value unless you know what you are doing, as it will prevent the renderer from sorting correctly. </para>
		/// It is especially problematic on dynamic gameplay effects.
		/// </summary>
		public int TranslucencySortPriority
		{
			get => E_PROP_UPrimitiveComponent_TranslucencySortPriority_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_TranslucencySortPriority_SET(NativePointer, value);
		}

		public int VisibilityId
		{
			get => E_PROP_UPrimitiveComponent_VisibilityId_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_VisibilityId_SET(NativePointer, value);
		}

		#endregion
		
		#region Events
		
		/// <summary>
		/// Event called when the mouse cursor is moved over this component and mouse over events are enabled in the player controller
		/// </summary>
		public event FComponentBeginCursorOverSignature OnBeginCursorOver
		{
			add
			{
				E_EVENT_ADD_UPrimitiveComponent_OnBeginCursorOver(NativePointer);
				_Event_OnBeginCursorOver += value;
			}

			remove
			{
				E_EVENT_DEL_UPrimitiveComponent_OnBeginCursorOver(NativePointer);
				_Event_OnBeginCursorOver -= value;
			}

		}

		private event FComponentBeginCursorOverSignature _Event_OnBeginCursorOver;
		
		internal void InvokeEvent_OnBeginCursorOver(ObjectPointerDescription touchedComponent)
		{
			_Event_OnBeginCursorOver?.Invoke(touchedComponent);
		}

		
		/// <summary>
		/// Event called when something starts to overlaps this component, for example a player walking into a trigger.
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// @note Both this component and the other one must have GetGenerateOverlapEvents() set to true to generate overlap events.
		/// <para>@note When receiving an overlap from another object's movement, the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// will be adjusted to indicate force from the other object against this object.
		/// </summary>
		public event FComponentBeginOverlapSignature OnComponentBeginOverlap
		{
			add
			{
				E_EVENT_ADD_UPrimitiveComponent_OnComponentBeginOverlap(NativePointer);
				_Event_OnComponentBeginOverlap += value;
			}

			remove
			{
				E_EVENT_DEL_UPrimitiveComponent_OnComponentBeginOverlap(NativePointer);
				_Event_OnComponentBeginOverlap -= value;
			}

		}

		private event FComponentBeginOverlapSignature _Event_OnComponentBeginOverlap;
		
		internal void InvokeEvent_OnComponentBeginOverlap(ObjectPointerDescription overlappedComponent, ObjectPointerDescription otherActor, ObjectPointerDescription otherComp, int otherBodyIndex, bool bFromSweep, FHitResult sweepResult)
		{
			_Event_OnComponentBeginOverlap?.Invoke(overlappedComponent, otherActor, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		}

		
		/// <summary>
		/// Event called when collision settings change for this component.
		/// </summary>
		public event FComponentCollisionSettingsChangedSignature OnComponentCollisionSettingsChangedEvent
		{
			add
			{
				E_EVENT_ADD_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(NativePointer);
				_Event_OnComponentCollisionSettingsChangedEvent += value;
			}

			remove
			{
				E_EVENT_DEL_UPrimitiveComponent_OnComponentCollisionSettingsChangedEvent(NativePointer);
				_Event_OnComponentCollisionSettingsChangedEvent -= value;
			}

		}

		private event FComponentCollisionSettingsChangedSignature _Event_OnComponentCollisionSettingsChangedEvent;
		
		internal void InvokeEvent_OnComponentCollisionSettingsChangedEvent(ObjectPointerDescription changedComponent)
		{
			_Event_OnComponentCollisionSettingsChangedEvent?.Invoke(changedComponent);
		}

		
		/// <summary>
		/// Event called when something stops overlapping this component
		/// <para>@note Both this component and the other one must have GetGenerateOverlapEvents() set to true to generate overlap events. </para>
		/// </summary>
		public event FComponentEndOverlapSignature OnComponentEndOverlap
		{
			add
			{
				E_EVENT_ADD_UPrimitiveComponent_OnComponentEndOverlap(NativePointer);
				_Event_OnComponentEndOverlap += value;
			}

			remove
			{
				E_EVENT_DEL_UPrimitiveComponent_OnComponentEndOverlap(NativePointer);
				_Event_OnComponentEndOverlap -= value;
			}

		}

		private event FComponentEndOverlapSignature _Event_OnComponentEndOverlap;
		
		internal void InvokeEvent_OnComponentEndOverlap(ObjectPointerDescription overlappedComponent, ObjectPointerDescription otherActor, ObjectPointerDescription otherComp, int otherBodyIndex)
		{
			_Event_OnComponentEndOverlap?.Invoke(overlappedComponent, otherActor, otherComp, otherBodyIndex);
		}

		
		/// <summary>
		/// Event called when a component hits (or is hit by) something solid. This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation.
		/// <para>For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event. </para>
		/// @note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled for this component.
		/// <para>@note When receiving a hit from another object's movement, the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// will be adjusted to indicate force from the other object against this object.
		/// <para>@note NormalImpulse will be filled in for physics-simulating bodies, but will be zero for swept-component blocking collisions. </para>
		/// </summary>
		public event FComponentHitSignature OnComponentHit
		{
			add
			{
				E_EVENT_ADD_UPrimitiveComponent_OnComponentHit(NativePointer);
				_Event_OnComponentHit += value;
			}

			remove
			{
				E_EVENT_DEL_UPrimitiveComponent_OnComponentHit(NativePointer);
				_Event_OnComponentHit -= value;
			}

		}

		private event FComponentHitSignature _Event_OnComponentHit;
		
		internal void InvokeEvent_OnComponentHit(ObjectPointerDescription hitComponent, ObjectPointerDescription otherActor, ObjectPointerDescription otherComp, FVector normalImpulse, FHitResult hit)
		{
			_Event_OnComponentHit?.Invoke(hitComponent, otherActor, otherComp, normalImpulse, hit);
		}

		
		/// <summary>
		/// Event called when the underlying physics objects is put to sleep
		/// </summary>
		public event FComponentSleepSignature OnComponentSleep
		{
			add
			{
				E_EVENT_ADD_UPrimitiveComponent_OnComponentSleep(NativePointer);
				_Event_OnComponentSleep += value;
			}

			remove
			{
				E_EVENT_DEL_UPrimitiveComponent_OnComponentSleep(NativePointer);
				_Event_OnComponentSleep -= value;
			}

		}

		private event FComponentSleepSignature _Event_OnComponentSleep;
		
		internal void InvokeEvent_OnComponentSleep(ObjectPointerDescription sleepingComponent, StringWrapper boneName)
		{
			_Event_OnComponentSleep?.Invoke(sleepingComponent, boneName);
		}

		
		/// <summary>
		/// Event called when the underlying physics objects is woken up
		/// </summary>
		public event FComponentWakeSignature OnComponentWake
		{
			add
			{
				E_EVENT_ADD_UPrimitiveComponent_OnComponentWake(NativePointer);
				_Event_OnComponentWake += value;
			}

			remove
			{
				E_EVENT_DEL_UPrimitiveComponent_OnComponentWake(NativePointer);
				_Event_OnComponentWake -= value;
			}

		}

		private event FComponentWakeSignature _Event_OnComponentWake;
		
		internal void InvokeEvent_OnComponentWake(ObjectPointerDescription wakingComponent, StringWrapper boneName)
		{
			_Event_OnComponentWake?.Invoke(wakingComponent, boneName);
		}

		
		/// <summary>
		/// Event called when the mouse cursor is moved off this component and mouse over events are enabled in the player controller
		/// </summary>
		public event FComponentEndCursorOverSignature OnEndCursorOver
		{
			add
			{
				E_EVENT_ADD_UPrimitiveComponent_OnEndCursorOver(NativePointer);
				_Event_OnEndCursorOver += value;
			}

			remove
			{
				E_EVENT_DEL_UPrimitiveComponent_OnEndCursorOver(NativePointer);
				_Event_OnEndCursorOver -= value;
			}

		}

		private event FComponentEndCursorOverSignature _Event_OnEndCursorOver;
		
		internal void InvokeEvent_OnEndCursorOver(ObjectPointerDescription touchedComponent)
		{
			_Event_OnEndCursorOver?.Invoke(touchedComponent);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Add an angular impulse to a single rigid body. Good for one time instant burst.
		/// </summary>
		/// <param name="angularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body.</param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect).</param>
		public virtual void AddAngularImpulse(FVector impulse, string boneName, bool bVelChange)
			=> E_UPrimitiveComponent_AddAngularImpulse(this, impulse, boneName, bVelChange);
		
		
		/// <summary>
		/// Add an angular impulse to a single rigid body. Good for one time instant burst.
		/// </summary>
		/// <param name="angularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body.</param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect).</param>
		public void AddAngularImpulseInDegrees(FVector impulse, string boneName, bool bVelChange = false)
			=> E_UPrimitiveComponent_AddAngularImpulseInDegrees(this, impulse, boneName, bVelChange);
		
		
		/// <summary>
		/// Add an angular impulse to a single rigid body. Good for one time instant burst.
		/// </summary>
		/// <param name="angularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body.</param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect).</param>
		public virtual void AddAngularImpulseInRadians(FVector impulse, string boneName, bool bVelChange)
			=> E_UPrimitiveComponent_AddAngularImpulseInRadians(this, impulse, boneName, bVelChange);
		
		
		/// <summary>
		/// Add a force to a single rigid body.
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// </summary>
		/// <param name="force">Force vector to apply. Magnitude indicates strength of force.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.</param>
		/// <param name="bAccelChange">If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect).</param>
		public virtual void AddForce(FVector force, string boneName, bool bAccelChange)
			=> E_UPrimitiveComponent_AddForce(this, force, boneName, bAccelChange);
		
		
		/// <summary>
		/// Add a force to a single rigid body at a particular location in world space.
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// </summary>
		/// <param name="force">Force vector to apply. Magnitude indicates strength of force.</param>
		/// <param name="location">Location to apply force, in world space.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.</param>
		public virtual void AddForceAtLocation(FVector force, FVector location, string boneName)
			=> E_UPrimitiveComponent_AddForceAtLocation(this, force, location, boneName);
		
		
		/// <summary>
		/// Add a force to a single rigid body at a particular location. Both Force and Location should be in body space.
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// </summary>
		/// <param name="force">Force vector to apply. Magnitude indicates strength of force.</param>
		/// <param name="location">Location to apply force, in component space.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body.</param>
		public virtual void AddForceAtLocationLocal(FVector force, FVector location, string boneName)
			=> E_UPrimitiveComponent_AddForceAtLocationLocal(this, force, location, boneName);
		
		
		/// <summary>
		/// Add an impulse to a single rigid body. Good for one time instant burst.
		/// </summary>
		/// <param name="impulse">Magnitude and direction of impulse to apply.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body.</param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect).</param>
		public virtual void AddImpulse(FVector impulse, string boneName, bool bVelChange)
			=> E_UPrimitiveComponent_AddImpulse(this, impulse, boneName, bVelChange);
		
		
		/// <summary>
		/// Add an impulse to a single rigid body at a specific location.
		/// </summary>
		/// <param name="impulse">Magnitude and direction of impulse to apply.</param>
		/// <param name="location">Point in world space to apply impulse at.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body.</param>
		public virtual void AddImpulseAtLocation(FVector impulse, FVector location, string boneName)
			=> E_UPrimitiveComponent_AddImpulseAtLocation(this, impulse, location, boneName);
		
		
		/// <summary>
		/// Add a force to all bodies in this component, originating from the supplied world-space location.
		/// </summary>
		/// <param name="origin">Origin of force in world space.</param>
		/// <param name="radius">Radius within which to apply the force.</param>
		/// <param name="strength">Strength of force to apply.</param>
		/// <param name="falloff">Allows you to control the strength of the force as a function of distance from Origin.</param>
		/// <param name="bAccelChange">If true, Strength is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect).</param>
		public virtual void AddRadialForce(FVector origin, float radius, float strength, ERadialImpulseFalloff falloff, bool bAccelChange)
			=> E_UPrimitiveComponent_AddRadialForce(this, origin, radius, strength, (byte)falloff, bAccelChange);
		
		
		/// <summary>
		/// Add an impulse to all rigid bodies in this component, radiating out from the specified position.
		/// </summary>
		/// <param name="origin">Point of origin for the radial impulse blast, in world space</param>
		/// <param name="radius">Size of radial impulse. Beyond this distance from Origin, there will be no affect.</param>
		/// <param name="strength">Maximum strength of impulse applied to body.</param>
		/// <param name="falloff">Allows you to control the strength of the impulse as a function of distance from Origin.</param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect).</param>
		public virtual void AddRadialImpulse(FVector origin, float radius, float strength, ERadialImpulseFalloff falloff, bool bVelChange)
			=> E_UPrimitiveComponent_AddRadialImpulse(this, origin, radius, strength, (byte)falloff, bVelChange);
		
		
		/// <summary>
		/// Add a torque to a single rigid body.
		/// </summary>
		/// <param name="torque">Torque to apply. Direction is axis of rotation and magnitude is strength of torque.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body.</param>
		/// <param name="bAccelChange">If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect).</param>
		public void AddTorque(FVector torque, string boneName, bool bAccelChange = false)
			=> E_UPrimitiveComponent_AddTorque(this, torque, boneName, bAccelChange);
		
		
		/// <summary>
		/// Add a torque to a single rigid body.
		/// </summary>
		/// <param name="torque">Torque to apply. Direction is axis of rotation and magnitude is strength of torque.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body.</param>
		/// <param name="bAccelChange">If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect).</param>
		public void AddTorqueInDegrees(FVector torque, string boneName, bool bAccelChange = false)
			=> E_UPrimitiveComponent_AddTorqueInDegrees(this, torque, boneName, bAccelChange);
		
		
		/// <summary>
		/// Add a torque to a single rigid body.
		/// </summary>
		/// <param name="torque">Torque to apply. Direction is axis of rotation and magnitude is strength of torque.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body.</param>
		/// <param name="bAccelChange">If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect).</param>
		public virtual void AddTorqueInRadians(FVector torque, string boneName, bool bAccelChange)
			=> E_UPrimitiveComponent_AddTorqueInRadians(this, torque, boneName, bAccelChange);
		
		
		/// <summary>
		/// Returns true if all descendant components that we can possibly overlap with use relative location and rotation.
		/// </summary>
		protected virtual bool AreAllCollideableDescendantsRelative(bool bAllowCachedValue)
			=> E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(this, bAllowCachedValue);
		
		
		/// <summary>
		/// Returns true if the given transforms result in the same bounds, due to rotational symmetry.
		/// <para>For example, this is true for a sphere with uniform scale undergoing any rotation. </para>
		/// This is NOT intended to detect every case where this is true, only the common cases to aid optimizations.
		/// </summary>
		public virtual bool AreSymmetricRotations(FQuat a, FQuat b, FVector scale3D)
			=> E_UPrimitiveComponent_AreSymmetricRotations(this, a, b, scale3D);
		
		
		/// <summary>
		/// Begin tracking an overlap interaction with the component specified.
		/// <see cref="Overlap"/>
		/// </summary>
		/// <param name="otherComp">The component of the other actor that this component is now overlapping</param>
		/// <param name="bDoNotifies">True to dispatch appropriate begin/end overlap notifications when these events occur.</param>
		public void BeginComponentOverlap(FOverlapInfo otherOverlap, bool bDoNotifies)
			=> E_UPrimitiveComponent_BeginComponentOverlap(this, otherOverlap, bDoNotifies);
		
		
		/// <summary>
		/// Returns the calculated mass in kg. This is not 100% exactly the mass physx will calculate, but it is very close ( difference < 0.1kg ).
		/// </summary>
		public virtual float CalculateMass(string boneName)
			=> E_UPrimitiveComponent_CalculateMass(this, boneName);
		
		
		/// <summary>
		/// Return true if the given Pawn can step up onto this component.
		/// <para>This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it. </para>
		/// @see CanCharacterStepUpOn
		/// </summary>
		/// <param name="pawn">the Pawn that wants to step onto this component.</param>
		public virtual bool CanCharacterStepUp(APawn pawn)
			=> E_UPrimitiveComponent_CanCharacterStepUp(this, pawn);
		
		
		/// <summary>
		/// Determines whether or not the simulate physics setting can be edited interactively on this component
		/// </summary>
		public virtual bool CanEditSimulatePhysics()
			=> E_UPrimitiveComponent_CanEditSimulatePhysics(this);
		
		
		/// <summary>
		/// Ends all current component overlaps. Generally used when destroying this component or when it can no longer generate overlaps.
		/// </summary>
		protected void ClearComponentOverlaps(bool bDoNotifies, bool bSkipNotifySelf)
			=> E_UPrimitiveComponent_ClearComponentOverlaps(this, bDoNotifies, bSkipNotifySelf);
		
		
		/// <summary>
		/// Clear the list of actors we ignore when moving.
		/// </summary>
		public void ClearMoveIgnoreActors()
			=> E_UPrimitiveComponent_ClearMoveIgnoreActors(this);
		
		
		/// <summary>
		/// Clear the list of components we ignore when moving.
		/// </summary>
		public void ClearMoveIgnoreComponents()
			=> E_UPrimitiveComponent_ClearMoveIgnoreComponents(this);
		
		
		/// <summary>
		/// Test the collision of the supplied component at the supplied location/rotation, and determine if it overlaps this component.
		/// <para>@note This overload taking rotation as a FQuat is slightly faster than the version using FRotator. </para>
		/// @note This simply calls the virtual ComponentOverlapComponentImpl() which can be overridden to implement custom behavior.
		/// </summary>
		/// <param name="primComp">Component to use geometry from to test against this component. Transform of this component is ignored.</param>
		/// <param name="pos">Location to place PrimComp geometry at</param>
		/// <param name="rot">Rotation to place PrimComp geometry at</param>
		/// <param name="@params">Parameter for trace. TraceTag is only used.</param>
		/// <return>true</return>
		public bool ComponentOverlapComponent(UPrimitiveComponent primComp, FVector pos, FQuat rot, FCollisionQueryParams @params)
			=> E_UPrimitiveComponent_ComponentOverlapComponent(this, primComp, pos, rot, @params);
		
		public bool ComponentOverlapComponent(UPrimitiveComponent primComp, FVector pos, FRotator rot, FCollisionQueryParams @params)
			=> E_UPrimitiveComponent_ComponentOverlapComponent_o1(this, primComp, pos, rot, @params);
		
		
		/// <summary>
		/// Override this method for custom behavior for ComponentOverlapComponent()
		/// </summary>
		protected virtual bool ComponentOverlapComponentImpl(UPrimitiveComponent primComp, FVector pos, FQuat rot, FCollisionQueryParams @params)
			=> E_UPrimitiveComponent_ComponentOverlapComponentImpl(this, primComp, pos, rot, @params);
		
		public void DispatchMouseOverEvents(UPrimitiveComponent currentComponent, UPrimitiveComponent newComponent)
			=> E_UPrimitiveComponent_DispatchMouseOverEvents(this, currentComponent, newComponent);
		
		
		/// <summary>
		/// Dispatch notification for wake events and propagate to any welded bodies
		/// </summary>
		public void DispatchWakeEvents(ESleepEvent wakeEvent, string boneName)
			=> E_UPrimitiveComponent_DispatchWakeEvents(this, (byte)wakeEvent, boneName);
		
		
		/// <summary>
		/// Finish tracking an overlap interaction that is no longer occurring between this component and the component specified.
		/// <see cref="Overlap"/>
		/// </summary>
		/// <param name="otherComp">The component of the other actor to stop overlapping</param>
		/// <param name="bDoNotifies">True to dispatch appropriate begin/end overlap notifications when these events occur.</param>
		/// <param name="bSkipNotifySelf">True to skip end overlap notifications to this component's.  Does not affect notifications to OtherComp's actor.</param>
		public void EndComponentOverlap(FOverlapInfo otherOverlap, bool bDoNotifies = true, bool bSkipNotifySelf = false)
			=> E_UPrimitiveComponent_EndComponentOverlap(this, otherOverlap, bDoNotifies, bSkipNotifySelf);
		
		
		/// <summary>
		/// Ensure physics state created
		/// </summary>
		protected void EnsurePhysicsStateCreated()
			=> E_UPrimitiveComponent_EnsurePhysicsStateCreated(this);
		
		
		/// <summary>
		/// Returns the angular damping of this component.
		/// </summary>
		public virtual float GetAngularDamping()
			=> E_UPrimitiveComponent_GetAngularDamping(this);
		
		
		/// <summary>
		/// Get the center of mass of a single body. In the case of a welded body this will return the center of mass of the entire welded body (including its parent and children)
		/// <para>Objects that are not simulated return (0,0,0) as they do not have COM </para>
		/// </summary>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to get center of mass of. 'None' indicates root body.</param>
		public FVector GetCenterOfMass(string boneName)
			=> E_UPrimitiveComponent_GetCenterOfMass(this, boneName);
		
		
		/// <summary>
		/// Returns the distance and closest point to the collision surface.
		/// <para>Component must have simple collision to be queried for closest point. </para>
		/// If returns < 0.f, this primitive does not have collsion
		/// </summary>
		/// <param name="point">World 3D vector</param>
		/// <param name="outPointOnBody">Point on the surface of collision closest to Point</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.</param>
		/// <return>Success</return>
		public float GetClosestPointOnCollision(FVector point, FVector outPointOnBody, string boneName)
			=> E_UPrimitiveComponent_GetClosestPointOnCollision(this, point, outPointOnBody, boneName);
		
		
		/// <summary>
		/// Get the collision profile name
		/// </summary>
		public string GetCollisionProfileName()
			=> E_UPrimitiveComponent_GetCollisionProfileName(this);
		
		
		/// <summary>
		/// Gets the diffuse boost for the primitive component.
		/// </summary>
		public virtual float GetDiffuseBoost(int elementIndex)
			=> E_UPrimitiveComponent_GetDiffuseBoost(this, elementIndex);
		
		
		/// <summary>
		/// Returns Distance to closest Body Instance surface.
		/// <para>If returns < 0.f, this primitive does not have collsion or if geometry is not supported </para>
		/// </summary>
		/// <param name="point">World 3D vector</param>
		/// <param name="outPointOnBody">Point on the surface of collision closest to Point</param>
		/// <return>Success</return>
		public float GetDistanceToCollision(FVector point, FVector closestPointOnCollision)
			=> E_UPrimitiveComponent_GetDistanceToCollision(this, point, closestPointOnCollision);
		
		
		/// <summary>
		/// Gets the emissive boost for the primitive component.
		/// </summary>
		public virtual float GetEmissiveBoost(int elementIndex)
			=> E_UPrimitiveComponent_GetEmissiveBoost(this, elementIndex);
		
		public bool GetGenerateOverlapEvents()
			=> E_UPrimitiveComponent_GetGenerateOverlapEvents(this);
		
		
		/// <summary>
		/// Returns the inertia tensor of this component in kg cm^2. The inertia tensor is in local component space.
		/// </summary>
		public virtual FVector GetInertiaTensor(string boneName)
			=> E_UPrimitiveComponent_GetInertiaTensor(this, boneName);
		
		
		/// <summary>
		/// Returns the light and shadow map memory for this primitive in its out variables.
		/// <para>Shadow map memory usage is per light whereof lightmap data is independent of number of lights, assuming at least one. </para>
		/// </summary>
		/// <param name="@out">LightMapMemoryUsage		Memory usage in bytes for light map (either texel or vertex) data</param>
		/// <param name="@out">ShadowMapMemoryUsage	Memory usage in bytes for shadow map (either texel or vertex) data</param>
		public virtual void GetLightAndShadowMapMemoryUsage(int lightMapMemoryUsage, int shadowMapMemoryUsage)
			=> E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(this, lightMapMemoryUsage, shadowMapMemoryUsage);
		
		
		/// <summary>
		/// Returns the lightmap resolution used for this primitive instance in the case of it supporting texture light/ shadow maps.
		/// <para>0 if not supported or no static shadowing. </para>
		/// </summary>
		/// <param name="width">out]	Width of light/shadow map</param>
		/// <param name="height">out]	Height of light/shadow map</param>
		/// <return>bool</return>
		public virtual bool GetLightMapResolution(int width, int height)
			=> E_UPrimitiveComponent_GetLightMapResolution(this, width, height);
		
		
		/// <summary>
		/// Returns the linear damping of this component.
		/// </summary>
		public virtual float GetLinearDamping()
			=> E_UPrimitiveComponent_GetLinearDamping(this);
		
		
		/// <summary>
		/// Gets the LOD Parent, which is used to compute visibility when hierarchical LOD is enabled
		/// </summary>
		public UPrimitiveComponent GetLODParentPrimitive()
			=> E_UPrimitiveComponent_GetLODParentPrimitive(this);
		
		
		/// <summary>
		/// Returns the mass of this component in kg.
		/// </summary>
		public virtual float GetMass()
			=> E_UPrimitiveComponent_GetMass(this);
		
		
		/// <summary>
		/// Returns the mass scale used to calculate the mass of a single physics body
		/// </summary>
		public virtual float GetMassScale(string boneName)
			=> E_UPrimitiveComponent_GetMassScale(this, boneName);
		
		
		/// <summary>
		/// Return number of material elements in this primitive
		/// </summary>
		public virtual int GetNumMaterials()
			=> E_UPrimitiveComponent_GetNumMaterials(this);
		
		
		/// <summary>
		/// Get the angular velocity of a single body, in degrees per second.
		/// </summary>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.</param>
		public FVector GetPhysicsAngularVelocity(string boneName)
			=> E_UPrimitiveComponent_GetPhysicsAngularVelocity(this, boneName);
		
		
		/// <summary>
		/// Get the angular velocity of a single body, in degrees per second.
		/// </summary>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.</param>
		public FVector GetPhysicsAngularVelocityInDegrees(string boneName)
			=> E_UPrimitiveComponent_GetPhysicsAngularVelocityInDegrees(this, boneName);
		
		
		/// <summary>
		/// Get the angular velocity of a single body, in radians per second.
		/// </summary>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.</param>
		public FVector GetPhysicsAngularVelocityInRadians(string boneName)
			=> E_UPrimitiveComponent_GetPhysicsAngularVelocityInRadians(this, boneName);
		
		
		/// <summary>
		/// Get the linear velocity of a single body.
		/// </summary>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.</param>
		public FVector GetPhysicsLinearVelocity(string boneName)
			=> E_UPrimitiveComponent_GetPhysicsLinearVelocity(this, boneName);
		
		
		/// <summary>
		/// Get the linear velocity of a point on a single body.
		/// </summary>
		/// <param name="point">Point is specified in world space.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body.</param>
		public FVector GetPhysicsLinearVelocityAtPoint(FVector point, string boneName)
			=> E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(this, point, boneName);
		
		
		/// <summary>
		/// Returns the matrix that should be used to render this component.
		/// <para>Allows component class to perform graphical distortion to the component not supported by an FTransform </para>
		/// </summary>
		public virtual FMatrix GetRenderMatrix()
			=> E_UPrimitiveComponent_GetRenderMatrix(this);
		
		
		/// <summary>
		/// Get the state of the rigid body responsible for this Actor's physics, and fill in the supplied FRigidBodyState struct based on it.
		/// </summary>
		/// <return>true</return>
		public bool GetRigidBodyState(FRigidBodyState outState, string boneName)
			=> E_UPrimitiveComponent_GetRigidBodyState(this, outState, boneName);
		
		
		/// <summary>
		/// Disable dynamic shadow casting if the primitive only casts indirect shadows, since dynamic shadows are always shadowing direct lighting
		/// </summary>
		public virtual bool GetShadowIndirectOnly()
			=> E_UPrimitiveComponent_GetShadowIndirectOnly(this);
		
		
		/// <summary>
		/// Returns The square of the distance to closest Body Instance surface.
		/// </summary>
		/// <param name="point">World 3D vector</param>
		/// <param name="outSquaredDistance">The squared distance to closest Body Instance surface. 0 if inside of the body</param>
		/// <param name="outPointOnBody">Point on the surface of collision closest to Point</param>
		/// <return>true</return>
		public virtual bool GetSquaredDistanceToCollision(FVector point, float outSquaredDistance, FVector outClosestPointOnCollision)
			=> E_UPrimitiveComponent_GetSquaredDistanceToCollision(this, point, outSquaredDistance, outClosestPointOnCollision);
		
		
		/// <summary>
		/// Determines the DPG the primitive's primary elements are drawn in.
		/// <para>Even if the primitive's elements are drawn in multiple DPGs, a primary DPG is needed for occlusion culling and shadow projection. </para>
		/// </summary>
		/// <return>The</return>
		public virtual byte GetStaticDepthPriorityGroup()
			=> E_UPrimitiveComponent_GetStaticDepthPriorityGroup(this);
		
		
		/// <summary>
		/// Returns the static lightmap resolution used for this primitive.
		/// <para>0 if not supported or no static shadowing. </para>
		/// </summary>
		/// <return>int32</return>
		public virtual int GetStaticLightMapResolution()
			=> E_UPrimitiveComponent_GetStaticLightMapResolution(this);
		
		
		/// <summary>
		/// Return True if a primitive's parameters as well as its position is static during gameplay, and can thus use static lighting.
		/// </summary>
		public bool HasStaticLighting()
			=> E_UPrimitiveComponent_HasStaticLighting(this);
		
		
		/// <summary>
		/// Returns true if the component is static and has the right static mesh setup to support lightmaps.
		/// </summary>
		public virtual bool HasValidSettingsForStaticLighting(bool bOverlookInvalidComponents)
			=> E_UPrimitiveComponent_HasValidSettingsForStaticLighting(this, bOverlookInvalidComponents);
		
		
		/// <summary>
		/// Tells this component whether to ignore collision with all components of a specific Actor when this component is moved.
		/// <para>Components on the other Actor may also need to be told to do the same when they move. </para>
		/// Does not affect movement of this component when simulating physics.
		/// </summary>
		public void IgnoreActorWhenMoving(AActor actor, bool bShouldIgnore)
			=> E_UPrimitiveComponent_IgnoreActorWhenMoving(this, actor, bShouldIgnore);
		
		
		/// <summary>
		/// Tells this component whether to ignore collision with another component when this component is moved.
		/// <para>The other components may also need to be told to do the same when they move. </para>
		/// Does not affect movement of this component when simulating physics.
		/// </summary>
		public void IgnoreComponentWhenMoving(UPrimitiveComponent component, bool bShouldIgnore)
			=> E_UPrimitiveComponent_IgnoreComponentWhenMoving(this, component, bShouldIgnore);
		
		
		/// <summary>
		/// Set collision params on OutParams (such as CollisionResponse) to match the settings on this PrimitiveComponent.
		/// </summary>
		public virtual void InitSweepCollisionParams(FCollisionQueryParams outParams, FCollisionResponseParams outResponseParam)
			=> E_UPrimitiveComponent_InitSweepCollisionParams(this, outParams, outResponseParam);
		
		
		/// <summary>
		/// Returns if any body in this component is currently awake and simulating.
		/// </summary>
		public virtual bool IsAnyRigidBodyAwake()
			=> E_UPrimitiveComponent_IsAnyRigidBodyAwake(this);
		
		
		/// <summary>
		/// Whether this primitive is referenced by the streaming manager and should sent callbacks when detached or destroyed
		/// </summary>
		public bool IsAttachedToStreamingManager()
			=> E_UPrimitiveComponent_IsAttachedToStreamingManager(this);
		
		
		/// <summary>
		/// Component is directly selected in the editor separate from its parent actor
		/// </summary>
		public bool IsComponentIndividuallySelected()
			=> E_UPrimitiveComponent_IsComponentIndividuallySelected(this);
		
		
		/// <summary>
		/// Returns whether this component is affected by gravity. Returns always false if the component is not simulated.
		/// </summary>
		public virtual bool IsGravityEnabled()
			=> E_UPrimitiveComponent_IsGravityEnabled(this);
		
		
		/// <summary>
		/// Check whether this component is overlapping any component of the given Actor.
		/// </summary>
		/// <param name="other">Actor to test this component against.</param>
		/// <return>Whether</return>
		public bool IsOverlappingActor(AActor other)
			=> E_UPrimitiveComponent_IsOverlappingActor(this, other);
		
		
		/// <summary>
		/// Check whether this component is overlapping another component.
		/// </summary>
		/// <param name="otherComp">Component to test this component against.</param>
		/// <return>Whether</return>
		public bool IsOverlappingComponent(UPrimitiveComponent otherComp)
			=> E_UPrimitiveComponent_IsOverlappingComponent(this, otherComp);
		
		
		/// <summary>
		/// Check whether this component has the specified overlap.
		/// </summary>
		public bool IsOverlappingComponent(FOverlapInfo overlap)
			=> E_UPrimitiveComponent_IsOverlappingComponent_o1(this, overlap);
		
		
		/// <summary>
		/// Returns whether we have the post physics tick enabled
		/// </summary>
		public bool IsPostPhysicsComponentTickEnabled()
			=> E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(this);
		
		
		/// <summary>
		/// Whether the component has been welded to another simulating component
		/// </summary>
		public bool IsWelded()
			=> E_UPrimitiveComponent_IsWelded(this);
		
		
		/// <summary>
		/// This isn't bound extent, but for shape component to utilize extent is 0.
		/// <para>For normal primitive, this is 0, for ShapeComponent, this will have valid information </para>
		/// </summary>
		public virtual bool IsZeroExtent()
			=> E_UPrimitiveComponent_IsZeroExtent(this);
		
		
		/// <summary>
		/// Perform a box overlap against a single component as an AABB (No rotation)
		/// </summary>
		/// <param name="inBoxCentre">The centre of the box to overlap with the component</param>
		/// <param name="inBox">Description of the box to use in the overlap</param>
		/// <param name="bTraceComplex">Whether or not to trace the complex physics representation or just the simple representation</param>
		/// <param name="bShowTrace">Whether or not to draw the trace in the world (for debugging)</param>
		/// <param name="bPersistentShowTrace">Whether or not to make the debugging draw stay in the world permanently</param>
		public bool BoxOverlapComponent(FVector inBoxCentre, FBox inBox, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, FVector hitLocation, FVector hitNormal, string boneName, FHitResult outHit)
			=> E_UPrimitiveComponent_K2_BoxOverlapComponent(this, inBoxCentre, inBox, bTraceComplex, bShowTrace, bPersistentShowTrace, hitLocation, hitNormal, boneName, outHit);
		
		
		/// <summary>
		/// Utility to see if there is any form of collision (query or physics) enabled on this component.
		/// </summary>
		public bool IsCollisionEnabled()
			=> E_UPrimitiveComponent_K2_IsCollisionEnabled(this);
		
		
		/// <summary>
		/// Utility to see if there is any physics collision enabled on this component.
		/// </summary>
		public bool IsPhysicsCollisionEnabled()
			=> E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(this);
		
		
		/// <summary>
		/// Utility to see if there is any query collision enabled on this component.
		/// </summary>
		public bool IsQueryCollisionEnabled()
			=> E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(this);
		
		
		/// <summary>
		/// Perform a line trace against a single component
		/// </summary>
		/// <param name="traceStart">The start of the trace in world-space</param>
		/// <param name="traceEnd">The end of the trace in world-space</param>
		/// <param name="bTraceComplex">Whether or not to trace the complex physics representation or just the simple representation</param>
		/// <param name="bShowTrace">Whether or not to draw the trace in the world (for debugging)</param>
		/// <param name="bPersistentShowTrace">Whether or not to make the debugging draw stay in the world permanently</param>
		public bool K2_LineTraceComponent(FVector traceStart, FVector traceEnd, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, FVector hitLocation, FVector hitNormal, string boneName, FHitResult outHit)
			=> E_UPrimitiveComponent_K2_LineTraceComponent(this, traceStart, traceEnd, bTraceComplex, bShowTrace, bPersistentShowTrace, hitLocation, hitNormal, boneName, outHit);
		
		
		/// <summary>
		/// Perform a sphere overlap against a single component
		/// </summary>
		/// <param name="inSphereCentre">The centre of the sphere to overlap with the component</param>
		/// <param name="inSphereRadius">The Radius of the sphere to overlap with the component</param>
		/// <param name="bTraceComplex">Whether or not to trace the complex physics representation or just the simple representation</param>
		/// <param name="bShowTrace">Whether or not to draw the trace in the world (for debugging)</param>
		/// <param name="bPersistentShowTrace">Whether or not to make the debugging draw stay in the world permanently</param>
		public bool SphereOverlapComponent(FVector inSphereCentre, float inSphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, FVector hitLocation, FVector hitNormal, string boneName, FHitResult outHit)
			=> E_UPrimitiveComponent_K2_SphereOverlapComponent(this, inSphereCentre, inSphereRadius, bTraceComplex, bShowTrace, bPersistentShowTrace, hitLocation, hitNormal, boneName, outHit);
		
		
		/// <summary>
		/// Perform a sphere trace against a single component
		/// </summary>
		/// <param name="traceStart">The start of the trace in world-space</param>
		/// <param name="traceEnd">The end of the trace in world-space</param>
		/// <param name="sphereRadius">Radius of the sphere to trace against the component</param>
		/// <param name="bTraceComplex">Whether or not to trace the complex physics representation or just the simple representation</param>
		/// <param name="bShowTrace">Whether or not to draw the trace in the world (for debugging)</param>
		/// <param name="bPersistentShowTrace">Whether or not to make the debugging draw stay in the world permanently</param>
		public bool SphereTraceComponent(FVector traceStart, FVector traceEnd, float sphereRadius, bool bTraceComplex, bool bShowTrace, bool bPersistentShowTrace, FVector hitLocation, FVector hitNormal, string boneName, FHitResult outHit)
			=> E_UPrimitiveComponent_K2_SphereTraceComponent(this, traceStart, traceEnd, sphereRadius, bTraceComplex, bShowTrace, bPersistentShowTrace, hitLocation, hitNormal, boneName, outHit);
		
		
		/// <summary>
		/// Trace a ray against just this component.
		/// </summary>
		/// <param name="outHit">Information about hit against this component, if true is returned</param>
		/// <param name="start">Start location of the ray</param>
		/// <param name="end">End location of the ray</param>
		/// <param name="@params">Additional parameters used for the trace</param>
		/// <return>true</return>
		public virtual bool LineTraceComponent(FHitResult outHit, FVector start, FVector end, FCollisionQueryParams @params)
			=> E_UPrimitiveComponent_LineTraceComponent(this, outHit, start, end, @params);
		
		
		/// <summary>
		/// Called when the BodyInstance ResponseToChannels, CollisionEnabled or bNotifyRigidBodyCollision changes, in case subclasses want to use that information.
		/// </summary>
		protected virtual void OnComponentCollisionSettingsChanged()
			=> E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(this);
		
		
		/// <summary>
		/// Pushes new hover state to the render thread primitive proxy
		/// </summary>
		/// <param name="bInHovered">true if the proxy should display as if hovered</param>
		public void PushHoveredToProxy(bool bInHovered)
			=> E_UPrimitiveComponent_PushHoveredToProxy(this, bInHovered);
		
		
		/// <summary>
		/// Pushes new selection state to the render thread primitive proxy
		/// </summary>
		public void PushSelectionToProxy()
			=> E_UPrimitiveComponent_PushSelectionToProxy(this);
		
		
		/// <summary>
		/// Force all bodies in this component to sleep.
		/// </summary>
		public virtual void PutAllRigidBodiesToSleep()
			=> E_UPrimitiveComponent_PutAllRigidBodiesToSleep(this);
		
		
		/// <summary>
		/// Force a single body back to sleep.
		/// </summary>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to put to sleep. 'None' indicates root body.</param>
		public void PutRigidBodyToSleep(string boneName)
			=> E_UPrimitiveComponent_PutRigidBodyToSleep(this, boneName);
		
		
		/// <summary>
		/// Event called when a component is 'damaged', allowing for component class specific behaviour
		/// </summary>
		public virtual void ReceiveComponentDamage(float damageAmount, FDamageEvent damageEvent, AController eventInstigator, AActor damageCauser)
			=> E_UPrimitiveComponent_ReceiveComponentDamage(this, damageAmount, damageEvent, eventInstigator, damageCauser);
		
		
		/// <summary>
		/// Returns if a single body is currently awake and simulating.
		/// </summary>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to return wakeful state from. 'None' indicates root body.</param>
		public bool RigidBodyIsAwake(string boneName)
			=> E_UPrimitiveComponent_RigidBodyIsAwake(this, boneName);
		
		
		/// <summary>
		/// Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object.
		/// </summary>
		public virtual FVector ScaleByMomentOfInertia(FVector inputVector, string boneName)
			=> E_UPrimitiveComponent_ScaleByMomentOfInertia(this, inputVector, boneName);
		
		
		/// <summary>
		/// Called to send a transform update for this component to the physics engine
		/// </summary>
		protected void SendPhysicsTransform(ETeleportType teleport)
			=> E_UPrimitiveComponent_SendPhysicsTransform(this, (byte)teleport);
		
		
		/// <summary>
		/// Change the mass scale used fo all bodies in this component
		/// </summary>
		public virtual void SetAllMassScale(float inMassScale)
			=> E_UPrimitiveComponent_SetAllMassScale(this, inMassScale);
		
		
		/// <summary>
		/// Set the angular velocity of all bodies in this component.
		/// </summary>
		/// <param name="newAngVel">New angular velocity to apply to physics, in degrees per second.</param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies.</param>
		public void SetAllPhysicsAngularVelocityInDegrees(FVector newAngVel, bool bAddToCurrent = false)
			=> E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInDegrees(this, newAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// Set the angular velocity of all bodies in this component.
		/// </summary>
		/// <param name="newAngVel">New angular velocity to apply to physics, in radians per second.</param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies.</param>
		public virtual void SetAllPhysicsAngularVelocityInRadians(FVector newAngVel, bool bAddToCurrent)
			=> E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInRadians(this, newAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// Set the linear velocity of all bodies in this component.
		/// </summary>
		/// <param name="newVel">New linear velocity to apply to physics.</param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body.</param>
		public virtual void SetAllPhysicsLinearVelocity(FVector newVel, bool bAddToCurrent)
			=> E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(this, newVel, bAddToCurrent);
		
		
		/// <summary>
		/// Set the position of all bodies in this component.
		/// <para>If a SkeletalMeshComponent, the root body will be placed at the desired position, and the same delta is applied to all other bodies. </para>
		/// </summary>
		/// <param name="newPos">New position for the body</param>
		public virtual void SetAllPhysicsPosition(FVector newPos)
			=> E_UPrimitiveComponent_SetAllPhysicsPosition(this, newPos);
		
		
		/// <summary>
		/// Set the rotation of all bodies in this component.
		/// <para>If a SkeletalMeshComponent, the root body will be changed to the desired orientation, and the same delta is applied to all other bodies. </para>
		/// </summary>
		/// <param name="newRot">New orienatation for the body</param>
		public virtual void SetAllPhysicsRotation(FRotator newRot)
			=> E_UPrimitiveComponent_SetAllPhysicsRotation(this, newRot);
		
		
		/// <summary>
		/// Set the rotation of all bodies in this component.
		/// <para>If a SkeletalMeshComponent, the root body will be changed to the desired orientation, and the same delta is applied to all other bodies. </para>
		/// </summary>
		/// <param name="newRot">New orienatation for the body</param>
		public virtual void SetAllPhysicsRotation(FQuat newRot)
			=> E_UPrimitiveComponent_SetAllPhysicsRotation_o1(this, newRot);
		
		
		/// <summary>
		/// Set whether all bodies in this component should use Continuous Collision Detection
		/// </summary>
		public virtual void SetAllUseCCD(bool inUseCCD)
			=> E_UPrimitiveComponent_SetAllUseCCD(this, inUseCCD);
		
		
		/// <summary>
		/// Sets the angular damping of this component.
		/// </summary>
		public virtual void SetAngularDamping(float inDamping)
			=> E_UPrimitiveComponent_SetAngularDamping(this, inDamping);
		
		
		/// <summary>
		/// Scale the bounds of this object, used for frustum culling. Useful for features like WorldPositionOffset.
		/// </summary>
		public void SetBoundsScale(float newBoundsScale)
			=> E_UPrimitiveComponent_SetBoundsScale(this, newBoundsScale);
		
		
		/// <summary>
		/// Utility to cache the max draw distance based on cull distance volumes or the desired max draw distance
		/// </summary>
		public void SetCachedMaxDrawDistance(float newCachedMaxDrawDistance)
			=> E_UPrimitiveComponent_SetCachedMaxDrawDistance(this, newCachedMaxDrawDistance);
		
		
		/// <summary>
		/// Changes the value of CastShadow.
		/// </summary>
		public void SetCastShadow(bool newCastShadow)
			=> E_UPrimitiveComponent_SetCastShadow(this, newCastShadow);
		
		
		/// <summary>
		/// Set the center of mass of a single body. This will offset the physx-calculated center of mass.
		/// <para>Note that in the case where multiple bodies are attached together, the center of mass will be set for the entire group. </para>
		/// </summary>
		/// <param name="centerOfMassOffset">User specified offset for the center of mass of this object, from the calculated location.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body.</param>
		public void SetCenterOfMass(FVector centerOfMassOffset, string boneName)
			=> E_UPrimitiveComponent_SetCenterOfMass(this, centerOfMassOffset, boneName);
		
		
		/// <summary>
		/// Changes the collision channel that this object uses when it moves
		/// </summary>
		/// <param name="channel">The new channel for this component to use</param>
		public virtual void SetCollisionObjectType(ECollisionChannel channel)
			=> E_UPrimitiveComponent_SetCollisionObjectType(this, (byte)channel);
		
		
		/// <summary>
		/// Set Collision Profile Name
		/// <para>This function is called by constructors when they set ProfileName </para>
		/// This will change current CollisionProfileName to be this, and overwrite Collision Setting
		/// </summary>
		/// <param name="inCollisionProfileName">New Profile Name</param>
		public virtual void SetCollisionProfileName(string inCollisionProfileName)
			=> E_UPrimitiveComponent_SetCollisionProfileName(this, inCollisionProfileName);
		
		
		/// <summary>
		/// Changes all ResponseToChannels container for this PrimitiveComponent. to be NewResponse
		/// </summary>
		/// <param name="newResponse">What the new response should be to the supplied Channel</param>
		public virtual void SetCollisionResponseToAllChannels(ECollisionResponse newResponse)
			=> E_UPrimitiveComponent_SetCollisionResponseToAllChannels(this, (byte)newResponse);
		
		
		/// <summary>
		/// Changes a member of the ResponseToChannels container for this PrimitiveComponent.
		/// </summary>
		/// <param name="channel">The channel to change the response of</param>
		/// <param name="newResponse">What the new response should be to the supplied Channel</param>
		public virtual void SetCollisionResponseToChannel(ECollisionChannel channel, ECollisionResponse newResponse)
			=> E_UPrimitiveComponent_SetCollisionResponseToChannel(this, (byte)channel, (byte)newResponse);
		
		
		/// <summary>
		/// Changes the whole ResponseToChannels container for this PrimitiveComponent.
		/// </summary>
		/// <param name="newResponses">New set of responses for this component</param>
		public virtual void SetCollisionResponseToChannels(FCollisionResponseContainer newReponses)
			=> E_UPrimitiveComponent_SetCollisionResponseToChannels(this, newReponses);
		
		
		/// <summary>
		/// Changes the value of CullDistance.
		/// </summary>
		/// <param name="newCullDistance">The value to assign to CullDistance.</param>
		public void SetMaxDrawDistance(float newCullDistance)
			=> E_UPrimitiveComponent_SetCullDistance(this, newCullDistance);
		
		
		/// <summary>
		/// Sets the CustomDepth stencil value (0 - 255) and marks the render state dirty.
		/// </summary>
		public void SetCustomDepthStencilValue(int value)
			=> E_UPrimitiveComponent_SetCustomDepthStencilValue(this, value);
		
		
		/// <summary>
		/// Sets the CustomDepth stencil write mask and marks the render state dirty.
		/// </summary>
		public void SetCustomDepthStencilWriteMask(ERendererStencilMask writeMaskBit)
			=> E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(this, (byte)writeMaskBit);
		
		
		/// <summary>
		/// Changes the value of DepthPriorityGroup.
		/// </summary>
		/// <param name="newDepthPriorityGroup">The value to assign to DepthPriorityGroup.</param>
		public void SetDepthPriorityGroup(ESceneDepthPriorityGroup newDepthPriorityGroup)
			=> E_UPrimitiveComponent_SetDepthPriorityGroup(this, (byte)newDepthPriorityGroup);
		
		
		/// <summary>
		/// Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true.
		/// </summary>
		public virtual void SetEnableGravity(bool bGravityEnabled)
			=> E_UPrimitiveComponent_SetEnableGravity(this, bGravityEnabled);
		
		public void SetGenerateOverlapEvents(bool bInGenerateOverlapEvents)
			=> E_UPrimitiveComponent_SetGenerateOverlapEvents(this, bInGenerateOverlapEvents);
		
		
		/// <summary>
		/// Sets the linear damping of this component.
		/// </summary>
		public virtual void SetLinearDamping(float inDamping)
			=> E_UPrimitiveComponent_SetLinearDamping(this, inDamping);
		
		
		/// <summary>
		/// Set LOD Parent component, normally associated with an ALODActor
		/// </summary>
		public void SetLODParentPrimitive(UPrimitiveComponent inLODParentPrimitive)
			=> E_UPrimitiveComponent_SetLODParentPrimitive(this, inLODParentPrimitive);
		
		
		/// <summary>
		/// Override the mass (in Kg) of a single physics body.
		/// <para>Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group. </para>
		/// Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass.
		/// </summary>
		public virtual void SetMassOverrideInKg(string boneName, float massInKg, bool bOverrideMass)
			=> E_UPrimitiveComponent_SetMassOverrideInKg(this, boneName, massInKg, bOverrideMass);
		
		
		/// <summary>
		/// Change the mass scale used to calculate the mass of a single physics body
		/// </summary>
		public virtual void SetMassScale(string boneName, float inMassScale)
			=> E_UPrimitiveComponent_SetMassScale(this, boneName, inMassScale);
		
		
		/// <summary>
		/// Changes the value of bNotifyRigidBodyCollision
		/// </summary>
		public virtual void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
			=> E_UPrimitiveComponent_SetNotifyRigidBodyCollision(this, bNewNotifyRigidBodyCollision);
		
		
		/// <summary>
		/// Changes the value of bOnlyOwnerSee.
		/// </summary>
		public void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
			=> E_UPrimitiveComponent_SetOnlyOwnerSee(this, bNewOnlyOwnerSee);
		
		
		/// <summary>
		/// Changes the value of bOwnerNoSee.
		/// </summary>
		public void SetOwnerNoSee(bool bNewOwnerNoSee)
			=> E_UPrimitiveComponent_SetOwnerNoSee(this, bNewOwnerNoSee);
		
		
		/// <summary>
		/// Set the angular velocity of a single body.
		/// <para>This should be used cautiously - it may be better to use AddTorque or AddImpulse. </para>
		/// </summary>
		/// <param name="newAngVel">New angular velocity to apply to body, in degrees per second.</param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of the body.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body.</param>
		public void SetPhysicsAngularVelocity(FVector newAngVel, bool bAddToCurrent, string boneName)
			=> E_UPrimitiveComponent_SetPhysicsAngularVelocity(this, newAngVel, bAddToCurrent, boneName);
		
		
		/// <summary>
		/// Set the angular velocity of a single body.
		/// <para>This should be used cautiously - it may be better to use AddTorque or AddImpulse. </para>
		/// </summary>
		/// <param name="newAngVel">New angular velocity to apply to body, in degrees per second.</param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of the body.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body.</param>
		public void SetPhysicsAngularVelocityInDegrees(FVector newAngVel, bool bAddToCurrent, string boneName)
			=> E_UPrimitiveComponent_SetPhysicsAngularVelocityInDegrees(this, newAngVel, bAddToCurrent, boneName);
		
		
		/// <summary>
		/// Set the angular velocity of a single body.
		/// <para>This should be used cautiously - it may be better to use AddTorque or AddImpulse. </para>
		/// </summary>
		/// <param name="newAngVel">New angular velocity to apply to body, in radians per second.</param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of the body.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body.</param>
		public virtual void SetPhysicsAngularVelocityInRadians(FVector newAngVel, bool bAddToCurrent, string boneName)
			=> E_UPrimitiveComponent_SetPhysicsAngularVelocityInRadians(this, newAngVel, bAddToCurrent, boneName);
		
		
		/// <summary>
		/// Set the linear velocity of a single body.
		/// <para>This should be used cautiously - it may be better to use AddForce or AddImpulse. </para>
		/// </summary>
		/// <param name="newVel">New linear velocity to apply to physics.</param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to modify velocity of. 'None' indicates root body.</param>
		public virtual void SetPhysicsLinearVelocity(FVector newVel, bool bAddToCurrent, string boneName)
			=> E_UPrimitiveComponent_SetPhysicsLinearVelocity(this, newVel, bAddToCurrent, boneName);
		
		
		/// <summary>
		/// Set the maximum angular velocity of a single body.
		/// </summary>
		/// <param name="newMaxAngVel">New maximum angular velocity to apply to body, in degrees per second.</param>
		/// <param name="bAddToCurrent">If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.</param>
		public void SetPhysicsMaxAngularVelocity(float newMaxAngVel, bool bAddToCurrent, string boneName)
			=> E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(this, newMaxAngVel, bAddToCurrent, boneName);
		
		
		/// <summary>
		/// Set the maximum angular velocity of a single body.
		/// </summary>
		/// <param name="newMaxAngVel">New maximum angular velocity to apply to body, in degrees per second.</param>
		/// <param name="bAddToCurrent">If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.</param>
		public void SetPhysicsMaxAngularVelocityInDegrees(float newMaxAngVel, bool bAddToCurrent, string boneName)
			=> E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInDegrees(this, newMaxAngVel, bAddToCurrent, boneName);
		
		
		/// <summary>
		/// Set the maximum angular velocity of a single body.
		/// </summary>
		/// <param name="newMaxAngVel">New maximum angular velocity to apply to body, in radians per second.</param>
		/// <param name="bAddToCurrent">If true, NewMaxAngVel is added to the existing maximum angular velocity of the body.</param>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body.</param>
		public void SetPhysicsMaxAngularVelocityInRadians(float newMaxAngVel, bool bAddToCurrent, string boneName)
			=> E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInRadians(this, newMaxAngVel, bAddToCurrent, boneName);
		
		
		/// <summary>
		/// Controls if we get a post physics tick or not. If set during ticking, will take effect next frame
		/// </summary>
		public void SetPostPhysicsComponentTickEnabled(bool bEnable)
			=> E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(this, bEnable);
		
		
		/// <summary>
		/// Changes the value of bReceivesDecals.
		/// </summary>
		public void SetReceivesDecals(bool bNewReceivesDecals)
			=> E_UPrimitiveComponent_SetReceivesDecals(this, bNewReceivesDecals);
		
		
		/// <summary>
		/// Sets the bRenderCustomDepth property and marks the render state dirty.
		/// </summary>
		public void SetRenderCustomDepth(bool bValue)
			=> E_UPrimitiveComponent_SetRenderCustomDepth(this, bValue);
		
		
		/// <summary>
		/// Sets bRenderInMainPass property and marks the render state dirty.
		/// </summary>
		public void SetRenderInMainPass(bool bValue)
			=> E_UPrimitiveComponent_SetRenderInMainPass(this, bValue);
		
		
		/// <summary>
		/// Applies RigidBodyState only if it needs to be updated
		/// <para>NeedsUpdate flag will be removed from UpdatedState after all velocity corrections are finished </para>
		/// </summary>
		public void SetRigidBodyReplicatedTarget(FRigidBodyState updatedState, string boneName)
			=> E_UPrimitiveComponent_SetRigidBodyReplicatedTarget(this, updatedState, boneName);
		
		
		/// <summary>
		/// Sets whether or not a single body should use physics simulation, or should be 'fixed' (kinematic).
		/// <para>Note that if this component is currently attached to something, beginning simulation will detach it. </para>
		/// </summary>
		/// <param name="bSimulate">New simulation state for single body</param>
		public virtual void SetSimulatePhysics(bool bSimulate)
			=> E_UPrimitiveComponent_SetSimulatePhysics(this, bSimulate);
		
		
		/// <summary>
		/// Changes the value of bSingleSampleShadowFromStationaryLights.
		/// </summary>
		public void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights)
			=> E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(this, bNewSingleSampleShadowFromStationaryLights);
		
		
		/// <summary>
		/// Changes the value of TranslucentSortPriority.
		/// </summary>
		public void SetTranslucentSortPriority(int newTranslucentSortPriority)
			=> E_UPrimitiveComponent_SetTranslucentSortPriority(this, newTranslucentSortPriority);
		
		
		/// <summary>
		/// Set whether this component should use Continuous Collision Detection
		/// </summary>
		public virtual void SetUseCCD(bool inUseCCD, string boneName)
			=> E_UPrimitiveComponent_SetUseCCD(this, inUseCCD, boneName);
		
		
		/// <summary>
		/// Changes the value of bUseViewOwnerDepthPriorityGroup and ViewOwnerDepthPriorityGroup.
		/// </summary>
		/// <param name="bNewUseViewOwnerDepthPriorityGroup">The value to assign to bUseViewOwnerDepthPriorityGroup.</param>
		/// <param name="newViewOwnerDepthPriorityGroup">The value to assign to ViewOwnerDepthPriorityGroup.</param>
		public void SetViewOwnerDepthPriorityGroup(bool bNewUseViewOwnerDepthPriorityGroup, ESceneDepthPriorityGroup newViewOwnerDepthPriorityGroup)
			=> E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(this, bNewUseViewOwnerDepthPriorityGroup, (byte)newViewOwnerDepthPriorityGroup);
		
		
		/// <summary>
		/// Looking at various values of the component, determines if this
		/// <para>component should be added to the scene </para>
		/// </summary>
		/// <return>true</return>
		public bool ShouldComponentAddToScene()
			=> E_UPrimitiveComponent_ShouldComponentAddToScene(this);
		
		
		/// <summary>
		/// Determines whether the proxy for this primitive type needs to be recreated whenever the primitive moves.
		/// </summary>
		/// <return>true</return>
		public virtual bool ShouldRecreateProxyOnUpdateTransform()
			=> E_UPrimitiveComponent_ShouldRecreateProxyOnUpdateTransform(this);
		
		
		/// <summary>
		/// Return true if the owner is selected and this component is selectable
		/// </summary>
		public virtual bool ShouldRenderSelected()
			=> E_UPrimitiveComponent_ShouldRenderSelected(this);
		
		
		/// <summary>
		/// Whether the component type supports static lighting.
		/// </summary>
		protected virtual bool SupportsStaticLighting()
			=> E_UPrimitiveComponent_SupportsStaticLighting(this);
		
		
		/// <summary>
		/// Move this component to match the physics rigid body pose. Note, a warning will be generated if you call this function on a component that is attached to something
		/// </summary>
		public void SyncComponentToRBPhysics()
			=> E_UPrimitiveComponent_SyncComponentToRBPhysics(this);
		
		
		/// <summary>
		/// Unwelds the children of this component. Attachment is maintained
		/// </summary>
		public virtual void UnWeldChildren()
			=> E_UPrimitiveComponent_UnWeldChildren(this);
		
		
		/// <summary>
		/// UnWelds this component from its parent component. Attachment is maintained (DetachFromParent automatically unwelds)
		/// </summary>
		public virtual void UnWeldFromParent()
			=> E_UPrimitiveComponent_UnWeldFromParent(this);
		
		
		/// <summary>
		/// Internal function that updates physics objects to match the component collision settings.
		/// </summary>
		protected virtual void UpdatePhysicsToRBChannels()
			=> E_UPrimitiveComponent_UpdatePhysicsToRBChannels(this);
		
		
		/// <summary>
		/// Returns true if only unlit materials are used for rendering, false otherwise.
		/// </summary>
		public virtual bool UsesOnlyUnlitMaterials()
			=> E_UPrimitiveComponent_UsesOnlyUnlitMaterials(this);
		
		
		/// <summary>
		/// Ensure simulation is running for all bodies in this component.
		/// </summary>
		public virtual void WakeAllRigidBodies()
			=> E_UPrimitiveComponent_WakeAllRigidBodies(this);
		
		
		/// <summary>
		/// 'Wake' physics simulation for a single body.
		/// </summary>
		/// <param name="boneName">If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body.</param>
		public virtual void WakeRigidBody(string boneName)
			=> E_UPrimitiveComponent_WakeRigidBody(this, boneName);
		
		
		/// <summary>
		/// Welds this component to another scene component, optionally at a named socket. Component is automatically attached if not already
		/// <para>Welding allows the child physics object to become physically connected to its parent. This is useful for creating compound rigid bodies with correct mass distribution. </para>
		/// </summary>
		/// <param name="inParent">the component to be physically attached to</param>
		/// <param name="inSocketName">optional socket to attach component to</param>
		public virtual void WeldTo(USceneComponent inParent, string inSocketName)
			=> E_UPrimitiveComponent_WeldTo(this, inParent, inSocketName);
		
		
		/// <summary>
		/// Does the actual work for welding.
		/// </summary>
		/// <return>true</return>
		public virtual bool WeldToImplementation(USceneComponent inParent, string parentSocketName, bool bWeldSimulatedChild)
			=> E_UPrimitiveComponent_WeldToImplementation(this, inParent, parentSocketName, bWeldSimulatedChild);
		
		#endregion
		
		public static implicit operator IntPtr(UPrimitiveComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPrimitiveComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPrimitiveComponent>(PtrDesc);
		}}}
