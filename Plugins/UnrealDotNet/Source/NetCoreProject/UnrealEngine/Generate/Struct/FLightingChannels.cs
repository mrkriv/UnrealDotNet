using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLightingChannels : NativeStructWrapper
	{
		internal FLightingChannels(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightingChannels() :
			base(E_CreateStruct_FLightingChannels(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightingChannels();
		
		#endregion
		
		public static implicit operator IntPtr(FLightingChannels Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightingChannels(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightingChannels(Adress, false);
		}}}
