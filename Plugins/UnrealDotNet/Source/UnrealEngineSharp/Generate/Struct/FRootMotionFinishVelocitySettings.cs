// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:148

namespace UnrealEngine
{
	public partial class FRootMotionFinishVelocitySettings : NativeStructWrapper
	{
		public FRootMotionFinishVelocitySettings(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionFinishVelocitySettings() :
			base(E_CreateStruct_FRootMotionFinishVelocitySettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRootMotionFinishVelocitySettings_ClampVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionFinishVelocitySettings_ClampVelocity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRootMotionFinishVelocitySettings_Mode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionFinishVelocitySettings_Mode_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRootMotionFinishVelocitySettings_SetVelocity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionFinishVelocitySettings_SetVelocity_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionFinishVelocitySettings();
		
		#endregion
		
		#region Property
		public float ClampVelocity
		{
			get => E_PROP_FRootMotionFinishVelocitySettings_ClampVelocity_GET(NativePointer);
			set => E_PROP_FRootMotionFinishVelocitySettings_ClampVelocity_SET(NativePointer, value);
		}

		public ERootMotionFinishVelocityMode Mode
		{
			get => (ERootMotionFinishVelocityMode)E_PROP_FRootMotionFinishVelocitySettings_Mode_GET(NativePointer);
			set => E_PROP_FRootMotionFinishVelocitySettings_Mode_SET(NativePointer, (byte)value);
		}

		public FVector SetVelocity
		{
			get => E_PROP_FRootMotionFinishVelocitySettings_SetVelocity_GET(NativePointer);
			set => E_PROP_FRootMotionFinishVelocitySettings_SetVelocity_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRootMotionFinishVelocitySettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRootMotionFinishVelocitySettings(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRootMotionFinishVelocitySettings(adress, false);
		}}}
