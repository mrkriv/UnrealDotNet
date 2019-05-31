// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:396

namespace UnrealEngine
{
	public  partial class FLensImperfectionSettings : NativeStructWrapper
	{
		internal FLensImperfectionSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLensImperfectionSettings() :
			base(E_CreateStruct_FLensImperfectionSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLensImperfectionSettings_DirtMaskIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensImperfectionSettings_DirtMaskIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLensImperfectionSettings_DirtMaskTint_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensImperfectionSettings_DirtMaskTint_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLensImperfectionSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLensImperfectionSettings_ExportToPostProcessSettings(IntPtr self, IntPtr outPostProcessSettings);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// BloomDirtMask intensity
		/// </summary>
		public float DirtMaskIntensity
		{
			get => E_PROP_FLensImperfectionSettings_DirtMaskIntensity_GET(NativePointer);
			set => E_PROP_FLensImperfectionSettings_DirtMaskIntensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// BloomDirtMask tint color
		/// </summary>
		public FLinearColor DirtMaskTint
		{
			get => E_PROP_FLensImperfectionSettings_DirtMaskTint_GET(NativePointer);
			set => E_PROP_FLensImperfectionSettings_DirtMaskTint_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings outPostProcessSettings)
			=> E_FLensImperfectionSettings_ExportToPostProcessSettings(this, outPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FLensImperfectionSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FLensImperfectionSettings(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FLensImperfectionSettings(adress, false);
		}}}
