// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:994

namespace UnrealEngine
{
	public  partial class FExposureSettings : NativeStructWrapper
	{
		internal FExposureSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FExposureSettings() :
			base(E_CreateStruct_FExposureSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FExposureSettings_bFixed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FExposureSettings_bFixed_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FExposureSettings_FixedEV100_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FExposureSettings_FixedEV100_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FExposureSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FExposureSettings_ToString(IntPtr self);
		
		#endregion
		
		#region Property
		public bool bFixed
		{
			get => E_PROP_FExposureSettings_bFixed_GET(NativePointer);
			set => E_PROP_FExposureSettings_bFixed_SET(NativePointer, value);
		}

		public float FixedEV100
		{
			get => E_PROP_FExposureSettings_FixedEV100_GET(NativePointer);
			set => E_PROP_FExposureSettings_FixedEV100_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public override string ToString()
			=> E_FExposureSettings_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FExposureSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator FExposureSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FExposureSettings(Adress, false);
		}}}
