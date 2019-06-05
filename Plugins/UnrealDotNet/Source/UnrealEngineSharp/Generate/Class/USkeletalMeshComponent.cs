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
	public partial class USkeletalMeshComponent : USkinnedMeshComponent
	{
		public USkeletalMeshComponent(IntPtr adress)
			: base(adress)
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
		private static extern void E_USkeletalMeshComponent_AllowAnimCurveEvaluation(IntPtr self, string nameOfCurve, bool bAllow);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_BindClothToMasterPoseComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ClearMorphTargets(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_CreateBodySetup(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ForceClothNextUpdateTeleport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ForceClothNextUpdateTeleportAndReset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_GetAllowedAnimCurveEvaluate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetClothMaxDistanceScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_GetDisableAnimCurves(IntPtr self);
		
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
		private static extern bool E_USkeletalMeshComponent_InitializeAnimScriptInstance(IntPtr self, bool bForceReinit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsClothingSimulationSuspended(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsPlaying(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsWindEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Play(IntPtr self, bool bLooping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ResetAllowedAnimCurveEvaluation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ResetAnimInstanceDynamics(IntPtr self, byte inTeleportType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ResetClothTeleportMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ResumeClothingSimulation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetAllowAnimCurveEvaluation(IntPtr self, bool bInAllow);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetClothMaxDistanceScale(IntPtr self, float scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetDisableAnimCurves(IntPtr self, bool bInDisableAnimCurves);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetDisablePostProcessBlueprint(IntPtr self, bool bInDisablePostProcess);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetMorphTarget(IntPtr self, string morphTargetName, float value, bool bRemoveZeroWeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetPlayRate(IntPtr self, float rate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetPosition(IntPtr self, float inPos, bool bFireNotifies);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetUpdateAnimationInEditor(IntPtr self, bool newUpdateState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Stop(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SuspendClothingSimulation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ToggleDisablePostProcessBlueprint(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_UnbindClothFromMasterPoseComponent(IntPtr self, bool bRestoreSimulationSpace);
		
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
		/// can't collide with part of attached children if total collision volumes exceed 16 capsules or 32 planes per convex
		/// </summary>
		public byte bCollideWithAttachedChildren
		{
			get => E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bCollideWithAttachedChildren_SET(NativePointer, value);
		}

		
		/// <summary>
		/// can't collide with part of environment if total collision volumes exceed 16 capsules or 32 planes per convex
		/// </summary>
		public byte bCollideWithEnvironment
		{
			get => E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bCollideWithEnvironment_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether animation and world transform updates are deferred. If this is on, the kinematic bodies (scene query data) will not update until the next time the physics simulation is run
		/// </summary>
		public byte bDeferKinematicBoneUpdate
		{
			get => E_PROP_USkeletalMeshComponent_bDeferKinematicBoneUpdate_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bDeferKinematicBoneUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Indicates that this SkeletalMeshComponent has deferred kinematic bone updates until next physics sim.
		/// </summary>
		public byte bDeferredKinematicUpdate
		{
			get => E_PROP_USkeletalMeshComponent_bDeferredKinematicUpdate_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bDeferredKinematicUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Disable cloth simulation and play original animation without simulation
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
		/// Uses skinned data for collision data.
		/// </summary>
		public byte bEnablePerPolyCollision
		{
			get => E_PROP_USkeletalMeshComponent_bEnablePerPolyCollision_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bEnablePerPolyCollision_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, simulate physics for this component on a dedicated server.
		/// <para>This should be set if simulating physics and replicating with a dedicated server. </para>
		/// Note: This property cannot be changed at runtime.
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
		/// If true, the Location of this Component will be included into its bounds calculation
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
		/// Temporary fix for local space kinematics. This only works for bodies that have no constraints and is needed by vehicles. Proper support will remove this flag
		/// </summary>
		public byte bLocalSpaceKinematics
		{
			get => E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bLocalSpaceKinematics_SET(NativePointer, value);
		}

		
		/// <summary>
		/// It's worth trying this option when you feel that the current cloth simulation is unstable.
		/// <para>The scale of the actor is maintained during the simulation. </para>
		/// It is possible to add the inertia effects to the simulation, through the inertiaScale parameter of the clothing material.
		/// <para>So with an inertiaScale of 1.0 there should be no visible difference between local space and global space simulation. </para>
		/// Known issues: - Currently there's simulation issues when this feature is used in 3.x (DE4076) So if localSpaceSim is enabled there's no inertia effect when the global pose of the clothing actor changes.
		/// </summary>
		public byte bLocalSpaceSimulation
		{
			get => E_PROP_USkeletalMeshComponent_bLocalSpaceSimulation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bLocalSpaceSimulation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Skips Ticking and Bone Refresh.
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

		public byte bOnlyAllowAutonomousTickPose
		{
			get => E_PROP_USkeletalMeshComponent_bOnlyAllowAutonomousTickPose_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bOnlyAllowAutonomousTickPose_SET(NativePointer, value);
		}

		
		/// <summary>
		/// pauses this component's animations (doesn't tick them, but still refreshes bones)
		/// </summary>
		public byte bPauseAnims
		{
			get => E_PROP_USkeletalMeshComponent_bPauseAnims_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bPauseAnims_SET(NativePointer, value);
		}

		
		/// <summary>
		/// To save previous state
		/// </summary>
		public byte bPrevDisableClothSimulation
		{
			get => E_PROP_USkeletalMeshComponent_bPrevDisableClothSimulation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bPrevDisableClothSimulation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, propagates calls to ApplyAnimationCurvesToComponent for slave components, only needed if slave components do not tick themselves
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
		/// reset the clothing after moving the clothing position (called teleport)
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
		/// Indicates that simulation (if it's enabled) is entirely responsible for children transforms. This is only ok if you are not animating attachment points relative to the simulation
		/// </summary>
		public byte bSimulationUpdatesChildTransforms
		{
			get => E_PROP_USkeletalMeshComponent_bSimulationUpdatesChildTransforms_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bSimulationUpdatesChildTransforms_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to skip bounds update when interpolating. Bounds are updated to the target interpolation pose only on ticks when they are evaluated.
		/// </summary>
		public byte bSkipBoundsUpdateWhenInterpolating
		{
			get => E_PROP_USkeletalMeshComponent_bSkipBoundsUpdateWhenInterpolating_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bSkipBoundsUpdateWhenInterpolating_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether to skip UpdateKinematicBonesToAnim() when interpolating. Kinematic bones are updated to the target interpolation pose only on ticks when they are evaluated.
		/// </summary>
		public byte bSkipKinematicUpdateWhenInterpolating
		{
			get => E_PROP_USkeletalMeshComponent_bSkipKinematicUpdateWhenInterpolating_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bSkipKinematicUpdateWhenInterpolating_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If we should pass joint position to joints each frame, so that they can be used by motorized joints to drive the
		/// <para>ragdoll based on the animation. </para>
		/// </summary>
		public byte bUpdateJointsFromAnimation
		{
			get => E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls whether blending in physics bones will refresh overlaps on this component, defaults to true but can be disabled in cases where we know anim->physics blending doesn't meaningfully change overlaps
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
		/// On InitAnim should we set to ref pose (if false use first tick of animation data)
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
		/// weight to blend between simulated results and key-framed positions
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
		/// Used to scale speed of all animations on this skeletal mesh.
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
		/// Threshold for physics asset bodies above which we use an aggregate for broadphase collisions
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
		public void AllowAnimCurveEvaluation(string nameOfCurve, bool bAllow)
			=> E_USkeletalMeshComponent_AllowAnimCurveEvaluation(this, nameOfCurve, bAllow);
		
		
		/// <summary>
		/// If this component has a valid MasterPoseComponent then this function makes cloth items on the slave component
		/// <para>take the transforms of the cloth items on the master component instead of simulating separately. </para>
		/// @Note This will FORCE any cloth actor on the master component to simulate in local space. Also
		/// <para>The meshes used in the components must be identical for the cloth to bind correctly </para>
		/// </summary>
		public void BindClothToMasterPoseComponent()
			=> E_USkeletalMeshComponent_BindClothToMasterPoseComponent(this);
		
		
		/// <summary>
		/// Clear all Morph Target that are set to this mesh
		/// </summary>
		public void ClearMorphTargets()
			=> E_USkeletalMeshComponent_ClearMorphTargets(this);
		
		public void CreateBodySetup()
			=> E_USkeletalMeshComponent_CreateBodySetup(this);
		
		
		/// <summary>
		/// Used to indicate we should force 'teleport' during the next call to UpdateClothState,
		/// <para>This will transform positions and velocities and thus keep the simulation state, just translate it to a new pose. </para>
		/// </summary>
		public void ForceClothNextUpdateTeleport()
			=> E_USkeletalMeshComponent_ForceClothNextUpdateTeleport(this);
		
		
		/// <summary>
		/// Used to indicate we should force 'teleport and reset' during the next call to UpdateClothState.
		/// <para>This can be used to reset it from a bad state or by a teleport where the old state is not important anymore. </para>
		/// </summary>
		public void ForceClothNextUpdateTeleportAndReset()
			=> E_USkeletalMeshComponent_ForceClothNextUpdateTeleportAndReset(this);
		
		public bool GetAllowedAnimCurveEvaluate()
			=> E_USkeletalMeshComponent_GetAllowedAnimCurveEvaluate(this);
		
		
		/// <summary>
		/// Get/Set the max distance scale of clothing mesh vertices
		/// </summary>
		public float GetClothMaxDistanceScale()
			=> E_USkeletalMeshComponent_GetClothMaxDistanceScale(this);
		
		public bool GetDisableAnimCurves()
			=> E_USkeletalMeshComponent_GetDisableAnimCurves(this);
		
		public bool GetDisablePostProcessBlueprint()
			=> E_USkeletalMeshComponent_GetDisablePostProcessBlueprint(this);
		
		
		/// <summary>
		/// Get Morph target with given name
		/// </summary>
		public float GetMorphTarget(string morphTargetName)
			=> E_USkeletalMeshComponent_GetMorphTarget(this, morphTargetName);
		
		public float GetPlayRate()
			=> E_USkeletalMeshComponent_GetPlayRate(this);
		
		public float GetPosition()
			=> E_USkeletalMeshComponent_GetPosition(this);
		
		
		/// <summary>
		/// Returns whether there are any valid instances to run, currently this means whether we have
		/// <para>have an animation instance or a post process instance available to process. </para>
		/// </summary>
		public bool HasValidAnimationInstance()
			=> E_USkeletalMeshComponent_HasValidAnimationInstance(this);
		
		public bool InitializeAnimScriptInstance(bool bForceReinit = true)
			=> E_USkeletalMeshComponent_InitializeAnimScriptInstance(this, bForceReinit);
		
		
		/// <summary>
		/// Gets whether or not the clothing simulation is currently suspended
		/// </summary>
		public bool IsClothingSimulationSuspended()
			=> E_USkeletalMeshComponent_IsClothingSimulationSuspended(this);
		
		public bool IsPlaying()
			=> E_USkeletalMeshComponent_IsPlaying(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public virtual bool IsWindEnabled()
			=> E_USkeletalMeshComponent_IsWindEnabled(this);
		
		public void Play(bool bLooping)
			=> E_USkeletalMeshComponent_Play(this, bLooping);
		
		
		/// <summary>
		/// By reset, it will allow all the curves to be evaluated
		/// </summary>
		public void ResetAllowedAnimCurveEvaluation()
			=> E_USkeletalMeshComponent_ResetAllowedAnimCurveEvaluation(this);
		
		
		/// <summary>
		/// Informs any active anim instances (main instance, sub instances, post instance) that a dynamics reset is required
		/// <para>for example if a teleport occurs. </para>
		/// </summary>
		public void ResetAnimInstanceDynamics(ETeleportType inTeleportType)
			=> E_USkeletalMeshComponent_ResetAnimInstanceDynamics(this, (byte)inTeleportType);
		
		
		/// <summary>
		/// Reset the teleport mode of a next update to 'Continuous'
		/// </summary>
		public void ResetClothTeleportMode()
			=> E_USkeletalMeshComponent_ResetClothTeleportMode(this);
		
		
		/// <summary>
		/// Resumes a previously suspended clothing simulation, teleporting the clothing on the next tick
		/// </summary>
		public void ResumeClothingSimulation()
			=> E_USkeletalMeshComponent_ResumeClothingSimulation(this);
		
		public void SetAllowAnimCurveEvaluation(bool bInAllow)
			=> E_USkeletalMeshComponent_SetAllowAnimCurveEvaluation(this, bInAllow);
		
		public void SetClothMaxDistanceScale(float scale)
			=> E_USkeletalMeshComponent_SetClothMaxDistanceScale(this, scale);
		
		
		/// <summary>
		/// return true if currently updating in editor is true
		/// <para>this is non BP because this is only used for slave component to detect master component ticking state </para>
		/// </summary>
		public void SetDisableAnimCurves(bool bInDisableAnimCurves)
			=> E_USkeletalMeshComponent_SetDisableAnimCurves(this, bInDisableAnimCurves);
		
		public void SetDisablePostProcessBlueprint(bool bInDisablePostProcess)
			=> E_USkeletalMeshComponent_SetDisablePostProcessBlueprint(this, bInDisablePostProcess);
		
		
		/// <summary>
		/// Set Morph Target with Name and Value(0-1)
		/// </summary>
		/// <param name="bRemoveZeroWeight">Used by editor code when it should stay in the active list with zero weight</param>
		public void SetMorphTarget(string morphTargetName, float value, bool bRemoveZeroWeight = true)
			=> E_USkeletalMeshComponent_SetMorphTarget(this, morphTargetName, value, bRemoveZeroWeight);
		
		public void SetPlayRate(float rate)
			=> E_USkeletalMeshComponent_SetPlayRate(this, rate);
		
		public void SetPosition(float inPos, bool bFireNotifies = true)
			=> E_USkeletalMeshComponent_SetPosition(this, inPos, bFireNotifies);
		
		
		/// <summary>
		/// Sets whether or not to force tick component in order to update animation and refresh transform for this component
		/// <para>This is supported only in the editor </para>
		/// </summary>
		public void SetUpdateAnimationInEditor(bool newUpdateState)
			=> E_USkeletalMeshComponent_SetUpdateAnimationInEditor(this, newUpdateState);
		
		public void Stop()
			=> E_USkeletalMeshComponent_Stop(this);
		
		
		/// <summary>
		/// Stops simulating clothing, but does not show clothing ref pose. Keeps the last known simulation state
		/// </summary>
		public void SuspendClothingSimulation()
			=> E_USkeletalMeshComponent_SuspendClothingSimulation(this);
		
		
		/// <summary>
		/// Toggles whether the post process blueprint will run for this component
		/// </summary>
		public void ToggleDisablePostProcessBlueprint()
			=> E_USkeletalMeshComponent_ToggleDisablePostProcessBlueprint(this);
		
		
		/// <summary>
		/// If this component has a valid MasterPoseComponent and has previously had its cloth bound to the
		/// <para>MCP, this function will unbind the cloth and resume simulation. </para>
		/// space, we will restore this setting. This will cause the master component to reset which may be
		/// <para>undesirable. </para>
		/// </summary>
		/// <param name="bRestoreSimulationSpace">if true and the master pose cloth was originally simulating in world</param>
		public void UnbindClothFromMasterPoseComponent(bool bRestoreSimulationSpace = true)
			=> E_USkeletalMeshComponent_UnbindClothFromMasterPoseComponent(this, bRestoreSimulationSpace);
		
		#endregion
		
		public static implicit operator IntPtr(USkeletalMeshComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator USkeletalMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkeletalMeshComponent>(PtrDesc);
		}}}
