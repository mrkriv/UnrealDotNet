using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:156

namespace UnrealEngine
{
	public  partial class UCharacterMovementComponent : UPawnMovementComponent
	{
		public UCharacterMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UCharacterMovementComponent(UObject Parent = null, string Name = "CharacterMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCharacterMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCharacterMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_AirControl_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_AirControl_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_AirControlBoostMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_AirControlBoostMultiplier_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_AirControlBoostVelocityThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_AirControlBoostVelocityThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_AvoidanceConsiderationRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_AvoidanceConsiderationRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCharacterMovementComponent_AvoidanceUID_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_AvoidanceUID_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_AvoidanceWeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_AvoidanceWeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_BrakingDecelerationFalling_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_BrakingDecelerationFalling_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_BrakingDecelerationFlying_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_BrakingDecelerationFlying_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_BrakingDecelerationSwimming_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_BrakingDecelerationSwimming_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_BrakingDecelerationWalking_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_BrakingDecelerationWalking_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_BrakingFriction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_BrakingFriction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_BrakingFrictionFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_BrakingFrictionFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_Buoyancy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_Buoyancy_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_CrouchedSpeedMultiplier_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_CrouchedSpeedMultiplier_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_CurrentFloor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_CurrentFloor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_CustomMovementMode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_CustomMovementMode_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UCharacterMovementComponent_DeferredUpdatedMoveComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_DeferredUpdatedMoveComponent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_FallingLateralFriction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_FallingLateralFriction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_GravityScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_GravityScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_GroundFriction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_GroundFriction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_InitialPushForceFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_InitialPushForceFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_JumpOffJumpZFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_JumpOffJumpZFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_JumpOutOfWaterPitch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_JumpOutOfWaterPitch_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_JumpZVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_JumpZVelocity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_LedgeCheckThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_LedgeCheckThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothLocationTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothLocationTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothRotationTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothRotationTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_Mass_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_Mass_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxAcceleration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxAcceleration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxCustomMovementSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxCustomMovementSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometry_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometry_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometryAsProxy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometryAsProxy_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawn_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawn_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawnAsProxy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawnAsProxy_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxFlySpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxFlySpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxOutOfWaterStepHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxOutOfWaterStepHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UCharacterMovementComponent_MaxSimulationIterations_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxSimulationIterations_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxSimulationTimeStep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxSimulationTimeStep_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxStepHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxStepHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxSwimSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxSwimSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxTouchForce_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxTouchForce_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxWalkSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxWalkSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MaxWalkSpeedCrouched_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MaxWalkSpeedCrouched_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MinAnalogWalkSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MinAnalogWalkSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MinTimeBetweenTimeStampResets_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MinTimeBetweenTimeStampResets_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_MinTouchForce_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_MinTouchForce_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleDown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleDown_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleUp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleUp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NavMeshProjectionInterpSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NavMeshProjectionInterpSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NavMeshProjectionInterval_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NavMeshProjectionInterval_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NavMeshProjectionTimer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NavMeshProjectionTimer_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NavWalkingFloorDistTolerance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NavWalkingFloorDistTolerance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetProxyShrinkHalfHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetProxyShrinkHalfHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetProxyShrinkRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetProxyShrinkRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetworkLargeClientCorrectionDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetworkLargeClientCorrectionDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetworkMaxSmoothUpdateDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetworkMaxSmoothUpdateDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAckGoodMoves_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAckGoodMoves_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustments_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustments_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetworkNoSmoothUpdateDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetworkNoSmoothUpdateDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothLocationTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothLocationTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothRotationTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothRotationTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_NetworkSmoothingMode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_NetworkSmoothingMode_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_OldBaseLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_OldBaseLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_OldBaseQuat_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_OldBaseQuat_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_OutofWaterZ_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_OutofWaterZ_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_PendingLaunchVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_PendingLaunchVelocity_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_PerchAdditionalHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_PerchAdditionalHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_PerchRadiusThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_PerchRadiusThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_PushForceFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_PushForceFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_PushForcePointZOffsetFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_PushForcePointZOffsetFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_RepulsionForce_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_RepulsionForce_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_RequestedVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_RequestedVelocity_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_RotationRate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_RotationRate_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_StandingDownwardForceScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_StandingDownwardForceScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_TouchForceFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_TouchForceFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_UpperImpactNormalScale_DEPRECATED_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_UpperImpactNormalScale_DEPRECATED_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AddForce(IntPtr Self, IntPtr Force);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AddImpulse(IntPtr Self, IntPtr Impulse, bool bVelocityChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AddRadialForce(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AddRadialImpulse(IntPtr Self, IntPtr Origin, float Radius, float Strength, byte Falloff, bool bVelChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AdjustFloorHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AdjustProxyCapsuleSize(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyAccumulatedForces(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyDownwardForce(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyImpactPhysicsForces(IntPtr Self, IntPtr Impact, IntPtr ImpactAcceleration, IntPtr ImpactVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyNetworkMovementMode(IntPtr Self, byte ReceivedMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyRepulsionForce(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ApplyRequestedMove(IntPtr Self, float DeltaTime, float MaxAccel, float MaxSpeed, float Friction, float BrakingDeceleration, IntPtr OutAcceleration, float OutRequestedSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyVelocityBraking(IntPtr Self, float DeltaTime, float Friction, float BrakingDeceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_BoostAirControl(IntPtr Self, float DeltaTime, float TickAirControl, IntPtr FallAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_CalcVelocity(IntPtr Self, float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_CallMovementUpdateDelegate(IntPtr Self, float DeltaSeconds, IntPtr OldLocation, IntPtr OldVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanCrouchInCurrentState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanStartPathFollowing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanStepUp(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanStopPathFollowing(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanWalkOffLedges(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_CapsuleTouched(IntPtr Self, IntPtr OverlappedComp, IntPtr Other, IntPtr OtherComp, int OtherBodyIndex, bool bFromSweep, IntPtr SweepResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CheckFall(IntPtr Self, IntPtr OldFloor, IntPtr Hit, IntPtr Delta, IntPtr OldLocation, float remainingTime, float timeTick, int Iterations, bool bMustJump);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CheckLedgeDirection(IntPtr Self, IntPtr OldLocation, IntPtr SideStep, IntPtr GravDir);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CheckWaterJump(IntPtr Self, IntPtr CheckPoint, IntPtr WallNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClearAccumulatedForces(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAckGoodMove(IntPtr Self, float TimeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAckGoodMove_Implementation(IntPtr Self, float TimeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAdjustPosition(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewVel, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAdjustPosition_Implementation(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewVel, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ClientUpdatePositionAfterServerUpdate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientVeryShortAdjustPosition(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientVeryShortAdjustPosition_Implementation(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_ComputeAnalogInputModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ComputeFloorDist(IntPtr Self, IntPtr CapsuleLocation, float LineDistance, float SweepDistance, IntPtr OutFloorResult, float SweepRadius, IntPtr DownwardSweepResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ComputeGroundMovementDelta(IntPtr Self, IntPtr Delta, IntPtr RampHit, bool bHitFromLineTrace);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ComputeOrientToMovementRotation(IntPtr Self, IntPtr CurrentRotation, float DeltaTime, IntPtr DeltaRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ComputePerchResult(IntPtr Self, float TestRadius, IntPtr InHit, float InMaxFloorDist, IntPtr OutPerchFloorResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ComputeSlideVector(IntPtr Self, IntPtr Delta, float Time, IntPtr Normal, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ConstrainInputAcceleration(IntPtr Self, IntPtr InputAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_Crouch(IntPtr Self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_Deactivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_DisableMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_DoJump(IntPtr Self, bool bReplayingMoves);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_FindBestNavMeshLocation(IntPtr Self, IntPtr TraceStart, IntPtr TraceEnd, IntPtr CurrentFeetLocation, IntPtr TargetNavLocation, IntPtr OutHitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_FindFloor(IntPtr Self, IntPtr CapsuleLocation, IntPtr OutFloorResult, bool bZeroDelta, IntPtr DownwardSweepResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_FindWaterLine(IntPtr Self, IntPtr Start, IntPtr End);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ForceClientAdjustment(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ForcePositionUpdate(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ForceReplicationUpdate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetAirControl(IntPtr Self, float DeltaTime, float TickAirControl, IntPtr FallAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetAnalogInputModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetBestDirectionOffActor(IntPtr Self, IntPtr BaseActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UCharacterMovementComponent_GetCharacterOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetCurrentAcceleration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetDeltaRotation(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetFallingLateralAcceleration(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetGravityZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UCharacterMovementComponent_GetGroundMovementMode(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetImpartedMovementBaseVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetLedgeMove(IntPtr Self, IntPtr OldLocation, IntPtr Delta, IntPtr GravDir);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxAcceleration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxBrakingDeceleration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxJumpHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxJumpHeightWithJumpTime(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMinAnalogSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetModifiedMaxAcceleration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UCharacterMovementComponent_GetMovementBase(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UCharacterMovementComponent_GetMovementName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetNetworkSafeRandomAngleDegrees(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetPathFollowingBrakingDistance(IntPtr Self, float MaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetPenetrationAdjustment(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetPerchRadiusThreshold(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetServerLastTransformUpdateTimeStamp(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetSimulationTimeStep(IntPtr Self, float RemainingTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetValidPerchRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetWalkableFloorAngle(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetWalkableFloorZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_HandleImpact(IntPtr Self, IntPtr Hit, float TimeSlice, IntPtr MoveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_HandlePendingLaunch(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_HandleSlopeBoosting(IntPtr Self, IntPtr SlideResult, IntPtr Delta, float Time, IntPtr Normal, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_HandleSwimmingWallHit(IntPtr Self, IntPtr Hit, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_HasPredictionData_Client(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_HasPredictionData_Server(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_HasRootMotionSources(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_HasValidData(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_ImmersionDepth(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsCrouching(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsFalling(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsFlying(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsMovementInProgress(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsMovingOnGround(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsSwimming(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsValidLandingSpot(IntPtr Self, IntPtr CapsuleLocation, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsWalkable(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsWalking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsWithinEdgeTolerance(IntPtr Self, IntPtr CapsuleLocation, IntPtr TestImpactPoint, float CapsuleRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_JumpOff(IntPtr Self, IntPtr MovementBaseActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_JumpOutOfWater(IntPtr Self, IntPtr WallNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_K2_ComputeFloorDist(IntPtr Self, IntPtr CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius, IntPtr FloorResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_K2_FindFloor(IntPtr Self, IntPtr CapsuleLocation, IntPtr FloorResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_K2_GetModifiedMaxAcceleration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_K2_GetWalkableFloorAngle(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_K2_GetWalkableFloorZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_Launch(IntPtr Self, IntPtr LaunchVel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_LimitAirControl(IntPtr Self, float DeltaTime, IntPtr FallAcceleration, IntPtr HitResult, bool bCheckForValidLandingSpot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MaintainHorizontalGroundVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MaybeSaveBaseLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MaybeUpdateBasedMovement(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MoveAutonomous(IntPtr Self, float ClientTimeStamp, float DeltaTime, byte CompressedFlags, IntPtr NewAccel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_NewFallVelocity(IntPtr Self, IntPtr InitialVelocity, IntPtr Gravity, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_NotifyBumpedPawn(IntPtr Self, IntPtr BumpedPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_NotifyJumpApex(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnCharacterStuckInGeometry(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnClientTimeStampResetDetected(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnMovementModeChanged(IntPtr Self, byte PreviousMovementMode, byte PreviousCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnMovementUpdated(IntPtr Self, float DeltaSeconds, IntPtr OldLocation, IntPtr OldVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnRegister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnTeleported(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnTimeDiscrepancyDetected(IntPtr Self, float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnUnableToFollowBaseMove(IntPtr Self, IntPtr DeltaPosition, IntPtr OldLocation, IntPtr MoveOnBaseHit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UCharacterMovementComponent_PackNetworkMovementMode(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PerformAirControlForPathFollowing(IntPtr Self, IntPtr Direction, float ZDiff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PerformMovement(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysCustom(IntPtr Self, float deltaTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysFalling(IntPtr Self, float deltaTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysFlying(IntPtr Self, float deltaTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysicsRotation(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysNavWalking(IntPtr Self, float deltaTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysSwimming(IntPtr Self, float deltaTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysWalking(IntPtr Self, float deltaTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ProcessLanded(IntPtr Self, IntPtr Hit, float remainingTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ProjectLocationFromNavMesh(IntPtr Self, float DeltaSeconds, IntPtr CurrentFeetLocation, IntPtr TargetNavLocation, float UpOffset, float DownOffset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_RegisterComponentTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_RemoveRootMotionSource(IntPtr Self, string InstanceName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ReplicateMoveToServer(IntPtr Self, float DeltaTime, IntPtr NewAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_RequestDirectMove(IntPtr Self, IntPtr MoveVelocity, bool bForceMaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_RequestPathMove(IntPtr Self, IntPtr MoveInput);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ResetPredictionData_Client(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ResetPredictionData_Server(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ResolvePenetrationImpl(IntPtr Self, IntPtr Adjustment, IntPtr Hit, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_RevertMove(IntPtr Self, IntPtr OldLocation, IntPtr OldBase, IntPtr InOldBaseLocation, IntPtr OldFloor, bool bFailMove);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_RoundAcceleration(IntPtr Self, IntPtr InAccel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SaveBaseLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ScaleInputAcceleration(IntPtr Self, IntPtr InputAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SendClientAdjustment(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ServerCheckClientError(IntPtr Self, float ClientTimeStamp, float DeltaTime, IntPtr Accel, IntPtr ClientWorldLocation, IntPtr RelativeClientLocation, IntPtr ClientMovementBase, string ClientBaseBoneName, byte ClientMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ServerMoveHandleClientError(IntPtr Self, float ClientTimeStamp, float DeltaTime, IntPtr Accel, IntPtr RelativeClientLocation, IntPtr ClientMovementBase, string ClientBaseBoneName, byte ClientMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetAvoidanceEnabled(IntPtr Self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetAvoidanceGroup(IntPtr Self, int GroupFlags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetBase(IntPtr Self, IntPtr NewBase, string BoneName, bool bNotifyActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetBaseFromFloor(IntPtr Self, IntPtr FloorResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetDefaultMovementMode(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetGroundMovementMode(IntPtr Self, byte NewGroundMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetGroupsToAvoid(IntPtr Self, int GroupFlags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetGroupsToIgnore(IntPtr Self, int GroupFlags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetMovementMode(IntPtr Self, byte NewMovementMode, byte NewCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetNavWalkingPhysics(IntPtr Self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetPostLandedPhysics(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetUpdatedComponent(IntPtr Self, IntPtr NewUpdatedComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetWalkableFloorAngle(IntPtr Self, float InWalkableFloorAngle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetWalkableFloorZ(IntPtr Self, float InWalkableFloorZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldCancelAdaptiveReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldCatchAir(IntPtr Self, IntPtr OldFloor, IntPtr NewFloor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldCheckForValidLandingSpot(IntPtr Self, float DeltaTime, IntPtr Delta, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldComputePerchResult(IntPtr Self, IntPtr InHit, bool bCheckRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldJumpOutOfWater(IntPtr Self, IntPtr JumpDir);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldRemainVertical(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SimulatedTick(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SimulateMovement(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_SlideAlongSurface(IntPtr Self, IntPtr Delta, float Time, IntPtr Normal, IntPtr Hit, bool bHandleImpact);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SmoothClientPosition(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SmoothClientPosition_Interpolate(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SmoothClientPosition_UpdateVisuals(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SmoothCorrection(IntPtr Self, IntPtr OldLocation, IntPtr OldRotation, IntPtr NewLocation, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_StartFalling(IntPtr Self, int Iterations, float remainingTime, float timeTick, IntPtr Delta, IntPtr subLoc);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_StartNewPhysics(IntPtr Self, float deltaTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_StartSwimming(IntPtr Self, IntPtr OldLocation, IntPtr OldVelocity, float timeTick, float remainingTime, int Iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_StopActiveMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_Swim(IntPtr Self, IntPtr Delta, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_TickCharacterPose(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_TryToLeaveNavWalking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_TwoWallAdjust(IntPtr Self, IntPtr Delta, IntPtr Hit, IntPtr OldHitNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UnCrouch(IntPtr Self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateBasedMovement(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateBasedRotation(IntPtr Self, IntPtr FinalRotation, IntPtr ReducedRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateCharacterStateAfterMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateCharacterStateBeforeMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateFloorFromAdjustment(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateFromCompressedFlags(IntPtr Self, byte Flags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_VisualizeMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AddInputVector(IntPtr Self, IntPtr WorldVector, bool bForce);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ConsumeInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsMoveInputIgnored(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetActorFeetLocationBased(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_StopMovementImmediately(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ConstrainDirectionToPlane(IntPtr Self, IntPtr Direction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ConstrainLocationToPlane(IntPtr Self, IntPtr Location);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ConstrainNormalToPlane(IntPtr Self, IntPtr Normal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxSpeedModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetModifiedMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_InitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsExceedingMaxSpeed(IntPtr Self, float MaxSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsInWater(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_K2_GetMaxSpeedModifier(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_K2_GetModifiedMaxSpeed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_MoveUpdatedComponentImpl(IntPtr Self, IntPtr Delta, IntPtr NewRotation, bool bSweep, IntPtr OutHit, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetPlaneConstraintAxisSetting(IntPtr Self, byte NewAxisSetting);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetPlaneConstraintEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetPlaneConstraintFromVectors(IntPtr Self, IntPtr Forward, IntPtr Up);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetPlaneConstraintNormal(IntPtr Self, IntPtr PlaneNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetPlaneConstraintOrigin(IntPtr Self, IntPtr PlaneOrigin);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldSkipUpdate(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SnapUpdatedComponentToPlane(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateComponentVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateTickRegistration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_Activate(IntPtr Self, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_CreateRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_DestroyComponent(IntPtr Self, bool bPromoteChildren);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_DestroyRenderState_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_GetComponentClassCanReplicate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UCharacterMovementComponent_GetReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_HasValidPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_InvalidateLightingCacheDetailed(IntPtr Self, bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsNavigationRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsReadyForOwnerToAutoDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnActorEnableCollisionChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnComponentCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnComponentDestroyed(IntPtr Self, bool bDestroyingHierarchy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnDestroyPhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnUnregister(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_RequiresGameThreadEndOfFrameRecreate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_RequiresGameThreadEndOfFrameUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SendRenderDynamicData_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SendRenderTransform_Concurrent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetActive(IntPtr Self, bool bNewActive, bool bReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetAutoActivate(IntPtr Self, bool bNewAutoActivate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetComponentTickEnabled(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetComponentTickEnabledAsync(IntPtr Self, bool bEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldActivate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldCreatePhysicsState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldCreateRenderState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ToggleActive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UninitializeComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateComponentToWorld(IntPtr Self, byte UpdateTransformFlags, byte Teleport);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UCharacterMovementComponent_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UCharacterMovementComponent_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>When falling, amount of lateral movement control available to the character. </para>
		/// <para>0 = no control, 1 = full control at max speed of MaxWalkSpeed. </para>
		/// </summary>
		public float AirControl
		{
			get => E_PROP_UCharacterMovementComponent_AirControl_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AirControl_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When falling, multiplier applied to AirControl when lateral velocity is less than AirControlBoostVelocityThreshold. </para>
		/// <para>Setting this to zero will disable air control boosting. Final result is clamped at 1. </para>
		/// </summary>
		public float AirControlBoostMultiplier
		{
			get => E_PROP_UCharacterMovementComponent_AirControlBoostMultiplier_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AirControlBoostMultiplier_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When falling, if lateral velocity magnitude is less than this value, AirControl is multiplied by AirControlBoostMultiplier. </para>
		/// <para>Setting this to zero will disable air control boosting. </para>
		/// </summary>
		public float AirControlBoostVelocityThreshold
		{
			get => E_PROP_UCharacterMovementComponent_AirControlBoostVelocityThreshold_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AirControlBoostVelocityThreshold_SET(NativePointer, value);
		}

		public float AvoidanceConsiderationRadius
		{
			get => E_PROP_UCharacterMovementComponent_AvoidanceConsiderationRadius_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AvoidanceConsiderationRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>No default value, for now it's assumed to be valid if GetAvoidanceManager() returns non-NULL. </para>
		/// </summary>
		public int AvoidanceUID
		{
			get => E_PROP_UCharacterMovementComponent_AvoidanceUID_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AvoidanceUID_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>De facto default value 0.5 (due to that being the default in the avoidance registration function), indicates RVO behavior. </para>
		/// </summary>
		public float AvoidanceWeight
		{
			get => E_PROP_UCharacterMovementComponent_AvoidanceWeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AvoidanceWeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If enabled, the player will interact with physics objects when walking into them. </para>
		/// </summary>
		public bool bEnablePhysicsInteraction
		{
			get => E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If enabled, the PushForceFactor is applied per kg mass of the affected object. </para>
		/// </summary>
		public bool bPushForceScaledToMass
		{
			get => E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If enabled, the PushForce location is moved using PushForcePointZOffsetFactor. Otherwise simply use the impact point. </para>
		/// </summary>
		public bool bPushForceUsingZOffset
		{
			get => E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Lateral deceleration when falling and not applying acceleration. </para>
		/// <para>@see MaxAcceleration </para>
		/// </summary>
		public float BrakingDecelerationFalling
		{
			get => E_PROP_UCharacterMovementComponent_BrakingDecelerationFalling_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingDecelerationFalling_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Deceleration when flying and not applying acceleration. </para>
		/// <para>@see MaxAcceleration </para>
		/// </summary>
		public float BrakingDecelerationFlying
		{
			get => E_PROP_UCharacterMovementComponent_BrakingDecelerationFlying_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingDecelerationFlying_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Deceleration when swimming and not applying acceleration. </para>
		/// <para>@see MaxAcceleration </para>
		/// </summary>
		public float BrakingDecelerationSwimming
		{
			get => E_PROP_UCharacterMovementComponent_BrakingDecelerationSwimming_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingDecelerationSwimming_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Deceleration when walking and not applying acceleration. This is a constant opposing force that directly lowers velocity by a constant value. </para>
		/// <para>@see GroundFriction, MaxAcceleration </para>
		/// </summary>
		public float BrakingDecelerationWalking
		{
			get => E_PROP_UCharacterMovementComponent_BrakingDecelerationWalking_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingDecelerationWalking_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Friction (drag) coefficient applied when braking (whenever Acceleration = 0, or if character is exceeding max speed); actual value used is this multiplied by BrakingFrictionFactor. </para>
		/// <para>When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity. </para>
		/// <para>Braking is composed of friction (velocity-dependent drag) and constant deceleration. </para>
		/// <para>This is the current value, used in all movement modes; if this is not desired, override it or bUseSeparateBrakingFriction when movement mode changes. </para>
		/// <para>@note Only used if bUseSeparateBrakingFriction setting is true, otherwise current friction such as GroundFriction is used. </para>
		/// <para>@see bUseSeparateBrakingFriction, BrakingFrictionFactor, GroundFriction, BrakingDecelerationWalking </para>
		/// </summary>
		public float BrakingFriction
		{
			get => E_PROP_UCharacterMovementComponent_BrakingFriction_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingFriction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Factor used to multiply actual value of friction used when braking. </para>
		/// <para>This applies to any friction value that is currently used, which may depend on bUseSeparateBrakingFriction. </para>
		/// <para>@note This is 2 by default for historical reasons, a value of 1 gives the true drag equation. </para>
		/// <para>@see bUseSeparateBrakingFriction, GroundFriction, BrakingFriction </para>
		/// </summary>
		public float BrakingFrictionFactor
		{
			get => E_PROP_UCharacterMovementComponent_BrakingFrictionFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingFrictionFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If enabled, the applied push force will try to get the physics object to the same velocity than the player, not faster. This will only </para>
		/// <para>scale the force down, it will never apply more force than defined by PushForceFactor. </para>
		/// </summary>
		public bool bScalePushForceToVelocity
		{
			get => E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If enabled, the TouchForceFactor is applied per kg mass of the affected object. </para>
		/// </summary>
		public bool bTouchForceScaledToMass
		{
			get => E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Water buoyancy. A ratio (1.0 = neutral buoyancy, 0.0 = no buoyancy) </para>
		/// </summary>
		public float Buoyancy
		{
			get => E_PROP_UCharacterMovementComponent_Buoyancy_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_Buoyancy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Last valid projected hit result from raycast to geometry from navmesh </para>
		/// </summary>
		public FHitResult CachedProjectedNavMeshHitResult
		{
			get => E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Collision half-height when crouching (component scale is applied separately) </para>
		/// </summary>
		public float CrouchedHalfHeight
		{
			get => E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_SET(NativePointer, value);
		}

		public float CrouchedSpeedMultiplier_DEPRECATED
		{
			get => E_PROP_UCharacterMovementComponent_CrouchedSpeedMultiplier_DEPRECATED_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_CrouchedSpeedMultiplier_DEPRECATED_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Information about the floor the Character is standing on (updated only during walking movement). </para>
		/// </summary>
		public FFindFloorResult CurrentFloor
		{
			get => E_PROP_UCharacterMovementComponent_CurrentFloor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_CurrentFloor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Current custom sub-mode if MovementMode is set to Custom. </para>
		/// <para>This is automatically replicated through the Character owner and for client-server movement functions. </para>
		/// <para>@see SetMovementMode() </para>
		/// </summary>
		public byte CustomMovementMode
		{
			get => E_PROP_UCharacterMovementComponent_CustomMovementMode_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_CustomMovementMode_SET(NativePointer, value);
		}

		public USceneComponent DeferredUpdatedMoveComponent
		{
			get => E_PROP_UCharacterMovementComponent_DeferredUpdatedMoveComponent_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_DeferredUpdatedMoveComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Friction to apply to lateral air movement when falling. </para>
		/// <para>If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero). </para>
		/// <para>@see BrakingFriction, bUseSeparateBrakingFriction </para>
		/// </summary>
		public float FallingLateralFriction
		{
			get => E_PROP_UCharacterMovementComponent_FallingLateralFriction_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_FallingLateralFriction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Custom gravity scale. Gravity is multiplied by this amount for the character. </para>
		/// </summary>
		public float GravityScale
		{
			get => E_PROP_UCharacterMovementComponent_GravityScale_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_GravityScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Setting that affects movement control. Higher values allow faster changes in direction. </para>
		/// <para>If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero), where it is multiplied by BrakingFrictionFactor. </para>
		/// <para>When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity. </para>
		/// <para>This can be used to simulate slippery surfaces such as ice or oil by changing the value (possibly based on the material pawn is standing on). </para>
		/// <para>@see BrakingDecelerationWalking, BrakingFriction, bUseSeparateBrakingFriction, BrakingFrictionFactor </para>
		/// </summary>
		public float GroundFriction
		{
			get => E_PROP_UCharacterMovementComponent_GroundFriction_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_GroundFriction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Initial impulse force to apply when the player bounces into a blocking physics object. </para>
		/// </summary>
		public float InitialPushForceFactor
		{
			get => E_PROP_UCharacterMovementComponent_InitialPushForceFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_InitialPushForceFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Fraction of JumpZVelocity to use when automatically "jumping off" of a base actor that's not allowed to be a base for a character. (For example, if you're not allowed to stand on other players.) </para>
		/// </summary>
		public float JumpOffJumpZFactor
		{
			get => E_PROP_UCharacterMovementComponent_JumpOffJumpZFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_JumpOffJumpZFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When exiting water, jump if control pitch angle is this high or above. </para>
		/// </summary>
		public float JumpOutOfWaterPitch
		{
			get => E_PROP_UCharacterMovementComponent_JumpOutOfWaterPitch_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_JumpOutOfWaterPitch_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Initial velocity (instantaneous vertical acceleration) when jumping. </para>
		/// </summary>
		public float JumpZVelocity
		{
			get => E_PROP_UCharacterMovementComponent_JumpZVelocity_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_JumpZVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Used in determining if pawn is going off ledge.  If the ledge is "shorter" than this value then the pawn will be able to walk off it. </para>
		/// </summary>
		public float LedgeCheckThreshold
		{
			get => E_PROP_UCharacterMovementComponent_LedgeCheckThreshold_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_LedgeCheckThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Similar setting as NetworkSimulatedSmoothLocationTime but only used on Listen servers. </para>
		/// </summary>
		public float ListenServerNetworkSimulatedSmoothLocationTime
		{
			get => E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothLocationTime_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothLocationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Similar setting as NetworkSimulatedSmoothRotationTime but only used on Listen servers. </para>
		/// </summary>
		public float ListenServerNetworkSimulatedSmoothRotationTime
		{
			get => E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothRotationTime_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothRotationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Mass of pawn (for when momentum is imparted to it). </para>
		/// </summary>
		public float Mass
		{
			get => E_PROP_UCharacterMovementComponent_Mass_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_Mass_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max Acceleration (rate of change of velocity) </para>
		/// </summary>
		public float MaxAcceleration
		{
			get => E_PROP_UCharacterMovementComponent_MaxAcceleration_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxAcceleration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The maximum speed when using Custom movement mode. </para>
		/// </summary>
		public float MaxCustomMovementSpeed
		{
			get => E_PROP_UCharacterMovementComponent_MaxCustomMovementSpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxCustomMovementSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns. </para>
		/// <para>This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server. </para>
		/// <para>@see MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawn, MaxDepenetrationWithPawnAsProxy </para>
		/// </summary>
		public float MaxDepenetrationWithGeometry
		{
			get => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometry_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometry_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns. </para>
		/// <para>This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server. </para>
		/// <para>@see MaxDepenetrationWithGeometry, MaxDepenetrationWithPawn, MaxDepenetrationWithPawnAsProxy </para>
		/// </summary>
		public float MaxDepenetrationWithGeometryAsProxy
		{
			get => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometryAsProxy_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometryAsProxy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max distance we are allowed to depenetrate when moving out of other Pawns. </para>
		/// <para>@see MaxDepenetrationWithGeometry, MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawnAsProxy </para>
		/// </summary>
		public float MaxDepenetrationWithPawn
		{
			get => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawn_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawn_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max distance we allow simulated proxies to depenetrate when moving out of other Pawns. </para>
		/// <para>Typically we don't want a large value, because we receive a server authoritative position that we should not then ignore by pushing them out of the local player. </para>
		/// <para>@see MaxDepenetrationWithGeometry, MaxDepenetrationWithGeometryAsProxy, MaxDepenetrationWithPawn </para>
		/// </summary>
		public float MaxDepenetrationWithPawnAsProxy
		{
			get => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawnAsProxy_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawnAsProxy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The maximum flying speed. </para>
		/// </summary>
		public float MaxFlySpeed
		{
			get => E_PROP_UCharacterMovementComponent_MaxFlySpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxFlySpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Maximum step height for getting out of water </para>
		/// </summary>
		public float MaxOutOfWaterStepHeight
		{
			get => E_PROP_UCharacterMovementComponent_MaxOutOfWaterStepHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxOutOfWaterStepHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max number of iterations used for each discrete simulation step. </para>
		/// <para>Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking). </para>
		/// <para>Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance. </para>
		/// <para>WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation. </para>
		/// <para>@see MaxSimulationTimeStep </para>
		/// </summary>
		public int MaxSimulationIterations
		{
			get => E_PROP_UCharacterMovementComponent_MaxSimulationIterations_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxSimulationIterations_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Max time delta for each discrete simulation step. </para>
		/// <para>Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking). </para>
		/// <para>Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance. </para>
		/// <para>WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation. </para>
		/// <para>@see MaxSimulationIterations </para>
		/// </summary>
		public float MaxSimulationTimeStep
		{
			get => E_PROP_UCharacterMovementComponent_MaxSimulationTimeStep_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxSimulationTimeStep_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Maximum height character can step up </para>
		/// </summary>
		public float MaxStepHeight
		{
			get => E_PROP_UCharacterMovementComponent_MaxStepHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxStepHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The maximum swimming speed. </para>
		/// </summary>
		public float MaxSwimSpeed
		{
			get => E_PROP_UCharacterMovementComponent_MaxSwimSpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxSwimSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Maximum force applied to touched physics objects. If < 0.0f, there is no maximum. </para>
		/// </summary>
		public float MaxTouchForce
		{
			get => E_PROP_UCharacterMovementComponent_MaxTouchForce_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxTouchForce_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The maximum ground speed when walking. Also determines maximum lateral speed when falling. </para>
		/// </summary>
		public float MaxWalkSpeed
		{
			get => E_PROP_UCharacterMovementComponent_MaxWalkSpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxWalkSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The maximum ground speed when walking and crouched. </para>
		/// </summary>
		public float MaxWalkSpeedCrouched
		{
			get => E_PROP_UCharacterMovementComponent_MaxWalkSpeedCrouched_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxWalkSpeedCrouched_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The ground speed that we should accelerate up to when walking at minimum analog stick tilt </para>
		/// </summary>
		public float MinAnalogWalkSpeed
		{
			get => E_PROP_UCharacterMovementComponent_MinAnalogWalkSpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MinAnalogWalkSpeed_SET(NativePointer, value);
		}

		public float MinTimeBetweenTimeStampResets
		{
			get => E_PROP_UCharacterMovementComponent_MinTimeBetweenTimeStampResets_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MinTimeBetweenTimeStampResets_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Minimum Force applied to touched physics objects. If < 0.0f, there is no minimum. </para>
		/// </summary>
		public float MinTouchForce
		{
			get => E_PROP_UCharacterMovementComponent_MinTouchForce_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MinTouchForce_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Scale of the total capsule height to use for projection from navmesh to underlying geometry in the downward direction. </para>
		/// <para>In other words, trace down to [CapsuleHeight * NavMeshProjectionHeightScaleDown] below nav mesh. </para>
		/// </summary>
		public float NavMeshProjectionHeightScaleDown
		{
			get => E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleDown_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleDown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Scale of the total capsule height to use for projection from navmesh to underlying geometry in the upward direction. </para>
		/// <para>In other words, start the trace at [CapsuleHeight * NavMeshProjectionHeightScaleUp] above nav mesh. </para>
		/// </summary>
		public float NavMeshProjectionHeightScaleUp
		{
			get => E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleUp_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleUp_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Speed at which to interpolate agent navmesh offset between traces. 0: Instant (no interp) > 0: Interp speed") </para>
		/// </summary>
		public float NavMeshProjectionInterpSpeed
		{
			get => E_PROP_UCharacterMovementComponent_NavMeshProjectionInterpSpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavMeshProjectionInterpSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>How often we should raycast to project from navmesh to underlying geometry </para>
		/// </summary>
		public float NavMeshProjectionInterval
		{
			get => E_PROP_UCharacterMovementComponent_NavMeshProjectionInterval_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavMeshProjectionInterval_SET(NativePointer, value);
		}

		public float NavMeshProjectionTimer
		{
			get => E_PROP_UCharacterMovementComponent_NavMeshProjectionTimer_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavMeshProjectionTimer_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Ignore small differences in ground height between server and client data during NavWalking mode </para>
		/// </summary>
		public float NavWalkingFloorDistTolerance
		{
			get => E_PROP_UCharacterMovementComponent_NavWalkingFloorDistTolerance_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavWalkingFloorDistTolerance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Shrink simulated proxy capsule half height by this amount, to account for network rounding that may cause encroachment. Changing during gameplay is not supported. </para>
		/// <para>@see AdjustProxyCapsuleSize() </para>
		/// </summary>
		public float NetProxyShrinkHalfHeight
		{
			get => E_PROP_UCharacterMovementComponent_NetProxyShrinkHalfHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetProxyShrinkHalfHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Shrink simulated proxy capsule radius by this amount, to account for network rounding that may cause encroachment. Changing during gameplay is not supported. </para>
		/// <para>@see AdjustProxyCapsuleSize() </para>
		/// </summary>
		public float NetProxyShrinkRadius
		{
			get => E_PROP_UCharacterMovementComponent_NetProxyShrinkRadius_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetProxyShrinkRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If client error is larger than this, sets bNetworkLargeClientCorrection to reduce delay between client adjustments. </para>
		/// <para>@see NetworkMinTimeBetweenClientAdjustments, NetworkMinTimeBetweenClientAdjustmentsLargeCorrection </para>
		/// </summary>
		public float NetworkLargeClientCorrectionDistance
		{
			get => E_PROP_UCharacterMovementComponent_NetworkLargeClientCorrectionDistance_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkLargeClientCorrectionDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Maximum distance character is allowed to lag behind server location when interpolating between updates. </para>
		/// </summary>
		public float NetworkMaxSmoothUpdateDistance
		{
			get => E_PROP_UCharacterMovementComponent_NetworkMaxSmoothUpdateDistance_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkMaxSmoothUpdateDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Minimum time on the server between acknowledging good client moves. This can save on bandwidth. Set to 0 to disable throttling. </para>
		/// </summary>
		public float NetworkMinTimeBetweenClientAckGoodMoves
		{
			get => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAckGoodMoves_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAckGoodMoves_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Minimum time on the server between sending client adjustments when client has exceeded allowable position error. </para>
		/// <para>Should be >= NetworkMinTimeBetweenClientAdjustmentsLargeCorrection (the larger value is used regardless). </para>
		/// <para>This can save on bandwidth. Set to 0 to disable throttling. </para>
		/// <para>@see ServerLastClientAdjustmentTime </para>
		/// </summary>
		public float NetworkMinTimeBetweenClientAdjustments
		{
			get => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustments_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustments_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Minimum time on the server between sending client adjustments when client has exceeded allowable position error by a large amount (NetworkLargeClientCorrectionDistance). </para>
		/// <para>Should be <= NetworkMinTimeBetweenClientAdjustments (the smaller value is used regardless). </para>
		/// <para>@see NetworkMinTimeBetweenClientAdjustments </para>
		/// </summary>
		public float NetworkMinTimeBetweenClientAdjustmentsLargeCorrection
		{
			get => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Maximum distance beyond which character is teleported to the new server location without any smoothing. </para>
		/// </summary>
		public float NetworkNoSmoothUpdateDistance
		{
			get => E_PROP_UCharacterMovementComponent_NetworkNoSmoothUpdateDistance_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkNoSmoothUpdateDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>How long to take to smoothly interpolate from the old pawn position on the client to the corrected one sent by the server. Not used by Linear smoothing. </para>
		/// </summary>
		public float NetworkSimulatedSmoothLocationTime
		{
			get => E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothLocationTime_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothLocationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>How long to take to smoothly interpolate from the old pawn rotation on the client to the corrected one sent by the server. Not used by Linear smoothing. </para>
		/// </summary>
		public float NetworkSimulatedSmoothRotationTime
		{
			get => E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothRotationTime_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothRotationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Smoothing mode for simulated proxies in network game. </para>
		/// </summary>
		public ENetworkSmoothingMode NetworkSmoothingMode
		{
			get => (ENetworkSmoothingMode)E_PROP_UCharacterMovementComponent_NetworkSmoothingMode_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkSmoothingMode_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Saved location of object we are standing on, for UpdateBasedMovement() to determine if base moved in the last frame, and therefore pawn needs an update. </para>
		/// </summary>
		public FVector OldBaseLocation
		{
			get => E_PROP_UCharacterMovementComponent_OldBaseLocation_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_OldBaseLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Saved location of object we are standing on, for UpdateBasedMovement() to determine if base moved in the last frame, and therefore pawn needs an update. </para>
		/// </summary>
		public FQuat OldBaseQuat
		{
			get => E_PROP_UCharacterMovementComponent_OldBaseQuat_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_OldBaseQuat_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Z velocity applied when pawn tries to get out of water </para>
		/// </summary>
		public float OutofWaterZ
		{
			get => E_PROP_UCharacterMovementComponent_OutofWaterZ_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_OutofWaterZ_SET(NativePointer, value);
		}

		public FVector PendingLaunchVelocity
		{
			get => E_PROP_UCharacterMovementComponent_PendingLaunchVelocity_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_PendingLaunchVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When perching on a ledge, add this additional distance to MaxStepHeight when determining how high above a walkable floor we can perch. </para>
		/// <para>Note that we still enforce MaxStepHeight to start the step up; this just allows the character to hang off the edge or step slightly higher off the floor. </para>
		/// <para>(@see PerchRadiusThreshold) </para>
		/// </summary>
		public float PerchAdditionalHeight
		{
			get => E_PROP_UCharacterMovementComponent_PerchAdditionalHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_PerchAdditionalHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Don't allow the character to perch on the edge of a surface if the contact is this close to the edge of the capsule. </para>
		/// <para>Note that characters will not fall off if they are within MaxStepHeight of a walkable surface below. </para>
		/// </summary>
		public float PerchRadiusThreshold
		{
			get => E_PROP_UCharacterMovementComponent_PerchRadiusThreshold_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_PerchRadiusThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Force to apply when the player collides with a blocking physics object. </para>
		/// </summary>
		public float PushForceFactor
		{
			get => E_PROP_UCharacterMovementComponent_PushForceFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_PushForceFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Z-Offset for the position the force is applied to. 0.0f is the center of the physics object, 1.0f is the top and -1.0f is the bottom of the object. </para>
		/// </summary>
		public float PushForcePointZOffsetFactor
		{
			get => E_PROP_UCharacterMovementComponent_PushForcePointZOffsetFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_PushForcePointZOffsetFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Force per kg applied constantly to all overlapping components. </para>
		/// </summary>
		public float RepulsionForce
		{
			get => E_PROP_UCharacterMovementComponent_RepulsionForce_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_RepulsionForce_SET(NativePointer, value);
		}

		public FVector RequestedVelocity
		{
			get => E_PROP_UCharacterMovementComponent_RequestedVelocity_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_RequestedVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Change in rotation per second, used when UseControllerDesiredRotation or OrientRotationToMovement are true. Set a negative value for infinite rotation rate and instant turns. </para>
		/// </summary>
		public FRotator RotationRate
		{
			get => E_PROP_UCharacterMovementComponent_RotationRate_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_RotationRate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Force applied to objects we stand on (due to Mass and Gravity) is scaled by this amount. </para>
		/// </summary>
		public float StandingDownwardForceScale
		{
			get => E_PROP_UCharacterMovementComponent_StandingDownwardForceScale_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_StandingDownwardForceScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Force to apply to physics objects that are touched by the player. </para>
		/// </summary>
		public float TouchForceFactor
		{
			get => E_PROP_UCharacterMovementComponent_TouchForceFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_TouchForceFactor_SET(NativePointer, value);
		}

		public float UpperImpactNormalScale_DEPRECATED
		{
			get => E_PROP_UCharacterMovementComponent_UpperImpactNormalScale_DEPRECATED_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_UpperImpactNormalScale_DEPRECATED_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add force to character. Forces are accumulated each tick and applied together </para>
		/// <para>so multiple calls to this function will accumulate. </para>
		/// <para>Forces are scaled depending on timestep, so they can be applied each frame. If you want an </para>
		/// <para>instantaneous force, use AddImpulse. </para>
		/// <para>Adding a force always takes the actor's mass into account. </para>
		/// <para>Note that changing the momentum of characters like this can change the movement mode. </para>
		/// <param name="Force">Force to apply. </param>
		/// </summary>
		public virtual void AddForce(FVector Force)
			=> E_UCharacterMovementComponent_AddForce(this, Force);
		
		
		/// <summary>
		/// <para>Add impulse to character. Impulses are accumulated each tick and applied together </para>
		/// <para>so multiple calls to this function will accumulate. </para>
		/// <para>An impulse is an instantaneous force, usually applied once. If you want to continually apply </para>
		/// <para>forces each frame, use AddForce(). </para>
		/// <para>Note that changing the momentum of characters like this can change the movement mode. </para>
		/// <param name="Impulse">Impulse to apply. </param>
		/// <param name="bVelocityChange">Whether or not the impulse is relative to mass. </param>
		/// </summary>
		public virtual void AddImpulse(FVector Impulse, bool bVelocityChange)
			=> E_UCharacterMovementComponent_AddImpulse(this, Impulse, bVelocityChange);
		
		public override void AddRadialForce(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff)
			=> E_UCharacterMovementComponent_AddRadialForce(this, Origin, Radius, Strength, (byte)Falloff);
		
		public override void AddRadialImpulse(FVector Origin, float Radius, float Strength, ERadialImpulseFalloff Falloff, bool bVelChange)
			=> E_UCharacterMovementComponent_AddRadialImpulse(this, Origin, Radius, Strength, (byte)Falloff, bVelChange);
		
		
		/// <summary>
		/// <para>Adjust distance from floor, trying to maintain a slight offset from the floor when walking (based on CurrentFloor). </para>
		/// </summary>
		public virtual void AdjustFloorHeight()
			=> E_UCharacterMovementComponent_AdjustFloorHeight(this);
		
		
		/// <summary>
		/// <para>Adjust the size of the capsule on simulated proxies, to avoid overlaps due to replication rounding. </para>
		/// <para>Changes to the capsule size on the proxy should set bShrinkProxyCapsule=true and possibly call AdjustProxyCapsuleSize() immediately if applicable. </para>
		/// </summary>
		protected virtual void AdjustProxyCapsuleSize()
			=> E_UCharacterMovementComponent_AdjustProxyCapsuleSize(this);
		
		
		/// <summary>
		/// <para>Applies momentum accumulated through AddImpulse() and AddForce(), then clears those forces. Does *not* use ClearAccumulatedForces() since that would clear pending launch velocity as well. </para>
		/// </summary>
		public virtual void ApplyAccumulatedForces(float DeltaSeconds)
			=> E_UCharacterMovementComponent_ApplyAccumulatedForces(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Applies downward force when walking on top of physics objects. </para>
		/// <param name="DeltaSeconds">Time elapsed since last frame. </param>
		/// </summary>
		public virtual void ApplyDownwardForce(float DeltaSeconds)
			=> E_UCharacterMovementComponent_ApplyDownwardForce(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Apply physics forces to the impacted component, if bEnablePhysicsInteraction is true. </para>
		/// <param name="Impact">HitResult that resulted in the impact </param>
		/// <param name="ImpactAcceleration">Acceleration of the character at the time of impact </param>
		/// <param name="ImpactVelocity">Velocity of the character at the time of impact </param>
		/// </summary>
		protected virtual void ApplyImpactPhysicsForces(FHitResult Impact, FVector ImpactAcceleration, FVector ImpactVelocity)
			=> E_UCharacterMovementComponent_ApplyImpactPhysicsForces(this, Impact, ImpactAcceleration, ImpactVelocity);
		
		public virtual void ApplyNetworkMovementMode(byte ReceivedMode)
			=> E_UCharacterMovementComponent_ApplyNetworkMovementMode(this, ReceivedMode);
		
		
		/// <summary>
		/// <para>Applies repulsion force to all touched components. </para>
		/// </summary>
		public virtual void ApplyRepulsionForce(float DeltaSeconds)
			=> E_UCharacterMovementComponent_ApplyRepulsionForce(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Use velocity requested by path following to compute a requested acceleration and speed. </para>
		/// <para>This does not affect the Acceleration member variable, as that is used to indicate input acceleration. </para>
		/// <para>This may directly affect current Velocity. </para>
		/// <param name="DeltaTime">Time slice for this operation </param>
		/// <param name="MaxAccel">Max acceleration allowed in OutAcceleration result. </param>
		/// <param name="MaxSpeed">Max speed allowed when computing OutRequestedSpeed. </param>
		/// <param name="Friction">Current friction. </param>
		/// <param name="BrakingDeceleration">Current braking deceleration. </param>
		/// <param name="OutAcceleration">Acceleration computed based on requested velocity. </param>
		/// <param name="OutRequestedSpeed">Speed of resulting velocity request, which can affect the max speed allowed by movement. </param>
		/// <return>Whether there is a requested velocity and acceleration, resulting in valid OutAcceleration and OutRequestedSpeed values. </return>
		/// </summary>
		public virtual bool ApplyRequestedMove(float DeltaTime, float MaxAccel, float MaxSpeed, float Friction, float BrakingDeceleration, FVector OutAcceleration, float OutRequestedSpeed)
			=> E_UCharacterMovementComponent_ApplyRequestedMove(this, DeltaTime, MaxAccel, MaxSpeed, Friction, BrakingDeceleration, OutAcceleration, OutRequestedSpeed);
		
		
		/// <summary>
		/// <para>Slows towards stop. </para>
		/// </summary>
		protected virtual void ApplyVelocityBraking(float DeltaTime, float Friction, float BrakingDeceleration)
			=> E_UCharacterMovementComponent_ApplyVelocityBraking(this, DeltaTime, Friction, BrakingDeceleration);
		
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_UCharacterMovementComponent_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		public override void BeginDestroy()
			=> E_UCharacterMovementComponent_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Increase air control if conditions of AirControlBoostMultiplier and AirControlBoostVelocityThreshold are met. </para>
		/// <para>This function is used internally by GetAirControl(). </para>
		/// <param name="DeltaTime">Time step for the current update. </param>
		/// <param name="TickAirControl">Current air control value. </param>
		/// <param name="FallAcceleration">Acceleration used during movement. </param>
		/// <return>Modified air control to use during falling movement </return>
		/// <para>@see GetAirControl() </para>
		/// </summary>
		protected virtual float BoostAirControl(float DeltaTime, float TickAirControl, FVector FallAcceleration)
			=> E_UCharacterMovementComponent_BoostAirControl(this, DeltaTime, TickAirControl, FallAcceleration);
		
		
		/// <summary>
		/// <para>Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity. </para>
		/// <para>This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes. </para>
		/// <param name="DeltaTime">time elapsed since last frame. </param>
		/// <param name="Friction">coefficient of friction when not accelerating, or in the direction opposite acceleration. </param>
		/// <param name="bFluid">true if moving through a fluid, causing Friction to always be applied regardless of acceleration. </param>
		/// <param name="BrakingDeceleration">deceleration applied when not accelerating, or when exceeding max velocity. </param>
		/// </summary>
		public virtual void CalcVelocity(float DeltaTime, float Friction, bool bFluid, float BrakingDeceleration)
			=> E_UCharacterMovementComponent_CalcVelocity(this, DeltaTime, Friction, bFluid, BrakingDeceleration);
		
		
		/// <summary>
		/// <para>Internal function to call OnMovementUpdated delegate on CharacterOwner. </para>
		/// </summary>
		protected virtual void CallMovementUpdateDelegate(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
			=> E_UCharacterMovementComponent_CallMovementUpdateDelegate(this, DeltaSeconds, OldLocation, OldVelocity);
		
		
		/// <summary>
		/// <return>true if the character is allowed to crouch in the current state. By default it is allowed when walking or falling, if CanEverCrouch() is true. </return>
		/// </summary>
		public virtual bool CanCrouchInCurrentState()
			=> E_UCharacterMovementComponent_CanCrouchInCurrentState(this);
		
		public override bool CanStartPathFollowing()
			=> E_UCharacterMovementComponent_CanStartPathFollowing(this);
		
		
		/// <summary>
		/// <return>true if we can step up on the actor in the given FHitResult. </return>
		/// </summary>
		public virtual bool CanStepUp(FHitResult Hit)
			=> E_UCharacterMovementComponent_CanStepUp(this, Hit);
		
		public override bool CanStopPathFollowing()
			=> E_UCharacterMovementComponent_CanStopPathFollowing(this);
		
		
		/// <summary>
		/// <return>whether this pawn is currently allowed to walk off ledges </return>
		/// </summary>
		public virtual bool CanWalkOffLedges()
			=> E_UCharacterMovementComponent_CanWalkOffLedges(this);
		
		protected virtual void CapsuleTouched(UPrimitiveComponent OverlappedComp, AActor Other, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult SweepResult)
			=> E_UCharacterMovementComponent_CapsuleTouched(this, OverlappedComp, Other, OtherComp, OtherBodyIndex, bFromSweep, SweepResult);
		
		
		/// <summary>
		/// <para>Check if pawn is falling </para>
		/// </summary>
		public virtual bool CheckFall(FFindFloorResult OldFloor, FHitResult Hit, FVector Delta, FVector OldLocation, float remainingTime, float timeTick, int Iterations, bool bMustJump)
			=> E_UCharacterMovementComponent_CheckFall(this, OldFloor, Hit, Delta, OldLocation, remainingTime, timeTick, Iterations, bMustJump);
		
		
		/// <summary>
		/// <return>true if there is a suitable floor SideStep from current position. </return>
		/// </summary>
		public virtual bool CheckLedgeDirection(FVector OldLocation, FVector SideStep, FVector GravDir)
			=> E_UCharacterMovementComponent_CheckLedgeDirection(this, OldLocation, SideStep, GravDir);
		
		
		/// <summary>
		/// <para>Check if swimming pawn just ran into edge of the pool and should jump out. </para>
		/// </summary>
		public virtual bool CheckWaterJump(FVector CheckPoint, FVector WallNormal)
			=> E_UCharacterMovementComponent_CheckWaterJump(this, CheckPoint, WallNormal);
		
		
		/// <summary>
		/// <para>Clears forces accumulated through AddImpulse() and AddForce(), and also pending launch velocity. </para>
		/// </summary>
		public virtual void ClearAccumulatedForces()
			=> E_UCharacterMovementComponent_ClearAccumulatedForces(this);
		
		
		/// <summary>
		/// <para>If no client adjustment is needed after processing received ServerMove(), ack the good move so client can remove it from SavedMoves </para>
		/// </summary>
		public virtual void ClientAckGoodMove(float TimeStamp)
			=> E_UCharacterMovementComponent_ClientAckGoodMove(this, TimeStamp);
		
		public virtual void ClientAckGoodMove_Implementation(float TimeStamp)
			=> E_UCharacterMovementComponent_ClientAckGoodMove_Implementation(this, TimeStamp);
		
		
		/// <summary>
		/// <para>Replicate position correction to client, associated with a timestamped servermove.  Client will replay subsequent moves after applying adjustment. </para>
		/// </summary>
		public virtual void ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustPosition(this, TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		public virtual void ClientAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustPosition_Implementation(this, TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		
		/// <summary>
		/// <para>If bUpdatePosition is true, then replay any unacked moves. Returns whether any moves were actually replayed. </para>
		/// </summary>
		protected virtual bool ClientUpdatePositionAfterServerUpdate()
			=> E_UCharacterMovementComponent_ClientUpdatePositionAfterServerUpdate(this);
		
		public virtual void ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_UCharacterMovementComponent_ClientVeryShortAdjustPosition(this, TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		public virtual void ClientVeryShortAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_UCharacterMovementComponent_ClientVeryShortAdjustPosition_Implementation(this, TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		
		/// <summary>
		/// <para>Computes the analog input modifier based on current input vector and/or acceleration. </para>
		/// </summary>
		protected virtual float ComputeAnalogInputModifier()
			=> E_UCharacterMovementComponent_ComputeAnalogInputModifier(this);
		
		
		/// <summary>
		/// <para>Compute distance to the floor from bottom sphere of capsule and store the result in OutFloorResult. </para>
		/// <para>This distance is the swept distance of the capsule to the first point impacted by the lower hemisphere, or distance from the bottom of the capsule in the case of a line trace. </para>
		/// <para>This function does not care if collision is disabled on the capsule (unlike FindFloor). </para>
		/// <para>@see FindFloor </para>
		/// <param name="CapsuleLocation">Location of the capsule used for the query </param>
		/// <param name="LineDistance">If non-zero, max distance to test for a simple line check from the capsule base. Used only if the sweep test fails to find a walkable floor, and only returns a valid result if the impact normal is a walkable normal. </param>
		/// <param name="SweepDistance">If non-zero, max distance to use when sweeping a capsule downwards for the test. MUST be greater than or equal to the line distance. </param>
		/// <param name="OutFloorResult">Result of the floor check. The HitResult will contain the valid sweep or line test upon success, or the result of the sweep upon failure. </param>
		/// <param name="SweepRadius">The radius to use for sweep tests. Should be <= capsule radius. </param>
		/// <param name="DownwardSweepResult">If non-null and it contains valid blocking hit info, this will be used as the result of a downward sweep test instead of doing it as part of the update. </param>
		/// </summary>
		public virtual void ComputeFloorDist(FVector CapsuleLocation, float LineDistance, float SweepDistance, FFindFloorResult OutFloorResult, float SweepRadius, FHitResult DownwardSweepResult)
			=> E_UCharacterMovementComponent_ComputeFloorDist(this, CapsuleLocation, LineDistance, SweepDistance, OutFloorResult, SweepRadius, DownwardSweepResult);
		
		
		/// <summary>
		/// <para>Compute a vector of movement, given a delta and a hit result of the surface we are on. </para>
		/// <param name="Delta">Attempted movement direction </param>
		/// <param name="RampHit">Hit result of sweep that found the ramp below the capsule </param>
		/// <param name="bHitFromLineTrace">Whether the floor trace came from a line trace </param>
		/// <return>If on a walkable surface, this returns a vector that moves parallel to the surface. The magnitude may be scaled if bMaintainHorizontalGroundVelocity is true. </return>
		/// <para>If a ramp vector can't be computed, this will just return Delta. </para>
		/// </summary>
		protected virtual FVector ComputeGroundMovementDelta(FVector Delta, FHitResult RampHit, bool bHitFromLineTrace)
			=> E_UCharacterMovementComponent_ComputeGroundMovementDelta(this, Delta, RampHit, bHitFromLineTrace);
		
		
		/// <summary>
		/// <para>Compute a target rotation based on current movement. Used by PhysicsRotation() when bOrientRotationToMovement is true. </para>
		/// <para>Default implementation targets a rotation based on Acceleration. </para>
		/// <param name="CurrentRotation">Current rotation of the Character </param>
		/// <param name="DeltaTime">Time slice for this movement </param>
		/// <param name="DeltaRotation">Proposed rotation change based simply on DeltaTime * RotationRate </param>
		/// <return>The target rotation given current movement. </return>
		/// </summary>
		public virtual FRotator ComputeOrientToMovementRotation(FRotator CurrentRotation, float DeltaTime, FRotator DeltaRotation)
			=> E_UCharacterMovementComponent_ComputeOrientToMovementRotation(this, CurrentRotation, DeltaTime, DeltaRotation);
		
		
		/// <summary>
		/// <para>Compute the sweep result of the smaller capsule with radius specified by GetValidPerchRadius(), </para>
		/// <para>and return true if the sweep contacts a valid walkable normal within InMaxFloorDist of InHit.ImpactPoint. </para>
		/// <para>This may be used to determine if the capsule can or cannot stay at the current location if perched on the edge of a small ledge or unwalkable surface. </para>
		/// <para>Note: Only returns a valid result if ShouldComputePerchResult returned true for the supplied hit value. </para>
		/// <param name="TestRadius">Radius to use for the sweep, usually GetValidPerchRadius(). </param>
		/// <param name="InHit">Result of the last sweep test before the query. </param>
		/// <param name="InMaxFloorDist">Max distance to floor allowed by perching, from the supplied contact point (InHit.ImpactPoint). </param>
		/// <param name="OutPerchFloorResult">Contains the result of the perch floor test. </param>
		/// <return>True if the current location is a valid spot at which to perch. </return>
		/// </summary>
		public virtual bool ComputePerchResult(float TestRadius, FHitResult InHit, float InMaxFloorDist, FFindFloorResult OutPerchFloorResult)
			=> E_UCharacterMovementComponent_ComputePerchResult(this, TestRadius, InHit, InMaxFloorDist, OutPerchFloorResult);
		
		
		/// <summary>
		/// <para>Calculate slide vector along a surface. </para>
		/// <para>Has special treatment when falling, to avoid boosting up slopes (calling HandleSlopeBoosting() in this case). </para>
		/// <param name="Delta">Attempted move. </param>
		/// <param name="Time">Amount of move to apply (between 0 and 1). </param>
		/// <param name="Normal">Normal opposed to movement. Not necessarily equal to Hit.Normal (but usually is). </param>
		/// <param name="Hit">HitResult of the move that resulted in the slide. </param>
		/// <return>New deflected vector of movement. </return>
		/// </summary>
		public override FVector ComputeSlideVector(FVector Delta, float Time, FVector Normal, FHitResult Hit)
			=> E_UCharacterMovementComponent_ComputeSlideVector(this, Delta, Time, Normal, Hit);
		
		
		/// <summary>
		/// <para>Enforce constraints on input given current state. For instance, don't move upwards if walking and looking up. </para>
		/// </summary>
		protected virtual FVector ConstrainInputAcceleration(FVector InputAcceleration)
			=> E_UCharacterMovementComponent_ConstrainInputAcceleration(this, InputAcceleration);
		
		
		/// <summary>
		/// <para>Checks if new capsule size fits (no encroachment), and call CharacterOwner->OnStartCrouch() if successful. </para>
		/// <para>In general you should set bWantsToCrouch instead to have the crouch persist during movement, or just use the crouch functions on the owning Character. </para>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset. </param>
		/// </summary>
		public virtual void Crouch(bool bClientSimulation)
			=> E_UCharacterMovementComponent_Crouch(this, bClientSimulation);
		
		public override void Deactivate()
			=> E_UCharacterMovementComponent_Deactivate(this);
		
		
		/// <summary>
		/// <para>Make movement impossible (sets movement mode to MOVE_None). </para>
		/// </summary>
		public virtual void DisableMovement()
			=> E_UCharacterMovementComponent_DisableMovement(this);
		
		
		/// <summary>
		/// <para>Perform jump. Called by Character when a jump has been detected because Character->bPressedJump was true. Checks CanJump(). </para>
		/// <para>Note that you should usually trigger a jump through Character::Jump() instead. </para>
		/// <param name="bReplayingMoves">true if this is being done as part of replaying moves on a locally controlled client after a server correction. </param>
		/// <return>True if the jump was triggered successfully. </return>
		/// </summary>
		public virtual bool DoJump(bool bReplayingMoves)
			=> E_UCharacterMovementComponent_DoJump(this, bReplayingMoves);
		
		
		/// <summary>
		/// <para>Performs trace for ProjectLocationFromNavMesh </para>
		/// </summary>
		protected virtual void FindBestNavMeshLocation(FVector TraceStart, FVector TraceEnd, FVector CurrentFeetLocation, FVector TargetNavLocation, FHitResult OutHitResult)
			=> E_UCharacterMovementComponent_FindBestNavMeshLocation(this, TraceStart, TraceEnd, CurrentFeetLocation, TargetNavLocation, OutHitResult);
		
		
		/// <summary>
		/// <para>Sweeps a vertical trace to find the floor for the capsule at the given location. Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result. </para>
		/// <para>No floor will be found if collision is disabled on the capsule! </para>
		/// <param name="CapsuleLocation">Location where the capsule sweep should originate </param>
		/// <param name="OutFloorResult">Out] Contains the result of the floor check. The HitResult will contain the valid sweep or line test upon success, or the result of the sweep upon failure. </param>
		/// <param name="bZeroDelta">If true, the capsule was not actively moving in this update (can be used to avoid unnecessary floor tests). </param>
		/// <param name="DownwardSweepResult">If non-null and it contains valid blocking hit info, this will be used as the result of a downward sweep test instead of doing it as part of the update. </param>
		/// </summary>
		public virtual void FindFloor(FVector CapsuleLocation, FFindFloorResult OutFloorResult, bool bZeroDelta, FHitResult DownwardSweepResult)
			=> E_UCharacterMovementComponent_FindFloor(this, CapsuleLocation, OutFloorResult, bZeroDelta, DownwardSweepResult);
		
		
		/// <summary>
		/// <para>Get as close to waterline as possible, staying on same side as currently. </para>
		/// </summary>
		public FVector FindWaterLine(FVector Start, FVector End)
			=> E_UCharacterMovementComponent_FindWaterLine(this, Start, End);
		
		
		/// <summary>
		/// <para>Force a client adjustment. Resets ServerLastClientAdjustmentTime. </para>
		/// </summary>
		public void ForceClientAdjustment()
			=> E_UCharacterMovementComponent_ForceClientAdjustment(this);
		
		public virtual void ForcePositionUpdate(float DeltaTime)
			=> E_UCharacterMovementComponent_ForcePositionUpdate(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Force a client update by making it appear on the server that the client hasn't updated in a long time. </para>
		/// </summary>
		public virtual void ForceReplicationUpdate()
			=> E_UCharacterMovementComponent_ForceReplicationUpdate(this);
		
		
		/// <summary>
		/// <para>Get the air control to use during falling movement. </para>
		/// <para>Given an initial air control (TickAirControl), applies the result of BoostAirControl(). </para>
		/// <para>This function is used internally by GetFallingLateralAcceleration(). </para>
		/// <param name="DeltaTime">Time step for the current update. </param>
		/// <param name="TickAirControl">Current air control value. </param>
		/// <param name="FallAcceleration">Acceleration used during movement. </param>
		/// <return>Air control to use during falling movement. </return>
		/// <para>@see AirControl, BoostAirControl(), LimitAirControl(), GetFallingLateralAcceleration() </para>
		/// </summary>
		public virtual FVector GetAirControl(float DeltaTime, float TickAirControl, FVector FallAcceleration)
			=> E_UCharacterMovementComponent_GetAirControl(this, DeltaTime, TickAirControl, FallAcceleration);
		
		
		/// <summary>
		/// <return>Modifier [0..1] based on the magnitude of the last input vector, which is used to modify the acceleration and max speed during movement. </return>
		/// </summary>
		public float GetAnalogInputModifier()
			=> E_UCharacterMovementComponent_GetAnalogInputModifier(this);
		
		
		/// <summary>
		/// <para>Can be overridden to choose to jump based on character velocity, base actor dimensions, etc. </para>
		/// </summary>
		public virtual FVector GetBestDirectionOffActor(AActor BaseActor)
			=> E_UCharacterMovementComponent_GetBestDirectionOffActor(this, BaseActor);
		
		
		/// <summary>
		/// <para>Get the Character that owns UpdatedComponent. </para>
		/// </summary>
		public ACharacter GetCharacterOwner()
			=> E_UCharacterMovementComponent_GetCharacterOwner(this);
		
		
		/// <summary>
		/// <return>Current acceleration, computed from input vector each update. </return>
		/// </summary>
		public FVector GetCurrentAcceleration()
			=> E_UCharacterMovementComponent_GetCurrentAcceleration(this);
		
		
		/// <summary>
		/// <return>how far to rotate character during the time interval DeltaTime. </return>
		/// </summary>
		public virtual FRotator GetDeltaRotation(float DeltaTime)
			=> E_UCharacterMovementComponent_GetDeltaRotation(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Get the lateral acceleration to use during falling movement. The Z component of the result is ignored. </para>
		/// <para>Default implementation returns current Acceleration value modified by GetAirControl(), with Z component removed, </para>
		/// <para>with magnitude clamped to GetMaxAcceleration(). </para>
		/// <para>This function is used internally by PhysFalling(). </para>
		/// <param name="DeltaTime">Time step for the current update. </param>
		/// <return>Acceleration to use during falling movement. </return>
		/// </summary>
		public virtual FVector GetFallingLateralAcceleration(float DeltaTime)
			=> E_UCharacterMovementComponent_GetFallingLateralAcceleration(this, DeltaTime);
		
		public override float GetGravityZ()
			=> E_UCharacterMovementComponent_GetGravityZ(this);
		
		
		/// <summary>
		/// <para>Get current GroundMovementMode value. </para>
		/// <return>current GroundMovementMode </return>
		/// <para>@see GroundMovementMode, SetGroundMovementMode() </para>
		/// </summary>
		public EMovementMode GetGroundMovementMode()
			=> (EMovementMode)E_UCharacterMovementComponent_GetGroundMovementMode(this);
		
		
		/// <summary>
		/// <para>If we have a movement base, get the velocity that should be imparted by that base, usually when jumping off of it. </para>
		/// <para>Only applies the components of the velocity enabled by bImpartBaseVelocityX, bImpartBaseVelocityY, bImpartBaseVelocityZ. </para>
		/// </summary>
		public virtual FVector GetImpartedMovementBaseVelocity()
			=> E_UCharacterMovementComponent_GetImpartedMovementBaseVelocity(this);
		
		
		/// <summary>
		/// <param name="Delta">is the current move delta (which ended up going over a ledge). </param>
		/// <return>new delta which moves along the ledge </return>
		/// </summary>
		public virtual FVector GetLedgeMove(FVector OldLocation, FVector Delta, FVector GravDir)
			=> E_UCharacterMovementComponent_GetLedgeMove(this, OldLocation, Delta, GravDir);
		
		
		/// <summary>
		/// <return>Maximum acceleration for the current state. </return>
		/// </summary>
		public virtual float GetMaxAcceleration()
			=> E_UCharacterMovementComponent_GetMaxAcceleration(this);
		
		
		/// <summary>
		/// <return>Maximum deceleration for the current state when braking (ie when there is no acceleration). </return>
		/// </summary>
		public virtual float GetMaxBrakingDeceleration()
			=> E_UCharacterMovementComponent_GetMaxBrakingDeceleration(this);
		
		
		/// <summary>
		/// <para>Compute the max jump height based on the JumpZVelocity velocity and gravity. </para>
		/// <para>This does not take into account the CharacterOwner's MaxJumpHoldTime. </para>
		/// </summary>
		public virtual float GetMaxJumpHeight()
			=> E_UCharacterMovementComponent_GetMaxJumpHeight(this);
		
		
		/// <summary>
		/// <para>Compute the max jump height based on the JumpZVelocity velocity and gravity. </para>
		/// <para>This does take into account the CharacterOwner's MaxJumpHoldTime. </para>
		/// </summary>
		public virtual float GetMaxJumpHeightWithJumpTime()
			=> E_UCharacterMovementComponent_GetMaxJumpHeightWithJumpTime(this);
		
		public override float GetMaxSpeed()
			=> E_UCharacterMovementComponent_GetMaxSpeed(this);
		
		
		/// <summary>
		/// <return>Maximum acceleration for the current state. </return>
		/// </summary>
		public virtual float GetMinAnalogSpeed()
			=> E_UCharacterMovementComponent_GetMinAnalogSpeed(this);
		
		
		/// <summary>
		/// <return>Maximum acceleration for the current state, based on MaxAcceleration and any additional modifiers. </return>
		/// </summary>
		public virtual float GetModifiedMaxAcceleration()
			=> E_UCharacterMovementComponent_GetModifiedMaxAcceleration(this);
		
		
		/// <summary>
		/// <para>Return PrimitiveComponent we are based on (standing and walking on). </para>
		/// </summary>
		public UPrimitiveComponent GetMovementBase()
			=> E_UCharacterMovementComponent_GetMovementBase(this);
		
		
		/// <summary>
		/// <para>@Return MovementMode string </para>
		/// </summary>
		public virtual string GetMovementName()
			=> E_UCharacterMovementComponent_GetMovementName(this);
		
		
		/// <summary>
		/// <para>Generate a random angle in degrees that is approximately equal between client and server. </para>
		/// <para>Note that in networked games this result changes with low frequency and has a low period, </para>
		/// <para>so should not be used for frequent randomization. </para>
		/// </summary>
		public virtual float GetNetworkSafeRandomAngleDegrees()
			=> E_UCharacterMovementComponent_GetNetworkSafeRandomAngleDegrees(this);
		
		public override float GetPathFollowingBrakingDistance(float MaxSpeed)
			=> E_UCharacterMovementComponent_GetPathFollowingBrakingDistance(this, MaxSpeed);
		
		
		/// <summary>
		/// <para>Overridden to enforce max distances based on hit geometry. </para>
		/// </summary>
		public override FVector GetPenetrationAdjustment(FHitResult Hit)
			=> E_UCharacterMovementComponent_GetPenetrationAdjustment(this, Hit);
		
		
		/// <summary>
		/// <return>The distance from the edge of the capsule within which we don't allow the character to perch on the edge of a surface. </return>
		/// </summary>
		public float GetPerchRadiusThreshold()
			=> E_UCharacterMovementComponent_GetPerchRadiusThreshold(this);
		
		
		/// <summary>
		/// <para>Get the value of ServerLastTransformUpdateTimeStamp. </para>
		/// </summary>
		public float GetServerLastTransformUpdateTimeStamp()
			=> E_UCharacterMovementComponent_GetServerLastTransformUpdateTimeStamp(this);
		
		
		/// <summary>
		/// <para>Compute remaining time step given remaining time and current iterations. </para>
		/// <para>The last iteration (limited by MaxSimulationIterations) always returns the remaining time, which may violate MaxSimulationTimeStep. </para>
		/// <param name="RemainingTime">Remaining time in the tick. </param>
		/// <param name="Iterations">Current iteration of the tick (starting at 1). </param>
		/// <return>The remaining time step to use for the next sub-step of iteration. </return>
		/// <para>@see MaxSimulationTimeStep, MaxSimulationIterations </para>
		/// </summary>
		public float GetSimulationTimeStep(float RemainingTime, int Iterations)
			=> E_UCharacterMovementComponent_GetSimulationTimeStep(this, RemainingTime, Iterations);
		
		
		/// <summary>
		/// <para>Returns the radius within which we can stand on the edge of a surface without falling (if this is a walkable surface). </para>
		/// <para>Simply computed as the capsule radius minus the result of GetPerchRadiusThreshold(). </para>
		/// </summary>
		public float GetValidPerchRadius()
			=> E_UCharacterMovementComponent_GetValidPerchRadius(this);
		
		
		/// <summary>
		/// <para>Get the max angle in degrees of a walkable surface for the character. </para>
		/// </summary>
		public float GetWalkableFloorAngle()
			=> E_UCharacterMovementComponent_GetWalkableFloorAngle(this);
		
		
		/// <summary>
		/// <para>Get the Z component of the normal of the steepest walkable surface for the character. Any lower than this and it is not walkable. </para>
		/// </summary>
		public float GetWalkableFloorZ()
			=> E_UCharacterMovementComponent_GetWalkableFloorZ(this);
		
		
		/// <summary>
		/// <para>Handle a blocking impact. Calls ApplyImpactPhysicsForces for the hit, if bEnablePhysicsInteraction is true. </para>
		/// </summary>
		public override void HandleImpact(FHitResult Hit, float TimeSlice, FVector MoveDelta)
			=> E_UCharacterMovementComponent_HandleImpact(this, Hit, TimeSlice, MoveDelta);
		
		
		/// <summary>
		/// <para>Handle a pending launch during an update. Returns true if the launch was triggered. </para>
		/// </summary>
		public virtual bool HandlePendingLaunch()
			=> E_UCharacterMovementComponent_HandlePendingLaunch(this);
		
		
		/// <summary>
		/// <para>Limit the slide vector when falling if the resulting slide might boost the character faster upwards. </para>
		/// <param name="SlideResult">Vector of movement for the slide (usually the result of ComputeSlideVector) </param>
		/// <param name="Delta">Original attempted move </param>
		/// <param name="Time">Amount of move to apply (between 0 and 1). </param>
		/// <param name="Normal">Normal opposed to movement. Not necessarily equal to Hit.Normal (but usually is). </param>
		/// <param name="Hit">HitResult of the move that resulted in the slide. </param>
		/// <return>New slide result. </return>
		/// </summary>
		protected virtual FVector HandleSlopeBoosting(FVector SlideResult, FVector Delta, float Time, FVector Normal, FHitResult Hit)
			=> E_UCharacterMovementComponent_HandleSlopeBoosting(this, SlideResult, Delta, Time, Normal, Hit);
		
		protected virtual void HandleSwimmingWallHit(FHitResult Hit, float DeltaTime)
			=> E_UCharacterMovementComponent_HandleSwimmingWallHit(this, Hit, DeltaTime);
		
		public virtual bool HasPredictionData_Client()
			=> E_UCharacterMovementComponent_HasPredictionData_Client(this);
		
		public virtual bool HasPredictionData_Server()
			=> E_UCharacterMovementComponent_HasPredictionData_Server(this);
		
		
		/// <summary>
		/// <return>true if we have Root Motion from any source to use in PerformMovement() physics. </return>
		/// </summary>
		public bool HasRootMotionSources()
			=> E_UCharacterMovementComponent_HasRootMotionSources(this);
		
		
		/// <summary>
		/// <para>Return true if we have a valid CharacterOwner and UpdatedComponent. </para>
		/// </summary>
		public virtual bool HasValidData()
			=> E_UCharacterMovementComponent_HasValidData(this);
		
		public virtual float ImmersionDepth()
			=> E_UCharacterMovementComponent_ImmersionDepth(this);
		
		public override bool IsCrouching()
			=> E_UCharacterMovementComponent_IsCrouching(this);
		
		public override bool IsFalling()
			=> E_UCharacterMovementComponent_IsFalling(this);
		
		public override bool IsFlying()
			=> E_UCharacterMovementComponent_IsFlying(this);
		
		
		/// <summary>
		/// <return>true if currently performing a movement update. </return>
		/// <para>@see bMovementInProgress </para>
		/// </summary>
		public bool IsMovementInProgress()
			=> E_UCharacterMovementComponent_IsMovementInProgress(this);
		
		public override bool IsMovingOnGround()
			=> E_UCharacterMovementComponent_IsMovingOnGround(this);
		
		public override bool IsSwimming()
			=> E_UCharacterMovementComponent_IsSwimming(this);
		
		
		/// <summary>
		/// <para>Verify that the supplied hit result is a valid landing spot when falling. </para>
		/// </summary>
		public virtual bool IsValidLandingSpot(FVector CapsuleLocation, FHitResult Hit)
			=> E_UCharacterMovementComponent_IsValidLandingSpot(this, CapsuleLocation, Hit);
		
		
		/// <summary>
		/// <para>Return true if the hit result should be considered a walkable surface for the character. </para>
		/// </summary>
		public virtual bool IsWalkable(FHitResult Hit)
			=> E_UCharacterMovementComponent_IsWalkable(this, Hit);
		
		
		/// <summary>
		/// <return>true if the character is in the 'Walking' movement mode. </return>
		/// </summary>
		public bool IsWalking()
			=> E_UCharacterMovementComponent_IsWalking(this);
		
		
		/// <summary>
		/// <para>Return true if the 2D distance to the impact point is inside the edge tolerance (CapsuleRadius minus a small rejection threshold). </para>
		/// <para>Useful for rejecting adjacent hits when finding a floor or landing spot. </para>
		/// </summary>
		public virtual bool IsWithinEdgeTolerance(FVector CapsuleLocation, FVector TestImpactPoint, float CapsuleRadius)
			=> E_UCharacterMovementComponent_IsWithinEdgeTolerance(this, CapsuleLocation, TestImpactPoint, CapsuleRadius);
		
		
		/// <summary>
		/// <para>Force this pawn to bounce off its current base, which isn't an acceptable base for it. </para>
		/// </summary>
		public virtual void JumpOff(AActor MovementBaseActor)
			=> E_UCharacterMovementComponent_JumpOff(this, MovementBaseActor);
		
		
		/// <summary>
		/// <para>Jump onto shore from water </para>
		/// </summary>
		public virtual void JumpOutOfWater(FVector WallNormal)
			=> E_UCharacterMovementComponent_JumpOutOfWater(this, WallNormal);
		
		
		/// <summary>
		/// <para>Compute distance to the floor from bottom sphere of capsule and store the result in FloorResult. </para>
		/// <para>This distance is the swept distance of the capsule to the first point impacted by the lower hemisphere, or distance from the bottom of the capsule in the case of a line trace. </para>
		/// <para>This function does not care if collision is disabled on the capsule (unlike FindFloor). </para>
		/// <param name="CapsuleLocation">Location where the capsule sweep should originate </param>
		/// <param name="LineDistance">If non-zero, max distance to test for a simple line check from the capsule base. Used only if the sweep test fails to find a walkable floor, and only returns a valid result if the impact normal is a walkable normal. </param>
		/// <param name="SweepDistance">If non-zero, max distance to use when sweeping a capsule downwards for the test. MUST be greater than or equal to the line distance. </param>
		/// <param name="SweepRadius">The radius to use for sweep tests. Should be <= capsule radius. </param>
		/// <param name="FloorResult">Result of the floor check </param>
		/// </summary>
		public void ComputeFloorDistance(FVector CapsuleLocation, float LineDistance, float SweepDistance, float SweepRadius, FFindFloorResult FloorResult)
			=> E_UCharacterMovementComponent_K2_ComputeFloorDist(this, CapsuleLocation, LineDistance, SweepDistance, SweepRadius, FloorResult);
		
		
		/// <summary>
		/// <para>Sweeps a vertical trace to find the floor for the capsule at the given location. Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result. </para>
		/// <para>No floor will be found if collision is disabled on the capsule! </para>
		/// <param name="CapsuleLocation">Location where the capsule sweep should originate </param>
		/// <param name="FloorResult">Result of the floor check </param>
		/// </summary>
		public void K2_FindFloor(FVector CapsuleLocation, FFindFloorResult FloorResult)
			=> E_UCharacterMovementComponent_K2_FindFloor(this, CapsuleLocation, FloorResult);
		
		
		/// <summary>
		/// <return>Maximum acceleration for the current state, based on MaxAcceleration and any additional modifiers. </return>
		/// </summary>
		public virtual float K2_GetModifiedMaxAcceleration()
			=> E_UCharacterMovementComponent_K2_GetModifiedMaxAcceleration(this);
		
		
		/// <summary>
		/// <para>Get the max angle in degrees of a walkable surface for the character. </para>
		/// </summary>
		public float K2_GetWalkableFloorAngle()
			=> E_UCharacterMovementComponent_K2_GetWalkableFloorAngle(this);
		
		
		/// <summary>
		/// <para>Get the Z component of the normal of the steepest walkable surface for the character. Any lower than this and it is not walkable. </para>
		/// </summary>
		public float K2_GetWalkableFloorZ()
			=> E_UCharacterMovementComponent_K2_GetWalkableFloorZ(this);
		
		
		/// <summary>
		/// <para>Queue a pending launch with velocity LaunchVel. </para>
		/// </summary>
		public virtual void Launch(FVector LaunchVel)
			=> E_UCharacterMovementComponent_Launch(this, LaunchVel);
		
		
		/// <summary>
		/// <para>Limits the air control to use during falling movement, given an impact while falling. </para>
		/// <para>This function is used internally by PhysFalling(). </para>
		/// <param name="DeltaTime">Time step for the current update. </param>
		/// <param name="FallAcceleration">Acceleration used during movement. </param>
		/// <param name="HitResult">Result of impact. </param>
		/// <param name="bCheckForValidLandingSpot">If true, will use IsValidLandingSpot() to determine if HitResult is a walkable surface. If false, this check is skipped. </param>
		/// <return>Modified air control acceleration to use during falling movement. </return>
		/// <para>@see PhysFalling() </para>
		/// </summary>
		protected virtual FVector LimitAirControl(float DeltaTime, FVector FallAcceleration, FHitResult HitResult, bool bCheckForValidLandingSpot)
			=> E_UCharacterMovementComponent_LimitAirControl(this, DeltaTime, FallAcceleration, HitResult, bCheckForValidLandingSpot);
		
		
		/// <summary>
		/// <para>Adjusts velocity when walking so that Z velocity is zero. </para>
		/// <para>When bMaintainHorizontalGroundVelocity is false, also rescales the velocity vector to maintain the original magnitude, but in the horizontal direction. </para>
		/// </summary>
		protected virtual void MaintainHorizontalGroundVelocity()
			=> E_UCharacterMovementComponent_MaintainHorizontalGroundVelocity(this);
		
		
		/// <summary>
		/// <para>Call SaveBaseLocation() if not deferring updates (bDeferUpdateBasedMovement is false). </para>
		/// </summary>
		public virtual void MaybeSaveBaseLocation()
			=> E_UCharacterMovementComponent_MaybeSaveBaseLocation(this);
		
		
		/// <summary>
		/// <para>Update or defer updating of position based on Base movement </para>
		/// </summary>
		public virtual void MaybeUpdateBasedMovement(float DeltaSeconds)
			=> E_UCharacterMovementComponent_MaybeUpdateBasedMovement(this, DeltaSeconds);
		
		protected virtual void MoveAutonomous(float ClientTimeStamp, float DeltaTime, byte CompressedFlags, FVector NewAccel)
			=> E_UCharacterMovementComponent_MoveAutonomous(this, ClientTimeStamp, DeltaTime, CompressedFlags, NewAccel);
		
		
		/// <summary>
		/// <para>Compute new falling velocity from given velocity and gravity. Applies the limits of the current Physics Volume's TerminalVelocity. </para>
		/// </summary>
		public virtual FVector NewFallVelocity(FVector InitialVelocity, FVector Gravity, float DeltaTime)
			=> E_UCharacterMovementComponent_NewFallVelocity(this, InitialVelocity, Gravity, DeltaTime);
		
		public override void NotifyBumpedPawn(APawn BumpedPawn)
			=> E_UCharacterMovementComponent_NotifyBumpedPawn(this, BumpedPawn);
		
		
		/// <summary>
		/// <para>Called if bNotifyApex is true and character has just passed the apex of its jump. </para>
		/// </summary>
		public virtual void NotifyJumpApex()
			=> E_UCharacterMovementComponent_NotifyJumpApex(this);
		
		
		/// <summary>
		/// <para>Notification that the character is stuck in geometry.  Only called during walking movement. </para>
		/// </summary>
		protected virtual void OnCharacterStuckInGeometry(FHitResult Hit)
			=> E_UCharacterMovementComponent_OnCharacterStuckInGeometry(this, Hit);
		
		
		/// <summary>
		/// <para>Called by UCharacterMovementComponent::VerifyClientTimeStamp() when a client timestamp reset has been detected and is valid. </para>
		/// </summary>
		protected virtual void OnClientTimeStampResetDetected()
			=> E_UCharacterMovementComponent_OnClientTimeStampResetDetected(this);
		
		
		/// <summary>
		/// <para>Called after MovementMode has changed. Base implementation does special handling for starting certain modes, then notifies the CharacterOwner. </para>
		/// </summary>
		protected virtual void OnMovementModeChanged(EMovementMode PreviousMovementMode, byte PreviousCustomMode)
			=> E_UCharacterMovementComponent_OnMovementModeChanged(this, (byte)PreviousMovementMode, PreviousCustomMode);
		
		
		/// <summary>
		/// <para>Event triggered at the end of a movement update. If scoped movement updates are enabled (bEnableScopedMovementUpdates), this is within such a scope. </para>
		/// <para>If that is not desired, bind to the CharacterOwner's OnMovementUpdated event instead, as that is triggered after the scoped movement update. </para>
		/// </summary>
		protected virtual void OnMovementUpdated(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
			=> E_UCharacterMovementComponent_OnMovementUpdated(this, DeltaSeconds, OldLocation, OldVelocity);
		
		public override void OnRegister()
			=> E_UCharacterMovementComponent_OnRegister(this);
		
		
		/// <summary>
		/// <para>Called by owning Character upon successful teleport from AActor::TeleportTo(). </para>
		/// </summary>
		public override void OnTeleported()
			=> E_UCharacterMovementComponent_OnTeleported(this);
		
		
		/// <summary>
		/// <para>Called by UCharacterMovementComponent::ProcessClientTimeStampForTimeDiscrepancy() (on server) when the time from client moves </para>
		/// <para>significantly differs from the server time, indicating potential time manipulation by clients (speed hacks, significant network </para>
		/// <para>issues, client performance problems) </para>
		/// <param name="CurrentTimeDiscrepancy">Accumulated time difference between client ServerMove and server time - this is bounded </param>
		/// <para>by MovementTimeDiscrepancy config variables in AGameNetworkManager, and is the value with which </para>
		/// <para>we test against to trigger this function. This is reset when MovementTimeDiscrepancy resolution </para>
		/// <para>is enabled </para>
		/// <param name="LifetimeRawTimeDiscrepancy">Accumulated time difference between client ServerMove and server time - this is unbounded </param>
		/// <para>and does NOT get affected by MovementTimeDiscrepancy resolution, and is useful as a longer-term </para>
		/// <para>view of how the given client is performing. High magnitude unbounded error points to </para>
		/// <para>intentional tampering by a client vs. occasional "naturally caused" spikes in error due to </para>
		/// <para>burst packet loss/performance hitches </para>
		/// <param name="Lifetime">Game time over which LifetimeRawTimeDiscrepancy has accrued (useful for determining severity </param>
		/// <para>of LifetimeUnboundedError) </para>
		/// <param name="CurrentMoveError">Time difference between client ServerMove and how much time has passed on the server for the </param>
		/// <para>current move that has caused TimeDiscrepancy to accumulate enough to trigger detection. </para>
		/// </summary>
		protected virtual void OnTimeDiscrepancyDetected(float CurrentTimeDiscrepancy, float LifetimeRawTimeDiscrepancy, float Lifetime, float CurrentMoveError)
			=> E_UCharacterMovementComponent_OnTimeDiscrepancyDetected(this, CurrentTimeDiscrepancy, LifetimeRawTimeDiscrepancy, Lifetime, CurrentMoveError);
		
		
		/// <summary>
		/// <para>Event triggered when we are moving on a base but we are not able to move the full DeltaPosition because something has blocked us. </para>
		/// <para>Note: MoveComponentFlags includes the flag to ignore the movement base while this event is fired. </para>
		/// <param name="DeltaPosition">How far we tried to move with the base. </param>
		/// <param name="OldLocation">Location before we tried to move with the base. </param>
		/// <param name="MoveOnBaseHit">Hit result for the object we hit when trying to move with the base. </param>
		/// </summary>
		protected virtual void OnUnableToFollowBaseMove(FVector DeltaPosition, FVector OldLocation, FHitResult MoveOnBaseHit)
			=> E_UCharacterMovementComponent_OnUnableToFollowBaseMove(this, DeltaPosition, OldLocation, MoveOnBaseHit);
		
		public byte PackNetworkMovementMode()
			=> E_UCharacterMovementComponent_PackNetworkMovementMode(this);
		
		
		/// <summary>
		/// <para>Update Velocity and Acceleration to air control in the desired Direction for character using path following. </para>
		/// <param name="Direction">is the desired direction of movement </param>
		/// <param name="ZDiff">is the height difference between the destination and the Pawn's current position </param>
		/// <para>@see RequestDirectMove() </para>
		/// </summary>
		public virtual void PerformAirControlForPathFollowing(FVector Direction, float ZDiff)
			=> E_UCharacterMovementComponent_PerformAirControlForPathFollowing(this, Direction, ZDiff);
		
		
		/// <summary>
		/// <para>Perform movement on an autonomous client </para>
		/// </summary>
		protected virtual void PerformMovement(float DeltaTime)
			=> E_UCharacterMovementComponent_PerformMovement(this, DeltaTime);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysCustom(float deltaTime, int Iterations)
			=> E_UCharacterMovementComponent_PhysCustom(this, deltaTime, Iterations);
		
		
		/// <summary>
		/// <para>Handle falling movement. </para>
		/// </summary>
		public virtual void PhysFalling(float deltaTime, int Iterations)
			=> E_UCharacterMovementComponent_PhysFalling(this, deltaTime, Iterations);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysFlying(float deltaTime, int Iterations)
			=> E_UCharacterMovementComponent_PhysFlying(this, deltaTime, Iterations);
		
		
		/// <summary>
		/// <para>Perform rotation over deltaTime </para>
		/// </summary>
		public virtual void PhysicsRotation(float DeltaTime)
			=> E_UCharacterMovementComponent_PhysicsRotation(this, DeltaTime);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysNavWalking(float deltaTime, int Iterations)
			=> E_UCharacterMovementComponent_PhysNavWalking(this, deltaTime, Iterations);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysSwimming(float deltaTime, int Iterations)
			=> E_UCharacterMovementComponent_PhysSwimming(this, deltaTime, Iterations);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysWalking(float deltaTime, int Iterations)
			=> E_UCharacterMovementComponent_PhysWalking(this, deltaTime, Iterations);
		
		public override void PostLoad()
			=> E_UCharacterMovementComponent_PostLoad(this);
		
		
		/// <summary>
		/// <para>Handle landing against Hit surface over remaingTime and iterations, calling SetPostLandedPhysics() and starting the new movement mode. </para>
		/// </summary>
		protected virtual void ProcessLanded(FHitResult Hit, float remainingTime, int Iterations)
			=> E_UCharacterMovementComponent_ProcessLanded(this, Hit, remainingTime, Iterations);
		
		
		/// <summary>
		/// <para>Attempts to better align navmesh walking characters with underlying geometry (sometimes </para>
		/// <para>navmesh can differ quite significantly from geometry). </para>
		/// <para>Updates CachedProjectedNavMeshHitResult, access this for more info about hits. </para>
		/// </summary>
		protected virtual FVector ProjectLocationFromNavMesh(float DeltaSeconds, FVector CurrentFeetLocation, FVector TargetNavLocation, float UpOffset, float DownOffset)
			=> E_UCharacterMovementComponent_ProjectLocationFromNavMesh(this, DeltaSeconds, CurrentFeetLocation, TargetNavLocation, UpOffset, DownOffset);
		
		public override void RegisterComponentTickFunctions(bool bRegister)
			=> E_UCharacterMovementComponent_RegisterComponentTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Remove a RootMotionSource from current root motion by name </para>
		/// </summary>
		public void RemoveRootMotionSource(string InstanceName)
			=> E_UCharacterMovementComponent_RemoveRootMotionSource(this, InstanceName);
		
		
		/// <summary>
		/// <para>Perform local movement and send the move to the server. </para>
		/// </summary>
		protected virtual void ReplicateMoveToServer(float DeltaTime, FVector NewAcceleration)
			=> E_UCharacterMovementComponent_ReplicateMoveToServer(this, DeltaTime, NewAcceleration);
		
		public override void RequestDirectMove(FVector MoveVelocity, bool bForceMaxSpeed)
			=> E_UCharacterMovementComponent_RequestDirectMove(this, MoveVelocity, bForceMaxSpeed);
		
		public override void RequestPathMove(FVector MoveInput)
			=> E_UCharacterMovementComponent_RequestPathMove(this, MoveInput);
		
		public virtual void ResetPredictionData_Client()
			=> E_UCharacterMovementComponent_ResetPredictionData_Client(this);
		
		public virtual void ResetPredictionData_Server()
			=> E_UCharacterMovementComponent_ResetPredictionData_Server(this);
		
		
		/// <summary>
		/// <para>Overridden to set bJustTeleported to true, so we don't make incorrect velocity calculations based on adjusted movement. </para>
		/// </summary>
		protected override bool ResolvePenetrationImpl(FVector Adjustment, FHitResult Hit, FQuat NewRotation)
			=> E_UCharacterMovementComponent_ResolvePenetrationImpl(this, Adjustment, Hit, NewRotation);
		
		
		/// <summary>
		/// <para>Revert to previous position OldLocation, return to being based on OldBase. </para>
		/// <para>if bFailMove, stop movement and notify controller </para>
		/// </summary>
		public void RevertMove(FVector OldLocation, UPrimitiveComponent OldBase, FVector InOldBaseLocation, FFindFloorResult OldFloor, bool bFailMove)
			=> E_UCharacterMovementComponent_RevertMove(this, OldLocation, OldBase, InOldBaseLocation, OldFloor, bFailMove);
		
		
		/// <summary>
		/// <para>Round acceleration, for better consistency and lower bandwidth in networked games. </para>
		/// </summary>
		public virtual FVector RoundAcceleration(FVector InAccel)
			=> E_UCharacterMovementComponent_RoundAcceleration(this, InAccel);
		
		
		/// <summary>
		/// <para>Update OldBaseLocation and OldBaseQuat if there is a valid movement base, and store the relative location/rotation if necessary. Ignores bDeferUpdateBasedMovement and forces the update. </para>
		/// </summary>
		public virtual void SaveBaseLocation()
			=> E_UCharacterMovementComponent_SaveBaseLocation(this);
		
		
		/// <summary>
		/// <para>Scale input acceleration, based on movement acceleration rate. </para>
		/// </summary>
		protected virtual FVector ScaleInputAcceleration(FVector InputAcceleration)
			=> E_UCharacterMovementComponent_ScaleInputAcceleration(this, InputAcceleration);
		
		public virtual void SendClientAdjustment()
			=> E_UCharacterMovementComponent_SendClientAdjustment(this);
		
		
		/// <summary>
		/// <para>Check for Server-Client disagreement in position or other movement state important enough to trigger a client correction. </para>
		/// <para>@see ServerMoveHandleClientError() </para>
		/// </summary>
		protected virtual bool ServerCheckClientError(float ClientTimeStamp, float DeltaTime, FVector Accel, FVector ClientWorldLocation, FVector RelativeClientLocation, UPrimitiveComponent ClientMovementBase, string ClientBaseBoneName, byte ClientMovementMode)
			=> E_UCharacterMovementComponent_ServerCheckClientError(this, ClientTimeStamp, DeltaTime, Accel, ClientWorldLocation, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
		
		
		/// <summary>
		/// <para>Have the server check if the client is outside an error tolerance, and queue a client adjustment if so. </para>
		/// <para>If either GetPredictionData_Server_Character()->bForceClientUpdate or ServerCheckClientError() are true, the client adjustment will be sent. </para>
		/// <para>RelativeClientLocation will be a relative location if MovementBaseUtility::UseRelativePosition(ClientMovementBase) is true, or a world location if false. </para>
		/// <para>@see ServerCheckClientError() </para>
		/// </summary>
		protected virtual void ServerMoveHandleClientError(float ClientTimeStamp, float DeltaTime, FVector Accel, FVector RelativeClientLocation, UPrimitiveComponent ClientMovementBase, string ClientBaseBoneName, byte ClientMovementMode)
			=> E_UCharacterMovementComponent_ServerMoveHandleClientError(this, ClientTimeStamp, DeltaTime, Accel, RelativeClientLocation, ClientMovementBase, ClientBaseBoneName, ClientMovementMode);
		
		
		/// <summary>
		/// <para>Change avoidance state and registers in RVO manager if needed </para>
		/// </summary>
		public void SetAvoidanceEnabled(bool bEnable)
			=> E_UCharacterMovementComponent_SetAvoidanceEnabled(this, bEnable);
		
		public void SetAvoidanceGroup(int GroupFlags)
			=> E_UCharacterMovementComponent_SetAvoidanceGroup(this, GroupFlags);
		
		
		/// <summary>
		/// <para>Update the base of the character, which is the PrimitiveComponent we are standing on. </para>
		/// </summary>
		public virtual void SetBase(UPrimitiveComponent NewBase, string BoneName, bool bNotifyActor)
			=> E_UCharacterMovementComponent_SetBase(this, NewBase, BoneName, bNotifyActor);
		
		
		/// <summary>
		/// <para>Update the base of the character, using the given floor result if it is walkable, or null if not. Calls SetBase(). </para>
		/// </summary>
		public void SetBaseFromFloor(FFindFloorResult FloorResult)
			=> E_UCharacterMovementComponent_SetBaseFromFloor(this, FloorResult);
		
		
		/// <summary>
		/// <para>Set movement mode to the default based on the current physics volume. </para>
		/// </summary>
		public virtual void SetDefaultMovementMode()
			=> E_UCharacterMovementComponent_SetDefaultMovementMode(this);
		
		
		/// <summary>
		/// <para>Set movement mode to use when returning to walking movement (either MOVE_Walking or MOVE_NavWalking). </para>
		/// <para>If movement mode is currently one of Walking or NavWalking, this will also change the current movement mode (via SetMovementMode()) </para>
		/// <para>if the new mode is not the current ground mode. </para>
		/// <param name="NewGroundMovementMode">New ground movement mode. Must be either MOVE_Walking or MOVE_NavWalking, other values are ignored. </param>
		/// <para>@see GroundMovementMode </para>
		/// </summary>
		public void SetGroundMovementMode(EMovementMode NewGroundMovementMode)
			=> E_UCharacterMovementComponent_SetGroundMovementMode(this, (byte)NewGroundMovementMode);
		
		public void SetGroupsToAvoid(int GroupFlags)
			=> E_UCharacterMovementComponent_SetGroupsToAvoid(this, GroupFlags);
		
		public void SetGroupsToIgnore(int GroupFlags)
			=> E_UCharacterMovementComponent_SetGroupsToIgnore(this, GroupFlags);
		
		
		/// <summary>
		/// <para>Change movement mode. </para>
		/// <param name="NewMovementMode">The new movement mode </param>
		/// <param name="NewCustomMode">The new custom sub-mode, only applicable if NewMovementMode is Custom. </param>
		/// </summary>
		public virtual void SetMovementMode(EMovementMode NewMovementMode, byte NewCustomMode)
			=> E_UCharacterMovementComponent_SetMovementMode(this, (byte)NewMovementMode, NewCustomMode);
		
		
		/// <summary>
		/// <para>Switch collision settings for NavWalking mode (ignore world collisions) </para>
		/// </summary>
		protected virtual void SetNavWalkingPhysics(bool bEnable)
			=> E_UCharacterMovementComponent_SetNavWalkingPhysics(this, bEnable);
		
		
		/// <summary>
		/// <para>Use new physics after landing. Defaults to swimming if in water, walking otherwise. </para>
		/// </summary>
		protected virtual void SetPostLandedPhysics(FHitResult Hit)
			=> E_UCharacterMovementComponent_SetPostLandedPhysics(this, Hit);
		
		public override void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
			=> E_UCharacterMovementComponent_SetUpdatedComponent(this, NewUpdatedComponent);
		
		
		/// <summary>
		/// <para>Set the max angle in degrees of a walkable surface for the character. Also computes WalkableFloorZ. </para>
		/// </summary>
		public void SetWalkableFloorAngle(float InWalkableFloorAngle)
			=> E_UCharacterMovementComponent_SetWalkableFloorAngle(this, InWalkableFloorAngle);
		
		
		/// <summary>
		/// <para>Set the Z component of the normal of the steepest walkable surface for the character. Also computes WalkableFloorAngle. </para>
		/// </summary>
		public void SetWalkableFloorZ(float InWalkableFloorZ)
			=> E_UCharacterMovementComponent_SetWalkableFloorZ(this, InWalkableFloorZ);
		
		
		/// <summary>
		/// <para>On the server if we know we are having our replication rate throttled, this method checks if important replicated properties have changed that should cause us to return to the normal replication rate. </para>
		/// </summary>
		protected virtual bool ShouldCancelAdaptiveReplication()
			=> E_UCharacterMovementComponent_ShouldCancelAdaptiveReplication(this);
		
		
		/// <summary>
		/// <para>Whether Character should go into falling mode when walking and changing position, based on an old and new floor result (both of which are considered walkable). </para>
		/// <para>Default implementation always returns false. </para>
		/// <return>true if Character should start falling </return>
		/// </summary>
		public virtual bool ShouldCatchAir(FFindFloorResult OldFloor, FFindFloorResult NewFloor)
			=> E_UCharacterMovementComponent_ShouldCatchAir(this, OldFloor, NewFloor);
		
		
		/// <summary>
		/// <para>Determine whether we should try to find a valid landing spot after an impact with an invalid one (based on the Hit result). </para>
		/// <para>For example, landing on the lower portion of the capsule on the edge of geometry may be a walkable surface, but could have reported an unwalkable impact normal. </para>
		/// </summary>
		public virtual bool ShouldCheckForValidLandingSpot(float DeltaTime, FVector Delta, FHitResult Hit)
			=> E_UCharacterMovementComponent_ShouldCheckForValidLandingSpot(this, DeltaTime, Delta, Hit);
		
		
		/// <summary>
		/// <para>Check if the result of a sweep test (passed in InHit) might be a valid location to perch, in which case we should use ComputePerchResult to validate the location. </para>
		/// <para>@see ComputePerchResult </para>
		/// <param name="InHit">Result of the last sweep test before this query. </param>
		/// <param name="bCheckRadius">If true, only allow the perch test if the impact point is outside the radius returned by GetValidPerchRadius(). </param>
		/// <return>Whether perching may be possible, such that ComputePerchResult can return a valid result. </return>
		/// </summary>
		public virtual bool ShouldComputePerchResult(FHitResult InHit, bool bCheckRadius)
			=> E_UCharacterMovementComponent_ShouldComputePerchResult(this, InHit, bCheckRadius);
		
		
		/// <summary>
		/// <para>Determine whether the Character should jump when exiting water. </para>
		/// <param name="JumpDir">is the desired direction to jump out of water </param>
		/// <return>true if Pawn should jump out of water </return>
		/// </summary>
		public virtual bool ShouldJumpOutOfWater(FVector JumpDir)
			=> E_UCharacterMovementComponent_ShouldJumpOutOfWater(this, JumpDir);
		
		
		/// <summary>
		/// <para>if true, DesiredRotation will be restricted to only Yaw component in PhysicsRotation() </para>
		/// </summary>
		public virtual bool ShouldRemainVertical()
			=> E_UCharacterMovementComponent_ShouldRemainVertical(this);
		
		
		/// <summary>
		/// <para>Special Tick for Simulated Proxies </para>
		/// </summary>
		protected void SimulatedTick(float DeltaSeconds)
			=> E_UCharacterMovementComponent_SimulatedTick(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Simulate movement on a non-owning client. Called by SimulatedTick(). </para>
		/// </summary>
		protected virtual void SimulateMovement(float DeltaTime)
			=> E_UCharacterMovementComponent_SimulateMovement(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Custom version of SlideAlongSurface that handles different movement modes separately; namely during walking physics we might not want to slide up slopes. </para>
		/// </summary>
		public override float SlideAlongSurface(FVector Delta, float Time, FVector Normal, FHitResult Hit, bool bHandleImpact)
			=> E_UCharacterMovementComponent_SlideAlongSurface(this, Delta, Time, Normal, Hit, bHandleImpact);
		
		
		/// <summary>
		/// <para>Smooth mesh location for network interpolation, based on values set up by SmoothCorrection. </para>
		/// <para>Internally this simply calls SmoothClientPosition_Interpolate() then SmoothClientPosition_UpdateVisuals(). </para>
		/// <para>This function is not called when bNetworkSmoothingComplete is true. </para>
		/// <param name="DeltaSeconds">Time since last update. </param>
		/// </summary>
		protected virtual void SmoothClientPosition(float DeltaSeconds)
			=> E_UCharacterMovementComponent_SmoothClientPosition(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Update interpolation values for client smoothing. Does not change actual mesh location. </para>
		/// <para>Sets bNetworkSmoothingComplete to true when the interpolation reaches the target. </para>
		/// </summary>
		protected void SmoothClientPosition_Interpolate(float DeltaSeconds)
			=> E_UCharacterMovementComponent_SmoothClientPosition_Interpolate(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Update mesh location based on interpolated values. </para>
		/// </summary>
		protected void SmoothClientPosition_UpdateVisuals()
			=> E_UCharacterMovementComponent_SmoothClientPosition_UpdateVisuals(this);
		
		
		/// <summary>
		/// <para>React to new transform from network update. Sets bNetworkSmoothingComplete to false to ensure future smoothing updates. </para>
		/// <para>IMPORTANT: It is expected that this function triggers any movement/transform updates to match the network update if desired. </para>
		/// </summary>
		public virtual void SmoothCorrection(FVector OldLocation, FQuat OldRotation, FVector NewLocation, FQuat NewRotation)
			=> E_UCharacterMovementComponent_SmoothCorrection(this, OldLocation, OldRotation, NewLocation, NewRotation);
		
		
		/// <summary>
		/// <para>Transition from walking to falling </para>
		/// </summary>
		public virtual void StartFalling(int Iterations, float remainingTime, float timeTick, FVector Delta, FVector subLoc)
			=> E_UCharacterMovementComponent_StartFalling(this, Iterations, remainingTime, timeTick, Delta, subLoc);
		
		
		/// <summary>
		/// <para>changes physics based on MovementMode </para>
		/// </summary>
		public virtual void StartNewPhysics(float deltaTime, int Iterations)
			=> E_UCharacterMovementComponent_StartNewPhysics(this, deltaTime, Iterations);
		
		
		/// <summary>
		/// <para>Handle start swimming functionality </para>
		/// <param name="OldLocation">Location on last tick </param>
		/// <param name="OldVelocity">velocity at last tick </param>
		/// <param name="timeTick">time since at OldLocation </param>
		/// <param name="remainingTime">DeltaTime to complete transition to swimming </param>
		/// <param name="Iterations">physics iteration count </param>
		/// </summary>
		public void StartSwimming(FVector OldLocation, FVector OldVelocity, float timeTick, float remainingTime, int Iterations)
			=> E_UCharacterMovementComponent_StartSwimming(this, OldLocation, OldVelocity, timeTick, remainingTime, Iterations);
		
		public override void StopActiveMovement()
			=> E_UCharacterMovementComponent_StopActiveMovement(this);
		
		public float Swim(FVector Delta, FHitResult Hit)
			=> E_UCharacterMovementComponent_Swim(this, Delta, Hit);
		
		
		/// <summary>
		/// <para>Ticks the characters pose and accumulates root motion </para>
		/// </summary>
		protected void TickCharacterPose(float DeltaTime)
			=> E_UCharacterMovementComponent_TickCharacterPose(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Checks to see if the current location is not encroaching blocking geometry so the character can leave NavWalking. </para>
		/// <para>Restores collision settings and adjusts character location to avoid getting stuck in geometry. </para>
		/// <para>If it's not possible, MovementMode change will be delayed until character reach collision free spot. </para>
		/// <return>True if movement mode was successfully changed </return>
		/// </summary>
		protected virtual bool TryToLeaveNavWalking()
			=> E_UCharacterMovementComponent_TryToLeaveNavWalking(this);
		
		
		/// <summary>
		/// <para>Custom version that allows upwards slides when walking if the surface is walkable. </para>
		/// </summary>
		public override void TwoWallAdjust(FVector Delta, FHitResult Hit, FVector OldHitNormal)
			=> E_UCharacterMovementComponent_TwoWallAdjust(this, Delta, Hit, OldHitNormal);
		
		
		/// <summary>
		/// <para>Checks if default capsule size fits (no encroachment), and trigger OnEndCrouch() on the owner if successful. </para>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset. </param>
		/// </summary>
		public virtual void UnCrouch(bool bClientSimulation)
			=> E_UCharacterMovementComponent_UnCrouch(this, bClientSimulation);
		
		
		/// <summary>
		/// <para>Update position based on Base movement </para>
		/// </summary>
		public virtual void UpdateBasedMovement(float DeltaSeconds)
			=> E_UCharacterMovementComponent_UpdateBasedMovement(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Update controller's view rotation as pawn's base rotates </para>
		/// </summary>
		public virtual void UpdateBasedRotation(FRotator FinalRotation, FRotator ReducedRotation)
			=> E_UCharacterMovementComponent_UpdateBasedRotation(this, FinalRotation, ReducedRotation);
		
		
		/// <summary>
		/// <para>Update the character state in PerformMovement after the position change. Some rotation updates happen after this. </para>
		/// </summary>
		public virtual void UpdateCharacterStateAfterMovement()
			=> E_UCharacterMovementComponent_UpdateCharacterStateAfterMovement(this);
		
		
		/// <summary>
		/// <para>Update the character state in PerformMovement right before doing the actual position change </para>
		/// </summary>
		public virtual void UpdateCharacterStateBeforeMovement()
			=> E_UCharacterMovementComponent_UpdateCharacterStateBeforeMovement(this);
		
		
		/// <summary>
		/// <para>React to instantaneous change in position. Invalidates cached floor recomputes it if possible if there is a current movement base. </para>
		/// </summary>
		public virtual void UpdateFloorFromAdjustment()
			=> E_UCharacterMovementComponent_UpdateFloorFromAdjustment(this);
		
		
		/// <summary>
		/// <para>Unpack compressed flags from a saved move and set state accordingly. See FSavedMove_Character. </para>
		/// </summary>
		protected virtual void UpdateFromCompressedFlags(byte Flags)
			=> E_UCharacterMovementComponent_UpdateFromCompressedFlags(this, Flags);
		
		
		/// <summary>
		/// <para>Draw in-world debug information for character movement (called with p.VisualizeMovement > 0). </para>
		/// </summary>
		public virtual void VisualizeMovement()
			=> E_UCharacterMovementComponent_VisualizeMovement(this);
		
		
		/// <summary>
		/// <para>Adds the given vector to the accumulated input in world space. Input vectors are usually between 0 and 1 in magnitude. </para>
		/// <para>They are accumulated during a frame then applied as acceleration during the movement update. </para>
		/// <param name="WorldDirection">Direction in world space to apply input </param>
		/// <param name="ScaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value. </param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored(). </param>
		/// <para>@see APawn::AddMovementInput() </para>
		/// </summary>
		public override void AddInputVector(FVector WorldVector, bool bForce)
			=> E_UCharacterMovementComponent_AddInputVector(this, WorldVector, bForce);
		
		public override FVector ConsumeInputVector()
			=> E_UCharacterMovementComponent_ConsumeInputVector(this);
		
		
		/// <summary>
		/// <para>Helper to see if move input is ignored. If there is no Pawn or UpdatedComponent, returns true, otherwise defers to the Pawn's implementation of IsMoveInputIgnored(). </para>
		/// </summary>
		public override bool IsMoveInputIgnored()
			=> E_UCharacterMovementComponent_IsMoveInputIgnored(this);
		
		
		/// <summary>
		/// <para>@returns based location of controlled actor </para>
		/// </summary>
		public override FBasedPosition GetActorFeetLocationBased()
			=> E_UCharacterMovementComponent_GetActorFeetLocationBased(this);
		
		public override void StopMovementImmediately()
			=> E_UCharacterMovementComponent_StopMovementImmediately(this);
		
		
		/// <summary>
		/// <para>Constrain a direction vector to the plane constraint, if enabled. </para>
		/// <para>@see SetPlaneConstraint </para>
		/// </summary>
		public override FVector ConstrainDirectionToPlane(FVector Direction)
			=> E_UCharacterMovementComponent_ConstrainDirectionToPlane(this, Direction);
		
		
		/// <summary>
		/// <para>Constrain a position vector to the plane constraint, if enabled. </para>
		/// </summary>
		public override FVector ConstrainLocationToPlane(FVector Location)
			=> E_UCharacterMovementComponent_ConstrainLocationToPlane(this, Location);
		
		
		/// <summary>
		/// <para>Constrain a normal vector (of unit length) to the plane constraint, if enabled. </para>
		/// </summary>
		public override FVector ConstrainNormalToPlane(FVector Normal)
			=> E_UCharacterMovementComponent_ConstrainNormalToPlane(this, Normal);
		
		
		/// <summary>
		/// <return>a scalar applied to the maximum velocity that the component can currently move. </return>
		/// </summary>
		public override float GetMaxSpeedModifier()
			=> E_UCharacterMovementComponent_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// <return>the result of GetMaxSpeed() * GetMaxSpeedModifier(). </return>
		/// </summary>
		public override float GetModifiedMaxSpeed()
			=> E_UCharacterMovementComponent_GetModifiedMaxSpeed(this);
		
		
		/// <summary>
		/// <para>Overridden to auto-register the updated component if it starts NULL, and we can find a root component on our owner. </para>
		/// </summary>
		public override void InitializeComponent()
			=> E_UCharacterMovementComponent_InitializeComponent(this);
		
		
		/// <summary>
		/// <para>Returns true if the current velocity is exceeding the given max speed (usually the result of GetMaxSpeed()), within a small error tolerance. </para>
		/// <para>Note that under normal circumstances updates cause by acceleration will not cause this to be true, however external forces or changes in the max speed limit </para>
		/// <para>can cause the max speed to be violated. </para>
		/// </summary>
		public override bool IsExceedingMaxSpeed(float MaxSpeed)
			=> E_UCharacterMovementComponent_IsExceedingMaxSpeed(this, MaxSpeed);
		
		
		/// <summary>
		/// <para>return true if it's in PhysicsVolume with water flag </para>
		/// </summary>
		public override bool IsInWater()
			=> E_UCharacterMovementComponent_IsInWater(this);
		
		
		/// <summary>
		/// <return>a scalar applied to the maximum velocity that the component can currently move. </return>
		/// </summary>
		public override float K2_GetMaxSpeedModifier()
			=> E_UCharacterMovementComponent_K2_GetMaxSpeedModifier(this);
		
		
		/// <summary>
		/// <return>the result of GetMaxSpeed() * GetMaxSpeedModifier(). </return>
		/// </summary>
		public override float K2_GetModifiedMaxSpeed()
			=> E_UCharacterMovementComponent_K2_GetModifiedMaxSpeed(this);
		
		protected override bool MoveUpdatedComponentImpl(FVector Delta, FQuat NewRotation, bool bSweep, FHitResult OutHit, ETeleportType Teleport)
			=> E_UCharacterMovementComponent_MoveUpdatedComponentImpl(this, Delta, NewRotation, bSweep, OutHit, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Set the plane constraint axis setting. </para>
		/// <para>Changing this setting will modify the current value of PlaneConstraintNormal. </para>
		/// <param name="NewAxisSetting">New plane constraint axis setting. </param>
		/// </summary>
		public override void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
			=> E_UCharacterMovementComponent_SetPlaneConstraintAxisSetting(this, (byte)NewAxisSetting);
		
		
		/// <summary>
		/// <para>Sets whether or not the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintEnabled(bool bEnabled)
			=> E_UCharacterMovementComponent_SetPlaneConstraintEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Uses the Forward and Up vectors to compute the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
			=> E_UCharacterMovementComponent_SetPlaneConstraintFromVectors(this, Forward, Up);
		
		
		/// <summary>
		/// <para>Sets the normal of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// <para>Changing the normal automatically sets PlaneConstraintAxisSetting to "Custom". </para>
		/// <param name="PlaneNormal">The normal of the plane. If non-zero in length, it will be normalized. </param>
		/// </summary>
		public override void SetPlaneConstraintNormal(FVector PlaneNormal)
			=> E_UCharacterMovementComponent_SetPlaneConstraintNormal(this, PlaneNormal);
		
		
		/// <summary>
		/// <para>Sets the origin of the plane that constrains movement, enforced if the plane constraint is enabled. </para>
		/// </summary>
		public override void SetPlaneConstraintOrigin(FVector PlaneOrigin)
			=> E_UCharacterMovementComponent_SetPlaneConstraintOrigin(this, PlaneOrigin);
		
		
		/// <summary>
		/// <para>Possibly skip update if moved component is not rendered or can't move. </para>
		/// <param name="DeltaTime">todo this parameter is not used in the function. </param>
		/// <return>true if component movement update should be skipped </return>
		/// </summary>
		public override bool ShouldSkipUpdate(float DeltaTime)
			=> E_UCharacterMovementComponent_ShouldSkipUpdate(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Snap the updated component to the plane constraint, if enabled. </para>
		/// </summary>
		public override void SnapUpdatedComponentToPlane()
			=> E_UCharacterMovementComponent_SnapUpdatedComponentToPlane(this);
		
		
		/// <summary>
		/// <para>Update ComponentVelocity of UpdatedComponent. This needs to be called by derived classes at the end of an update whenever Velocity has changed. </para>
		/// </summary>
		public override void UpdateComponentVelocity()
			=> E_UCharacterMovementComponent_UpdateComponentVelocity(this);
		
		
		/// <summary>
		/// <para>Update tick registration state, determined by bAutoUpdateTickRegistration. Called by SetUpdatedComponent. </para>
		/// </summary>
		public override void UpdateTickRegistration()
			=> E_UCharacterMovementComponent_UpdateTickRegistration(this);
		
		
		/// <summary>
		/// <para>Activates the SceneComponent </para>
		/// <param name="bReset">The value to assign to HiddenGame. </param>
		/// </summary>
		public override void Activate(bool bReset)
			=> E_UCharacterMovementComponent_Activate(this, bReset);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteActor </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UCharacterMovementComponent_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this component tick after PrerequisiteComponent. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UCharacterMovementComponent_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>BeginsPlay for the component.  Occurs at level startup. This is before BeginPlay (Actor or Component). </para>
		/// <para>All Components (that want initialization) in the level will be Initialized on load before any </para>
		/// <para>Actor/Component gets BeginPlay. </para>
		/// <para>Requires component to be registered and initialized. </para>
		/// </summary>
		public override void BeginPlay()
			=> E_UCharacterMovementComponent_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Used to create any rendering thread information for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void CreateRenderState_Concurrent()
			=> E_UCharacterMovementComponent_CreateRenderState_Concurrent(this);
		
		
		/// <summary>
		/// <para>Unregister the component, remove it from its outer Actor's Components array and mark for pending kill. </para>
		/// </summary>
		public override void DestroyComponent(bool bPromoteChildren)
			=> E_UCharacterMovementComponent_DestroyComponent(this, bPromoteChildren);
		
		
		/// <summary>
		/// <para>Used to shut down any rendering thread structure for this component </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void DestroyRenderState_Concurrent()
			=> E_UCharacterMovementComponent_DestroyRenderState_Concurrent(this);
		
		public override bool GetComponentClassCanReplicate()
			=> E_UCharacterMovementComponent_GetComponentClassCanReplicate(this);
		
		
		/// <summary>
		/// <para>Returns a readable name for this component, including the asset name if applicable </para>
		/// <para>By default this appends a space plus AdditionalStatObject() </para>
		/// </summary>
		public override string GetReadableName()
			=> E_UCharacterMovementComponent_GetReadableName(this);
		
		
		/// <summary>
		/// <para>Used to check that DestroyPhysicsState() is working correctly </para>
		/// </summary>
		public override bool HasValidPhysicsState()
			=> E_UCharacterMovementComponent_HasValidPhysicsState(this);
		
		
		/// <summary>
		/// <para>Called when this actor component has moved, allowing it to discard statically cached lighting information. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bInvalidateBuildEnqueuedLighting, bool bTranslationOnly)
			=> E_UCharacterMovementComponent_InvalidateLightingCacheDetailed(this, bInvalidateBuildEnqueuedLighting, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Returns whether the component is active or not </para>
		/// <return>The active state of the component. </return>
		/// </summary>
		public override bool IsActive()
			=> E_UCharacterMovementComponent_IsActive(this);
		
		
		/// <summary>
		/// <para>Returns whether this component is an editor-only object or not </para>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_UCharacterMovementComponent_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_UCharacterMovementComponent_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>override to supply actual logic </para>
		/// </summary>
		public override bool IsNavigationRelevant()
			=> E_UCharacterMovementComponent_IsNavigationRelevant(this);
		
		
		/// <summary>
		/// <para>Overridable check for a component to indicate to its Owner that it should prevent the Actor from auto destroying when finished </para>
		/// </summary>
		public override bool IsReadyForOwnerToAutoDestroy()
			=> E_UCharacterMovementComponent_IsReadyForOwnerToAutoDestroy(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_UCharacterMovementComponent_IsSupportedForNetworking(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_UCharacterMovementComponent_MarkAsEditorOnlySubobject(this);
		
		public override bool NeedsLoadForClient()
			=> E_UCharacterMovementComponent_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_UCharacterMovementComponent_NeedsLoadForEditorGame(this);
		
		public override bool NeedsLoadForServer()
			=> E_UCharacterMovementComponent_NeedsLoadForServer(this);
		
		
		/// <summary>
		/// <para>Called on each component when the Actor's bEnableCollisionChanged flag changes </para>
		/// </summary>
		public override void OnActorEnableCollisionChanged()
			=> E_UCharacterMovementComponent_OnActorEnableCollisionChanged(this);
		
		
		/// <summary>
		/// <para>Called when a component is created (not loaded) </para>
		/// </summary>
		public override void OnComponentCreated()
			=> E_UCharacterMovementComponent_OnComponentCreated(this);
		
		
		/// <summary>
		/// <para>Called when a component is destroyed </para>
		/// <param name="bDestroyingHierarchy">True if the entire component hierarchy is being torn down, allows avoiding expensive operations </param>
		/// </summary>
		public override void OnComponentDestroyed(bool bDestroyingHierarchy)
			=> E_UCharacterMovementComponent_OnComponentDestroyed(this, bDestroyingHierarchy);
		
		
		/// <summary>
		/// <para>Used to create any physics engine information for this component </para>
		/// </summary>
		protected override void OnCreatePhysicsState()
			=> E_UCharacterMovementComponent_OnCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Used to shut down and physics engine structure for this component </para>
		/// </summary>
		protected override void OnDestroyPhysicsState()
			=> E_UCharacterMovementComponent_OnDestroyPhysicsState(this);
		
		
		/// <summary>
		/// <para>Called when a component is unregistered. Called after DestroyRenderState_Concurrent and OnDestroyPhysicsState are called. </para>
		/// </summary>
		public override void OnUnregister()
			=> E_UCharacterMovementComponent_OnUnregister(this);
		
		public override void PostInitProperties()
			=> E_UCharacterMovementComponent_PostInitProperties(this);
		
		public override void PostNetReceive()
			=> E_UCharacterMovementComponent_PostNetReceive(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_UCharacterMovementComponent_PostRename(this, OldOuter, OldName);
		
		public override void PreNetReceive()
			=> E_UCharacterMovementComponent_PreNetReceive(this);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_UCharacterMovementComponent_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_UCharacterMovementComponent_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame recreates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameRecreate()
			=> E_UCharacterMovementComponent_RequiresGameThreadEndOfFrameRecreate(this);
		
		
		/// <summary>
		/// <para>return true if this component requires end of frame updates to happen from the game thread. </para>
		/// </summary>
		public override bool RequiresGameThreadEndOfFrameUpdates()
			=> E_UCharacterMovementComponent_RequiresGameThreadEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Called to send dynamic data for this component to the rendering thread </para>
		/// </summary>
		protected override void SendRenderDynamicData_Concurrent()
			=> E_UCharacterMovementComponent_SendRenderDynamicData_Concurrent(this);
		
		
		/// <summary>
		/// <para>Called to send a transform update for this component to the rendering thread </para>
		/// <para>Caution**, this is called concurrently on multiple threads (but never the same component concurrently) </para>
		/// </summary>
		public override void SendRenderTransform_Concurrent()
			=> E_UCharacterMovementComponent_SendRenderTransform_Concurrent(this);
		
		
		/// <summary>
		/// <para>Sets whether the component is active or not </para>
		/// <param name="bNewActive">The new active state of the component </param>
		/// </summary>
		public override void SetActive(bool bNewActive, bool bReset)
			=> E_UCharacterMovementComponent_SetActive(this, bNewActive, bReset);
		
		
		/// <summary>
		/// <para>Sets whether the component should be auto activate or not. Only safe during construction scripts. </para>
		/// <param name="bNewAutoActivate">The new auto activate state of the component </param>
		/// </summary>
		public override void SetAutoActivate(bool bNewAutoActivate)
			=> E_UCharacterMovementComponent_SetAutoActivate(this, bNewAutoActivate);
		
		
		/// <summary>
		/// <para>Set this component's tick functions to be enabled or disabled. Only has an effect if the function is registered </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabled(bool bEnabled)
			=> E_UCharacterMovementComponent_SetComponentTickEnabled(this, bEnabled);
		
		
		/// <summary>
		/// <para>Spawns a task on GameThread that will call SetComponentTickEnabled </para>
		/// <param name="bEnabled">Whether it should be enabled or not </param>
		/// </summary>
		public override void SetComponentTickEnabledAsync(bool bEnabled)
			=> E_UCharacterMovementComponent_SetComponentTickEnabledAsync(this, bEnabled);
		
		
		/// <summary>
		/// <para>"Trigger" related function. Return true if it should activate </para>
		/// </summary>
		protected override bool ShouldActivate()
			=> E_UCharacterMovementComponent_ShouldActivate(this);
		
		
		/// <summary>
		/// <para>Return true if CreatePhysicsState() should be called. </para>
		/// <para>Ideally CreatePhysicsState() should always succeed if this returns true, but this isn't currently the case </para>
		/// </summary>
		public override bool ShouldCreatePhysicsState()
			=> E_UCharacterMovementComponent_ShouldCreatePhysicsState(this);
		
		
		/// <summary>
		/// <para>Return true if CreateRenderState() should be called </para>
		/// </summary>
		public override bool ShouldCreateRenderState()
			=> E_UCharacterMovementComponent_ShouldCreateRenderState(this);
		
		
		/// <summary>
		/// <para>Toggles the active state of the component </para>
		/// </summary>
		public override void ToggleActive()
			=> E_UCharacterMovementComponent_ToggleActive(this);
		
		
		/// <summary>
		/// <para>Handle this component being Uninitialized. </para>
		/// <para>Called from AActor::EndPlay only if bHasBeenInitialized is true </para>
		/// </summary>
		public override void UninitializeComponent()
			=> E_UCharacterMovementComponent_UninitializeComponent(this);
		
		
		/// <summary>
		/// <para>Recalculate the value of our component to world transform </para>
		/// </summary>
		public override void UpdateComponentToWorld(EUpdateTransformFlags UpdateTransformFlags, ETeleportType Teleport)
			=> E_UCharacterMovementComponent_UpdateComponentToWorld(this, (byte)UpdateTransformFlags, (byte)Teleport);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_UCharacterMovementComponent_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public override bool CheckDefaultSubobjectsInternal()
			=> E_UCharacterMovementComponent_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E_UCharacterMovementComponent_FinishDestroy(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_UCharacterMovementComponent_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_UCharacterMovementComponent_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_UCharacterMovementComponent_IsAsset(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_UCharacterMovementComponent_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_UCharacterMovementComponent_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_UCharacterMovementComponent_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the </para>
		/// <para>potentially asynchronous object cleanup. </para>
		/// <return>True if the object's asynchronous cleanup has completed and it is ready for FinishDestroy to be called. </return>
		/// </summary>
		public override bool IsReadyForFinishDestroy()
			=> E_UCharacterMovementComponent_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_UCharacterMovementComponent_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_UCharacterMovementComponent_Modify(this, bAlwaysMarkDirty);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_UCharacterMovementComponent_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_UCharacterMovementComponent_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_UCharacterMovementComponent_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies()
			=> E_UCharacterMovementComponent_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UCharacterMovementComponent_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_UCharacterMovementComponent_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_UCharacterMovementComponent_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_UCharacterMovementComponent_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_UCharacterMovementComponent_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public override bool CanBeInCluster()
			=> E_UCharacterMovementComponent_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_UCharacterMovementComponent_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_UCharacterMovementComponent_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(UCharacterMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UCharacterMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCharacterMovementComponent>(PtrDesc);
		}}}
