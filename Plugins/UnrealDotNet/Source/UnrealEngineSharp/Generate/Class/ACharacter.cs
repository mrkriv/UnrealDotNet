// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

namespace UnrealEngine
{
	public  partial class ACharacter : APawn
	{
		public ACharacter(IntPtr adress)
			: base(adress)
		{
		}

		public ACharacter(UObject Parent = null, string Name = "Character")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ACharacter(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_ACharacter_CapsuleComponentName_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_ACharacter_CharacterMovementComponentName_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_CrouchedEyeHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_CrouchedEyeHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_ACharacter_JumpCurrentCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpCurrentCount_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_JumpForceTimeRemaining_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpForceTimeRemaining_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_JumpKeyHoldTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpKeyHoldTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_ACharacter_JumpMaxCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpMaxCount_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_JumpMaxHoldTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_JumpMaxHoldTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_ACharacter_LandedDelegate(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_ACharacter_LandedDelegate(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_ACharacter_MeshComponentName_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_ACharacter_MovementModeChangedDelegate(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_ACharacter_MovementModeChangedDelegate(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_ACharacter_OnCharacterMovementUpdated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_ACharacter_OnCharacterMovementUpdated(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_ADD_ACharacter_OnReachedJumpApex(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_EVENT_DEL_ACharacter_OnReachedJumpApex(IntPtr Ptr);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_ACharacter_ProxyJumpForceStartedTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_ProxyJumpForceStartedTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_ACharacter_RepRootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_RepRootMotion_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_ACharacter_SavedRootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_SavedRootMotion_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ACharacter(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ApplyDamageMomentum(IntPtr self, float damageTaken, IntPtr damageEvent, IntPtr pawnInstigator, IntPtr damageCauser);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_BaseChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_CacheInitialMeshOffset(IntPtr self, IntPtr meshRelativeLocation, IntPtr meshRelativeRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanCrouch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanJump(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanJumpInternal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanJumpInternal_Implementation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_CheckJumpInput(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClearJumpInput(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAckGoodMove(IntPtr self, float timeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAckGoodMove_Implementation(IntPtr self, float timeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAdjustPosition(IntPtr self, float timeStamp, IntPtr newLoc, IntPtr newVel, IntPtr newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAdjustPosition_Implementation(IntPtr self, float timeStamp, IntPtr newLoc, IntPtr newVel, IntPtr newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatFly(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatFly_Implementation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatGhost(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatGhost_Implementation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatWalk(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatWalk_Implementation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientVeryShortAdjustPosition(IntPtr self, float timeStamp, IntPtr newLoc, IntPtr newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientVeryShortAdjustPosition_Implementation(IntPtr self, float timeStamp, IntPtr newLoc, IntPtr newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Crouch(IntPtr self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Falling(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetAnimRootMotionTranslationScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBasedMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseRotationOffset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseRotationOffsetRotator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseTranslationOffset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetCapsuleComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetCharacterMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetJumpMaxHoldTime(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetMesh(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetReplicatedBasedMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_ACharacter_GetReplicatedMovementMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_HasAnyRootMotion(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsJumpProvidingForce(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsPlayingNetworkedRootMotionMontage(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsPlayingRootMotion(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Jump(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_OnEndCrouch(IntPtr self, float halfHeightAdjust, float scaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_OnMovementModeChanged(IntPtr self, byte prevMovementMode, byte newMovementMode, byte prevCustomMode, byte newCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_OnStartCrouch(IntPtr self, float halfHeightAdjust, float scaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_UpdateCustomMovement(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Landed(IntPtr self, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_LaunchCharacter(IntPtr self, IntPtr launchVelocity, bool bXYOverride, bool bZOverride);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_MoveBlockedBy(IntPtr self, IntPtr impact);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyActorBeginOverlap(IntPtr self, IntPtr otherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyActorEndOverlap(IntPtr self, IntPtr otherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyJumpApex(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnEndCrouch(IntPtr self, float halfHeightAdjust, float scaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnJumped(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnJumped_Implementation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnLanded(IntPtr self, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnLaunched(IntPtr self, IntPtr launchVelocity, bool bXYOverride, bool bZOverride);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnMovementModeChanged(IntPtr self, byte prevMovementMode, byte previousCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_IsCrouched(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_ReplayLastTransformUpdateTimeStamp(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_ReplicatedBasedMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_RootMotion(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnStartCrouch(IntPtr self, float halfHeightAdjust, float scaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnUpdateSimulatedPosition(IntPtr self, IntPtr oldLocation, IntPtr oldRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnWalkingOffLedge(IntPtr self, IntPtr previousFloorImpactNormal, IntPtr previousFloorContactNormal, IntPtr previousLocation, float timeDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnWalkingOffLedge_Implementation(IntPtr self, IntPtr previousFloorImpactNormal, IntPtr previousFloorContactNormal, IntPtr previousLocation, float timeDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ResetJumpState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_RestoreReplicatedMove(IntPtr self, IntPtr rootMotionRepMove);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RootMotionDebugClientPrintOnScreen(IntPtr self, string inString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RootMotionDebugClientPrintOnScreen_Implementation(IntPtr self, string inString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SaveRelativeBasedMovement(IntPtr self, IntPtr newRelativeLocation, IntPtr newRotation, bool bRelativeRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetAnimRootMotionTranslationScale(IntPtr self, float inAnimRootMotionTranslationScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetBase(IntPtr self, IntPtr newBase, string boneName, bool bNotifyActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_ShouldNotifyLanded(IntPtr self, IntPtr hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SimulatedRootMotionPositionFixup(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_StopJumping(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_UnCrouch(IntPtr self, bool bClientSimulation);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Name of the CapsuleComponent.
		/// </summary>
		public static string CapsuleComponentName
		{
			get => E_PROP_ACharacter_CapsuleComponentName_GET();
		}

		
		/// <summary>
		/// Name of the CharacterMovement component. Use this name if you want to use a different class (with ObjectInitializer.SetDefaultSubobjectClass).
		/// </summary>
		public static string CharacterMovementComponentName
		{
			get => E_PROP_ACharacter_CharacterMovementComponentName_GET();
		}

		
		/// <summary>
		/// Default crouched eye height
		/// </summary>
		public float CrouchedEyeHeight
		{
			get => E_PROP_ACharacter_CrouchedEyeHeight_GET(NativePointer);
			set => E_PROP_ACharacter_CrouchedEyeHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Tracks the current number of jumps performed.
		/// <para>This is incremented in CheckJumpInput, used in CanJump_Implementation, and reset in OnMovementModeChanged. </para>
		/// When providing overrides for these methods, it's recommended to either manually
		/// <para>increment / reset this value, or call the Super:: method. </para>
		/// </summary>
		public int JumpCurrentCount
		{
			get => E_PROP_ACharacter_JumpCurrentCount_GET(NativePointer);
			set => E_PROP_ACharacter_JumpCurrentCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Amount of jump force time remaining, if JumpMaxHoldTime > 0.
		/// </summary>
		public float JumpForceTimeRemaining
		{
			get => E_PROP_ACharacter_JumpForceTimeRemaining_GET(NativePointer);
			set => E_PROP_ACharacter_JumpForceTimeRemaining_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Jump key Held Time.
		/// <para>This is the time that the player has held the jump key, in seconds. </para>
		/// </summary>
		public float JumpKeyHoldTime
		{
			get => E_PROP_ACharacter_JumpKeyHoldTime_GET(NativePointer);
			set => E_PROP_ACharacter_JumpKeyHoldTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The max number of jumps the character can perform.
		/// <para>Note that if JumpMaxHoldTime is non zero and StopJumping is not called, the player </para>
		/// may be able to perform and unlimited number of jumps. Therefore it is usually
		/// <para>best to call StopJumping() when jump input has ceased (such as a button up event). </para>
		/// </summary>
		public int JumpMaxCount
		{
			get => E_PROP_ACharacter_JumpMaxCount_GET(NativePointer);
			set => E_PROP_ACharacter_JumpMaxCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The max time the jump key can be held.
		/// <para>Note that if StopJumping() is not called before the max jump hold time is reached, </para>
		/// then the character will carry on receiving vertical velocity. Therefore it is usually
		/// <para>best to call StopJumping() when jump input has ceased (such as a button up event). </para>
		/// </summary>
		public float JumpMaxHoldTime
		{
			get => E_PROP_ACharacter_JumpMaxHoldTime_GET(NativePointer);
			set => E_PROP_ACharacter_JumpMaxHoldTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Name of the MeshComponent. Use this name if you want to prevent creation of the component (with ObjectInitializer.DoNotCreateDefaultSubobject).
		/// </summary>
		public static string MeshComponentName
		{
			get => E_PROP_ACharacter_MeshComponentName_GET();
		}

		
		/// <summary>
		/// Track last time a jump force started for a proxy.
		/// </summary>
		public float ProxyJumpForceStartedTime
		{
			get => E_PROP_ACharacter_ProxyJumpForceStartedTime_GET(NativePointer);
			set => E_PROP_ACharacter_ProxyJumpForceStartedTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Replicated Root Motion montage
		/// </summary>
		public FRepRootMotionMontage RepRootMotion
		{
			get => E_PROP_ACharacter_RepRootMotion_GET(NativePointer);
			set => E_PROP_ACharacter_RepRootMotion_SET(NativePointer, value);
		}

		public FRootMotionSourceGroup SavedRootMotion
		{
			get => E_PROP_ACharacter_SavedRootMotion_GET(NativePointer);
			set => E_PROP_ACharacter_SavedRootMotion_SET(NativePointer, value);
		}

		#endregion
		
		#region Events
		
		/// <summary>
		/// Called upon landing when falling, to perform actions based on the Hit result.
		/// <para>Note that movement mode is still "Falling" during this event. Current Velocity value is the velocity at the time of landing. </para>
		/// Consider OnMovementModeChanged() as well, as that can be used once the movement mode changes to the new mode (most likely Walking).
		/// <see cref="OnMovementModeChanged"/>
		/// </summary>
		/// <param name="hit">Result describing the landing that resulted in a valid landing spot.</param>
		public event FLandedSignature LandedDelegate
		{
			add
			{
				E_EVENT_ADD_ACharacter_LandedDelegate(NativePointer);
				_Event_LandedDelegate += value;
			}

			remove
			{
				E_EVENT_DEL_ACharacter_LandedDelegate(NativePointer);
				_Event_LandedDelegate -= value;
			}

		}

		private event FLandedSignature _Event_LandedDelegate;
		
		internal void InvokeEvent_LandedDelegate(FHitResult hit)
		{
			_Event_LandedDelegate?.Invoke(hit);
		}

		
		/// <summary>
		/// Multicast delegate for MovementMode changing.
		/// </summary>
		public event FMovementModeChangedSignature MovementModeChangedDelegate
		{
			add
			{
				E_EVENT_ADD_ACharacter_MovementModeChangedDelegate(NativePointer);
				_Event_MovementModeChangedDelegate += value;
			}

			remove
			{
				E_EVENT_DEL_ACharacter_MovementModeChangedDelegate(NativePointer);
				_Event_MovementModeChangedDelegate -= value;
			}

		}

		private event FMovementModeChangedSignature _Event_MovementModeChangedDelegate;
		
		internal void InvokeEvent_MovementModeChangedDelegate(ObjectPointerDescription character, EMovementMode prevMovementMode, byte previousCustomMode)
		{
			_Event_MovementModeChangedDelegate?.Invoke(character, prevMovementMode, previousCustomMode);
		}

		
		/// <summary>
		/// Event triggered at the end of a CharacterMovementComponent movement update.
		/// <para>This is the preferred event to use rather than the Tick event when performing custom updates to CharacterMovement properties based on the current state. </para>
		/// This is mainly due to the nature of network updates, where client corrections in position from the server can cause multiple iterations of a movement update,
		/// <para>which allows this event to update as well, while a Tick event would not. </para>
		/// </summary>
		/// <param name="deltaSeconds">Delta time in seconds for this update</param>
		/// <param name="initialLocation">Location at the start of the update. May be different than the current location if movement occurred.</param>
		/// <param name="initialVelocity">Velocity at the start of the update. May be different than the current velocity.</param>
		public event FCharacterMovementUpdatedSignature OnCharacterMovementUpdated
		{
			add
			{
				E_EVENT_ADD_ACharacter_OnCharacterMovementUpdated(NativePointer);
				_Event_OnCharacterMovementUpdated += value;
			}

			remove
			{
				E_EVENT_DEL_ACharacter_OnCharacterMovementUpdated(NativePointer);
				_Event_OnCharacterMovementUpdated -= value;
			}

		}

		private event FCharacterMovementUpdatedSignature _Event_OnCharacterMovementUpdated;
		
		internal void InvokeEvent_OnCharacterMovementUpdated(float deltaSeconds, FVector oldLocation, FVector oldVelocity)
		{
			_Event_OnCharacterMovementUpdated?.Invoke(deltaSeconds, oldLocation, oldVelocity);
		}

		
		/// <summary>
		/// Broadcast when Character's jump reaches its apex. Needs CharacterMovement->bNotifyApex = true
		/// </summary>
		public event FCharacterReachedApexSignature OnReachedJumpApex
		{
			add
			{
				E_EVENT_ADD_ACharacter_OnReachedJumpApex(NativePointer);
				_Event_OnReachedJumpApex += value;
			}

			remove
			{
				E_EVENT_DEL_ACharacter_OnReachedJumpApex(NativePointer);
				_Event_OnReachedJumpApex -= value;
			}

		}

		private event FCharacterReachedApexSignature _Event_OnReachedJumpApex;
		
		internal void InvokeEvent_OnReachedJumpApex()
		{
			_Event_OnReachedJumpApex?.Invoke();
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Apply momentum caused by damage.
		/// </summary>
		public virtual void ApplyDamageMomentum(float damageTaken, FDamageEvent damageEvent, APawn pawnInstigator, AActor damageCauser)
			=> E_ACharacter_ApplyDamageMomentum(this, damageTaken, damageEvent, pawnInstigator, damageCauser);
		
		
		/// <summary>
		/// Event called after actor's base changes (if SetBase was requested to notify us with bNotifyPawn).
		/// </summary>
		protected virtual void BaseChange()
			=> E_ACharacter_BaseChange(this);
		
		
		/// <summary>
		/// Cache mesh offset from capsule. This is used as the target for network smoothing interpolation, when the mesh is offset with lagged smoothing.
		/// <para>This is automatically called during initialization; call this at runtime if you intend to change the default mesh offset from the capsule. </para>
		/// <see cref="GetBaseTranslationOffset"/>
		/// </summary>
		public virtual void CacheInitialMeshOffset(FVector meshRelativeLocation, FRotator meshRelativeRotation)
			=> E_ACharacter_CacheInitialMeshOffset(this, meshRelativeLocation, meshRelativeRotation);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public virtual bool CanCrouch()
			=> E_ACharacter_CanCrouch(this);
		
		
		/// <summary>
		/// Check if the character can jump in the current state.
		/// <para>The default implementation may be overridden or extended by implementing the custom CanJump event in Blueprints. </para>
		/// @Return Whether the character can jump in the current state.
		/// </summary>
		public bool CanJump()
			=> E_ACharacter_CanJump(this);
		
		
		/// <summary>
		/// Customizable event to check if the character can jump in the current state.
		/// <para>Default implementation returns true if the character is on the ground and not crouching, </para>
		/// has a valid CharacterMovementComponent and CanEverJump() returns true.
		/// <para>Default implementation also allows for 'hold to jump higher' functionality: </para>
		/// As well as returning true when on the ground, it also returns true when GetMaxJumpTime is more
		/// <para>than zero and IsJumping returns true. </para>
		/// @Return Whether the character can jump in the current state.
		/// </summary>
		protected bool CanJumpInternal()
			=> E_ACharacter_CanJumpInternal(this);
		
		protected virtual bool CanJumpInternal_Implementation()
			=> E_ACharacter_CanJumpInternal_Implementation(this);
		
		
		/// <summary>
		/// Trigger jump if jump button has been pressed.
		/// </summary>
		public virtual void CheckJumpInput(float deltaTime)
			=> E_ACharacter_CheckJumpInput(this, deltaTime);
		
		
		/// <summary>
		/// Update jump input state after having checked input.
		/// </summary>
		public virtual void ClearJumpInput(float deltaTime)
			=> E_ACharacter_ClearJumpInput(this, deltaTime);
		
		public void ClientAckGoodMove(float timeStamp)
			=> E_ACharacter_ClientAckGoodMove(this, timeStamp);
		
		public void ClientAckGoodMove_Implementation(float timeStamp)
			=> E_ACharacter_ClientAckGoodMove_Implementation(this, timeStamp);
		
		public void ClientAdjustPosition(float timeStamp, FVector newLoc, FVector newVel, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_ACharacter_ClientAdjustPosition(this, timeStamp, newLoc, newVel, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		public void ClientAdjustPosition_Implementation(float timeStamp, FVector newLoc, FVector newVel, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_ACharacter_ClientAdjustPosition_Implementation(this, timeStamp, newLoc, newVel, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		public void ClientCheatFly()
			=> E_ACharacter_ClientCheatFly(this);
		
		public virtual void ClientCheatFly_Implementation()
			=> E_ACharacter_ClientCheatFly_Implementation(this);
		
		public void ClientCheatGhost()
			=> E_ACharacter_ClientCheatGhost(this);
		
		public virtual void ClientCheatGhost_Implementation()
			=> E_ACharacter_ClientCheatGhost_Implementation(this);
		
		public void ClientCheatWalk()
			=> E_ACharacter_ClientCheatWalk(this);
		
		public virtual void ClientCheatWalk_Implementation()
			=> E_ACharacter_ClientCheatWalk_Implementation(this);
		
		public void ClientVeryShortAdjustPosition(float timeStamp, FVector newLoc, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_ACharacter_ClientVeryShortAdjustPosition(this, timeStamp, newLoc, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		public void ClientVeryShortAdjustPosition_Implementation(float timeStamp, FVector newLoc, UPrimitiveComponent newBase, string newBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte serverMovementMode)
			=> E_ACharacter_ClientVeryShortAdjustPosition_Implementation(this, timeStamp, newLoc, newBase, newBaseBoneName, bHasBase, bBaseRelativePosition, serverMovementMode);
		
		
		/// <summary>
		/// Request the character to start crouching. The request is processed on the next update of the CharacterMovementComponent.
		/// <para>@see OnStartCrouch </para>
		/// @see IsCrouched
		/// <see cref="CharacterMovement"/>
		/// </summary>
		public virtual void Crouch(bool bClientSimulation)
			=> E_ACharacter_Crouch(this, bClientSimulation);
		
		
		/// <summary>
		/// Called when the character's movement enters falling
		/// </summary>
		public virtual void Falling()
			=> E_ACharacter_Falling(this);
		
		
		/// <summary>
		/// Returns current value of AnimRootMotionScale
		/// </summary>
		public float GetAnimRootMotionTranslationScale()
			=> E_ACharacter_GetAnimRootMotionTranslationScale(this);
		
		
		/// <summary>
		/// Accessor for BasedMovement
		/// </summary>
		public FBasedMovementInfo GetBasedMovement()
			=> E_ACharacter_GetBasedMovement(this);
		
		
		/// <summary>
		/// Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation.
		/// </summary>
		public virtual FQuat GetBaseRotationOffset()
			=> E_ACharacter_GetBaseRotationOffset(this);
		
		
		/// <summary>
		/// Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation.
		/// </summary>
		public FRotator GetBaseRotationOffsetRotator()
			=> E_ACharacter_GetBaseRotationOffsetRotator(this);
		
		
		/// <summary>
		/// Get the saved translation offset of mesh. This is how much extra offset is applied from the center of the capsule.
		/// </summary>
		public FVector GetBaseTranslationOffset()
			=> E_ACharacter_GetBaseTranslationOffset(this);
		
		
		/// <summary>
		/// Returns CapsuleComponent subobject
		/// </summary>
		public UCapsuleComponent GetCapsuleComponent()
			=> E_ACharacter_GetCapsuleComponent(this);
		
		
		/// <summary>
		/// Returns CharacterMovement subobject
		/// </summary>
		public UCharacterMovementComponent GetCharacterMovement()
			=> E_ACharacter_GetCharacterMovement(this);
		
		
		/// <summary>
		/// Get the maximum jump time for the character.
		/// <para>Note that if StopJumping() is not called before the max jump hold time is reached, </para>
		/// then the character will carry on receiving vertical velocity. Therefore it is usually
		/// <para>best to call StopJumping() when jump input has ceased (such as a button up event). </para>
		/// </summary>
		/// <return>Maximum</return>
		public virtual float GetJumpMaxHoldTime()
			=> E_ACharacter_GetJumpMaxHoldTime(this);
		
		
		/// <summary>
		/// Returns Mesh subobject
		/// </summary>
		public USkeletalMeshComponent GetMesh()
			=> E_ACharacter_GetMesh(this);
		
		
		/// <summary>
		/// Accessor for ReplicatedBasedMovement
		/// </summary>
		public FBasedMovementInfo GetReplicatedBasedMovement()
			=> E_ACharacter_GetReplicatedBasedMovement(this);
		
		
		/// <summary>
		/// Returns ReplicatedMovementMode
		/// </summary>
		public byte GetReplicatedMovementMode()
			=> E_ACharacter_GetReplicatedMovementMode(this);
		
		
		/// <summary>
		/// Accessor for ReplicatedServerLastTransformUpdateTimeStamp.
		/// </summary>
		public float GetReplicatedServerLastTransformUpdateTimeStamp()
			=> E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(this);
		
		
		/// <summary>
		/// True if we are playing root motion from any source right now (anim root motion, root motion source)
		/// </summary>
		public bool HasAnyRootMotion()
			=> E_ACharacter_HasAnyRootMotion(this);
		
		
		/// <summary>
		/// True if jump is actively providing a force, such as when the jump key is held and the time it has been held is less than JumpMaxHoldTime.
		/// <see cref="CharacterMovement"/>
		/// </summary>
		public virtual bool IsJumpProvidingForce()
			=> E_ACharacter_IsJumpProvidingForce(this);
		
		
		/// <summary>
		/// True if we are playing Root Motion right now, through a Montage with RootMotionMode == ERootMotionMode::RootMotionFromMontagesOnly.
		/// <para>This means code path for networked root motion is enabled. </para>
		/// </summary>
		public bool IsPlayingNetworkedRootMotionMontage()
			=> E_ACharacter_IsPlayingNetworkedRootMotionMontage(this);
		
		
		/// <summary>
		/// True if we are playing Anim root motion right now
		/// </summary>
		public bool IsPlayingAnimRootMotion()
			=> E_ACharacter_IsPlayingRootMotion(this);
		
		
		/// <summary>
		/// Make the character jump on the next update.
		/// <para>If you want your character to jump according to the time that the jump key is held, </para>
		/// then you can set JumpKeyHoldTime to some non-zero value. Make sure in this case to
		/// <para>call StopJumping() when you want the jump's z-velocity to stop being applied (such </para>
		/// as on a button up event), otherwise the character will carry on receiving the
		/// <para>velocity until JumpKeyHoldTime is reached. </para>
		/// </summary>
		public virtual void Jump()
			=> E_ACharacter_Jump(this);
		
		
		/// <summary>
		/// Event when Character stops crouching.
		/// </summary>
		/// <param name="halfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height.</param>
		/// <param name="scaledHalfHeightAdjust">difference after component scale is taken in to account.</param>
		public void K2_OnEndCrouch(float halfHeightAdjust, float scaledHalfHeightAdjust)
			=> E_ACharacter_K2_OnEndCrouch(this, halfHeightAdjust, scaledHalfHeightAdjust);
		
		
		/// <summary>
		/// Called from CharacterMovementComponent to notify the character that the movement mode has changed.
		/// </summary>
		/// <param name="prevMovementMode">Movement mode before the change</param>
		/// <param name="newMovementMode">New movement mode</param>
		/// <param name="prevCustomMode">Custom mode before the change (applicable if PrevMovementMode is Custom)</param>
		/// <param name="newCustomMode">New custom mode (applicable if NewMovementMode is Custom)</param>
		public void K2_OnMovementModeChanged(EMovementMode prevMovementMode, EMovementMode newMovementMode, byte prevCustomMode, byte newCustomMode)
			=> E_ACharacter_K2_OnMovementModeChanged(this, (byte)prevMovementMode, (byte)newMovementMode, prevCustomMode, newCustomMode);
		
		
		/// <summary>
		/// Event when Character crouches.
		/// </summary>
		/// <param name="halfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height.</param>
		/// <param name="scaledHalfHeightAdjust">difference after component scale is taken in to account.</param>
		public void K2_OnStartCrouch(float halfHeightAdjust, float scaledHalfHeightAdjust)
			=> E_ACharacter_K2_OnStartCrouch(this, halfHeightAdjust, scaledHalfHeightAdjust);
		
		
		/// <summary>
		/// Event for implementing custom character movement mode. Called by CharacterMovement if MovementMode is set to Custom.
		/// <para>@note C++ code should override UCharacterMovementComponent::PhysCustom() instead. </para>
		/// <see cref="UCharacterMovementComponent"/>
		/// </summary>
		public void UpdateCustomMovement(float deltaTime)
			=> E_ACharacter_K2_UpdateCustomMovement(this, deltaTime);
		
		
		/// <summary>
		/// Called upon landing when falling, to perform actions based on the Hit result. Triggers the OnLanded event.
		/// <para>Note that movement mode is still "Falling" during this event. Current Velocity value is the velocity at the time of landing. </para>
		/// Consider OnMovementModeChanged() as well, as that can be used once the movement mode changes to the new mode (most likely Walking).
		/// <see cref="OnMovementModeChanged"/>
		/// </summary>
		/// <param name="hit">Result describing the landing that resulted in a valid landing spot.</param>
		public virtual void Landed(FHitResult hit)
			=> E_ACharacter_Landed(this, hit);
		
		
		/// <summary>
		/// Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick,
		/// <para>and will set it to the "falling" state. Triggers the OnLaunched event. </para>
		/// @PARAM LaunchVelocity is the velocity to impart to the Character
		/// <para>@PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it. </para>
		/// @PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it.
		/// </summary>
		public virtual void LaunchCharacter(FVector launchVelocity, bool bXYOverride, bool bZOverride)
			=> E_ACharacter_LaunchCharacter(this, launchVelocity, bXYOverride, bZOverride);
		
		
		/// <summary>
		/// Called when pawn's movement is blocked
		/// </summary>
		/// <param name="impact">describes the blocking hit.</param>
		public virtual void MoveBlockedBy(FHitResult impact)
			=> E_ACharacter_MoveBlockedBy(this, impact);
		
		public virtual void NotifyActorBeginOverlap(AActor otherActor)
			=> E_ACharacter_NotifyActorBeginOverlap(this, otherActor);
		
		public virtual void NotifyActorEndOverlap(AActor otherActor)
			=> E_ACharacter_NotifyActorEndOverlap(this, otherActor);
		
		
		/// <summary>
		/// Called when character's jump reaches Apex. Needs CharacterMovement->bNotifyApex = true
		/// </summary>
		public virtual void NotifyJumpApex()
			=> E_ACharacter_NotifyJumpApex(this);
		
		
		/// <summary>
		/// Called when Character stops crouching. Called on non-owned Characters through bIsCrouched replication.
		/// </summary>
		/// <param name="halfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height.</param>
		/// <param name="scaledHalfHeightAdjust">difference after component scale is taken in to account.</param>
		public virtual void OnEndCrouch(float halfHeightAdjust, float scaledHalfHeightAdjust)
			=> E_ACharacter_OnEndCrouch(this, halfHeightAdjust, scaledHalfHeightAdjust);
		
		
		/// <summary>
		/// Event fired when the character has just started jumping
		/// </summary>
		public void OnJumped()
			=> E_ACharacter_OnJumped(this);
		
		public virtual void OnJumped_Implementation()
			=> E_ACharacter_OnJumped_Implementation(this);
		
		public void OnLanded(FHitResult hit)
			=> E_ACharacter_OnLanded(this, hit);
		
		public void OnLaunched(FVector launchVelocity, bool bXYOverride, bool bZOverride)
			=> E_ACharacter_OnLaunched(this, launchVelocity, bXYOverride, bZOverride);
		
		
		/// <summary>
		/// Called from CharacterMovementComponent to notify the character that the movement mode has changed.
		/// </summary>
		/// <param name="prevMovementMode">Movement mode before the change</param>
		/// <param name="prevCustomMode">Custom mode before the change (applicable if PrevMovementMode is Custom)</param>
		public virtual void OnMovementModeChanged(EMovementMode prevMovementMode, byte previousCustomMode)
			=> E_ACharacter_OnMovementModeChanged(this, (byte)prevMovementMode, previousCustomMode);
		
		public virtual void OnRep_IsCrouched()
			=> E_ACharacter_OnRep_IsCrouched(this);
		
		public void OnRep_ReplayLastTransformUpdateTimeStamp()
			=> E_ACharacter_OnRep_ReplayLastTransformUpdateTimeStamp(this);
		
		public virtual void OnRep_ReplicatedBasedMovement()
			=> E_ACharacter_OnRep_ReplicatedBasedMovement(this);
		
		public void OnRep_RootMotion()
			=> E_ACharacter_OnRep_RootMotion(this);
		
		
		/// <summary>
		/// Called when Character crouches. Called on non-owned Characters through bIsCrouched replication.
		/// </summary>
		/// <param name="halfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height.</param>
		/// <param name="scaledHalfHeightAdjust">difference after component scale is taken in to account.</param>
		public virtual void OnStartCrouch(float halfHeightAdjust, float scaledHalfHeightAdjust)
			=> E_ACharacter_OnStartCrouch(this, halfHeightAdjust, scaledHalfHeightAdjust);
		
		
		/// <summary>
		/// Called on client after position update is received to respond to the new location and rotation.
		/// <para>Actual change in location is expected to occur in CharacterMovement->SmoothCorrection(), after which this occurs. </para>
		/// Default behavior is to check for penetration in a blocking object if bClientCheckEncroachmentOnNetUpdate is enabled, and set bSimGravityDisabled=true if so.
		/// </summary>
		public virtual void OnUpdateSimulatedPosition(FVector oldLocation, FQuat oldRotation)
			=> E_ACharacter_OnUpdateSimulatedPosition(this, oldLocation, oldRotation);
		
		
		/// <summary>
		/// Event fired when the Character is walking off a surface and is about to fall because CharacterMovement->CurrentFloor became unwalkable.
		/// <para>If CharacterMovement->MovementMode does not change during this event then the character will automatically start falling afterwards. </para>
		/// @note Z velocity is zero during walking movement, and will be here as well. Another velocity can be computed here if desired and will be used when starting to fall.
		/// </summary>
		/// <param name="previousFloorImpactNormal">Normal of the previous walkable floor.</param>
		/// <param name="previousFloorContactNormal">Normal of the contact with the previous walkable floor.</param>
		/// <param name="previousLocation">Previous character location before movement off the ledge.</param>
		/// <param name="timeTick">Time delta of movement update resulting in moving off the ledge.</param>
		public void OnWalkingOffLedge(FVector previousFloorImpactNormal, FVector previousFloorContactNormal, FVector previousLocation, float timeDelta)
			=> E_ACharacter_OnWalkingOffLedge(this, previousFloorImpactNormal, previousFloorContactNormal, previousLocation, timeDelta);
		
		public virtual void OnWalkingOffLedge_Implementation(FVector previousFloorImpactNormal, FVector previousFloorContactNormal, FVector previousLocation, float timeDelta)
			=> E_ACharacter_OnWalkingOffLedge_Implementation(this, previousFloorImpactNormal, previousFloorContactNormal, previousLocation, timeDelta);
		
		
		/// <summary>
		/// Marks character as not trying to jump
		/// </summary>
		public virtual void ResetJumpState()
			=> E_ACharacter_ResetJumpState(this);
		
		
		/// <summary>
		/// Restore actor to an old buffered move.
		/// </summary>
		public bool RestoreReplicatedMove(FSimulatedRootMotionReplicatedMove rootMotionRepMove)
			=> E_ACharacter_RestoreReplicatedMove(this, rootMotionRepMove);
		
		public void RootMotionDebugClientPrintOnScreen(string inString)
			=> E_ACharacter_RootMotionDebugClientPrintOnScreen(this, inString);
		
		public virtual void RootMotionDebugClientPrintOnScreen_Implementation(string inString)
			=> E_ACharacter_RootMotionDebugClientPrintOnScreen_Implementation(this, inString);
		
		
		/// <summary>
		/// Save a new relative location in BasedMovement and a new rotation with is either relative or absolute.
		/// </summary>
		public void SaveRelativeBasedMovement(FVector newRelativeLocation, FRotator newRotation, bool bRelativeRotation)
			=> E_ACharacter_SaveRelativeBasedMovement(this, newRelativeLocation, newRotation, bRelativeRotation);
		
		
		/// <summary>
		/// Sets scale to apply to root motion translation on this Character
		/// </summary>
		public void SetAnimRootMotionTranslationScale(float inAnimRootMotionTranslationScale)
			=> E_ACharacter_SetAnimRootMotionTranslationScale(this, inAnimRootMotionTranslationScale);
		
		
		/// <summary>
		/// Sets the component the Character is walking on, used by CharacterMovement walking movement to be able to follow dynamic objects.
		/// </summary>
		public virtual void SetBase(UPrimitiveComponent newBase, string boneName, bool bNotifyActor)
			=> E_ACharacter_SetBase(this, newBase, boneName, bNotifyActor);
		
		
		/// <summary>
		/// Returns true if the Landed() event should be called. Used by CharacterMovement to prevent notifications while playing back network moves.
		/// </summary>
		public virtual bool ShouldNotifyLanded(FHitResult hit)
			=> E_ACharacter_ShouldNotifyLanded(this, hit);
		
		
		/// <summary>
		/// Position fix up for Simulated Proxies playing Root Motion
		/// </summary>
		public void SimulatedRootMotionPositionFixup(float deltaSeconds)
			=> E_ACharacter_SimulatedRootMotionPositionFixup(this, deltaSeconds);
		
		
		/// <summary>
		/// Stop the character from jumping on the next update.
		/// <para>Call this from an input event (such as a button 'up' event) to cease applying </para>
		/// jump Z-velocity. If this is not called, then jump z-velocity will be applied
		/// <para>until JumpMaxHoldTime is reached. </para>
		/// </summary>
		public virtual void StopJumping()
			=> E_ACharacter_StopJumping(this);
		
		
		/// <summary>
		/// Request the character to stop crouching. The request is processed on the next update of the CharacterMovementComponent.
		/// <para>@see OnEndCrouch </para>
		/// @see IsCrouched
		/// <see cref="CharacterMovement"/>
		/// </summary>
		public virtual void UnCrouch(bool bClientSimulation)
			=> E_ACharacter_UnCrouch(this, bClientSimulation);
		
		#endregion
		
		public static implicit operator IntPtr(ACharacter self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ACharacter(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ACharacter>(PtrDesc);
		}}}
