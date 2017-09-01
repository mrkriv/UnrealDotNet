using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Converts a stencil mask from the editor's USTRUCT version to the version the renderer uses.
	/// </summary>
	public partial class FRendererStencilMaskEvaluation
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FRendererStencilMaskEvaluation()
		{
			NativePointer = E_CreateStruct_FRendererStencilMaskEvaluation();
			IsRef = false;
		}

		internal FRendererStencilMaskEvaluation(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FRendererStencilMaskEvaluation();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#endregion
		
		public static implicit operator IntPtr(FRendererStencilMaskEvaluation Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRendererStencilMaskEvaluation(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRendererStencilMaskEvaluation(Adress, false);
		}}}
