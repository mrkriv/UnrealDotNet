using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FAnimationEvaluationContext
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FAnimationEvaluationContext()
		{
			NativePointer = E_CreateStruct_FAnimationEvaluationContext();
			IsRef = false;
		}

		internal FAnimationEvaluationContext(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FAnimationEvaluationContext();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FAnimationEvaluationContext_RootBoneTranslation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FAnimationEvaluationContext_RootBoneTranslation_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FAnimationEvaluationContext_bDoInterpolation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FAnimationEvaluationContext_bDoInterpolation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FAnimationEvaluationContext_bDoEvaluation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FAnimationEvaluationContext_bDoEvaluation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FAnimationEvaluationContext_Copy(FAnimationEvaluationContext Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FAnimationEvaluationContext_Clear(FAnimationEvaluationContext Self);
		
		#endregion
		
		#region Property
		public FVector RootBoneTranslation
		{
			get => E_PROP_FAnimationEvaluationContext_RootBoneTranslation_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_RootBoneTranslation_SET(NativePointer, value);
		}

		public bool bDoInterpolation
		{
			get => E_PROP_FAnimationEvaluationContext_bDoInterpolation_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_bDoInterpolation_SET(NativePointer, value);
		}

		public bool bDoEvaluation
		{
			get => E_PROP_FAnimationEvaluationContext_bDoEvaluation_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_bDoEvaluation_SET(NativePointer, value);
		}

		public bool bDuplicateToCacheBones
		{
			get => E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_bDuplicateToCacheBones_SET(NativePointer, value);
		}

		public bool bDuplicateToCacheCurve
		{
			get => E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_GET(NativePointer);
			set => E_PROP_FAnimationEvaluationContext_bDuplicateToCacheCurve_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Copy(FAnimationEvaluationContext Other)
			=> E_FAnimationEvaluationContext_Copy(this, Other);
		
		public void Clear()
			=> E_FAnimationEvaluationContext_Clear(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAnimationEvaluationContext Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAnimationEvaluationContext(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAnimationEvaluationContext(Adress, false);
		}}}
