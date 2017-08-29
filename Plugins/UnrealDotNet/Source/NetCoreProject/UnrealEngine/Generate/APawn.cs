using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Pawn is the base class of all actors that can be possessed by players or AI.
	/// They are the physical representations of players and creatures in a level.
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/Framework/Pawn
	/// </summary>
	public partial class APawn : AActor
	{
		public APawn(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_APawn_BaseEyeHeight_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_APawn_BaseEyeHeight_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern byte E_Struct_APawn_RemoteViewPitch_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_APawn_RemoteViewPitch_SET(IntPtr Ptr, byte Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_APawn_AllowedYawError_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_APawn_AllowedYawError_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_Struct_APawn_ControlInputVector_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_APawn_ControlInputVector_SET(IntPtr Ptr, FVector Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_Struct_APawn_LastControlInputVector_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_APawn_LastControlInputVector_SET(IntPtr Ptr, FVector Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_PawnMakeNoise(IntPtr Self, float Loudness, IntPtr NoiseLocation, bool bUseNoiseMakerLocation, AActor NoiseMaker);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_TurnOff(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_PawnStartFire(IntPtr Self, byte FireModeNum);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_SetRemoteViewPitch(IntPtr Self, float NewRemoteViewPitch);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern AActor E_APawn_GetMovementBaseActor(IntPtr Self, APawn Pawn);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_APawn_ReachedDesiredRotation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_APawn_GetDefaultHalfHeight(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_APawn_IsControlled(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_APawn_GetControlRotation(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_SetCanAffectNavigationGeneration(IntPtr Self, bool bNewValue, bool bForceUpdate);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_APawn_GetGravityDirection(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_FaceRotation(IntPtr Self, IntPtr NewControlRotation, float DeltaTime);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_AddMovementInput(IntPtr Self, IntPtr WorldDirection, float ScaleValue, bool bForce);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_Internal_AddMovementInput(IntPtr Self, IntPtr WorldAccel, bool bForce);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_MoveIgnoreActorAdd(IntPtr Self, AActor ActorToIgnore);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_ClientSetRotation(IntPtr Self, IntPtr NewRotation);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_APawn_LaunchPawn(IntPtr Self, IntPtr LaunchVelocity, bool bXYOverride, bool bZOverride);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Base eye height above collision center.
		/// </summary>
		public float BaseEyeHeight
		{
			get => E_Struct_APawn_BaseEyeHeight_GET(NativePointer);
			set => E_Struct_APawn_BaseEyeHeight_SET(NativePointer, value);
		}

		public byte RemoteViewPitch
		{
			get => E_Struct_APawn_RemoteViewPitch_GET(NativePointer);
			set => E_Struct_APawn_RemoteViewPitch_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max difference between pawn's Rotation.Yaw and GetDesiredRotation().Yaw for pawn to be considered as having reached its desired rotation
		/// </summary>
		public float AllowedYawError
		{
			get => E_Struct_APawn_AllowedYawError_GET(NativePointer);
			set => E_Struct_APawn_AllowedYawError_SET(NativePointer, value);
		}

		protected FVector ControlInputVector
		{
			get => E_Struct_APawn_ControlInputVector_GET(NativePointer);
			set => E_Struct_APawn_ControlInputVector_SET(NativePointer, value);
		}

		protected FVector LastControlInputVector
		{
			get => E_Struct_APawn_LastControlInputVector_GET(NativePointer);
			set => E_Struct_APawn_LastControlInputVector_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Inform AIControllers that you've made a noise they might hear (they are sent a HearNoise message if they have bHearNoises==true)
		/// The instigator of this sound is the pawn which is used to call MakeNoise.
		/// @param Loudness - is the relative loudness of this noise (range 0.0 to 1.0).  Directly affects the hearing range specified by the AI's HearingThreshold.
		/// @param NoiseLocation - Position of noise source.  If zero vector, use the actor's location.
		/// @param bUseNoiseMakerLocation - If true, use the location of the NoiseMaker rather than NoiseLocation.  If false, use NoiseLocation.
		/// @param NoiseMaker - Which actor is the source of the noise.  Not to be confused with the Noise Instigator, which is responsible for the noise (and is the pawn on which this function is called).  If not specified, the pawn instigating the noise will be used as the NoiseMaker
		/// </summary>
		public void PawnMakeNoise(float Loudness, FVector NoiseLocation, bool bUseNoiseMakerLocation = true, AActor NoiseMaker = null)
			=> E_APawn_PawnMakeNoise(NativePointer, Loudness, NoiseLocation, bUseNoiseMakerLocation, NoiseMaker);
		
		
		/// <summary>
		/// Freeze pawn - stop sounds, animations, physics, weapon firing
		/// </summary>
		public void TurnOff()
			=> E_APawn_TurnOff(NativePointer);
		
		
		/// <summary>
		/// Handle StartFire() passed from PlayerController
		/// </summary>
		public void PawnStartFire(byte FireModeNum = 0)
			=> E_APawn_PawnStartFire(NativePointer, FireModeNum);
		
		
		/// <summary>
		/// Set Pawn ViewPitch, so we can see where remote clients are looking.
		/// Maps 360.0 degrees into a byte
		/// @param	NewRemoteViewPitch	Pitch component to replicate to remote (non owned) clients.
		/// </summary>
		public void SetRemoteViewPitch(float NewRemoteViewPitch)
			=> E_APawn_SetRemoteViewPitch(NativePointer, NewRemoteViewPitch);
		
		
		/// <summary>
		/// Gets the owning actor of the Movement Base Component on which the pawn is standing.
		/// </summary>
		public AActor GetMovementBaseActor(APawn Pawn)
			=> E_APawn_GetMovementBaseActor(NativePointer, Pawn);
		
		public bool ReachedDesiredRotation()
			=> E_APawn_ReachedDesiredRotation(NativePointer);
		
		
		/// <summary>
		/// @return The half-height of the default Pawn, scaled by the component scale. By default returns the half-height of the RootComponent, regardless of whether it is registered or collidable.
		/// </summary>
		public float GetDefaultHalfHeight()
			=> E_APawn_GetDefaultHalfHeight(NativePointer);
		
		
		/// <summary>
		/// See if this actor is currently being controlled
		/// </summary>
		public bool IsControlled()
			=> E_APawn_IsControlled(NativePointer);
		
		
		/// <summary>
		/// Get the rotation of the Controller, often the 'view' rotation of this Pawn.
		/// </summary>
		public FRotator GetControlRotation()
			=> E_APawn_GetControlRotation(NativePointer);
		
		
		/// <summary>
		/// Use SetCanAffectNavigationGeneration to change this value at runtime.
		/// Note that calling this function at runtime will result in any navigation change only if runtime navigation generation is enabled.
		/// </summary>
		public void SetCanAffectNavigationGeneration(bool bNewValue, bool bForceUpdate = false)
			=> E_APawn_SetCanAffectNavigationGeneration(NativePointer, bNewValue, bForceUpdate);
		
		
		/// <summary>
		/// @return vector direction of gravity
		/// </summary>
		public FVector GetGravityDirection()
			=> E_APawn_GetGravityDirection(NativePointer);
		
		
		/// <summary>
		/// Updates Pawn's rotation to the given rotation, assumed to be the Controller's ControlRotation. Respects the bUseControllerRotation* settings.
		/// </summary>
		public void FaceRotation(FRotator NewControlRotation, float DeltaTime)
			=> E_APawn_FaceRotation(NativePointer, NewControlRotation, DeltaTime);
		
		
		/// <summary>
		/// Add movement input along the given world direction vector (usually normalized) scaled by 'ScaleValue'. If ScaleValue < 0, movement will be in the opposite direction.
		/// Base Pawn classes won't automatically apply movement, it's up to the user to do so in a Tick event. Subclasses such as Character and DefaultPawn automatically handle this input and move.
		/// @param WorldDirection	Direction in world space to apply input
		/// @param ScaleValue		Scale to apply to input. This can be used for analog input, ie a value of 0.5 applies half the normal value, while -1.0 would reverse the direction.
		/// @param bForce			If true always add the input, ignoring the result of IsMoveInputIgnored().
		/// @see GetPendingMovementInputVector(), GetLastMovementInputVector(), ConsumeMovementInputVector()
		/// </summary>
		public void AddMovementInput(FVector WorldDirection, float ScaleValue, bool bForce = false)
			=> E_APawn_AddMovementInput(NativePointer, WorldDirection, ScaleValue, bForce);
		
		
		/// <summary>
		/// Internal function meant for use only within Pawn or by a PawnMovementComponent. Adds movement input if not ignored, or if forced.
		/// </summary>
		public void Internal_AddMovementInput(FVector WorldAccel, bool bForce = false)
			=> E_APawn_Internal_AddMovementInput(NativePointer, WorldAccel, bForce);
		
		
		/// <summary>
		/// Add an Actor to ignore by Pawn's movement collision
		/// </summary>
		public void MoveIgnoreActorAdd(AActor ActorToIgnore)
			=> E_APawn_MoveIgnoreActorAdd(NativePointer, ActorToIgnore);
		
		
		/// <summary>
		/// Deprecated, misleading name and redundant
		/// </summary>
		public void ClientSetRotation(FRotator NewRotation)
			=> E_APawn_ClientSetRotation(NativePointer, NewRotation);
		
		
		/// <summary>
		/// (Deprecated) Launch Character with LaunchVelocity
		/// </summary>
		public void LaunchPawn(FVector LaunchVelocity, bool bXYOverride, bool bZOverride)
			=> E_APawn_LaunchPawn(NativePointer, LaunchVelocity, bXYOverride, bZOverride);
		
		#endregion
		
		public static implicit operator IntPtr(APawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator APawn(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new APawn(Adress);
		}}}
