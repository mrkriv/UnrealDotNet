using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageRendererStencilMaskEvaluation
	/// <para>Converts a stencil mask from the editor's USTRUCT version to the version the renderer uses. </para>
	/// </summary>
	public  partial class FRendererStencilMaskEvaluation : NativeStructWrapper
	{
		public FRendererStencilMaskEvaluation() : base(E_CreateStruct_FRendererStencilMaskEvaluation(), false)
		{
		}

		internal FRendererStencilMaskEvaluation(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FRendererStencilMaskEvaluation();
		
		#endregion
		
		public static implicit operator IntPtr(FRendererStencilMaskEvaluation Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRendererStencilMaskEvaluation(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRendererStencilMaskEvaluation(Adress, false);
		}}}
