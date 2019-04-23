// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ForceFeedbackEffect.h:44

namespace UnrealEngine
{
	public  partial class FForceFeedbackParameters : NativeStructWrapper
	{
		internal FForceFeedbackParameters(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FForceFeedbackParameters() :
			base(E_CreateStruct_FForceFeedbackParameters(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FForceFeedbackParameters_bIgnoreTimeDilation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FForceFeedbackParameters_bIgnoreTimeDilation_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FForceFeedbackParameters_bLooping_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FForceFeedbackParameters_bLooping_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FForceFeedbackParameters_bPlayWhilePaused_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FForceFeedbackParameters_bPlayWhilePaused_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FForceFeedbackParameters_Tag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FForceFeedbackParameters_Tag_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FForceFeedbackParameters();
		
		#endregion
		
		#region Property
		public bool bIgnoreTimeDilation
		{
			get => E_PROP_FForceFeedbackParameters_bIgnoreTimeDilation_GET(NativePointer);
			set => E_PROP_FForceFeedbackParameters_bIgnoreTimeDilation_SET(NativePointer, value);
		}

		public bool bLooping
		{
			get => E_PROP_FForceFeedbackParameters_bLooping_GET(NativePointer);
			set => E_PROP_FForceFeedbackParameters_bLooping_SET(NativePointer, value);
		}

		public bool bPlayWhilePaused
		{
			get => E_PROP_FForceFeedbackParameters_bPlayWhilePaused_GET(NativePointer);
			set => E_PROP_FForceFeedbackParameters_bPlayWhilePaused_SET(NativePointer, value);
		}

		public string Tag
		{
			get => E_PROP_FForceFeedbackParameters_Tag_GET(NativePointer);
			set => E_PROP_FForceFeedbackParameters_Tag_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FForceFeedbackParameters self)
		{
			return self.NativePointer;
		}

		public static implicit operator FForceFeedbackParameters(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FForceFeedbackParameters(Adress, false);
		}}}
