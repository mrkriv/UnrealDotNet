using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FDepthFieldGlowInfo : NativeStructWrapper
	{
		internal FDepthFieldGlowInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDepthFieldGlowInfo() :
			base(E_CreateStruct_FDepthFieldGlowInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDepthFieldGlowInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FDepthFieldGlowInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDepthFieldGlowInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDepthFieldGlowInfo(Adress, false);
		}}}
