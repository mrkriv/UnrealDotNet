using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FCameraExposureSettings : NativeStructWrapper
	{
		internal FCameraExposureSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCameraExposureSettings() :
			base(E_CreateStruct_FCameraExposureSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCameraExposureSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCameraExposureSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FCameraExposureSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FCameraExposureSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FCameraExposureSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCameraExposureSettings(Adress, false);
		}}}
