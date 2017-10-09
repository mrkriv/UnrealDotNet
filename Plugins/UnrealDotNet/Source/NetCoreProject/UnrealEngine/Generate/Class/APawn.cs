using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class APawn : AActor
	{
		public APawn(IntPtr Adress)
			: base(Adress)
		{
		}

		public APawn(UObject Parent = null, string Name = "Pawn")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_APawn(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_APawn(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APawn_AllowedYawError_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_AllowedYawError_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APawn_AutoPossessAI_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_AutoPossessAI_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APawn_BaseEyeHeight_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_BaseEyeHeight_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APawn_RemoteViewPitch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APawn_RemoteViewPitch_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_AddControllerPitchInput(IntPtr Self, float Val);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_AddControllerRollInput(IntPtr Self, float Val);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_AddControllerYawInput(IntPtr Self, float Val);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_AddMovementInput(IntPtr Self, IntPtr WorldDirection, float ScaleValue, bool bForce);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_ClientSetRotation(IntPtr Self, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_ConsumeMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_DestroyPlayerInputComponent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_DetachFromControllerPendingDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_FaceRotation(IntPtr Self, IntPtr NewControlRotation, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetBaseAimRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetControlRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_APawn_GetDefaultHalfHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetGravityDirection(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetLastMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetPawnViewLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetPendingMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_GetViewRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_InFreeCam(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_InputEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_Internal_AddMovementInput(IntPtr Self, IntPtr WorldAccel, bool bForce);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_Internal_ConsumeMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_Internal_GetLastMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_Internal_GetMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_Internal_GetPendingMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_IsControlled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_IsLocallyControlled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_IsMoveInputIgnored(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_IsPlayerControlled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_APawn_K2_GetMovementInputVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_LaunchPawn(IntPtr Self, IntPtr LaunchVelocity, bool bXYOverride, bool bZOverride);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_OnRep_Controller(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_OnRep_PlayerState(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_PawnClientRestart(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_PawnStartFire(IntPtr Self, byte FireModeNum);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APawn_ReachedDesiredRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_RecalculateBaseEyeHeight(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_Restart(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SetCanAffectNavigationGeneration(IntPtr Self, bool bNewValue, bool bForceUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SetPlayerDefaults(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SetRemoteViewPitch(IntPtr Self, float NewRemoteViewPitch);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_SpawnDefaultController(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_TurnOff(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_UnPossessed(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_UpdateNavAgent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APawn_UpdateNavigationRelevance(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Max difference between pawn's Rotation.Yaw and GetDesiredRotation().Yaw for pawn to be considered as having reached its desired rotation </para>
		/// </summary>
		public float AllowedYawError
		{
			get => E_PROP_APawn_AllowedYawError_GET(NativePointer);
			set => E_PROP_APawn_AllowedYawError_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Determines when the Pawn creates and is possessed by an AI Controller (on level start, when spawned, etc). </para>
		/// <para>Only possible if AIControllerClass is set, and ignored if AutoPossessPlayer is enabled. </para>
		/// <para>@see AutoPossessPlayer </para>
		/// </summary>
		public EAutoPossessAI AutoPossessAI
		{
			get => (EAutoPossessAI)E_PROP_APawn_AutoPossessAI_GET(NativePointer);
			set => E_PROP_APawn_AutoPossessAI_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Base eye height above collision center. </para>
		/// </summary>
		public float BaseEyeHeight
		{
			get => E_PROP_APawn_BaseEyeHeight_GET(NativePointer);
			set => E_PROP_APawn_BaseEyeHeight_SET(NativePointer, value);
		}

		public byte RemoteViewPitch
		{
			get => E_PROP_APawn_RemoteViewPitch_GET(NativePointer);
			set => E_PROP_APawn_RemoteViewPitch_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add input (affecting Pitch) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputPitchScale value. </para>
		/// <param name="Val">Amount to add to Pitch. This value is multiplied by the PlayerController's InputPitchScale value. </param>
		/// <para>@see PlayerController::InputPitchScale </para>
		/// </summary>
		public virtual void AddControllerPitchInput(float Val)
			=> E_APawn_AddControllerPitchInput(this, Val);
		
		
		/// <summary>
		/// <para>Add input (affecting Roll) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputRollScale value. </para>
		/// <param name="Val">Amount to add to Roll. This value is multiplied by the PlayerController's InputRollScale value. </param>
		/// <para>@see PlayerController::InputRollScale </para>
		/// </summary>
		public virtual void AddControllerRollInput(float Val)
			=> E_APawn_AddControllerRollInput(this, Val);
		
		
		/// <summary>
		/// <para>Add input (affecting Yaw) to the Controller's ControlRotation, if it is a local PlayerController. </para>
		/// <para>This value is multiplied by the PlayerController's InputYawScale value. </para>
		/// <param name="Val">Amount to add to Yaw. This value is multiplied by the PlayerController's InputYawScale value. </param>
		/// <para>@see PlayerController::InputYawScale </para>
		/// </summary>
		public virtual void AddControllerYawInput(float Val)
			=> E_APawn_AddControllerYawInput(this, Val);
		
		
		/// <summary>
		/// <para>Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'. If ScaleValue < 0, movement will be in the opposite direction. </para>
		/// <para>Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move. </para>
		/// <param name="WorldDirection">Direction in world space to apply input </param>
		/// <param name="ScaleValue">Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction. </param>
		/// <param name="bForce">If true always add the input, ignoring the result of IsMoveInputIgnored(). </param>
		/// <para>@see GetPendingMovementInputVector(), GetLastMovementInputVector(), ConsumeMovementInputVector() </para>
		/// </summary>
		public virtual void AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce)
			=> E_APawn_AddMovementInput(this, WorldDirection, ScaleValue, bForce);
		
		
		/// <summary>
		/// <para>Deprecated, misleading name and redundant </para>
		/// </summary>
		public virtual void ClientSetRotation(FRotator NewRotation)
			=> E_APawn_ClientSetRotation(this, NewRotation);
		
		
		/// <summary>
		/// <para>Returns the pending input vector and resets it to zero. </para>
		/// <para>This should be used during a movement update (by the Pawn or PawnMovementComponent) to prevent accumulation of control input between frames. </para>
		/// <para>Copies the pending input vector to the saved input vector (GetLastMovementInputVector()). </para>
		/// <return>The pending input vector. </return>
		/// </summary>
		public virtual FVector ConsumeMovementInputVector()
			=> E_APawn_ConsumeMovementInputVector(this);
		
		
		/// <summary>
		/// <para>Destroys the player input component and removes any references to it. </para>
		/// </summary>
		protected virtual void DestroyPlayerInputComponent()
			=> E_APawn_DestroyPlayerInputComponent(this);
		
		
		/// <summary>
		/// <para>Call this function to detach safely pawn from its controller, knowing that we will be destroyed soon. </para>
		/// </summary>
		public virtual void DetachFromControllerPendingDestroy()
			=> E_APawn_DetachFromControllerPendingDestroy(this);
		
		
		/// <summary>
		/// <para>Updates Pawn's rotation to the given rotation, assumed to be the Controller's ControlRotation. Respects the bUseControllerRotation* settings. </para>
		/// </summary>
		public virtual void FaceRotation(FRotator NewControlRotation, float DeltaTime)
			=> E_APawn_FaceRotation(this, NewControlRotation, DeltaTime);
		
		
		/// <summary>
		/// <para>Return the aim rotation for the Pawn. </para>
		/// <para>If we have a controller, by default we aim at the player's 'eyes' direction </para>
		/// <para>that is by default the Pawn rotation for AI, and camera (crosshair) rotation for human players. </para>
		/// </summary>
		public virtual FRotator GetBaseAimRotation()
			=> E_APawn_GetBaseAimRotation(this);
		
		
		/// <summary>
		/// <para>Get the rotation of the Controller, often the 'view' rotation of this Pawn. </para>
		/// </summary>
		public FRotator GetControlRotation()
			=> E_APawn_GetControlRotation(this);
		
		
		/// <summary>
		/// <return>The half-height of the default Pawn, scaled by the component scale. By default returns the half-height of the RootComponent, regardless of whether it is registered or collidable. </return>
		/// </summary>
		public virtual float GetDefaultHalfHeight()
			=> E_APawn_GetDefaultHalfHeight(this);
		
		
		/// <summary>
		/// <return>vector direction of gravity </return>
		/// </summary>
		public FVector GetGravityDirection()
			=> E_APawn_GetGravityDirection(this);
		
		
		/// <summary>
		/// <para>Return the last input vector in world space that was processed by ConsumeMovementInputVector(), which is usually done by the Pawn or PawnMovementComponent. </para>
		/// <para>Any user that needs to know about the input that last affected movement should use this function. </para>
		/// <para>For example an animation update would want to use this, since by default the order of updates in a frame is: </para>
		/// <para>PlayerController (device input) -> MovementComponent -> Pawn -> Mesh (animations) </para>
		/// <return>The last input vector in world space that was processed by ConsumeMovementInputVector(). </return>
		/// <para>@see AddMovementInput(), GetPendingMovementInputVector(), ConsumeMovementInputVector() </para>
		/// </summary>
		public FVector GetLastMovementInputVector()
			=> E_APawn_GetLastMovementInputVector(this);
		
		
		/// <summary>
		/// <para>(Deprecated) Return the input vector in world space. </para>
		/// </summary>
		public FVector GetMovementInputVector()
			=> E_APawn_GetMovementInputVector(this);
		
		
		/// <summary>
		/// <return>Pawn's eye location </return>
		/// </summary>
		public virtual FVector GetPawnViewLocation()
			=> E_APawn_GetPawnViewLocation(this);
		
		
		/// <summary>
		/// <para>Return the pending input vector in world space. This is the most up-to-date value of the input vector, pending ConsumeMovementInputVector() which clears it, </para>
		/// <para>Usually only a PawnMovementComponent will want to read this value, or the Pawn itself if it is responsible for movement. </para>
		/// <return>The pending input vector in world space. </return>
		/// <para>@see AddMovementInput(), GetLastMovementInputVector(), ConsumeMovementInputVector() </para>
		/// </summary>
		public FVector GetPendingMovementInputVector()
			=> E_APawn_GetPendingMovementInputVector(this);
		
		
		/// <summary>
		/// <para>Get the view rotation of the Pawn (direction they are looking, normally Controller->ControlRotation). </para>
		/// <return>The view rotation of the Pawn. </return>
		/// </summary>
		public virtual FRotator GetViewRotation()
			=> E_APawn_GetViewRotation(this);
		
		
		/// <summary>
		/// <para>return true if player is viewing this Pawn in FreeCam </para>
		/// </summary>
		public virtual bool InFreeCam()
			=> E_APawn_InFreeCam(this);
		
		public bool InputEnabled()
			=> E_APawn_InputEnabled(this);
		
		
		/// <summary>
		/// <para>Internal function meant for use only within Pawn or by a PawnMovementComponent. Adds movement input if not ignored, or if forced. </para>
		/// </summary>
		public void Internal_AddMovementInput(FVector WorldAccel, bool bForce = false)
			=> E_APawn_Internal_AddMovementInput(this, WorldAccel, bForce);
		
		
		/// <summary>
		/// <para>Internal function meant for use only within Pawn or by a PawnMovementComponent. LastControlInputVector is updated with initial value of ControlInputVector. Returns ControlInputVector and resets it to zero. </para>
		/// </summary>
		public FVector Internal_ConsumeMovementInputVector()
			=> E_APawn_Internal_ConsumeMovementInputVector(this);
		
		
		/// <summary>
		/// <para>Internal function meant for use only within Pawn or by a PawnMovementComponent. Returns the value of LastControlInputVector. </para>
		/// </summary>
		public FVector Internal_GetLastMovementInputVector()
			=> E_APawn_Internal_GetLastMovementInputVector(this);
		
		
		/// <summary>
		/// <para>Internal function meant for use only within Pawn or by a PawnMovementComponent. </para>
		/// </summary>
		public FVector Internal_GetMovementInputVector()
			=> E_APawn_Internal_GetMovementInputVector(this);
		
		
		/// <summary>
		/// <para>Internal function meant for use only within Pawn or by a PawnMovementComponent. Returns the value of ControlInputVector. </para>
		/// </summary>
		public FVector Internal_GetPendingMovementInputVector()
			=> E_APawn_Internal_GetPendingMovementInputVector(this);
		
		
		/// <summary>
		/// <para>See if this actor is currently being controlled </para>
		/// </summary>
		public bool IsControlled()
			=> E_APawn_IsControlled(this);
		
		
		/// <summary>
		/// <return>true if controlled by a local (not network) Controller. </return>
		/// </summary>
		public virtual bool IsLocallyControlled()
			=> E_APawn_IsLocallyControlled(this);
		
		
		/// <summary>
		/// <para>Helper to see if move input is ignored. If our controller is a PlayerController, checks Controller->IsMoveInputIgnored(). </para>
		/// </summary>
		public virtual bool IsMoveInputIgnored()
			=> E_APawn_IsMoveInputIgnored(this);
		
		
		/// <summary>
		/// <return>true if controlled by a human player (possessed by a PlayerController). </return>
		/// </summary>
		public virtual bool IsPlayerControlled()
			=> E_APawn_IsPlayerControlled(this);
		
		
		/// <summary>
		/// <para>(Deprecated) Return the input vector in world space. </para>
		/// </summary>
		public FVector K2_GetMovementInputVector()
			=> E_APawn_K2_GetMovementInputVector(this);
		
		
		/// <summary>
		/// <para>(Deprecated) Launch Character with LaunchVelocity </para>
		/// </summary>
		public void LaunchPawn(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
			=> E_APawn_LaunchPawn(this, LaunchVelocity, bXYOverride, bZOverride);
		
		public virtual void OnRep_Controller()
			=> E_APawn_OnRep_Controller(this);
		
		public virtual void OnRep_PlayerState()
			=> E_APawn_OnRep_PlayerState(this);
		
		
		/// <summary>
		/// <para>Tell client that the Pawn is begin restarted. Calls Restart(). </para>
		/// </summary>
		public virtual void PawnClientRestart()
			=> E_APawn_PawnClientRestart(this);
		
		
		/// <summary>
		/// <para>Handle StartFire() passed from PlayerController </para>
		/// </summary>
		public virtual void PawnStartFire(byte FireModeNum)
			=> E_APawn_PawnStartFire(this, FireModeNum);
		
		public virtual bool ReachedDesiredRotation()
			=> E_APawn_ReachedDesiredRotation(this);
		
		
		/// <summary>
		/// <para>Set BaseEyeHeight based on current state. </para>
		/// </summary>
		public virtual void RecalculateBaseEyeHeight()
			=> E_APawn_RecalculateBaseEyeHeight(this);
		
		
		/// <summary>
		/// <para>Called when the Pawn is being restarted (usually by being possessed by a Controller). </para>
		/// </summary>
		public virtual void Restart()
			=> E_APawn_Restart(this);
		
		
		/// <summary>
		/// <para>Use SetCanAffectNavigationGeneration to change this value at runtime. </para>
		/// <para>Note that calling this function at runtime will result in any navigation change only if runtime navigation generation is enabled. </para>
		/// </summary>
		public void SetCanAffectNavigationGeneration(bool bNewValue, bool bForceUpdate = false)
			=> E_APawn_SetCanAffectNavigationGeneration(this, bNewValue, bForceUpdate);
		
		
		/// <summary>
		/// <para>Make sure pawn properties are back to default. </para>
		/// </summary>
		public virtual void SetPlayerDefaults()
			=> E_APawn_SetPlayerDefaults(this);
		
		
		/// <summary>
		/// <para>Set Pawn ViewPitch, so we can see where remote clients are looking. </para>
		/// <para>Maps 360.0 degrees into a byte </para>
		/// <param name="NewRemoteViewPitch">Pitch component to replicate to remote (non owned) clients. </param>
		/// </summary>
		public void SetRemoteViewPitch(float NewRemoteViewPitch)
			=> E_APawn_SetRemoteViewPitch(this, NewRemoteViewPitch);
		
		
		/// <summary>
		/// <para>Spawn default controller for this Pawn, and get possessed by it. </para>
		/// </summary>
		public virtual void SpawnDefaultController()
			=> E_APawn_SpawnDefaultController(this);
		
		
		/// <summary>
		/// <para>Freeze pawn - stop sounds, animations, physics, weapon firing </para>
		/// </summary>
		public virtual void TurnOff()
			=> E_APawn_TurnOff(this);
		
		
		/// <summary>
		/// <para>Called when our Controller no longer possesses us. </para>
		/// </summary>
		public virtual void UnPossessed()
			=> E_APawn_UnPossessed(this);
		
		
		/// <summary>
		/// <para>updates MovementComponent's parameters used by navigation system </para>
		/// </summary>
		public void UpdateNavAgent()
			=> E_APawn_UpdateNavAgent(this);
		
		
		/// <summary>
		/// <para>update all components relevant for navigation generators to match bCanAffectNavigationGeneration flag </para>
		/// </summary>
		public virtual void UpdateNavigationRelevance()
			=> E_APawn_UpdateNavigationRelevance(this);
		
		#endregion
		
		public static implicit operator IntPtr(APawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator APawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<APawn>(PtrDesc);
		}}}
