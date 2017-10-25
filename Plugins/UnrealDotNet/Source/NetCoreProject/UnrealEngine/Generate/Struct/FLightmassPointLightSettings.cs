using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1552

namespace UnrealEngine
{
	public  partial class FLightmassPointLightSettings : FLightmassLightSettings
	{
		internal FLightmassPointLightSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassPointLightSettings() :
			base(E_CreateStruct_FLightmassPointLightSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassPointLightSettings();
		
		#endregion
		
		public static implicit operator IntPtr(FLightmassPointLightSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightmassPointLightSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassPointLightSettings(Adress, false);
		}}}
