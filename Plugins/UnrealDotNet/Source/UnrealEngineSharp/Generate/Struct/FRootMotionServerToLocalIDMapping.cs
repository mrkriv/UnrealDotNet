// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:76

namespace UnrealEngine
{
	public partial class FRootMotionServerToLocalIDMapping : NativeStructWrapper
	{
		public FRootMotionServerToLocalIDMapping(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionServerToLocalIDMapping() :
			base(E_CreateStruct_FRootMotionServerToLocalIDMapping(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionServerToLocalIDMapping_TimeStamp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionServerToLocalIDMapping_TimeStamp_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionServerToLocalIDMapping();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionServerToLocalIDMapping_IsStillValid(IntPtr self, float currentTimeStamp);
		
		#endregion
		
		#region Property
		public float TimeStamp
		{
			get => E_PROP_FRootMotionServerToLocalIDMapping_TimeStamp_GET(NativePointer);
			set => E_PROP_FRootMotionServerToLocalIDMapping_TimeStamp_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool IsStillValid(float currentTimeStamp)
			=> E_FRootMotionServerToLocalIDMapping_IsStillValid(this, currentTimeStamp);
		
		#endregion
		
		public static implicit operator IntPtr(FRootMotionServerToLocalIDMapping self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRootMotionServerToLocalIDMapping(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRootMotionServerToLocalIDMapping(adress, false);
		}}}
