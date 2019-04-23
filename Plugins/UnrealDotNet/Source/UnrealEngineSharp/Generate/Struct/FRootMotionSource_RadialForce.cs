// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:446

namespace UnrealEngine
{
	public  partial class FRootMotionSource_RadialForce : FRootMotionSource
	{
		internal FRootMotionSource_RadialForce(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionSource_RadialForce() :
			base(E_CreateStruct_FRootMotionSource_RadialForce(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRootMotionSource_RadialForce_bIsPush_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_RadialForce_bIsPush_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRootMotionSource_RadialForce_bNoZForce_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_RadialForce_bNoZForce_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRootMotionSource_RadialForce_bUseFixedWorldDirection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_RadialForce_bUseFixedWorldDirection_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_RadialForce_FixedWorldDirection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_RadialForce_FixedWorldDirection_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_RadialForce_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_RadialForce_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FRootMotionSource_RadialForce_LocationActor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_RadialForce_LocationActor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionSource_RadialForce_Radius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_RadialForce_Radius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionSource_RadialForce_Strength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_RadialForce_Strength_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionSource_RadialForce();
		
		#endregion
		
		#region Property
		public bool bIsPush
		{
			get => E_PROP_FRootMotionSource_RadialForce_bIsPush_GET(NativePointer);
			set => E_PROP_FRootMotionSource_RadialForce_bIsPush_SET(NativePointer, value);
		}

		public bool bNoZForce
		{
			get => E_PROP_FRootMotionSource_RadialForce_bNoZForce_GET(NativePointer);
			set => E_PROP_FRootMotionSource_RadialForce_bNoZForce_SET(NativePointer, value);
		}

		public bool bUseFixedWorldDirection
		{
			get => E_PROP_FRootMotionSource_RadialForce_bUseFixedWorldDirection_GET(NativePointer);
			set => E_PROP_FRootMotionSource_RadialForce_bUseFixedWorldDirection_SET(NativePointer, value);
		}

		public FRotator FixedWorldDirection
		{
			get => E_PROP_FRootMotionSource_RadialForce_FixedWorldDirection_GET(NativePointer);
			set => E_PROP_FRootMotionSource_RadialForce_FixedWorldDirection_SET(NativePointer, value);
		}

		public FVector Location
		{
			get => E_PROP_FRootMotionSource_RadialForce_Location_GET(NativePointer);
			set => E_PROP_FRootMotionSource_RadialForce_Location_SET(NativePointer, value);
		}

		public AActor LocationActor
		{
			get => E_PROP_FRootMotionSource_RadialForce_LocationActor_GET(NativePointer);
			set => E_PROP_FRootMotionSource_RadialForce_LocationActor_SET(NativePointer, value);
		}

		public float Radius
		{
			get => E_PROP_FRootMotionSource_RadialForce_Radius_GET(NativePointer);
			set => E_PROP_FRootMotionSource_RadialForce_Radius_SET(NativePointer, value);
		}

		public float Strength
		{
			get => E_PROP_FRootMotionSource_RadialForce_Strength_GET(NativePointer);
			set => E_PROP_FRootMotionSource_RadialForce_Strength_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRootMotionSource_RadialForce self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRootMotionSource_RadialForce(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRootMotionSource_RadialForce(Adress, false);
		}}}
