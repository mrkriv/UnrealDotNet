using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPaintedVertex : NativeStructWrapper
	{
		internal FPaintedVertex(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPaintedVertex() :
			base(E_CreateStruct_FPaintedVertex(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPaintedVertex();
		
		#endregion
		
		public static implicit operator IntPtr(FPaintedVertex Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPaintedVertex(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPaintedVertex(Adress, false);
		}}}
