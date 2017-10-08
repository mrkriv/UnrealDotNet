using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FBatchedPoint : NativeStructWrapper
	{
		internal FBatchedPoint(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBatchedPoint() :
			base(E_CreateStruct_FBatchedPoint(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBatchedPoint();
		
		#endregion
		
		public static implicit operator IntPtr(FBatchedPoint Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBatchedPoint(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBatchedPoint(Adress, false);
		}}}
