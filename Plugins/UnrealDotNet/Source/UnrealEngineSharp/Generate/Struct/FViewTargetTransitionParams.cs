// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\PlayerCameraManager.h:102

namespace UnrealEngine
{
	public partial class FViewTargetTransitionParams : NativeStructWrapper
	{
		public FViewTargetTransitionParams(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FViewTargetTransitionParams() :
			base(E_CreateStruct_FViewTargetTransitionParams(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FViewTargetTransitionParams_BlendExp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FViewTargetTransitionParams_BlendExp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FViewTargetTransitionParams_BlendTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FViewTargetTransitionParams_BlendTime_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FViewTargetTransitionParams();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FViewTargetTransitionParams_GetBlendAlpha(IntPtr self, float timePct);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Exponent, used by certain blend functions to control the shape of the curve.
		/// </summary>
		public float BlendExp
		{
			get => E_PROP_FViewTargetTransitionParams_BlendExp_GET(NativePointer);
			set => E_PROP_FViewTargetTransitionParams_BlendExp_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Total duration of blend to pending view target. 0 means no blending.
		/// </summary>
		public float BlendTime
		{
			get => E_PROP_FViewTargetTransitionParams_BlendTime_GET(NativePointer);
			set => E_PROP_FViewTargetTransitionParams_BlendTime_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// For a given linear blend value (blend percentage), return the final blend alpha with the requested function applied
		/// </summary>
		public float GetBlendAlpha(float timePct)
			=> E_FViewTargetTransitionParams_GetBlendAlpha(this, timePct);
		
		#endregion
		
		public static implicit operator IntPtr(FViewTargetTransitionParams self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FViewTargetTransitionParams(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FViewTargetTransitionParams(adress, false);
		}}}
