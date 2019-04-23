// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:654

namespace UnrealEngine
{
	public  partial class FRootMotionSource_JumpForce : FRootMotionSource
	{
		internal FRootMotionSource_JumpForce(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionSource_JumpForce() :
			base(E_CreateStruct_FRootMotionSource_JumpForce(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRootMotionSource_JumpForce_bDisableTimeout_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_JumpForce_bDisableTimeout_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionSource_JumpForce_Distance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_JumpForce_Distance_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionSource_JumpForce_Height_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_JumpForce_Height_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_JumpForce_Rotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_JumpForce_Rotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_JumpForce_SavedHalfwayLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_JumpForce_SavedHalfwayLocation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionSource_JumpForce();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRootMotionSource_JumpForce_GetPathOffset(IntPtr self, float moveFraction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRootMotionSource_JumpForce_GetRelativeLocation(IntPtr self, float moveFraction);
		
		#endregion
		
		#region Property
		public bool bDisableTimeout
		{
			get => E_PROP_FRootMotionSource_JumpForce_bDisableTimeout_GET(NativePointer);
			set => E_PROP_FRootMotionSource_JumpForce_bDisableTimeout_SET(NativePointer, value);
		}

		public float Distance
		{
			get => E_PROP_FRootMotionSource_JumpForce_Distance_GET(NativePointer);
			set => E_PROP_FRootMotionSource_JumpForce_Distance_SET(NativePointer, value);
		}

		public float Height
		{
			get => E_PROP_FRootMotionSource_JumpForce_Height_GET(NativePointer);
			set => E_PROP_FRootMotionSource_JumpForce_Height_SET(NativePointer, value);
		}

		public FRotator Rotation
		{
			get => E_PROP_FRootMotionSource_JumpForce_Rotation_GET(NativePointer);
			set => E_PROP_FRootMotionSource_JumpForce_Rotation_SET(NativePointer, value);
		}

		public FVector SavedHalfwayLocation
		{
			get => E_PROP_FRootMotionSource_JumpForce_SavedHalfwayLocation_GET(NativePointer);
			set => E_PROP_FRootMotionSource_JumpForce_SavedHalfwayLocation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public FVector GetPathOffset(float moveFraction)
			=> E_FRootMotionSource_JumpForce_GetPathOffset(this, moveFraction);
		
		public FVector GetRelativeLocation(float moveFraction)
			=> E_FRootMotionSource_JumpForce_GetRelativeLocation(this, moveFraction);
		
		#endregion
		
		public static implicit operator IntPtr(FRootMotionSource_JumpForce self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRootMotionSource_JumpForce(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRootMotionSource_JumpForce(Adress, false);
		}}}
