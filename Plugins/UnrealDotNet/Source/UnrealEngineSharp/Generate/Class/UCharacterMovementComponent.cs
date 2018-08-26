// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:157

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
		private static extern void E_UCharacterMovementComponent_AddForce(IntPtr self, IntPtr force);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AddImpulse(IntPtr self, IntPtr impulse, bool bVelocityChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AdjustFloorHeight(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_AdjustProxyCapsuleSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyAccumulatedForces(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyDownwardForce(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyImpactPhysicsForces(IntPtr self, IntPtr impact, IntPtr impactAcceleration, IntPtr impactVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyNetworkMovementMode(IntPtr self, byte receivedMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyRepulsionForce(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ApplyRequestedMove(IntPtr self, float deltaTime, float maxAccel, float maxSpeed, float friction, float brakingDeceleration, IntPtr outAcceleration, float outRequestedSpeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ApplyVelocityBraking(IntPtr self, float deltaTime, float friction, float brakingDeceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_BoostAirControl(IntPtr self, float deltaTime, float tickAirControl, IntPtr fallAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_CalcVelocity(IntPtr self, float deltaTime, float friction, bool bFluid, float brakingDeceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_CallMovementUpdateDelegate(IntPtr self, float deltaSeconds, IntPtr oldLocation, IntPtr oldVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanCrouchInCurrentState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanStepUp(IntPtr self, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CanWalkOffLedges(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_CapsuleTouched(IntPtr self, IntPtr overlappedComp, IntPtr other, IntPtr otherComp, int otherBodyIndex, bool bFromSweep, IntPtr sweepResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CheckFall(IntPtr self, IntPtr oldFloor, IntPtr hit, IntPtr delta, IntPtr oldLocation, float remainingTime, float timeTick, int iterations, bool bMustJump);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CheckLedgeDirection(IntPtr self, IntPtr oldLocation, IntPtr sideStep, IntPtr gravDir);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_CheckWaterJump(IntPtr self, IntPtr checkPoint, IntPtr wallNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClearAccumulatedForces(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAckGoodMove(IntPtr self, float timeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAckGoodMove_Implementation(IntPtr self, float timeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAdjustPosition(IntPtr self, float timeStamp, IntPtr newLoc, IntPtr newVel, IntPtr newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAdjustPosition_Implementation(IntPtr self, float timeStamp, IntPtr newLoc, IntPtr newVel, IntPtr newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ClientUpdatePositionAfterServerUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientVeryShortAdjustPosition(IntPtr self, float timeStamp, IntPtr newLoc, IntPtr newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientVeryShortAdjustPosition_Implementation(IntPtr self, float timeStamp, IntPtr newLoc, IntPtr newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_ComputeAnalogInputModifier(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ComputeFloorDist(IntPtr self, IntPtr capsuleLocation, float lineDistance, float sweepDistance, IntPtr outFloorResult, float sweepRadius, IntPtr downwardSweepResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ComputeGroundMovementDelta(IntPtr self, IntPtr delta, IntPtr rampHit, bool bHitFromLineTrace);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ComputeOrientToMovementRotation(IntPtr self, IntPtr currentRotation, float deltaTime, IntPtr deltaRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ComputePerchResult(IntPtr self, float testRadius, IntPtr inHit, float inMaxFloorDist, IntPtr outPerchFloorResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ConstrainInputAcceleration(IntPtr self, IntPtr inputAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_Crouch(IntPtr self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_DisableMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_DoJump(IntPtr self, bool bReplayingMoves);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_FindBestNavMeshLocation(IntPtr self, IntPtr traceStart, IntPtr traceEnd, IntPtr currentFeetLocation, IntPtr targetNavLocation, IntPtr outHitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_FindFloor(IntPtr self, IntPtr capsuleLocation, IntPtr outFloorResult, bool bZeroDelta, IntPtr downwardSweepResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_FindWaterLine(IntPtr self, IntPtr start, IntPtr end);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ForceClientAdjustment(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ForceReplicationUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetAirControl(IntPtr self, float deltaTime, float tickAirControl, IntPtr fallAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetAnalogInputModifier(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetBestDirectionOffActor(IntPtr self, IntPtr baseActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UCharacterMovementComponent_GetCharacterOwner(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetCurrentAcceleration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetDeltaRotation(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetFallingLateralAcceleration(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UCharacterMovementComponent_GetGroundMovementMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetImpartedMovementBaseVelocity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetLedgeMove(IntPtr self, IntPtr oldLocation, IntPtr delta, IntPtr gravDir);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxAcceleration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxBrakingDeceleration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxJumpHeight(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMaxJumpHeightWithJumpTime(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetMinAnalogSpeed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetModifiedMaxAcceleration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UCharacterMovementComponent_GetMovementBase(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UCharacterMovementComponent_GetMovementName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetNetworkSafeRandomAngleDegrees(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetPerchRadiusThreshold(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetServerLastTransformUpdateTimeStamp(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetSimulationTimeStep(IntPtr self, float remainingTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetValidPerchRadius(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetWalkableFloorAngle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_GetWalkableFloorZ(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_HandlePendingLaunch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_HandleSlopeBoosting(IntPtr self, IntPtr slideResult, IntPtr delta, float time, IntPtr normal, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_HandleSwimmingWallHit(IntPtr self, IntPtr hit, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_HasRootMotionSources(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_HasValidData(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_ImmersionDepth(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsMovementInProgress(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsValidLandingSpot(IntPtr self, IntPtr capsuleLocation, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsWalkable(IntPtr self, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsWalking(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_IsWithinEdgeTolerance(IntPtr self, IntPtr capsuleLocation, IntPtr testImpactPoint, float capsuleRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_JumpOff(IntPtr self, IntPtr movementBaseActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_JumpOutOfWater(IntPtr self, IntPtr wallNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_K2_ComputeFloorDist(IntPtr self, IntPtr capsuleLocation, float lineDistance, float sweepDistance, float sweepRadius, IntPtr floorResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_K2_FindFloor(IntPtr self, IntPtr capsuleLocation, IntPtr floorResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_K2_GetModifiedMaxAcceleration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_K2_GetWalkableFloorAngle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_K2_GetWalkableFloorZ(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_Launch(IntPtr self, IntPtr launchVel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_LimitAirControl(IntPtr self, float deltaTime, IntPtr fallAcceleration, IntPtr hitResult, bool bCheckForValidLandingSpot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MaintainHorizontalGroundVelocity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MaybeSaveBaseLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MaybeUpdateBasedMovement(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MoveAutonomous(IntPtr self, float clientTimeStamp, float deltaTime, byte compressedFlags, IntPtr newAccel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_NewFallVelocity(IntPtr self, IntPtr initialVelocity, IntPtr gravity, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_NotifyJumpApex(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnCharacterStuckInGeometry(IntPtr self, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnClientTimeStampResetDetected(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnMovementModeChanged(IntPtr self, byte previousMovementMode, byte previousCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnMovementUpdated(IntPtr self, float deltaSeconds, IntPtr oldLocation, IntPtr oldVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnTimeDiscrepancyDetected(IntPtr self, float currentTimeDiscrepancy, float lifetimeRawTimeDiscrepancy, float lifetime, float currentMoveError);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_OnUnableToFollowBaseMove(IntPtr self, IntPtr deltaPosition, IntPtr oldLocation, IntPtr moveOnBaseHit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UCharacterMovementComponent_PackNetworkMovementMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PerformAirControlForPathFollowing(IntPtr self, IntPtr direction, float zDiff);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PerformMovement(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysCustom(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysFalling(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysFlying(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysicsRotation(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysNavWalking(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysSwimming(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_PhysWalking(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ProcessLanded(IntPtr self, IntPtr hit, float remainingTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ProjectLocationFromNavMesh(IntPtr self, float deltaSeconds, IntPtr currentFeetLocation, IntPtr targetNavLocation, float upOffset, float downOffset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_RemoveRootMotionSource(IntPtr self, string instanceName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ReplicateMoveToServer(IntPtr self, float deltaTime, IntPtr newAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_RevertMove(IntPtr self, IntPtr oldLocation, IntPtr oldBase, IntPtr inOldBaseLocation, IntPtr oldFloor, bool bFailMove);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_RoundAcceleration(IntPtr self, IntPtr inAccel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SaveBaseLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_ScaleInputAcceleration(IntPtr self, IntPtr inputAcceleration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ServerCheckClientError(IntPtr self, float clientTimeStamp, float deltaTime, IntPtr accel, IntPtr clientWorldLocation, IntPtr relativeClientLocation, IntPtr clientMovementBase, string clientBaseBoneName, byte clientMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ServerMoveHandleClientError(IntPtr self, float clientTimeStamp, float deltaTime, IntPtr accel, IntPtr relativeClientLocation, IntPtr clientMovementBase, string clientBaseBoneName, byte clientMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetAvoidanceEnabled(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetAvoidanceGroup(IntPtr self, int groupFlags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetBase(IntPtr self, IntPtr newBase, string boneName, bool bNotifyActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetBaseFromFloor(IntPtr self, IntPtr floorResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetDefaultMovementMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetGroundMovementMode(IntPtr self, byte newGroundMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetGroupsToAvoid(IntPtr self, int groupFlags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetGroupsToIgnore(IntPtr self, int groupFlags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetMovementMode(IntPtr self, byte newMovementMode, byte newCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetNavWalkingPhysics(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetPostLandedPhysics(IntPtr self, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetWalkableFloorAngle(IntPtr self, float inWalkableFloorAngle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SetWalkableFloorZ(IntPtr self, float inWalkableFloorZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldCancelAdaptiveReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldCatchAir(IntPtr self, IntPtr oldFloor, IntPtr newFloor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldCheckForValidLandingSpot(IntPtr self, float deltaTime, IntPtr delta, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldComputePerchResult(IntPtr self, IntPtr inHit, bool bCheckRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldJumpOutOfWater(IntPtr self, IntPtr jumpDir);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ShouldRemainVertical(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SimulatedTick(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SimulateMovement(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SmoothClientPosition(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SmoothClientPosition_Interpolate(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_SmoothClientPosition_UpdateVisuals(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_StartFalling(IntPtr self, int iterations, float remainingTime, float timeTick, IntPtr delta, IntPtr subLoc);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_StartNewPhysics(IntPtr self, float deltaTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_StartSwimming(IntPtr self, IntPtr oldLocation, IntPtr oldVelocity, float timeTick, float remainingTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UCharacterMovementComponent_Swim(IntPtr self, IntPtr delta, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_TickCharacterPose(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_TryToLeaveNavWalking(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UnCrouch(IntPtr self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateBasedMovement(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateBasedRotation(IntPtr self, IntPtr finalRotation, IntPtr reducedRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateCharacterStateAfterMovement(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateCharacterStateBeforeMovement(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateFloorFromAdjustment(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_UpdateFromCompressedFlags(IntPtr self, byte flags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_VisualizeMovement(IntPtr self);
		
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
		public virtual void AddForce(FVector force)
			=> E_UCharacterMovementComponent_AddForce(this, force);
		
		
		/// <summary>
		/// <para>Add impulse to character. Impulses are accumulated each tick and applied together </para>
		/// <para>so multiple calls to this function will accumulate. </para>
		/// <para>An impulse is an instantaneous force, usually applied once. If you want to continually apply </para>
		/// <para>forces each frame, use AddForce(). </para>
		/// <para>Note that changing the momentum of characters like this can change the movement mode. </para>
		/// <param name="Impulse">Impulse to apply. </param>
		/// <param name="bVelocityChange">Whether or not the impulse is relative to mass. </param>
		/// </summary>
		public virtual void AddImpulse(FVector impulse, bool bVelocityChange)
			=> E_UCharacterMovementComponent_AddImpulse(this, impulse, bVelocityChange);
		
		
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
		public virtual void ApplyAccumulatedForces(float deltaSeconds)
			=> E_UCharacterMovementComponent_ApplyAccumulatedForces(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>Applies downward force when walking on top of physics objects. </para>
		/// <param name="DeltaSeconds">Time elapsed since last frame. </param>
		/// </summary>
		public virtual void ApplyDownwardForce(float deltaSeconds)
			=> E_UCharacterMovementComponent_ApplyDownwardForce(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>Apply physics forces to the impacted component, if bEnablePhysicsInteraction is true. </para>
		/// <param name="Impact">HitResult that resulted in the impact </param>
		/// <param name="ImpactAcceleration">Acceleration of the character at the time of impact </param>
		/// <param name="ImpactVelocity">Velocity of the character at the time of impact </param>
		/// </summary>
		protected virtual void ApplyImpactPhysicsForces(FHitResult impact, FVector impactAcceleration, FVector impactVelocity)
			=> E_UCharacterMovementComponent_ApplyImpactPhysicsForces(this, impact, impactAcceleration, impactVelocity);
		
		public virtual void ApplyNetworkMovementMode(byte receivedMode)
			=> E_UCharacterMovementComponent_ApplyNetworkMovementMode(this, receivedMode);
		
		
		/// <summary>
		/// <para>Applies repulsion force to all touched components. </para>
		/// </summary>
		public virtual void ApplyRepulsionForce(float deltaSeconds)
			=> E_UCharacterMovementComponent_ApplyRepulsionForce(this, deltaSeconds);
		
		
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
		public virtual bool ApplyRequestedMove(float deltaTime, float maxAccel, float maxSpeed, float friction, float brakingDeceleration, FVector outAcceleration, float outRequestedSpeed)
			=> E_UCharacterMovementComponent_ApplyRequestedMove(this, deltaTime, maxAccel, maxSpeed, friction, brakingDeceleration, outAcceleration, outRequestedSpeed);
		
		
		/// <summary>
		/// <para>Slows towards stop. </para>
		/// </summary>
		protected virtual void ApplyVelocityBraking(float deltaTime, float friction, float brakingDeceleration)
			=> E_UCharacterMovementComponent_ApplyVelocityBraking(this, deltaTime, friction, brakingDeceleration);
		
		
		/// <summary>
		/// <para>Increase air control if conditions of AirControlBoostMultiplier and AirControlBoostVelocityThreshold are met. </para>
		/// <para>This function is used internally by GetAirControl(). </para>
		/// <param name="DeltaTime">Time step for the current update. </param>
		/// <param name="TickAirControl">Current air control value. </param>
		/// <param name="FallAcceleration">Acceleration used during movement. </param>
		/// <return>Modified air control to use during falling movement </return>
		/// <para>@see GetAirControl() </para>
		/// </summary>
		protected virtual float BoostAirControl(float deltaTime, float tickAirControl, FVector fallAcceleration)
			=> E_UCharacterMovementComponent_BoostAirControl(this, deltaTime, tickAirControl, fallAcceleration);
		
		
		/// <summary>
		/// <para>Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity. </para>
		/// <para>This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes. </para>
		/// <param name="DeltaTime">time elapsed since last frame. </param>
		/// <param name="Friction">coefficient of friction when not accelerating, or in the direction opposite acceleration. </param>
		/// <param name="bFluid">true if moving through a fluid, causing Friction to always be applied regardless of acceleration. </param>
		/// <param name="BrakingDeceleration">deceleration applied when not accelerating, or when exceeding max velocity. </param>
		/// </summary>
		public virtual void CalcVelocity(float deltaTime, float friction, bool bFluid, float brakingDeceleration)
			=> E_UCharacterMovementComponent_CalcVelocity(this, deltaTime, friction, bFluid, brakingDeceleration);
		
		
		/// <summary>
		/// <para>Internal function to call OnMovementUpdated delegate on CharacterOwner. </para>
		/// </summary>
		protected virtual void CallMovementUpdateDelegate(float deltaSeconds, FVector oldLocation, FVector oldVelocity)
			=> E_UCharacterMovementComponent_CallMovementUpdateDelegate(this, deltaSeconds, oldLocation, oldVelocity);
		
		
		/// <summary>
		/// <return>true if the character is allowed to crouch in the current state. By default it is allowed when walking or falling, if CanEverCrouch() is true. </return>
		/// </summary>
		public virtual bool CanCrouchInCurrentState()
			=> E_UCharacterMovementComponent_CanCrouchInCurrentState(this);
		
		
		/// <summary>
		/// <return>true if we can step up on the actor in the given FHitResult. </return>
		/// </summary>
		public virtual bool CanStepUp(FHitResult hit)
			=> E_UCharacterMovementComponent_CanStepUp(this, hit);
		
		
		/// <summary>
		/// <return>whether this pawn is currently allowed to walk off ledges </return>
		/// </summary>
		public virtual bool CanWalkOffLedges()
			=> E_UCharacterMovementComponent_CanWalkOffLedges(this);
		
		protected virtual void CapsuleTouched(UPrimitiveComponent overlappedComp, AActor other, UPrimitiveComponent otherComp, int otherBodyIndex, bool bFromSweep, FHitResult sweepResult)
			=> E_UCharacterMovementComponent_CapsuleTouched(this, overlappedComp, other, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		
		
		/// <summary>
		/// <para>Check if pawn is falling </para>
		/// </summary>
		public virtual bool CheckFall(FFindFloorResult oldFloor, FHitResult hit, FVector delta, FVector oldLocation, float remainingTime, float timeTick, int iterations, bool bMustJump)
			=> E_UCharacterMovementComponent_CheckFall(this, oldFloor, hit, delta, oldLocation, remainingTime, timeTick, iterations, bMustJump);
		
		
		/// <summary>
		/// <return>true if there is a suitable floor SideStep from current position. </return>
		/// </summary>
		public virtual bool CheckLedgeDirection(FVector oldLocation, FVector sideStep, FVector gravDir)
			=> E_UCharacterMovementComponent_CheckLedgeDirection(this, oldLocation, sideStep, gravDir);
		
		
		/// <summary>
		/// <para>Check if swimming pawn just ran into edge of the pool and should jump out. </para>
		/// </summary>
		public virtual bool CheckWaterJump(FVector checkPoint, FVector wallNormal)
			=> E_UCharacterMovementComponent_CheckWaterJump(this, checkPoint, wallNormal);
		
		
		/// <summary>
		/// <para>Clears forces accumulated through AddImpulse() and AddForce(), and also pending launch velocity. </para>
		/// </summary>
		public virtual void ClearAccumulatedForces()
			=> E_UCharacterMovementComponent_ClearAccumulatedForces(this);
		
		
		/// <summary>
		/// <para>If no client adjustment is needed after processing received ServerMove(), ack the good move so client can remove it from SavedMoves </para>
		/// </summary>
		public virtual void ClientAckGoodMove(float timeStamp)
			=> E_UCharacterMovementComponent_ClientAckGoodMove(this, timeStamp);
		
		public virtual void ClientAckGoodMove_Implementation(float timeStamp)
			=> E_UCharacterMovementComponent_ClientAckGoodMove_Implementation(this, timeStamp);
		
		
		/// <summary>
		/// <para>Replicate position correction to client, associated with a timestamped servermove.  Client will replay subsequent moves after applying adjustment. </para>
		/// </summary>
		public virtual void ClientAdjustPosition(float timeStamp, FVector newLoc, FVector newVel, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustPosition(this, timeStamp, newLoc, newVel, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		public virtual void ClientAdjustPosition_Implementation(float timeStamp, FVector newLoc, FVector newVel, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustPosition_Implementation(this, timeStamp, newLoc, newVel, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		
		/// <summary>
		/// <para>If bUpdatePosition is true, then replay any unacked moves. Returns whether any moves were actually replayed. </para>
		/// </summary>
		protected virtual bool ClientUpdatePositionAfterServerUpdate()
			=> E_UCharacterMovementComponent_ClientUpdatePositionAfterServerUpdate(this);
		
		public virtual void ClientVeryShortAdjustPosition(float timeStamp, FVector newLoc, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientVeryShortAdjustPosition(this, timeStamp, newLoc, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		public virtual void ClientVeryShortAdjustPosition_Implementation(float timeStamp, FVector newLoc, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientVeryShortAdjustPosition_Implementation(this, timeStamp, newLoc, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		
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
		public virtual void ComputeFloorDist(FVector capsuleLocation, float lineDistance, float sweepDistance, FFindFloorResult outFloorResult, float sweepRadius, FHitResult downwardSweepResult)
			=> E_UCharacterMovementComponent_ComputeFloorDist(this, capsuleLocation, lineDistance, sweepDistance, outFloorResult, sweepRadius, downwardSweepResult);
		
		
		/// <summary>
		/// <para>Compute a vector of movement, given a delta and a hit result of the surface we are on. </para>
		/// <param name="Delta">Attempted movement direction </param>
		/// <param name="RampHit">Hit result of sweep that found the ramp below the capsule </param>
		/// <param name="bHitFromLineTrace">Whether the floor trace came from a line trace </param>
		/// <return>If on a walkable surface, this returns a vector that moves parallel to the surface. The magnitude may be scaled if bMaintainHorizontalGroundVelocity is true. </return>
		/// <para>If a ramp vector can't be computed, this will just return Delta. </para>
		/// </summary>
		protected virtual FVector ComputeGroundMovementDelta(FVector delta, FHitResult rampHit, bool bHitFromLineTrace)
			=> E_UCharacterMovementComponent_ComputeGroundMovementDelta(this, delta, rampHit, bHitFromLineTrace);
		
		
		/// <summary>
		/// <para>Compute a target rotation based on current movement. Used by PhysicsRotation() when bOrientRotationToMovement is true. </para>
		/// <para>Default implementation targets a rotation based on Acceleration. </para>
		/// <param name="CurrentRotation">Current rotation of the Character </param>
		/// <param name="DeltaTime">Time slice for this movement </param>
		/// <param name="DeltaRotation">Proposed rotation change based simply on DeltaTime * RotationRate </param>
		/// <return>The target rotation given current movement. </return>
		/// </summary>
		public virtual FRotator ComputeOrientToMovementRotation(FRotator currentRotation, float deltaTime, FRotator deltaRotation)
			=> E_UCharacterMovementComponent_ComputeOrientToMovementRotation(this, currentRotation, deltaTime, deltaRotation);
		
		
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
		public virtual bool ComputePerchResult(float testRadius, FHitResult inHit, float inMaxFloorDist, FFindFloorResult outPerchFloorResult)
			=> E_UCharacterMovementComponent_ComputePerchResult(this, testRadius, inHit, inMaxFloorDist, outPerchFloorResult);
		
		
		/// <summary>
		/// <para>Enforce constraints on input given current state. For instance, don't move upwards if walking and looking up. </para>
		/// </summary>
		protected virtual FVector ConstrainInputAcceleration(FVector inputAcceleration)
			=> E_UCharacterMovementComponent_ConstrainInputAcceleration(this, inputAcceleration);
		
		
		/// <summary>
		/// <para>Checks if new capsule size fits (no encroachment), and call CharacterOwner->OnStartCrouch() if successful. </para>
		/// <para>In general you should set bWantsToCrouch instead to have the crouch persist during movement, or just use the crouch functions on the owning Character. </para>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset. </param>
		/// </summary>
		public virtual void Crouch(bool bClientSimulation)
			=> E_UCharacterMovementComponent_Crouch(this, bClientSimulation);
		
		
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
		protected virtual void FindBestNavMeshLocation(FVector traceStart, FVector traceEnd, FVector currentFeetLocation, FVector targetNavLocation, FHitResult outHitResult)
			=> E_UCharacterMovementComponent_FindBestNavMeshLocation(this, traceStart, traceEnd, currentFeetLocation, targetNavLocation, outHitResult);
		
		
		/// <summary>
		/// <para>Sweeps a vertical trace to find the floor for the capsule at the given location. Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result. </para>
		/// <para>No floor will be found if collision is disabled on the capsule! </para>
		/// <param name="CapsuleLocation">Location where the capsule sweep should originate </param>
		/// <param name="OutFloorResult">Out] Contains the result of the floor check. The HitResult will contain the valid sweep or line test upon success, or the result of the sweep upon failure. </param>
		/// <param name="bZeroDelta">If true, the capsule was not actively moving in this update (can be used to avoid unnecessary floor tests). </param>
		/// <param name="DownwardSweepResult">If non-null and it contains valid blocking hit info, this will be used as the result of a downward sweep test instead of doing it as part of the update. </param>
		/// </summary>
		public virtual void FindFloor(FVector capsuleLocation, FFindFloorResult outFloorResult, bool bZeroDelta, FHitResult downwardSweepResult)
			=> E_UCharacterMovementComponent_FindFloor(this, capsuleLocation, outFloorResult, bZeroDelta, downwardSweepResult);
		
		
		/// <summary>
		/// <para>Get as close to waterline as possible, staying on same side as currently. </para>
		/// </summary>
		public FVector FindWaterLine(FVector start, FVector end)
			=> E_UCharacterMovementComponent_FindWaterLine(this, start, end);
		
		
		/// <summary>
		/// <para>Force a client adjustment. Resets ServerLastClientAdjustmentTime. </para>
		/// </summary>
		public void ForceClientAdjustment()
			=> E_UCharacterMovementComponent_ForceClientAdjustment(this);
		
		
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
		public virtual FVector GetAirControl(float deltaTime, float tickAirControl, FVector fallAcceleration)
			=> E_UCharacterMovementComponent_GetAirControl(this, deltaTime, tickAirControl, fallAcceleration);
		
		
		/// <summary>
		/// <return>Modifier [0..1] based on the magnitude of the last input vector, which is used to modify the acceleration and max speed during movement. </return>
		/// </summary>
		public float GetAnalogInputModifier()
			=> E_UCharacterMovementComponent_GetAnalogInputModifier(this);
		
		
		/// <summary>
		/// <para>Can be overridden to choose to jump based on character velocity, base actor dimensions, etc. </para>
		/// </summary>
		public virtual FVector GetBestDirectionOffActor(AActor baseActor)
			=> E_UCharacterMovementComponent_GetBestDirectionOffActor(this, baseActor);
		
		
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
		public virtual FRotator GetDeltaRotation(float deltaTime)
			=> E_UCharacterMovementComponent_GetDeltaRotation(this, deltaTime);
		
		
		/// <summary>
		/// <para>Get the lateral acceleration to use during falling movement. The Z component of the result is ignored. </para>
		/// <para>Default implementation returns current Acceleration value modified by GetAirControl(), with Z component removed, </para>
		/// <para>with magnitude clamped to GetMaxAcceleration(). </para>
		/// <para>This function is used internally by PhysFalling(). </para>
		/// <param name="DeltaTime">Time step for the current update. </param>
		/// <return>Acceleration to use during falling movement. </return>
		/// </summary>
		public virtual FVector GetFallingLateralAcceleration(float deltaTime)
			=> E_UCharacterMovementComponent_GetFallingLateralAcceleration(this, deltaTime);
		
		
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
		public virtual FVector GetLedgeMove(FVector oldLocation, FVector delta, FVector gravDir)
			=> E_UCharacterMovementComponent_GetLedgeMove(this, oldLocation, delta, gravDir);
		
		
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
		public float GetSimulationTimeStep(float remainingTime, int iterations)
			=> E_UCharacterMovementComponent_GetSimulationTimeStep(this, remainingTime, iterations);
		
		
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
		protected virtual FVector HandleSlopeBoosting(FVector slideResult, FVector delta, float time, FVector normal, FHitResult hit)
			=> E_UCharacterMovementComponent_HandleSlopeBoosting(this, slideResult, delta, time, normal, hit);
		
		protected virtual void HandleSwimmingWallHit(FHitResult hit, float deltaTime)
			=> E_UCharacterMovementComponent_HandleSwimmingWallHit(this, hit, deltaTime);
		
		
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
		
		
		/// <summary>
		/// <return>true if currently performing a movement update. </return>
		/// <para>@see bMovementInProgress </para>
		/// </summary>
		public bool IsMovementInProgress()
			=> E_UCharacterMovementComponent_IsMovementInProgress(this);
		
		
		/// <summary>
		/// <para>Verify that the supplied hit result is a valid landing spot when falling. </para>
		/// </summary>
		public virtual bool IsValidLandingSpot(FVector capsuleLocation, FHitResult hit)
			=> E_UCharacterMovementComponent_IsValidLandingSpot(this, capsuleLocation, hit);
		
		
		/// <summary>
		/// <para>Return true if the hit result should be considered a walkable surface for the character. </para>
		/// </summary>
		public virtual bool IsWalkable(FHitResult hit)
			=> E_UCharacterMovementComponent_IsWalkable(this, hit);
		
		
		/// <summary>
		/// <return>true if the character is in the 'Walking' movement mode. </return>
		/// </summary>
		public bool IsWalking()
			=> E_UCharacterMovementComponent_IsWalking(this);
		
		
		/// <summary>
		/// <para>Return true if the 2D distance to the impact point is inside the edge tolerance (CapsuleRadius minus a small rejection threshold). </para>
		/// <para>Useful for rejecting adjacent hits when finding a floor or landing spot. </para>
		/// </summary>
		public virtual bool IsWithinEdgeTolerance(FVector capsuleLocation, FVector testImpactPoint, float capsuleRadius)
			=> E_UCharacterMovementComponent_IsWithinEdgeTolerance(this, capsuleLocation, testImpactPoint, capsuleRadius);
		
		
		/// <summary>
		/// <para>Force this pawn to bounce off its current base, which isn't an acceptable base for it. </para>
		/// </summary>
		public virtual void JumpOff(AActor movementBaseActor)
			=> E_UCharacterMovementComponent_JumpOff(this, movementBaseActor);
		
		
		/// <summary>
		/// <para>Jump onto shore from water </para>
		/// </summary>
		public virtual void JumpOutOfWater(FVector wallNormal)
			=> E_UCharacterMovementComponent_JumpOutOfWater(this, wallNormal);
		
		
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
		public virtual void ComputeFloorDistance(FVector capsuleLocation, float lineDistance, float sweepDistance, float sweepRadius, FFindFloorResult floorResult)
			=> E_UCharacterMovementComponent_K2_ComputeFloorDist(this, capsuleLocation, lineDistance, sweepDistance, sweepRadius, floorResult);
		
		
		/// <summary>
		/// <para>Sweeps a vertical trace to find the floor for the capsule at the given location. Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result. </para>
		/// <para>No floor will be found if collision is disabled on the capsule! </para>
		/// <param name="CapsuleLocation">Location where the capsule sweep should originate </param>
		/// <param name="FloorResult">Result of the floor check </param>
		/// </summary>
		public virtual void K2_FindFloor(FVector capsuleLocation, FFindFloorResult floorResult)
			=> E_UCharacterMovementComponent_K2_FindFloor(this, capsuleLocation, floorResult);
		
		
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
		public virtual void Launch(FVector launchVel)
			=> E_UCharacterMovementComponent_Launch(this, launchVel);
		
		
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
		protected virtual FVector LimitAirControl(float deltaTime, FVector fallAcceleration, FHitResult hitResult, bool bCheckForValidLandingSpot)
			=> E_UCharacterMovementComponent_LimitAirControl(this, deltaTime, fallAcceleration, hitResult, bCheckForValidLandingSpot);
		
		
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
		public virtual void MaybeUpdateBasedMovement(float deltaSeconds)
			=> E_UCharacterMovementComponent_MaybeUpdateBasedMovement(this, deltaSeconds);
		
		protected virtual void MoveAutonomous(float clientTimeStamp, float deltaTime, byte compressedFlags, FVector newAccel)
			=> E_UCharacterMovementComponent_MoveAutonomous(this, clientTimeStamp, deltaTime, compressedFlags, newAccel);
		
		
		/// <summary>
		/// <para>Compute new falling velocity from given velocity and gravity. Applies the limits of the current Physics Volume's TerminalVelocity. </para>
		/// </summary>
		public virtual FVector NewFallVelocity(FVector initialVelocity, FVector gravity, float deltaTime)
			=> E_UCharacterMovementComponent_NewFallVelocity(this, initialVelocity, gravity, deltaTime);
		
		
		/// <summary>
		/// <para>Called if bNotifyApex is true and character has just passed the apex of its jump. </para>
		/// </summary>
		public virtual void NotifyJumpApex()
			=> E_UCharacterMovementComponent_NotifyJumpApex(this);
		
		
		/// <summary>
		/// <para>Notification that the character is stuck in geometry.  Only called during walking movement. </para>
		/// </summary>
		protected virtual void OnCharacterStuckInGeometry(FHitResult hit)
			=> E_UCharacterMovementComponent_OnCharacterStuckInGeometry(this, hit);
		
		
		/// <summary>
		/// <para>Called by UCharacterMovementComponent::VerifyClientTimeStamp() when a client timestamp reset has been detected and is valid. </para>
		/// </summary>
		protected virtual void OnClientTimeStampResetDetected()
			=> E_UCharacterMovementComponent_OnClientTimeStampResetDetected(this);
		
		
		/// <summary>
		/// <para>Called after MovementMode has changed. Base implementation does special handling for starting certain modes, then notifies the CharacterOwner. </para>
		/// </summary>
		protected virtual void OnMovementModeChanged(EMovementMode previousMovementMode, byte previousCustomMode)
			=> E_UCharacterMovementComponent_OnMovementModeChanged(this, (byte)previousMovementMode, previousCustomMode);
		
		
		/// <summary>
		/// <para>Event triggered at the end of a movement update. If scoped movement updates are enabled (bEnableScopedMovementUpdates), this is within such a scope. </para>
		/// <para>If that is not desired, bind to the CharacterOwner's OnMovementUpdated event instead, as that is triggered after the scoped movement update. </para>
		/// </summary>
		protected virtual void OnMovementUpdated(float deltaSeconds, FVector oldLocation, FVector oldVelocity)
			=> E_UCharacterMovementComponent_OnMovementUpdated(this, deltaSeconds, oldLocation, oldVelocity);
		
		
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
		protected virtual void OnTimeDiscrepancyDetected(float currentTimeDiscrepancy, float lifetimeRawTimeDiscrepancy, float lifetime, float currentMoveError)
			=> E_UCharacterMovementComponent_OnTimeDiscrepancyDetected(this, currentTimeDiscrepancy, lifetimeRawTimeDiscrepancy, lifetime, currentMoveError);
		
		
		/// <summary>
		/// <para>Event triggered when we are moving on a base but we are not able to move the full DeltaPosition because something has blocked us. </para>
		/// <para>Note: MoveComponentFlags includes the flag to ignore the movement base while this event is fired. </para>
		/// <param name="DeltaPosition">How far we tried to move with the base. </param>
		/// <param name="OldLocation">Location before we tried to move with the base. </param>
		/// <param name="MoveOnBaseHit">Hit result for the object we hit when trying to move with the base. </param>
		/// </summary>
		protected virtual void OnUnableToFollowBaseMove(FVector deltaPosition, FVector oldLocation, FHitResult moveOnBaseHit)
			=> E_UCharacterMovementComponent_OnUnableToFollowBaseMove(this, deltaPosition, oldLocation, moveOnBaseHit);
		
		public byte PackNetworkMovementMode()
			=> E_UCharacterMovementComponent_PackNetworkMovementMode(this);
		
		
		/// <summary>
		/// <para>Update Velocity and Acceleration to air control in the desired Direction for character using path following. </para>
		/// <param name="Direction">is the desired direction of movement </param>
		/// <param name="ZDiff">is the height difference between the destination and the Pawn's current position </param>
		/// <para>@see RequestDirectMove() </para>
		/// </summary>
		public virtual void PerformAirControlForPathFollowing(FVector direction, float zDiff)
			=> E_UCharacterMovementComponent_PerformAirControlForPathFollowing(this, direction, zDiff);
		
		
		/// <summary>
		/// <para>Perform movement on an autonomous client </para>
		/// </summary>
		protected virtual void PerformMovement(float deltaTime)
			=> E_UCharacterMovementComponent_PerformMovement(this, deltaTime);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysCustom(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysCustom(this, deltaTime, iterations);
		
		
		/// <summary>
		/// <para>Handle falling movement. </para>
		/// </summary>
		public virtual void PhysFalling(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysFalling(this, deltaTime, iterations);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysFlying(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysFlying(this, deltaTime, iterations);
		
		
		/// <summary>
		/// <para>Perform rotation over deltaTime </para>
		/// </summary>
		public virtual void PhysicsRotation(float deltaTime)
			=> E_UCharacterMovementComponent_PhysicsRotation(this, deltaTime);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysNavWalking(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysNavWalking(this, deltaTime, iterations);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysSwimming(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysSwimming(this, deltaTime, iterations);
		
		
		/// <summary>
		/// <para>@note Movement update functions should only be called through StartNewPhysics() </para>
		/// </summary>
		protected virtual void PhysWalking(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysWalking(this, deltaTime, iterations);
		
		
		/// <summary>
		/// <para>Handle landing against Hit surface over remaingTime and iterations, calling SetPostLandedPhysics() and starting the new movement mode. </para>
		/// </summary>
		protected virtual void ProcessLanded(FHitResult hit, float remainingTime, int iterations)
			=> E_UCharacterMovementComponent_ProcessLanded(this, hit, remainingTime, iterations);
		
		
		/// <summary>
		/// <para>Attempts to better align navmesh walking characters with underlying geometry (sometimes </para>
		/// <para>navmesh can differ quite significantly from geometry). </para>
		/// <para>Updates CachedProjectedNavMeshHitResult, access this for more info about hits. </para>
		/// </summary>
		protected virtual FVector ProjectLocationFromNavMesh(float deltaSeconds, FVector currentFeetLocation, FVector targetNavLocation, float upOffset, float downOffset)
			=> E_UCharacterMovementComponent_ProjectLocationFromNavMesh(this, deltaSeconds, currentFeetLocation, targetNavLocation, upOffset, downOffset);
		
		
		/// <summary>
		/// <para>Remove a RootMotionSource from current root motion by name </para>
		/// </summary>
		public void RemoveRootMotionSource(string instanceName)
			=> E_UCharacterMovementComponent_RemoveRootMotionSource(this, instanceName);
		
		
		/// <summary>
		/// <para>Perform local movement and send the move to the server. </para>
		/// </summary>
		protected virtual void ReplicateMoveToServer(float deltaTime, FVector newAcceleration)
			=> E_UCharacterMovementComponent_ReplicateMoveToServer(this, deltaTime, newAcceleration);
		
		
		/// <summary>
		/// <para>Revert to previous position OldLocation, return to being based on OldBase. </para>
		/// <para>if bFailMove, stop movement and notify controller </para>
		/// </summary>
		public void RevertMove(FVector oldLocation, UPrimitiveComponent oldBase, FVector inOldBaseLocation, FFindFloorResult oldFloor, bool bFailMove)
			=> E_UCharacterMovementComponent_RevertMove(this, oldLocation, oldBase, inOldBaseLocation, oldFloor, bFailMove);
		
		
		/// <summary>
		/// <para>Round acceleration, for better consistency and lower bandwidth in networked games. </para>
		/// </summary>
		public virtual FVector RoundAcceleration(FVector inAccel)
			=> E_UCharacterMovementComponent_RoundAcceleration(this, inAccel);
		
		
		/// <summary>
		/// <para>Update OldBaseLocation and OldBaseQuat if there is a valid movement base, and store the relative location/rotation if necessary. Ignores bDeferUpdateBasedMovement and forces the update. </para>
		/// </summary>
		public virtual void SaveBaseLocation()
			=> E_UCharacterMovementComponent_SaveBaseLocation(this);
		
		
		/// <summary>
		/// <para>Scale input acceleration, based on movement acceleration rate. </para>
		/// </summary>
		protected virtual FVector ScaleInputAcceleration(FVector inputAcceleration)
			=> E_UCharacterMovementComponent_ScaleInputAcceleration(this, inputAcceleration);
		
		
		/// <summary>
		/// <para>Check for Server-Client disagreement in position or other movement state important enough to trigger a client correction. </para>
		/// <para>@see ServerMoveHandleClientError() </para>
		/// </summary>
		protected virtual bool ServerCheckClientError(float clientTimeStamp, float deltaTime, FVector accel, FVector clientWorldLocation, FVector relativeClientLocation, UPrimitiveComponent clientMovementBase, string clientBaseBoneName, byte clientMovementMode)
			=> E_UCharacterMovementComponent_ServerCheckClientError(this, clientTimeStamp, deltaTime, accel, clientWorldLocation, relativeClientLocation, clientMovementBase, clientBaseBoneName, clientMovementMode);
		
		
		/// <summary>
		/// <para>Have the server check if the client is outside an error tolerance, and queue a client adjustment if so. </para>
		/// <para>If either GetPredictionData_Server_Character()->bForceClientUpdate or ServerCheckClientError() are true, the client adjustment will be sent. </para>
		/// <para>RelativeClientLocation will be a relative location if MovementBaseUtility::UseRelativePosition(ClientMovementBase) is true, or a world location if false. </para>
		/// <para>@see ServerCheckClientError() </para>
		/// </summary>
		protected virtual void ServerMoveHandleClientError(float clientTimeStamp, float deltaTime, FVector accel, FVector relativeClientLocation, UPrimitiveComponent clientMovementBase, string clientBaseBoneName, byte clientMovementMode)
			=> E_UCharacterMovementComponent_ServerMoveHandleClientError(this, clientTimeStamp, deltaTime, accel, relativeClientLocation, clientMovementBase, clientBaseBoneName, clientMovementMode);
		
		
		/// <summary>
		/// <para>Change avoidance state and registers in RVO manager if needed </para>
		/// </summary>
		public void SetAvoidanceEnabled(bool bEnable)
			=> E_UCharacterMovementComponent_SetAvoidanceEnabled(this, bEnable);
		
		public void SetAvoidanceGroup(int groupFlags)
			=> E_UCharacterMovementComponent_SetAvoidanceGroup(this, groupFlags);
		
		
		/// <summary>
		/// <para>Update the base of the character, which is the PrimitiveComponent we are standing on. </para>
		/// </summary>
		public virtual void SetBase(UPrimitiveComponent newBase, string boneName, bool bNotifyActor)
			=> E_UCharacterMovementComponent_SetBase(this, newBase, boneName, bNotifyActor);
		
		
		/// <summary>
		/// <para>Update the base of the character, using the given floor result if it is walkable, or null if not. Calls SetBase(). </para>
		/// </summary>
		public void SetBaseFromFloor(FFindFloorResult floorResult)
			=> E_UCharacterMovementComponent_SetBaseFromFloor(this, floorResult);
		
		
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
		public void SetGroundMovementMode(EMovementMode newGroundMovementMode)
			=> E_UCharacterMovementComponent_SetGroundMovementMode(this, (byte)newGroundMovementMode);
		
		public void SetGroupsToAvoid(int groupFlags)
			=> E_UCharacterMovementComponent_SetGroupsToAvoid(this, groupFlags);
		
		public void SetGroupsToIgnore(int groupFlags)
			=> E_UCharacterMovementComponent_SetGroupsToIgnore(this, groupFlags);
		
		
		/// <summary>
		/// <para>Change movement mode. </para>
		/// <param name="NewMovementMode">The new movement mode </param>
		/// <param name="NewCustomMode">The new custom sub-mode, only applicable if NewMovementMode is Custom. </param>
		/// </summary>
		public virtual void SetMovementMode(EMovementMode newMovementMode, byte newCustomMode)
			=> E_UCharacterMovementComponent_SetMovementMode(this, (byte)newMovementMode, newCustomMode);
		
		
		/// <summary>
		/// <para>Switch collision settings for NavWalking mode (ignore world collisions) </para>
		/// </summary>
		protected virtual void SetNavWalkingPhysics(bool bEnable)
			=> E_UCharacterMovementComponent_SetNavWalkingPhysics(this, bEnable);
		
		
		/// <summary>
		/// <para>Use new physics after landing. Defaults to swimming if in water, walking otherwise. </para>
		/// </summary>
		protected virtual void SetPostLandedPhysics(FHitResult hit)
			=> E_UCharacterMovementComponent_SetPostLandedPhysics(this, hit);
		
		
		/// <summary>
		/// <para>Set the max angle in degrees of a walkable surface for the character. Also computes WalkableFloorZ. </para>
		/// </summary>
		public void SetWalkableFloorAngle(float inWalkableFloorAngle)
			=> E_UCharacterMovementComponent_SetWalkableFloorAngle(this, inWalkableFloorAngle);
		
		
		/// <summary>
		/// <para>Set the Z component of the normal of the steepest walkable surface for the character. Also computes WalkableFloorAngle. </para>
		/// </summary>
		public void SetWalkableFloorZ(float inWalkableFloorZ)
			=> E_UCharacterMovementComponent_SetWalkableFloorZ(this, inWalkableFloorZ);
		
		
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
		public virtual bool ShouldCatchAir(FFindFloorResult oldFloor, FFindFloorResult newFloor)
			=> E_UCharacterMovementComponent_ShouldCatchAir(this, oldFloor, newFloor);
		
		
		/// <summary>
		/// <para>Determine whether we should try to find a valid landing spot after an impact with an invalid one (based on the Hit result). </para>
		/// <para>For example, landing on the lower portion of the capsule on the edge of geometry may be a walkable surface, but could have reported an unwalkable impact normal. </para>
		/// </summary>
		public virtual bool ShouldCheckForValidLandingSpot(float deltaTime, FVector delta, FHitResult hit)
			=> E_UCharacterMovementComponent_ShouldCheckForValidLandingSpot(this, deltaTime, delta, hit);
		
		
		/// <summary>
		/// <para>Check if the result of a sweep test (passed in InHit) might be a valid location to perch, in which case we should use ComputePerchResult to validate the location. </para>
		/// <para>@see ComputePerchResult </para>
		/// <param name="InHit">Result of the last sweep test before this query. </param>
		/// <param name="bCheckRadius">If true, only allow the perch test if the impact point is outside the radius returned by GetValidPerchRadius(). </param>
		/// <return>Whether perching may be possible, such that ComputePerchResult can return a valid result. </return>
		/// </summary>
		public virtual bool ShouldComputePerchResult(FHitResult inHit, bool bCheckRadius)
			=> E_UCharacterMovementComponent_ShouldComputePerchResult(this, inHit, bCheckRadius);
		
		
		/// <summary>
		/// <para>Determine whether the Character should jump when exiting water. </para>
		/// <param name="JumpDir">is the desired direction to jump out of water </param>
		/// <return>true if Pawn should jump out of water </return>
		/// </summary>
		public virtual bool ShouldJumpOutOfWater(FVector jumpDir)
			=> E_UCharacterMovementComponent_ShouldJumpOutOfWater(this, jumpDir);
		
		
		/// <summary>
		/// <para>if true, DesiredRotation will be restricted to only Yaw component in PhysicsRotation() </para>
		/// </summary>
		public virtual bool ShouldRemainVertical()
			=> E_UCharacterMovementComponent_ShouldRemainVertical(this);
		
		
		/// <summary>
		/// <para>Special Tick for Simulated Proxies </para>
		/// </summary>
		protected void SimulatedTick(float deltaSeconds)
			=> E_UCharacterMovementComponent_SimulatedTick(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>Simulate movement on a non-owning client. Called by SimulatedTick(). </para>
		/// </summary>
		protected virtual void SimulateMovement(float deltaTime)
			=> E_UCharacterMovementComponent_SimulateMovement(this, deltaTime);
		
		
		/// <summary>
		/// <para>Smooth mesh location for network interpolation, based on values set up by SmoothCorrection. </para>
		/// <para>Internally this simply calls SmoothClientPosition_Interpolate() then SmoothClientPosition_UpdateVisuals(). </para>
		/// <para>This function is not called when bNetworkSmoothingComplete is true. </para>
		/// <param name="DeltaSeconds">Time since last update. </param>
		/// </summary>
		protected virtual void SmoothClientPosition(float deltaSeconds)
			=> E_UCharacterMovementComponent_SmoothClientPosition(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>Update interpolation values for client smoothing. Does not change actual mesh location. </para>
		/// <para>Sets bNetworkSmoothingComplete to true when the interpolation reaches the target. </para>
		/// </summary>
		protected void SmoothClientPosition_Interpolate(float deltaSeconds)
			=> E_UCharacterMovementComponent_SmoothClientPosition_Interpolate(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>Update mesh location based on interpolated values. </para>
		/// </summary>
		protected void SmoothClientPosition_UpdateVisuals()
			=> E_UCharacterMovementComponent_SmoothClientPosition_UpdateVisuals(this);
		
		
		/// <summary>
		/// <para>Transition from walking to falling </para>
		/// </summary>
		public virtual void StartFalling(int iterations, float remainingTime, float timeTick, FVector delta, FVector subLoc)
			=> E_UCharacterMovementComponent_StartFalling(this, iterations, remainingTime, timeTick, delta, subLoc);
		
		
		/// <summary>
		/// <para>changes physics based on MovementMode </para>
		/// </summary>
		public virtual void StartNewPhysics(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_StartNewPhysics(this, deltaTime, iterations);
		
		
		/// <summary>
		/// <para>Handle start swimming functionality </para>
		/// <param name="OldLocation">Location on last tick </param>
		/// <param name="OldVelocity">velocity at last tick </param>
		/// <param name="timeTick">time since at OldLocation </param>
		/// <param name="remainingTime">DeltaTime to complete transition to swimming </param>
		/// <param name="Iterations">physics iteration count </param>
		/// </summary>
		public void StartSwimming(FVector oldLocation, FVector oldVelocity, float timeTick, float remainingTime, int iterations)
			=> E_UCharacterMovementComponent_StartSwimming(this, oldLocation, oldVelocity, timeTick, remainingTime, iterations);
		
		public float Swim(FVector delta, FHitResult hit)
			=> E_UCharacterMovementComponent_Swim(this, delta, hit);
		
		
		/// <summary>
		/// <para>Ticks the characters pose and accumulates root motion </para>
		/// </summary>
		protected void TickCharacterPose(float deltaTime)
			=> E_UCharacterMovementComponent_TickCharacterPose(this, deltaTime);
		
		
		/// <summary>
		/// <para>Checks to see if the current location is not encroaching blocking geometry so the character can leave NavWalking. </para>
		/// <para>Restores collision settings and adjusts character location to avoid getting stuck in geometry. </para>
		/// <para>If it's not possible, MovementMode change will be delayed until character reach collision free spot. </para>
		/// <return>True if movement mode was successfully changed </return>
		/// </summary>
		protected virtual bool TryToLeaveNavWalking()
			=> E_UCharacterMovementComponent_TryToLeaveNavWalking(this);
		
		
		/// <summary>
		/// <para>Checks if default capsule size fits (no encroachment), and trigger OnEndCrouch() on the owner if successful. </para>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset. </param>
		/// </summary>
		public virtual void UnCrouch(bool bClientSimulation)
			=> E_UCharacterMovementComponent_UnCrouch(this, bClientSimulation);
		
		
		/// <summary>
		/// <para>Update position based on Base movement </para>
		/// </summary>
		public virtual void UpdateBasedMovement(float deltaSeconds)
			=> E_UCharacterMovementComponent_UpdateBasedMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>Update controller's view rotation as pawn's base rotates </para>
		/// </summary>
		public virtual void UpdateBasedRotation(FRotator finalRotation, FRotator reducedRotation)
			=> E_UCharacterMovementComponent_UpdateBasedRotation(this, finalRotation, reducedRotation);
		
		
		/// <summary>
		/// <para>Update the character state in PerformMovement after the position change. Some rotation updates happen after this. </para>
		/// </summary>
		public virtual void UpdateCharacterStateAfterMovement(float deltaSeconds)
			=> E_UCharacterMovementComponent_UpdateCharacterStateAfterMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>Update the character state in PerformMovement right before doing the actual position change </para>
		/// </summary>
		public virtual void UpdateCharacterStateBeforeMovement(float deltaSeconds)
			=> E_UCharacterMovementComponent_UpdateCharacterStateBeforeMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>React to instantaneous change in position. Invalidates cached floor recomputes it if possible if there is a current movement base. </para>
		/// </summary>
		public virtual void UpdateFloorFromAdjustment()
			=> E_UCharacterMovementComponent_UpdateFloorFromAdjustment(this);
		
		
		/// <summary>
		/// <para>Unpack compressed flags from a saved move and set state accordingly. See FSavedMove_Character. </para>
		/// </summary>
		protected virtual void UpdateFromCompressedFlags(byte flags)
			=> E_UCharacterMovementComponent_UpdateFromCompressedFlags(this, flags);
		
		
		/// <summary>
		/// <para>Draw in-world debug information for character movement (called with p.VisualizeMovement > 0). </para>
		/// </summary>
		public virtual void VisualizeMovement()
			=> E_UCharacterMovementComponent_VisualizeMovement(this);
		
		#endregion
		
		public static implicit operator IntPtr(UCharacterMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UCharacterMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCharacterMovementComponent>(PtrDesc);
		}}}
