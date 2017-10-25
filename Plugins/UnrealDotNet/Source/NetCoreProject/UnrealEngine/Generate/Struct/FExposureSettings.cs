using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:959

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FExposureSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FExposureSettings_bFixed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FExposureSettings_bFixed_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FExposureSettings_LogOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FExposureSettings_LogOffset_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FExposureSettings_ToString(IntPtr Self);
		
		#endregion
		
		#region Property
		public bool bFixed
		{
			get => E_PROP_FExposureSettings_bFixed_GET(NativePointer);
			set => E_PROP_FExposureSettings_bFixed_SET(NativePointer, value);
		}

		public int LogOffset
		{
			get => E_PROP_FExposureSettings_LogOffset_GET(NativePointer);
			set => E_PROP_FExposureSettings_LogOffset_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public override string ToString()
			=> E_FExposureSettings_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FExposureSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FExposureSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FExposureSettings(Adress, false);
		}}}
