// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

namespace UnrealEngine
{
	public  partial class USpringArmComponent : USceneComponent
	{
		public USpringArmComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USpringArmComponent(UObject Parent = null, string Name = "SpringArmComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USpringArmComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_USpringArmComponent_bIsCameraFixed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_bIsCameraFixed_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USpringArmComponent_CameraLagMaxDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_CameraLagMaxDistance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USpringArmComponent_CameraLagMaxTimeStep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_CameraLagMaxTimeStep_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USpringArmComponent_CameraLagSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_CameraLagSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USpringArmComponent_CameraRotationLagSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_CameraRotationLagSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USpringArmComponent_PreviousArmOrigin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_PreviousArmOrigin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USpringArmComponent_PreviousDesiredLoc_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_PreviousDesiredLoc_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USpringArmComponent_PreviousDesiredRot_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_PreviousDesiredRot_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USpringArmComponent_ProbeSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_ProbeSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USpringArmComponent_SocketOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_SocketOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USpringArmComponent_TargetArmLength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_TargetArmLength_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USpringArmComponent_TargetOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_TargetOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USpringArmComponent_UnfixedCameraPosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_UnfixedCameraPosition_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USpringArmComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USpringArmComponent_BlendLocations(IntPtr self, IntPtr desiredArmLocation, IntPtr traceHitLocation, bool bHitSomething, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USpringArmComponent_GetTargetRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USpringArmComponent_GetUnfixedCameraPosition(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USpringArmComponent_IsCollisionFixApplied(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USpringArmComponent_UpdateDesiredArmLocation(IntPtr self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float deltaTime);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Temporary variables when applying Collision Test displacement to notify if its being applied and by how much
		/// </summary>
		public bool bIsCameraFixed
		{
			get => E_PROP_USpringArmComponent_bIsCameraFixed_GET(NativePointer);
			set => E_PROP_USpringArmComponent_bIsCameraFixed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max distance the camera target may lag behind the current location. If set to zero, no max distance is enforced.
		/// </summary>
		public float CameraLagMaxDistance
		{
			get => E_PROP_USpringArmComponent_CameraLagMaxDistance_GET(NativePointer);
			set => E_PROP_USpringArmComponent_CameraLagMaxDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max time step used when sub-stepping camera lag.
		/// </summary>
		public float CameraLagMaxTimeStep
		{
			get => E_PROP_USpringArmComponent_CameraLagMaxTimeStep_GET(NativePointer);
			set => E_PROP_USpringArmComponent_CameraLagMaxTimeStep_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If bEnableCameraLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).
		/// </summary>
		public float CameraLagSpeed
		{
			get => E_PROP_USpringArmComponent_CameraLagSpeed_GET(NativePointer);
			set => E_PROP_USpringArmComponent_CameraLagSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If bEnableCameraRotationLag is true, controls how quickly camera reaches target position. Low values are slower (more lag), high values are faster (less lag), while zero is instant (no lag).
		/// </summary>
		public float CameraRotationLagSpeed
		{
			get => E_PROP_USpringArmComponent_CameraRotationLagSpeed_GET(NativePointer);
			set => E_PROP_USpringArmComponent_CameraRotationLagSpeed_SET(NativePointer, value);
		}

		public FVector PreviousArmOrigin
		{
			get => E_PROP_USpringArmComponent_PreviousArmOrigin_GET(NativePointer);
			set => E_PROP_USpringArmComponent_PreviousArmOrigin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Temporary variables when using camera lag, to record previous camera position
		/// </summary>
		public FVector PreviousDesiredLoc
		{
			get => E_PROP_USpringArmComponent_PreviousDesiredLoc_GET(NativePointer);
			set => E_PROP_USpringArmComponent_PreviousDesiredLoc_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Temporary variable for lagging camera rotation, for previous rotation
		/// </summary>
		public FRotator PreviousDesiredRot
		{
			get => E_PROP_USpringArmComponent_PreviousDesiredRot_GET(NativePointer);
			set => E_PROP_USpringArmComponent_PreviousDesiredRot_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How big should the query probe sphere be (in unreal units)
		/// </summary>
		public float ProbeSize
		{
			get => E_PROP_USpringArmComponent_ProbeSize_GET(NativePointer);
			set => E_PROP_USpringArmComponent_ProbeSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// offset at end of spring arm; use this instead of the relative offset of the attached component to ensure the line trace works as desired
		/// </summary>
		public FVector SocketOffset
		{
			get => E_PROP_USpringArmComponent_SocketOffset_GET(NativePointer);
			set => E_PROP_USpringArmComponent_SocketOffset_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Natural length of the spring arm when there are no collisions
		/// </summary>
		public float TargetArmLength
		{
			get => E_PROP_USpringArmComponent_TargetArmLength_GET(NativePointer);
			set => E_PROP_USpringArmComponent_TargetArmLength_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Offset at start of spring, applied in world space. Use this if you want a world-space offset from the parent component instead of the usual relative-space offset.
		/// </summary>
		public FVector TargetOffset
		{
			get => E_PROP_USpringArmComponent_TargetOffset_GET(NativePointer);
			set => E_PROP_USpringArmComponent_TargetOffset_SET(NativePointer, value);
		}

		public FVector UnfixedCameraPosition
		{
			get => E_PROP_USpringArmComponent_UnfixedCameraPosition_GET(NativePointer);
			set => E_PROP_USpringArmComponent_UnfixedCameraPosition_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// This function allows subclasses to blend the trace hit location with the desired arm location;
		/// <para>by default it returns bHitSomething ? TraceHitLocation : DesiredArmLocation </para>
		/// </summary>
		protected virtual FVector BlendLocations(FVector desiredArmLocation, FVector traceHitLocation, bool bHitSomething, float deltaTime)
			=> E_USpringArmComponent_BlendLocations(this, desiredArmLocation, traceHitLocation, bHitSomething, deltaTime);
		
		
		/// <summary>
		/// Get the target rotation we inherit, used as the base target for the boom rotation.
		/// <para>This is derived from attachment to our parent and considering the UsePawnControlRotation and absolute rotation flags. </para>
		/// </summary>
		public FRotator GetTargetRotation()
			=> E_USpringArmComponent_GetTargetRotation(this);
		
		
		/// <summary>
		/// Get the position where the camera should be without applying the Collision Test displacement
		/// </summary>
		public FVector GetUnfixedCameraPosition()
			=> E_USpringArmComponent_GetUnfixedCameraPosition(this);
		
		
		/// <summary>
		/// Is the Collision Test displacement being applied?
		/// </summary>
		public bool IsCollisionFixApplied()
			=> E_USpringArmComponent_IsCollisionFixApplied(this);
		
		
		/// <summary>
		/// Updates the desired arm location, calling BlendLocations to do the actual blending if a trace is done
		/// </summary>
		protected virtual void UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float deltaTime)
			=> E_USpringArmComponent_UpdateDesiredArmLocation(this, bDoTrace, bDoLocationLag, bDoRotationLag, deltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(USpringArmComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator USpringArmComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USpringArmComponent>(PtrDesc);
		}}}
