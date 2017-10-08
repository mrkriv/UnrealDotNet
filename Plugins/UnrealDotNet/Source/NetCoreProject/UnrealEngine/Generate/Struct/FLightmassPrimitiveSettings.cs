using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLightmassPrimitiveSettings : NativeStructWrapper
	{
		internal FLightmassPrimitiveSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassPrimitiveSettings() :
			base(E_CreateStruct_FLightmassPrimitiveSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassPrimitiveSettings();
		
		#endregion
		
		public static implicit operator IntPtr(FLightmassPrimitiveSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightmassPrimitiveSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassPrimitiveSettings(Adress, false);
		}}}
