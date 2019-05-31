// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:114

namespace UnrealEngine
{
	public  partial class FRootMotionSourceSettings : NativeStructWrapper
	{
		internal FRootMotionSourceSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRootMotionSourceSettings() :
			base(E_CreateStruct_FRootMotionSourceSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FRootMotionSourceSettings_Flags_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRootMotionSourceSettings_Flags_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRootMotionSourceSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceSettings_Clear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRootMotionSourceSettings_HasFlag(IntPtr self, byte flag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceSettings_SetFlag(IntPtr self, byte flag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRootMotionSourceSettings_UnSetFlag(IntPtr self, byte flag);
		
		#endregion
		
		#region Property
		public byte Flags
		{
			get => E_PROP_FRootMotionSourceSettings_Flags_GET(NativePointer);
			set => E_PROP_FRootMotionSourceSettings_Flags_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Clear()
			=> E_FRootMotionSourceSettings_Clear(this);
		
		public bool HasFlag(ERootMotionSourceSettingsFlags flag)
			=> E_FRootMotionSourceSettings_HasFlag(this, (byte)flag);
		
		public void SetFlag(ERootMotionSourceSettingsFlags flag)
			=> E_FRootMotionSourceSettings_SetFlag(this, (byte)flag);
		
		public void UnSetFlag(ERootMotionSourceSettingsFlags flag)
			=> E_FRootMotionSourceSettings_UnSetFlag(this, (byte)flag);
		
		#endregion
		
		public static implicit operator IntPtr(FRootMotionSourceSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRootMotionSourceSettings(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FRootMotionSourceSettings(adress, false);
		}}}
