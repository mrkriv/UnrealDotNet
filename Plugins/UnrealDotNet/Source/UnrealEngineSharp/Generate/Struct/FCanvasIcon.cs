// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Canvas.h:21

namespace UnrealEngine
{
	public partial class FCanvasIcon : NativeStructWrapper
	{
		public FCanvasIcon(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FCanvasIcon() :
			base(E_CreateStruct_FCanvasIcon(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCanvasIcon_U_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasIcon_U_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCanvasIcon_UL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasIcon_UL_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCanvasIcon_V_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasIcon_V_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCanvasIcon_VL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCanvasIcon_VL_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCanvasIcon();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// UV coords
		/// </summary>
		public float U
		{
			get => E_PROP_FCanvasIcon_U_GET(NativePointer);
			set => E_PROP_FCanvasIcon_U_SET(NativePointer, value);
		}

		public float UL
		{
			get => E_PROP_FCanvasIcon_UL_GET(NativePointer);
			set => E_PROP_FCanvasIcon_UL_SET(NativePointer, value);
		}

		public float V
		{
			get => E_PROP_FCanvasIcon_V_GET(NativePointer);
			set => E_PROP_FCanvasIcon_V_SET(NativePointer, value);
		}

		public float VL
		{
			get => E_PROP_FCanvasIcon_VL_GET(NativePointer);
			set => E_PROP_FCanvasIcon_VL_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCanvasIcon self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCanvasIcon(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FCanvasIcon(adress, false);
		}}}
