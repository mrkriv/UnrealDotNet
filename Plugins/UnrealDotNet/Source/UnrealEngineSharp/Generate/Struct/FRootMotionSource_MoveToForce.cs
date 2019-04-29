// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:521

namespace UnrealEngine
{
	public  partial class FRootMotionSource_MoveToForce : FRootMotionSource
	{
		internal FRootMotionSource_MoveToForce(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionSource_MoveToForce() :
			base(E_CreateStruct_FRootMotionSource_MoveToForce(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRootMotionSource_MoveToForce_bRestrictSpeedToExpected_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_MoveToForce_bRestrictSpeedToExpected_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_MoveToForce_StartLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_MoveToForce_StartLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_MoveToForce_TargetLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_MoveToForce_TargetLocation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionSource_MoveToForce();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRootMotionSource_MoveToForce_GetPathOffsetInWorldSpace(IntPtr self, float moveFraction);
		
		#endregion
		
		#region Property
		public bool bRestrictSpeedToExpected
		{
			get => E_PROP_FRootMotionSource_MoveToForce_bRestrictSpeedToExpected_GET(NativePointer);
			set => E_PROP_FRootMotionSource_MoveToForce_bRestrictSpeedToExpected_SET(NativePointer, value);
		}

		public FVector StartLocation
		{
			get => E_PROP_FRootMotionSource_MoveToForce_StartLocation_GET(NativePointer);
			set => E_PROP_FRootMotionSource_MoveToForce_StartLocation_SET(NativePointer, value);
		}

		public FVector TargetLocation
		{
			get => E_PROP_FRootMotionSource_MoveToForce_TargetLocation_GET(NativePointer);
			set => E_PROP_FRootMotionSource_MoveToForce_TargetLocation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public FVector GetPathOffsetInWorldSpace(float moveFraction)
			=> E_FRootMotionSource_MoveToForce_GetPathOffsetInWorldSpace(this, moveFraction);
		
		#endregion
		
		public static implicit operator IntPtr(FRootMotionSource_MoveToForce self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRootMotionSource_MoveToForce(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRootMotionSource_MoveToForce(Adress, false);
		}}}
