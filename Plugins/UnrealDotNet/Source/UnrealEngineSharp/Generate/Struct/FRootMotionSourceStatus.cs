// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:93

namespace UnrealEngine
{
	public  partial class FRootMotionSourceStatus : NativeStructWrapper
	{
		internal FRootMotionSourceStatus(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionSourceStatus() :
			base(E_CreateStruct_FRootMotionSourceStatus(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRootMotionSourceStatus_Flags_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSourceStatus_Flags_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionSourceStatus();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceStatus_Clear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSourceStatus_HasFlag(IntPtr self, byte flag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceStatus_SetFlag(IntPtr self, byte flag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceStatus_UnSetFlag(IntPtr self, byte flag);
		
		#endregion
		
		#region Property
		public byte Flags
		{
			get => E_PROP_FRootMotionSourceStatus_Flags_GET(NativePointer);
			set => E_PROP_FRootMotionSourceStatus_Flags_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Clear()
			=> E_FRootMotionSourceStatus_Clear(this);
		
		public bool HasFlag(ERootMotionSourceStatusFlags flag)
			=> E_FRootMotionSourceStatus_HasFlag(this, (byte)flag);
		
		public void SetFlag(ERootMotionSourceStatusFlags flag)
			=> E_FRootMotionSourceStatus_SetFlag(this, (byte)flag);
		
		public void UnSetFlag(ERootMotionSourceStatusFlags flag)
			=> E_FRootMotionSourceStatus_UnSetFlag(this, (byte)flag);
		
		#endregion
		
		public static implicit operator IntPtr(FRootMotionSourceStatus self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRootMotionSourceStatus(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRootMotionSourceStatus(adress, false);
		}}}
