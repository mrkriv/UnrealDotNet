// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1537

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassPointLightSettings();
		
		#endregion
		
		public static implicit operator IntPtr(FLightmassPointLightSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator FLightmassPointLightSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassPointLightSettings(Adress, false);
		}}}
