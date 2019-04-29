// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:164

namespace UnrealEngine
{
	public  partial class FFilmStockSettings : NativeStructWrapper
	{
		internal FFilmStockSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFilmStockSettings() :
			base(E_CreateStruct_FFilmStockSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_BlackClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_BlackClip_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_Shoulder_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_Shoulder_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_Slope_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_Slope_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_Toe_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_Toe_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFilmStockSettings_WhiteClip_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFilmStockSettings_WhiteClip_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFilmStockSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFilmStockSettings_ExportToPostProcessSettings(IntPtr self, IntPtr outPostProcessSettings);
		
		#endregion
		
		#region Property
		public float Blackclip
		{
			get => E_PROP_FFilmStockSettings_BlackClip_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_BlackClip_SET(NativePointer, value);
		}

		public float Shoulder
		{
			get => E_PROP_FFilmStockSettings_Shoulder_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_Shoulder_SET(NativePointer, value);
		}

		public float Slope
		{
			get => E_PROP_FFilmStockSettings_Slope_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_Slope_SET(NativePointer, value);
		}

		public float Toe
		{
			get => E_PROP_FFilmStockSettings_Toe_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_Toe_SET(NativePointer, value);
		}

		public float Whiteclip
		{
			get => E_PROP_FFilmStockSettings_WhiteClip_GET(NativePointer);
			set => E_PROP_FFilmStockSettings_WhiteClip_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings outPostProcessSettings)
			=> E_FFilmStockSettings_ExportToPostProcessSettings(this, outPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FFilmStockSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFilmStockSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFilmStockSettings(Adress, false);
		}}}
