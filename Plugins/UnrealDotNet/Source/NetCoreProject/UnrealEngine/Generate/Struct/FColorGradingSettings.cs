using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FColorGradingSettings : NativeStructWrapper
	{
		internal FColorGradingSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FColorGradingSettings() :
			base(E_CreateStruct_FColorGradingSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FColorGradingSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FColorGradingSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FColorGradingSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FColorGradingSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FColorGradingSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FColorGradingSettings(Adress, false);
		}}}
