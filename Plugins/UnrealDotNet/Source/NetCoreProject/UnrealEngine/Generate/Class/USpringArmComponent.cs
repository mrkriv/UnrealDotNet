using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// This component tries to maintain its children at a fixed distance from the parent,
	/// but will retract the children if there is a collision, and spring back when there is no collision.
	/// Example: Use as a 'camera boom' to keep the follow camera for a player from colliding into the world.
	/// </summary>
	public partial class USpringArmComponent : USceneComponent
	{
		public USpringArmComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_USpringArmComponent_RelativeSocketLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USpringArmComponent_RelativeSocketLocation_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FQuat E_PROP_USpringArmComponent_RelativeSocketRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USpringArmComponent_RelativeSocketRotation_SET(IntPtr Ptr, FQuat Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_USpringArmComponent_bUseControllerViewRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USpringArmComponent_bUseControllerViewRotation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USpringArmComponent_UpdateDesiredArmLocation(IntPtr Self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USpringArmComponent_BlendLocations(IntPtr Self, IntPtr DesiredArmLocation, IntPtr TraceHitLocation, bool bHitSomething, float DeltaTime);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Cached component-space socket location
		/// </summary>
		protected FVector RelativeSocketLocation
		{
			get => E_PROP_USpringArmComponent_RelativeSocketLocation_GET(NativePointer);
			set => E_PROP_USpringArmComponent_RelativeSocketLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Cached component-space socket rotation
		/// </summary>
		protected FQuat RelativeSocketRotation
		{
			get => E_PROP_USpringArmComponent_RelativeSocketRotation_GET(NativePointer);
			set => E_PROP_USpringArmComponent_RelativeSocketRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// DEPRECATED variable: use "bUsePawnControlRotation" instead. Existing code using this value may not behave correctly.
		/// This is not a UPROPERTY, with good reason: we don't want to serialize in old values.
		/// </summary>
		public bool bUseControllerViewRotation
		{
			get => E_PROP_USpringArmComponent_bUseControllerViewRotation_GET(NativePointer);
			set => E_PROP_USpringArmComponent_bUseControllerViewRotation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Updates the desired arm location, calling BlendLocations to do the actual blending if a trace is done
		/// </summary>
		protected void UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
			=> E_USpringArmComponent_UpdateDesiredArmLocation(NativePointer, bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
		
		
		/// <summary>
		/// This function allows subclasses to blend the trace hit location with the desired arm location;
		/// by default it returns bHitSomething ? TraceHitLocation : DesiredArmLocation
		/// </summary>
		protected FVector BlendLocations(FVector DesiredArmLocation, FVector TraceHitLocation, bool bHitSomething, float DeltaTime)
			=> E_USpringArmComponent_BlendLocations(NativePointer, DesiredArmLocation, TraceHitLocation, bHitSomething, DeltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(USpringArmComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USpringArmComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new USpringArmComponent(Adress);
		}}}
