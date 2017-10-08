using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLightmassDebugOptions : NativeStructWrapper
	{
		internal FLightmassDebugOptions(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassDebugOptions() :
			base(E_CreateStruct_FLightmassDebugOptions(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassDebugOptions();
		
		#endregion
		
		public static implicit operator IntPtr(FLightmassDebugOptions Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightmassDebugOptions(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassDebugOptions(Adress, false);
		}}}
