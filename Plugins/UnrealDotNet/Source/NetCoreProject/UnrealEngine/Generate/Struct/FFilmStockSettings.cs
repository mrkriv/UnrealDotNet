using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FFilmStockSettings : NativeStructWrapper
	{
		internal FFilmStockSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFilmStockSettings() :
			base(E_CreateStruct_FFilmStockSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFilmStockSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFilmStockSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FFilmStockSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FFilmStockSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFilmStockSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFilmStockSettings(Adress, false);
		}}}
