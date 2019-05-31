// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:395

namespace UnrealEngine
{
	public  partial class FRootMotionSource_ConstantForce : FRootMotionSource
	{
		internal FRootMotionSource_ConstantForce(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionSource_ConstantForce() :
			base(E_CreateStruct_FRootMotionSource_ConstantForce(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionSource_ConstantForce_Force_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSource_ConstantForce_Force_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionSource_ConstantForce();
		
		#endregion
		
		#region Property
		public FVector Force
		{
			get => E_PROP_FRootMotionSource_ConstantForce_Force_GET(NativePointer);
			set => E_PROP_FRootMotionSource_ConstantForce_Force_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRootMotionSource_ConstantForce self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRootMotionSource_ConstantForce(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRootMotionSource_ConstantForce(adress, false);
		}}}
