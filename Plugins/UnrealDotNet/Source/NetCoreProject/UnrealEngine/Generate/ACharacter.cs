using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Characters are Pawns that have a mesh, collision, and built-in movement logic.
	/// They are responsible for all physical interaction between the player or AI and the world, and also implement basic networking and input models.
	/// They are designed for a vertically-oriented player representation that can walk, jump, fly, and swim through the world using CharacterMovementComponent.
	/// @see APawn, UCharacterMovementComponent
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Pawn/Character
	/// </summary>
	public partial class ACharacter : APawn
	{
		public ACharacter(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_ACharacter_CrouchedEyeHeight_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_ACharacter_CrouchedEyeHeight_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_ACharacter_JumpKeyHoldTime_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_ACharacter_JumpKeyHoldTime_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_ACharacter_JumpMaxHoldTime_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_ACharacter_JumpMaxHoldTime_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_Struct_ACharacter_JumpMaxCount_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_ACharacter_JumpMaxCount_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_Struct_ACharacter_JumpCurrentCount_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_ACharacter_JumpCurrentCount_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRepRootMotionMontage E_Struct_ACharacter_RepRootMotion_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_ACharacter_RepRootMotion_SET(IntPtr Ptr, FRepRootMotionMontage Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_CacheInitialMeshOffset(IntPtr Self, IntPtr MeshRelativeLocation, IntPtr MeshRelativeRotation);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_OnRep_ReplicatedBasedMovement(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_SaveRelativeBasedMovement(IntPtr Self, IntPtr NewRelativeLocation, IntPtr NewRotation, bool bRelativeRotation);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern byte E_ACharacter_GetReplicatedMovementMode(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_ACharacter_GetBaseTranslationOffset(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_ACharacter_GetBaseRotationOffset(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_ACharacter_GetBaseRotationOffsetRotator(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_ACharacter_CanJump(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_LaunchCharacter(IntPtr Self, IntPtr LaunchVelocity, bool bXYOverride, bool bZOverride);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_OnWalkingOffLedge(IntPtr Self, IntPtr PreviousFloorImpactNormal, IntPtr PreviousFloorContactNormal, IntPtr PreviousLocation, float TimeDelta);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_ACharacter_CanCrouch(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_OnEndCrouch(IntPtr Self, float HalfHeightAdjust, float ScaledHalfHeightAdjust);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_K2_UpdateCustomMovement(IntPtr Self, float DeltaTime);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_UpdateFromCompressedFlags(IntPtr Self, byte Flags);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_ACharacter_RestoreReplicatedMove(IntPtr Self, IntPtr RootMotionRepMove);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_UpdateSimulatedPosition(IntPtr Self, IntPtr Location, IntPtr NewRotation);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ACharacter_OnUpdateSimulatedPosition(IntPtr Self, IntPtr OldLocation, IntPtr OldRotation);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Default crouched eye height
		/// </summary>
		public float CrouchedEyeHeight
		{
			get => E_Struct_ACharacter_CrouchedEyeHeight_GET(NativePointer);
			set => E_Struct_ACharacter_CrouchedEyeHeight_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Jump key Held Time.
		/// This is the time that the player has held the jump key, in seconds.
		/// </summary>
		public float JumpKeyHoldTime
		{
			get => E_Struct_ACharacter_JumpKeyHoldTime_GET(NativePointer);
			set => E_Struct_ACharacter_JumpKeyHoldTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The max time the jump key can be held.
		/// Note that if StopJumping() is not called before the max jump hold time is reached,
		/// then the character will carry on receiving vertical velocity. Therefore it is usually
		/// best to call StopJumping() when jump input has ceased (such as a button up event).
		/// </summary>
		public float JumpMaxHoldTime
		{
			get => E_Struct_ACharacter_JumpMaxHoldTime_GET(NativePointer);
			set => E_Struct_ACharacter_JumpMaxHoldTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The max number of jumps the character can perform.
		/// Note that if JumpMaxHoldTime is non zero and StopJumping is not called, the player
		/// may be able to perform and unlimited number of jumps. Therefore it is usually
		/// best to call StopJumping() when jump input has ceased (such as a button up event).
		/// </summary>
		public int JumpMaxCount
		{
			get => E_Struct_ACharacter_JumpMaxCount_GET(NativePointer);
			set => E_Struct_ACharacter_JumpMaxCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Tracks the current number of jumps performed.
		/// This is incremented in CheckJumpInput, used in CanJump_Implementation, and reset in OnMovementModeChanged.
		/// When providing overrides for these methods, it's recommended to either manually
		/// increment / reset this value, or call the Super:: method.
		/// </summary>
		public int JumpCurrentCount
		{
			get => E_Struct_ACharacter_JumpCurrentCount_GET(NativePointer);
			set => E_Struct_ACharacter_JumpCurrentCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Replicated Root Motion montage
		/// </summary>
		public FRepRootMotionMontage RepRootMotion
		{
			get => E_Struct_ACharacter_RepRootMotion_GET(NativePointer);
			set => E_Struct_ACharacter_RepRootMotion_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Cache mesh offset from capsule. This is used as the target for network smoothing interpolation, when the mesh is offset with lagged smoothing.
		/// This is automatically called during initialization; call this at runtime if you intend to change the default mesh offset from the capsule.
		/// @see GetBaseTranslationOffset(), GetBaseRotationOffset()
		/// </summary>
		public void CacheInitialMeshOffset(FVector MeshRelativeLocation, FRotator MeshRelativeRotation)
			=> E_ACharacter_CacheInitialMeshOffset(NativePointer, MeshRelativeLocation, MeshRelativeRotation);
		
		public void OnRep_ReplicatedBasedMovement()
			=> E_ACharacter_OnRep_ReplicatedBasedMovement(NativePointer);
		
		
		/// <summary>
		/// Accessor for ReplicatedServerLastTransformUpdateTimeStamp.
		/// </summary>
		public float GetReplicatedServerLastTransformUpdateTimeStamp()
			=> E_ACharacter_GetReplicatedServerLastTransformUpdateTimeStamp(NativePointer);
		
		
		/// <summary>
		/// Save a new relative location in BasedMovement and a new rotation with is either relative or absolute.
		/// </summary>
		public void SaveRelativeBasedMovement(FVector NewRelativeLocation, FRotator NewRotation, bool bRelativeRotation)
			=> E_ACharacter_SaveRelativeBasedMovement(NativePointer, NewRelativeLocation, NewRotation, bRelativeRotation);
		
		
		/// <summary>
		/// Returns ReplicatedMovementMode
		/// </summary>
		public byte GetReplicatedMovementMode()
			=> E_ACharacter_GetReplicatedMovementMode(NativePointer);
		
		
		/// <summary>
		/// Get the saved translation offset of mesh. This is how much extra offset is applied from the center of the capsule.
		/// </summary>
		public FVector GetBaseTranslationOffset()
			=> E_ACharacter_GetBaseTranslationOffset(NativePointer);
		
		
		/// <summary>
		/// Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation.
		/// </summary>
		public FQuat GetBaseRotationOffset()
			=> E_ACharacter_GetBaseRotationOffset(NativePointer);
		
		
		/// <summary>
		/// Get the saved rotation offset of mesh. This is how much extra rotation is applied from the capsule rotation.
		/// </summary>
		public FRotator GetBaseRotationOffsetRotator()
			=> E_ACharacter_GetBaseRotationOffsetRotator(NativePointer);
		
		
		/// <summary>
		/// Check if the character can jump in the current state.
		/// The default implementation may be overridden or extended by implementing the custom CanJump event in Blueprints.
		/// @Return Whether the character can jump in the current state.
		/// </summary>
		public bool CanJump()
			=> E_ACharacter_CanJump(NativePointer);
		
		
		/// <summary>
		/// Set a pending launch velocity on the Character. This velocity will be processed on the next CharacterMovementComponent tick,
		/// and will set it to the "falling" state. Triggers the OnLaunched event.
		/// @PARAM LaunchVelocity is the velocity to impart to the Character
		/// @PARAM bXYOverride if true replace the XY part of the Character's velocity instead of adding to it.
		/// @PARAM bZOverride if true replace the Z component of the Character's velocity instead of adding to it.
		/// </summary>
		public void LaunchCharacter(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
			=> E_ACharacter_LaunchCharacter(NativePointer, LaunchVelocity, bXYOverride, bZOverride);
		
		
		/// <summary>
		/// Event fired when the Character is walking off a surface and is about to fall because CharacterMovement->CurrentFloor became unwalkable.
		/// If CharacterMovement->MovementMode does not change during this event then the character will automatically start falling afterwards.
		/// @note Z velocity is zero during walking movement, and will be here as well. Another velocity can be computed here if desired and will be used when starting to fall.
		/// @param  PreviousFloorImpactNormal Normal of the previous walkable floor.
		/// @param  PreviousFloorContactNormal Normal of the contact with the previous walkable floor.
		/// @param  PreviousLocation	Previous character location before movement off the ledge.
		/// @param  TimeTick	Time delta of movement update resulting in moving off the ledge.
		/// </summary>
		public void OnWalkingOffLedge(FVector PreviousFloorImpactNormal, FVector PreviousFloorContactNormal, FVector PreviousLocation, float TimeDelta)
			=> E_ACharacter_OnWalkingOffLedge(NativePointer, PreviousFloorImpactNormal, PreviousFloorContactNormal, PreviousLocation, TimeDelta);
		
		
		/// <summary>
		/// @return true if this character is currently able to crouch (and is not currently crouched)
		/// </summary>
		public bool CanCrouch()
			=> E_ACharacter_CanCrouch(NativePointer);
		
		
		/// <summary>
		/// Called when Character stops crouching. Called on non-owned Characters through bIsCrouched replication.
		/// @param	HalfHeightAdjust		difference between default collision half-height, and actual crouched capsule half-height.
		/// @param	ScaledHalfHeightAdjust	difference after component scale is taken in to account.
		/// </summary>
		public void OnEndCrouch(float HalfHeightAdjust, float ScaledHalfHeightAdjust)
			=> E_ACharacter_OnEndCrouch(NativePointer, HalfHeightAdjust, ScaledHalfHeightAdjust);
		
		
		/// <summary>
		/// Event for implementing custom character movement mode. Called by CharacterMovement if MovementMode is set to Custom.
		/// @note C++ code should override UCharacterMovementComponent::PhysCustom() instead.
		/// @see UCharacterMovementComponent::PhysCustom()
		/// </summary>
		public void UpdateCustomMovement(float DeltaTime)
			=> E_ACharacter_K2_UpdateCustomMovement(NativePointer, DeltaTime);
		
		public void UpdateFromCompressedFlags(byte Flags)
			=> E_ACharacter_UpdateFromCompressedFlags(NativePointer, Flags);
		
		
		/// <summary>
		/// Restore actor to an old buffered move.
		/// </summary>
		public bool RestoreReplicatedMove(FSimulatedRootMotionReplicatedMove RootMotionRepMove)
			=> E_ACharacter_RestoreReplicatedMove(NativePointer, RootMotionRepMove);
		
		public void UpdateSimulatedPosition(FVector Location, FRotator NewRotation)
			=> E_ACharacter_UpdateSimulatedPosition(NativePointer, Location, NewRotation);
		
		
		/// <summary>
		/// Called on client after position update is received to respond to the new location and rotation.
		/// Actual change in location is expected to occur in CharacterMovement->SmoothCorrection(), after which this occurs.
		/// Default behavior is to check for penetration in a blocking object if bClientCheckEncroachmentOnNetUpdate is enabled, and set bSimGravityDisabled=true if so.
		/// </summary>
		public void OnUpdateSimulatedPosition(FVector OldLocation, FQuat OldRotation)
			=> E_ACharacter_OnUpdateSimulatedPosition(NativePointer, OldLocation, OldRotation);
		
		#endregion
		
		public static implicit operator IntPtr(ACharacter Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ACharacter(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new ACharacter(Adress);
		}}}
