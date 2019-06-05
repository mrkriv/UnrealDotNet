// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\TouchInterface.h:15

namespace UnrealEngine
{
	public partial class FTouchInputControl : NativeStructWrapper
	{
		public FTouchInputControl(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FTouchInputControl() :
			base(E_CreateStruct_FTouchInputControl(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FTouchInputControl_Center_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTouchInputControl_Center_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FTouchInputControl_InputScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTouchInputControl_InputScale_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FTouchInputControl_InteractionSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTouchInputControl_InteractionSize_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FTouchInputControl_ThumbSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTouchInputControl_ThumbSize_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FTouchInputControl_VisualSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTouchInputControl_VisualSize_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTouchInputControl();
		
		#endregion
		
		#region Property
		public FVector2D Center
		{
			get => E_PROP_FTouchInputControl_Center_GET(NativePointer);
			set => E_PROP_FTouchInputControl_Center_SET(NativePointer, value);
		}

		public FVector2D InputScale
		{
			get => E_PROP_FTouchInputControl_InputScale_GET(NativePointer);
			set => E_PROP_FTouchInputControl_InputScale_SET(NativePointer, value);
		}

		public FVector2D InteractionSize
		{
			get => E_PROP_FTouchInputControl_InteractionSize_GET(NativePointer);
			set => E_PROP_FTouchInputControl_InteractionSize_SET(NativePointer, value);
		}

		public FVector2D ThumbSize
		{
			get => E_PROP_FTouchInputControl_ThumbSize_GET(NativePointer);
			set => E_PROP_FTouchInputControl_ThumbSize_SET(NativePointer, value);
		}

		public FVector2D VisualSize
		{
			get => E_PROP_FTouchInputControl_VisualSize_GET(NativePointer);
			set => E_PROP_FTouchInputControl_VisualSize_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FTouchInputControl self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTouchInputControl(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTouchInputControl(adress, false);
		}}}
