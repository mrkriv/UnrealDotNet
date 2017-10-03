using System;
using System.Runtime.InteropServices;

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USpringArmComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_USpringArmComponent_bUseControllerViewRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_bUseControllerViewRotation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USpringArmComponent_RelativeSocketLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_RelativeSocketLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_USpringArmComponent_RelativeSocketRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USpringArmComponent_RelativeSocketRotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USpringArmComponent_BlendLocations(IntPtr Self, IntPtr DesiredArmLocation, IntPtr TraceHitLocation, bool bHitSomething, float DeltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USpringArmComponent_UpdateDesiredArmLocation(IntPtr Self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>DEPRECATED variable: use "bUsePawnControlRotation" instead. Existing code using this value may not behave correctly. </para>
		/// <para>This is not a UPROPERTY, with good reason: we don't want to serialize in old values. </para>
		/// </summary>
		public bool bUseControllerViewRotation
		{
			get => E_PROP_USpringArmComponent_bUseControllerViewRotation_GET(NativePointer);
			set => E_PROP_USpringArmComponent_bUseControllerViewRotation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Cached component-space socket location </para>
		/// </summary>
		protected FVector RelativeSocketLocation
		{
			get => E_PROP_USpringArmComponent_RelativeSocketLocation_GET(NativePointer);
			set => E_PROP_USpringArmComponent_RelativeSocketLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Cached component-space socket rotation </para>
		/// </summary>
		protected FQuat RelativeSocketRotation
		{
			get => E_PROP_USpringArmComponent_RelativeSocketRotation_GET(NativePointer);
			set => E_PROP_USpringArmComponent_RelativeSocketRotation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>This function allows subclasses to blend the trace hit location with the desired arm location; </para>
		/// <para>by default it returns bHitSomething ? TraceHitLocation : DesiredArmLocation </para>
		/// </summary>
		protected virtual FVector BlendLocations(FVector DesiredArmLocation, FVector TraceHitLocation, bool bHitSomething, float DeltaTime)
			=> E_USpringArmComponent_BlendLocations(this, DesiredArmLocation, TraceHitLocation, bHitSomething, DeltaTime);
		
		
		/// <summary>
		/// <para>Updates the desired arm location, calling BlendLocations to do the actual blending if a trace is done </para>
		/// </summary>
		protected virtual void UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float DeltaTime)
			=> E_USpringArmComponent_UpdateDesiredArmLocation(this, bDoTrace, bDoLocationLag, bDoRotationLag, DeltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(USpringArmComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USpringArmComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USpringArmComponent>(PtrDesc);
		}}}
