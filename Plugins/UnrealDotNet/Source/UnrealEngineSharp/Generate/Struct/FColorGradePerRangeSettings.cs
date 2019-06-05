// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:97

namespace UnrealEngine
{
	public partial class FColorGradePerRangeSettings : NativeStructWrapper
	{
		public FColorGradePerRangeSettings(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FColorGradePerRangeSettings() :
			base(E_CreateStruct_FColorGradePerRangeSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Contrast_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Contrast_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Gain_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Gain_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Gamma_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Gamma_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Offset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Offset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Saturation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Saturation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FColorGradePerRangeSettings();
		
		#endregion
		
		#region Property
		public FVector4 Contrast
		{
			get => E_PROP_FColorGradePerRangeSettings_Contrast_GET(NativePointer);
			set => E_PROP_FColorGradePerRangeSettings_Contrast_SET(NativePointer, value);
		}

		public FVector4 Gain
		{
			get => E_PROP_FColorGradePerRangeSettings_Gain_GET(NativePointer);
			set => E_PROP_FColorGradePerRangeSettings_Gain_SET(NativePointer, value);
		}

		public FVector4 Gamma
		{
			get => E_PROP_FColorGradePerRangeSettings_Gamma_GET(NativePointer);
			set => E_PROP_FColorGradePerRangeSettings_Gamma_SET(NativePointer, value);
		}

		public FVector4 Offset
		{
			get => E_PROP_FColorGradePerRangeSettings_Offset_GET(NativePointer);
			set => E_PROP_FColorGradePerRangeSettings_Offset_SET(NativePointer, value);
		}

		public FVector4 Saturation
		{
			get => E_PROP_FColorGradePerRangeSettings_Saturation_GET(NativePointer);
			set => E_PROP_FColorGradePerRangeSettings_Saturation_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FColorGradePerRangeSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FColorGradePerRangeSettings(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FColorGradePerRangeSettings(adress, false);
		}}}
