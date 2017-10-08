using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FResponseChannel : NativeStructWrapper
	{
		internal FResponseChannel(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FResponseChannel() :
			base(E_CreateStruct_FResponseChannel(), false)
		{
		}

		public FResponseChannel(string InChannel, ECollisionResponse InResponse) :
			base(E_CreateStruct_FResponseChannel_FName_ECollisionResponse(InChannel, (byte)InResponse), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FResponseChannel();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FResponseChannel_FName_ECollisionResponse(string InChannel, byte InResponse);
		
		#endregion
		
		public static implicit operator IntPtr(FResponseChannel Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FResponseChannel(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FResponseChannel(Adress, false);
		}}}
