using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PrimitiveComponent.h:170

namespace UnrealEngine
{
	public  partial class UPrimitiveComponent : USceneComponent
	{
		public UPrimitiveComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPrimitiveComponent(UObject Parent = null, string Name = "PrimitiveComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPrimitiveComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPrimitiveComponent(IntPtr Parent, string Name);
		
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
		private static extern byte E_PROP_UPrimitiveComponent_bCheckAsyncSceneOnMove_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bCheckAsyncSceneOnMove_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bForceMipStreaming_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bForceMipStreaming_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UPrimitiveComponent_bGenerateOverlapEvents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bGenerateOverlapEvents_SET(IntPtr Ptr, byte Value);
		
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
		private static extern byte E_PROP_UPrimitiveComponent_bRenderInMono_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPrimitiveComponent_bRenderInMono_SET(IntPtr Ptr, byte Value);
		
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
		private static extern int E_PROP_UPrimitiveComponent_CurrentTag_GET();
		
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
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddAngularImpulse(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddAngularImpulseInDegrees(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddAngularImpulseInRadians(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddForce(IntPtr Self, IntPtr Force, string BoneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddForceAtLocation(IntPtr Self, IntPtr Force, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddForceAtLocationLocal(IntPtr Self, IntPtr Force, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddImpulse(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddImpulseAtLocation(IntPtr Self, IntPtr Impulse, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddRadialForce(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddRadialImpulse(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddTorque(IntPtr Self, IntPtr Torque, string BoneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddTorqueInDegrees(IntPtr Self, IntPtr Torque, string BoneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_AddTorqueInRadians(IntPtr Self, IntPtr Torque, string BoneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(IntPtr Self, bool bAllowCachedValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_AreSymmetricRotations(IntPtr Self, IntPtr A, IntPtr B, IntPtr Scale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_BeginComponentOverlap(IntPtr Self, IntPtr OtherOverlap, bool bDoNotifies);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_CalculateMass(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_CanCharacterStepUp(IntPtr Self, IntPtr Pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_CanEditSimulatePhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ClearComponentOverlaps(IntPtr Self, bool bDoNotifies, bool bSkipNotifySelf);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ClearMoveIgnoreActors(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_ClearMoveIgnoreComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ConditionalApplyRigidBodyState(IntPtr Self, IntPtr UpdatedState, IntPtr ErrorCorrection, IntPtr OutDeltaPos, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_DispatchMouseOverEvents(IntPtr Self, IntPtr CurrentComponent, IntPtr NewComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_DispatchWakeEvents(IntPtr Self, int WakeEvent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_EndComponentOverlap(IntPtr Self, IntPtr OtherOverlap, bool bDoNotifies, bool bSkipNotifySelf);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_EnsurePhysicsStateCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetAngularDamping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetCenterOfMass(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetClosestPointOnCollision(IntPtr Self, IntPtr Point, IntPtr OutPointOnBody, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UPrimitiveComponent_GetCollisionProfileName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetDiffuseBoost(IntPtr Self, int ElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetDistanceToCollision(IntPtr Self, IntPtr Point, IntPtr ClosestPointOnCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetEmissiveBoost(IntPtr Self, int ElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetInertiaTensor(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(IntPtr Self, int LightMapMemoryUsage, int ShadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetLightMapResolution(IntPtr Self, int Width, int Height);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetLinearDamping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPrimitiveComponent_GetLODParentPrimitive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetMass(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPrimitiveComponent_GetMassScale(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UPrimitiveComponent_GetNumMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsAngularVelocity(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsAngularVelocityInDegrees(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsAngularVelocityInRadians(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsLinearVelocity(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(IntPtr Self, IntPtr Point, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetRigidBodyState(IntPtr Self, IntPtr OutState, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetShadowIndirectOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_GetSquaredDistanceToCollision(IntPtr Self, IntPtr Point, float OutSquaredDistance, IntPtr OutClosestPointOnCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UPrimitiveComponent_GetStaticDepthPriorityGroup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UPrimitiveComponent_GetStaticLightMapResolution(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_HasStaticLighting(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_HasValidSettingsForStaticLighting(IntPtr Self, bool bOverlookInvalidComponents);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_IgnoreActorWhenMoving(IntPtr Self, IntPtr Actor, bool bShouldIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_IgnoreComponentWhenMoving(IntPtr Self, IntPtr Component, bool bShouldIgnore);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsAnyRigidBodyAwake(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsAttachedToStreamingManager(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsComponentIndividuallySelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsGravityEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsOverlappingActor(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsWelded(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_IsZeroExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_IsCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_K2_LineTraceComponent(IntPtr Self, IntPtr TraceStart, IntPtr TraceEnd, bool bTraceComplex, bool bShowTrace, IntPtr HitLocation, IntPtr HitNormal, string BoneName, IntPtr OutHit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PushHoveredToProxy(IntPtr Self, bool bInHovered);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PushSelectionToProxy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PutAllRigidBodiesToSleep(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_PutRigidBodyToSleep(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_RigidBodyIsAwake(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UPrimitiveComponent_ScaleByMomentOfInertia(IntPtr Self, IntPtr InputVector, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SendPhysicsTransform(IntPtr Self, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllMassScale(IntPtr Self, float InMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsAngularVelocity(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInDegrees(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInRadians(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(IntPtr Self, IntPtr NewVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllPhysicsPosition(IntPtr Self, IntPtr NewPos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAllUseCCD(IntPtr Self, bool InUseCCD);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetAngularDamping(IntPtr Self, float InDamping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetBoundsScale(IntPtr Self, float NewBoundsScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCachedMaxDrawDistance(IntPtr Self, float NewCachedMaxDrawDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCastShadow(IntPtr Self, bool NewCastShadow);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCenterOfMass(IntPtr Self, IntPtr CenterOfMassOffset, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionObjectType(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionProfileName(IntPtr Self, string InCollisionProfileName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionResponseToAllChannels(IntPtr Self, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionResponseToChannel(IntPtr Self, byte Channel, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCollisionResponseToChannels(IntPtr Self, IntPtr NewReponses);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCullDistance(IntPtr Self, float NewCullDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCustomDepthStencilValue(IntPtr Self, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(IntPtr Self, byte WriteMaskBit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetDepthPriorityGroup(IntPtr Self, byte NewDepthPriorityGroup);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetEnableGravity(IntPtr Self, bool bGravityEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetLinearDamping(IntPtr Self, float InDamping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetLODParentPrimitive(IntPtr Self, IntPtr InLODParentPrimitive);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetMassOverrideInKg(IntPtr Self, string BoneName, float MassInKg, bool bOverrideMass);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetMassScale(IntPtr Self, string BoneName, float InMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetNotifyRigidBodyCollision(IntPtr Self, bool bNewNotifyRigidBodyCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetOnlyOwnerSee(IntPtr Self, bool bNewOnlyOwnerSee);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetOwnerNoSee(IntPtr Self, bool bNewOwnerNoSee);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsAngularVelocity(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsAngularVelocityInDegrees(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsAngularVelocityInRadians(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsLinearVelocity(IntPtr Self, IntPtr NewVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(IntPtr Self, float NewMaxAngVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInDegrees(IntPtr Self, float NewMaxAngVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInRadians(IntPtr Self, float NewMaxAngVel, bool bAddToCurrent, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(IntPtr Self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetReceivesDecals(IntPtr Self, bool bNewReceivesDecals);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetRenderCustomDepth(IntPtr Self, bool bValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetRenderInMainPass(IntPtr Self, bool bValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetRenderInMono(IntPtr Self, bool bValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetSimulatePhysics(IntPtr Self, bool bSimulate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(IntPtr Self, bool bNewSingleSampleShadowFromStationaryLights);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetTranslucentSortPriority(IntPtr Self, int NewTranslucentSortPriority);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetUseCCD(IntPtr Self, bool InUseCCD, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(IntPtr Self, bool bNewUseViewOwnerDepthPriorityGroup, byte NewViewOwnerDepthPriorityGroup);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SetWalkableSlopeOverride(IntPtr Self, IntPtr NewOverride);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ShouldComponentAddToScene(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ShouldRecreateProxyOnUpdateTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_ShouldRenderSelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_SupportsStaticLighting(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_SyncComponentToRBPhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_UnWeldChildren(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_UnWeldFromParent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_UpdatePhysicsToRBChannels(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_UsesOnlyUnlitMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_WakeAllRigidBodies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_WakeRigidBody(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPrimitiveComponent_WeldTo(IntPtr Self, IntPtr InParent, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPrimitiveComponent_WeldToImplementation(IntPtr Self, IntPtr InParent, string ParentSocketName, bool bWeldSimulatedChild);
		
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
		/// <para>Controls whether the primitive should affect dynamic distance field lighting methods.  This flag is only used if CastShadow is true. </para>
		/// </summary>
		public byte bAffectDistanceFieldLighting
		{
			get => E_PROP_UPrimitiveComponent_bAffectDistanceFieldLighting_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAffectDistanceFieldLighting_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls whether the primitive should inject light into the Light Propagation Volume.  This flag is only used if CastShadow is true. </para>
		/// </summary>
		public byte bAffectDynamicIndirectLighting
		{
			get => E_PROP_UPrimitiveComponent_bAffectDynamicIndirectLighting_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAffectDynamicIndirectLighting_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to accept cull distance volumes to modify cached cull distance. </para>
		/// </summary>
		public byte bAllowCullDistanceVolume
		{
			get => E_PROP_UPrimitiveComponent_bAllowCullDistanceVolume_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAllowCullDistanceVolume_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Indicates if we'd like to create physics state all the time (for collision and simulation). </para>
		/// <para>If you set this to false, it still will create physics state if collision or simulation activated. </para>
		/// <para>This can help performance if you'd like to avoid overhead of creating physics state when triggers </para>
		/// </summary>
		public byte bAlwaysCreatePhysicsState
		{
			get => E_PROP_UPrimitiveComponent_bAlwaysCreatePhysicsState_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAlwaysCreatePhysicsState_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>True for damage to this component to apply physics impulse, false to opt out of these impulses. </para>
		/// </summary>
		public byte bApplyImpulseOnDamage
		{
			get => E_PROP_UPrimitiveComponent_bApplyImpulseOnDamage_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bApplyImpulseOnDamage_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether this primitive is referenced by a FDynamicTextureInstanceManager </para>
		/// </summary>
		public byte bAttachedToStreamingManagerAsDynamic
		{
			get => E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsDynamic_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsDynamic_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether this primitive is referenced by a FLevelTextureManager </para>
		/// </summary>
		public byte bAttachedToStreamingManagerAsStatic
		{
			get => E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsStatic_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bAttachedToStreamingManagerAsStatic_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether this component should cast shadows from lights that have bCastShadowsFromCinematicObjectsOnly enabled. </para>
		/// <para>This is useful for characters in a cinematic with special cinematic lights, where the cost of shadowmap rendering of the environment is undesired. </para>
		/// </summary>
		public byte bCastCinematicShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastCinematicShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastCinematicShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls whether the primitive should cast shadows in the case of non precomputed shadowing.  This flag is only used if CastShadow is true. </para>
		/// </summary>
		public byte DynamicShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastDynamicShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastDynamicShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When enabled, the component will be rendering into the far shadow cascades (only for directional lights). </para>
		/// </summary>
		public byte FarShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastFarShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastFarShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, the primitive will cast shadows even if bHidden is true. </para>
		/// <para>Controls whether the primitive should cast shadows when hidden. </para>
		/// <para>This flag is only used if CastShadow is true. </para>
		/// </summary>
		public byte HiddenShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastHiddenShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastHiddenShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether this component should create a per-object shadow that gives higher effective shadow resolution. </para>
		/// <para>Useful for cinematic character shadowing. Assumed to be enabled if bSelfShadowOnly is enabled. </para>
		/// </summary>
		public byte DynamicInsetShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastInsetShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastInsetShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether this primitive should cast dynamic shadows as if it were a two sided material. </para>
		/// </summary>
		public byte ShadowTwoSided
		{
			get => E_PROP_UPrimitiveComponent_bCastShadowAsTwoSided_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastShadowAsTwoSided_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether the object should cast a static shadow from shadow casting lights.  This flag is only used if CastShadow is true. </para>
		/// </summary>
		public byte StaticShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastStaticShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastStaticShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether the object should cast a volumetric translucent shadow. </para>
		/// <para>Volumetric translucent shadows are useful for primitives with smoothly changing opacity like particles representing a volume, </para>
		/// <para>But have artifacts when used on highly opaque surfaces. </para>
		/// </summary>
		public byte VolumetricTranslucentShadow
		{
			get => E_PROP_UPrimitiveComponent_bCastVolumetricTranslucentShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCastVolumetricTranslucentShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this component will look for collisions on both physic scenes during movement. </para>
		/// <para>Only required if the asynchronous physics scene is enabled and has geometry in it, and you wish to test for collisions with objects in that scene. </para>
		/// <para>@see MoveComponent() </para>
		/// </summary>
		public byte bCheckAsyncSceneOnMove
		{
			get => E_PROP_UPrimitiveComponent_bCheckAsyncSceneOnMove_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bCheckAsyncSceneOnMove_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, forces mips for textures used by this component to be resident when this component's level is loaded. </para>
		/// </summary>
		public byte bForceMipStreaming
		{
			get => E_PROP_UPrimitiveComponent_bForceMipStreaming_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bForceMipStreaming_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this component will generate overlap events when it is overlapping other components (eg Begin Overlap). </para>
		/// <para>Both components (this and the other) must have this enabled for overlap events to occur. </para>
		/// <para>@see [Overlap Events](https://docs.unrealengine.com/latest/INT/Engine/Physics/Collision/index.html#overlapandgenerateoverlapevents) </para>
		/// <para>@see UpdateOverlaps(), BeginComponentOverlap(), EndComponentOverlap() </para>
		/// </summary>
		public byte bGenerateOverlapEvents
		{
			get => E_PROP_UPrimitiveComponent_bGenerateOverlapEvents_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bGenerateOverlapEvents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether this primitive is handled as dynamic, although it could have no references </para>
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
		/// <para>Will ignore radial forces applied to this component. </para>
		/// </summary>
		public byte bIgnoreRadialForce
		{
			get => E_PROP_UPrimitiveComponent_bIgnoreRadialForce_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bIgnoreRadialForce_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Will ignore radial impulses applied to this component. </para>
		/// </summary>
		public byte bIgnoreRadialImpulse
		{
			get => E_PROP_UPrimitiveComponent_bIgnoreRadialImpulse_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bIgnoreRadialImpulse_SET(NativePointer, value);
		}

		public byte bLightAsIfStatic_DEPRECATED
		{
			get => E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bLightAsIfStatic_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to light this component and any attachments as a group.  This only has effect on the root component of an attachment tree. </para>
		/// <para>When enabled, attached component shadowing settings like bCastInsetShadow, bCastVolumetricTranslucentShadow, etc, will be ignored. </para>
		/// <para>This is useful for improving performance when multiple movable components are attached together. </para>
		/// </summary>
		public byte bLightAttachmentsAsGroup
		{
			get => E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bLightAttachmentsAsGroup_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this component will generate individual overlaps for each overlapping physics body if it is a multi-body component. When false, this component will </para>
		/// <para>generate only one overlap, regardless of how many physics bodies it has and how many of them are overlapping another component/body. This flag has no </para>
		/// <para>influence on single body components. </para>
		/// </summary>
		public byte bMultiBodyOverlap
		{
			get => E_PROP_UPrimitiveComponent_bMultiBodyOverlap_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bMultiBodyOverlap_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If this is True, this component will only be visible when the view actor is the component's owner, directly or indirectly. </para>
		/// </summary>
		public byte bOnlyOwnerSee
		{
			get => E_PROP_UPrimitiveComponent_bOnlyOwnerSee_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bOnlyOwnerSee_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Scales the bounds of the object. </para>
		/// <para>This is useful when using World Position Offset to animate the vertices of the object outside of its bounds. </para>
		/// <para>Warning: Increasing the bounds of an object will reduce performance and shadow quality! </para>
		/// <para>Currently only used by StaticMeshComponent and SkeletalMeshComponent. </para>
		/// </summary>
		public float BoundsScale
		{
			get => E_PROP_UPrimitiveComponent_BoundsScale_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_BoundsScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If this is True, this component won't be visible when the view actor is the component's owner, directly or indirectly. </para>
		/// </summary>
		public byte bOwnerNoSee
		{
			get => E_PROP_UPrimitiveComponent_bOwnerNoSee_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bOwnerNoSee_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Mobile only: </para>
		/// <para>If disabled this component will not receive CSM shadows. (Components that do not receive CSM may have reduced shading cost) </para>
		/// </summary>
		public byte ReceiveCSMShadows
		{
			get => E_PROP_UPrimitiveComponent_bReceiveMobileCSMShadows_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bReceiveMobileCSMShadows_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether the primitive receives decals. </para>
		/// </summary>
		public byte bReceivesDecals
		{
			get => E_PROP_UPrimitiveComponent_bReceivesDecals_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bReceivesDecals_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this component will be rendered in the CustomDepth pass (usually used for outlines) </para>
		/// </summary>
		public byte RenderCustomDepthPass
		{
			get => E_PROP_UPrimitiveComponent_bRenderCustomDepth_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bRenderCustomDepth_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this component will be rendered in the main pass (z prepass, basepass, transparency) </para>
		/// </summary>
		public byte bRenderInMainPass
		{
			get => E_PROP_UPrimitiveComponent_bRenderInMainPass_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bRenderInMainPass_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this component will be rendered in mono only if an HMD is connected and monoscopic far field rendering is activated. </para>
		/// </summary>
		public byte bRenderInMono
		{
			get => E_PROP_UPrimitiveComponent_bRenderInMono_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bRenderInMono_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, component sweeps will return the material in their hit result. </para>
		/// <para>@see MoveComponent(), FHitResult </para>
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
		/// <para>When enabled, the component will only cast a shadow on itself and not other components in the world. </para>
		/// <para>This is especially useful for first person weapons, and forces bCastInsetShadow to be enabled. </para>
		/// </summary>
		public byte bSelfShadowOnly
		{
			get => E_PROP_UPrimitiveComponent_bSelfShadowOnly_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bSelfShadowOnly_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether the whole component should be shadowed as one from stationary lights, which makes shadow receiving much cheaper. </para>
		/// <para>When enabled shadowing data comes from the volume lighting samples precomputed by Lightmass, which are very sparse. </para>
		/// <para>This is currently only used on stationary directional lights. </para>
		/// </summary>
		public byte bSingleSampleShadowFromStationaryLights
		{
			get => E_PROP_UPrimitiveComponent_bSingleSampleShadowFromStationaryLights_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bSingleSampleShadowFromStationaryLights_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, component sweeps with this component should trace against complex collision during movement (for example, each triangle of a mesh). </para>
		/// <para>If false, collision will be resolved against simple collision bounds instead. </para>
		/// <para>@see MoveComponent() </para>
		/// </summary>
		public byte bTraceComplexOnMove
		{
			get => E_PROP_UPrimitiveComponent_bTraceComplexOnMove_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bTraceComplexOnMove_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Treat this primitive as part of the background for occlusion purposes. This can be used as an optimization to reduce the cost of rendering skyboxes, large ground planes that are part of the vista, etc. </para>
		/// </summary>
		public byte bTreatAsBackgroundForOcclusion
		{
			get => E_PROP_UPrimitiveComponent_bTreatAsBackgroundForOcclusion_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bTreatAsBackgroundForOcclusion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to render the primitive in the depth only pass. </para>
		/// <para>This should generally be true for all objects, and let the renderer make decisions about whether to render objects in the depth only pass. </para>
		/// <para>@todo - if any rendering features rely on a complete depth only pass, this variable needs to go away. </para>
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
		/// <para>If true, this component will be visible in reflection captures. </para>
		/// </summary>
		public byte bVisibleInReflectionCaptures
		{
			get => E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_bVisibleInReflectionCaptures_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The distance to cull this primitive at. </para>
		/// <para>A CachedMaxDrawDistance of 0 indicates that the primitive should not be culled by distance. </para>
		/// </summary>
		public float CurrentMaxDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CachedMaxDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls whether the primitive component should cast a shadow or not. </para>
		/// <para>This flag is ignored (no shadows will be generated) if all materials on this component have an Unlit shading model. </para>
		/// </summary>
		public byte CastShadow
		{
			get => E_PROP_UPrimitiveComponent_CastShadow_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CastShadow_SET(NativePointer, value);
		}

		public static int CurrentTag
		{
			get => E_PROP_UPrimitiveComponent_CurrentTag_GET();
		}

		
		/// <summary>
		/// <para>Optionally write this 0-255 value to the stencil buffer in CustomDepth pass (Requires project setting or r.CustomDepth == 3) </para>
		/// </summary>
		public int CustomDepthStencilValue
		{
			get => E_PROP_UPrimitiveComponent_CustomDepthStencilValue_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_CustomDepthStencilValue_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Mask used for stencil buffer writes. </para>
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
		/// <para>Max draw distance exposed to LDs. The real max draw distance is the min (disregarding 0) of this and volumes affecting this object. </para>
		/// </summary>
		public float DesiredMaxDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_LDMaxDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LDMaxDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Channels that this component should be in.  Lights with matching channels will affect the component. </para>
		/// <para>These channels only apply to opaque materials, direct lighting, and dynamic lighting and shadowing. </para>
		/// </summary>
		public FLightingChannels LightingChannels
		{
			get => E_PROP_UPrimitiveComponent_LightingChannels_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LightingChannels_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls the type of lightmap used for this component. </para>
		/// </summary>
		public ELightmapType LightmapType
		{
			get => (ELightmapType)E_PROP_UPrimitiveComponent_LightmapType_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LightmapType_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Multiplier used to scale the Light Propagation Volume light injection bias, to reduce light bleeding. </para>
		/// <para>Set to 0 for no bias, 1 for default or higher for increased biasing (e.g. for </para>
		/// <para>thin geometry such as walls) </para>
		/// </summary>
		public float LpvBiasMultiplier
		{
			get => E_PROP_UPrimitiveComponent_LpvBiasMultiplier_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_LpvBiasMultiplier_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The minimum distance at which the primitive should be rendered, </para>
		/// <para>measured in world space units from the center of the primitive's bounding sphere to the camera position. </para>
		/// </summary>
		public float MinDrawDistance
		{
			get => E_PROP_UPrimitiveComponent_MinDrawDistance_GET(NativePointer);
			set => E_PROP_UPrimitiveComponent_MinDrawDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Translucent objects with a lower sort priority draw behind objects with a higher priority. </para>
		/// <para>Translucent objects with the same priority are rendered from back-to-front based on their bounds origin. </para>
		/// <para>Ignored if the object is not translucent.  The default priority is zero. </para>
		/// <para>Warning: This should never be set to a non-default value unless you know what you are doing, as it will prevent the renderer from sorting correctly. </para>
		/// <para>It is especially problematic on dynamic gameplay effects. </para>
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
		/// <para>Event called when the mouse cursor is moved over this component and mouse over events are enabled in the player controller </para>
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
		
		internal void InvokeEvent_OnBeginCursorOver(ObjectPointerDescription TouchedComponent)
		{
			_Event_OnBeginCursorOver?.Invoke(TouchedComponent);
		}

		
		/// <summary>
		/// <para>Event called when something starts to overlaps this component, for example a player walking into a trigger. </para>
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// <para>@note Both this component and the other one must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// <para>@note When receiving an overlap from another object's movement, the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// <para>will be adjusted to indicate force from the other object against this object. </para>
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
		
		internal void InvokeEvent_OnComponentBeginOverlap(ObjectPointerDescription OverlappedComponent, ObjectPointerDescription OtherActor, ObjectPointerDescription OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
		{
			_Event_OnComponentBeginOverlap?.Invoke(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
		}

		
		/// <summary>
		/// <para>Event called when collision settings change for this component. </para>
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
		
		internal void InvokeEvent_OnComponentCollisionSettingsChangedEvent(ObjectPointerDescription ChangedComponent)
		{
			_Event_OnComponentCollisionSettingsChangedEvent?.Invoke(ChangedComponent);
		}

		
		/// <summary>
		/// <para>Event called when something stops overlapping this component </para>
		/// <para>@note Both this component and the other one must have bGenerateOverlapEvents set to true to generate overlap events. </para>
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
		
		internal void InvokeEvent_OnComponentEndOverlap(ObjectPointerDescription OverlappedComponent, ObjectPointerDescription OtherActor, ObjectPointerDescription OtherComp, int OtherBodyIndex)
		{
			_Event_OnComponentEndOverlap?.Invoke(OverlappedComponent, OtherActor, OtherComp, OtherBodyIndex);
		}

		
		/// <summary>
		/// <para>Event called when a component hits (or is hit by) something solid. This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation. </para>
		/// <para>For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event. </para>
		/// <para>@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled for this component. </para>
		/// <para>@note When receiving a hit from another object's movement, the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// <para>will be adjusted to indicate force from the other object against this object. </para>
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
		
		internal void InvokeEvent_OnComponentHit(ObjectPointerDescription HitComponent, ObjectPointerDescription OtherActor, ObjectPointerDescription OtherComp, FVector NormalImpulse, FHitResult Hit)
		{
			_Event_OnComponentHit?.Invoke(HitComponent, OtherActor, OtherComp, NormalImpulse, Hit);
		}

		
		/// <summary>
		/// <para>Event called when the underlying physics objects is put to sleep </para>
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
		
		internal void InvokeEvent_OnComponentSleep(ObjectPointerDescription SleepingComponent, StringWrapper BoneName)
		{
			_Event_OnComponentSleep?.Invoke(SleepingComponent, BoneName);
		}

		
		/// <summary>
		/// <para>Event called when the underlying physics objects is woken up </para>
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
		
		internal void InvokeEvent_OnComponentWake(ObjectPointerDescription WakingComponent, StringWrapper BoneName)
		{
			_Event_OnComponentWake?.Invoke(WakingComponent, BoneName);
		}

		
		/// <summary>
		/// <para>Event called when the mouse cursor is moved off this component and mouse over events are enabled in the player controller </para>
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
		
		internal void InvokeEvent_OnEndCursorOver(ObjectPointerDescription TouchedComponent)
		{
			_Event_OnEndCursorOver?.Invoke(TouchedComponent);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public virtual void AddAngularImpulse(FVector Impulse, string BoneName, bool bVelChange)
			=> E_UPrimitiveComponent_AddAngularImpulse(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public void AddAngularImpulseInDegrees(FVector Impulse, string BoneName, bool bVelChange = false)
			=> E_UPrimitiveComponent_AddAngularImpulseInDegrees(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public virtual void AddAngularImpulseInRadians(FVector Impulse, string BoneName, bool bVelChange)
			=> E_UPrimitiveComponent_AddAngularImpulseInRadians(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect). </param>
		/// </summary>
		public virtual void AddForce(FVector Force, string BoneName, bool bAccelChange)
			=> E_UPrimitiveComponent_AddForce(this, Force, BoneName, bAccelChange);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location in world space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in world space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public virtual void AddForceAtLocation(FVector Force, FVector Location, string BoneName)
			=> E_UPrimitiveComponent_AddForceAtLocation(this, Force, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location. Both Force and Location should be in body space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in component space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public virtual void AddForceAtLocationLocal(FVector Force, FVector Location, string BoneName)
			=> E_UPrimitiveComponent_AddForceAtLocationLocal(this, Force, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public virtual void AddImpulse(FVector Impulse, string BoneName, bool bVelChange)
			=> E_UPrimitiveComponent_AddImpulse(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body at a specific location. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="Location">Point in world space to apply impulse at. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body. </param>
		/// </summary>
		public virtual void AddImpulseAtLocation(FVector Impulse, FVector Location, string BoneName)
			=> E_UPrimitiveComponent_AddImpulseAtLocation(this, Impulse, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add a force to all bodies in this component, originating from the supplied world-space location. </para>
		/// <param name="Origin">Origin of force in world space. </param>
		/// <param name="Radius">Radius within which to apply the force. </param>
		/// <param name="Strength">Strength of force to apply. </param>
		/// <param name="Falloff">Allows you to control the strength of the force as a function of distance from Origin. </param>
		/// <param name="bAccelChange">If true, Strength is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect). </param>
		/// </summary>
		public virtual void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
			=> E_UPrimitiveComponent_AddRadialForce(this, Origin, Radius, Strength, (byte)Falloff, bAccelChange);
		
		
		/// <summary>
		/// <para>Add an impulse to all rigid bodies in this component, radiating out from the specified position. </para>
		/// <param name="Origin">Point of origin for the radial impulse blast, in world space </param>
		/// <param name="Radius">Size of radial impulse. Beyond this distance from Origin, there will be no affect. </param>
		/// <param name="Strength">Maximum strength of impulse applied to body. </param>
		/// <param name="Falloff">Allows you to control the strength of the impulse as a function of distance from Origin. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public virtual void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
			=> E_UPrimitiveComponent_AddRadialImpulse(this, Origin, Radius, Strength, (byte)Falloff, bVelChange);
		
		
		/// <summary>
		/// <para>Add a torque to a single rigid body. </para>
		/// <param name="Torque">Torque to apply. Direction is axis of rotation and magnitude is strength of torque. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect). </param>
		/// </summary>
		public void AddTorque(FVector Torque, string BoneName, bool bAccelChange = false)
			=> E_UPrimitiveComponent_AddTorque(this, Torque, BoneName, bAccelChange);
		
		
		/// <summary>
		/// <para>Add a torque to a single rigid body. </para>
		/// <param name="Torque">Torque to apply. Direction is axis of rotation and magnitude is strength of torque. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect). </param>
		/// </summary>
		public void AddTorqueInDegrees(FVector Torque, string BoneName, bool bAccelChange = false)
			=> E_UPrimitiveComponent_AddTorqueInDegrees(this, Torque, BoneName, bAccelChange);
		
		
		/// <summary>
		/// <para>Add a torque to a single rigid body. </para>
		/// <param name="Torque">Torque to apply. Direction is axis of rotation and magnitude is strength of torque. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply torque to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Torque is taken as a change in angular acceleration instead of a physical torque (i.e. mass will have no effect). </param>
		/// </summary>
		public void AddTorqueInRadians(FVector Torque, string BoneName, bool bAccelChange = false)
			=> E_UPrimitiveComponent_AddTorqueInRadians(this, Torque, BoneName, bAccelChange);
		
		
		/// <summary>
		/// <para>Returns true if all descendant components that we can possibly overlap with use relative location and rotation. </para>
		/// </summary>
		protected virtual bool AreAllCollideableDescendantsRelative(bool bAllowCachedValue)
			=> E_UPrimitiveComponent_AreAllCollideableDescendantsRelative(this, bAllowCachedValue);
		
		
		/// <summary>
		/// <para>Returns true if the given transforms result in the same bounds, due to rotational symmetry. </para>
		/// <para>For example, this is true for a sphere with uniform scale undergoing any rotation. </para>
		/// <para>This is NOT intended to detect every case where this is true, only the common cases to aid optimizations. </para>
		/// </summary>
		public virtual bool AreSymmetricRotations(FQuat A, FQuat B, FVector Scale3D)
			=> E_UPrimitiveComponent_AreSymmetricRotations(this, A, B, Scale3D);
		
		
		/// <summary>
		/// <para>Begin tracking an overlap interaction with the component specified. </para>
		/// <param name="OtherComp">The component of the other actor that this component is now overlapping </param>
		/// <param name="bDoNotifies">True to dispatch appropriate begin/end overlap notifications when these events occur. </param>
		/// <para>@see [Overlap Events](https://docs.unrealengine.com/latest/INT/Engine/Physics/Collision/index.html#overlapandgenerateoverlapevents) </para>
		/// </summary>
		public void BeginComponentOverlap(FOverlapInfo OtherOverlap, bool bDoNotifies)
			=> E_UPrimitiveComponent_BeginComponentOverlap(this, OtherOverlap, bDoNotifies);
		
		
		/// <summary>
		/// <para>Returns the calculated mass in kg. This is not 100% exactly the mass physx will calculate, but it is very close ( difference < 0.1kg ). </para>
		/// </summary>
		public virtual float CalculateMass(string BoneName)
			=> E_UPrimitiveComponent_CalculateMass(this, BoneName);
		
		
		/// <summary>
		/// <para>Return true if the given Pawn can step up onto this component. </para>
		/// <para>This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it. </para>
		/// <param name="Pawn">the Pawn that wants to step onto this component. </param>
		/// <para>@see CanCharacterStepUpOn </para>
		/// </summary>
		public virtual bool CanCharacterStepUp(APawn Pawn)
			=> E_UPrimitiveComponent_CanCharacterStepUp(this, Pawn);
		
		
		/// <summary>
		/// <para>Determines whether or not the simulate physics setting can be edited interactively on this component </para>
		/// </summary>
		public virtual bool CanEditSimulatePhysics()
			=> E_UPrimitiveComponent_CanEditSimulatePhysics(this);
		
		
		/// <summary>
		/// <para>Ends all current component overlaps. Generally used when destroying this component or when it can no longer generate overlaps. </para>
		/// </summary>
		protected void ClearComponentOverlaps(bool bDoNotifies, bool bSkipNotifySelf)
			=> E_UPrimitiveComponent_ClearComponentOverlaps(this, bDoNotifies, bSkipNotifySelf);
		
		
		/// <summary>
		/// <para>Clear the list of actors we ignore when moving. </para>
		/// </summary>
		public void ClearMoveIgnoreActors()
			=> E_UPrimitiveComponent_ClearMoveIgnoreActors(this);
		
		
		/// <summary>
		/// <para>Clear the list of components we ignore when moving. </para>
		/// </summary>
		public void ClearMoveIgnoreComponents()
			=> E_UPrimitiveComponent_ClearMoveIgnoreComponents(this);
		
		
		/// <summary>
		/// <para>Applies RigidBodyState only if it needs to be updated </para>
		/// <para>NeedsUpdate flag will be removed from UpdatedState after all velocity corrections are finished </para>
		/// </summary>
		public bool ConditionalApplyRigidBodyState(FRigidBodyState UpdatedState, FRigidBodyErrorCorrection ErrorCorrection, FVector OutDeltaPos, string BoneName)
			=> E_UPrimitiveComponent_ConditionalApplyRigidBodyState(this, UpdatedState, ErrorCorrection, OutDeltaPos, BoneName);
		
		public void DispatchMouseOverEvents(UPrimitiveComponent CurrentComponent, UPrimitiveComponent NewComponent)
			=> E_UPrimitiveComponent_DispatchMouseOverEvents(this, CurrentComponent, NewComponent);
		
		
		/// <summary>
		/// <para>Dispatch notification for wake events and propagate to any welded bodies </para>
		/// </summary>
		public void DispatchWakeEvents(int WakeEvent, string BoneName)
			=> E_UPrimitiveComponent_DispatchWakeEvents(this, WakeEvent, BoneName);
		
		
		/// <summary>
		/// <para>Finish tracking an overlap interaction that is no longer occurring between this component and the component specified. </para>
		/// <param name="OtherComp">The component of the other actor to stop overlapping </param>
		/// <param name="bDoNotifies">True to dispatch appropriate begin/end overlap notifications when these events occur. </param>
		/// <param name="bSkipNotifySelf">True to skip end overlap notifications to this component's.  Does not affect notifications to OtherComp's actor. </param>
		/// <para>@see [Overlap Events](https://docs.unrealengine.com/latest/INT/Engine/Physics/Collision/index.html#overlapandgenerateoverlapevents) </para>
		/// </summary>
		public void EndComponentOverlap(FOverlapInfo OtherOverlap, bool bDoNotifies = true, bool bSkipNotifySelf = false)
			=> E_UPrimitiveComponent_EndComponentOverlap(this, OtherOverlap, bDoNotifies, bSkipNotifySelf);
		
		
		/// <summary>
		/// <para>Ensure physics state created </para>
		/// </summary>
		protected void EnsurePhysicsStateCreated()
			=> E_UPrimitiveComponent_EnsurePhysicsStateCreated(this);
		
		
		/// <summary>
		/// <para>Returns the angular damping of this component. </para>
		/// </summary>
		public virtual float GetAngularDamping()
			=> E_UPrimitiveComponent_GetAngularDamping(this);
		
		
		/// <summary>
		/// <para>Get the center of mass of a single body. In the case of a welded body this will return the center of mass of the entire welded body (including its parent and children) </para>
		/// <para>Objects that are not simulated return (0,0,0) as they do not have COM </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get center of mass of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetCenterOfMass(string BoneName)
			=> E_UPrimitiveComponent_GetCenterOfMass(this, BoneName);
		
		
		/// <summary>
		/// <para>Returns the distance and closest point to the collision surface. </para>
		/// <para>Component must have simple collision to be queried for closest point. </para>
		/// <param name="Point">World 3D vector </param>
		/// <param name="OutPointOnBody">Point on the surface of collision closest to Point </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body. </param>
		/// <return>Success if returns > 0.f, if returns 0.f, it is either not convex or inside of the point </return>
		/// <para>If returns < 0.f, this primitive does not have collsion </para>
		/// </summary>
		public float GetClosestPointOnCollision(FVector Point, FVector OutPointOnBody, string BoneName)
			=> E_UPrimitiveComponent_GetClosestPointOnCollision(this, Point, OutPointOnBody, BoneName);
		
		
		/// <summary>
		/// <para>Get the collision profile name </para>
		/// </summary>
		public string GetCollisionProfileName()
			=> E_UPrimitiveComponent_GetCollisionProfileName(this);
		
		
		/// <summary>
		/// <para>Gets the diffuse boost for the primitive component. </para>
		/// </summary>
		public virtual float GetDiffuseBoost(int ElementIndex)
			=> E_UPrimitiveComponent_GetDiffuseBoost(this, ElementIndex);
		
		
		/// <summary>
		/// <para>returns Distance to closest Body Instance surface. </para>
		/// <param name="Point">World 3D vector </param>
		/// <param name="OutPointOnBody">Point on the surface of collision closest to Point </param>
		/// <return>Success if returns > 0.f, if returns 0.f, point is inside the geometry </return>
		/// <para>If returns < 0.f, this primitive does not have collsion or if geometry is not supported </para>
		/// </summary>
		public float GetDistanceToCollision(FVector Point, FVector ClosestPointOnCollision)
			=> E_UPrimitiveComponent_GetDistanceToCollision(this, Point, ClosestPointOnCollision);
		
		
		/// <summary>
		/// <para>Gets the emissive boost for the primitive component. </para>
		/// </summary>
		public virtual float GetEmissiveBoost(int ElementIndex)
			=> E_UPrimitiveComponent_GetEmissiveBoost(this, ElementIndex);
		
		
		/// <summary>
		/// <para>Returns the inertia tensor of this component in kg cm^2. The inertia tensor is in local component space. </para>
		/// </summary>
		public virtual FVector GetInertiaTensor(string BoneName)
			=> E_UPrimitiveComponent_GetInertiaTensor(this, BoneName);
		
		
		/// <summary>
		/// <para>Returns the light and shadow map memory for this primitive in its out variables. </para>
		/// <para>Shadow map memory usage is per light whereof lightmap data is independent of number of lights, assuming at least one. </para>
		/// <param name="out">LightMapMemoryUsage		Memory usage in bytes for light map (either texel or vertex) data </param>
		/// <param name="out">ShadowMapMemoryUsage	Memory usage in bytes for shadow map (either texel or vertex) data </param>
		/// </summary>
		public virtual void GetLightAndShadowMapMemoryUsage(int LightMapMemoryUsage, int ShadowMapMemoryUsage)
			=> E_UPrimitiveComponent_GetLightAndShadowMapMemoryUsage(this, LightMapMemoryUsage, ShadowMapMemoryUsage);
		
		
		/// <summary>
		/// <para>Returns the lightmap resolution used for this primitive instance in the case of it supporting texture light/ shadow maps. </para>
		/// <para>0 if not supported or no static shadowing. </para>
		/// <param name="Width">out]	Width of light/shadow map </param>
		/// <param name="Height">out]	Height of light/shadow map </param>
		/// <return>bool			true if LightMap values are padded, false if not </return>
		/// </summary>
		public virtual bool GetLightMapResolution(int Width, int Height)
			=> E_UPrimitiveComponent_GetLightMapResolution(this, Width, Height);
		
		
		/// <summary>
		/// <para>Returns the linear damping of this component. </para>
		/// </summary>
		public virtual float GetLinearDamping()
			=> E_UPrimitiveComponent_GetLinearDamping(this);
		
		public UPrimitiveComponent GetLODParentPrimitive()
			=> E_UPrimitiveComponent_GetLODParentPrimitive(this);
		
		
		/// <summary>
		/// <para>Returns the mass of this component in kg. </para>
		/// </summary>
		public virtual float GetMass()
			=> E_UPrimitiveComponent_GetMass(this);
		
		
		/// <summary>
		/// <para>Returns the mass scale used to calculate the mass of a single physics body </para>
		/// </summary>
		public virtual float GetMassScale(string BoneName)
			=> E_UPrimitiveComponent_GetMassScale(this, BoneName);
		
		
		/// <summary>
		/// <return>number of material elements in this primitive </return>
		/// </summary>
		public virtual int GetNumMaterials()
			=> E_UPrimitiveComponent_GetNumMaterials(this);
		
		
		/// <summary>
		/// <para>Get the angular velocity of a single body, in degrees per second. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetPhysicsAngularVelocity(string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsAngularVelocity(this, BoneName);
		
		
		/// <summary>
		/// <para>Get the angular velocity of a single body, in degrees per second. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetPhysicsAngularVelocityInDegrees(string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsAngularVelocityInDegrees(this, BoneName);
		
		
		/// <summary>
		/// <para>Get the angular velocity of a single body, in radians per second. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetPhysicsAngularVelocityInRadians(string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsAngularVelocityInRadians(this, BoneName);
		
		
		/// <summary>
		/// <para>Get the linear velocity of a single body. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetPhysicsLinearVelocity(string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsLinearVelocity(this, BoneName);
		
		
		/// <summary>
		/// <para>Get the linear velocity of a point on a single body. </para>
		/// <param name="Point">Point is specified in world space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to get velocity of. 'None' indicates root body. </param>
		/// </summary>
		public FVector GetPhysicsLinearVelocityAtPoint(FVector Point, string BoneName)
			=> E_UPrimitiveComponent_GetPhysicsLinearVelocityAtPoint(this, Point, BoneName);
		
		
		/// <summary>
		/// <para>Get the state of the rigid body responsible for this Actor's physics, and fill in the supplied FRigidBodyState struct based on it. </para>
		/// <return>true if we successfully found a physics-engine body and update the state structure from it. </return>
		/// </summary>
		public bool GetRigidBodyState(FRigidBodyState OutState, string BoneName)
			=> E_UPrimitiveComponent_GetRigidBodyState(this, OutState, BoneName);
		
		public virtual bool GetShadowIndirectOnly()
			=> E_UPrimitiveComponent_GetShadowIndirectOnly(this);
		
		
		/// <summary>
		/// <para>returns The square of the distance to closest Body Instance surface. </para>
		/// <param name="Point">World 3D vector </param>
		/// <param name="OutSquaredDistance">The squared distance to closest Body Instance surface. 0 if inside of the body </param>
		/// <param name="OutPointOnBody">Point on the surface of collision closest to Point </param>
		/// <return>true if a distance to the body was found and OutDistanceSquared has been populated </return>
		/// </summary>
		public virtual bool GetSquaredDistanceToCollision(FVector Point, float OutSquaredDistance, FVector OutClosestPointOnCollision)
			=> E_UPrimitiveComponent_GetSquaredDistanceToCollision(this, Point, OutSquaredDistance, OutClosestPointOnCollision);
		
		
		/// <summary>
		/// <para>Determines the DPG the primitive's primary elements are drawn in. </para>
		/// <para>Even if the primitive's elements are drawn in multiple DPGs, a primary DPG is needed for occlusion culling and shadow projection. </para>
		/// <return>The DPG the primitive's primary elements will be drawn in. </return>
		/// </summary>
		public virtual byte GetStaticDepthPriorityGroup()
			=> E_UPrimitiveComponent_GetStaticDepthPriorityGroup(this);
		
		
		/// <summary>
		/// <para>Returns the static lightmap resolution used for this primitive. </para>
		/// <para>0 if not supported or no static shadowing. </para>
		/// <return>int32		The StaticLightmapResolution for the component </return>
		/// </summary>
		public virtual int GetStaticLightMapResolution()
			=> E_UPrimitiveComponent_GetStaticLightMapResolution(this);
		
		
		/// <summary>
		/// <return>True if a primitive's parameters as well as its position is static during gameplay, and can thus use static lighting. </return>
		/// </summary>
		public bool HasStaticLighting()
			=> E_UPrimitiveComponent_HasStaticLighting(this);
		
		public virtual bool HasValidSettingsForStaticLighting(bool bOverlookInvalidComponents)
			=> E_UPrimitiveComponent_HasValidSettingsForStaticLighting(this, bOverlookInvalidComponents);
		
		
		/// <summary>
		/// <para>Tells this component whether to ignore collision with all components of a specific Actor when this component is moved. </para>
		/// <para>Components on the other Actor may also need to be told to do the same when they move. </para>
		/// <para>Does not affect movement of this component when simulating physics. </para>
		/// </summary>
		public void IgnoreActorWhenMoving(AActor Actor, bool bShouldIgnore)
			=> E_UPrimitiveComponent_IgnoreActorWhenMoving(this, Actor, bShouldIgnore);
		
		
		/// <summary>
		/// <para>Tells this component whether to ignore collision with another component when this component is moved. </para>
		/// <para>The other components may also need to be told to do the same when they move. </para>
		/// <para>Does not affect movement of this component when simulating physics. </para>
		/// </summary>
		public void IgnoreComponentWhenMoving(UPrimitiveComponent Component, bool bShouldIgnore)
			=> E_UPrimitiveComponent_IgnoreComponentWhenMoving(this, Component, bShouldIgnore);
		
		
		/// <summary>
		/// <para>Returns if any body in this component is currently awake and simulating. </para>
		/// </summary>
		public virtual bool IsAnyRigidBodyAwake()
			=> E_UPrimitiveComponent_IsAnyRigidBodyAwake(this);
		
		
		/// <summary>
		/// <para>Whether this primitive is referenced by the streaming manager and should sent callbacks when detached or destroyed </para>
		/// </summary>
		public bool IsAttachedToStreamingManager()
			=> E_UPrimitiveComponent_IsAttachedToStreamingManager(this);
		
		
		/// <summary>
		/// <para>Component is directly selected in the editor separate from its parent actor </para>
		/// </summary>
		public bool IsComponentIndividuallySelected()
			=> E_UPrimitiveComponent_IsComponentIndividuallySelected(this);
		
		
		/// <summary>
		/// <para>Returns whether this component is affected by gravity. Returns always false if the component is not simulated. </para>
		/// </summary>
		public virtual bool IsGravityEnabled()
			=> E_UPrimitiveComponent_IsGravityEnabled(this);
		
		
		/// <summary>
		/// <para>Check whether this component is overlapping any component of the given Actor. </para>
		/// <param name="Other">Actor to test this component against. </param>
		/// <return>Whether this component is overlapping any component of the given Actor. </return>
		/// </summary>
		public bool IsOverlappingActor(AActor Other)
			=> E_UPrimitiveComponent_IsOverlappingActor(this, Other);
		
		
		/// <summary>
		/// <para>Returns whether we have the post physics tick enabled </para>
		/// </summary>
		public bool IsPostPhysicsComponentTickEnabled()
			=> E_UPrimitiveComponent_IsPostPhysicsComponentTickEnabled(this);
		
		
		/// <summary>
		/// <para>Whether the component has been welded to another simulating component </para>
		/// </summary>
		public bool IsWelded()
			=> E_UPrimitiveComponent_IsWelded(this);
		
		
		/// <summary>
		/// <para>This isn't bound extent, but for shape component to utilize extent is 0. </para>
		/// <para>For normal primitive, this is 0, for ShapeComponent, this will have valid information </para>
		/// </summary>
		public virtual bool IsZeroExtent()
			=> E_UPrimitiveComponent_IsZeroExtent(this);
		
		
		/// <summary>
		/// <para>Utility to see if there is any form of collision (query or physics) enabled on this component. </para>
		/// </summary>
		public bool IsCollisionEnabled()
			=> E_UPrimitiveComponent_K2_IsCollisionEnabled(this);
		
		
		/// <summary>
		/// <para>Utility to see if there is any physics collision enabled on this component. </para>
		/// </summary>
		public bool IsPhysicsCollisionEnabled()
			=> E_UPrimitiveComponent_K2_IsPhysicsCollisionEnabled(this);
		
		
		/// <summary>
		/// <para>Utility to see if there is any query collision enabled on this component. </para>
		/// </summary>
		public bool IsQueryCollisionEnabled()
			=> E_UPrimitiveComponent_K2_IsQueryCollisionEnabled(this);
		
		
		/// <summary>
		/// <para>Perform a line trace against a single component </para>
		/// </summary>
		public bool LineTraceComponent(FVector TraceStart, FVector TraceEnd, bool bTraceComplex, bool bShowTrace, FVector HitLocation, FVector HitNormal, string BoneName, FHitResult OutHit)
			=> E_UPrimitiveComponent_K2_LineTraceComponent(this, TraceStart, TraceEnd, bTraceComplex, bShowTrace, HitLocation, HitNormal, BoneName, OutHit);
		
		
		/// <summary>
		/// <para>Called when the BodyInstance ResponseToChannels, CollisionEnabled or bNotifyRigidBodyCollision changes, in case subclasses want to use that information. </para>
		/// </summary>
		protected virtual void OnComponentCollisionSettingsChanged()
			=> E_UPrimitiveComponent_OnComponentCollisionSettingsChanged(this);
		
		
		/// <summary>
		/// <para>Pushes new hover state to the render thread primitive proxy </para>
		/// <param name="bInHovered">true if the proxy should display as if hovered </param>
		/// </summary>
		public void PushHoveredToProxy(bool bInHovered)
			=> E_UPrimitiveComponent_PushHoveredToProxy(this, bInHovered);
		
		
		/// <summary>
		/// <para>Pushes new selection state to the render thread primitive proxy </para>
		/// </summary>
		public void PushSelectionToProxy()
			=> E_UPrimitiveComponent_PushSelectionToProxy(this);
		
		
		/// <summary>
		/// <para>Force all bodies in this component to sleep. </para>
		/// </summary>
		public virtual void PutAllRigidBodiesToSleep()
			=> E_UPrimitiveComponent_PutAllRigidBodiesToSleep(this);
		
		
		/// <summary>
		/// <para>Force a single body back to sleep. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to put to sleep. 'None' indicates root body. </param>
		/// </summary>
		public void PutRigidBodyToSleep(string BoneName)
			=> E_UPrimitiveComponent_PutRigidBodyToSleep(this, BoneName);
		
		
		/// <summary>
		/// <para>Returns if a single body is currently awake and simulating. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to return wakeful state from. 'None' indicates root body. </param>
		/// </summary>
		public bool RigidBodyIsAwake(string BoneName)
			=> E_UPrimitiveComponent_RigidBodyIsAwake(this, BoneName);
		
		
		/// <summary>
		/// <para>Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object. </para>
		/// </summary>
		public virtual FVector ScaleByMomentOfInertia(FVector InputVector, string BoneName)
			=> E_UPrimitiveComponent_ScaleByMomentOfInertia(this, InputVector, BoneName);
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the physics engine </para>
		/// </summary>
		protected void SendPhysicsTransform(ETeleportType Teleport)
			=> E_UPrimitiveComponent_SendPhysicsTransform(this, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Change the mass scale used fo all bodies in this component </para>
		/// </summary>
		public virtual void SetAllMassScale(float InMassScale)
			=> E_UPrimitiveComponent_SetAllMassScale(this, InMassScale);
		
		
		/// <summary>
		/// <para>Set the angular velocity of all bodies in this component. </para>
		/// <param name="NewAngVel">New angular velocity to apply to physics, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies. </param>
		/// </summary>
		public virtual void SetAllPhysicsAngularVelocity(FVector NewAngVel, bool bAddToCurrent)
			=> E_UPrimitiveComponent_SetAllPhysicsAngularVelocity(this, NewAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the angular velocity of all bodies in this component. </para>
		/// <param name="NewAngVel">New angular velocity to apply to physics, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies. </param>
		/// </summary>
		public void SetAllPhysicsAngularVelocityInDegrees(FVector NewAngVel, bool bAddToCurrent = false)
			=> E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInDegrees(this, NewAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the angular velocity of all bodies in this component. </para>
		/// <param name="NewAngVel">New angular velocity to apply to physics, in radians per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies. </param>
		/// </summary>
		public virtual void SetAllPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent)
			=> E_UPrimitiveComponent_SetAllPhysicsAngularVelocityInRadians(this, NewAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the linear velocity of all bodies in this component. </para>
		/// <param name="NewVel">New linear velocity to apply to physics. </param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body. </param>
		/// </summary>
		public virtual void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent)
			=> E_UPrimitiveComponent_SetAllPhysicsLinearVelocity(this, NewVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the position of all bodies in this component. </para>
		/// <para>If a SkeletalMeshComponent, the root body will be placed at the desired position, and the same delta is applied to all other bodies. </para>
		/// <param name="NewPos">New position for the body </param>
		/// </summary>
		public virtual void SetAllPhysicsPosition(FVector NewPos)
			=> E_UPrimitiveComponent_SetAllPhysicsPosition(this, NewPos);
		
		
		/// <summary>
		/// <para>Set whether all bodies in this component should use Continuous Collision Detection </para>
		/// </summary>
		public virtual void SetAllUseCCD(bool InUseCCD)
			=> E_UPrimitiveComponent_SetAllUseCCD(this, InUseCCD);
		
		
		/// <summary>
		/// <para>Sets the angular damping of this component. </para>
		/// </summary>
		public virtual void SetAngularDamping(float InDamping)
			=> E_UPrimitiveComponent_SetAngularDamping(this, InDamping);
		
		
		/// <summary>
		/// <para>Scale the bounds of this object, used for frustum culling. Useful for features like WorldPositionOffset. </para>
		/// </summary>
		public void SetBoundsScale(float NewBoundsScale)
			=> E_UPrimitiveComponent_SetBoundsScale(this, NewBoundsScale);
		
		
		/// <summary>
		/// <para>Utility to cache the max draw distance based on cull distance volumes or the desired max draw distance </para>
		/// </summary>
		public void SetCachedMaxDrawDistance(float NewCachedMaxDrawDistance)
			=> E_UPrimitiveComponent_SetCachedMaxDrawDistance(this, NewCachedMaxDrawDistance);
		
		
		/// <summary>
		/// <para>Changes the value of CastShadow. </para>
		/// </summary>
		public void SetCastShadow(bool NewCastShadow)
			=> E_UPrimitiveComponent_SetCastShadow(this, NewCastShadow);
		
		
		/// <summary>
		/// <para>Set the center of mass of a single body. This will offset the physx-calculated center of mass. </para>
		/// <para>Note that in the case where multiple bodies are attached together, the center of mass will be set for the entire group. </para>
		/// <param name="CenterOfMassOffset">User specified offset for the center of mass of this object, from the calculated location. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to set center of mass of. 'None' indicates root body. </param>
		/// </summary>
		public void SetCenterOfMass(FVector CenterOfMassOffset, string BoneName)
			=> E_UPrimitiveComponent_SetCenterOfMass(this, CenterOfMassOffset, BoneName);
		
		
		/// <summary>
		/// <para>Changes the collision channel that this object uses when it moves </para>
		/// <param name="Channel">The new channel for this component to use </param>
		/// </summary>
		public virtual void SetCollisionObjectType(ECollisionChannel Channel)
			=> E_UPrimitiveComponent_SetCollisionObjectType(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Set Collision Profile Name </para>
		/// <para>This function is called by constructors when they set ProfileName </para>
		/// <para>This will change current CollisionProfileName to be this, and overwrite Collision Setting </para>
		/// <param name="InCollisionProfileName">New Profile Name </param>
		/// </summary>
		public virtual void SetCollisionProfileName(string InCollisionProfileName)
			=> E_UPrimitiveComponent_SetCollisionProfileName(this, InCollisionProfileName);
		
		
		/// <summary>
		/// <para>Changes all ResponseToChannels container for this PrimitiveComponent. to be NewResponse </para>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public virtual void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
			=> E_UPrimitiveComponent_SetCollisionResponseToAllChannels(this, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Changes a member of the ResponseToChannels container for this PrimitiveComponent. </para>
		/// <param name="Channel">The channel to change the response of </param>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public virtual void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
			=> E_UPrimitiveComponent_SetCollisionResponseToChannel(this, (byte)Channel, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Changes the whole ResponseToChannels container for this PrimitiveComponent. </para>
		/// <param name="NewResponses">New set of responses for this component </param>
		/// </summary>
		public virtual void SetCollisionResponseToChannels(FCollisionResponseContainer NewReponses)
			=> E_UPrimitiveComponent_SetCollisionResponseToChannels(this, NewReponses);
		
		
		/// <summary>
		/// <para>Changes the value of CullDistance. </para>
		/// <param name="NewCullDistance">The value to assign to CullDistance. </param>
		/// </summary>
		public void SetMaxDrawDistance(float NewCullDistance)
			=> E_UPrimitiveComponent_SetCullDistance(this, NewCullDistance);
		
		
		/// <summary>
		/// <para>Sets the CustomDepth stencil value (0 - 255) and marks the render state dirty. </para>
		/// </summary>
		public void SetCustomDepthStencilValue(int Value)
			=> E_UPrimitiveComponent_SetCustomDepthStencilValue(this, Value);
		
		
		/// <summary>
		/// <para>Sets the CustomDepth stencil write mask and marks the render state dirty. </para>
		/// </summary>
		public void SetCustomDepthStencilWriteMask(ERendererStencilMask WriteMaskBit)
			=> E_UPrimitiveComponent_SetCustomDepthStencilWriteMask(this, (byte)WriteMaskBit);
		
		
		/// <summary>
		/// <para>Changes the value of DepthPriorityGroup. </para>
		/// <param name="NewDepthPriorityGroup">The value to assign to DepthPriorityGroup. </param>
		/// </summary>
		public void SetDepthPriorityGroup(ESceneDepthPriorityGroup NewDepthPriorityGroup)
			=> E_UPrimitiveComponent_SetDepthPriorityGroup(this, (byte)NewDepthPriorityGroup);
		
		
		/// <summary>
		/// <para>Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true. </para>
		/// </summary>
		public virtual void SetEnableGravity(bool bGravityEnabled)
			=> E_UPrimitiveComponent_SetEnableGravity(this, bGravityEnabled);
		
		
		/// <summary>
		/// <para>Sets the linear damping of this component. </para>
		/// </summary>
		public virtual void SetLinearDamping(float InDamping)
			=> E_UPrimitiveComponent_SetLinearDamping(this, InDamping);
		
		
		/// <summary>
		/// <para>LOD parent primitive to draw instead of this one (multiple UPrim's will point to the same LODParent ) </para>
		/// </summary>
		public void SetLODParentPrimitive(UPrimitiveComponent InLODParentPrimitive)
			=> E_UPrimitiveComponent_SetLODParentPrimitive(this, InLODParentPrimitive);
		
		
		/// <summary>
		/// <para>Override the mass (in Kg) of a single physics body. </para>
		/// <para>Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group. </para>
		/// <para>Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass. </para>
		/// </summary>
		public virtual void SetMassOverrideInKg(string BoneName, float MassInKg, bool bOverrideMass)
			=> E_UPrimitiveComponent_SetMassOverrideInKg(this, BoneName, MassInKg, bOverrideMass);
		
		
		/// <summary>
		/// <para>Change the mass scale used to calculate the mass of a single physics body </para>
		/// </summary>
		public virtual void SetMassScale(string BoneName, float InMassScale)
			=> E_UPrimitiveComponent_SetMassScale(this, BoneName, InMassScale);
		
		
		/// <summary>
		/// <para>Changes the value of bNotifyRigidBodyCollision </para>
		/// <param name="bNewNotifyRigidBodyCollision">The value to assign to bNotifyRigidBodyCollision </param>
		/// </summary>
		public virtual void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
			=> E_UPrimitiveComponent_SetNotifyRigidBodyCollision(this, bNewNotifyRigidBodyCollision);
		
		
		/// <summary>
		/// <para>Changes the value of bOnlyOwnerSee. </para>
		/// </summary>
		public void SetOnlyOwnerSee(bool bNewOnlyOwnerSee)
			=> E_UPrimitiveComponent_SetOnlyOwnerSee(this, bNewOnlyOwnerSee);
		
		
		/// <summary>
		/// <para>Changes the value of bOwnerNoSee. </para>
		/// </summary>
		public void SetOwnerNoSee(bool bNewOwnerNoSee)
			=> E_UPrimitiveComponent_SetOwnerNoSee(this, bNewOwnerNoSee);
		
		
		/// <summary>
		/// <para>Set the angular velocity of a single body. </para>
		/// <para>This should be used cautiously - it may be better to use AddTorque or AddImpulse. </para>
		/// <param name="NewAngVel">New angular velocity to apply to body, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsAngularVelocity(FVector NewAngVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsAngularVelocity(this, NewAngVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Set the angular velocity of a single body. </para>
		/// <para>This should be used cautiously - it may be better to use AddTorque or AddImpulse. </para>
		/// <param name="NewAngVel">New angular velocity to apply to body, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsAngularVelocityInDegrees(FVector NewAngVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsAngularVelocityInDegrees(this, NewAngVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Set the angular velocity of a single body. </para>
		/// <para>This should be used cautiously - it may be better to use AddTorque or AddImpulse. </para>
		/// <param name="NewAngVel">New angular velocity to apply to body, in radians per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify angular velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsAngularVelocityInRadians(this, NewAngVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Set the linear velocity of a single body. </para>
		/// <para>This should be used cautiously - it may be better to use AddForce or AddImpulse. </para>
		/// <param name="NewVel">New linear velocity to apply to physics. </param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsLinearVelocity(this, NewVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Set the maximum angular velocity of a single body. </para>
		/// <param name="NewMaxAngVel">New maximum angular velocity to apply to body, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewMaxAngVel is added to the existing maximum angular velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsMaxAngularVelocity(float NewMaxAngVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsMaxAngularVelocity(this, NewMaxAngVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Set the maximum angular velocity of a single body. </para>
		/// <param name="NewMaxAngVel">New maximum angular velocity to apply to body, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewMaxAngVel is added to the existing maximum angular velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsMaxAngularVelocityInDegrees(float NewMaxAngVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInDegrees(this, NewMaxAngVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Set the maximum angular velocity of a single body. </para>
		/// <param name="NewMaxAngVel">New maximum angular velocity to apply to body, in radians per second. </param>
		/// <param name="bAddToCurrent">If true, NewMaxAngVel is added to the existing maximum angular velocity of the body. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to modify maximum angular velocity of. 'None' indicates root body. </param>
		/// </summary>
		public void SetPhysicsMaxAngularVelocityInRadians(float NewMaxAngVel, bool bAddToCurrent, string BoneName)
			=> E_UPrimitiveComponent_SetPhysicsMaxAngularVelocityInRadians(this, NewMaxAngVel, bAddToCurrent, BoneName);
		
		
		/// <summary>
		/// <para>Controls if we get a post physics tick or not. If set during ticking, will take effect next frame </para>
		/// </summary>
		public void SetPostPhysicsComponentTickEnabled(bool bEnable)
			=> E_UPrimitiveComponent_SetPostPhysicsComponentTickEnabled(this, bEnable);
		
		
		/// <summary>
		/// <para>Changes the value of bReceivesDecals. </para>
		/// </summary>
		public void SetReceivesDecals(bool bNewReceivesDecals)
			=> E_UPrimitiveComponent_SetReceivesDecals(this, bNewReceivesDecals);
		
		
		/// <summary>
		/// <para>Sets the bRenderCustomDepth property and marks the render state dirty. </para>
		/// </summary>
		public void SetRenderCustomDepth(bool bValue)
			=> E_UPrimitiveComponent_SetRenderCustomDepth(this, bValue);
		
		
		/// <summary>
		/// <para>Sets bRenderInMainPass property and marks the render state dirty. </para>
		/// </summary>
		public void SetRenderInMainPass(bool bValue)
			=> E_UPrimitiveComponent_SetRenderInMainPass(this, bValue);
		
		
		/// <summary>
		/// <para>Sets bRenderInMono property and marks the render state dirty. </para>
		/// </summary>
		public void SetRenderInMono(bool bValue)
			=> E_UPrimitiveComponent_SetRenderInMono(this, bValue);
		
		
		/// <summary>
		/// <para>Sets whether or not a single body should use physics simulation, or should be 'fixed' (kinematic). </para>
		/// <para>Note that if this component is currently attached to something, beginning simulation will detach it. </para>
		/// <param name="bSimulate">New simulation state for single body </param>
		/// </summary>
		public virtual void SetSimulatePhysics(bool bSimulate)
			=> E_UPrimitiveComponent_SetSimulatePhysics(this, bSimulate);
		
		
		/// <summary>
		/// <para>Changes the value of bSingleSampleShadowFromStationaryLights. </para>
		/// </summary>
		public void SetSingleSampleShadowFromStationaryLights(bool bNewSingleSampleShadowFromStationaryLights)
			=> E_UPrimitiveComponent_SetSingleSampleShadowFromStationaryLights(this, bNewSingleSampleShadowFromStationaryLights);
		
		
		/// <summary>
		/// <para>Changes the value of TranslucentSortPriority. </para>
		/// </summary>
		public void SetTranslucentSortPriority(int NewTranslucentSortPriority)
			=> E_UPrimitiveComponent_SetTranslucentSortPriority(this, NewTranslucentSortPriority);
		
		
		/// <summary>
		/// <para>Set whether this component should use Continuous Collision Detection </para>
		/// </summary>
		public virtual void SetUseCCD(bool InUseCCD, string BoneName)
			=> E_UPrimitiveComponent_SetUseCCD(this, InUseCCD, BoneName);
		
		
		/// <summary>
		/// <para>Changes the value of bUseViewOwnerDepthPriorityGroup and ViewOwnerDepthPriorityGroup. </para>
		/// <param name="bNewUseViewOwnerDepthPriorityGroup">The value to assign to bUseViewOwnerDepthPriorityGroup. </param>
		/// <param name="NewViewOwnerDepthPriorityGroup">The value to assign to ViewOwnerDepthPriorityGroup. </param>
		/// </summary>
		public void SetViewOwnerDepthPriorityGroup(bool bNewUseViewOwnerDepthPriorityGroup, ESceneDepthPriorityGroup NewViewOwnerDepthPriorityGroup)
			=> E_UPrimitiveComponent_SetViewOwnerDepthPriorityGroup(this, bNewUseViewOwnerDepthPriorityGroup, (byte)NewViewOwnerDepthPriorityGroup);
		
		
		/// <summary>
		/// <para>Sets a new slope override for this component instance. </para>
		/// </summary>
		public void SetWalkableSlopeOverride(FWalkableSlopeOverride NewOverride)
			=> E_UPrimitiveComponent_SetWalkableSlopeOverride(this, NewOverride);
		
		
		/// <summary>
		/// <para>Looking at various values of the component, determines if this </para>
		/// <para>component should be added to the scene </para>
		/// <return>true if the component is visible and should be added to the scene, false otherwise </return>
		/// </summary>
		public bool ShouldComponentAddToScene()
			=> E_UPrimitiveComponent_ShouldComponentAddToScene(this);
		
		
		/// <summary>
		/// <para>Determines whether the proxy for this primitive type needs to be recreated whenever the primitive moves. </para>
		/// <return>true to recreate the proxy when UpdateTransform is called. </return>
		/// </summary>
		public virtual bool ShouldRecreateProxyOnUpdateTransform()
			=> E_UPrimitiveComponent_ShouldRecreateProxyOnUpdateTransform(this);
		
		
		/// <summary>
		/// <return>true if the owner is selected and this component is selectable </return>
		/// </summary>
		public virtual bool ShouldRenderSelected()
			=> E_UPrimitiveComponent_ShouldRenderSelected(this);
		
		
		/// <summary>
		/// <para>Whether the component type supports static lighting. </para>
		/// </summary>
		protected virtual bool SupportsStaticLighting()
			=> E_UPrimitiveComponent_SupportsStaticLighting(this);
		
		
		/// <summary>
		/// <para>Move this component to match the physics rigid body pose. Note, a warning will be generated if you call this function on a component that is attached to something </para>
		/// </summary>
		public void SyncComponentToRBPhysics()
			=> E_UPrimitiveComponent_SyncComponentToRBPhysics(this);
		
		
		/// <summary>
		/// <para>Unwelds the children of this component. Attachment is maintained </para>
		/// </summary>
		public virtual void UnWeldChildren()
			=> E_UPrimitiveComponent_UnWeldChildren(this);
		
		
		/// <summary>
		/// <para>UnWelds this component from its parent component. Attachment is maintained (DetachFromParent automatically unwelds) </para>
		/// </summary>
		public virtual void UnWeldFromParent()
			=> E_UPrimitiveComponent_UnWeldFromParent(this);
		
		
		/// <summary>
		/// <para>Internal function that updates physics objects to match the component collision settings. </para>
		/// </summary>
		protected virtual void UpdatePhysicsToRBChannels()
			=> E_UPrimitiveComponent_UpdatePhysicsToRBChannels(this);
		
		
		/// <summary>
		/// <return>true if only unlit materials are used for rendering, false otherwise. </return>
		/// </summary>
		public virtual bool UsesOnlyUnlitMaterials()
			=> E_UPrimitiveComponent_UsesOnlyUnlitMaterials(this);
		
		
		/// <summary>
		/// <para>Ensure simulation is running for all bodies in this component. </para>
		/// </summary>
		public virtual void WakeAllRigidBodies()
			=> E_UPrimitiveComponent_WakeAllRigidBodies(this);
		
		
		/// <summary>
		/// <para>'Wake' physics simulation for a single body. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body. </param>
		/// </summary>
		public virtual void WakeRigidBody(string BoneName)
			=> E_UPrimitiveComponent_WakeRigidBody(this, BoneName);
		
		
		/// <summary>
		/// <para>Welds this component to another scene component, optionally at a named socket. Component is automatically attached if not already </para>
		/// <para>Welding allows the child physics object to become physically connected to its parent. This is useful for creating compound rigid bodies with correct mass distribution. </para>
		/// <param name="InParent">the component to be physically attached to </param>
		/// <param name="InSocketName">optional socket to attach component to </param>
		/// </summary>
		public virtual void WeldTo(USceneComponent InParent, string InSocketName)
			=> E_UPrimitiveComponent_WeldTo(this, InParent, InSocketName);
		
		
		/// <summary>
		/// <para>Does the actual work for welding. </para>
		/// <return>true if did a true weld of shapes, meaning body initialization is not needed </return>
		/// </summary>
		public virtual bool WeldToImplementation(USceneComponent InParent, string ParentSocketName, bool bWeldSimulatedChild)
			=> E_UPrimitiveComponent_WeldToImplementation(this, InParent, ParentSocketName, bWeldSimulatedChild);
		
		#endregion
		
		public static implicit operator IntPtr(UPrimitiveComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPrimitiveComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPrimitiveComponent>(PtrDesc);
		}}}
