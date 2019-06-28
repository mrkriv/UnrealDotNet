// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:159

namespace UnrealEngine
{
	public partial class UCharacterMovementComponent : UPawnMovementComponent
	{
		public UCharacterMovementComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UCharacterMovementComponent(UObject Parent = null, string Name = "CharacterMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCharacterMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

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
		private static extern byte E_PROP_UCharacterMovementComponent_bAllowPhysicsRotationDuringAnimRootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bAllowPhysicsRotationDuringAnimRootMotion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bAlwaysCheckFloor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bAlwaysCheckFloor_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bApplyGravityWhileJumping_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bApplyGravityWhileJumping_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bCanWalkOffLedges_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bCanWalkOffLedges_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bCanWalkOffLedgesWhenCrouching_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bCanWalkOffLedgesWhenCrouching_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bCheatFlying_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bCheatFlying_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bCrouchMaintainsBaseLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bCrouchMaintainsBaseLocation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bDeferUpdateMoveComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bDeferUpdateMoveComponent_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bEnableScopedMovementUpdates_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bEnableScopedMovementUpdates_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bEnableServerDualMoveScopedMovementUpdates_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bEnableServerDualMoveScopedMovementUpdates_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bFastAttachedMove_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bFastAttachedMove_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bForceMaxAccel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bForceMaxAccel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bForceNextFloorCheck_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bForceNextFloorCheck_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bIgnoreBaseRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bIgnoreBaseRotation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bIgnoreClientMovementErrorChecksAndCorrection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bIgnoreClientMovementErrorChecksAndCorrection_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bImpartBaseAngularVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bImpartBaseAngularVelocity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bImpartBaseVelocityX_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bImpartBaseVelocityX_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bImpartBaseVelocityY_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bImpartBaseVelocityY_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bImpartBaseVelocityZ_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bImpartBaseVelocityZ_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bIsNavWalkingOnServer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bIsNavWalkingOnServer_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bJustTeleported_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bJustTeleported_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bMaintainHorizontalGroundVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bMaintainHorizontalGroundVelocity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bNetworkAlwaysReplicateTransformUpdateTimestamp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bNetworkAlwaysReplicateTransformUpdateTimestamp_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bNetworkLargeClientCorrection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bNetworkLargeClientCorrection_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bNetworkMovementModeChanged_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bNetworkMovementModeChanged_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bNetworkSkipProxyPredictionOnNetUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bNetworkSkipProxyPredictionOnNetUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bNetworkSmoothingComplete_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bNetworkSmoothingComplete_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bNetworkUpdateReceived_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bNetworkUpdateReceived_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bNotifyApex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bNotifyApex_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bOrientRotationToMovement_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bOrientRotationToMovement_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bPerformingJumpOff_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bPerformingJumpOff_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_SET(IntPtr Ptr, byte Value);
		
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
		private static extern float E_PROP_UCharacterMovementComponent_BrakingSubStepTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_BrakingSubStepTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bRequestedMoveUseAcceleration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bRequestedMoveUseAcceleration_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bRunPhysicsWithNoController_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bRunPhysicsWithNoController_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bShrinkProxyCapsule_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bShrinkProxyCapsule_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bSweepWhileNavWalking_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bSweepWhileNavWalking_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_Buoyancy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_Buoyancy_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bUseControllerDesiredRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bUseControllerDesiredRotation_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bUseFlatBaseForFloorChecks_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bUseFlatBaseForFloorChecks_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bUseRVOAvoidance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bUseRVOAvoidance_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bUseSeparateBrakingFriction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bUseSeparateBrakingFriction_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bWantsToCrouch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bWantsToCrouch_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bWantsToLeaveNavWalking_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bWantsToLeaveNavWalking_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UCharacterMovementComponent_bWasSimulatingRootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_bWasSimulatingRootMotion_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_CurrentFloor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_CurrentFloor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UCharacterMovementComponent_CurrentRootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UCharacterMovementComponent_CurrentRootMotion_SET(IntPtr Ptr, IntPtr Value);
		
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
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCharacterMovementComponent(IntPtr Parent, string Name);
		
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
		private static extern void E_UCharacterMovementComponent_ClientAdjustRootMotionPosition(IntPtr self, float timeStamp, float serverMontageTrackPosition, IntPtr serverLoc, IntPtr serverRotation, float serverVelZ, IntPtr serverBase, string serverBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAdjustRootMotionPosition_Implementation(IntPtr self, float timeStamp, float serverMontageTrackPosition, IntPtr serverLoc, IntPtr serverRotation, float serverVelZ, IntPtr serverBase, string serverBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAdjustRootMotionSourcePosition(IntPtr self, float timeStamp, IntPtr serverRootMotion, bool bHasAnimRootMotion, float serverMontageTrackPosition, IntPtr serverLoc, IntPtr serverRotation, float serverVelZ, IntPtr serverBase, string serverBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ClientAdjustRootMotionSourcePosition_Implementation(IntPtr self, float timeStamp, IntPtr serverRootMotion, bool bHasAnimRootMotion, float serverMontageTrackPosition, IntPtr serverLoc, IntPtr serverRotation, float serverVelZ, IntPtr serverBase, string serverBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
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
		private static extern void E_UCharacterMovementComponent_ConvertRootMotionServerIDsToLocalIDs(IntPtr self, IntPtr localRootMotionToMatchWith, IntPtr inOutServerRootMotion, float timeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_Crouch(IntPtr self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_DisableMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_DoJump(IntPtr self, bool bReplayingMoves);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_FindBestNavMeshLocation(IntPtr self, IntPtr traceStart, IntPtr traceEnd, IntPtr currentFeetLocation, IntPtr targetNavLocation, IntPtr outHitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_FindFloor(IntPtr self, IntPtr capsuleLocation, IntPtr outFloorResult, bool bCanUseCachedLocation, IntPtr downwardSweepResult);
		
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
		private static extern IntPtr E_UCharacterMovementComponent_GetLastUpdateLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetLastUpdateQuat(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetLastUpdateRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UCharacterMovementComponent_GetLastUpdateVelocity(IntPtr self);
		
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
		private static extern void E_UCharacterMovementComponent_HandleWalkingOffLedge(IntPtr self, IntPtr previousFloorImpactNormal, IntPtr previousFloorContactNormal, IntPtr previousLocation, float timeDelta);
		
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
		private static extern void E_UCharacterMovementComponent_MoveAlongFloor(IntPtr self, IntPtr inVelocity, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MoveAutonomous(IntPtr self, float clientTimeStamp, float deltaTime, byte compressedFlags, IntPtr newAccel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_MoveSmooth(IntPtr self, IntPtr inVelocity, float deltaSeconds);
		
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
		private static extern void E_UCharacterMovementComponent_OnRootMotionSourceBeingApplied(IntPtr self, IntPtr source);
		
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
		private static extern void E_UCharacterMovementComponent_ServerMoveOld(IntPtr self, float oldTimeStamp, IntPtr oldAccel, byte oldMoveFlags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_ServerMoveOld_Implementation(IntPtr self, float oldTimeStamp, IntPtr oldAccel, byte oldMoveFlags);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UCharacterMovementComponent_ServerMoveOld_Validate(IntPtr self, float oldTimeStamp, IntPtr oldAccel, byte oldMoveFlags);
		
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
		private static extern bool E_UCharacterMovementComponent_StepUp(IntPtr self, IntPtr gravDir, IntPtr delta, IntPtr hit);
		
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
		private static extern void E_UCharacterMovementComponent_UpdateProxyAcceleration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCharacterMovementComponent_VisualizeMovement(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// When falling, amount of lateral movement control available to the character.
		/// <para>0 = no control, 1 = full control at max speed of MaxWalkSpeed. </para>
		/// </summary>
		public float AirControl
		{
			get => E_PROP_UCharacterMovementComponent_AirControl_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AirControl_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When falling, multiplier applied to AirControl when lateral velocity is less than AirControlBoostVelocityThreshold.
		/// <para>Setting this to zero will disable air control boosting. Final result is clamped at 1. </para>
		/// </summary>
		public float AirControlBoostMultiplier
		{
			get => E_PROP_UCharacterMovementComponent_AirControlBoostMultiplier_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AirControlBoostMultiplier_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When falling, if lateral velocity magnitude is less than this value, AirControl is multiplied by AirControlBoostMultiplier.
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
		/// No default value, for now it's assumed to be valid if GetAvoidanceManager() returns non-NULL.
		/// </summary>
		public int AvoidanceUID
		{
			get => E_PROP_UCharacterMovementComponent_AvoidanceUID_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AvoidanceUID_SET(NativePointer, value);
		}

		
		/// <summary>
		/// De facto default value 0.5 (due to that being the default in the avoidance registration function), indicates RVO behavior.
		/// </summary>
		public float AvoidanceWeight
		{
			get => E_PROP_UCharacterMovementComponent_AvoidanceWeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_AvoidanceWeight_SET(NativePointer, value);
		}

		public byte bAllowPhysicsRotationDuringAnimRootMotion
		{
			get => E_PROP_UCharacterMovementComponent_bAllowPhysicsRotationDuringAnimRootMotion_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bAllowPhysicsRotationDuringAnimRootMotion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we always force floor checks for stationary Characters while walking.
		/// <para>Normally floor checks are avoided if possible when not moving, but this can be used to force them if there are use-cases where they are being skipped erroneously </para>
		/// (such as objects moving up into the character from below).
		/// </summary>
		public byte bAlwaysCheckFloor
		{
			get => E_PROP_UCharacterMovementComponent_bAlwaysCheckFloor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bAlwaysCheckFloor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Apply gravity while the character is actively jumping (e.g. holding the jump key).
		/// <para>Helps remove frame-rate dependent jump height, but may alter base jump height. </para>
		/// </summary>
		public byte bApplyGravityWhileJumping
		{
			get => E_PROP_UCharacterMovementComponent_bApplyGravityWhileJumping_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bApplyGravityWhileJumping_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, Character can walk off a ledge.
		/// </summary>
		public byte bCanWalkOffLedges
		{
			get => E_PROP_UCharacterMovementComponent_bCanWalkOffLedges_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bCanWalkOffLedges_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, Character can walk off a ledge when crouching.
		/// </summary>
		public byte bCanWalkOffLedgesWhenCrouching
		{
			get => E_PROP_UCharacterMovementComponent_bCanWalkOffLedgesWhenCrouching_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bCanWalkOffLedgesWhenCrouching_SET(NativePointer, value);
		}

		public byte bCheatFlying
		{
			get => E_PROP_UCharacterMovementComponent_bCheatFlying_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bCheatFlying_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, crouching should keep the base of the capsule in place by lowering the center of the shrunken capsule. If false, the base of the capsule moves up and the center stays in place.
		/// <para>The same behavior applies when the character uncrouches: if true, the base is kept in the same location and the center moves up. If false, the capsule grows and only moves up if the base impacts something. </para>
		/// By default this variable is set when the movement mode changes: set to true when walking and false otherwise. Feel free to override the behavior when the movement mode changes.
		/// </summary>
		public byte bCrouchMaintainsBaseLocation
		{
			get => E_PROP_UCharacterMovementComponent_bCrouchMaintainsBaseLocation_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bCrouchMaintainsBaseLocation_SET(NativePointer, value);
		}

		public byte bDeferUpdateMoveComponent
		{
			get => E_PROP_UCharacterMovementComponent_bDeferUpdateMoveComponent_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bDeferUpdateMoveComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If enabled, the player will interact with physics objects when walking into them.
		/// </summary>
		public byte bEnablePhysicsInteraction
		{
			get => E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bEnablePhysicsInteraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, high-level movement updates will be wrapped in a movement scope that accumulates updates and defers a bulk of the work until the end.
		/// <para>When enabled, touch and hit events will not be triggered until the end of multiple moves within an update, which can improve performance. </para>
		/// @see FScopedMovementUpdate
		/// </summary>
		public byte bEnableScopedMovementUpdates
		{
			get => E_PROP_UCharacterMovementComponent_bEnableScopedMovementUpdates_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bEnableScopedMovementUpdates_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Optional scoped movement update to combine moves for cheaper performance on the server when the client sends two moves in one packet.
		/// <para>Be warned that since this wraps a larger scope than is normally done with bEnableScopedMovementUpdates, this can result in subtle changes in behavior </para>
		/// in regards to when overlap events are handled, when attached components are moved, etc.
		/// <para>@see bEnableScopedMovementUpdates </para>
		/// </summary>
		public byte bEnableServerDualMoveScopedMovementUpdates
		{
			get => E_PROP_UCharacterMovementComponent_bEnableServerDualMoveScopedMovementUpdates_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bEnableServerDualMoveScopedMovementUpdates_SET(NativePointer, value);
		}

		public byte bFastAttachedMove
		{
			get => E_PROP_UCharacterMovementComponent_bFastAttachedMove_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bFastAttachedMove_SET(NativePointer, value);
		}

		public byte bForceMaxAccel
		{
			get => E_PROP_UCharacterMovementComponent_bForceMaxAccel_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bForceMaxAccel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Force the Character in MOVE_Walking to do a check for a valid floor even if he hasn't moved. Cleared after next floor check.
		/// <para>Normally if bAlwaysCheckFloor is false we try to avoid the floor check unless some conditions are met, but this can be used to force the next check to always run. </para>
		/// </summary>
		public byte bForceNextFloorCheck
		{
			get => E_PROP_UCharacterMovementComponent_bForceNextFloorCheck_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bForceNextFloorCheck_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the character ignores changes in rotation of the base it is standing on.
		/// <para>If true, the character maintains current world rotation. </para>
		/// If false, the character rotates with the moving base.
		/// </summary>
		public byte bIgnoreBaseRotation
		{
			get => E_PROP_UCharacterMovementComponent_bIgnoreBaseRotation_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bIgnoreBaseRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True when we should ignore server location difference checks for client error on this movement component
		/// <para>This can be useful when character is moving at extreme speeds for a duration and you need it to look </para>
		/// smooth on clients. Make sure to disable when done, as this would break this character's server-client
		/// <para>movement correction. </para>
		/// </summary>
		public byte bIgnoreClientMovementErrorChecksAndCorrection
		{
			get => E_PROP_UCharacterMovementComponent_bIgnoreClientMovementErrorChecksAndCorrection_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bIgnoreClientMovementErrorChecksAndCorrection_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, impart the base component's tangential components of angular velocity when jumping or falling off it.
		/// <para>Only those components of the velocity allowed by the separate component settings (bImpartBaseVelocityX etc) will be applied. </para>
		/// <see cref="bImpartBaseVelocityX"/>
		/// </summary>
		public byte bImpartBaseAngularVelocity
		{
			get => E_PROP_UCharacterMovementComponent_bImpartBaseAngularVelocity_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bImpartBaseAngularVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, impart the base actor's X velocity when falling off it (which includes jumping)
		/// </summary>
		public byte bImpartBaseVelocityX
		{
			get => E_PROP_UCharacterMovementComponent_bImpartBaseVelocityX_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bImpartBaseVelocityX_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, impart the base actor's Y velocity when falling off it (which includes jumping)
		/// </summary>
		public byte bImpartBaseVelocityY
		{
			get => E_PROP_UCharacterMovementComponent_bImpartBaseVelocityY_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bImpartBaseVelocityY_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, impart the base actor's Z velocity when falling off it (which includes jumping)
		/// </summary>
		public byte bImpartBaseVelocityZ
		{
			get => E_PROP_UCharacterMovementComponent_bImpartBaseVelocityZ_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bImpartBaseVelocityZ_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Set on clients when server's movement mode is NavWalking
		/// </summary>
		public byte bIsNavWalkingOnServer
		{
			get => E_PROP_UCharacterMovementComponent_bIsNavWalkingOnServer_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bIsNavWalkingOnServer_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Used by movement code to determine if a change in position is based on normal movement or a teleport. If not a teleport, velocity can be recomputed based on the change in position.
		/// </summary>
		public byte bJustTeleported
		{
			get => E_PROP_UCharacterMovementComponent_bJustTeleported_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bJustTeleported_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, walking movement always maintains horizontal velocity when moving up ramps, which causes movement up ramps to be faster parallel to the ramp surface.
		/// <para>If false, then walking movement maintains velocity magnitude parallel to the ramp surface. </para>
		/// </summary>
		public byte bMaintainHorizontalGroundVelocity
		{
			get => E_PROP_UCharacterMovementComponent_bMaintainHorizontalGroundVelocity_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bMaintainHorizontalGroundVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Flag used on the server to determine whether to always replicate ReplicatedServerLastTransformUpdateTimeStamp to clients.
		/// <para>Normally this is only sent when the network smoothing mode on character movement is set to Linear smoothing (on the server), to save bandwidth. </para>
		/// Setting this to true will force the timestamp to replicate regardless, in case the server doesn't know about the smoothing mode, or if the timestamp is used for another purpose.
		/// </summary>
		public byte bNetworkAlwaysReplicateTransformUpdateTimestamp
		{
			get => E_PROP_UCharacterMovementComponent_bNetworkAlwaysReplicateTransformUpdateTimestamp_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bNetworkAlwaysReplicateTransformUpdateTimestamp_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Flag indicating the client correction was larger than NetworkLargeClientCorrectionThreshold.
		/// </summary>
		public byte bNetworkLargeClientCorrection
		{
			get => E_PROP_UCharacterMovementComponent_bNetworkLargeClientCorrection_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bNetworkLargeClientCorrection_SET(NativePointer, value);
		}

		public byte bNetworkMovementModeChanged
		{
			get => E_PROP_UCharacterMovementComponent_bNetworkMovementModeChanged_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bNetworkMovementModeChanged_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we skip prediction on frames where a proxy receives a network update. This can avoid expensive prediction on those frames,
		/// <para>with the side-effect of predicting with a frame of additional latency. </para>
		/// </summary>
		public byte bNetworkSkipProxyPredictionOnNetUpdate
		{
			get => E_PROP_UCharacterMovementComponent_bNetworkSkipProxyPredictionOnNetUpdate_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bNetworkSkipProxyPredictionOnNetUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Signals that smoothed position/rotation has reached target, and no more smoothing is necessary until a future update.
		/// <para>This is used as an optimization to skip calls to SmoothClientPosition() when true. SmoothCorrection() sets it false when a new network update is received. </para>
		/// SmoothClientPosition_Interpolate() sets this to true when the interpolation reaches the target, before one last call to SmoothClientPosition_UpdateVisuals().
		/// <para>If this is not desired, override SmoothClientPosition() to always set this to false to avoid this feature. </para>
		/// </summary>
		public byte bNetworkSmoothingComplete
		{
			get => E_PROP_UCharacterMovementComponent_bNetworkSmoothingComplete_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bNetworkSmoothingComplete_SET(NativePointer, value);
		}

		public byte bNetworkUpdateReceived
		{
			get => E_PROP_UCharacterMovementComponent_bNetworkUpdateReceived_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bNetworkUpdateReceived_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, event NotifyJumpApex() to CharacterOwner's controller when at apex of jump. Is cleared when event is triggered.
		/// <para>By default this is off, and if you want the event to fire you typically set it to true when movement mode changes to "Falling" from another mode (see OnMovementModeChanged). </para>
		/// </summary>
		public byte bNotifyApex
		{
			get => E_PROP_UCharacterMovementComponent_bNotifyApex_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bNotifyApex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, rotate the Character toward the direction of acceleration, using RotationRate as the rate of rotation change. Overrides UseControllerDesiredRotation.
		/// <para>Normally you will want to make sure that other settings are cleared, such as bUseControllerRotationYaw on the Character. </para>
		/// </summary>
		public byte bOrientRotationToMovement
		{
			get => E_PROP_UCharacterMovementComponent_bOrientRotationToMovement_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bOrientRotationToMovement_SET(NativePointer, value);
		}

		public byte bPerformingJumpOff
		{
			get => E_PROP_UCharacterMovementComponent_bPerformingJumpOff_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bPerformingJumpOff_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If enabled, the PushForceFactor is applied per kg mass of the affected object.
		/// </summary>
		public byte bPushForceScaledToMass
		{
			get => E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bPushForceScaledToMass_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If enabled, the PushForce location is moved using PushForcePointZOffsetFactor. Otherwise simply use the impact point.
		/// </summary>
		public byte bPushForceUsingZOffset
		{
			get => E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bPushForceUsingZOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Lateral deceleration when falling and not applying acceleration.
		/// <para>@see MaxAcceleration </para>
		/// </summary>
		public float BrakingDecelerationFalling
		{
			get => E_PROP_UCharacterMovementComponent_BrakingDecelerationFalling_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingDecelerationFalling_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Deceleration when flying and not applying acceleration.
		/// <para>@see MaxAcceleration </para>
		/// </summary>
		public float BrakingDecelerationFlying
		{
			get => E_PROP_UCharacterMovementComponent_BrakingDecelerationFlying_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingDecelerationFlying_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Deceleration when swimming and not applying acceleration.
		/// <para>@see MaxAcceleration </para>
		/// </summary>
		public float BrakingDecelerationSwimming
		{
			get => E_PROP_UCharacterMovementComponent_BrakingDecelerationSwimming_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingDecelerationSwimming_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Deceleration when walking and not applying acceleration. This is a constant opposing force that directly lowers velocity by a constant value.
		/// <see cref="GroundFriction"/>
		/// </summary>
		public float BrakingDecelerationWalking
		{
			get => E_PROP_UCharacterMovementComponent_BrakingDecelerationWalking_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingDecelerationWalking_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Friction (drag) coefficient applied when braking (whenever Acceleration = 0, or if character is exceeding max speed); actual value used is this multiplied by BrakingFrictionFactor.
		/// <para>When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity. </para>
		/// Braking is composed of friction (velocity-dependent drag) and constant deceleration.
		/// <para>This is the current value, used in all movement modes; if this is not desired, override it or bUseSeparateBrakingFriction when movement mode changes. </para>
		/// @note Only used if bUseSeparateBrakingFriction setting is true, otherwise current friction such as GroundFriction is used.
		/// <see cref="bUseSeparateBrakingFriction"/>
		/// </summary>
		public float BrakingFriction
		{
			get => E_PROP_UCharacterMovementComponent_BrakingFriction_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingFriction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Factor used to multiply actual value of friction used when braking.
		/// <para>This applies to any friction value that is currently used, which may depend on bUseSeparateBrakingFriction. </para>
		/// @note This is 2 by default for historical reasons, a value of 1 gives the true drag equation.
		/// <see cref="bUseSeparateBrakingFriction"/>
		/// </summary>
		public float BrakingFrictionFactor
		{
			get => E_PROP_UCharacterMovementComponent_BrakingFrictionFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingFrictionFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time substepping when applying braking friction. Smaller time steps increase accuracy at the slight cost of performance, especially if there are large frame times.
		/// </summary>
		public float BrakingSubStepTime
		{
			get => E_PROP_UCharacterMovementComponent_BrakingSubStepTime_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_BrakingSubStepTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Should use acceleration for path following?
		/// <para>If true, acceleration is applied when path following to reach the target velocity. </para>
		/// If false, path following velocity is set directly, disregarding acceleration.
		/// </summary>
		public byte bRequestedMoveUseAcceleration
		{
			get => E_PROP_UCharacterMovementComponent_bRequestedMoveUseAcceleration_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bRequestedMoveUseAcceleration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, movement will be performed even if there is no Controller for the Character owner.
		/// <para>Normally without a Controller, movement will be aborted and velocity and acceleration are zeroed if the character is walking. </para>
		/// Characters that are spawned without a Controller but with this flag enabled will initialize the movement mode to DefaultLandMovementMode or DefaultWaterMovementMode appropriately.
		/// <see cref="DefaultLandMovementMode"/>
		/// </summary>
		public byte bRunPhysicsWithNoController
		{
			get => E_PROP_UCharacterMovementComponent_bRunPhysicsWithNoController_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bRunPhysicsWithNoController_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If enabled, the applied push force will try to get the physics object to the same velocity than the player, not faster. This will only
		/// <para>scale the force down, it will never apply more force than defined by PushForceFactor. </para>
		/// </summary>
		public byte bScalePushForceToVelocity
		{
			get => E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bScalePushForceToVelocity_SET(NativePointer, value);
		}

		public byte bShrinkProxyCapsule
		{
			get => E_PROP_UCharacterMovementComponent_bShrinkProxyCapsule_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bShrinkProxyCapsule_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether or not the character should sweep for collision geometry while walking.
		/// <see cref="USceneComponent"/>
		/// </summary>
		public byte bSweepWhileNavWalking
		{
			get => E_PROP_UCharacterMovementComponent_bSweepWhileNavWalking_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bSweepWhileNavWalking_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If enabled, the TouchForceFactor is applied per kg mass of the affected object.
		/// </summary>
		public byte bTouchForceScaledToMass
		{
			get => E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bTouchForceScaledToMass_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Water buoyancy. A ratio (1.0 = neutral buoyancy, 0.0 = no buoyancy)
		/// </summary>
		public float Buoyancy
		{
			get => E_PROP_UCharacterMovementComponent_Buoyancy_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_Buoyancy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, smoothly rotate the Character toward the Controller's desired rotation (typically Controller->ControlRotation), using RotationRate as the rate of rotation change. Overridden by OrientRotationToMovement.
		/// <para>Normally you will want to make sure that other settings are cleared, such as bUseControllerRotationYaw on the Character. </para>
		/// </summary>
		public byte bUseControllerDesiredRotation
		{
			get => E_PROP_UCharacterMovementComponent_bUseControllerDesiredRotation_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bUseControllerDesiredRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Performs floor checks as if the character is using a shape with a flat base.
		/// <para>This avoids the situation where characters slowly lower off the side of a ledge (as their capsule 'balances' on the edge). </para>
		/// </summary>
		public byte bUseFlatBaseForFloorChecks
		{
			get => E_PROP_UCharacterMovementComponent_bUseFlatBaseForFloorChecks_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bUseFlatBaseForFloorChecks_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If set, component will use RVO avoidance. This only runs on the server.
		/// </summary>
		public byte bUseRVOAvoidance
		{
			get => E_PROP_UCharacterMovementComponent_bUseRVOAvoidance_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bUseRVOAvoidance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, BrakingFriction will be used to slow the character to a stop (when there is no Acceleration).
		/// <para>If false, braking uses the same friction passed to CalcVelocity() (ie GroundFriction when walking), multiplied by BrakingFrictionFactor. </para>
		/// This setting applies to all movement modes; if only desired in certain modes, consider toggling it when movement modes change.
		/// <para>@see BrakingFriction </para>
		/// </summary>
		public byte bUseSeparateBrakingFriction
		{
			get => E_PROP_UCharacterMovementComponent_bUseSeparateBrakingFriction_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bUseSeparateBrakingFriction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, try to crouch (or keep crouching) on next update. If false, try to stop crouching on next update.
		/// </summary>
		public byte bWantsToCrouch
		{
			get => E_PROP_UCharacterMovementComponent_bWantsToCrouch_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bWantsToCrouch_SET(NativePointer, value);
		}

		public byte bWantsToLeaveNavWalking
		{
			get => E_PROP_UCharacterMovementComponent_bWantsToLeaveNavWalking_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bWantsToLeaveNavWalking_SET(NativePointer, value);
		}

		public byte bWasSimulatingRootMotion
		{
			get => E_PROP_UCharacterMovementComponent_bWasSimulatingRootMotion_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_bWasSimulatingRootMotion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Last valid projected hit result from raycast to geometry from navmesh
		/// </summary>
		public FHitResult CachedProjectedNavMeshHitResult
		{
			get => E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_CachedProjectedNavMeshHitResult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Collision half-height when crouching (component scale is applied separately)
		/// </summary>
		public float CrouchedHalfHeight
		{
			get => E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_CrouchedHalfHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Information about the floor the Character is standing on (updated only during walking movement).
		/// </summary>
		public FFindFloorResult CurrentFloor
		{
			get => E_PROP_UCharacterMovementComponent_CurrentFloor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_CurrentFloor_SET(NativePointer, value);
		}

		public FRootMotionSourceGroup CurrentRootMotion
		{
			get => E_PROP_UCharacterMovementComponent_CurrentRootMotion_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_CurrentRootMotion_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current custom sub-mode if MovementMode is set to Custom.
		/// <para>This is automatically replicated through the Character owner and for client-server movement functions. </para>
		/// <see cref="SetMovementMode"/>
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
		/// Friction to apply to lateral air movement when falling.
		/// <para>If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero). </para>
		/// <see cref="BrakingFriction"/>
		/// </summary>
		public float FallingLateralFriction
		{
			get => E_PROP_UCharacterMovementComponent_FallingLateralFriction_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_FallingLateralFriction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Custom gravity scale. Gravity is multiplied by this amount for the character.
		/// </summary>
		public float GravityScale
		{
			get => E_PROP_UCharacterMovementComponent_GravityScale_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_GravityScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Setting that affects movement control. Higher values allow faster changes in direction.
		/// <para>If bUseSeparateBrakingFriction is false, also affects the ability to stop more quickly when braking (whenever Acceleration is zero), where it is multiplied by BrakingFrictionFactor. </para>
		/// When braking, this property allows you to control how much friction is applied when moving across the ground, applying an opposing force that scales with current velocity.
		/// <para>This can be used to simulate slippery surfaces such as ice or oil by changing the value (possibly based on the material pawn is standing on). </para>
		/// <see cref="BrakingDecelerationWalking"/>
		/// </summary>
		public float GroundFriction
		{
			get => E_PROP_UCharacterMovementComponent_GroundFriction_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_GroundFriction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Initial impulse force to apply when the player bounces into a blocking physics object.
		/// </summary>
		public float InitialPushForceFactor
		{
			get => E_PROP_UCharacterMovementComponent_InitialPushForceFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_InitialPushForceFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Fraction of JumpZVelocity to use when automatically "jumping off" of a base actor that's not allowed to be a base for a character. (For example, if you're not allowed to stand on other players.)
		/// </summary>
		public float JumpOffJumpZFactor
		{
			get => E_PROP_UCharacterMovementComponent_JumpOffJumpZFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_JumpOffJumpZFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When exiting water, jump if control pitch angle is this high or above.
		/// </summary>
		public float JumpOutOfWaterPitch
		{
			get => E_PROP_UCharacterMovementComponent_JumpOutOfWaterPitch_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_JumpOutOfWaterPitch_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Initial velocity (instantaneous vertical acceleration) when jumping.
		/// </summary>
		public float JumpZVelocity
		{
			get => E_PROP_UCharacterMovementComponent_JumpZVelocity_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_JumpZVelocity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Used in determining if pawn is going off ledge.  If the ledge is "shorter" than this value then the pawn will be able to walk off it.
		/// </summary>
		public float LedgeCheckThreshold
		{
			get => E_PROP_UCharacterMovementComponent_LedgeCheckThreshold_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_LedgeCheckThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Similar setting as NetworkSimulatedSmoothLocationTime but only used on Listen servers.
		/// </summary>
		public float ListenServerNetworkSimulatedSmoothLocationTime
		{
			get => E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothLocationTime_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothLocationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Similar setting as NetworkSimulatedSmoothRotationTime but only used on Listen servers.
		/// </summary>
		public float ListenServerNetworkSimulatedSmoothRotationTime
		{
			get => E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothRotationTime_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_ListenServerNetworkSimulatedSmoothRotationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Mass of pawn (for when momentum is imparted to it).
		/// </summary>
		public float Mass
		{
			get => E_PROP_UCharacterMovementComponent_Mass_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_Mass_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max Acceleration (rate of change of velocity)
		/// </summary>
		public float MaxAcceleration
		{
			get => E_PROP_UCharacterMovementComponent_MaxAcceleration_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxAcceleration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The maximum speed when using Custom movement mode.
		/// </summary>
		public float MaxCustomMovementSpeed
		{
			get => E_PROP_UCharacterMovementComponent_MaxCustomMovementSpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxCustomMovementSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.
		/// <para>This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server. </para>
		/// <see cref="MaxDepenetrationWithGeometryAsProxy"/>
		/// </summary>
		public float MaxDepenetrationWithGeometry
		{
			get => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometry_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometry_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance we allow simulated proxies to depenetrate when moving out of anything but Pawns.
		/// <para>This is generally more tolerant than with Pawns, because other geometry is either not moving, or is moving predictably with a bit of delay compared to on the server. </para>
		/// <see cref="MaxDepenetrationWithGeometry"/>
		/// </summary>
		public float MaxDepenetrationWithGeometryAsProxy
		{
			get => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometryAsProxy_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithGeometryAsProxy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance we are allowed to depenetrate when moving out of other Pawns.
		/// <see cref="MaxDepenetrationWithGeometry"/>
		/// </summary>
		public float MaxDepenetrationWithPawn
		{
			get => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawn_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawn_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance we allow simulated proxies to depenetrate when moving out of other Pawns.
		/// <para>Typically we don't want a large value, because we receive a server authoritative position that we should not then ignore by pushing them out of the local player. </para>
		/// <see cref="MaxDepenetrationWithGeometry"/>
		/// </summary>
		public float MaxDepenetrationWithPawnAsProxy
		{
			get => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawnAsProxy_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxDepenetrationWithPawnAsProxy_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The maximum flying speed.
		/// </summary>
		public float MaxFlySpeed
		{
			get => E_PROP_UCharacterMovementComponent_MaxFlySpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxFlySpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum step height for getting out of water
		/// </summary>
		public float MaxOutOfWaterStepHeight
		{
			get => E_PROP_UCharacterMovementComponent_MaxOutOfWaterStepHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxOutOfWaterStepHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max number of iterations used for each discrete simulation step.
		/// <para>Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking). </para>
		/// Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// <para>WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation. </para>
		/// @see MaxSimulationTimeStep
		/// </summary>
		public int MaxSimulationIterations
		{
			get => E_PROP_UCharacterMovementComponent_MaxSimulationIterations_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxSimulationIterations_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max time delta for each discrete simulation step.
		/// <para>Used primarily in the the more advanced movement modes that break up larger time steps (usually those applying gravity such as falling and walking). </para>
		/// Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance.
		/// <para>WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation. </para>
		/// @see MaxSimulationIterations
		/// </summary>
		public float MaxSimulationTimeStep
		{
			get => E_PROP_UCharacterMovementComponent_MaxSimulationTimeStep_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxSimulationTimeStep_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum height character can step up
		/// </summary>
		public float MaxStepHeight
		{
			get => E_PROP_UCharacterMovementComponent_MaxStepHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxStepHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The maximum swimming speed.
		/// </summary>
		public float MaxSwimSpeed
		{
			get => E_PROP_UCharacterMovementComponent_MaxSwimSpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxSwimSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum force applied to touched physics objects. If < 0.0f, there is no maximum.
		/// </summary>
		public float MaxTouchForce
		{
			get => E_PROP_UCharacterMovementComponent_MaxTouchForce_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxTouchForce_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The maximum ground speed when walking. Also determines maximum lateral speed when falling.
		/// </summary>
		public float MaxWalkSpeed
		{
			get => E_PROP_UCharacterMovementComponent_MaxWalkSpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxWalkSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The maximum ground speed when walking and crouched.
		/// </summary>
		public float MaxWalkSpeedCrouched
		{
			get => E_PROP_UCharacterMovementComponent_MaxWalkSpeedCrouched_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MaxWalkSpeedCrouched_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The ground speed that we should accelerate up to when walking at minimum analog stick tilt
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
		/// Minimum Force applied to touched physics objects. If < 0.0f, there is no minimum.
		/// </summary>
		public float MinTouchForce
		{
			get => E_PROP_UCharacterMovementComponent_MinTouchForce_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_MinTouchForce_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scale of the total capsule height to use for projection from navmesh to underlying geometry in the downward direction.
		/// <para>In other words, trace down to [CapsuleHeight * NavMeshProjectionHeightScaleDown] below nav mesh. </para>
		/// </summary>
		public float NavMeshProjectionHeightScaleDown
		{
			get => E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleDown_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleDown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Scale of the total capsule height to use for projection from navmesh to underlying geometry in the upward direction.
		/// <para>In other words, start the trace at [CapsuleHeight * NavMeshProjectionHeightScaleUp] above nav mesh. </para>
		/// </summary>
		public float NavMeshProjectionHeightScaleUp
		{
			get => E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleUp_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavMeshProjectionHeightScaleUp_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Speed at which to interpolate agent navmesh offset between traces. 0: Instant (no interp) > 0: Interp speed")
		/// </summary>
		public float NavMeshProjectionInterpSpeed
		{
			get => E_PROP_UCharacterMovementComponent_NavMeshProjectionInterpSpeed_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavMeshProjectionInterpSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How often we should raycast to project from navmesh to underlying geometry
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
		/// Ignore small differences in ground height between server and client data during NavWalking mode
		/// </summary>
		public float NavWalkingFloorDistTolerance
		{
			get => E_PROP_UCharacterMovementComponent_NavWalkingFloorDistTolerance_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NavWalkingFloorDistTolerance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Shrink simulated proxy capsule half height by this amount, to account for network rounding that may cause encroachment. Changing during gameplay is not supported.
		/// <see cref="AdjustProxyCapsuleSize"/>
		/// </summary>
		public float NetProxyShrinkHalfHeight
		{
			get => E_PROP_UCharacterMovementComponent_NetProxyShrinkHalfHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetProxyShrinkHalfHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Shrink simulated proxy capsule radius by this amount, to account for network rounding that may cause encroachment. Changing during gameplay is not supported.
		/// <see cref="AdjustProxyCapsuleSize"/>
		/// </summary>
		public float NetProxyShrinkRadius
		{
			get => E_PROP_UCharacterMovementComponent_NetProxyShrinkRadius_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetProxyShrinkRadius_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If client error is larger than this, sets bNetworkLargeClientCorrection to reduce delay between client adjustments.
		/// <see cref="NetworkMinTimeBetweenClientAdjustments"/>
		/// </summary>
		public float NetworkLargeClientCorrectionDistance
		{
			get => E_PROP_UCharacterMovementComponent_NetworkLargeClientCorrectionDistance_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkLargeClientCorrectionDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum distance character is allowed to lag behind server location when interpolating between updates.
		/// </summary>
		public float NetworkMaxSmoothUpdateDistance
		{
			get => E_PROP_UCharacterMovementComponent_NetworkMaxSmoothUpdateDistance_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkMaxSmoothUpdateDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Minimum time on the server between acknowledging good client moves. This can save on bandwidth. Set to 0 to disable throttling.
		/// </summary>
		public float NetworkMinTimeBetweenClientAckGoodMoves
		{
			get => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAckGoodMoves_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAckGoodMoves_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Minimum time on the server between sending client adjustments when client has exceeded allowable position error.
		/// <para>Should be >= NetworkMinTimeBetweenClientAdjustmentsLargeCorrection (the larger value is used regardless). </para>
		/// This can save on bandwidth. Set to 0 to disable throttling.
		/// <para>@see ServerLastClientAdjustmentTime </para>
		/// </summary>
		public float NetworkMinTimeBetweenClientAdjustments
		{
			get => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustments_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustments_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Minimum time on the server between sending client adjustments when client has exceeded allowable position error by a large amount (NetworkLargeClientCorrectionDistance).
		/// <para>Should be <= NetworkMinTimeBetweenClientAdjustments (the smaller value is used regardless). </para>
		/// @see NetworkMinTimeBetweenClientAdjustments
		/// </summary>
		public float NetworkMinTimeBetweenClientAdjustmentsLargeCorrection
		{
			get => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkMinTimeBetweenClientAdjustmentsLargeCorrection_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum distance beyond which character is teleported to the new server location without any smoothing.
		/// </summary>
		public float NetworkNoSmoothUpdateDistance
		{
			get => E_PROP_UCharacterMovementComponent_NetworkNoSmoothUpdateDistance_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkNoSmoothUpdateDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How long to take to smoothly interpolate from the old pawn position on the client to the corrected one sent by the server. Not used by Linear smoothing.
		/// </summary>
		public float NetworkSimulatedSmoothLocationTime
		{
			get => E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothLocationTime_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothLocationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How long to take to smoothly interpolate from the old pawn rotation on the client to the corrected one sent by the server. Not used by Linear smoothing.
		/// </summary>
		public float NetworkSimulatedSmoothRotationTime
		{
			get => E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothRotationTime_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkSimulatedSmoothRotationTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Smoothing mode for simulated proxies in network game.
		/// </summary>
		public ENetworkSmoothingMode NetworkSmoothingMode
		{
			get => (ENetworkSmoothingMode)E_PROP_UCharacterMovementComponent_NetworkSmoothingMode_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_NetworkSmoothingMode_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// Saved location of object we are standing on, for UpdateBasedMovement() to determine if base moved in the last frame, and therefore pawn needs an update.
		/// </summary>
		public FVector OldBaseLocation
		{
			get => E_PROP_UCharacterMovementComponent_OldBaseLocation_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_OldBaseLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Saved location of object we are standing on, for UpdateBasedMovement() to determine if base moved in the last frame, and therefore pawn needs an update.
		/// </summary>
		public FQuat OldBaseQuat
		{
			get => E_PROP_UCharacterMovementComponent_OldBaseQuat_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_OldBaseQuat_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Z velocity applied when pawn tries to get out of water
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
		/// When perching on a ledge, add this additional distance to MaxStepHeight when determining how high above a walkable floor we can perch.
		/// <para>Note that we still enforce MaxStepHeight to start the step up; this just allows the character to hang off the edge or step slightly higher off the floor. </para>
		/// <see cref="PerchRadiusThreshold"/>
		/// </summary>
		public float PerchAdditionalHeight
		{
			get => E_PROP_UCharacterMovementComponent_PerchAdditionalHeight_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_PerchAdditionalHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Don't allow the character to perch on the edge of a surface if the contact is this close to the edge of the capsule.
		/// <para>Note that characters will not fall off if they are within MaxStepHeight of a walkable surface below. </para>
		/// </summary>
		public float PerchRadiusThreshold
		{
			get => E_PROP_UCharacterMovementComponent_PerchRadiusThreshold_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_PerchRadiusThreshold_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Force to apply when the player collides with a blocking physics object.
		/// </summary>
		public float PushForceFactor
		{
			get => E_PROP_UCharacterMovementComponent_PushForceFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_PushForceFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Z-Offset for the position the force is applied to. 0.0f is the center of the physics object, 1.0f is the top and -1.0f is the bottom of the object.
		/// </summary>
		public float PushForcePointZOffsetFactor
		{
			get => E_PROP_UCharacterMovementComponent_PushForcePointZOffsetFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_PushForcePointZOffsetFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Force per kg applied constantly to all overlapping components.
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
		/// Change in rotation per second, used when UseControllerDesiredRotation or OrientRotationToMovement are true. Set a negative value for infinite rotation rate and instant turns.
		/// </summary>
		public FRotator RotationRate
		{
			get => E_PROP_UCharacterMovementComponent_RotationRate_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_RotationRate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Force applied to objects we stand on (due to Mass and Gravity) is scaled by this amount.
		/// </summary>
		public float StandingDownwardForceScale
		{
			get => E_PROP_UCharacterMovementComponent_StandingDownwardForceScale_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_StandingDownwardForceScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Force to apply to physics objects that are touched by the player.
		/// </summary>
		public float TouchForceFactor
		{
			get => E_PROP_UCharacterMovementComponent_TouchForceFactor_GET(NativePointer);
			set => E_PROP_UCharacterMovementComponent_TouchForceFactor_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Add force to character. Forces are accumulated each tick and applied together
		/// <para>so multiple calls to this function will accumulate. </para>
		/// Forces are scaled depending on timestep, so they can be applied each frame. If you want an
		/// <para>instantaneous force, use AddImpulse. </para>
		/// Adding a force always takes the actor's mass into account.
		/// <para>Note that changing the momentum of characters like this can change the movement mode. </para>
		/// </summary>
		/// <param name="force">Force to apply.</param>
		public virtual void AddForce(FVector force)
			=> E_UCharacterMovementComponent_AddForce(this, force);
		
		
		/// <summary>
		/// Add impulse to character. Impulses are accumulated each tick and applied together
		/// <para>so multiple calls to this function will accumulate. </para>
		/// An impulse is an instantaneous force, usually applied once. If you want to continually apply
		/// <para>forces each frame, use AddForce(). </para>
		/// Note that changing the momentum of characters like this can change the movement mode.
		/// </summary>
		/// <param name="impulse">Impulse to apply.</param>
		/// <param name="bVelocityChange">Whether or not the impulse is relative to mass.</param>
		public virtual void AddImpulse(FVector impulse, bool bVelocityChange)
			=> E_UCharacterMovementComponent_AddImpulse(this, impulse, bVelocityChange);
		
		
		/// <summary>
		/// Adjust distance from floor, trying to maintain a slight offset from the floor when walking (based on CurrentFloor).
		/// </summary>
		public virtual void AdjustFloorHeight()
			=> E_UCharacterMovementComponent_AdjustFloorHeight(this);
		
		
		/// <summary>
		/// Adjust the size of the capsule on simulated proxies, to avoid overlaps due to replication rounding.
		/// <para>Changes to the capsule size on the proxy should set bShrinkProxyCapsule=true and possibly call AdjustProxyCapsuleSize() immediately if applicable. </para>
		/// </summary>
		protected virtual void AdjustProxyCapsuleSize()
			=> E_UCharacterMovementComponent_AdjustProxyCapsuleSize(this);
		
		
		/// <summary>
		/// Applies momentum accumulated through AddImpulse() and AddForce(), then clears those forces. Does *not* use ClearAccumulatedForces() since that would clear pending launch velocity as well.
		/// </summary>
		public virtual void ApplyAccumulatedForces(float deltaSeconds)
			=> E_UCharacterMovementComponent_ApplyAccumulatedForces(this, deltaSeconds);
		
		
		/// <summary>
		/// Applies downward force when walking on top of physics objects.
		/// </summary>
		/// <param name="deltaSeconds">Time elapsed since last frame.</param>
		public virtual void ApplyDownwardForce(float deltaSeconds)
			=> E_UCharacterMovementComponent_ApplyDownwardForce(this, deltaSeconds);
		
		
		/// <summary>
		/// Apply physics forces to the impacted component, if bEnablePhysicsInteraction is true.
		/// </summary>
		/// <param name="impact">HitResult that resulted in the impact</param>
		/// <param name="impactAcceleration">Acceleration of the character at the time of impact</param>
		/// <param name="impactVelocity">Velocity of the character at the time of impact</param>
		protected virtual void ApplyImpactPhysicsForces(FHitResult impact, FVector impactAcceleration, FVector impactVelocity)
			=> E_UCharacterMovementComponent_ApplyImpactPhysicsForces(this, impact, impactAcceleration, impactVelocity);
		
		public virtual void ApplyNetworkMovementMode(byte receivedMode)
			=> E_UCharacterMovementComponent_ApplyNetworkMovementMode(this, receivedMode);
		
		
		/// <summary>
		/// Applies repulsion force to all touched components.
		/// </summary>
		public virtual void ApplyRepulsionForce(float deltaSeconds)
			=> E_UCharacterMovementComponent_ApplyRepulsionForce(this, deltaSeconds);
		
		
		/// <summary>
		/// Use velocity requested by path following to compute a requested acceleration and speed.
		/// <para>This does not affect the Acceleration member variable, as that is used to indicate input acceleration. </para>
		/// This may directly affect current Velocity.
		/// </summary>
		/// <param name="deltaTime">Time slice for this operation</param>
		/// <param name="maxAccel">Max acceleration allowed in OutAcceleration result.</param>
		/// <param name="maxSpeed">Max speed allowed when computing OutRequestedSpeed.</param>
		/// <param name="friction">Current friction.</param>
		/// <param name="brakingDeceleration">Current braking deceleration.</param>
		/// <param name="outAcceleration">Acceleration computed based on requested velocity.</param>
		/// <param name="outRequestedSpeed">Speed of resulting velocity request, which can affect the max speed allowed by movement.</param>
		/// <return>Whether</return>
		public virtual bool ApplyRequestedMove(float deltaTime, float maxAccel, float maxSpeed, float friction, float brakingDeceleration, FVector outAcceleration, float outRequestedSpeed)
			=> E_UCharacterMovementComponent_ApplyRequestedMove(this, deltaTime, maxAccel, maxSpeed, friction, brakingDeceleration, outAcceleration, outRequestedSpeed);
		
		
		/// <summary>
		/// Slows towards stop.
		/// </summary>
		protected virtual void ApplyVelocityBraking(float deltaTime, float friction, float brakingDeceleration)
			=> E_UCharacterMovementComponent_ApplyVelocityBraking(this, deltaTime, friction, brakingDeceleration);
		
		
		/// <summary>
		/// Increase air control if conditions of AirControlBoostMultiplier and AirControlBoostVelocityThreshold are met.
		/// <para>This function is used internally by GetAirControl(). </para>
		/// <see cref="GetAirControl"/>
		/// </summary>
		/// <param name="deltaTime">Time step for the current update.</param>
		/// <param name="tickAirControl">Current air control value.</param>
		/// <param name="fallAcceleration">Acceleration used during movement.</param>
		/// <return>Modified</return>
		protected virtual float BoostAirControl(float deltaTime, float tickAirControl, FVector fallAcceleration)
			=> E_UCharacterMovementComponent_BoostAirControl(this, deltaTime, tickAirControl, fallAcceleration);
		
		
		/// <summary>
		/// Updates Velocity and Acceleration based on the current state, applying the effects of friction and acceleration or deceleration. Does not apply gravity.
		/// <para>This is used internally during movement updates. Normally you don't need to call this from outside code, but you might want to use it for custom movement modes. </para>
		/// </summary>
		/// <param name="deltaTime">time elapsed since last frame.</param>
		/// <param name="friction">coefficient of friction when not accelerating, or in the direction opposite acceleration.</param>
		/// <param name="bFluid">true if moving through a fluid, causing Friction to always be applied regardless of acceleration.</param>
		/// <param name="brakingDeceleration">deceleration applied when not accelerating, or when exceeding max velocity.</param>
		public virtual void CalcVelocity(float deltaTime, float friction, bool bFluid, float brakingDeceleration)
			=> E_UCharacterMovementComponent_CalcVelocity(this, deltaTime, friction, bFluid, brakingDeceleration);
		
		
		/// <summary>
		/// Internal function to call OnMovementUpdated delegate on CharacterOwner.
		/// </summary>
		protected virtual void CallMovementUpdateDelegate(float deltaSeconds, FVector oldLocation, FVector oldVelocity)
			=> E_UCharacterMovementComponent_CallMovementUpdateDelegate(this, deltaSeconds, oldLocation, oldVelocity);
		
		
		/// <summary>
		/// Returns true if the character is allowed to crouch in the current state. By default it is allowed when walking or falling, if CanEverCrouch() is true.
		/// </summary>
		public virtual bool CanCrouchInCurrentState()
			=> E_UCharacterMovementComponent_CanCrouchInCurrentState(this);
		
		
		/// <summary>
		/// Returns true if we can step up on the actor in the given FHitResult.
		/// </summary>
		public virtual bool CanStepUp(FHitResult hit)
			=> E_UCharacterMovementComponent_CanStepUp(this, hit);
		
		
		/// <summary>
		/// Returns whether this pawn is currently allowed to walk off ledges
		/// </summary>
		public virtual bool CanWalkOffLedges()
			=> E_UCharacterMovementComponent_CanWalkOffLedges(this);
		
		protected virtual void CapsuleTouched(UPrimitiveComponent overlappedComp, AActor other, UPrimitiveComponent otherComp, int otherBodyIndex, bool bFromSweep, FHitResult sweepResult)
			=> E_UCharacterMovementComponent_CapsuleTouched(this, overlappedComp, other, otherComp, otherBodyIndex, bFromSweep, sweepResult);
		
		
		/// <summary>
		/// Check if pawn is falling
		/// </summary>
		public virtual bool CheckFall(FFindFloorResult oldFloor, FHitResult hit, FVector delta, FVector oldLocation, float remainingTime, float timeTick, int iterations, bool bMustJump)
			=> E_UCharacterMovementComponent_CheckFall(this, oldFloor, hit, delta, oldLocation, remainingTime, timeTick, iterations, bMustJump);
		
		
		/// <summary>
		/// Returns true if there is a suitable floor SideStep from current position.
		/// </summary>
		public virtual bool CheckLedgeDirection(FVector oldLocation, FVector sideStep, FVector gravDir)
			=> E_UCharacterMovementComponent_CheckLedgeDirection(this, oldLocation, sideStep, gravDir);
		
		
		/// <summary>
		/// Check if swimming pawn just ran into edge of the pool and should jump out.
		/// </summary>
		public virtual bool CheckWaterJump(FVector checkPoint, FVector wallNormal)
			=> E_UCharacterMovementComponent_CheckWaterJump(this, checkPoint, wallNormal);
		
		
		/// <summary>
		/// Clears forces accumulated through AddImpulse() and AddForce(), and also pending launch velocity.
		/// </summary>
		public virtual void ClearAccumulatedForces()
			=> E_UCharacterMovementComponent_ClearAccumulatedForces(this);
		
		
		/// <summary>
		/// If no client adjustment is needed after processing received ServerMove(), ack the good move so client can remove it from SavedMoves
		/// </summary>
		public virtual void ClientAckGoodMove(float timeStamp)
			=> E_UCharacterMovementComponent_ClientAckGoodMove(this, timeStamp);
		
		public virtual void ClientAckGoodMove_Implementation(float timeStamp)
			=> E_UCharacterMovementComponent_ClientAckGoodMove_Implementation(this, timeStamp);
		
		
		/// <summary>
		/// Replicate position correction to client, associated with a timestamped servermove.  Client will replay subsequent moves after applying adjustment.
		/// </summary>
		public virtual void ClientAdjustPosition(float timeStamp, FVector newLoc, FVector newVel, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustPosition(this, timeStamp, newLoc, newVel, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		public virtual void ClientAdjustPosition_Implementation(float timeStamp, FVector newLoc, FVector newVel, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustPosition_Implementation(this, timeStamp, newLoc, newVel, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		
		/// <summary>
		/// Replicate position correction to client when using root motion for movement. (animation root motion specific)
		/// </summary>
		public virtual void ClientAdjustRootMotionPosition(float timeStamp, float serverMontageTrackPosition, FVector serverLoc, FVector_NetQuantizeNormal serverRotation, float serverVelZ, UPrimitiveComponent serverBase, string serverBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustRootMotionPosition(this, timeStamp, serverMontageTrackPosition, serverLoc, serverRotation, serverVelZ, serverBase, serverBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		public virtual void ClientAdjustRootMotionPosition_Implementation(float timeStamp, float serverMontageTrackPosition, FVector serverLoc, FVector_NetQuantizeNormal serverRotation, float serverVelZ, UPrimitiveComponent serverBase, string serverBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustRootMotionPosition_Implementation(this, timeStamp, serverMontageTrackPosition, serverLoc, serverRotation, serverVelZ, serverBase, serverBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		
		/// <summary>
		/// Replicate root motion source correction to client when using root motion for movement.
		/// </summary>
		public virtual void ClientAdjustRootMotionSourcePosition(float timeStamp, FRootMotionSourceGroup serverRootMotion, bool bHasAnimRootMotion, float serverMontageTrackPosition, FVector serverLoc, FVector_NetQuantizeNormal serverRotation, float serverVelZ, UPrimitiveComponent serverBase, string serverBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustRootMotionSourcePosition(this, timeStamp, serverRootMotion, bHasAnimRootMotion, serverMontageTrackPosition, serverLoc, serverRotation, serverVelZ, serverBase, serverBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		public virtual void ClientAdjustRootMotionSourcePosition_Implementation(float timeStamp, FRootMotionSourceGroup serverRootMotion, bool bHasAnimRootMotion, float serverMontageTrackPosition, FVector serverLoc, FVector_NetQuantizeNormal serverRotation, float serverVelZ, UPrimitiveComponent serverBase, string serverBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientAdjustRootMotionSourcePosition_Implementation(this, timeStamp, serverRootMotion, bHasAnimRootMotion, serverMontageTrackPosition, serverLoc, serverRotation, serverVelZ, serverBase, serverBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		
		/// <summary>
		/// If bUpdatePosition is true, then replay any unacked moves. Returns whether any moves were actually replayed.
		/// </summary>
		protected virtual bool ClientUpdatePositionAfterServerUpdate()
			=> E_UCharacterMovementComponent_ClientUpdatePositionAfterServerUpdate(this);
		
		public virtual void ClientVeryShortAdjustPosition(float timeStamp, FVector newLoc, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientVeryShortAdjustPosition(this, timeStamp, newLoc, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		public virtual void ClientVeryShortAdjustPosition_Implementation(float timeStamp, FVector newLoc, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_UCharacterMovementComponent_ClientVeryShortAdjustPosition_Implementation(this, timeStamp, newLoc, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		
		/// <summary>
		/// Computes the analog input modifier based on current input vector and/or acceleration.
		/// </summary>
		protected virtual float ComputeAnalogInputModifier()
			=> E_UCharacterMovementComponent_ComputeAnalogInputModifier(this);
		
		
		/// <summary>
		/// Compute distance to the floor from bottom sphere of capsule and store the result in OutFloorResult.
		/// <para>This distance is the swept distance of the capsule to the first point impacted by the lower hemisphere, or distance from the bottom of the capsule in the case of a line trace. </para>
		/// This function does not care if collision is disabled on the capsule (unlike FindFloor).
		/// <para>@see FindFloor </para>
		/// </summary>
		/// <param name="capsuleLocation">Location of the capsule used for the query</param>
		/// <param name="lineDistance">If non-zero, max distance to test for a simple line check from the capsule base. Used only if the sweep test fails to find a walkable floor, and only returns a valid result if the impact normal is a walkable normal.</param>
		/// <param name="sweepDistance">If non-zero, max distance to use when sweeping a capsule downwards for the test. MUST be greater than or equal to the line distance.</param>
		/// <param name="outFloorResult">Result of the floor check. The HitResult will contain the valid sweep or line test upon success, or the result of the sweep upon failure.</param>
		/// <param name="sweepRadius">The radius to use for sweep tests. Should be <= capsule radius.</param>
		/// <param name="downwardSweepResult">If non-null and it contains valid blocking hit info, this will be used as the result of a downward sweep test instead of doing it as part of the update.</param>
		public virtual void ComputeFloorDist(FVector capsuleLocation, float lineDistance, float sweepDistance, FFindFloorResult outFloorResult, float sweepRadius, FHitResult downwardSweepResult)
			=> E_UCharacterMovementComponent_ComputeFloorDist(this, capsuleLocation, lineDistance, sweepDistance, outFloorResult, sweepRadius, downwardSweepResult);
		
		
		/// <summary>
		/// Compute a vector of movement, given a delta and a hit result of the surface we are on.
		/// <para>If a ramp vector can't be computed, this will just return Delta. </para>
		/// </summary>
		/// <param name="delta">Attempted movement direction</param>
		/// <param name="rampHit">Hit result of sweep that found the ramp below the capsule</param>
		/// <param name="bHitFromLineTrace">Whether the floor trace came from a line trace</param>
		/// <return>If</return>
		protected virtual FVector ComputeGroundMovementDelta(FVector delta, FHitResult rampHit, bool bHitFromLineTrace)
			=> E_UCharacterMovementComponent_ComputeGroundMovementDelta(this, delta, rampHit, bHitFromLineTrace);
		
		
		/// <summary>
		/// Compute a target rotation based on current movement. Used by PhysicsRotation() when bOrientRotationToMovement is true.
		/// <para>Default implementation targets a rotation based on Acceleration. </para>
		/// </summary>
		/// <param name="currentRotation">Current rotation of the Character</param>
		/// <param name="deltaTime">Time slice for this movement</param>
		/// <param name="deltaRotation">Proposed rotation change based simply on DeltaTime * RotationRate</param>
		/// <return>The</return>
		public virtual FRotator ComputeOrientToMovementRotation(FRotator currentRotation, float deltaTime, FRotator deltaRotation)
			=> E_UCharacterMovementComponent_ComputeOrientToMovementRotation(this, currentRotation, deltaTime, deltaRotation);
		
		
		/// <summary>
		/// Compute the sweep result of the smaller capsule with radius specified by GetValidPerchRadius(),
		/// <para>and return true if the sweep contacts a valid walkable normal within InMaxFloorDist of InHit.ImpactPoint. </para>
		/// This may be used to determine if the capsule can or cannot stay at the current location if perched on the edge of a small ledge or unwalkable surface.
		/// <para>Note: Only returns a valid result if ShouldComputePerchResult returned true for the supplied hit value. </para>
		/// </summary>
		/// <param name="testRadius">Radius to use for the sweep, usually GetValidPerchRadius().</param>
		/// <param name="inHit">Result of the last sweep test before the query.</param>
		/// <param name="inMaxFloorDist">Max distance to floor allowed by perching, from the supplied contact point (InHit.ImpactPoint).</param>
		/// <param name="outPerchFloorResult">Contains the result of the perch floor test.</param>
		/// <return>True</return>
		public virtual bool ComputePerchResult(float testRadius, FHitResult inHit, float inMaxFloorDist, FFindFloorResult outPerchFloorResult)
			=> E_UCharacterMovementComponent_ComputePerchResult(this, testRadius, inHit, inMaxFloorDist, outPerchFloorResult);
		
		
		/// <summary>
		/// Enforce constraints on input given current state. For instance, don't move upwards if walking and looking up.
		/// </summary>
		protected virtual FVector ConstrainInputAcceleration(FVector inputAcceleration)
			=> E_UCharacterMovementComponent_ConstrainInputAcceleration(this, inputAcceleration);
		
		
		/// <summary>
		/// Converts received server IDs in a root motion group to local IDs
		/// </summary>
		public void ConvertRootMotionServerIDsToLocalIDs(FRootMotionSourceGroup localRootMotionToMatchWith, FRootMotionSourceGroup inOutServerRootMotion, float timeStamp)
			=> E_UCharacterMovementComponent_ConvertRootMotionServerIDsToLocalIDs(this, localRootMotionToMatchWith, inOutServerRootMotion, timeStamp);
		
		
		/// <summary>
		/// Checks if new capsule size fits (no encroachment), and call CharacterOwner->OnStartCrouch() if successful.
		/// <para>In general you should set bWantsToCrouch instead to have the crouch persist during movement, or just use the crouch functions on the owning Character. </para>
		/// </summary>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset.</param>
		public virtual void Crouch(bool bClientSimulation)
			=> E_UCharacterMovementComponent_Crouch(this, bClientSimulation);
		
		
		/// <summary>
		/// Make movement impossible (sets movement mode to MOVE_None).
		/// </summary>
		public virtual void DisableMovement()
			=> E_UCharacterMovementComponent_DisableMovement(this);
		
		
		/// <summary>
		/// Perform jump. Called by Character when a jump has been detected because Character->bPressedJump was true. Checks CanJump().
		/// <para>Note that you should usually trigger a jump through Character::Jump() instead. </para>
		/// </summary>
		/// <param name="bReplayingMoves">true if this is being done as part of replaying moves on a locally controlled client after a server correction.</param>
		/// <return>True</return>
		public virtual bool DoJump(bool bReplayingMoves)
			=> E_UCharacterMovementComponent_DoJump(this, bReplayingMoves);
		
		
		/// <summary>
		/// Performs trace for ProjectLocationFromNavMesh
		/// </summary>
		protected virtual void FindBestNavMeshLocation(FVector traceStart, FVector traceEnd, FVector currentFeetLocation, FVector targetNavLocation, FHitResult outHitResult)
			=> E_UCharacterMovementComponent_FindBestNavMeshLocation(this, traceStart, traceEnd, currentFeetLocation, targetNavLocation, outHitResult);
		
		
		/// <summary>
		/// Sweeps a vertical trace to find the floor for the capsule at the given location. Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result.
		/// <para>No floor will be found if collision is disabled on the capsule! </para>
		/// </summary>
		/// <param name="capsuleLocation">Location where the capsule sweep should originate</param>
		/// <param name="outFloorResult">Out] Contains the result of the floor check. The HitResult will contain the valid sweep or line test upon success, or the result of the sweep upon failure.</param>
		/// <param name="bCanUseCachedLocation">If true, may use a cached value (can be used to avoid unnecessary floor tests, if for example the capsule was not moving since the last test).</param>
		/// <param name="downwardSweepResult">If non-null and it contains valid blocking hit info, this will be used as the result of a downward sweep test instead of doing it as part of the update.</param>
		public virtual void FindFloor(FVector capsuleLocation, FFindFloorResult outFloorResult, bool bCanUseCachedLocation, FHitResult downwardSweepResult)
			=> E_UCharacterMovementComponent_FindFloor(this, capsuleLocation, outFloorResult, bCanUseCachedLocation, downwardSweepResult);
		
		
		/// <summary>
		/// Get as close to waterline as possible, staying on same side as currently.
		/// </summary>
		public FVector FindWaterLine(FVector start, FVector end)
			=> E_UCharacterMovementComponent_FindWaterLine(this, start, end);
		
		
		/// <summary>
		/// Force a client adjustment. Resets ServerLastClientAdjustmentTime.
		/// </summary>
		public void ForceClientAdjustment()
			=> E_UCharacterMovementComponent_ForceClientAdjustment(this);
		
		
		/// <summary>
		/// Force a client update by making it appear on the server that the client hasn't updated in a long time.
		/// </summary>
		public virtual void ForceReplicationUpdate()
			=> E_UCharacterMovementComponent_ForceReplicationUpdate(this);
		
		
		/// <summary>
		/// Get the air control to use during falling movement.
		/// <para>Given an initial air control (TickAirControl), applies the result of BoostAirControl(). </para>
		/// This function is used internally by GetFallingLateralAcceleration().
		/// <see cref="AirControl"/>
		/// </summary>
		/// <param name="deltaTime">Time step for the current update.</param>
		/// <param name="tickAirControl">Current air control value.</param>
		/// <param name="fallAcceleration">Acceleration used during movement.</param>
		/// <return>Air</return>
		public virtual FVector GetAirControl(float deltaTime, float tickAirControl, FVector fallAcceleration)
			=> E_UCharacterMovementComponent_GetAirControl(this, deltaTime, tickAirControl, fallAcceleration);
		
		
		/// <summary>
		/// Returns modifier [0..1] based on the magnitude of the last input vector, which is used to modify the acceleration and max speed during movement.
		/// </summary>
		public float GetAnalogInputModifier()
			=> E_UCharacterMovementComponent_GetAnalogInputModifier(this);
		
		
		/// <summary>
		/// Can be overridden to choose to jump based on character velocity, base actor dimensions, etc.
		/// </summary>
		public virtual FVector GetBestDirectionOffActor(AActor baseActor)
			=> E_UCharacterMovementComponent_GetBestDirectionOffActor(this, baseActor);
		
		
		/// <summary>
		/// Get the Character that owns UpdatedComponent.
		/// </summary>
		public ACharacter GetCharacterOwner()
			=> E_UCharacterMovementComponent_GetCharacterOwner(this);
		
		
		/// <summary>
		/// Returns current acceleration, computed from input vector each update.
		/// </summary>
		public FVector GetCurrentAcceleration()
			=> E_UCharacterMovementComponent_GetCurrentAcceleration(this);
		
		
		/// <summary>
		/// Returns how far to rotate character during the time interval DeltaTime.
		/// </summary>
		public virtual FRotator GetDeltaRotation(float deltaTime)
			=> E_UCharacterMovementComponent_GetDeltaRotation(this, deltaTime);
		
		
		/// <summary>
		/// Get the lateral acceleration to use during falling movement. The Z component of the result is ignored.
		/// <para>Default implementation returns current Acceleration value modified by GetAirControl(), with Z component removed, </para>
		/// with magnitude clamped to GetMaxAcceleration().
		/// <para>This function is used internally by PhysFalling(). </para>
		/// </summary>
		/// <param name="deltaTime">Time step for the current update.</param>
		/// <return>Acceleration</return>
		public virtual FVector GetFallingLateralAcceleration(float deltaTime)
			=> E_UCharacterMovementComponent_GetFallingLateralAcceleration(this, deltaTime);
		
		
		/// <summary>
		/// Get current GroundMovementMode value.
		/// <see cref="GroundMovementMode"/>
		/// </summary>
		/// <return>current</return>
		public EMovementMode GetGroundMovementMode()
			=> (EMovementMode)E_UCharacterMovementComponent_GetGroundMovementMode(this);
		
		
		/// <summary>
		/// If we have a movement base, get the velocity that should be imparted by that base, usually when jumping off of it.
		/// <para>Only applies the components of the velocity enabled by bImpartBaseVelocityX, bImpartBaseVelocityY, bImpartBaseVelocityZ. </para>
		/// </summary>
		public virtual FVector GetImpartedMovementBaseVelocity()
			=> E_UCharacterMovementComponent_GetImpartedMovementBaseVelocity(this);
		
		
		/// <summary>
		/// Returns the location at the end of the last tick.
		/// </summary>
		public FVector GetLastUpdateLocation()
			=> E_UCharacterMovementComponent_GetLastUpdateLocation(this);
		
		
		/// <summary>
		/// Returns the rotation Quat at the end of the last tick.
		/// </summary>
		public FQuat GetLastUpdateQuat()
			=> E_UCharacterMovementComponent_GetLastUpdateQuat(this);
		
		
		/// <summary>
		/// Returns the rotation at the end of the last tick.
		/// </summary>
		public FRotator GetLastUpdateRotation()
			=> E_UCharacterMovementComponent_GetLastUpdateRotation(this);
		
		
		/// <summary>
		/// Returns the velocity at the end of the last tick.
		/// </summary>
		public FVector GetLastUpdateVelocity()
			=> E_UCharacterMovementComponent_GetLastUpdateVelocity(this);
		
		
		/// <summary>
		/// </summary>
		/// <param name="delta">is the current move delta (which ended up going over a ledge).</param>
		/// <return>new</return>
		public virtual FVector GetLedgeMove(FVector oldLocation, FVector delta, FVector gravDir)
			=> E_UCharacterMovementComponent_GetLedgeMove(this, oldLocation, delta, gravDir);
		
		
		/// <summary>
		/// Returns maximum acceleration for the current state.
		/// </summary>
		public virtual float GetMaxAcceleration()
			=> E_UCharacterMovementComponent_GetMaxAcceleration(this);
		
		
		/// <summary>
		/// Returns maximum deceleration for the current state when braking (ie when there is no acceleration).
		/// </summary>
		public virtual float GetMaxBrakingDeceleration()
			=> E_UCharacterMovementComponent_GetMaxBrakingDeceleration(this);
		
		
		/// <summary>
		/// Compute the max jump height based on the JumpZVelocity velocity and gravity.
		/// <para>This does not take into account the CharacterOwner's MaxJumpHoldTime. </para>
		/// </summary>
		public virtual float GetMaxJumpHeight()
			=> E_UCharacterMovementComponent_GetMaxJumpHeight(this);
		
		
		/// <summary>
		/// Compute the max jump height based on the JumpZVelocity velocity and gravity.
		/// <para>This does take into account the CharacterOwner's MaxJumpHoldTime. </para>
		/// </summary>
		public virtual float GetMaxJumpHeightWithJumpTime()
			=> E_UCharacterMovementComponent_GetMaxJumpHeightWithJumpTime(this);
		
		
		/// <summary>
		/// Returns maximum acceleration for the current state.
		/// </summary>
		public virtual float GetMinAnalogSpeed()
			=> E_UCharacterMovementComponent_GetMinAnalogSpeed(this);
		
		public virtual float GetModifiedMaxAcceleration()
			=> E_UCharacterMovementComponent_GetModifiedMaxAcceleration(this);
		
		
		/// <summary>
		/// Return PrimitiveComponent we are based on (standing and walking on).
		/// </summary>
		public UPrimitiveComponent GetMovementBase()
			=> E_UCharacterMovementComponent_GetMovementBase(this);
		
		
		/// <summary>
		/// Returns MovementMode string
		/// </summary>
		public virtual string GetMovementName()
			=> E_UCharacterMovementComponent_GetMovementName(this);
		
		
		/// <summary>
		/// Generate a random angle in degrees that is approximately equal between client and server.
		/// <para>Note that in networked games this result changes with low frequency and has a low period, </para>
		/// so should not be used for frequent randomization.
		/// </summary>
		public virtual float GetNetworkSafeRandomAngleDegrees()
			=> E_UCharacterMovementComponent_GetNetworkSafeRandomAngleDegrees(this);
		
		
		/// <summary>
		/// Returns The distance from the edge of the capsule within which we don't allow the character to perch on the edge of a surface.
		/// </summary>
		public float GetPerchRadiusThreshold()
			=> E_UCharacterMovementComponent_GetPerchRadiusThreshold(this);
		
		
		/// <summary>
		/// Get the value of ServerLastTransformUpdateTimeStamp.
		/// </summary>
		public float GetServerLastTransformUpdateTimeStamp()
			=> E_UCharacterMovementComponent_GetServerLastTransformUpdateTimeStamp(this);
		
		
		/// <summary>
		/// Compute remaining time step given remaining time and current iterations.
		/// <para>The last iteration (limited by MaxSimulationIterations) always returns the remaining time, which may violate MaxSimulationTimeStep. </para>
		/// <see cref="MaxSimulationTimeStep"/>
		/// </summary>
		/// <param name="remainingTime">Remaining time in the tick.</param>
		/// <param name="iterations">Current iteration of the tick (starting at 1).</param>
		/// <return>The</return>
		public float GetSimulationTimeStep(float remainingTime, int iterations)
			=> E_UCharacterMovementComponent_GetSimulationTimeStep(this, remainingTime, iterations);
		
		
		/// <summary>
		/// Returns the radius within which we can stand on the edge of a surface without falling (if this is a walkable surface).
		/// <para>Simply computed as the capsule radius minus the result of GetPerchRadiusThreshold(). </para>
		/// </summary>
		public float GetValidPerchRadius()
			=> E_UCharacterMovementComponent_GetValidPerchRadius(this);
		
		
		/// <summary>
		/// Get the max angle in degrees of a walkable surface for the character.
		/// </summary>
		public float GetWalkableFloorAngle()
			=> E_UCharacterMovementComponent_GetWalkableFloorAngle(this);
		
		
		/// <summary>
		/// Get the Z component of the normal of the steepest walkable surface for the character. Any lower than this and it is not walkable.
		/// </summary>
		public float GetWalkableFloorZ()
			=> E_UCharacterMovementComponent_GetWalkableFloorZ(this);
		
		
		/// <summary>
		/// Handle a pending launch during an update. Returns true if the launch was triggered.
		/// </summary>
		public virtual bool HandlePendingLaunch()
			=> E_UCharacterMovementComponent_HandlePendingLaunch(this);
		
		
		/// <summary>
		/// Limit the slide vector when falling if the resulting slide might boost the character faster upwards.
		/// </summary>
		/// <param name="slideResult">Vector of movement for the slide (usually the result of ComputeSlideVector)</param>
		/// <param name="delta">Original attempted move</param>
		/// <param name="time">Amount of move to apply (between 0 and 1).</param>
		/// <param name="normal">Normal opposed to movement. Not necessarily equal to Hit.Normal (but usually is).</param>
		/// <param name="hit">HitResult of the move that resulted in the slide.</param>
		/// <return>New</return>
		protected virtual FVector HandleSlopeBoosting(FVector slideResult, FVector delta, float time, FVector normal, FHitResult hit)
			=> E_UCharacterMovementComponent_HandleSlopeBoosting(this, slideResult, delta, time, normal, hit);
		
		protected virtual void HandleSwimmingWallHit(FHitResult hit, float deltaTime)
			=> E_UCharacterMovementComponent_HandleSwimmingWallHit(this, hit, deltaTime);
		
		
		/// <summary>
		/// Trigger OnWalkingOffLedge event on CharacterOwner.
		/// </summary>
		public virtual void HandleWalkingOffLedge(FVector previousFloorImpactNormal, FVector previousFloorContactNormal, FVector previousLocation, float timeDelta)
			=> E_UCharacterMovementComponent_HandleWalkingOffLedge(this, previousFloorImpactNormal, previousFloorContactNormal, previousLocation, timeDelta);
		
		
		/// <summary>
		/// Returns true if we have Root Motion from any source to use in PerformMovement() physics.
		/// </summary>
		public bool HasRootMotionSources()
			=> E_UCharacterMovementComponent_HasRootMotionSources(this);
		
		
		/// <summary>
		/// Return true if we have a valid CharacterOwner and UpdatedComponent.
		/// </summary>
		public virtual bool HasValidData()
			=> E_UCharacterMovementComponent_HasValidData(this);
		
		public virtual float ImmersionDepth()
			=> E_UCharacterMovementComponent_ImmersionDepth(this);
		
		
		/// <summary>
		/// Returns true if currently performing a movement update.
		/// <para>@see bMovementInProgress </para>
		/// </summary>
		public bool IsMovementInProgress()
			=> E_UCharacterMovementComponent_IsMovementInProgress(this);
		
		
		/// <summary>
		/// Verify that the supplied hit result is a valid landing spot when falling.
		/// </summary>
		public virtual bool IsValidLandingSpot(FVector capsuleLocation, FHitResult hit)
			=> E_UCharacterMovementComponent_IsValidLandingSpot(this, capsuleLocation, hit);
		
		
		/// <summary>
		/// Return true if the hit result should be considered a walkable surface for the character.
		/// </summary>
		public virtual bool IsWalkable(FHitResult hit)
			=> E_UCharacterMovementComponent_IsWalkable(this, hit);
		
		
		/// <summary>
		/// Returns true if the character is in the 'Walking' movement mode.
		/// </summary>
		public bool IsWalking()
			=> E_UCharacterMovementComponent_IsWalking(this);
		
		
		/// <summary>
		/// Return true if the 2D distance to the impact point is inside the edge tolerance (CapsuleRadius minus a small rejection threshold).
		/// <para>Useful for rejecting adjacent hits when finding a floor or landing spot. </para>
		/// </summary>
		public virtual bool IsWithinEdgeTolerance(FVector capsuleLocation, FVector testImpactPoint, float capsuleRadius)
			=> E_UCharacterMovementComponent_IsWithinEdgeTolerance(this, capsuleLocation, testImpactPoint, capsuleRadius);
		
		
		/// <summary>
		/// Force this pawn to bounce off its current base, which isn't an acceptable base for it.
		/// </summary>
		public virtual void JumpOff(AActor movementBaseActor)
			=> E_UCharacterMovementComponent_JumpOff(this, movementBaseActor);
		
		
		/// <summary>
		/// Jump onto shore from water
		/// </summary>
		public virtual void JumpOutOfWater(FVector wallNormal)
			=> E_UCharacterMovementComponent_JumpOutOfWater(this, wallNormal);
		
		
		/// <summary>
		/// Compute distance to the floor from bottom sphere of capsule and store the result in FloorResult.
		/// <para>This distance is the swept distance of the capsule to the first point impacted by the lower hemisphere, or distance from the bottom of the capsule in the case of a line trace. </para>
		/// This function does not care if collision is disabled on the capsule (unlike FindFloor).
		/// </summary>
		/// <param name="capsuleLocation">Location where the capsule sweep should originate</param>
		/// <param name="lineDistance">If non-zero, max distance to test for a simple line check from the capsule base. Used only if the sweep test fails to find a walkable floor, and only returns a valid result if the impact normal is a walkable normal.</param>
		/// <param name="sweepDistance">If non-zero, max distance to use when sweeping a capsule downwards for the test. MUST be greater than or equal to the line distance.</param>
		/// <param name="sweepRadius">The radius to use for sweep tests. Should be <= capsule radius.</param>
		/// <param name="floorResult">Result of the floor check</param>
		public virtual void ComputeFloorDistance(FVector capsuleLocation, float lineDistance, float sweepDistance, float sweepRadius, FFindFloorResult floorResult)
			=> E_UCharacterMovementComponent_K2_ComputeFloorDist(this, capsuleLocation, lineDistance, sweepDistance, sweepRadius, floorResult);
		
		
		/// <summary>
		/// Sweeps a vertical trace to find the floor for the capsule at the given location. Will attempt to perch if ShouldComputePerchResult() returns true for the downward sweep result.
		/// <para>No floor will be found if collision is disabled on the capsule! </para>
		/// </summary>
		/// <param name="capsuleLocation">Location where the capsule sweep should originate</param>
		/// <param name="floorResult">Result of the floor check</param>
		public virtual void K2_FindFloor(FVector capsuleLocation, FFindFloorResult floorResult)
			=> E_UCharacterMovementComponent_K2_FindFloor(this, capsuleLocation, floorResult);
		
		
		/// <summary>
		/// Returns maximum acceleration for the current state, based on MaxAcceleration and any additional modifiers.
		/// </summary>
		public virtual float K2_GetModifiedMaxAcceleration()
			=> E_UCharacterMovementComponent_K2_GetModifiedMaxAcceleration(this);
		
		
		/// <summary>
		/// Get the max angle in degrees of a walkable surface for the character.
		/// </summary>
		public float K2_GetWalkableFloorAngle()
			=> E_UCharacterMovementComponent_K2_GetWalkableFloorAngle(this);
		
		
		/// <summary>
		/// Get the Z component of the normal of the steepest walkable surface for the character. Any lower than this and it is not walkable.
		/// </summary>
		public float K2_GetWalkableFloorZ()
			=> E_UCharacterMovementComponent_K2_GetWalkableFloorZ(this);
		
		
		/// <summary>
		/// Queue a pending launch with velocity LaunchVel.
		/// </summary>
		public virtual void Launch(FVector launchVel)
			=> E_UCharacterMovementComponent_Launch(this, launchVel);
		
		
		/// <summary>
		/// Limits the air control to use during falling movement, given an impact while falling.
		/// <para>This function is used internally by PhysFalling(). </para>
		/// <see cref="PhysFalling"/>
		/// </summary>
		/// <param name="deltaTime">Time step for the current update.</param>
		/// <param name="fallAcceleration">Acceleration used during movement.</param>
		/// <param name="hitResult">Result of impact.</param>
		/// <param name="bCheckForValidLandingSpot">If true, will use IsValidLandingSpot() to determine if HitResult is a walkable surface. If false, this check is skipped.</param>
		/// <return>Modified</return>
		protected virtual FVector LimitAirControl(float deltaTime, FVector fallAcceleration, FHitResult hitResult, bool bCheckForValidLandingSpot)
			=> E_UCharacterMovementComponent_LimitAirControl(this, deltaTime, fallAcceleration, hitResult, bCheckForValidLandingSpot);
		
		
		/// <summary>
		/// Adjusts velocity when walking so that Z velocity is zero.
		/// <para>When bMaintainHorizontalGroundVelocity is false, also rescales the velocity vector to maintain the original magnitude, but in the horizontal direction. </para>
		/// </summary>
		protected virtual void MaintainHorizontalGroundVelocity()
			=> E_UCharacterMovementComponent_MaintainHorizontalGroundVelocity(this);
		
		
		/// <summary>
		/// Call SaveBaseLocation() if not deferring updates (bDeferUpdateBasedMovement is false).
		/// </summary>
		public virtual void MaybeSaveBaseLocation()
			=> E_UCharacterMovementComponent_MaybeSaveBaseLocation(this);
		
		
		/// <summary>
		/// Update or defer updating of position based on Base movement
		/// </summary>
		public virtual void MaybeUpdateBasedMovement(float deltaSeconds)
			=> E_UCharacterMovementComponent_MaybeUpdateBasedMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// Move along the floor, using CurrentFloor and ComputeGroundMovementDelta() to get a movement direction.
		/// <para>If a second walkable surface is hit, it will also be moved along using the same approach. </para>
		/// </summary>
		/// <param name="inVelocity">Velocity of movement</param>
		/// <param name="deltaSeconds">Time over which movement occurs</param>
		/// <param name="outStepDownResult">Out] If non-null, and a floor check is performed, this will be updated to reflect that result.</param>
		protected virtual void MoveAlongFloor(FVector inVelocity, float deltaSeconds)
			=> E_UCharacterMovementComponent_MoveAlongFloor(this, inVelocity, deltaSeconds);
		
		protected virtual void MoveAutonomous(float clientTimeStamp, float deltaTime, byte compressedFlags, FVector newAccel)
			=> E_UCharacterMovementComponent_MoveAutonomous(this, clientTimeStamp, deltaTime, compressedFlags, newAccel);
		
		
		/// <summary>
		/// Moves along the given movement direction using simple movement rules based on the current movement mode (usually used by simulated proxies).
		/// </summary>
		/// <param name="inVelocity">Velocity of movement</param>
		/// <param name="deltaSeconds">Time over which movement occurs</param>
		/// <param name="outStepDownResult">Out] If non-null, and a floor check is performed, this will be updated to reflect that result.</param>
		public virtual void MoveSmooth(FVector inVelocity, float deltaSeconds)
			=> E_UCharacterMovementComponent_MoveSmooth(this, inVelocity, deltaSeconds);
		
		
		/// <summary>
		/// Compute new falling velocity from given velocity and gravity. Applies the limits of the current Physics Volume's TerminalVelocity.
		/// </summary>
		public virtual FVector NewFallVelocity(FVector initialVelocity, FVector gravity, float deltaTime)
			=> E_UCharacterMovementComponent_NewFallVelocity(this, initialVelocity, gravity, deltaTime);
		
		
		/// <summary>
		/// Called if bNotifyApex is true and character has just passed the apex of its jump.
		/// </summary>
		public virtual void NotifyJumpApex()
			=> E_UCharacterMovementComponent_NotifyJumpApex(this);
		
		
		/// <summary>
		/// Notification that the character is stuck in geometry.  Only called during walking movement.
		/// </summary>
		protected virtual void OnCharacterStuckInGeometry(FHitResult hit)
			=> E_UCharacterMovementComponent_OnCharacterStuckInGeometry(this, hit);
		
		
		/// <summary>
		/// Called by UCharacterMovementComponent::VerifyClientTimeStamp() when a client timestamp reset has been detected and is valid.
		/// </summary>
		protected virtual void OnClientTimeStampResetDetected()
			=> E_UCharacterMovementComponent_OnClientTimeStampResetDetected(this);
		
		
		/// <summary>
		/// Called after MovementMode has changed. Base implementation does special handling for starting certain modes, then notifies the CharacterOwner.
		/// </summary>
		protected virtual void OnMovementModeChanged(EMovementMode previousMovementMode, byte previousCustomMode)
			=> E_UCharacterMovementComponent_OnMovementModeChanged(this, (byte)previousMovementMode, previousCustomMode);
		
		
		/// <summary>
		/// Event triggered at the end of a movement update. If scoped movement updates are enabled (bEnableScopedMovementUpdates), this is within such a scope.
		/// <para>If that is not desired, bind to the CharacterOwner's OnMovementUpdated event instead, as that is triggered after the scoped movement update. </para>
		/// </summary>
		protected virtual void OnMovementUpdated(float deltaSeconds, FVector oldLocation, FVector oldVelocity)
			=> E_UCharacterMovementComponent_OnMovementUpdated(this, deltaSeconds, oldLocation, oldVelocity);
		
		
		/// <summary>
		/// Called during ApplyRootMotionSource call, useful for project-specific alerts for "something is about to be altering our movement"
		/// </summary>
		public virtual void OnRootMotionSourceBeingApplied(FRootMotionSource source)
			=> E_UCharacterMovementComponent_OnRootMotionSourceBeingApplied(this, source);
		
		
		/// <summary>
		/// Called by UCharacterMovementComponent::ProcessClientTimeStampForTimeDiscrepancy() (on server) when the time from client moves
		/// <para>significantly differs from the server time, indicating potential time manipulation by clients (speed hacks, significant network </para>
		/// issues, client performance problems)
		/// <para>by MovementTimeDiscrepancy config variables in AGameNetworkManager, and is the value with which </para>
		/// we test against to trigger this function. This is reset when MovementTimeDiscrepancy resolution
		/// <para>is enabled </para>
		/// and does NOT get affected by MovementTimeDiscrepancy resolution, and is useful as a longer-term
		/// <para>view of how the given client is performing. High magnitude unbounded error points to </para>
		/// intentional tampering by a client vs. occasional "naturally caused" spikes in error due to
		/// <para>burst packet loss/performance hitches </para>
		/// of LifetimeUnboundedError)
		/// <para>current move that has caused TimeDiscrepancy to accumulate enough to trigger detection. </para>
		/// </summary>
		/// <param name="currentTimeDiscrepancy">Accumulated time difference between client ServerMove and server time - this is bounded</param>
		/// <param name="lifetimeRawTimeDiscrepancy">Accumulated time difference between client ServerMove and server time - this is unbounded</param>
		/// <param name="lifetime">Game time over which LifetimeRawTimeDiscrepancy has accrued (useful for determining severity</param>
		/// <param name="currentMoveError">Time difference between client ServerMove and how much time has passed on the server for the</param>
		protected virtual void OnTimeDiscrepancyDetected(float currentTimeDiscrepancy, float lifetimeRawTimeDiscrepancy, float lifetime, float currentMoveError)
			=> E_UCharacterMovementComponent_OnTimeDiscrepancyDetected(this, currentTimeDiscrepancy, lifetimeRawTimeDiscrepancy, lifetime, currentMoveError);
		
		
		/// <summary>
		/// Event triggered when we are moving on a base but we are not able to move the full DeltaPosition because something has blocked us.
		/// <para>Note: MoveComponentFlags includes the flag to ignore the movement base while this event is fired. </para>
		/// </summary>
		/// <param name="deltaPosition">How far we tried to move with the base.</param>
		/// <param name="oldLocation">Location before we tried to move with the base.</param>
		/// <param name="moveOnBaseHit">Hit result for the object we hit when trying to move with the base.</param>
		protected virtual void OnUnableToFollowBaseMove(FVector deltaPosition, FVector oldLocation, FHitResult moveOnBaseHit)
			=> E_UCharacterMovementComponent_OnUnableToFollowBaseMove(this, deltaPosition, oldLocation, moveOnBaseHit);
		
		public virtual byte PackNetworkMovementMode()
			=> E_UCharacterMovementComponent_PackNetworkMovementMode(this);
		
		
		/// <summary>
		/// Update Velocity and Acceleration to air control in the desired Direction for character using path following.
		/// <see cref="RequestDirectMove"/>
		/// </summary>
		/// <param name="direction">is the desired direction of movement</param>
		/// <param name="zDiff">is the height difference between the destination and the Pawn's current position</param>
		public virtual void PerformAirControlForPathFollowing(FVector direction, float zDiff)
			=> E_UCharacterMovementComponent_PerformAirControlForPathFollowing(this, direction, zDiff);
		
		
		/// <summary>
		/// Perform movement on an autonomous client
		/// </summary>
		protected virtual void PerformMovement(float deltaTime)
			=> E_UCharacterMovementComponent_PerformMovement(this, deltaTime);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected virtual void PhysCustom(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysCustom(this, deltaTime, iterations);
		
		
		/// <summary>
		/// Handle falling movement.
		/// </summary>
		public virtual void PhysFalling(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysFalling(this, deltaTime, iterations);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected virtual void PhysFlying(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysFlying(this, deltaTime, iterations);
		
		
		/// <summary>
		/// Perform rotation over deltaTime
		/// </summary>
		public virtual void PhysicsRotation(float deltaTime)
			=> E_UCharacterMovementComponent_PhysicsRotation(this, deltaTime);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected virtual void PhysNavWalking(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysNavWalking(this, deltaTime, iterations);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected virtual void PhysSwimming(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysSwimming(this, deltaTime, iterations);
		
		
		/// <summary>
		/// @note Movement update functions should only be called through StartNewPhysics()
		/// </summary>
		protected virtual void PhysWalking(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_PhysWalking(this, deltaTime, iterations);
		
		
		/// <summary>
		/// Handle landing against Hit surface over remaingTime and iterations, calling SetPostLandedPhysics() and starting the new movement mode.
		/// </summary>
		protected virtual void ProcessLanded(FHitResult hit, float remainingTime, int iterations)
			=> E_UCharacterMovementComponent_ProcessLanded(this, hit, remainingTime, iterations);
		
		
		/// <summary>
		/// Attempts to better align navmesh walking characters with underlying geometry (sometimes
		/// <para>navmesh can differ quite significantly from geometry). </para>
		/// Updates CachedProjectedNavMeshHitResult, access this for more info about hits.
		/// </summary>
		protected virtual FVector ProjectLocationFromNavMesh(float deltaSeconds, FVector currentFeetLocation, FVector targetNavLocation, float upOffset, float downOffset)
			=> E_UCharacterMovementComponent_ProjectLocationFromNavMesh(this, deltaSeconds, currentFeetLocation, targetNavLocation, upOffset, downOffset);
		
		
		/// <summary>
		/// Remove a RootMotionSource from current root motion by name
		/// </summary>
		public void RemoveRootMotionSource(string instanceName)
			=> E_UCharacterMovementComponent_RemoveRootMotionSource(this, instanceName);
		
		
		/// <summary>
		/// Perform local movement and send the move to the server.
		/// </summary>
		protected virtual void ReplicateMoveToServer(float deltaTime, FVector newAcceleration)
			=> E_UCharacterMovementComponent_ReplicateMoveToServer(this, deltaTime, newAcceleration);
		
		
		/// <summary>
		/// Revert to previous position OldLocation, return to being based on OldBase.
		/// <para>if bFailMove, stop movement and notify controller </para>
		/// </summary>
		public void RevertMove(FVector oldLocation, UPrimitiveComponent oldBase, FVector inOldBaseLocation, FFindFloorResult oldFloor, bool bFailMove)
			=> E_UCharacterMovementComponent_RevertMove(this, oldLocation, oldBase, inOldBaseLocation, oldFloor, bFailMove);
		
		
		/// <summary>
		/// Round acceleration, for better consistency and lower bandwidth in networked games.
		/// </summary>
		public virtual FVector RoundAcceleration(FVector inAccel)
			=> E_UCharacterMovementComponent_RoundAcceleration(this, inAccel);
		
		
		/// <summary>
		/// Update OldBaseLocation and OldBaseQuat if there is a valid movement base, and store the relative location/rotation if necessary. Ignores bDeferUpdateBasedMovement and forces the update.
		/// </summary>
		public virtual void SaveBaseLocation()
			=> E_UCharacterMovementComponent_SaveBaseLocation(this);
		
		
		/// <summary>
		/// Scale input acceleration, based on movement acceleration rate.
		/// </summary>
		protected virtual FVector ScaleInputAcceleration(FVector inputAcceleration)
			=> E_UCharacterMovementComponent_ScaleInputAcceleration(this, inputAcceleration);
		
		
		/// <summary>
		/// Check for Server-Client disagreement in position or other movement state important enough to trigger a client correction.
		/// <see cref="ServerMoveHandleClientError"/>
		/// </summary>
		protected virtual bool ServerCheckClientError(float clientTimeStamp, float deltaTime, FVector accel, FVector clientWorldLocation, FVector relativeClientLocation, UPrimitiveComponent clientMovementBase, string clientBaseBoneName, byte clientMovementMode)
			=> E_UCharacterMovementComponent_ServerCheckClientError(this, clientTimeStamp, deltaTime, accel, clientWorldLocation, relativeClientLocation, clientMovementBase, clientBaseBoneName, clientMovementMode);
		
		
		/// <summary>
		/// Have the server check if the client is outside an error tolerance, and queue a client adjustment if so.
		/// <para>If either GetPredictionData_Server_Character()->bForceClientUpdate or ServerCheckClientError() are true, the client adjustment will be sent. </para>
		/// RelativeClientLocation will be a relative location if MovementBaseUtility::UseRelativePosition(ClientMovementBase) is true, or a world location if false.
		/// <see cref="ServerCheckClientError"/>
		/// </summary>
		protected virtual void ServerMoveHandleClientError(float clientTimeStamp, float deltaTime, FVector accel, FVector relativeClientLocation, UPrimitiveComponent clientMovementBase, string clientBaseBoneName, byte clientMovementMode)
			=> E_UCharacterMovementComponent_ServerMoveHandleClientError(this, clientTimeStamp, deltaTime, accel, relativeClientLocation, clientMovementBase, clientBaseBoneName, clientMovementMode);
		
		public virtual void ServerMoveOld(float oldTimeStamp, FVector_NetQuantize10 oldAccel, byte oldMoveFlags)
			=> E_UCharacterMovementComponent_ServerMoveOld(this, oldTimeStamp, oldAccel, oldMoveFlags);
		
		public virtual void ServerMoveOld_Implementation(float oldTimeStamp, FVector_NetQuantize10 oldAccel, byte oldMoveFlags)
			=> E_UCharacterMovementComponent_ServerMoveOld_Implementation(this, oldTimeStamp, oldAccel, oldMoveFlags);
		
		public virtual bool ServerMoveOld_Validate(float oldTimeStamp, FVector_NetQuantize10 oldAccel, byte oldMoveFlags)
			=> E_UCharacterMovementComponent_ServerMoveOld_Validate(this, oldTimeStamp, oldAccel, oldMoveFlags);
		
		
		/// <summary>
		/// Change avoidance state and registers in RVO manager if needed
		/// </summary>
		public void SetAvoidanceEnabled(bool bEnable)
			=> E_UCharacterMovementComponent_SetAvoidanceEnabled(this, bEnable);
		
		public void SetAvoidanceGroup(int groupFlags)
			=> E_UCharacterMovementComponent_SetAvoidanceGroup(this, groupFlags);
		
		
		/// <summary>
		/// Update the base of the character, which is the PrimitiveComponent we are standing on.
		/// </summary>
		public virtual void SetBase(UPrimitiveComponent newBase, string boneName, bool bNotifyActor)
			=> E_UCharacterMovementComponent_SetBase(this, newBase, boneName, bNotifyActor);
		
		
		/// <summary>
		/// Update the base of the character, using the given floor result if it is walkable, or null if not. Calls SetBase().
		/// </summary>
		public void SetBaseFromFloor(FFindFloorResult floorResult)
			=> E_UCharacterMovementComponent_SetBaseFromFloor(this, floorResult);
		
		
		/// <summary>
		/// Set movement mode to the default based on the current physics volume.
		/// </summary>
		public virtual void SetDefaultMovementMode()
			=> E_UCharacterMovementComponent_SetDefaultMovementMode(this);
		
		
		/// <summary>
		/// Set movement mode to use when returning to walking movement (either MOVE_Walking or MOVE_NavWalking).
		/// <para>If movement mode is currently one of Walking or NavWalking, this will also change the current movement mode (via SetMovementMode()) </para>
		/// if the new mode is not the current ground mode.
		/// <para>@see GroundMovementMode </para>
		/// </summary>
		/// <param name="newGroundMovementMode">New ground movement mode. Must be either MOVE_Walking or MOVE_NavWalking, other values are ignored.</param>
		public void SetGroundMovementMode(EMovementMode newGroundMovementMode)
			=> E_UCharacterMovementComponent_SetGroundMovementMode(this, (byte)newGroundMovementMode);
		
		public void SetGroupsToAvoid(int groupFlags)
			=> E_UCharacterMovementComponent_SetGroupsToAvoid(this, groupFlags);
		
		public void SetGroupsToIgnore(int groupFlags)
			=> E_UCharacterMovementComponent_SetGroupsToIgnore(this, groupFlags);
		
		
		/// <summary>
		/// Change movement mode.
		/// </summary>
		/// <param name="newMovementMode">The new movement mode</param>
		/// <param name="newCustomMode">The new custom sub-mode, only applicable if NewMovementMode is Custom.</param>
		public virtual void SetMovementMode(EMovementMode newMovementMode, byte newCustomMode)
			=> E_UCharacterMovementComponent_SetMovementMode(this, (byte)newMovementMode, newCustomMode);
		
		
		/// <summary>
		/// Switch collision settings for NavWalking mode (ignore world collisions)
		/// </summary>
		protected virtual void SetNavWalkingPhysics(bool bEnable)
			=> E_UCharacterMovementComponent_SetNavWalkingPhysics(this, bEnable);
		
		
		/// <summary>
		/// Use new physics after landing. Defaults to swimming if in water, walking otherwise.
		/// </summary>
		protected virtual void SetPostLandedPhysics(FHitResult hit)
			=> E_UCharacterMovementComponent_SetPostLandedPhysics(this, hit);
		
		
		/// <summary>
		/// Set the max angle in degrees of a walkable surface for the character. Also computes WalkableFloorZ.
		/// </summary>
		public void SetWalkableFloorAngle(float inWalkableFloorAngle)
			=> E_UCharacterMovementComponent_SetWalkableFloorAngle(this, inWalkableFloorAngle);
		
		
		/// <summary>
		/// Set the Z component of the normal of the steepest walkable surface for the character. Also computes WalkableFloorAngle.
		/// </summary>
		public void SetWalkableFloorZ(float inWalkableFloorZ)
			=> E_UCharacterMovementComponent_SetWalkableFloorZ(this, inWalkableFloorZ);
		
		
		/// <summary>
		/// On the server if we know we are having our replication rate throttled, this method checks if important replicated properties have changed that should cause us to return to the normal replication rate.
		/// </summary>
		protected virtual bool ShouldCancelAdaptiveReplication()
			=> E_UCharacterMovementComponent_ShouldCancelAdaptiveReplication(this);
		
		
		/// <summary>
		/// Whether Character should go into falling mode when walking and changing position, based on an old and new floor result (both of which are considered walkable).
		/// <para>Default implementation always returns false. </para>
		/// </summary>
		/// <return>true</return>
		public virtual bool ShouldCatchAir(FFindFloorResult oldFloor, FFindFloorResult newFloor)
			=> E_UCharacterMovementComponent_ShouldCatchAir(this, oldFloor, newFloor);
		
		
		/// <summary>
		/// Determine whether we should try to find a valid landing spot after an impact with an invalid one (based on the Hit result).
		/// <para>For example, landing on the lower portion of the capsule on the edge of geometry may be a walkable surface, but could have reported an unwalkable impact normal. </para>
		/// </summary>
		public virtual bool ShouldCheckForValidLandingSpot(float deltaTime, FVector delta, FHitResult hit)
			=> E_UCharacterMovementComponent_ShouldCheckForValidLandingSpot(this, deltaTime, delta, hit);
		
		
		/// <summary>
		/// Check if the result of a sweep test (passed in InHit) might be a valid location to perch, in which case we should use ComputePerchResult to validate the location.
		/// <para>@see ComputePerchResult </para>
		/// </summary>
		/// <param name="inHit">Result of the last sweep test before this query.</param>
		/// <param name="bCheckRadius">If true, only allow the perch test if the impact point is outside the radius returned by GetValidPerchRadius().</param>
		/// <return>Whether</return>
		public virtual bool ShouldComputePerchResult(FHitResult inHit, bool bCheckRadius)
			=> E_UCharacterMovementComponent_ShouldComputePerchResult(this, inHit, bCheckRadius);
		
		
		/// <summary>
		/// Determine whether the Character should jump when exiting water.
		/// </summary>
		/// <param name="jumpDir">is the desired direction to jump out of water</param>
		/// <return>true</return>
		public virtual bool ShouldJumpOutOfWater(FVector jumpDir)
			=> E_UCharacterMovementComponent_ShouldJumpOutOfWater(this, jumpDir);
		
		
		/// <summary>
		/// if true, DesiredRotation will be restricted to only Yaw component in PhysicsRotation()
		/// </summary>
		public virtual bool ShouldRemainVertical()
			=> E_UCharacterMovementComponent_ShouldRemainVertical(this);
		
		
		/// <summary>
		/// Special Tick for Simulated Proxies
		/// </summary>
		protected void SimulatedTick(float deltaSeconds)
			=> E_UCharacterMovementComponent_SimulatedTick(this, deltaSeconds);
		
		
		/// <summary>
		/// Simulate movement on a non-owning client. Called by SimulatedTick().
		/// </summary>
		protected virtual void SimulateMovement(float deltaTime)
			=> E_UCharacterMovementComponent_SimulateMovement(this, deltaTime);
		
		
		/// <summary>
		/// Smooth mesh location for network interpolation, based on values set up by SmoothCorrection.
		/// <para>Internally this simply calls SmoothClientPosition_Interpolate() then SmoothClientPosition_UpdateVisuals(). </para>
		/// This function is not called when bNetworkSmoothingComplete is true.
		/// </summary>
		/// <param name="deltaSeconds">Time since last update.</param>
		protected virtual void SmoothClientPosition(float deltaSeconds)
			=> E_UCharacterMovementComponent_SmoothClientPosition(this, deltaSeconds);
		
		
		/// <summary>
		/// Update interpolation values for client smoothing. Does not change actual mesh location.
		/// <para>Sets bNetworkSmoothingComplete to true when the interpolation reaches the target. </para>
		/// </summary>
		protected void SmoothClientPosition_Interpolate(float deltaSeconds)
			=> E_UCharacterMovementComponent_SmoothClientPosition_Interpolate(this, deltaSeconds);
		
		
		/// <summary>
		/// Update mesh location based on interpolated values.
		/// </summary>
		protected void SmoothClientPosition_UpdateVisuals()
			=> E_UCharacterMovementComponent_SmoothClientPosition_UpdateVisuals(this);
		
		
		/// <summary>
		/// Transition from walking to falling
		/// </summary>
		public virtual void StartFalling(int iterations, float remainingTime, float timeTick, FVector delta, FVector subLoc)
			=> E_UCharacterMovementComponent_StartFalling(this, iterations, remainingTime, timeTick, delta, subLoc);
		
		
		/// <summary>
		/// changes physics based on MovementMode
		/// </summary>
		public virtual void StartNewPhysics(float deltaTime, int iterations)
			=> E_UCharacterMovementComponent_StartNewPhysics(this, deltaTime, iterations);
		
		
		/// <summary>
		/// Handle start swimming functionality
		/// </summary>
		/// <param name="oldLocation">Location on last tick</param>
		/// <param name="oldVelocity">velocity at last tick</param>
		/// <param name="timeTick">time since at OldLocation</param>
		/// <param name="remainingTime">DeltaTime to complete transition to swimming</param>
		/// <param name="iterations">physics iteration count</param>
		public void StartSwimming(FVector oldLocation, FVector oldVelocity, float timeTick, float remainingTime, int iterations)
			=> E_UCharacterMovementComponent_StartSwimming(this, oldLocation, oldVelocity, timeTick, remainingTime, iterations);
		
		
		/// <summary>
		/// Move up steps or slope. Does nothing and returns false if CanStepUp(Hit) returns false.
		/// </summary>
		/// <param name="gravDir">Gravity vector direction (assumed normalized or zero)</param>
		/// <param name="delta">Requested move</param>
		/// <param name="hit">In] The hit before the step up.</param>
		/// <param name="outStepDownResult">Out] If non-null, a floor check will be performed if possible as part of the final step down, and it will be updated to reflect this result.</param>
		/// <return>true</return>
		public virtual bool StepUp(FVector gravDir, FVector delta, FHitResult hit)
			=> E_UCharacterMovementComponent_StepUp(this, gravDir, delta, hit);
		
		public float Swim(FVector delta, FHitResult hit)
			=> E_UCharacterMovementComponent_Swim(this, delta, hit);
		
		
		/// <summary>
		/// Ticks the characters pose and accumulates root motion
		/// </summary>
		protected void TickCharacterPose(float deltaTime)
			=> E_UCharacterMovementComponent_TickCharacterPose(this, deltaTime);
		
		
		/// <summary>
		/// Checks to see if the current location is not encroaching blocking geometry so the character can leave NavWalking.
		/// <para>Restores collision settings and adjusts character location to avoid getting stuck in geometry. </para>
		/// If it's not possible, MovementMode change will be delayed until character reach collision free spot.
		/// </summary>
		/// <return>True</return>
		protected virtual bool TryToLeaveNavWalking()
			=> E_UCharacterMovementComponent_TryToLeaveNavWalking(this);
		
		
		/// <summary>
		/// Checks if default capsule size fits (no encroachment), and trigger OnEndCrouch() on the owner if successful.
		/// </summary>
		/// <param name="bClientSimulation">true when called when bIsCrouched is replicated to non owned clients, to update collision cylinder and offset.</param>
		public virtual void UnCrouch(bool bClientSimulation)
			=> E_UCharacterMovementComponent_UnCrouch(this, bClientSimulation);
		
		
		/// <summary>
		/// Update position based on Base movement
		/// </summary>
		public virtual void UpdateBasedMovement(float deltaSeconds)
			=> E_UCharacterMovementComponent_UpdateBasedMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// Update controller's view rotation as pawn's base rotates
		/// </summary>
		public virtual void UpdateBasedRotation(FRotator finalRotation, FRotator reducedRotation)
			=> E_UCharacterMovementComponent_UpdateBasedRotation(this, finalRotation, reducedRotation);
		
		
		/// <summary>
		/// Update the character state in PerformMovement after the position change. Some rotation updates happen after this.
		/// </summary>
		public virtual void UpdateCharacterStateAfterMovement(float deltaSeconds)
			=> E_UCharacterMovementComponent_UpdateCharacterStateAfterMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// Update the character state in PerformMovement right before doing the actual position change
		/// </summary>
		public virtual void UpdateCharacterStateBeforeMovement(float deltaSeconds)
			=> E_UCharacterMovementComponent_UpdateCharacterStateBeforeMovement(this, deltaSeconds);
		
		
		/// <summary>
		/// React to instantaneous change in position. Invalidates cached floor recomputes it if possible if there is a current movement base.
		/// </summary>
		public virtual void UpdateFloorFromAdjustment()
			=> E_UCharacterMovementComponent_UpdateFloorFromAdjustment(this);
		
		
		/// <summary>
		/// Unpack compressed flags from a saved move and set state accordingly. See FSavedMove_Character.
		/// </summary>
		protected virtual void UpdateFromCompressedFlags(byte flags)
			=> E_UCharacterMovementComponent_UpdateFromCompressedFlags(this, flags);
		
		
		/// <summary>
		/// Used during SimulateMovement for proxies, this computes a new value for Acceleration before running proxy simulation.
		/// <para>The base implementation simply derives a value from the normalized Velocity value, which may help animations that want some indication of the direction of movement. </para>
		/// Proxies don't implement predictive acceleration by default so this value is not used for the actual simulation.
		/// </summary>
		public virtual void UpdateProxyAcceleration()
			=> E_UCharacterMovementComponent_UpdateProxyAcceleration(this);
		
		
		/// <summary>
		/// Draw in-world debug information for character movement (called with p.VisualizeMovement > 0).
		/// </summary>
		public virtual void VisualizeMovement()
			=> E_UCharacterMovementComponent_VisualizeMovement(this);
		
		#endregion
		
		public static implicit operator IntPtr(UCharacterMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UCharacterMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCharacterMovementComponent>(PtrDesc);
		}}}
