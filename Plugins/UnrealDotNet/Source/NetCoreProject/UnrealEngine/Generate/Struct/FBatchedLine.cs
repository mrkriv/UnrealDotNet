using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FBatchedLine : NativeStructWrapper
	{
		internal FBatchedLine(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBatchedLine() :
			base(E_CreateStruct_FBatchedLine(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBatchedLine();
		
		#endregion
		
		public static implicit operator IntPtr(FBatchedLine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBatchedLine(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBatchedLine(Adress, false);
		}}}
