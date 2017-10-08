using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLensImperfectionSettings : NativeStructWrapper
	{
		internal FLensImperfectionSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLensImperfectionSettings() :
			base(E_CreateStruct_FLensImperfectionSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLensImperfectionSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLensImperfectionSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FLensImperfectionSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FLensImperfectionSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLensImperfectionSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensImperfectionSettings(Adress, false);
		}}}
