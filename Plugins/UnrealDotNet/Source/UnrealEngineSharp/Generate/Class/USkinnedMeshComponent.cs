// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:182

namespace UnrealEngine
{
	public  partial class USkinnedMeshComponent : UMeshComponent
	{
		public USkinnedMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USkinnedMeshComponent(UObject Parent = null, string Name = "SkinnedMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USkinnedMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USkinnedMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_USkinnedMeshComponent_ActiveMorphTargets_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_ActiveMorphTargets_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bCanHighlightSelectedSections_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bCanHighlightSelectedSections_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bCastCapsuleDirectShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bCastCapsuleDirectShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bCastCapsuleIndirectShadow_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bCastCapsuleIndirectShadow_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bComponentUseFixedSkelBounds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bComponentUseFixedSkelBounds_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bConsiderAllBodiesForBounds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bConsiderAllBodiesForBounds_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bCPUSkinning_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bCPUSkinning_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bDisableMorphTarget_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bDisableMorphTarget_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bDisplayBones_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bDisplayBones_DEPRECATED_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bDisplayDebugUpdateRateOptimizations_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bDisplayDebugUpdateRateOptimizations_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bEnableUpdateRateOptimizations_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bEnableUpdateRateOptimizations_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bForceWireframe_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bForceWireframe_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bHideSkin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bHideSkin_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_USkinnedMeshComponent_BoneVisibilityStates_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_BoneVisibilityStates_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_USkinnedMeshComponent_bOverrideMinLod_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bOverrideMinLod_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bPerBoneMotionBlur_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bPerBoneMotionBlur_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bRecentlyRendered_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bRecentlyRendered_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bRenderStatic_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bRenderStatic_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_bUseBoundsFromMasterPoseComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_bUseBoundsFromMasterPoseComponent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkinnedMeshComponent_ForcedLodModel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_ForcedLodModel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_USkinnedMeshComponent_LODInfo_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_LODInfo_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkinnedMeshComponent_MaxDistanceFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_MaxDistanceFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkinnedMeshComponent_MinLodModel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_MinLodModel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_USkinnedMeshComponent_MorphTargetWeights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_MorphTargetWeights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkinnedMeshComponent_PredictedLODLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_PredictedLODLevel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_ClearRefPoseOverride(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_ClearSkinWeightOverride(IntPtr self, int lODIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_ClearVertexColorOverride(IntPtr self, int lODIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USkinnedMeshComponent_GetBoneIndex(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USkinnedMeshComponent_GetBoneName(IntPtr self, int boneIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_USkinnedMeshComponent_GetMasterBoneMap(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USkinnedMeshComponent_GetNumBones(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USkinnedMeshComponent_GetNumLODs(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USkinnedMeshComponent_GetParentBone(IntPtr self, string boneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkinnedMeshComponent_GetRefPoseOverride(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USkinnedMeshComponent_GetSocketBoneName(IntPtr self, string inSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetCapsuleIndirectShadowMinVisibility(IntPtr self, float newValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetCastCapsuleDirectShadow(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetCastCapsuleIndirectShadow(IntPtr self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetForcedLOD(IntPtr self, int inNewForcedLOD);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetForceWireframe(IntPtr self, bool inForceWireframe);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetMinLOD(IntPtr self, int inNewMinLOD);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetRefPoseOverride(IntPtr self, IntPtr newRefPoseTransforms);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkinnedMeshComponent_ShouldCPUSkin(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Array indicating all active morph targets. This array is updated inside RefreshBoneTransforms based on the Anim Blueprint. </para>
		/// </summary>
		public TArray<FActiveMorphTarget> ActiveMorphTargets
		{
			get => E_PROP_USkinnedMeshComponent_ActiveMorphTargets_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_ActiveMorphTargets_SET(NativePointer, value);
		}

		public byte bCanHighlightSelectedSections
		{
			get => E_PROP_USkinnedMeshComponent_bCanHighlightSelectedSections_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bCanHighlightSelectedSections_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to use the capsule representation (when present) from a skeletal mesh's ShadowPhysicsAsset for direct shadowing from lights. </para>
		/// <para>This type of shadowing is approximate but handles extremely wide area shadowing well.  The softness of the shadow depends on the light's LightSourceAngle / SourceRadius. </para>
		/// <para>This flag will force bCastInsetShadow to be enabled. </para>
		/// </summary>
		public byte CapsuleDirectShadow
		{
			get => E_PROP_USkinnedMeshComponent_bCastCapsuleDirectShadow_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bCastCapsuleDirectShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to use the capsule representation (when present) from a skeletal mesh's ShadowPhysicsAsset for shadowing indirect lighting (from lightmaps or skylight). </para>
		/// </summary>
		public byte CapsuleIndirectShadow
		{
			get => E_PROP_USkinnedMeshComponent_bCastCapsuleIndirectShadow_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bCastCapsuleIndirectShadow_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When true, skip using the physics asset etc. and always use the fixed bounds defined in the SkeletalMesh. </para>
		/// </summary>
		public byte bComponentUseFixedSkelBounds
		{
			get => E_PROP_USkinnedMeshComponent_bComponentUseFixedSkelBounds_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bComponentUseFixedSkelBounds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, when updating bounds from a PhysicsAsset, consider _all_ BodySetups, not just those flagged with bConsiderForBounds. </para>
		/// </summary>
		public byte bConsiderAllBodiesForBounds
		{
			get => E_PROP_USkinnedMeshComponent_bConsiderAllBodiesForBounds_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bConsiderAllBodiesForBounds_SET(NativePointer, value);
		}

		public byte bCPUSkinning
		{
			get => E_PROP_USkinnedMeshComponent_bCPUSkinning_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bCPUSkinning_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Disable Morphtarget for this component. </para>
		/// </summary>
		public byte bDisableMorphTarget
		{
			get => E_PROP_USkinnedMeshComponent_bDisableMorphTarget_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bDisableMorphTarget_SET(NativePointer, value);
		}

		public byte bDisplayBones_DEPRECATED
		{
			get => E_PROP_USkinnedMeshComponent_bDisplayBones_DEPRECATED_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bDisplayBones_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Enable on screen debugging of update rate optimization. </para>
		/// <para>Red = Skipping 0 frames, Green = skipping 1 frame, Blue = skipping 2 frames, black = skipping more than 2 frames. </para>
		/// <para>@todo: turn this into a console command. </para>
		/// </summary>
		public byte bDisplayDebugUpdateRateOptimizations
		{
			get => E_PROP_USkinnedMeshComponent_bDisplayDebugUpdateRateOptimizations_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bDisplayDebugUpdateRateOptimizations_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>if TRUE, Owner will determine how often animation will be updated and evaluated. See AnimUpdateRateTick() </para>
		/// <para>This allows to skip frames for performance. (For example based on visibility and size on screen). </para>
		/// </summary>
		public byte bEnableUpdateRateOptimizations
		{
			get => E_PROP_USkinnedMeshComponent_bEnableUpdateRateOptimizations_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bEnableUpdateRateOptimizations_SET(NativePointer, value);
		}

		public byte bForceWireframe
		{
			get => E_PROP_USkinnedMeshComponent_bForceWireframe_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bForceWireframe_SET(NativePointer, value);
		}

		public byte bHideSkin
		{
			get => E_PROP_USkinnedMeshComponent_bHideSkin_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bHideSkin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Array of bone visibilities (containing one of the values in EBoneVisibilityStatus for each bone).  A bone is only visible if it is *exactly* 1 (BVS_Visible) </para>
		/// </summary>
		public TArray<byte> BoneVisibilityStates
		{
			get => E_PROP_USkinnedMeshComponent_BoneVisibilityStates_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_BoneVisibilityStates_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether we should use the min lod specified in MinLodModel for this component instead of the min lod in the mesh </para>
		/// </summary>
		public bool bOverrideMinLod
		{
			get => E_PROP_USkinnedMeshComponent_bOverrideMinLod_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bOverrideMinLod_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, use per-bone motion blur on this skeletal mesh (requires additional rendering, can be disabled to save performance). </para>
		/// </summary>
		public byte bPerBoneMotionBlur
		{
			get => E_PROP_USkinnedMeshComponent_bPerBoneMotionBlur_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bPerBoneMotionBlur_SET(NativePointer, value);
		}

		public byte bRecentlyRendered
		{
			get => E_PROP_USkinnedMeshComponent_bRecentlyRendered_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bRecentlyRendered_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, render as static in reference pose. </para>
		/// </summary>
		public byte bRenderStatic
		{
			get => E_PROP_USkinnedMeshComponent_bRenderStatic_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bRenderStatic_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When true, we will just using the bounds from our MasterPoseComponent.  This is useful for when we have a Mesh Parented </para>
		/// <para>to the main SkelMesh (e.g. outline mesh or a full body overdraw effect that is toggled) that is always going to be the same </para>
		/// <para>bounds as parent.  We want to do no calculations in that case. </para>
		/// </summary>
		public byte bUseBoundsFromMasterPoseComponent
		{
			get => E_PROP_USkinnedMeshComponent_bUseBoundsFromMasterPoseComponent_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_bUseBoundsFromMasterPoseComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls how dark the capsule indirect shadow can be. </para>
		/// </summary>
		public float CapsuleIndirectShadowMinVisibility
		{
			get => E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_CapsuleIndirectShadowMinVisibility_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If 0, auto-select LOD level. if >0, force to (ForcedLodModel-1). </para>
		/// </summary>
		public int ForcedLodModel
		{
			get => E_PROP_USkinnedMeshComponent_ForcedLodModel_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_ForcedLodModel_SET(NativePointer, value);
		}

		public TArray<FSkelMeshComponentLODInfo> LODInfo
		{
			get => E_PROP_USkinnedMeshComponent_LODInfo_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_LODInfo_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>High (best) DistanceFactor that was desired for rendering this USkeletalMesh last frame. Represents how big this mesh was in screen space </para>
		/// </summary>
		public float MaxDistanceFactor
		{
			get => E_PROP_USkinnedMeshComponent_MaxDistanceFactor_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_MaxDistanceFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>This is the min LOD that this component will use.  (e.g. if set to 2 then only 2+ LOD Models will be used.) This is useful to set on </para>
		/// <para>meshes which are known to be a certain distance away and still want to have better LODs when zoomed in on them. </para>
		/// </summary>
		public int MinLodModel
		{
			get => E_PROP_USkinnedMeshComponent_MinLodModel_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_MinLodModel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Array of weights for all morph targets. This array is updated inside RefreshBoneTransforms based on the Anim Blueprint. </para>
		/// </summary>
		public TArray<float> MorphTargetWeights
		{
			get => E_PROP_USkinnedMeshComponent_MorphTargetWeights_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_MorphTargetWeights_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>LOD level from previous frame, so we can detect changes in LOD to recalc required bones. </para>
		/// </summary>
		public int OldPredictedLODLevel
		{
			get => E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_OldPredictedLODLevel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Best LOD that was 'predicted' by UpdateSkelPose. </para>
		/// <para>This is what bones were updated based on, so we do not allow rendering at a better LOD than this. </para>
		/// </summary>
		public int PredictedLODLevel
		{
			get => E_PROP_USkinnedMeshComponent_PredictedLODLevel_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_PredictedLODLevel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Allows adjusting the desired streaming distance of streaming textures that uses UV 0. </para>
		/// <para>1.0 is the default, whereas a higher value makes the textures stream in sooner from far away. </para>
		/// <para>A lower value (0.0-1.0) makes the textures stream in later (you have to be closer). </para>
		/// <para>Value can be < 0 (from legcay content, or code changes) </para>
		/// </summary>
		public float StreamingDistanceMultiplier
		{
			get => E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Clear any applied ref pose override </para>
		/// </summary>
		public virtual void ClearRefPoseOverride()
			=> E_USkinnedMeshComponent_ClearRefPoseOverride(this);
		
		
		/// <summary>
		/// <para>Clear any applied skin weight override </para>
		/// </summary>
		public void ClearSkinWeightOverride(int lODIndex)
			=> E_USkinnedMeshComponent_ClearSkinWeightOverride(this, lODIndex);
		
		
		/// <summary>
		/// <para>Clear any applied vertex color override </para>
		/// </summary>
		public void ClearVertexColorOverride(int lODIndex)
			=> E_USkinnedMeshComponent_ClearVertexColorOverride(this, lODIndex);
		
		
		/// <summary>
		/// <para>Find the index of bone by name. Looks in the current SkeletalMesh being used by this SkeletalMeshComponent. </para>
		/// <param name="BoneName">Name of bone to look up </param>
		/// <return>Index of the named bone in the current SkeletalMesh. Will return INDEX_NONE if bone not found. </return>
		/// <para>@see USkeletalMesh::GetBoneIndex. </para>
		/// </summary>
		public int GetBoneIndex(string boneName)
			=> E_USkinnedMeshComponent_GetBoneIndex(this, boneName);
		
		
		/// <summary>
		/// <para>Get Bone Name from index </para>
		/// <param name="BoneIndex">Index of the bone </param>
		/// <return>the name of the bone at the specified index </return>
		/// </summary>
		public string GetBoneName(int boneIndex)
			=> E_USkinnedMeshComponent_GetBoneName(this, boneIndex);
		
		public TArray<int> GetMasterBoneMap()
			=> E_USkinnedMeshComponent_GetMasterBoneMap(this);
		
		
		/// <summary>
		/// <para>Returns the number of bones in the skeleton. </para>
		/// </summary>
		public int GetNumBones()
			=> E_USkinnedMeshComponent_GetNumBones(this);
		
		
		/// <summary>
		/// <para>Get the number of LODs on this component </para>
		/// </summary>
		public int GetNumLODs()
			=> E_USkinnedMeshComponent_GetNumLODs(this);
		
		
		/// <summary>
		/// <para>Get Parent Bone of the input bone </para>
		/// <param name="BoneName">Name of the bone </param>
		/// <return>the name of the parent bone for the specified bone. Returns 'None' if the bone does not exist or it is the root bone </return>
		/// </summary>
		public string GetParentBone(string boneName)
			=> E_USkinnedMeshComponent_GetParentBone(this, boneName);
		
		
		/// <summary>
		/// <para>Accessor for RefPoseOverride </para>
		/// </summary>
		public virtual FSkelMeshRefPoseOverride GetRefPoseOverride()
			=> E_USkinnedMeshComponent_GetRefPoseOverride(this);
		
		
		/// <summary>
		/// <para>Returns bone name linked to a given named socket on the skeletal mesh component. </para>
		/// <para>If you're unsure to deal with sockets or bones names, you can use this function to filter through, and always return the bone name. </para>
		/// <param name="bone">name or socket name </param>
		/// <return>bone name </return>
		/// </summary>
		public string GetSocketBoneName(string inSocketName)
			=> E_USkinnedMeshComponent_GetSocketBoneName(this, inSocketName);
		
		public void SetCapsuleIndirectShadowMinVisibility(float newValue)
			=> E_USkinnedMeshComponent_SetCapsuleIndirectShadowMinVisibility(this, newValue);
		
		
		/// <summary>
		/// <para>Get the LOD Bias of this component </para>
		/// <return>The LOD bias of this component. Derived classes can override this to ignore or override LOD bias settings. </return>
		/// </summary>
		public void SetCastCapsuleDirectShadow(bool bNewValue)
			=> E_USkinnedMeshComponent_SetCastCapsuleDirectShadow(this, bNewValue);
		
		public void SetCastCapsuleIndirectShadow(bool bNewValue)
			=> E_USkinnedMeshComponent_SetCastCapsuleIndirectShadow(this, bNewValue);
		
		
		/// <summary>
		/// <para>Set MinLodModel of the mesh component </para>
		/// <param name="InNewForcedLOD">Set new ForcedLODModel that forces to set the incoming LOD. Range from [1, Max Number of LOD]. This will affect in the next tick update. </param>
		/// </summary>
		public void SetForcedLOD(int inNewForcedLOD)
			=> E_USkinnedMeshComponent_SetForcedLOD(this, inNewForcedLOD);
		
		
		/// <summary>
		/// <para>Sets the value of the bForceWireframe flag and reattaches the component as necessary. </para>
		/// <param name="InForceWireframe">New value of bForceWireframe. </param>
		/// </summary>
		public void SetForceWireframe(bool inForceWireframe)
			=> E_USkinnedMeshComponent_SetForceWireframe(this, inForceWireframe);
		
		
		/// <summary>
		/// <para>Set MinLodModel of the mesh component </para>
		/// <param name="InNewMinLOD">Set new MinLodModel that make sure the LOD does not go below of this value. Range from [0, Max Number of LOD - 1]. This will affect in the next tick update. </param>
		/// </summary>
		public void SetMinLOD(int inNewMinLOD)
			=> E_USkinnedMeshComponent_SetMinLOD(this, inNewMinLOD);
		
		
		/// <summary>
		/// <para>Apply an override for the current mesh ref pose </para>
		/// </summary>
		public virtual void SetRefPoseOverride(TArray<FTransform> newRefPoseTransforms)
			=> E_USkinnedMeshComponent_SetRefPoseOverride(this, newRefPoseTransforms);
		
		
		/// <summary>
		/// <para>Function returns whether or not CPU skinning should be applied </para>
		/// <para>Allows the editor to override the skinning state for editor tools </para>
		/// <return>true if should CPU skin. false otherwise </return>
		/// </summary>
		public virtual bool ShouldCPUSkin()
			=> E_USkinnedMeshComponent_ShouldCPUSkin(this);
		
		#endregion
		
		public static implicit operator IntPtr(USkinnedMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USkinnedMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkinnedMeshComponent>(PtrDesc);
		}}}
