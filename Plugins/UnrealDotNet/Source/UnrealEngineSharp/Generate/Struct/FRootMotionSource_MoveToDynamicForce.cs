// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:585

namespace UnrealEngine
{
	public  partial class FRootMotionSource_MoveToDynamicForce : FRootMotionSource
	{
		internal FRootMotionSource_MoveToDynamicForce(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionSource_MoveToDynamicForce() :
			base(E_CreateStruct_FRootMotionSource_MoveToDynamicForce(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FRootMotionSource_MoveToDynamicForce_bRestrictSpeedToExpected_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_MoveToDynamicForce_bRestrictSpeedToExpected_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_MoveToDynamicForce_InitialTargetLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_MoveToDynamicForce_InitialTargetLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_MoveToDynamicForce_StartLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_MoveToDynamicForce_StartLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_MoveToDynamicForce_TargetLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_MoveToDynamicForce_TargetLocation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionSource_MoveToDynamicForce();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRootMotionSource_MoveToDynamicForce_GetPathOffsetInWorldSpace(IntPtr self, float moveFraction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSource_MoveToDynamicForce_SetTargetLocation(IntPtr self, IntPtr newTargetLocation);
		
		#endregion
		
		#region Property
		public bool bRestrictSpeedToExpected
		{
			get => E_PROP_FRootMotionSource_MoveToDynamicForce_bRestrictSpeedToExpected_GET(NativePointer);
			set => E_PROP_FRootMotionSource_MoveToDynamicForce_bRestrictSpeedToExpected_SET(NativePointer, value);
		}

		public FVector InitialTargetLocation
		{
			get => E_PROP_FRootMotionSource_MoveToDynamicForce_InitialTargetLocation_GET(NativePointer);
			set => E_PROP_FRootMotionSource_MoveToDynamicForce_InitialTargetLocation_SET(NativePointer, value);
		}

		public FVector StartLocation
		{
			get => E_PROP_FRootMotionSource_MoveToDynamicForce_StartLocation_GET(NativePointer);
			set => E_PROP_FRootMotionSource_MoveToDynamicForce_StartLocation_SET(NativePointer, value);
		}

		public FVector TargetLocation
		{
			get => E_PROP_FRootMotionSource_MoveToDynamicForce_TargetLocation_GET(NativePointer);
			set => E_PROP_FRootMotionSource_MoveToDynamicForce_TargetLocation_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public FVector GetPathOffsetInWorldSpace(float moveFraction)
			=> E_FRootMotionSource_MoveToDynamicForce_GetPathOffsetInWorldSpace(this, moveFraction);
		
		public void SetTargetLocation(FVector newTargetLocation)
			=> E_FRootMotionSource_MoveToDynamicForce_SetTargetLocation(this, newTargetLocation);
		
		#endregion
		
		public static implicit operator IntPtr(FRootMotionSource_MoveToDynamicForce self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRootMotionSource_MoveToDynamicForce(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRootMotionSource_MoveToDynamicForce(adress, false);
		}}}
