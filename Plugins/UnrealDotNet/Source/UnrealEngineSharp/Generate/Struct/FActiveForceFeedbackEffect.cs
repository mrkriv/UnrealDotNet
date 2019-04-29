// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ForceFeedbackEffect.h:68

namespace UnrealEngine
{
	public  partial class FActiveForceFeedbackEffect : NativeStructWrapper
	{
		internal FActiveForceFeedbackEffect(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FActiveForceFeedbackEffect() :
			base(E_CreateStruct_FActiveForceFeedbackEffect(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FActiveForceFeedbackEffect_Parameters_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActiveForceFeedbackEffect_Parameters_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FActiveForceFeedbackEffect_PlayTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActiveForceFeedbackEffect_PlayTime_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActiveForceFeedbackEffect();
		
		#endregion
		
		#region Property
		public FForceFeedbackParameters Parameters
		{
			get => E_PROP_FActiveForceFeedbackEffect_Parameters_GET(NativePointer);
			set => E_PROP_FActiveForceFeedbackEffect_Parameters_SET(NativePointer, value);
		}

		public float PlayTime
		{
			get => E_PROP_FActiveForceFeedbackEffect_PlayTime_GET(NativePointer);
			set => E_PROP_FActiveForceFeedbackEffect_PlayTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FActiveForceFeedbackEffect self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FActiveForceFeedbackEffect(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActiveForceFeedbackEffect(Adress, false);
		}}}
