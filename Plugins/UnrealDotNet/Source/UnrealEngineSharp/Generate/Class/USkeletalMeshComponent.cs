// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:279

namespace UnrealEngine
{
	public  partial class USkeletalMeshComponent : USkinnedMeshComponent
	{
		public USkeletalMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USkeletalMeshComponent(UObject Parent = null, string Name = "SkeletalMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USkeletalMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_AreaStiffness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_AreaStiffness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bAnimTreeInitialised_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bAnimTreeInitialised_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bBlendPhysics_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bBlendPhysics_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bDeferKinematicBoneUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bDeferKinematicBoneUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bDeferredKinematicUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bDeferredKinematicUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bDisableClothSimulation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bDisableClothSimulation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bEnableLineCheckWithBounds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bEnableLineCheckWithBounds_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bEnablePerPolyCollision_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bEnablePerPolyCollision_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bEnablePhysicsOnDedicatedServer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bEnablePhysicsOnDedicatedServer_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_BendingStiffness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_BendingStiffness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bForceRefpose_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bForceRefpose_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bHasValidBodies_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bHasValidBodies_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bIncludeComponentLocationIntoBounds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bIncludeComponentLocationIntoBounds_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bIsAutonomousTickPose_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bIsAutonomousTickPose_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bLocalSpaceSimulation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bLocalSpaceSimulation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bNoSkeletonUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bNoSkeletonUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bOldForceRefPose_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bOldForceRefPose_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_USkeletalMeshComponent_BoneSpaceTransforms_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_BoneSpaceTransforms_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bOnlyAllowAutonomousTickPose_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bOnlyAllowAutonomousTickPose_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bPauseAnims_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bPauseAnims_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bPrevDisableClothSimulation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bPrevDisableClothSimulation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bPropagateCurvesToSlaves_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bPropagateCurvesToSlaves_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bRequiredBonesUpToDate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bRequiredBonesUpToDate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bResetAfterTeleport_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bResetAfterTeleport_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bShowPrePhysBones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bShowPrePhysBones_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bSimulationUpdatesChildTransforms_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bSimulationUpdatesChildTransforms_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bSkipBoundsUpdateWhenInterpolating_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bSkipBoundsUpdateWhenInterpolating_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bSkipKinematicUpdateWhenInterpolating_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bSkipKinematicUpdateWhenInterpolating_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bUpdateOverlapsOnAnimationFinalize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUpdateOverlapsOnAnimationFinalize_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bUseBendingElements_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUseBendingElements_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bUseContinuousCollisionDetection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUseContinuousCollisionDetection_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bUseSelfCollisions_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUseSelfCollisions_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bUseTetrahedralConstraints_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUseTetrahedralConstraints_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bUseThinShellVolumeConstraints_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUseThinShellVolumeConstraints_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_ClothBlendWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_ClothBlendWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_EdgeStiffness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_EdgeStiffness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USkeletalMeshComponent_RootBoneTranslation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_RootBoneTranslation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_ShapeTargetStiffness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_ShapeTargetStiffness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_StrainLimitingStiffness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_StrainLimitingStiffness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_VolumeStiffness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_VolumeStiffness_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USkeletalMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ClearMorphTargets(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_CreateBodySetup(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_USkeletalMeshComponent_GetCachedComponentSpaceTransforms(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_GetDisablePostProcessBlueprint(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetMorphTarget(IntPtr self, string morphTargetName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetPlayRate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetPosition(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_HasValidAnimationInstance(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsPlaying(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Play(IntPtr self, bool bLooping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ResetAnimInstanceDynamics(IntPtr self, byte inTeleportType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetDisablePostProcessBlueprint(IntPtr self, bool bInDisablePostProcess);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetMorphTarget(IntPtr self, string morphTargetName, float value, bool bRemoveZeroWeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetPlayRate(IntPtr self, float rate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetPosition(IntPtr self, float inPos, bool bFireNotifies);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Stop(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ToggleDisablePostProcessBlueprint(IntPtr self);
		
		#endregion
		
		#region Property
		public float AreaStiffness
		{
			get => E_PROP_USkeletalMeshComponent_AreaStiffness_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_AreaStiffness_SET(NativePointer, value);
		}

		public byte bAnimTreeInitialised
		{
			get => E_PROP_USkeletalMeshComponent_bAnimTreeInitialised_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bAnimTreeInitialised_SET(NativePointer, value);
		}

		public byte bBlendPhysics
		{
			get => E_PROP_USkeletalMeshComponent_bBlendPhysics_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bBlendPhysics_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>can't collide with part of attached children if total collision volumes exceed 16 capsules or 32 planes per convex </para>
		/// </summary>
		public byte bCollideWithAttachedChildren
		{
			get => E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>can't collide with part of environment if total collision volumes exceed 16 capsules or 32 planes per convex </para>
		/// </summary>
		public byte bCollideWithEnvironment
		{
			get => E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether animation and world transform updates are deferred. If this is on, the kinematic bodies (scene query data) will not update until the next time the physics simulation is run </para>
		/// </summary>
		public byte bDeferKinematicBoneUpdate
		{
			get => E_PROP_USkeletalMeshComponent_bDeferKinematicBoneUpdate_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bDeferKinematicBoneUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Indicates that this SkeletalMeshComponent has deferred kinematic bone updates until next physics sim. </para>
		/// </summary>
		public byte bDeferredKinematicUpdate
		{
			get => E_PROP_USkeletalMeshComponent_bDeferredKinematicUpdate_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bDeferredKinematicUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Disable cloth simulation and play original animation without simulation </para>
		/// </summary>
		public byte bDisableClothSimulation
		{
			get => E_PROP_USkeletalMeshComponent_bDisableClothSimulation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bDisableClothSimulation_SET(NativePointer, value);
		}

		public byte bEnableLineCheckWithBounds
		{
			get => E_PROP_USkeletalMeshComponent_bEnableLineCheckWithBounds_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bEnableLineCheckWithBounds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Uses skinned data for collision data. </para>
		/// </summary>
		public byte bEnablePerPolyCollision
		{
			get => E_PROP_USkeletalMeshComponent_bEnablePerPolyCollision_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bEnablePerPolyCollision_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, simulate physics for this component on a dedicated server. </para>
		/// <para>This should be set if simulating physics and replicating with a dedicated server. </para>
		/// <para>Note: This property cannot be changed at runtime. </para>
		/// </summary>
		public byte bEnablePhysicsOnDedicatedServer
		{
			get => E_PROP_USkeletalMeshComponent_bEnablePhysicsOnDedicatedServer_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bEnablePhysicsOnDedicatedServer_SET(NativePointer, value);
		}

		public float BendingStiffness
		{
			get => E_PROP_USkeletalMeshComponent_BendingStiffness_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_BendingStiffness_SET(NativePointer, value);
		}

		public byte bForceRefpose
		{
			get => E_PROP_USkeletalMeshComponent_bForceRefpose_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bForceRefpose_SET(NativePointer, value);
		}

		public byte bHasValidBodies
		{
			get => E_PROP_USkeletalMeshComponent_bHasValidBodies_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bHasValidBodies_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, the Location of this Component will be included into its bounds calculation </para>
		/// <para>(this can be useful when using SMU_OnlyTickPoseWhenRendered on a character that moves away from the root and no bones are left near the origin of the component) </para>
		/// </summary>
		public byte bIncludeComponentLocationIntoBounds
		{
			get => E_PROP_USkeletalMeshComponent_bIncludeComponentLocationIntoBounds_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bIncludeComponentLocationIntoBounds_SET(NativePointer, value);
		}

		public byte bIsAutonomousTickPose
		{
			get => E_PROP_USkeletalMeshComponent_bIsAutonomousTickPose_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bIsAutonomousTickPose_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Temporary fix for local space kinematics. This only works for bodies that have no constraints and is needed by vehicles. Proper support will remove this flag </para>
		/// </summary>
		public byte bLocalSpaceKinematics
		{
			get => E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>It's worth trying this option when you feel that the current cloth simulation is unstable. </para>
		/// <para>The scale of the actor is maintained during the simulation. </para>
		/// <para>It is possible to add the inertia effects to the simulation, through the inertiaScale parameter of the clothing material. </para>
		/// <para>So with an inertiaScale of 1.0 there should be no visible difference between local space and global space simulation. </para>
		/// <para>Known issues: - Currently there's simulation issues when this feature is used in 3.x (DE4076) So if localSpaceSim is enabled there's no inertia effect when the global pose of the clothing actor changes. </para>
		/// </summary>
		public byte bLocalSpaceSimulation
		{
			get => E_PROP_USkeletalMeshComponent_bLocalSpaceSimulation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bLocalSpaceSimulation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Skips Ticking and Bone Refresh. </para>
		/// </summary>
		public byte bNoSkeletonUpdate
		{
			get => E_PROP_USkeletalMeshComponent_bNoSkeletonUpdate_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bNoSkeletonUpdate_SET(NativePointer, value);
		}

		public byte bOldForceRefPose
		{
			get => E_PROP_USkeletalMeshComponent_bOldForceRefPose_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bOldForceRefPose_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Temporary array of local-space (relative to parent bone) rotation/translation for each bone. </para>
		/// </summary>
		public TArray<FTransform> BoneSpaceTransforms
		{
			get => E_PROP_USkeletalMeshComponent_BoneSpaceTransforms_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_BoneSpaceTransforms_SET(NativePointer, value);
		}

		public byte bOnlyAllowAutonomousTickPose
		{
			get => E_PROP_USkeletalMeshComponent_bOnlyAllowAutonomousTickPose_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bOnlyAllowAutonomousTickPose_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>pauses this component's animations (doesn't tick them, but still refreshes bones) </para>
		/// </summary>
		public byte bPauseAnims
		{
			get => E_PROP_USkeletalMeshComponent_bPauseAnims_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bPauseAnims_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>To save previous state </para>
		/// </summary>
		public byte bPrevDisableClothSimulation
		{
			get => E_PROP_USkeletalMeshComponent_bPrevDisableClothSimulation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bPrevDisableClothSimulation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, propagates calls to ApplyAnimationCurvesToComponent for slave components, only needed if slave components do not tick themselves </para>
		/// </summary>
		public byte bPropagateCurvesToSlaves
		{
			get => E_PROP_USkeletalMeshComponent_bPropagateCurvesToSlaves_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bPropagateCurvesToSlaves_SET(NativePointer, value);
		}

		public byte bRequiredBonesUpToDate
		{
			get => E_PROP_USkeletalMeshComponent_bRequiredBonesUpToDate_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bRequiredBonesUpToDate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>reset the clothing after moving the clothing position (called teleport) </para>
		/// </summary>
		public byte bResetAfterTeleport
		{
			get => E_PROP_USkeletalMeshComponent_bResetAfterTeleport_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bResetAfterTeleport_SET(NativePointer, value);
		}

		public byte bShowPrePhysBones
		{
			get => E_PROP_USkeletalMeshComponent_bShowPrePhysBones_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bShowPrePhysBones_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Indicates that simulation (if it's enabled) is entirely responsible for children transforms. This is only ok if you are not animating attachment points relative to the simulation </para>
		/// </summary>
		public byte bSimulationUpdatesChildTransforms
		{
			get => E_PROP_USkeletalMeshComponent_bSimulationUpdatesChildTransforms_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bSimulationUpdatesChildTransforms_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to skip bounds update when interpolating. Bounds are updated to the target interpolation pose only on ticks when they are evaluated. </para>
		/// </summary>
		public byte bSkipBoundsUpdateWhenInterpolating
		{
			get => E_PROP_USkeletalMeshComponent_bSkipBoundsUpdateWhenInterpolating_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bSkipBoundsUpdateWhenInterpolating_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether to skip UpdateKinematicBonesToAnim() when interpolating. Kinematic bones are updated to the target interpolation pose only on ticks when they are evaluated. </para>
		/// </summary>
		public byte bSkipKinematicUpdateWhenInterpolating
		{
			get => E_PROP_USkeletalMeshComponent_bSkipKinematicUpdateWhenInterpolating_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bSkipKinematicUpdateWhenInterpolating_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If we should pass joint position to joints each frame, so that they can be used by motorized joints to drive the </para>
		/// <para>ragdoll based on the animation. </para>
		/// </summary>
		public byte bUpdateJointsFromAnimation
		{
			get => E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls whether blending in physics bones will refresh overlaps on this component, defaults to true but can be disabled in cases where we know anim->physics blending doesn't meaningfully change overlaps </para>
		/// </summary>
		public byte bUpdateOverlapsOnAnimationFinalize
		{
			get => E_PROP_USkeletalMeshComponent_bUpdateOverlapsOnAnimationFinalize_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUpdateOverlapsOnAnimationFinalize_SET(NativePointer, value);
		}

		public byte bUseBendingElements
		{
			get => E_PROP_USkeletalMeshComponent_bUseBendingElements_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUseBendingElements_SET(NativePointer, value);
		}

		public byte bUseContinuousCollisionDetection
		{
			get => E_PROP_USkeletalMeshComponent_bUseContinuousCollisionDetection_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUseContinuousCollisionDetection_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>On InitAnim should we set to ref pose (if false use first tick of animation data) </para>
		/// </summary>
		public byte bUseRefPoseOnInitAnim
		{
			get => E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_SET(NativePointer, value);
		}

		public byte bUseSelfCollisions
		{
			get => E_PROP_USkeletalMeshComponent_bUseSelfCollisions_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUseSelfCollisions_SET(NativePointer, value);
		}

		public byte bUseTetrahedralConstraints
		{
			get => E_PROP_USkeletalMeshComponent_bUseTetrahedralConstraints_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUseTetrahedralConstraints_SET(NativePointer, value);
		}

		public byte bUseThinShellVolumeConstraints
		{
			get => E_PROP_USkeletalMeshComponent_bUseThinShellVolumeConstraints_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUseThinShellVolumeConstraints_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>weight to blend between simulated results and key-framed positions </para>
		/// <para>if weight is 1.0, shows only cloth simulation results and 0.0 will show only skinned results </para>
		/// </summary>
		public float ClothBlendWeight
		{
			get => E_PROP_USkeletalMeshComponent_ClothBlendWeight_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_ClothBlendWeight_SET(NativePointer, value);
		}

		public float ClothMaxDistanceScale
		{
			get => E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_SET(NativePointer, value);
		}

		public float EdgeStiffness
		{
			get => E_PROP_USkeletalMeshComponent_EdgeStiffness_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_EdgeStiffness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Used to scale speed of all animations on this skeletal mesh. </para>
		/// </summary>
		public float GlobalAnimRateScale
		{
			get => E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_SET(NativePointer, value);
		}

		public FVector LineCheckBoundsScale
		{
			get => E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Threshold for physics asset bodies above which we use an aggregate for broadphase collisions </para>
		/// </summary>
		public int RagdollAggregateThreshold
		{
			get => E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_SET(NativePointer, value);
		}

		public FVector RootBoneTranslation
		{
			get => E_PROP_USkeletalMeshComponent_RootBoneTranslation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_RootBoneTranslation_SET(NativePointer, value);
		}

		public float ShapeTargetStiffness
		{
			get => E_PROP_USkeletalMeshComponent_ShapeTargetStiffness_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_ShapeTargetStiffness_SET(NativePointer, value);
		}

		public float StrainLimitingStiffness
		{
			get => E_PROP_USkeletalMeshComponent_StrainLimitingStiffness_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_StrainLimitingStiffness_SET(NativePointer, value);
		}

		public float VolumeStiffness
		{
			get => E_PROP_USkeletalMeshComponent_VolumeStiffness_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_VolumeStiffness_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Clear all Morph Target that are set to this mesh </para>
		/// </summary>
		public void ClearMorphTargets()
			=> E_USkeletalMeshComponent_ClearMorphTargets(this);
		
		public void CreateBodySetup()
			=> E_USkeletalMeshComponent_CreateBodySetup(this);
		
		
		/// <summary>
		/// <para>Access cached component space transforms </para>
		/// </summary>
		public TArray<FTransform> GetCachedComponentSpaceTransforms()
			=> E_USkeletalMeshComponent_GetCachedComponentSpaceTransforms(this);
		
		public bool GetDisablePostProcessBlueprint()
			=> E_USkeletalMeshComponent_GetDisablePostProcessBlueprint(this);
		
		
		/// <summary>
		/// <para>Get Morph target with given name </para>
		/// </summary>
		public float GetMorphTarget(string morphTargetName)
			=> E_USkeletalMeshComponent_GetMorphTarget(this, morphTargetName);
		
		public float GetPlayRate()
			=> E_USkeletalMeshComponent_GetPlayRate(this);
		
		public float GetPosition()
			=> E_USkeletalMeshComponent_GetPosition(this);
		
		
		/// <summary>
		/// <para>Returns whether there are any valid instances to run, currently this means whether we have </para>
		/// <para>have an animation instance or a post process instance available to process. </para>
		/// </summary>
		public bool HasValidAnimationInstance()
			=> E_USkeletalMeshComponent_HasValidAnimationInstance(this);
		
		public bool IsPlaying()
			=> E_USkeletalMeshComponent_IsPlaying(this);
		
		public void Play(bool bLooping)
			=> E_USkeletalMeshComponent_Play(this, bLooping);
		
		
		/// <summary>
		/// <para>Informs any active anim instances (main instance, sub instances, post instance) that a dynamics reset is required </para>
		/// <para>for example if a teleport occurs. </para>
		/// </summary>
		public void ResetAnimInstanceDynamics(ETeleportType inTeleportType)
			=> E_USkeletalMeshComponent_ResetAnimInstanceDynamics(this, (byte)inTeleportType);
		
		public void SetDisablePostProcessBlueprint(bool bInDisablePostProcess)
			=> E_USkeletalMeshComponent_SetDisablePostProcessBlueprint(this, bInDisablePostProcess);
		
		
		/// <summary>
		/// <para>Set Morph Target with Name and Value(0-1) </para>
		/// <param name="bRemoveZeroWeight">Used by editor code when it should stay in the active list with zero weight </param>
		/// </summary>
		public void SetMorphTarget(string morphTargetName, float value, bool bRemoveZeroWeight = true)
			=> E_USkeletalMeshComponent_SetMorphTarget(this, morphTargetName, value, bRemoveZeroWeight);
		
		public void SetPlayRate(float rate)
			=> E_USkeletalMeshComponent_SetPlayRate(this, rate);
		
		public void SetPosition(float inPos, bool bFireNotifies = true)
			=> E_USkeletalMeshComponent_SetPosition(this, inPos, bFireNotifies);
		
		public void Stop()
			=> E_USkeletalMeshComponent_Stop(this);
		
		
		/// <summary>
		/// <para>Toggles whether the post process blueprint will run for this component </para>
		/// </summary>
		public void ToggleDisablePostProcessBlueprint()
			=> E_USkeletalMeshComponent_ToggleDisablePostProcessBlueprint(this);
		
		#endregion
		
		public static implicit operator IntPtr(USkeletalMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USkeletalMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkeletalMeshComponent>(PtrDesc);
		}}}
