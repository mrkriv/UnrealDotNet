using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FDestructibleChunkInfo : NativeStructWrapper
	{
		internal FDestructibleChunkInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDestructibleChunkInfo() :
			base(E_CreateStruct_FDestructibleChunkInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDestructibleChunkInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FDestructibleChunkInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDestructibleChunkInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDestructibleChunkInfo(Adress, false);
		}}}
