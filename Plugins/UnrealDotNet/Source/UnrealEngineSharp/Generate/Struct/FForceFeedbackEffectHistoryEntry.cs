// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerController.h:89

namespace UnrealEngine
{
	public partial class FForceFeedbackEffectHistoryEntry : NativeStructWrapper
	{
		public FForceFeedbackEffectHistoryEntry(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FForceFeedbackEffectHistoryEntry(FActiveForceFeedbackEffect lastActiveFFE, float time) :
			base(E_CreateStruct_FForceFeedbackEffectHistoryEntry_FActiveForceFeedbackEffect_float(lastActiveFFE, time), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FForceFeedbackEffectHistoryEntry_LastActiveForceFeedbackEffect_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FForceFeedbackEffectHistoryEntry_LastActiveForceFeedbackEffect_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FForceFeedbackEffectHistoryEntry_TimeShown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FForceFeedbackEffectHistoryEntry_TimeShown_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FForceFeedbackEffectHistoryEntry_FActiveForceFeedbackEffect_float(IntPtr lastActiveFFE, float time);
		
		#endregion
		
		#region Property
		public FActiveForceFeedbackEffect LastActiveForceFeedbackEffect
		{
			get => E_PROP_FForceFeedbackEffectHistoryEntry_LastActiveForceFeedbackEffect_GET(NativePointer);
			set => E_PROP_FForceFeedbackEffectHistoryEntry_LastActiveForceFeedbackEffect_SET(NativePointer, value);
		}

		public float TimeShown
		{
			get => E_PROP_FForceFeedbackEffectHistoryEntry_TimeShown_GET(NativePointer);
			set => E_PROP_FForceFeedbackEffectHistoryEntry_TimeShown_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FForceFeedbackEffectHistoryEntry self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FForceFeedbackEffectHistoryEntry(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FForceFeedbackEffectHistoryEntry(adress, false);
		}}}
