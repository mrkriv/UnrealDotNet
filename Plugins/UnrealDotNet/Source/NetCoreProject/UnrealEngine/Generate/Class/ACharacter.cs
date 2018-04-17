using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\Character.h:210

namespace UnrealEngine
{
	public  partial class ACharacter : APawn
	{
		public ACharacter(IntPtr Adress)
			: base(Adress)
		{
		}

		public ACharacter(UObject Parent = null, string Name = "Character")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ACharacter(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ACharacter(IntPtr Parent, string Name);
		
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
		private static extern IntPtr E_PROP_ACharacter_RepRootMotion_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_ACharacter_RepRootMotion_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ApplyDamageMomentum(IntPtr Self, float DamageTaken, IntPtr DamageEvent, IntPtr PawnInstigator, IntPtr DamageCauser);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_BaseChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_CacheInitialMeshOffset(IntPtr Self, IntPtr MeshRelativeLocation, IntPtr MeshRelativeRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanCrouch(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanJump(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanJumpInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanJumpInternal_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_CheckJumpInput(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClearCrossLevelReferences(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClearJumpInput(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAckGoodMove(IntPtr Self, float TimeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAckGoodMove_Implementation(IntPtr Self, float TimeStamp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAdjustPosition(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewVel, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientAdjustPosition_Implementation(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewVel, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatFly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatFly_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatGhost(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatGhost_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatWalk(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientCheatWalk_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientVeryShortAdjustPosition(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ClientVeryShortAdjustPosition_Implementation(IntPtr Self, float TimeStamp, IntPtr NewLoc, IntPtr NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Crouch(IntPtr Self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Falling(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetAnimRootMotionTranslationScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseRotationOffset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseRotationOffsetRotator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseTranslationOffset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetCapsuleComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetCharacterMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetDefaultHalfHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetJumpMaxHoldTime(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetMesh(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetMovementBase(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetMovementComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetNavAgentLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_ACharacter_GetReplicatedMovementMode(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_GetSimpleCollisionCylinder(IntPtr Self, float CollisionRadius, float CollisionHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsJumpProvidingForce(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsPlayingNetworkedRootMotionMontage(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsPlayingRootMotion(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Jump(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_OnEndCrouch(IntPtr Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_OnMovementModeChanged(IntPtr Self, byte PrevMovementMode, byte NewMovementMode, byte PrevCustomMode, byte NewCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_OnStartCrouch(IntPtr Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_UpdateCustomMovement(IntPtr Self, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Landed(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_LaunchCharacter(IntPtr Self, IntPtr LaunchVelocity, bool bXYOverride, bool bZOverride);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_MoveBlockedBy(IntPtr Self, IntPtr Impact);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyJumpApex(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnEndCrouch(IntPtr Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnJumped(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnJumped_Implementation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnLanded(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnLaunched(IntPtr Self, IntPtr LaunchVelocity, bool bXYOverride, bool bZOverride);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnMovementModeChanged(IntPtr Self, byte PrevMovementMode, byte PreviousCustomMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_IsCrouched(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_ReplicatedBasedMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_ReplicatedMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_RootMotion(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnStartCrouch(IntPtr Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnUpdateSimulatedPosition(IntPtr Self, IntPtr OldLocation, IntPtr OldRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnWalkingOffLedge(IntPtr Self, IntPtr PreviousFloorImpactNormal, IntPtr PreviousFloorContactNormal, IntPtr PreviousLocation, float TimeDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnWalkingOffLedge_Implementation(IntPtr Self, IntPtr PreviousFloorImpactNormal, IntPtr PreviousFloorContactNormal, IntPtr PreviousLocation, float TimeDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PawnClientRestart(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostInitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostNetReceiveLocationAndRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RecalculateBaseEyeHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ResetJumpState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Restart(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_RestoreReplicatedMove(IntPtr Self, IntPtr RootMotionRepMove);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RootMotionDebugClientPrintOnScreen(IntPtr Self, string InString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RootMotionDebugClientPrintOnScreen_Implementation(IntPtr Self, string InString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SaveRelativeBasedMovement(IntPtr Self, IntPtr NewRelativeLocation, IntPtr NewRotation, bool bRelativeRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetAnimRootMotionTranslationScale(IntPtr Self, float InAnimRootMotionTranslationScale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetBase(IntPtr Self, IntPtr NewBase, string BoneName, bool bNotifyActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetReplicateMovement(IntPtr Self, bool bInReplicateMovement);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_ShouldNotifyLanded(IntPtr Self, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SimulatedRootMotionPositionFixup(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_StopJumping(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_TornOff(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_TurnOff(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_UnCrouch(IntPtr Self, bool bClientSimulation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_UnPossessed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_UpdateNavigationRelevance(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_AddControllerPitchInput(IntPtr Self, float Val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_AddControllerRollInput(IntPtr Self, float Val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_AddControllerYawInput(IntPtr Self, float Val);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_AddMovementInput(IntPtr Self, IntPtr WorldDirection, float ScaleValue, bool bForce);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanBeBaseForCharacter(IntPtr Self, IntPtr APawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_ConsumeMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Destroyed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_DestroyPlayerInputComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_DetachFromControllerPendingDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_FaceRotation(IntPtr Self, IntPtr NewControlRotation, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_GetActorEyesViewPoint(IntPtr Self, IntPtr Location, IntPtr Rotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetBaseAimRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_ACharacter_GetHumanReadableName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_GetMoveGoalReachTest(IntPtr Self, IntPtr MovingActor, IntPtr MoveOffset, IntPtr GoalOffset, float GoalRadius, float GoalHalfHeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetNetOwningPlayer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetPawnNoiseEmitterComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetPawnViewLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetVelocity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetViewRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_InFreeCam(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsBasedOnActor(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsLocallyControlled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsMoveInputIgnored(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsNetRelevantFor(IntPtr Self, IntPtr RealViewer, IntPtr ViewTarget, IntPtr SrcLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsPlayerControlled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_Controller(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_PlayerState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OutsideWorldBounds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PawnStartFire(IntPtr Self, byte FireModeNum);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostNetReceiveVelocity(IntPtr Self, IntPtr NewVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostRegisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PreInitializeComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_ReachedDesiredRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Reset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetPlayerDefaults(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_ShouldTickIfViewportsOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SpawnDefaultController(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_TeleportSucceeded(IntPtr Self, bool bIsATest);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_AddTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_AddTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ApplyWorldOffset(IntPtr Self, IntPtr InOffset, bool bWorldShift);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_CalculateComponentsBoundingBoxInLocalSpace(IntPtr Self, bool bNonColliding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CheckStillInWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_DestroyNetworkActorHandled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ForceNetRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ForceNetUpdate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_GatherCurrentMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetComponentsBoundingBox(IntPtr Self, bool bNonColliding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_GetComponentsBoundingCylinder(IntPtr Self, float CollisionRadius, float CollisionHalfHeight, bool bNonColliding);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_ACharacter_GetComponentsCollisionResponseToChannel(IntPtr Self, byte Channel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetDefaultAttachComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetLastRenderTime(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_ACharacter_GetLifeSpan(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_ACharacter_GetTargetLocation(IntPtr Self, IntPtr RequestedBy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_ACharacter_GetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_HasActiveCameraComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_HasActivePawnControlCameraComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_HasNetOwner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_InvalidateLightingCacheDetailed(IntPtr Self, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsAttachedTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsComponentRelevantForNavigation(IntPtr Self, IntPtr Component);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsLevelBoundsRelevant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsRelevancyOwnerFor(IntPtr Self, IntPtr ReplicatedActor, IntPtr ActorOwner, IntPtr ConnectionActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsReplayRelevantFor(IntPtr Self, IntPtr RealViewer, IntPtr ViewTarget, IntPtr SrcLocation, float CullDistanceSquared);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsRootComponentCollisionRegistered(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_K2_DestroyActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_LifeSpanExpired(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_MarkComponentsAsPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyActorBeginCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyActorBeginOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyActorEndCursorOver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyActorEndOverlap(IntPtr Self, IntPtr OtherActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyHit(IntPtr Self, IntPtr MyComp, IntPtr Other, IntPtr OtherComp, bool bSelfMoved, IntPtr HitLocation, IntPtr HitNormal, IntPtr NormalImpulse, IntPtr Hit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnConstruction(IntPtr Self, IntPtr Transform);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_AttachmentReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_Instigator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_Owner(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnRep_ReplicateMovement(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnReplicationPausedChanged(IntPtr Self, bool bIsReplicationPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnSubobjectCreatedFromReplication(IntPtr Self, IntPtr NewSubobject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnSubobjectDestroyFromReplication(IntPtr Self, IntPtr Subobject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostActorCreated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostNetInit(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostNetReceivePhysicState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostUnregisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PrestreamTextures(IntPtr Self, float Seconds, bool bEnableStreaming, int CinematicTextureGroups);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RegisterActorTickFunctions(IntPtr Self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RegisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RemoveTickPrerequisiteActor(IntPtr Self, IntPtr PrerequisiteActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RemoveTickPrerequisiteComponent(IntPtr Self, IntPtr PrerequisiteComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ReregisterAllComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_RerunConstructionScripts(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetActorHiddenInGame(IntPtr Self, bool bNewHidden);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetLifeSpan(IntPtr Self, float InLifespan);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_SetOwner(IntPtr Self, IntPtr NewOwner);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_TearOff(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_TeleportTo(IntPtr Self, IntPtr DestLocation, IntPtr DestRotation, bool bIsATest, bool bNoCheck);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_Tick(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_TickActor(IntPtr Self, float DeltaTime, byte TickType, IntPtr ThisTickFunction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_UnregisterAllComponents(IntPtr Self, bool bForReregister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_UseShortConnectTimeout(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_ACharacter_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_ACharacter_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_ACharacter_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_ACharacter_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Name of the CapsuleComponent. </para>
		/// </summary>
		public static string CapsuleComponentName
		{
			get => E_PROP_ACharacter_CapsuleComponentName_GET();
		}

		
		/// <summary>
		/// <para>Name of the CharacterMovement component. Use this name if you want to use a different class (with ObjectInitializer.SetDefaultSubobjectClass). </para>
		/// </summary>
		public static string CharacterMovementComponentName
		{
			get => E_PROP_ACharacter_CharacterMovementComponentName_GET();
		}

		
		/// <summary>
		/// <para>Default crouched eye height </para>
		/// </summary>
		public float CrouchedEyeHeight
		{
			get => E_PROP_ACharacter_CrouchedEyeHeight_GET(NativePointer);
			set => E_PROP_ACharacter_CrouchedEyeHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Tracks the current number of jumps performed. </para>
		/// <para>This is incremented in CheckJumpInput, used in CanJump_Implementation, and reset in OnMovementModeChanged. </para>
		/// <para>When providing overrides for these methods, it's recommended to either manually </para>
		/// <para>increment / reset this value, or call the Super:: method. </para>
		/// </summary>
		public int JumpCurrentCount
		{
			get => E_PROP_ACharacter_JumpCurrentCount_GET(NativePointer);
			set => E_PROP_ACharacter_JumpCurrentCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Jump key Held Time. </para>
		/// <para>This is the time that the player has held the jump key, in seconds. </para>
		/// </summary>
		public float JumpKeyHoldTime
		{
			get => E_PROP_ACharacter_JumpKeyHoldTime_GET(NativePointer);
			set => E_PROP_ACharacter_JumpKeyHoldTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The max number of jumps the character can perform. </para>
		/// <para>Note that if JumpMaxHoldTime is non zero and StopJumping is not called, the player </para>
		/// <para>may be able to perform and unlimited number of jumps. Therefore it is usually </para>
		/// <para>best to call StopJumping() when jump input has ceased (such as a button up event). </para>
		/// </summary>
		public int JumpMaxCount
		{
			get => E_PROP_ACharacter_JumpMaxCount_GET(NativePointer);
			set => E_PROP_ACharacter_JumpMaxCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The max time the jump key can be held. </para>
		/// <para>Note that if StopJumping() is not called before the max jump hold time is reached, </para>
		/// <para>then the character will carry on receiving vertical velocity. Therefore it is usually </para>
		/// <para>best to call StopJumping() when jump input has ceased (such as a button up event). </para>
		/// </summary>
		public float JumpMaxHoldTime
		{
			get => E_PROP_ACharacter_JumpMaxHoldTime_GET(NativePointer);
			set => E_PROP_ACharacter_JumpMaxHoldTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Name of the MeshComponent. Use this name if you want to prevent creation of the component (with ObjectInitializer.DoNotCreateDefaultSubobject). </para>
		/// </summary>
		public static string MeshComponentName
		{
			get => E_PROP_ACharacter_MeshComponentName_GET();
		}

		
		/// <summary>
		/// <para>Replicated Root Motion montage </para>
		/// </summary>
		public FRepRootMotionMontage RepRootMotion
		{
			get => E_PROP_ACharacter_RepRootMotion_GET(NativePointer);
			set => E_PROP_ACharacter_RepRootMotion_SET(NativePointer, value);
		}

		#endregion
		
		#region Events
		
		/// <summary>
		/// <para>Called upon landing when falling, to perform actions based on the Hit result. </para>
		/// <para>Note that movement mode is still "Falling" during this event. Current Velocity value is the velocity at the time of landing. </para>
		/// <para>Consider OnMovementModeChanged() as well, as that can be used once the movement mode changes to the new mode (most likely Walking). </para>
		/// <param name="Hit">Result describing the landing that resulted in a valid landing spot. </param>
		/// <para>@see OnMovementModeChanged() </para>
		/// </summary>
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
		
		internal void InvokeEvent_LandedDelegate(FHitResult Hit)
		{
			_Event_LandedDelegate?.Invoke(Hit);
		}

		
		/// <summary>
		/// <para>Multicast delegate for MovementMode changing. </para>
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
		
		internal void InvokeEvent_MovementModeChangedDelegate(ObjectPointerDescription Character, EMovementMode PrevMovementMode, byte PreviousCustomMode)
		{
			_Event_MovementModeChangedDelegate?.Invoke(Character, PrevMovementMode, PreviousCustomMode);
		}

		
		/// <summary>
		/// <para>Event triggered at the end of a CharacterMovementComponent movement update. </para>
		/// <para>This is the preferred event to use rather than the Tick event when performing custom updates to CharacterMovement properties based on the current state. </para>
		/// <para>This is mainly due to the nature of network updates, where client corrections in position from the server can cause multiple iterations of a movement update, </para>
		/// <para>which allows this event to update as well, while a Tick event would not. </para>
		/// <param name="DeltaSeconds">Delta time in seconds for this update </param>
		/// <param name="InitialLocation">Location at the start of the update. May be different than the current location if movement occurred. </param>
		/// <param name="InitialVelocity">Velocity at the start of the update. May be different than the current velocity. </param>
		/// </summary>
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
		
		internal void InvokeEvent_OnCharacterMovementUpdated(float DeltaSeconds, FVector OldLocation, FVector OldVelocity)
		{
			_Event_OnCharacterMovementUpdated?.Invoke(DeltaSeconds, OldLocation, OldVelocity);
		}

		
		/// <summary>
		/// <para>Broadcast when Character's jump reaches its apex. Needs CharacterMovement->bNotifyApex = true </para>
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
		/// <para>Apply momentum caused by damage. </para>
		/// </summary>
		public virtual void ApplyDamageMomentum(float DamageTaken, FDamageEvent DamageEvent, APawn PawnInstigator, AActor DamageCauser)
			=> E_ACharacter_ApplyDamageMomentum(this, DamageTaken, DamageEvent, PawnInstigator, DamageCauser);
		
		
		/// <summary>
		/// <para>Event called after actor's base changes (if SetBase was requested to notify us with bNotifyPawn). </para>
		/// </summary>
		protected virtual void BaseChange()
			=> E_ACharacter_BaseChange(this);
		
		public override void BeginPlay()
			=> E_ACharacter_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Cache mesh offset from capsule. This is used as the target for network smoothing interpolation, when the mesh is offset with lagged smoothing. </para>
		/// <para>This is automatically called during initialization; call this at runtime if you intend to change the default mesh offset from the capsule. </para>
		/// <para>@see GetBaseTranslationOffset(), GetBaseRotationOffset() </para>
		/// </summary>
		public virtual void CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
			=> E_ACharacter_CacheInitialMeshOffset(this, MeshRelativeLocation, MeshRelativeRotation);
		
		
		/// <summary>
		/// <return>true if this character is currently able to crouch (and is not currently crouched) </return>
		/// </summary>
		public virtual bool CanCrouch()
			=> E_ACharacter_CanCrouch(this);
		
		
		/// <summary>
		/// <para>Check if the character can jump in the current state. </para>
		/// <para>The default implementation may be overridden or extended by implementing the custom CanJump event in Blueprints. </para>
		/// <para>@Return Whether the character can jump in the current state. </para>
		/// </summary>
		public bool CanJump()
			=> E_ACharacter_CanJump(this);
		
		
		/// <summary>
		/// <para>Customizable event to check if the character can jump in the current state. </para>
		/// <para>Default implementation returns true if the character is on the ground and not crouching, </para>
		/// <para>has a valid CharacterMovementComponent and CanEverJump() returns true. </para>
		/// <para>Default implementation also allows for 'hold to jump higher' functionality: </para>
		/// <para>As well as returning true when on the ground, it also returns true when GetMaxJumpTime is more </para>
		/// <para>than zero and IsJumping returns true. </para>
		/// <para>@Return Whether the character can jump in the current state. </para>
		/// </summary>
		protected bool CanJumpInternal()
			=> E_ACharacter_CanJumpInternal(this);
		
		protected virtual bool CanJumpInternal_Implementation()
			=> E_ACharacter_CanJumpInternal_Implementation(this);
		
		
		/// <summary>
		/// <para>Trigger jump if jump button has been pressed. </para>
		/// </summary>
		public virtual void CheckJumpInput(float DeltaTime)
			=> E_ACharacter_CheckJumpInput(this, DeltaTime);
		
		public override void ClearCrossLevelReferences()
			=> E_ACharacter_ClearCrossLevelReferences(this);
		
		
		/// <summary>
		/// <para>Reset jump input state after having checked input. </para>
		/// </summary>
		public virtual void ClearJumpInput()
			=> E_ACharacter_ClearJumpInput(this);
		
		public void ClientAckGoodMove(float TimeStamp)
			=> E_ACharacter_ClientAckGoodMove(this, TimeStamp);
		
		public void ClientAckGoodMove_Implementation(float TimeStamp)
			=> E_ACharacter_ClientAckGoodMove_Implementation(this, TimeStamp);
		
		public void ClientAdjustPosition(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_ACharacter_ClientAdjustPosition(this, TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		public void ClientAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, FVector NewVel, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_ACharacter_ClientAdjustPosition_Implementation(this, TimeStamp, NewLoc, NewVel, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
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
		
		public void ClientVeryShortAdjustPosition(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_ACharacter_ClientVeryShortAdjustPosition(this, TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		public void ClientVeryShortAdjustPosition_Implementation(float TimeStamp, FVector NewLoc, UPrimitiveComponent NewBase, string NewBaseBoneName, bool bHasBase, bool bBaseRelativePosition, byte ServerMovementMode)
			=> E_ACharacter_ClientVeryShortAdjustPosition_Implementation(this, TimeStamp, NewLoc, NewBase, NewBaseBoneName, bHasBase, bBaseRelativePosition, ServerMovementMode);
		
		
		/// <summary>
		/// <para>Request the character to start crouching. The request is processed on the next update of the CharacterMovementComponent. </para>
		/// <para>@see OnStartCrouch </para>
		/// <para>@see IsCrouched </para>
		/// <para>@see CharacterMovement->WantsToCrouch </para>
		/// </summary>
		public virtual void Crouch(bool bClientSimulation)
			=> E_ACharacter_Crouch(this, bClientSimulation);
		
		
		/// <summary>
		/// <para>Called when the character's movement enters falling </para>
		/// </summary>
		public virtual void Falling()
			=> E_ACharacter_Falling(this);
		
		
		/// <summary>
		/// <para>Returns current value of AnimRootMotionScale </para>
		/// </summary>
		public float GetAnimRootMotionTranslationScale()
			=> E_ACharacter_GetAnimRootMotionTranslationScale(this);
		
		
		/// <summary>
		/// <para>Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation. </para>
		/// </summary>
		public virtual FQuat GetBaseRotationOffset()
			=> E_ACharacter_GetBaseRotationOffset(this);
		
		
		/// <summary>
		/// <para>Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation. </para>
		/// </summary>
		public FRotator GetBaseRotationOffsetRotator()
			=> E_ACharacter_GetBaseRotationOffsetRotator(this);
		
		
		/// <summary>
		/// <para>Get the saved translation offset of mesh. This is how much extra offset is applied from the center of the capsule. </para>
		/// </summary>
		public FVector GetBaseTranslationOffset()
			=> E_ACharacter_GetBaseTranslationOffset(this);
		
		
		/// <summary>
		/// <para>Returns CapsuleComponent subobject </para>
		/// </summary>
		public UCapsuleComponent GetCapsuleComponent()
			=> E_ACharacter_GetCapsuleComponent(this);
		
		
		/// <summary>
		/// <para>Returns CharacterMovement subobject </para>
		/// </summary>
		public UCharacterMovementComponent GetCharacterMovement()
			=> E_ACharacter_GetCharacterMovement(this);
		
		public override float GetDefaultHalfHeight()
			=> E_ACharacter_GetDefaultHalfHeight(this);
		
		
		/// <summary>
		/// <para>Get the maximum jump time for the character. </para>
		/// <para>Note that if StopJumping() is not called before the max jump hold time is reached, </para>
		/// <para>then the character will carry on receiving vertical velocity. Therefore it is usually </para>
		/// <para>best to call StopJumping() when jump input has ceased (such as a button up event). </para>
		/// <return>Maximum jump time for the character </return>
		/// </summary>
		public virtual float GetJumpMaxHoldTime()
			=> E_ACharacter_GetJumpMaxHoldTime(this);
		
		
		/// <summary>
		/// <para>Returns Mesh subobject </para>
		/// </summary>
		public USkeletalMeshComponent GetMesh()
			=> E_ACharacter_GetMesh(this);
		
		public override UPrimitiveComponent GetMovementBase()
			=> E_ACharacter_GetMovementBase(this);
		
		public override UPawnMovementComponent GetMovementComponent()
			=> E_ACharacter_GetMovementComponent(this);
		
		public override FVector GetNavAgentLocation()
			=> E_ACharacter_GetNavAgentLocation(this);
		
		
		/// <summary>
		/// <para>Returns ReplicatedMovementMode </para>
		/// </summary>
		public byte GetReplicatedMovementMode()
			=> E_ACharacter_GetReplicatedMovementMode(this);
		
		
		/// <summary>
		/// <para>Accessor for ReplicatedServerLastTransformUpdateTimeStamp. </para>
		/// </summary>
		public float GetReplicatedServerLastTransformUpdateTimeStamp()
			=> E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(this);
		
		public override void GetSimpleCollisionCylinder(float CollisionRadius, float CollisionHalfHeight)
			=> E_ACharacter_GetSimpleCollisionCylinder(this, CollisionRadius, CollisionHalfHeight);
		
		
		/// <summary>
		/// <para>True if jump is actively providing a force, such as when the jump key is held and the time it has been held is less than JumpMaxHoldTime. </para>
		/// <para>@see CharacterMovement->IsFalling </para>
		/// </summary>
		public virtual bool IsJumpProvidingForce()
			=> E_ACharacter_IsJumpProvidingForce(this);
		
		
		/// <summary>
		/// <para>True if we are playing Root Motion right now, through a Montage with RootMotionMode == ERootMotionMode::RootMotionFromMontagesOnly. </para>
		/// <para>This means code path for networked root motion is enabled. </para>
		/// </summary>
		public bool IsPlayingNetworkedRootMotionMontage()
			=> E_ACharacter_IsPlayingNetworkedRootMotionMontage(this);
		
		
		/// <summary>
		/// <para>True if we are playing Root Motion right now </para>
		/// </summary>
		public bool IsPlayingRootMotion()
			=> E_ACharacter_IsPlayingRootMotion(this);
		
		
		/// <summary>
		/// <para>Make the character jump on the next update. </para>
		/// <para>If you want your character to jump according to the time that the jump key is held, </para>
		/// <para>then you can set JumpKeyHoldTime to some non-zero value. Make sure in this case to </para>
		/// <para>call StopJumping() when you want the jump's z-velocity to stop being applied (such </para>
		/// <para>as on a button up event), otherwise the character will carry on receiving the </para>
		/// <para>velocity until JumpKeyHoldTime is reached. </para>
		/// </summary>
		public virtual void Jump()
			=> E_ACharacter_Jump(this);
		
		
		/// <summary>
		/// <para>Event when Character stops crouching. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public void K2_OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
			=> E_ACharacter_K2_OnEndCrouch(this, HalfHeightAdjust, ScaledHalfHeightAdjust);
		
		
		/// <summary>
		/// <para>Called from CharacterMovementComponent to notify the character that the movement mode has changed. </para>
		/// <param name="PrevMovementMode">Movement mode before the change </param>
		/// <param name="NewMovementMode">New movement mode </param>
		/// <param name="PrevCustomMode">Custom mode before the change (applicable if PrevMovementMode is Custom) </param>
		/// <param name="NewCustomMode">New custom mode (applicable if NewMovementMode is Custom) </param>
		/// </summary>
		public void K2_OnMovementModeChanged(EMovementMode PrevMovementMode, EMovementMode NewMovementMode, byte PrevCustomMode, byte NewCustomMode)
			=> E_ACharacter_K2_OnMovementModeChanged(this, (byte)PrevMovementMode, (byte)NewMovementMode, PrevCustomMode, NewCustomMode);
		
		
		/// <summary>
		/// <para>Event when Character crouches. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public void K2_OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
			=> E_ACharacter_K2_OnStartCrouch(this, HalfHeightAdjust, ScaledHalfHeightAdjust);
		
		
		/// <summary>
		/// <para>Event for implementing custom character movement mode. Called by CharacterMovement if MovementMode is set to Custom. </para>
		/// <para>@note C++ code should override UCharacterMovementComponent::PhysCustom() instead. </para>
		/// <para>@see UCharacterMovementComponent::PhysCustom() </para>
		/// </summary>
		public void UpdateCustomMovement(float DeltaTime)
			=> E_ACharacter_K2_UpdateCustomMovement(this, DeltaTime);
		
		
		/// <summary>
		/// <para>Called upon landing when falling, to perform actions based on the Hit result. Triggers the OnLanded event. </para>
		/// <para>Note that movement mode is still "Falling" during this event. Current Velocity value is the velocity at the time of landing. </para>
		/// <para>Consider OnMovementModeChanged() as well, as that can be used once the movement mode changes to the new mode (most likely Walking). </para>
		/// <param name="Hit">Result describing the landing that resulted in a valid landing spot. </param>
		/// <para>@see OnMovementModeChanged() </para>
		/// </summary>
		public virtual void Landed(FHitResult Hit)
			=> E_ACharacter_Landed(this, Hit);
		
		
		/// <summary>
		/// <para>Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick, </para>
		/// <para>and will set it to the "falling" state. Triggers the OnLaunched event. </para>
		/// <para>@PARAM LaunchVelocity is the velocity to impart to the Character </para>
		/// <para>@PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it. </para>
		/// <para>@PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it. </para>
		/// </summary>
		public virtual void LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
			=> E_ACharacter_LaunchCharacter(this, LaunchVelocity, bXYOverride, bZOverride);
		
		
		/// <summary>
		/// <para>Called when pawn's movement is blocked </para>
		/// <param name="Impact">describes the blocking hit. </param>
		/// </summary>
		public virtual void MoveBlockedBy(FHitResult Impact)
			=> E_ACharacter_MoveBlockedBy(this, Impact);
		
		
		/// <summary>
		/// <para>Called when character's jump reaches Apex. Needs CharacterMovement->bNotifyApex = true </para>
		/// </summary>
		public virtual void NotifyJumpApex()
			=> E_ACharacter_NotifyJumpApex(this);
		
		
		/// <summary>
		/// <para>Called when Character stops crouching. Called on non-owned Characters through bIsCrouched replication. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public virtual void OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
			=> E_ACharacter_OnEndCrouch(this, HalfHeightAdjust, ScaledHalfHeightAdjust);
		
		
		/// <summary>
		/// <para>Event fired when the character has just started jumping </para>
		/// </summary>
		public void OnJumped()
			=> E_ACharacter_OnJumped(this);
		
		public virtual void OnJumped_Implementation()
			=> E_ACharacter_OnJumped_Implementation(this);
		
		public void OnLanded(FHitResult Hit)
			=> E_ACharacter_OnLanded(this, Hit);
		
		public void OnLaunched(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
			=> E_ACharacter_OnLaunched(this, LaunchVelocity, bXYOverride, bZOverride);
		
		
		/// <summary>
		/// <para>Called from CharacterMovementComponent to notify the character that the movement mode has changed. </para>
		/// <param name="PrevMovementMode">Movement mode before the change </param>
		/// <param name="PrevCustomMode">Custom mode before the change (applicable if PrevMovementMode is Custom) </param>
		/// </summary>
		public virtual void OnMovementModeChanged(EMovementMode PrevMovementMode, byte PreviousCustomMode)
			=> E_ACharacter_OnMovementModeChanged(this, (byte)PrevMovementMode, PreviousCustomMode);
		
		public virtual void OnRep_IsCrouched()
			=> E_ACharacter_OnRep_IsCrouched(this);
		
		public virtual void OnRep_ReplicatedBasedMovement()
			=> E_ACharacter_OnRep_ReplicatedBasedMovement(this);
		
		public override void OnRep_ReplicatedMovement()
			=> E_ACharacter_OnRep_ReplicatedMovement(this);
		
		public void OnRep_RootMotion()
			=> E_ACharacter_OnRep_RootMotion(this);
		
		
		/// <summary>
		/// <para>Called when Character crouches. Called on non-owned Characters through bIsCrouched replication. </para>
		/// <param name="HalfHeightAdjust">difference between default collision half-height, and actual crouched capsule half-height. </param>
		/// <param name="ScaledHalfHeightAdjust">difference after component scale is taken in to account. </param>
		/// </summary>
		public virtual void OnStartCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
			=> E_ACharacter_OnStartCrouch(this, HalfHeightAdjust, ScaledHalfHeightAdjust);
		
		
		/// <summary>
		/// <para>Called on client after position update is received to respond to the new location and rotation. </para>
		/// <para>Actual change in location is expected to occur in CharacterMovement->SmoothCorrection(), after which this occurs. </para>
		/// <para>Default behavior is to check for penetration in a blocking object if bClientCheckEncroachmentOnNetUpdate is enabled, and set bSimGravityDisabled=true if so. </para>
		/// </summary>
		public virtual void OnUpdateSimulatedPosition(FVector OldLocation, FQuat OldRotation)
			=> E_ACharacter_OnUpdateSimulatedPosition(this, OldLocation, OldRotation);
		
		
		/// <summary>
		/// <para>Event fired when the Character is walking off a surface and is about to fall because CharacterMovement->CurrentFloor became unwalkable. </para>
		/// <para>If CharacterMovement->MovementMode does not change during this event then the character will automatically start falling afterwards. </para>
		/// <para>@note Z velocity is zero during walking movement, and will be here as well. Another velocity can be computed here if desired and will be used when starting to fall. </para>
		/// <param name="PreviousFloorImpactNormal">Normal of the previous walkable floor. </param>
		/// <param name="PreviousFloorContactNormal">Normal of the contact with the previous walkable floor. </param>
		/// <param name="PreviousLocation">Previous character location before movement off the ledge. </param>
		/// <param name="TimeTick">Time delta of movement update resulting in moving off the ledge. </param>
		/// </summary>
		public void OnWalkingOffLedge(FVector PreviousFloorImpactNormal, FVector PreviousFloorContactNormal, FVector PreviousLocation, float TimeDelta)
			=> E_ACharacter_OnWalkingOffLedge(this, PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
		
		public virtual void OnWalkingOffLedge_Implementation(FVector PreviousFloorImpactNormal, FVector PreviousFloorContactNormal, FVector PreviousLocation, float TimeDelta)
			=> E_ACharacter_OnWalkingOffLedge_Implementation(this, PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
		
		public override void PawnClientRestart()
			=> E_ACharacter_PawnClientRestart(this);
		
		public override void PostInitializeComponents()
			=> E_ACharacter_PostInitializeComponents(this);
		
		public override void PostNetReceive()
			=> E_ACharacter_PostNetReceive(this);
		
		public override void PostNetReceiveLocationAndRotation()
			=> E_ACharacter_PostNetReceiveLocationAndRotation(this);
		
		public override void PreNetReceive()
			=> E_ACharacter_PreNetReceive(this);
		
		public override void RecalculateBaseEyeHeight()
			=> E_ACharacter_RecalculateBaseEyeHeight(this);
		
		
		/// <summary>
		/// <para>Marks character as not trying to jump </para>
		/// </summary>
		public void ResetJumpState()
			=> E_ACharacter_ResetJumpState(this);
		
		public override void Restart()
			=> E_ACharacter_Restart(this);
		
		
		/// <summary>
		/// <para>Restore actor to an old buffered move. </para>
		/// </summary>
		public bool RestoreReplicatedMove(FSimulatedRootMotionReplicatedMove RootMotionRepMove)
			=> E_ACharacter_RestoreReplicatedMove(this, RootMotionRepMove);
		
		public void RootMotionDebugClientPrintOnScreen(string InString)
			=> E_ACharacter_RootMotionDebugClientPrintOnScreen(this, InString);
		
		public virtual void RootMotionDebugClientPrintOnScreen_Implementation(string InString)
			=> E_ACharacter_RootMotionDebugClientPrintOnScreen_Implementation(this, InString);
		
		
		/// <summary>
		/// <para>Save a new relative location in BasedMovement and a new rotation with is either relative or absolute. </para>
		/// </summary>
		public void SaveRelativeBasedMovement(FVector NewRelativeLocation, FRotator NewRotation, bool bRelativeRotation)
			=> E_ACharacter_SaveRelativeBasedMovement(this, NewRelativeLocation, NewRotation, bRelativeRotation);
		
		
		/// <summary>
		/// <para>Sets scale to apply to root motion translation on this Character </para>
		/// </summary>
		public void SetAnimRootMotionTranslationScale(float InAnimRootMotionTranslationScale)
			=> E_ACharacter_SetAnimRootMotionTranslationScale(this, InAnimRootMotionTranslationScale);
		
		
		/// <summary>
		/// <para>Sets the component the Character is walking on, used by CharacterMovement walking movement to be able to follow dynamic objects. </para>
		/// </summary>
		public virtual void SetBase(UPrimitiveComponent NewBase, string BoneName, bool bNotifyActor)
			=> E_ACharacter_SetBase(this, NewBase, BoneName, bNotifyActor);
		
		
		/// <summary>
		/// <para>Set whether this actor's movement replicates to network clients. </para>
		/// </summary>
		public override void SetReplicateMovement(bool bInReplicateMovement)
			=> E_ACharacter_SetReplicateMovement(this, bInReplicateMovement);
		
		
		/// <summary>
		/// <para>Returns true if the Landed() event should be called. Used by CharacterMovement to prevent notifications while playing back network moves. </para>
		/// </summary>
		public virtual bool ShouldNotifyLanded(FHitResult Hit)
			=> E_ACharacter_ShouldNotifyLanded(this, Hit);
		
		
		/// <summary>
		/// <para>Position fix up for Simulated Proxies playing Root Motion </para>
		/// </summary>
		public void SimulatedRootMotionPositionFixup(float DeltaSeconds)
			=> E_ACharacter_SimulatedRootMotionPositionFixup(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Stop the character from jumping on the next update. </para>
		/// <para>Call this from an input event (such as a button 'up' event) to cease applying </para>
		/// <para>jump Z-velocity. If this is not called, then jump z-velocity will be applied </para>
		/// <para>until JumpMaxHoldTime is reached. </para>
		/// </summary>
		public virtual void StopJumping()
			=> E_ACharacter_StopJumping(this);
		
		public override void TornOff()
			=> E_ACharacter_TornOff(this);
		
		public override void TurnOff()
			=> E_ACharacter_TurnOff(this);
		
		
		/// <summary>
		/// <para>Request the character to stop crouching. The request is processed on the next update of the CharacterMovementComponent. </para>
		/// <para>@see OnEndCrouch </para>
		/// <para>@see IsCrouched </para>
		/// <para>@see CharacterMovement->WantsToCrouch </para>
		/// </summary>
		public virtual void UnCrouch(bool bClientSimulation)
			=> E_ACharacter_UnCrouch(this, bClientSimulation);
		
		public override void UnPossessed()
			=> E_ACharacter_UnPossessed(this);
		
		public override void UpdateNavigationRelevance()
			=> E_ACharacter_UpdateNavigationRelevance(this);
		
		
		/// <summary>
		/// <para>Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputPitchScale value. </para>
		/// <param name="Val">Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value. </param>
		/// <para>@see PlayerController::InputPitchScale </para>
		/// </summary>
		public override void AddControllerPitchInput(float Val)
			=> E_ACharacter_AddControllerPitchInput(this, Val);
		
		
		/// <summary>
		/// <para>Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputRollScale value. </para>
		/// <param name="Val">Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value. </param>
		/// <para>@see PlayerController::InputRollScale </para>
		/// </summary>
		public override void AddControllerRollInput(float Val)
			=> E_ACharacter_AddControllerRollInput(this, Val);
		
		
		/// <summary>
		/// <para>Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputYawScale value. </para>
		/// <param name="Val">Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value. </param>
		/// <para>@see PlayerController::InputYawScale </para>
		/// </summary>
		public override void AddControllerYawInput(float Val)
			=> E_ACharacter_AddControllerYawInput(this, Val);
		
		
		/// <summary>
		/// <para>Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'. If ScaleValue < 0, movement will be in the opposite direction. </para>
		/// <para>Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move. </para>
		/// <param name="WorldDirection">Direction in world space to apply input </param>
		/// <param name="ScaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction. </param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored(). </param>
		/// <para>@see GetPendingMovementInputVector(), GetLastMovementInputVector(), ConsumeMovementInputVector() </para>
		/// </summary>
		public override void AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce)
			=> E_ACharacter_AddMovementInput(this, WorldDirection, ScaleValue, bForce);
		
		
		/// <summary>
		/// <para>Overridden to defer to the RootComponent's CanCharacterStepUpOn setting if it is explicitly Yes or No. If set to Owner, will return Super::CanBeBaseForCharacter(). </para>
		/// </summary>
		public override bool CanBeBaseForCharacter(APawn APawn)
			=> E_ACharacter_CanBeBaseForCharacter(this, APawn);
		
		
		/// <summary>
		/// <para>Returns the pending input vector and resets it to zero. </para>
		/// <para>This should be used during a movement update (by the Pawn or PawnMovementComponent) to prevent accumulation of control input between frames. </para>
		/// <para>Copies the pending input vector to the saved input vector (GetLastMovementInputVector()). </para>
		/// <return>The pending input vector. </return>
		/// </summary>
		public override FVector ConsumeMovementInputVector()
			=> E_ACharacter_ConsumeMovementInputVector(this);
		
		public override void Destroyed()
			=> E_ACharacter_Destroyed(this);
		
		
		/// <summary>
		/// <para>Destroys the player input component and removes any references to it. </para>
		/// </summary>
		protected override void DestroyPlayerInputComponent()
			=> E_ACharacter_DestroyPlayerInputComponent(this);
		
		
		/// <summary>
		/// <para>Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon. </para>
		/// </summary>
		public override void DetachFromControllerPendingDestroy()
			=> E_ACharacter_DetachFromControllerPendingDestroy(this);
		
		
		/// <summary>
		/// <para>Updates Pawn's rotation to the given rotation, assumed to be the Controller's ControlRotation. Respects the bUseControllerRotation* settings. </para>
		/// </summary>
		public override void FaceRotation(FRotator NewControlRotation, float DeltaTime)
			=> E_ACharacter_FaceRotation(this, NewControlRotation, DeltaTime);
		
		public override void GetActorEyesViewPoint(FVector Location, FRotator Rotation)
			=> E_ACharacter_GetActorEyesViewPoint(this, Location, Rotation);
		
		
		/// <summary>
		/// <para>Return the aim rotation for the Pawn. </para>
		/// <para>If we have a controller, by default we aim at the player's 'eyes' direction </para>
		/// <para>that is by default the Pawn rotation for AI, and camera (crosshair) rotation for human players. </para>
		/// </summary>
		public override FRotator GetBaseAimRotation()
			=> E_ACharacter_GetBaseAimRotation(this);
		
		public override string GetHumanReadableName()
			=> E_ACharacter_GetHumanReadableName(this);
		
		public override void GetMoveGoalReachTest(AActor MovingActor, FVector MoveOffset, FVector GoalOffset, float GoalRadius, float GoalHalfHeight)
			=> E_ACharacter_GetMoveGoalReachTest(this, MovingActor, MoveOffset, GoalOffset, GoalRadius, GoalHalfHeight);
		
		public override UPlayer GetNetOwningPlayer()
			=> E_ACharacter_GetNetOwningPlayer(this);
		
		
		/// <summary>
		/// <para>Return our PawnNoiseEmitterComponent, if any. Default implementation returns the first PawnNoiseEmitterComponent found in the components array. </para>
		/// <para>If one isn't found, then it tries to find one on the Pawn's current Controller. </para>
		/// </summary>
		public override UPawnNoiseEmitterComponent GetPawnNoiseEmitterComponent()
			=> E_ACharacter_GetPawnNoiseEmitterComponent(this);
		
		
		/// <summary>
		/// <return>Pawn's eye location </return>
		/// </summary>
		public override FVector GetPawnViewLocation()
			=> E_ACharacter_GetPawnViewLocation(this);
		
		public override FVector GetVelocity()
			=> E_ACharacter_GetVelocity(this);
		
		
		/// <summary>
		/// <para>Get the view rotation of the Pawn (direction they are looking, normally Controller->ControlRotation). </para>
		/// <return>The view rotation of the Pawn. </return>
		/// </summary>
		public override FRotator GetViewRotation()
			=> E_ACharacter_GetViewRotation(this);
		
		
		/// <summary>
		/// <return>true if player is viewing this Pawn in FreeCam </return>
		/// </summary>
		public override bool InFreeCam()
			=> E_ACharacter_InFreeCam(this);
		
		public override bool IsBasedOnActor(AActor Other)
			=> E_ACharacter_IsBasedOnActor(this, Other);
		
		
		/// <summary>
		/// <return>true if controlled by a local (not network) Controller. </return>
		/// </summary>
		public override bool IsLocallyControlled()
			=> E_ACharacter_IsLocallyControlled(this);
		
		
		/// <summary>
		/// <para>Helper to see if move input is ignored. If our controller is a PlayerController, checks Controller->IsMoveInputIgnored(). </para>
		/// </summary>
		public override bool IsMoveInputIgnored()
			=> E_ACharacter_IsMoveInputIgnored(this);
		
		public override bool IsNetRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation)
			=> E_ACharacter_IsNetRelevantFor(this, RealViewer, ViewTarget, SrcLocation);
		
		
		/// <summary>
		/// <return>true if controlled by a human player (possessed by a PlayerController). </return>
		/// </summary>
		public override bool IsPlayerControlled()
			=> E_ACharacter_IsPlayerControlled(this);
		
		public override void OnRep_Controller()
			=> E_ACharacter_OnRep_Controller(this);
		
		public override void OnRep_PlayerState()
			=> E_ACharacter_OnRep_PlayerState(this);
		
		public override void OutsideWorldBounds()
			=> E_ACharacter_OutsideWorldBounds(this);
		
		
		/// <summary>
		/// <para>Handle StartFire() passed from PlayerController </para>
		/// </summary>
		public override void PawnStartFire(byte FireModeNum)
			=> E_ACharacter_PawnStartFire(this, FireModeNum);
		
		public override void PostLoad()
			=> E_ACharacter_PostLoad(this);
		
		public override void PostNetReceiveVelocity(FVector NewVelocity)
			=> E_ACharacter_PostNetReceiveVelocity(this, NewVelocity);
		
		public override void PostRegisterAllComponents()
			=> E_ACharacter_PostRegisterAllComponents(this);
		
		public override void PreInitializeComponents()
			=> E_ACharacter_PreInitializeComponents(this);
		
		
		/// <summary>
		/// <para>Return true if yaw is within AllowedYawError of desired yaw </para>
		/// </summary>
		public override bool ReachedDesiredRotation()
			=> E_ACharacter_ReachedDesiredRotation(this);
		
		public override void Reset()
			=> E_ACharacter_Reset(this);
		
		
		/// <summary>
		/// <para>Make sure pawn properties are back to default. </para>
		/// </summary>
		public override void SetPlayerDefaults()
			=> E_ACharacter_SetPlayerDefaults(this);
		
		public override bool ShouldTickIfViewportsOnly()
			=> E_ACharacter_ShouldTickIfViewportsOnly(this);
		
		
		/// <summary>
		/// <para>Spawn default controller for this Pawn, and get possessed by it. </para>
		/// </summary>
		public override void SpawnDefaultController()
			=> E_ACharacter_SpawnDefaultController(this);
		
		public override void TeleportSucceeded(bool bIsATest)
			=> E_ACharacter_TeleportSucceeded(this, bIsATest);
		
		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteActor. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public override void AddTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_ACharacter_AddTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Make this actor tick after PrerequisiteComponent. This only applies to this actor's tick function; dependencies for owned components must be set up separately if desired. </para>
		/// </summary>
		public override void AddTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_ACharacter_AddTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Called by owning level to shift an actor location and all relevant data structures by specified delta </para>
		/// <param name="InWorldOffset">Offset vector to shift actor location </param>
		/// <param name="bWorldShift">Whether this call is part of whole world shifting </param>
		/// </summary>
		public override void ApplyWorldOffset(FVector InOffset, bool bWorldShift)
			=> E_ACharacter_ApplyWorldOffset(this, InOffset, bWorldShift);
		
		public override void BeginDestroy()
			=> E_ACharacter_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Calculates the actor space bounding box of all components in this Actor.  This is slower than GetComponentsBoundingBox(), because the local bounds of the components are not cached -- they are recalculated every time this function is called. </para>
		/// <param name="bNonColliding">Indicates that you want to include non-colliding components in the bounding box </param>
		/// </summary>
		public override FBox CalculateComponentsBoundingBoxInLocalSpace(bool bNonColliding)
			=> E_ACharacter_CalculateComponentsBoundingBoxInLocalSpace(this, bNonColliding);
		
		public override bool CanBeInCluster()
			=> E_ACharacter_CanBeInCluster(this);
		
		public override bool CheckDefaultSubobjectsInternal()
			=> E_ACharacter_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>This will check to see if the Actor is still in the world.  It will check things like </para>
		/// <para>the KillZ, outside world bounds, etc. and handle the situation. </para>
		/// </summary>
		public override bool CheckStillInWorld()
			=> E_ACharacter_CheckStillInWorld(this);
		
		
		/// <summary>
		/// <para>Called by DestroyActor(), gives actors a chance to op out of actor destruction </para>
		/// <para>Used by network code to have the net connection timeout/cleanup first </para>
		/// <return>true if DestroyActor() should not continue with actor destruction, false otherwise </return>
		/// </summary>
		public override bool DestroyNetworkActorHandled()
			=> E_ACharacter_DestroyNetworkActorHandled(this);
		
		
		/// <summary>
		/// <para>Forces this actor to be net relevant if it is not already by default </para>
		/// </summary>
		public override void ForceNetRelevant()
			=> E_ACharacter_ForceNetRelevant(this);
		
		
		/// <summary>
		/// <para>Force actor to be updated to clients </para>
		/// </summary>
		public override void ForceNetUpdate()
			=> E_ACharacter_ForceNetUpdate(this);
		
		
		/// <summary>
		/// <para>Fills ReplicatedMovement property </para>
		/// </summary>
		public override void GatherCurrentMovement()
			=> E_ACharacter_GatherCurrentMovement(this);
		
		
		/// <summary>
		/// <para>Returns the world space bounding box of all components in this Actor. </para>
		/// <param name="bNonColliding">Indicates that you want to include non-colliding components in the bounding box </param>
		/// </summary>
		public override FBox GetComponentsBoundingBox(bool bNonColliding)
			=> E_ACharacter_GetComponentsBoundingBox(this, bNonColliding);
		
		
		/// <summary>
		/// <para>Get half-height/radius of a big axis-aligned cylinder around this actors registered colliding components, or all registered components if bNonColliding is false. </para>
		/// </summary>
		public override void GetComponentsBoundingCylinder(float CollisionRadius, float CollisionHalfHeight, bool bNonColliding)
			=> E_ACharacter_GetComponentsBoundingCylinder(this, CollisionRadius, CollisionHalfHeight, bNonColliding);
		
		
		/// <summary>
		/// <para>Get Collision Response to the Channel that entered for all components </para>
		/// <para>It returns Max of state - i.e. if Component A overlaps, but if Component B blocks, it will return block as response </para>
		/// <para>if Component A ignores, but if Component B overlaps, it will return overlap </para>
		/// <param name="Channel">The channel to change the response of </param>
		/// </summary>
		public override ECollisionResponse GetComponentsCollisionResponseToChannel(ECollisionChannel Channel)
			=> (ECollisionResponse)E_ACharacter_GetComponentsCollisionResponseToChannel(this, (byte)Channel);
		
		
		/// <summary>
		/// <para>Returns this actor's default attachment component for attaching children to </para>
		/// <return>The scene component to be used as parent </return>
		/// </summary>
		public override USceneComponent GetDefaultAttachComponent()
			=> E_ACharacter_GetDefaultAttachComponent(this);
		
		
		/// <summary>
		/// <para>Returns the most recent time any of this actor's components were rendered </para>
		/// </summary>
		public override float GetLastRenderTime()
			=> E_ACharacter_GetLastRenderTime(this);
		
		
		/// <summary>
		/// <para>Get the remaining lifespan of this actor. If zero is returned the actor lives forever. </para>
		/// </summary>
		public override float GetLifeSpan()
			=> E_ACharacter_GetLifeSpan(this);
		
		
		/// <summary>
		/// <para>Returns the optimal location to fire weapons at this actor </para>
		/// <param name="RequestedBy">the Actor requesting the target location </param>
		/// </summary>
		public override FVector GetTargetLocation(AActor RequestedBy)
			=> E_ACharacter_GetTargetLocation(this, RequestedBy);
		
		
		/// <summary>
		/// <para>Getter for the cached world pointer </para>
		/// </summary>
		public override UWorld GetWorld()
			=> E_ACharacter_GetWorld(this);
		
		
		/// <summary>
		/// <para>Returns true if the actor contains an active camera component </para>
		/// </summary>
		public override bool HasActiveCameraComponent()
			=> E_ACharacter_HasActiveCameraComponent(this);
		
		
		/// <summary>
		/// <para>Returns true if the actor contains an active locked to HMD camera component </para>
		/// </summary>
		public override bool HasActivePawnControlCameraComponent()
			=> E_ACharacter_HasActivePawnControlCameraComponent(this);
		
		
		/// <summary>
		/// <para>Does this actor have an owner responsible for replication? (APlayerController typically) </para>
		/// <return>true if this actor can call RPCs or false if no such owner chain exists </return>
		/// </summary>
		protected override bool HasNetOwner()
			=> E_ACharacter_HasNetOwner(this);
		
		
		/// <summary>
		/// <para>Invalidates anything produced by the last lighting build. </para>
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bTranslationOnly)
			=> E_ACharacter_InvalidateLightingCacheDetailed(this, bTranslationOnly);
		
		
		/// <summary>
		/// <para>Iterates up the Base chain to see whether or not this Actor is attached to the given Actor </para>
		/// <param name="Other">the Actor to test for </param>
		/// <return>true if this Actor is attached on Other Actor </return>
		/// </summary>
		public override bool IsAttachedTo(AActor Other)
			=> E_ACharacter_IsAttachedTo(this, Other);
		
		
		/// <summary>
		/// <para>Check if owned component should be relevant for navigation </para>
		/// <para>Allows implementing master switch to disable e.g. collision export in projectiles </para>
		/// </summary>
		public override bool IsComponentRelevantForNavigation(UActorComponent Component)
			=> E_ACharacter_IsComponentRelevantForNavigation(this, Component);
		
		
		/// <summary>
		/// <para>Indicates whether this actor should participate in level bounds calculations </para>
		/// </summary>
		public override bool IsLevelBoundsRelevant()
			=> E_ACharacter_IsLevelBoundsRelevant(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_ACharacter_IsNameStableForNetworking(this);
		
		public override bool IsReadyForFinishDestroy()
			=> E_ACharacter_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Check if this actor is the owner when doing relevancy checks for actors marked bOnlyRelevantToOwner </para>
		/// <param name="ReplicatedActor">the actor we're doing a relevancy test on </param>
		/// <param name="ActorOwner">the owner of ReplicatedActor </param>
		/// <param name="ConnectionActor">the controller of the connection that we're doing relevancy checks for </param>
		/// <return>bool - true if this actor should be considered the owner </return>
		/// </summary>
		public override bool IsRelevancyOwnerFor(AActor ReplicatedActor, AActor ActorOwner, AActor ConnectionActor)
			=> E_ACharacter_IsRelevancyOwnerFor(this, ReplicatedActor, ActorOwner, ConnectionActor);
		
		
		/// <summary>
		/// <param name="RealViewer">is the "controlling net object" associated with the client for which network relevancy is being checked (typically player controller) </param>
		/// <param name="ViewTarget">is the Actor being used as the point of view for the RealViewer </param>
		/// <param name="SrcLocation">is the viewing location </param>
		/// <return>bool - true if this actor is replay relevant to the client associated with RealViewer </return>
		/// </summary>
		public override bool IsReplayRelevantFor(AActor RealViewer, AActor ViewTarget, FVector SrcLocation, float CullDistanceSquared)
			=> E_ACharacter_IsReplayRelevantFor(this, RealViewer, ViewTarget, SrcLocation, CullDistanceSquared);
		
		
		/// <summary>
		/// <para>@returns true if the root component is registered and has collision enabled. </para>
		/// </summary>
		public override bool IsRootComponentCollisionRegistered()
			=> E_ACharacter_IsRootComponentCollisionRegistered(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_ACharacter_IsSupportedForNetworking(this);
		
		
		/// <summary>
		/// <para>Destroy the actor </para>
		/// </summary>
		public override void DestroyActor()
			=> E_ACharacter_K2_DestroyActor(this);
		
		
		/// <summary>
		/// <para>Called when the lifespan of an actor expires (if he has one). </para>
		/// </summary>
		public override void LifeSpanExpired()
			=> E_ACharacter_LifeSpanExpired(this);
		
		
		/// <summary>
		/// <para>Called to mark all components as pending kill when the actor is being destroyed </para>
		/// </summary>
		public override void MarkComponentsAsPendingKill()
			=> E_ACharacter_MarkComponentsAsPendingKill(this);
		
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_ACharacter_Modify(this, bAlwaysMarkDirty);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved over it with the clickable interface. </para>
		/// </summary>
		public override void NotifyActorBeginCursorOver()
			=> E_ACharacter_NotifyActorBeginCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when this actor overlaps another actor, for example a player walking into a trigger. </para>
		/// <para>For events when objects have a blocking collision, for example a player hitting a wall, see 'Hit' events. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public override void NotifyActorBeginOverlap(AActor OtherActor)
			=> E_ACharacter_NotifyActorBeginOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when this actor has the mouse moved off of it with the clickable interface. </para>
		/// </summary>
		public override void NotifyActorEndCursorOver()
			=> E_ACharacter_NotifyActorEndCursorOver(this);
		
		
		/// <summary>
		/// <para>Event when an actor no longer overlaps another actor, and they have separated. </para>
		/// <para>@note Components on both this and the other Actor must have bGenerateOverlapEvents set to true to generate overlap events. </para>
		/// </summary>
		public override void NotifyActorEndOverlap(AActor OtherActor)
			=> E_ACharacter_NotifyActorEndOverlap(this, OtherActor);
		
		
		/// <summary>
		/// <para>Event when this actor bumps into a blocking object, or blocks another actor that bumps into it. </para>
		/// <para>This could happen due to things like Character movement, using Set Location with 'sweep' enabled, or physics simulation. </para>
		/// <para>For events when objects overlap (e.g. walking into a trigger) see the 'Overlap' event. </para>
		/// <para>@note For collisions during physics simulation to generate hit events, 'Simulation Generates Hit Events' must be enabled. </para>
		/// <para>@note When receiving a hit from another object's movement (bSelfMoved is false), the directions of 'Hit.Normal' and 'Hit.ImpactNormal' </para>
		/// <para>will be adjusted to indicate force from the other object against this object. </para>
		/// </summary>
		public override void NotifyHit(UPrimitiveComponent MyComp, AActor Other, UPrimitiveComponent OtherComp, bool bSelfMoved, FVector HitLocation, FVector HitNormal, FVector NormalImpulse, FHitResult Hit)
			=> E_ACharacter_NotifyHit(this, MyComp, Other, OtherComp, bSelfMoved, HitLocation, HitNormal, NormalImpulse, Hit);
		
		
		/// <summary>
		/// <para>Called when an instance of this class is placed (in editor) or spawned. </para>
		/// <param name="Transform">The transform the actor was constructed at. </param>
		/// </summary>
		public override void OnConstruction(FTransform Transform)
			=> E_ACharacter_OnConstruction(this, Transform);
		
		public override void OnRep_AttachmentReplication()
			=> E_ACharacter_OnRep_AttachmentReplication(this);
		
		public override void OnRep_Instigator()
			=> E_ACharacter_OnRep_Instigator(this);
		
		protected override void OnRep_Owner()
			=> E_ACharacter_OnRep_Owner(this);
		
		public override void OnRep_ReplicateMovement()
			=> E_ACharacter_OnRep_ReplicateMovement(this);
		
		
		/// <summary>
		/// <para>Called on the client when the replication paused value is changed </para>
		/// </summary>
		public override void OnReplicationPausedChanged(bool bIsReplicationPaused)
			=> E_ACharacter_OnReplicationPausedChanged(this, bIsReplicationPaused);
		
		
		/// <summary>
		/// <para>Called on the actor when a new subobject is dynamically created via replication </para>
		/// </summary>
		public override void OnSubobjectCreatedFromReplication(UObject NewSubobject)
			=> E_ACharacter_OnSubobjectCreatedFromReplication(this, NewSubobject);
		
		
		/// <summary>
		/// <para>Called on the actor when a subobject is dynamically destroyed via replication </para>
		/// </summary>
		public override void OnSubobjectDestroyFromReplication(UObject Subobject)
			=> E_ACharacter_OnSubobjectDestroyFromReplication(this, Subobject);
		
		
		/// <summary>
		/// <para>Called when an actor is done spawning into the world (from UWorld::SpawnActor). </para>
		/// <para>For actors with a root component, the location and rotation will have already been set. </para>
		/// <para>Takes place after any construction scripts have been called </para>
		/// </summary>
		public override void PostActorCreated()
			=> E_ACharacter_PostActorCreated(this);
		
		public override void PostInitProperties()
			=> E_ACharacter_PostInitProperties(this);
		
		
		/// <summary>
		/// <para>Always called immediately after spawning and reading in replicated properties </para>
		/// </summary>
		public override void PostNetInit()
			=> E_ACharacter_PostNetInit(this);
		
		
		/// <summary>
		/// <para>Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity() </para>
		/// </summary>
		public override void PostNetReceivePhysicState()
			=> E_ACharacter_PostNetReceivePhysicState(this);
		
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_ACharacter_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Called after all currently registered components are cleared </para>
		/// </summary>
		public override void PostUnregisterAllComponents()
			=> E_ACharacter_PostUnregisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Calls PrestreamTextures() for all the actor's meshcomponents. </para>
		/// <param name="Seconds">Number of seconds to force all mip-levels to be resident </param>
		/// <param name="bEnableStreaming">Whether to start (true) or stop (false) streaming </param>
		/// <param name="CinematicTextureGroups">Bitfield indicating which texture groups that use extra high-resolution mips </param>
		/// </summary>
		public override void PrestreamTextures(float Seconds, bool bEnableStreaming, int CinematicTextureGroups)
			=> E_ACharacter_PrestreamTextures(this, Seconds, bEnableStreaming, CinematicTextureGroups);
		
		
		/// <summary>
		/// <para>Virtual call chain to register all tick functions for the actor class hierarchy </para>
		/// <param name="bRegister">true to register, false, to unregister </param>
		/// </summary>
		protected override void RegisterActorTickFunctions(bool bRegister)
			=> E_ACharacter_RegisterActorTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// <para>Ensure that all the components in the Components array are registered </para>
		/// </summary>
		public override void RegisterAllComponents()
			=> E_ACharacter_RegisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteActor. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteActor(AActor PrerequisiteActor)
			=> E_ACharacter_RemoveTickPrerequisiteActor(this, PrerequisiteActor);
		
		
		/// <summary>
		/// <para>Remove tick dependency on PrerequisiteComponent. </para>
		/// </summary>
		public override void RemoveTickPrerequisiteComponent(UActorComponent PrerequisiteComponent)
			=> E_ACharacter_RemoveTickPrerequisiteComponent(this, PrerequisiteComponent);
		
		
		/// <summary>
		/// <para>Will reregister all components on this actor. Does a lot of work - should only really be used in editor, generally use UpdateComponentTransforms or MarkComponentsRenderStateDirty. </para>
		/// </summary>
		public override void ReregisterAllComponents()
			=> E_ACharacter_ReregisterAllComponents(this);
		
		
		/// <summary>
		/// <para>Rerun construction scripts, destroying all autogenerated components; will attempt to preserve the root component location. </para>
		/// </summary>
		public override void RerunConstructionScripts()
			=> E_ACharacter_RerunConstructionScripts(this);
		
		
		/// <summary>
		/// <para>Sets the actor to be hidden in the game </para>
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components </param>
		/// </summary>
		public override void SetActorHiddenInGame(bool bNewHidden)
			=> E_ACharacter_SetActorHiddenInGame(this, bNewHidden);
		
		
		/// <summary>
		/// <para>Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed. </para>
		/// </summary>
		public override void SetLifeSpan(float InLifespan)
			=> E_ACharacter_SetLifeSpan(this, InLifespan);
		
		
		/// <summary>
		/// <para>Set the owner of this Actor, used primarily for network replication. </para>
		/// <param name="NewOwner">The Actor whom takes over ownership of this Actor </param>
		/// </summary>
		public override void SetOwner(AActor NewOwner)
			=> E_ACharacter_SetOwner(this, NewOwner);
		
		
		/// <summary>
		/// <para>Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true. </para>
		/// </summary>
		public override void TearOff()
			=> E_ACharacter_TearOff(this);
		
		
		/// <summary>
		/// <para>Used for adding actors to levels or teleporting them to a new location. </para>
		/// <para>The result of this function is independent of the actor's current location and rotation. </para>
		/// <para>If the actor doesn't fit exactly at the location specified, tries to slightly move it out of walls and such if bNoCheck is false. </para>
		/// <param name="DestLocation">The target destination point </param>
		/// <param name="DestRotation">The target rotation at the destination </param>
		/// <param name="bIsATest">is true if this is a test movement, which shouldn't cause any notifications (used by AI pathfinding, for example) </param>
		/// <param name="bNoCheck">is true if we should skip checking for encroachment in the world or other actors </param>
		/// <return>true if the actor has been successfully moved, or false if it couldn't fit. </return>
		/// </summary>
		public override bool TeleportTo(FVector DestLocation, FRotator DestRotation, bool bIsATest, bool bNoCheck)
			=> E_ACharacter_TeleportTo(this, DestLocation, DestRotation, bIsATest, bNoCheck);
		
		
		/// <summary>
		/// <para>Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame. </para>
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// <param name="DeltaSeconds">Game time elapsed during last frame modified by the time dilation </param>
		/// </summary>
		public override void Tick(float DeltaSeconds)
			=> E_ACharacter_Tick(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>ticks the actor </para>
		/// <param name="DeltaTime">The time slice of this tick </param>
		/// <param name="TickType">The type of tick that is happening </param>
		/// <param name="ThisTickFunction">The tick function that is firing, useful for getting the completion handle </param>
		/// </summary>
		public override void TickActor(float DeltaTime, ELevelTick TickType, FActorTickFunction ThisTickFunction)
			=> E_ACharacter_TickActor(this, DeltaTime, (byte)TickType, ThisTickFunction);
		
		
		/// <summary>
		/// <para>Unregister all currently registered components </para>
		/// </summary>
		public override void UnregisterAllComponents(bool bForReregister)
			=> E_ACharacter_UnregisterAllComponents(this, bForReregister);
		
		
		/// <summary>
		/// <para>Used by the net connection to determine if a net owning actor should switch to using the shortened timeout value </para>
		/// <return>true to switch from InitialConnectTimeout to ConnectionTimeout values on the net driver </return>
		/// </summary>
		public override bool UseShortConnectTimeout()
			=> E_ACharacter_UseShortConnectTimeout(this);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_ACharacter_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E_ACharacter_FinishDestroy(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_ACharacter_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_ACharacter_GetDetailedInfoInternal(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_ACharacter_IsAsset(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine if the object is forced to be editor only or not </para>
		/// <return>true if this object should never be loaded outside the editor </return>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_ACharacter_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_ACharacter_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_ACharacter_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_ACharacter_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_ACharacter_IsSafeForRootSet(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_ACharacter_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on clients </para>
		/// <return>true if this object should be loaded on clients </return>
		/// </summary>
		public override bool NeedsLoadForClient()
			=> E_ACharacter_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will still get loaded if NeedsLoadForServer/Client are true </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_ACharacter_NeedsLoadForEditorGame(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on servers </para>
		/// <return>true if this object should be loaded on servers </return>
		/// </summary>
		public override bool NeedsLoadForServer()
			=> E_ACharacter_NeedsLoadForServer(this);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_ACharacter_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_ACharacter_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_ACharacter_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies()
			=> E_ACharacter_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_ACharacter_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_ACharacter_PreDestroyFromReplication(this);
		
		public override void ShutdownAfterError()
			=> E_ACharacter_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_ACharacter_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_ACharacter_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_ACharacter_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_ACharacter_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(ACharacter Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ACharacter(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ACharacter>(PtrDesc);
		}}}
