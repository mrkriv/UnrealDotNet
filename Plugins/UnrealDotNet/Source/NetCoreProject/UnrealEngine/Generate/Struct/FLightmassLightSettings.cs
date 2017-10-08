using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLightmassLightSettings : NativeStructWrapper
	{
		internal FLightmassLightSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassLightSettings() :
			base(E_CreateStruct_FLightmassLightSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassLightSettings();
		
		#endregion
		
		public static implicit operator IntPtr(FLightmassLightSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightmassLightSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassLightSettings(Adress, false);
		}}}
