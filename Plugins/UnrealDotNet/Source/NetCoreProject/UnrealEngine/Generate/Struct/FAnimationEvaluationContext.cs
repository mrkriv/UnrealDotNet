using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FAnimationEvaluationContext : NativeStructWrapper
	{
		internal FAnimationEvaluationContext(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAnimationEvaluationContext() :
			base(E_CreateStruct_FAnimationEvaluationContext(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAnimationEvaluationContext();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAnimationEvaluationContext_Clear(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAnimationEvaluationContext_Copy(IntPtr Self, IntPtr Other);
		
		#endregion
		
		#region ExternMethods
		public void Clear()
			=> E_FAnimationEvaluationContext_Clear(this);
		
		public void Copy(FAnimationEvaluationContext Other)
			=> E_FAnimationEvaluationContext_Copy(this, Other);
		
		#endregion
		
		public static implicit operator IntPtr(FAnimationEvaluationContext Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAnimationEvaluationContext(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAnimationEvaluationContext(Adress, false);
		}}}
