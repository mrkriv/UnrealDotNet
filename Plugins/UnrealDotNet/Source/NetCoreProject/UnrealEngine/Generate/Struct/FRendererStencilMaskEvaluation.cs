using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FRendererStencilMaskEvaluation : NativeStructWrapper
	{
		internal FRendererStencilMaskEvaluation(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRendererStencilMaskEvaluation() :
			base(E_CreateStruct_FRendererStencilMaskEvaluation(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRendererStencilMaskEvaluation();
		
		#endregion
		
		public static implicit operator IntPtr(FRendererStencilMaskEvaluation Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRendererStencilMaskEvaluation(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRendererStencilMaskEvaluation(Adress, false);
		}
}
}
