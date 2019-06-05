// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:507

namespace UnrealEngine
{
	public partial class FScreenMessageString : NativeStructWrapper
	{
		public FScreenMessageString(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FScreenMessageString() :
			base(E_CreateStruct_FScreenMessageString(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FScreenMessageString_CurrentTimeDisplayed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FScreenMessageString_CurrentTimeDisplayed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FScreenMessageString_ScreenMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FScreenMessageString_ScreenMessage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FScreenMessageString_TextScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FScreenMessageString_TextScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FScreenMessageString_TimeToDisplay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FScreenMessageString_TimeToDisplay_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScreenMessageString();
		
		#endregion
		
		#region Property
		public float CurrentTimeDisplayed
		{
			get => E_PROP_FScreenMessageString_CurrentTimeDisplayed_GET(NativePointer);
			set => E_PROP_FScreenMessageString_CurrentTimeDisplayed_SET(NativePointer, value);
		}

		public string ScreenMessage
		{
			get => E_PROP_FScreenMessageString_ScreenMessage_GET(NativePointer);
			set => E_PROP_FScreenMessageString_ScreenMessage_SET(NativePointer, value);
		}

		public FVector2D TextScale
		{
			get => E_PROP_FScreenMessageString_TextScale_GET(NativePointer);
			set => E_PROP_FScreenMessageString_TextScale_SET(NativePointer, value);
		}

		public float TimeToDisplay
		{
			get => E_PROP_FScreenMessageString_TimeToDisplay_GET(NativePointer);
			set => E_PROP_FScreenMessageString_TimeToDisplay_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FScreenMessageString self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FScreenMessageString(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FScreenMessageString(adress, false);
		}}}
