using System;
using System.Runtime.InteropServices;

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
		private static extern StringWrapper E_FExposureSettings_ToString(IntPtr Self);
		
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
