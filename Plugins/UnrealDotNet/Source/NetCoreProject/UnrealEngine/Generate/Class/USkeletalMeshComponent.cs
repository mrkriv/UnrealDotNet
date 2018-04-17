using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:254

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USkeletalMeshComponent(IntPtr Parent, string Name);
		
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
		private static extern byte E_PROP_USkeletalMeshComponent_bDeferMovementFromSceneQueries_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bDeferMovementFromSceneQueries_SET(IntPtr Ptr, byte Value);
		
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
		private static extern byte E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_ClothBlendWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_ClothBlendWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_ClothMaxDistanceScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_GlobalAnimRateScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_LineCheckBoundsScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_USkeletalMeshComponent_OnConstraintBroken(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_USkeletalMeshComponent_OnConstraintBroken(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_RagdollAggregateThreshold_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USkeletalMeshComponent_RootBoneTranslation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkeletalMeshComponent_RootBoneTranslation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ClearMorphTargets(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_CreateBodySetup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_GetDisablePostProcessBlueprint(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetMorphTarget(IntPtr Self, string MorphTargetName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetPlayRate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetPosition(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsPlaying(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Play(IntPtr Self, bool bLooping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetDisablePostProcessBlueprint(IntPtr Self, bool bInDisablePostProcess);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetMorphTarget(IntPtr Self, string MorphTargetName, float Value, bool bRemoveZeroWeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetPlayRate(IntPtr Self, float Rate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetPosition(IntPtr Self, float InPos, bool bFireNotifies);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Stop(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ToggleDisablePostProcessBlueprint(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ClearRefPoseOverride(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_CreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_DestroyRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_DoesSocketExist(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USkeletalMeshComponent_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USkeletalMeshComponent_GetMaterialIndex(IntPtr Self, string MaterialSlotName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USkeletalMeshComponent_GetNumMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkeletalMeshComponent_GetSocketTransform(IntPtr Self, string InSocketName, byte TransformSpace);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_HasAnySockets(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsMaterialSlotNameValid(IntPtr Self, string MaterialSlotName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnRegister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnUnregister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_RequiresGameThreadEndOfFrameRecreate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SendRenderDynamicData_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_ShouldCPUSkin(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddAngularImpulse(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddAngularImpulseInRadians(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddForce(IntPtr Self, IntPtr Force, string BoneName, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddForceAtLocation(IntPtr Self, IntPtr Force, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddForceAtLocationLocal(IntPtr Self, IntPtr Force, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddImpulse(IntPtr Self, IntPtr Impulse, string BoneName, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddImpulseAtLocation(IntPtr Self, IntPtr Impulse, IntPtr Location, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddRadialForce(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bAccelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddRadialImpulse(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_AreAllCollideableDescendantsRelative(IntPtr Self, bool bAllowCachedValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_AreSymmetricRotations(IntPtr Self, IntPtr A, IntPtr B, IntPtr Scale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_CalculateMass(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_CanCharacterStepUp(IntPtr Self, IntPtr Pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_CanEditSimulatePhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetAngularDamping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USkeletalMeshComponent_GetCollisionObjectType(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USkeletalMeshComponent_GetCollisionResponseToChannel(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkeletalMeshComponent_GetComponentVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetDiffuseBoost(IntPtr Self, int ElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetEmissiveBoost(IntPtr Self, int ElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkeletalMeshComponent_GetInertiaTensor(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_GetLightAndShadowMapMemoryUsage(IntPtr Self, int LightMapMemoryUsage, int ShadowMapMemoryUsage);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_GetLightMapResolution(IntPtr Self, int Width, int Height);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetLinearDamping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetMass(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USkeletalMeshComponent_GetMassScale(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkeletalMeshComponent_GetNavigationBounds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_GetShadowIndirectOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_GetSquaredDistanceToCollision(IntPtr Self, IntPtr Point, float OutSquaredDistance, IntPtr OutClosestPointOnCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_USkeletalMeshComponent_GetStaticDepthPriorityGroup(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USkeletalMeshComponent_GetStaticLightMapResolution(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_HasValidPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_HasValidSettingsForStaticLighting(IntPtr Self, bool bOverlookInvalidComponents);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_InvalidateLightingCacheDetailed(IntPtr Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsAnyRigidBodyAwake(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsGravityEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsNavigationRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsSimulatingPhysics(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsWorldGeometry(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsZeroExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_MoveComponentImpl(IntPtr Self, IntPtr Delta, IntPtr NewRotation, bool bSweep, IntPtr OutHit, byte MoveFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnActorEnableCollisionChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnAttachmentChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnComponentCollisionSettingsChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnComponentDestroyed(IntPtr Self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnDestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnUpdateTransform(IntPtr Self, byte UpdateTransformFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PostDuplicate(IntPtr Self, bool bDuplicateForPIE);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PutAllRigidBodiesToSleep(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_RegisterComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkeletalMeshComponent_ScaleByMomentOfInertia(IntPtr Self, IntPtr InputVector, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SendRenderTransform_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetAllMassScale(IntPtr Self, float InMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetAllPhysicsAngularVelocity(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetAllPhysicsAngularVelocityInRadians(IntPtr Self, IntPtr NewAngVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetAllPhysicsLinearVelocity(IntPtr Self, IntPtr NewVel, bool bAddToCurrent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetAllPhysicsPosition(IntPtr Self, IntPtr NewPos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetAllUseCCD(IntPtr Self, bool InUseCCD);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetAngularDamping(IntPtr Self, float InDamping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetCollisionObjectType(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetCollisionProfileName(IntPtr Self, string InCollisionProfileName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetCollisionResponseToAllChannels(IntPtr Self, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetCollisionResponseToChannel(IntPtr Self, byte Channel, byte NewResponse);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetCollisionResponseToChannels(IntPtr Self, IntPtr NewReponses);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetEnableGravity(IntPtr Self, bool bGravityEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetLinearDamping(IntPtr Self, float InDamping);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetMassOverrideInKg(IntPtr Self, string BoneName, float MassInKg, bool bOverrideMass);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetMassScale(IntPtr Self, string BoneName, float InMassScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetNotifyRigidBodyCollision(IntPtr Self, bool bNewNotifyRigidBodyCollision);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetSimulatePhysics(IntPtr Self, bool bSimulate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetUseCCD(IntPtr Self, bool InUseCCD, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_ShouldCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_ShouldRecreateProxyOnUpdateTransform(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_ShouldRenderSelected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_SupportsStaticLighting(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_UnWeldChildren(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_UnWeldFromParent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_UpdatePhysicsToRBChannels(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_UpdatePhysicsVolume(IntPtr Self, bool bTriggerNotifiers);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_UsesOnlyUnlitMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_WakeAllRigidBodies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_WakeRigidBody(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_WeldTo(IntPtr Self, IntPtr InParent, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_WeldToImplementation(IntPtr Self, IntPtr InParent, string ParentSocketName, bool bWeldSimulatedChild);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_CalcBoundingCylinder(IntPtr Self, float CylinderRadius, float CylinderHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_CanAttachAsChild(IntPtr Self, IntPtr ChildComponent, string SocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_DestroyComponent(IntPtr Self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_DetachFromComponent(IntPtr Self, IntPtr DetachmentRules);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_DetachFromParent(IntPtr Self, bool bMaintainWorldPosition, bool bCallModify);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkeletalMeshComponent_GetSocketLocation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkeletalMeshComponent_GetSocketQuaternion(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkeletalMeshComponent_GetSocketRotation(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsAnySimulatingPhysics(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsPrecomputedLightingValid(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsVisible(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsVisibleInEditor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnChildAttached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnChildDetached(IntPtr Self, IntPtr ChildComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnHiddenInGameChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnVisibilityChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PropagateLightingScenarioChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetRelativeScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_ShouldCollideWhenPlacing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_ShouldCreateRenderState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Activate(IntPtr Self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_Deactivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_GetComponentClassCanReplicate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USkeletalMeshComponent_GetReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_InitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsReadyForOwnerToAutoDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnComponentCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_RequiresGameThreadEndOfFrameUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetActive(IntPtr Self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetAutoActivate(IntPtr Self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetComponentTickEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_SetComponentTickEnabledAsync(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_ShouldActivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ToggleActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_UninitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USkeletalMeshComponent_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkeletalMeshComponent_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkeletalMeshComponent_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region Property
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
		public byte bDeferMovementFromSceneQueries
		{
			get => E_PROP_USkeletalMeshComponent_bDeferMovementFromSceneQueries_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bDeferMovementFromSceneQueries_SET(NativePointer, value);
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
		/// <para>If we should pass joint position to joints each frame, so that they can be used by motorized joints to drive the </para>
		/// <para>ragdoll based on the animation. </para>
		/// </summary>
		public byte bUpdateJointsFromAnimation
		{
			get => E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUpdateJointsFromAnimation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>On InitAnim should we set to ref pose (if false use first tick of animation data) </para>
		/// </summary>
		public byte bUseRefPoseOnInitAnim
		{
			get => E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_GET(NativePointer);
			set => E_PROP_USkeletalMeshComponent_bUseRefPoseOnInitAnim_SET(NativePointer, value);
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

		#endregion
		
		#region Events
		public event FConstraintBrokenSignature OnConstraintBroken
		{
			add
			{
				E_EVENT_ADD_USkeletalMeshComponent_OnConstraintBroken(NativePointer);
				_Event_OnConstraintBroken += value;
			}

			remove
			{
				E_EVENT_DEL_USkeletalMeshComponent_OnConstraintBroken(NativePointer);
				_Event_OnConstraintBroken -= value;
			}

		}

		private event FConstraintBrokenSignature _Event_OnConstraintBroken;
		
		internal void InvokeEvent_OnConstraintBroken(int ConstraintIndex)
		{
			_Event_OnConstraintBroken?.Invoke(ConstraintIndex);
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
		
		public bool GetDisablePostProcessBlueprint()
			=> E_USkeletalMeshComponent_GetDisablePostProcessBlueprint(this);
		
		
		/// <summary>
		/// <para>Get Morph target with given name </para>
		/// </summary>
		public float GetMorphTarget(string MorphTargetName)
			=> E_USkeletalMeshComponent_GetMorphTarget(this, MorphTargetName);
		
		public float GetPlayRate()
			=> E_USkeletalMeshComponent_GetPlayRate(this);
		
		public float GetPosition()
			=> E_USkeletalMeshComponent_GetPosition(this);
		
		public bool IsPlaying()
			=> E_USkeletalMeshComponent_IsPlaying(this);
		
		public void Play(bool bLooping)
			=> E_USkeletalMeshComponent_Play(this, bLooping);
		
		public void SetDisablePostProcessBlueprint(bool bInDisablePostProcess)
			=> E_USkeletalMeshComponent_SetDisablePostProcessBlueprint(this, bInDisablePostProcess);
		
		
		/// <summary>
		/// <para>Set Morph Target with Name and Value(0-1) </para>
		/// <param name="bRemoveZeroWeight">Used by editor code when it should stay in the active list with zero weight </param>
		/// </summary>
		public void SetMorphTarget(string MorphTargetName, float Value, bool bRemoveZeroWeight = true)
			=> E_USkeletalMeshComponent_SetMorphTarget(this, MorphTargetName, Value, bRemoveZeroWeight);
		
		public void SetPlayRate(float Rate)
			=> E_USkeletalMeshComponent_SetPlayRate(this, Rate);
		
		public void SetPosition(float InPos, bool bFireNotifies = true)
			=> E_USkeletalMeshComponent_SetPosition(this, InPos, bFireNotifies);
		
		public void Stop()
			=> E_USkeletalMeshComponent_Stop(this);
		
		
		/// <summary>
		/// <para>Toggles whether the post process blueprint will run for this component </para>
		/// </summary>
		public void ToggleDisablePostProcessBlueprint()
			=> E_USkeletalMeshComponent_ToggleDisablePostProcessBlueprint(this);
		
		public override void BeginDestroy()
			=> E_USkeletalMeshComponent_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Clear any applied ref pose override </para>
		/// </summary>
		public override void ClearRefPoseOverride()
			=> E_USkeletalMeshComponent_ClearRefPoseOverride(this);
		
		public override void CreateRenderState_Concurrent()
			=> E_USkeletalMeshComponent_CreateRenderState_Concurrent(this);
		
		public override void DestroyRenderState_Concurrent()
			=> E_USkeletalMeshComponent_DestroyRenderState_Concurrent(this);
		
		public override bool DoesSocketExist(string InSocketName)
			=> E_USkeletalMeshComponent_DoesSocketExist(this, InSocketName);
		
		public override string GetDetailedInfoInternal()
			=> E_USkeletalMeshComponent_GetDetailedInfoInternal(this);
		
		public override int GetMaterialIndex(string MaterialSlotName)
			=> E_USkeletalMeshComponent_GetMaterialIndex(this, MaterialSlotName);
		
		public override int GetNumMaterials()
			=> E_USkeletalMeshComponent_GetNumMaterials(this);
		
		public override FTransform GetSocketTransform(string InSocketName, ERelativeTransformSpace TransformSpace)
			=> E_USkeletalMeshComponent_GetSocketTransform(this, InSocketName, (byte)TransformSpace);
		
		public override bool HasAnySockets()
			=> E_USkeletalMeshComponent_HasAnySockets(this);
		
		public override bool IsMaterialSlotNameValid(string MaterialSlotName)
			=> E_USkeletalMeshComponent_IsMaterialSlotNameValid(this, MaterialSlotName);
		
		public override void OnRegister()
			=> E_USkeletalMeshComponent_OnRegister(this);
		
		public override void OnUnregister()
			=> E_USkeletalMeshComponent_OnUnregister(this);
		
		public override bool RequiresGameThreadEndOfFrameRecreate()
			=> E_USkeletalMeshComponent_RequiresGameThreadEndOfFrameRecreate(this);
		
		protected override void SendRenderDynamicData_Concurrent()
			=> E_USkeletalMeshComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// <para>Function returns whether or not CPU skinning should be applied </para>
		/// <para>Allows the editor to override the skinning state for editor tools </para>
		/// <return>true if should CPU skin. false otherwise </return>
		/// </summary>
		public override bool ShouldCPUSkin()
			=> E_USkeletalMeshComponent_ShouldCPUSkin(this);
		
		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddAngularImpulse(FVector Impulse, string BoneName, bool bVelChange)
			=> E_USkeletalMeshComponent_AddAngularImpulse(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add an angular impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="AngularImpulse">Magnitude and direction of impulse to apply. Direction is axis of rotation. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply angular impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in angular velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddAngularImpulseInRadians(FVector Impulse, string BoneName, bool bVelChange)
			=> E_USkeletalMeshComponent_AddAngularImpulseInRadians(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// <param name="bAccelChange">If true, Force is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect). </param>
		/// </summary>
		public override void AddForce(FVector Force, string BoneName, bool bAccelChange)
			=> E_USkeletalMeshComponent_AddForce(this, Force, BoneName, bAccelChange);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location in world space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in world space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public override void AddForceAtLocation(FVector Force, FVector Location, string BoneName)
			=> E_USkeletalMeshComponent_AddForceAtLocation(this, Force, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add a force to a single rigid body at a particular location. Both Force and Location should be in body space. </para>
		/// <para>This is like a 'thruster'. Good for adding a burst over some (non zero) time. Should be called every frame for the duration of the force. </para>
		/// <param name="Force">Force vector to apply. Magnitude indicates strength of force. </param>
		/// <param name="Location">Location to apply force, in component space. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply force to. 'None' indicates root body. </param>
		/// </summary>
		public override void AddForceAtLocationLocal(FVector Force, FVector Location, string BoneName)
			=> E_USkeletalMeshComponent_AddForceAtLocationLocal(this, Force, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body. Good for one time instant burst. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to apply impulse to. 'None' indicates root body. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddImpulse(FVector Impulse, string BoneName, bool bVelChange)
			=> E_USkeletalMeshComponent_AddImpulse(this, Impulse, BoneName, bVelChange);
		
		
		/// <summary>
		/// <para>Add an impulse to a single rigid body at a specific location. </para>
		/// <param name="Impulse">Magnitude and direction of impulse to apply. </param>
		/// <param name="Location">Point in world space to apply impulse at. </param>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of bone to apply impulse to. 'None' indicates root body. </param>
		/// </summary>
		public override void AddImpulseAtLocation(FVector Impulse, FVector Location, string BoneName)
			=> E_USkeletalMeshComponent_AddImpulseAtLocation(this, Impulse, Location, BoneName);
		
		
		/// <summary>
		/// <para>Add a force to all bodies in this component, originating from the supplied world-space location. </para>
		/// <param name="Origin">Origin of force in world space. </param>
		/// <param name="Radius">Radius within which to apply the force. </param>
		/// <param name="Strength">Strength of force to apply. </param>
		/// <param name="Falloff">Allows you to control the strength of the force as a function of distance from Origin. </param>
		/// <param name="bAccelChange">If true, Strength is taken as a change in acceleration instead of a physical force (i.e. mass will have no effect). </param>
		/// </summary>
		public override void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bAccelChange)
			=> E_USkeletalMeshComponent_AddRadialForce(this, Origin, Radius, Strength, (byte)Falloff, bAccelChange);
		
		
		/// <summary>
		/// <para>Add an impulse to all rigid bodies in this component, radiating out from the specified position. </para>
		/// <param name="Origin">Point of origin for the radial impulse blast, in world space </param>
		/// <param name="Radius">Size of radial impulse. Beyond this distance from Origin, there will be no affect. </param>
		/// <param name="Strength">Maximum strength of impulse applied to body. </param>
		/// <param name="Falloff">Allows you to control the strength of the impulse as a function of distance from Origin. </param>
		/// <param name="bVelChange">If true, the Strength is taken as a change in velocity instead of an impulse (ie. mass will have no effect). </param>
		/// </summary>
		public override void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
			=> E_USkeletalMeshComponent_AddRadialImpulse(this, Origin, Radius, Strength, (byte)Falloff, bVelChange);
		
		
		/// <summary>
		/// <para>Returns true if all descendant components that we can possibly overlap with use relative location and rotation. </para>
		/// </summary>
		protected override bool AreAllCollideableDescendantsRelative(bool bAllowCachedValue)
			=> E_USkeletalMeshComponent_AreAllCollideableDescendantsRelative(this, bAllowCachedValue);
		
		
		/// <summary>
		/// <para>Returns true if the given transforms result in the same bounds, due to rotational symmetry. </para>
		/// <para>For example, this is true for a sphere with uniform scale undergoing any rotation. </para>
		/// <para>This is NOT intended to detect every case where this is true, only the common cases to aid optimizations. </para>
		/// </summary>
		public override bool AreSymmetricRotations(FQuat A, FQuat B, FVector Scale3D)
			=> E_USkeletalMeshComponent_AreSymmetricRotations(this, A, B, Scale3D);
		
		
		/// <summary>
		/// <para>Used to detach physics objects before simulation begins. This is needed because at runtime we can't have simulated objects inside the attachment hierarchy </para>
		/// </summary>
		public override void BeginPlay()
			=> E_USkeletalMeshComponent_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Returns the calculated mass in kg. This is not 100% exactly the mass physx will calculate, but it is very close ( difference < 0.1kg ). </para>
		/// </summary>
		public override float CalculateMass(string BoneName)
			=> E_USkeletalMeshComponent_CalculateMass(this, BoneName);
		
		
		/// <summary>
		/// <para>Return true if the given Pawn can step up onto this component. </para>
		/// <para>This controls whether they can try to step up on it when they bump in to it, not whether they can walk on it after landing on it. </para>
		/// <param name="Pawn">the Pawn that wants to step onto this component. </param>
		/// <para>@see CanCharacterStepUpOn </para>
		/// </summary>
		public override bool CanCharacterStepUp(APawn Pawn)
			=> E_USkeletalMeshComponent_CanCharacterStepUp(this, Pawn);
		
		
		/// <summary>
		/// <para>Determines whether or not the simulate physics setting can be edited interactively on this component </para>
		/// </summary>
		public override bool CanEditSimulatePhysics()
			=> E_USkeletalMeshComponent_CanEditSimulatePhysics(this);
		
		public override void FinishDestroy()
			=> E_USkeletalMeshComponent_FinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns the angular damping of this component. </para>
		/// </summary>
		public override float GetAngularDamping()
			=> E_USkeletalMeshComponent_GetAngularDamping(this);
		
		
		/// <summary>
		/// <para>Gets the collision object type </para>
		/// </summary>
		public override ECollisionChannel GetCollisionObjectType()
			=> (ECollisionChannel)E_USkeletalMeshComponent_GetCollisionObjectType(this);
		
		
		/// <summary>
		/// <para>Gets the response type given a specific channel </para>
		/// </summary>
		public override ECollisionResponse GetCollisionResponseToChannel(ECollisionChannel Channel)
			=> (ECollisionResponse)E_USkeletalMeshComponent_GetCollisionResponseToChannel(this, (byte)Channel);
		
		public override FVector GetComponentVelocity()
			=> E_USkeletalMeshComponent_GetComponentVelocity(this);
		
		
		/// <summary>
		/// <para>Gets the diffuse boost for the primitive component. </para>
		/// </summary>
		public override float GetDiffuseBoost(int ElementIndex)
			=> E_USkeletalMeshComponent_GetDiffuseBoost(this, ElementIndex);
		
		
		/// <summary>
		/// <para>Gets the emissive boost for the primitive component. </para>
		/// </summary>
		public override float GetEmissiveBoost(int ElementIndex)
			=> E_USkeletalMeshComponent_GetEmissiveBoost(this, ElementIndex);
		
		
		/// <summary>
		/// <para>Returns the inertia tensor of this component in kg cm^2. The inertia tensor is in local component space. </para>
		/// </summary>
		public override FVector GetInertiaTensor(string BoneName)
			=> E_USkeletalMeshComponent_GetInertiaTensor(this, BoneName);
		
		
		/// <summary>
		/// <para>Returns the light and shadow map memory for this primitive in its out variables. </para>
		/// <para>Shadow map memory usage is per light whereof lightmap data is independent of number of lights, assuming at least one. </para>
		/// <param name="out">LightMapMemoryUsage		Memory usage in bytes for light map (either texel or vertex) data </param>
		/// <param name="out">ShadowMapMemoryUsage	Memory usage in bytes for shadow map (either texel or vertex) data </param>
		/// </summary>
		public override void GetLightAndShadowMapMemoryUsage(int LightMapMemoryUsage, int ShadowMapMemoryUsage)
			=> E_USkeletalMeshComponent_GetLightAndShadowMapMemoryUsage(this, LightMapMemoryUsage, ShadowMapMemoryUsage);
		
		
		/// <summary>
		/// <para>Returns the lightmap resolution used for this primitive instance in the case of it supporting texture light/ shadow maps. </para>
		/// <para>0 if not supported or no static shadowing. </para>
		/// <param name="Width">out]	Width of light/shadow map </param>
		/// <param name="Height">out]	Height of light/shadow map </param>
		/// <return>bool			true if LightMap values are padded, false if not </return>
		/// </summary>
		public override bool GetLightMapResolution(int Width, int Height)
			=> E_USkeletalMeshComponent_GetLightMapResolution(this, Width, Height);
		
		
		/// <summary>
		/// <para>Returns the linear damping of this component. </para>
		/// </summary>
		public override float GetLinearDamping()
			=> E_USkeletalMeshComponent_GetLinearDamping(this);
		
		
		/// <summary>
		/// <para>Returns the mass of this component in kg. </para>
		/// </summary>
		public override float GetMass()
			=> E_USkeletalMeshComponent_GetMass(this);
		
		
		/// <summary>
		/// <para>Returns the mass scale used to calculate the mass of a single physics body </para>
		/// </summary>
		public override float GetMassScale(string BoneName)
			=> E_USkeletalMeshComponent_GetMassScale(this, BoneName);
		
		public override FBox GetNavigationBounds()
			=> E_USkeletalMeshComponent_GetNavigationBounds(this);
		
		public override bool GetShadowIndirectOnly()
			=> E_USkeletalMeshComponent_GetShadowIndirectOnly(this);
		
		
		/// <summary>
		/// <para>returns The square of the distance to closest Body Instance surface. </para>
		/// <param name="Point">World 3D vector </param>
		/// <param name="OutSquaredDistance">The squared distance to closest Body Instance surface. 0 if inside of the body </param>
		/// <param name="OutPointOnBody">Point on the surface of collision closest to Point </param>
		/// <return>true if a distance to the body was found and OutDistanceSquared has been populated </return>
		/// </summary>
		public override bool GetSquaredDistanceToCollision(FVector Point, float OutSquaredDistance, FVector OutClosestPointOnCollision)
			=> E_USkeletalMeshComponent_GetSquaredDistanceToCollision(this, Point, OutSquaredDistance, OutClosestPointOnCollision);
		
		
		/// <summary>
		/// <para>Determines the DPG the primitive's primary elements are drawn in. </para>
		/// <para>Even if the primitive's elements are drawn in multiple DPGs, a primary DPG is needed for occlusion culling and shadow projection. </para>
		/// <return>The DPG the primitive's primary elements will be drawn in. </return>
		/// </summary>
		public override byte GetStaticDepthPriorityGroup()
			=> E_USkeletalMeshComponent_GetStaticDepthPriorityGroup(this);
		
		
		/// <summary>
		/// <para>Returns the static lightmap resolution used for this primitive. </para>
		/// <para>0 if not supported or no static shadowing. </para>
		/// <return>int32		The StaticLightmapResolution for the component </return>
		/// </summary>
		public override int GetStaticLightMapResolution()
			=> E_USkeletalMeshComponent_GetStaticLightMapResolution(this);
		
		public override bool HasValidPhysicsState()
			=> E_USkeletalMeshComponent_HasValidPhysicsState(this);
		
		public override bool HasValidSettingsForStaticLighting(bool bOverlookInvalidComponents)
			=> E_USkeletalMeshComponent_HasValidSettingsForStaticLighting(this, bOverlookInvalidComponents);
		
		
		/// <summary>
		/// <para>This function is used to create hierarchical LOD for the level. You can decide to opt out if you don't want. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E_USkeletalMeshComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns if any body in this component is currently awake and simulating. </para>
		/// </summary>
		public override bool IsAnyRigidBodyAwake()
			=> E_USkeletalMeshComponent_IsAnyRigidBodyAwake(this);
		
		public override bool IsEditorOnly()
			=> E_USkeletalMeshComponent_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>Returns whether this component is affected by gravity. Returns always false if the component is not simulated. </para>
		/// </summary>
		public override bool IsGravityEnabled()
			=> E_USkeletalMeshComponent_IsGravityEnabled(this);
		
		public override bool IsNavigationRelevant()
			=> E_USkeletalMeshComponent_IsNavigationRelevant(this);
		
		public override bool IsReadyForFinishDestroy()
			=> E_USkeletalMeshComponent_IsReadyForFinishDestroy(this);
		
		public override bool IsSimulatingPhysics(string BoneName)
			=> E_USkeletalMeshComponent_IsSimulatingPhysics(this, BoneName);
		
		public override bool IsWorldGeometry()
			=> E_USkeletalMeshComponent_IsWorldGeometry(this);
		
		
		/// <summary>
		/// <para>This isn't bound extent, but for shape component to utilize extent is 0. </para>
		/// <para>For normal primitive, this is 0, for ShapeComponent, this will have valid information </para>
		/// </summary>
		public override bool IsZeroExtent()
			=> E_USkeletalMeshComponent_IsZeroExtent(this);
		
		protected override bool MoveComponentImpl(FVector Delta, FQuat NewRotation, bool bSweep, FHitResult OutHit, EMoveComponentFlags MoveFlags, ETeleportType Teleport)
			=> E_USkeletalMeshComponent_MoveComponentImpl(this, Delta, NewRotation, bSweep, OutHit, (byte)MoveFlags, (byte)Teleport);
		
		public override bool NeedsLoadForClient()
			=> E_USkeletalMeshComponent_NeedsLoadForClient(this);
		
		public override bool NeedsLoadForServer()
			=> E_USkeletalMeshComponent_NeedsLoadForServer(this);
		
		public override void OnActorEnableCollisionChanged()
			=> E_USkeletalMeshComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// <para>Event called when AttachParent changes, to allow the scene to update its attachment state. </para>
		/// </summary>
		public override void OnAttachmentChanged()
			=> E_USkeletalMeshComponent_OnAttachmentChanged(this);
		
		
		/// <summary>
		/// <para>Called when the BodyInstance ResponseToChannels, CollisionEnabled or bNotifyRigidBodyCollision changes, in case subclasses want to use that information. </para>
		/// </summary>
		protected override void OnComponentCollisionSettingsChanged()
			=> E_USkeletalMeshComponent_OnComponentCollisionSettingsChanged(this);
		
		public override void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E_USkeletalMeshComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		protected override void OnCreatePhysicsState()
			=> E_USkeletalMeshComponent_OnCreatePhysicsState(this);
		
		protected override void OnDestroyPhysicsState()
			=> E_USkeletalMeshComponent_OnDestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Give the static mesh component recreate render state context access to Create/DestroyRenderState_Concurrent(). </para>
		/// </summary>
		public override void OnUpdateTransform(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
			=> E_USkeletalMeshComponent_OnUpdateTransform(this, (byte)UpdateTransformFlags, (byte)Teleport);
		
		public override void PostDuplicate(bool bDuplicateForPIE)
			=> E_USkeletalMeshComponent_PostDuplicate(this, bDuplicateForPIE);
		
		public override void PostLoad()
			=> E_USkeletalMeshComponent_PostLoad(this);
		
		
		/// <summary>
		/// <para>Force all bodies in this component to sleep. </para>
		/// </summary>
		public override void PutAllRigidBodiesToSleep()
			=> E_USkeletalMeshComponent_PutAllRigidBodiesToSleep(this);
		
		public override void RegisterComponentTickFunctions(bool bRegister)
			=> E_USkeletalMeshComponent_RegisterComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Scales the given vector by the world space moment of inertia. Useful for computing the torque needed to rotate an object. </para>
		/// </summary>
		public override FVector ScaleByMomentOfInertia(FVector InputVector, string BoneName)
			=> E_USkeletalMeshComponent_ScaleByMomentOfInertia(this, InputVector, BoneName);
		
		public override void SendRenderTransform_Concurrent()
			=> E_USkeletalMeshComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// <para>Change the mass scale used fo all bodies in this component </para>
		/// </summary>
		public override void SetAllMassScale(float InMassScale)
			=> E_USkeletalMeshComponent_SetAllMassScale(this, InMassScale);
		
		
		/// <summary>
		/// <para>Set the angular velocity of all bodies in this component. </para>
		/// <param name="NewAngVel">New angular velocity to apply to physics, in degrees per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies. </param>
		/// </summary>
		public override void SetAllPhysicsAngularVelocity(FVector NewAngVel, bool bAddToCurrent)
			=> E_USkeletalMeshComponent_SetAllPhysicsAngularVelocity(this, NewAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the angular velocity of all bodies in this component. </para>
		/// <param name="NewAngVel">New angular velocity to apply to physics, in radians per second. </param>
		/// <param name="bAddToCurrent">If true, NewAngVel is added to the existing angular velocity of all bodies. </param>
		/// </summary>
		public override void SetAllPhysicsAngularVelocityInRadians(FVector NewAngVel, bool bAddToCurrent)
			=> E_USkeletalMeshComponent_SetAllPhysicsAngularVelocityInRadians(this, NewAngVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the linear velocity of all bodies in this component. </para>
		/// <param name="NewVel">New linear velocity to apply to physics. </param>
		/// <param name="bAddToCurrent">If true, NewVel is added to the existing velocity of the body. </param>
		/// </summary>
		public override void SetAllPhysicsLinearVelocity(FVector NewVel, bool bAddToCurrent)
			=> E_USkeletalMeshComponent_SetAllPhysicsLinearVelocity(this, NewVel, bAddToCurrent);
		
		
		/// <summary>
		/// <para>Set the position of all bodies in this component. </para>
		/// <para>If a SkeletalMeshComponent, the root body will be placed at the desired position, and the same delta is applied to all other bodies. </para>
		/// <param name="NewPos">New position for the body </param>
		/// </summary>
		public override void SetAllPhysicsPosition(FVector NewPos)
			=> E_USkeletalMeshComponent_SetAllPhysicsPosition(this, NewPos);
		
		
		/// <summary>
		/// <para>Set whether all bodies in this component should use Continuous Collision Detection </para>
		/// </summary>
		public override void SetAllUseCCD(bool InUseCCD)
			=> E_USkeletalMeshComponent_SetAllUseCCD(this, InUseCCD);
		
		
		/// <summary>
		/// <para>Sets the angular damping of this component. </para>
		/// </summary>
		public override void SetAngularDamping(float InDamping)
			=> E_USkeletalMeshComponent_SetAngularDamping(this, InDamping);
		
		
		/// <summary>
		/// <para>Changes the collision channel that this object uses when it moves </para>
		/// <param name="Channel">The new channel for this component to use </param>
		/// </summary>
		public override void SetCollisionObjectType(ECollisionChannel Channel)
			=> E_USkeletalMeshComponent_SetCollisionObjectType(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Set Collision Profile Name </para>
		/// <para>This function is called by constructors when they set ProfileName </para>
		/// <para>This will change current CollisionProfileName to be this, and overwrite Collision Setting </para>
		/// <param name="InCollisionProfileName">New Profile Name </param>
		/// </summary>
		public override void SetCollisionProfileName(string InCollisionProfileName)
			=> E_USkeletalMeshComponent_SetCollisionProfileName(this, InCollisionProfileName);
		
		
		/// <summary>
		/// <para>Changes all ResponseToChannels container for this PrimitiveComponent. to be NewResponse </para>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public override void SetCollisionResponseToAllChannels(ECollisionResponse NewResponse)
			=> E_USkeletalMeshComponent_SetCollisionResponseToAllChannels(this, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Changes a member of the ResponseToChannels container for this PrimitiveComponent. </para>
		/// <param name="Channel">The channel to change the response of </param>
		/// <param name="NewResponse">What the new response should be to the supplied Channel </param>
		/// </summary>
		public override void SetCollisionResponseToChannel(ECollisionChannel Channel, ECollisionResponse NewResponse)
			=> E_USkeletalMeshComponent_SetCollisionResponseToChannel(this, (byte)Channel, (byte)NewResponse);
		
		
		/// <summary>
		/// <para>Changes the whole ResponseToChannels container for this PrimitiveComponent. </para>
		/// <param name="NewResponses">New set of responses for this component </param>
		/// </summary>
		public override void SetCollisionResponseToChannels(FCollisionResponseContainer NewReponses)
			=> E_USkeletalMeshComponent_SetCollisionResponseToChannels(this, NewReponses);
		
		
		/// <summary>
		/// <para>Enables/disables whether this component is affected by gravity. This applies only to components with bSimulatePhysics set to true. </para>
		/// </summary>
		public override void SetEnableGravity(bool bGravityEnabled)
			=> E_USkeletalMeshComponent_SetEnableGravity(this, bGravityEnabled);
		
		
		/// <summary>
		/// <para>Sets the linear damping of this component. </para>
		/// </summary>
		public override void SetLinearDamping(float InDamping)
			=> E_USkeletalMeshComponent_SetLinearDamping(this, InDamping);
		
		
		/// <summary>
		/// <para>Override the mass (in Kg) of a single physics body. </para>
		/// <para>Note that in the case where multiple bodies are attached together, the override mass will be set for the entire group. </para>
		/// <para>Set the Override Mass to false if you want to reset the body's mass to the auto-calculated physx mass. </para>
		/// </summary>
		public override void SetMassOverrideInKg(string BoneName, float MassInKg, bool bOverrideMass)
			=> E_USkeletalMeshComponent_SetMassOverrideInKg(this, BoneName, MassInKg, bOverrideMass);
		
		
		/// <summary>
		/// <para>Change the mass scale used to calculate the mass of a single physics body </para>
		/// </summary>
		public override void SetMassScale(string BoneName, float InMassScale)
			=> E_USkeletalMeshComponent_SetMassScale(this, BoneName, InMassScale);
		
		
		/// <summary>
		/// <para>Changes the value of bNotifyRigidBodyCollision </para>
		/// <param name="bNewNotifyRigidBodyCollision">The value to assign to bNotifyRigidBodyCollision </param>
		/// </summary>
		public override void SetNotifyRigidBodyCollision(bool bNewNotifyRigidBodyCollision)
			=> E_USkeletalMeshComponent_SetNotifyRigidBodyCollision(this, bNewNotifyRigidBodyCollision);
		
		
		/// <summary>
		/// <para>Sets whether or not a single body should use physics simulation, or should be 'fixed' (kinematic). </para>
		/// <para>Note that if this component is currently attached to something, beginning simulation will detach it. </para>
		/// <param name="bSimulate">New simulation state for single body </param>
		/// </summary>
		public override void SetSimulatePhysics(bool bSimulate)
			=> E_USkeletalMeshComponent_SetSimulatePhysics(this, bSimulate);
		
		
		/// <summary>
		/// <para>Set whether this component should use Continuous Collision Detection </para>
		/// </summary>
		public override void SetUseCCD(bool InUseCCD, string BoneName)
			=> E_USkeletalMeshComponent_SetUseCCD(this, InUseCCD, BoneName);
		
		public override bool ShouldCreatePhysicsState()
			=> E_USkeletalMeshComponent_ShouldCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Determines whether the proxy for this primitive type needs to be recreated whenever the primitive moves. </para>
		/// <return>true to recreate the proxy when UpdateTransform is called. </return>
		/// </summary>
		public override bool ShouldRecreateProxyOnUpdateTransform()
			=> E_USkeletalMeshComponent_ShouldRecreateProxyOnUpdateTransform(this);
		
		
		/// <summary>
		/// <return>true if the owner is selected and this component is selectable </return>
		/// </summary>
		public override bool ShouldRenderSelected()
			=> E_USkeletalMeshComponent_ShouldRenderSelected(this);
		
		
		/// <summary>
		/// <para>Whether the component type supports static lighting. </para>
		/// </summary>
		protected override bool SupportsStaticLighting()
			=> E_USkeletalMeshComponent_SupportsStaticLighting(this);
		
		
		/// <summary>
		/// <para>Unwelds the children of this component. Attachment is maintained </para>
		/// </summary>
		public override void UnWeldChildren()
			=> E_USkeletalMeshComponent_UnWeldChildren(this);
		
		
		/// <summary>
		/// <para>UnWelds this component from its parent component. Attachment is maintained (DetachFromParent automatically unwelds) </para>
		/// </summary>
		public override void UnWeldFromParent()
			=> E_USkeletalMeshComponent_UnWeldFromParent(this);
		
		
		/// <summary>
		/// <para>Internal function that updates physics objects to match the component collision settings. </para>
		/// </summary>
		protected override void UpdatePhysicsToRBChannels()
			=> E_USkeletalMeshComponent_UpdatePhysicsToRBChannels(this);
		
		
		/// <summary>
		/// <para>Update current physics volume for this component, if bShouldUpdatePhysicsVolume is true. Overridden to use the overlaps to find the physics volume. </para>
		/// </summary>
		public override void UpdatePhysicsVolume(bool bTriggerNotifiers)
			=> E_USkeletalMeshComponent_UpdatePhysicsVolume(this, bTriggerNotifiers);
		
		
		/// <summary>
		/// <return>true if only unlit materials are used for rendering, false otherwise. </return>
		/// </summary>
		public override bool UsesOnlyUnlitMaterials()
			=> E_USkeletalMeshComponent_UsesOnlyUnlitMaterials(this);
		
		
		/// <summary>
		/// <para>Ensure simulation is running for all bodies in this component. </para>
		/// </summary>
		public override void WakeAllRigidBodies()
			=> E_USkeletalMeshComponent_WakeAllRigidBodies(this);
		
		
		/// <summary>
		/// <para>'Wake' physics simulation for a single body. </para>
		/// <param name="BoneName">If a SkeletalMeshComponent, name of body to wake. 'None' indicates root body. </param>
		/// </summary>
		public override void WakeRigidBody(string BoneName)
			=> E_USkeletalMeshComponent_WakeRigidBody(this, BoneName);
		
		
		/// <summary>
		/// <para>Welds this component to another scene component, optionally at a named socket. Component is automatically attached if not already </para>
		/// <para>Welding allows the child physics object to become physically connected to its parent. This is useful for creating compound rigid bodies with correct mass distribution. </para>
		/// <param name="InParent">the component to be physically attached to </param>
		/// <param name="InSocketName">optional socket to attach component to </param>
		/// </summary>
		public override void WeldTo(USceneComponent InParent, string InSocketName)
			=> E_USkeletalMeshComponent_WeldTo(this, InParent, InSocketName);
		
		
		/// <summary>
		/// <para>Does the actual work for welding. </para>
		/// <return>true if did a true weld of shapes, meaning body initialization is not needed </return>
		/// </summary>
		public override bool WeldToImplementation(USceneComponent InParent, string ParentSocketName, bool bWeldSimulatedChild)
			=> E_USkeletalMeshComponent_WeldToImplementation(this, InParent, ParentSocketName, bWeldSimulatedChild);
		
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_USkeletalMeshComponent_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		
		/// <summary>
		/// <para>Calculate the axis-aligned bounding cylinder of the component (radius in X-Y, half-height along Z axis). </para>
		/// <para>Default behavior is just a cylinder around the box of the cached BoxSphereBounds. </para>
		/// </summary>
		public override void CalcBoundingCylinder(float CylinderRadius, float CylinderHalfHeight)
			=> E_USkeletalMeshComponent_CalcBoundingCylinder(this, CylinderRadius, CylinderHalfHeight);
		
		
		/// <summary>
		/// <para>Called to see if it's possible to attach another scene component as a child. </para>
		/// <para>Note: This can be called on template component as well! </para>
		/// </summary>
		public override bool CanAttachAsChild(USceneComponent ChildComponent, string SocketName)
			=> E_USkeletalMeshComponent_CanAttachAsChild(this, ChildComponent, SocketName);
		
		public override void DestroyComponent(bool bPromoteChildren)
			=> E_USkeletalMeshComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="DetachmentRules">How to handle transforms & modification when detaching. </param>
		/// </summary>
		public override void DetachFromComponent(FDetachmentTransformRules DetachmentRules)
			=> E_USkeletalMeshComponent_DetachFromComponent(this, DetachmentRules);
		
		
		/// <summary>
		/// <para>Detach this component from whatever it is attached to. Automatically unwelds components that are welded together (See WeldTo) </para>
		/// <param name="bMaintainWorldPosition">If true, update the relative location of the component to keep its world position the same </param>
		/// <param name="bCallModify">If true, call Modify() on the component and the current attach parent component </param>
		/// </summary>
		public override void DetachFromParentDeprecated(bool bMaintainWorldPosition, bool bCallModify)
			=> E_USkeletalMeshComponent_DetachFromParent(this, bMaintainWorldPosition, bCallModify);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone location. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FVector GetSocketLocation(string InSocketName)
			=> E_USkeletalMeshComponent_GetSocketLocation(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone FQuat rotation. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FQuat GetSocketQuaternion(string InSocketName)
			=> E_USkeletalMeshComponent_GetSocketQuaternion(this, InSocketName);
		
		
		/// <summary>
		/// <para>Get world-space socket or bone  FRotator rotation. </para>
		/// <param name="InSocketName">Name of the socket or the bone to get the transform </param>
		/// <return>Socket transform in world space if socket if found. Otherwise it will return component's transform in world space. </return>
		/// </summary>
		public override FRotator GetSocketRotation(string InSocketName)
			=> E_USkeletalMeshComponent_GetSocketRotation(this, InSocketName);
		
		
		/// <summary>
		/// <para>Returns whether the specified body is currently using physics simulation </para>
		/// </summary>
		public override bool IsAnySimulatingPhysics()
			=> E_USkeletalMeshComponent_IsAnySimulatingPhysics(this);
		
		public override bool IsPrecomputedLightingValid()
			=> E_USkeletalMeshComponent_IsPrecomputedLightingValid(this);
		
		
		/// <summary>
		/// <para>Is this component visible or not in game </para>
		/// <return>true if visible </return>
		/// </summary>
		public override bool IsVisible()
			=> E_USkeletalMeshComponent_IsVisible(this);
		
		
		/// <summary>
		/// <para>Return true if visible in editor </para>
		/// </summary>
		public override bool IsVisibleInEditor()
			=> E_USkeletalMeshComponent_IsVisibleInEditor(this);
		
		
		/// <summary>
		/// <para>Called after a child scene component is attached to this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildAttached(USceneComponent ChildComponent)
			=> E_USkeletalMeshComponent_OnChildAttached(this, ChildComponent);
		
		
		/// <summary>
		/// <para>Called after a child scene component is detached from this component. </para>
		/// <para>Note: Do not change the attachment state of the child during this call. </para>
		/// </summary>
		protected override void OnChildDetached(USceneComponent ChildComponent)
			=> E_USkeletalMeshComponent_OnChildDetached(this, ChildComponent);
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the hidden in game value of the component. </para>
		/// </summary>
		protected override void OnHiddenInGameChanged()
			=> E_USkeletalMeshComponent_OnHiddenInGameChanged(this);
		
		
		/// <summary>
		/// <para>Overridable internal function to respond to changes in the visibility of the component. </para>
		/// </summary>
		protected override void OnVisibilityChanged()
			=> E_USkeletalMeshComponent_OnVisibilityChanged(this);
		
		public override void PostNetReceive()
			=> E_USkeletalMeshComponent_PostNetReceive(this);
		
		public override void PostRepNotifies()
			=> E_USkeletalMeshComponent_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Stack of current movement scopes. </para>
		/// </summary>
		public override void PreNetReceive()
			=> E_USkeletalMeshComponent_PreNetReceive(this);
		
		public override void PropagateLightingScenarioChange()
			=> E_USkeletalMeshComponent_PropagateLightingScenarioChange(this);
		
		
		/// <summary>
		/// <para>Set the non-uniform scale of the component relative to its parent </para>
		/// </summary>
		public override void SetRelativeScale3D(FVector NewScale3D)
			=> E_USkeletalMeshComponent_SetRelativeScale3D(this, NewScale3D);
		
		
		/// <summary>
		/// <para>If true, bounds should be used when placing component/actor in level. Does not affect spawning. </para>
		/// </summary>
		public override bool ShouldCollideWhenPlacing()
			=> E_USkeletalMeshComponent_ShouldCollideWhenPlacing(this);
		
		
		/// <summary>
		/// <para>Return true if CreateRenderState() should be called </para>
		/// </summary>
		public override bool ShouldCreateRenderState()
			=> E_USkeletalMeshComponent_ShouldCreateRenderState(this);
		
		
		/// <summary>
		/// <para>Activates the SceneComponent </para>
		/// <param name="bReset">The value to assign to HiddenGame. </param>
		/// </summary>
		public override void Activate(bool bReset)
			=> E_USkeletalMeshComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_USkeletalMeshComponent_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_USkeletalMeshComponent_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Deactivates the SceneComponent. </para>
		/// </summary>
		public override void Deactivate()
			=> E_USkeletalMeshComponent_Deactivate(this);
		
		public override bool GetComponentClassCanReplicate()
			=> E_USkeletalMeshComponent_GetComponentClassCanReplicate(this);
		
		
		/// <summary>
		/// <para>Returns a readable name for this component, including the asset name if applicable </para>
		/// <para>By default this appends a space plus AdditionalStatObject() </para>
		/// </summary>
		public override string GetReadableName()
			=> E_USkeletalMeshComponent_GetReadableName(this);
		
		
		/// <summary>
		/// <para>Initializes the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components in the level will be Initialized on load before any Actor/Component gets BeginPlay </para>
		/// <para>Requires component to be registered, and bWantsInitializeComponent to be true. </para>
		/// </summary>
		public override void InitializeComponent()
			=> E_USkeletalMeshComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// <para>Returns whether the component is active or not </para>
		/// <return>The active state of the component. </return>
		/// </summary>
		public override bool IsActive()
			=> E_USkeletalMeshComponent_IsActive(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_USkeletalMeshComponent_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Overridable check for a component to indicate to its Owner that it should prevent the Actor from auto destroying when finished </para>
		/// </summary>
		public override bool IsReadyForOwnerToAutoDestroy()
			=> E_USkeletalMeshComponent_IsReadyForOwnerToAutoDestroy(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_USkeletalMeshComponent_IsSupportedForNetworking(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_USkeletalMeshComponent_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_USkeletalMeshComponent_NeedsLoadForEditorGame(this);
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public override void OnComponentCreated()
			=> E_USkeletalMeshComponent_OnComponentCreated(this);
		
		public override void PostInitProperties()
			=> E_USkeletalMeshComponent_PostInitProperties(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_USkeletalMeshComponent_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_USkeletalMeshComponent_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_USkeletalMeshComponent_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame updates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameUpdates()
			=> E_USkeletalMeshComponent_RequiresGameThreadEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// </summary>
		public override void SetActive(bool bNewActive, bool bReset)
			=> E_USkeletalMeshComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public override void SetAutoActivate(bool bNewAutoActivate)
			=> E_USkeletalMeshComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabled(bool bEnabled)
			=> E_USkeletalMeshComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabledAsync(bool bEnabled)
			=> E_USkeletalMeshComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// <para>"Trigger" related function. Return true if it should activate </para>
		/// </summary>
		protected override bool ShouldActivate()
			=> E_USkeletalMeshComponent_ShouldActivate(this);
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public override void ToggleActive()
			=> E_USkeletalMeshComponent_ToggleActive(this);
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent()
			=> E_USkeletalMeshComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_USkeletalMeshComponent_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public override bool CheckDefaultSubobjectsInternal()
			=> E_USkeletalMeshComponent_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_USkeletalMeshComponent_GetDesc(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_USkeletalMeshComponent_IsAsset(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_USkeletalMeshComponent_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_USkeletalMeshComponent_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_USkeletalMeshComponent_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_USkeletalMeshComponent_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_USkeletalMeshComponent_Modify(this, bAlwaysMarkDirty);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_USkeletalMeshComponent_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_USkeletalMeshComponent_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_USkeletalMeshComponent_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_USkeletalMeshComponent_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_USkeletalMeshComponent_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_USkeletalMeshComponent_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_USkeletalMeshComponent_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_USkeletalMeshComponent_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public override bool CanBeInCluster()
			=> E_USkeletalMeshComponent_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_USkeletalMeshComponent_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_USkeletalMeshComponent_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(USkeletalMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USkeletalMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkeletalMeshComponent>(PtrDesc);
		}}}
