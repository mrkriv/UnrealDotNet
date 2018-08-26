// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:107

namespace UnrealEngine
{
	public  partial class FColorGradingSettings : NativeStructWrapper
	{
		internal FColorGradingSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FColorGradingSettings() :
			base(E_CreateStruct_FColorGradingSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FColorGradingSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FColorGradingSettings_Global_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradingSettings_Global_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FColorGradingSettings_Highlights_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradingSettings_Highlights_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FColorGradingSettings_HighlightsMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradingSettings_HighlightsMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FColorGradingSettings_Midtones_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradingSettings_Midtones_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FColorGradingSettings_Shadows_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradingSettings_Shadows_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FColorGradingSettings_ShadowsMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FColorGradingSettings_ShadowsMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FColorGradingSettings_ExportToPostProcessSettings(IntPtr self, IntPtr outPostProcessSettings);
		
		#endregion
		
		#region Property
		public FColorGradePerRangeSettings Global
		{
			get => E_PROP_FColorGradingSettings_Global_GET(NativePointer);
			set => E_PROP_FColorGradingSettings_Global_SET(NativePointer, value);
		}

		public FColorGradePerRangeSettings Highlights
		{
			get => E_PROP_FColorGradingSettings_Highlights_GET(NativePointer);
			set => E_PROP_FColorGradingSettings_Highlights_SET(NativePointer, value);
		}

		public float HighlightsMin
		{
			get => E_PROP_FColorGradingSettings_HighlightsMin_GET(NativePointer);
			set => E_PROP_FColorGradingSettings_HighlightsMin_SET(NativePointer, value);
		}

		public FColorGradePerRangeSettings Midtones
		{
			get => E_PROP_FColorGradingSettings_Midtones_GET(NativePointer);
			set => E_PROP_FColorGradingSettings_Midtones_SET(NativePointer, value);
		}

		public FColorGradePerRangeSettings Shadows
		{
			get => E_PROP_FColorGradingSettings_Shadows_GET(NativePointer);
			set => E_PROP_FColorGradingSettings_Shadows_SET(NativePointer, value);
		}

		public float ShadowsMax
		{
			get => E_PROP_FColorGradingSettings_ShadowsMax_GET(NativePointer);
			set => E_PROP_FColorGradingSettings_ShadowsMax_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings outPostProcessSettings)
			=> E_FColorGradingSettings_ExportToPostProcessSettings(this, outPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FColorGradingSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator FColorGradingSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FColorGradingSettings(Adress, false);
		}}}
