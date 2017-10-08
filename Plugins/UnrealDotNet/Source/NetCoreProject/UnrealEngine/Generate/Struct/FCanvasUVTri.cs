using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FCanvasUVTri : NativeStructWrapper
	{
		internal FCanvasUVTri(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCanvasUVTri() :
			base(E_CreateStruct_FCanvasUVTri(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCanvasUVTri();
		
		#endregion
		
		public static implicit operator IntPtr(FCanvasUVTri Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FCanvasUVTri(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCanvasUVTri(Adress, false);
		}}}
