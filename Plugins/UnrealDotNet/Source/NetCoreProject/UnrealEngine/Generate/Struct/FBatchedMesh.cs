using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FBatchedMesh : NativeStructWrapper
	{
		internal FBatchedMesh(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBatchedMesh() :
			base(E_CreateStruct_FBatchedMesh(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBatchedMesh();
		
		#endregion
		
		public static implicit operator IntPtr(FBatchedMesh Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBatchedMesh(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBatchedMesh(Adress, false);
		}}}
