// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USpringArmComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USpringArmComponent_BlendLocations(IntPtr self, IntPtr desiredArmLocation, IntPtr traceHitLocation, bool bHitSomething, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USpringArmComponent_UpdateDesiredArmLocation(IntPtr self, bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float deltaTime);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>This function allows subclasses to blend the trace hit location with the desired arm location; </para>
		/// <para>by default it returns bHitSomething ? TraceHitLocation : DesiredArmLocation </para>
		/// </summary>
		protected virtual FVector BlendLocations(FVector desiredArmLocation, FVector traceHitLocation, bool bHitSomething, float deltaTime)
			=> E_USpringArmComponent_BlendLocations(this, desiredArmLocation, traceHitLocation, bHitSomething, deltaTime);
		
		
		/// <summary>
		/// <para>Updates the desired arm location, calling BlendLocations to do the actual blending if a trace is done </para>
		/// </summary>
		protected virtual void UpdateDesiredArmLocation(bool bDoTrace, bool bDoLocationLag, bool bDoRotationLag, float deltaTime)
			=> E_USpringArmComponent_UpdateDesiredArmLocation(this, bDoTrace, bDoLocationLag, bDoRotationLag, deltaTime);
		
		#endregion
		
		public static implicit operator IntPtr(USpringArmComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USpringArmComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USpringArmComponent>(PtrDesc);
		}}}
