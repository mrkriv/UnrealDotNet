using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLensSettings : NativeStructWrapper
	{
		internal FLensSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLensSettings() :
			base(E_CreateStruct_FLensSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLensSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLensSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FLensSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FLensSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLensSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensSettings(Adress, false);
		}}}
