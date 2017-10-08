using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSplineMeshParams : NativeStructWrapper
	{
		internal FSplineMeshParams(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSplineMeshParams() :
			base(E_CreateStruct_FSplineMeshParams(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplineMeshParams();
		
		#endregion
		
		public static implicit operator IntPtr(FSplineMeshParams Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSplineMeshParams(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSplineMeshParams(Adress, false);
		}}}
