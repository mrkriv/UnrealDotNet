using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLightmassDirectionalLightSettings : FLightmassLightSettings
	{
		internal FLightmassDirectionalLightSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassDirectionalLightSettings() :
			base(E_CreateStruct_FLightmassDirectionalLightSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassDirectionalLightSettings();
		
		#endregion
		
		public static implicit operator IntPtr(FLightmassDirectionalLightSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightmassDirectionalLightSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassDirectionalLightSettings(Adress, false);
		}}}
