// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:319

namespace UnrealEngine
{
	public  partial class FConvolutionBloomSettings : NativeStructWrapper
	{
		internal FConvolutionBloomSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FConvolutionBloomSettings() :
			base(E_CreateStruct_FConvolutionBloomSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FConvolutionBloomSettings_BufferScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FConvolutionBloomSettings_BufferScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FConvolutionBloomSettings_CenterUV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FConvolutionBloomSettings_CenterUV_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FConvolutionBloomSettings_PreFilterMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FConvolutionBloomSettings_PreFilterMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FConvolutionBloomSettings_PreFilterMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FConvolutionBloomSettings_PreFilterMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FConvolutionBloomSettings_PreFilterMult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FConvolutionBloomSettings_PreFilterMult_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FConvolutionBloomSettings_Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FConvolutionBloomSettings_Size_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FConvolutionBloomSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FConvolutionBloomSettings_ExportToPostProcessSettings(IntPtr self, IntPtr outPostProcessSettings);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Implicit buffer region as a fraction of the screen size to insure the bloom does not wrap across the screen.  Larger sizes have perf impact.
		/// </summary>
		public float ConvolutionBuffer
		{
			get => E_PROP_FConvolutionBloomSettings_BufferScale_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_BufferScale_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The UV location of the center of the kernel.  Should be very close to (.5,.5)
		/// </summary>
		public FVector2D ConvolutionCenter
		{
			get => E_PROP_FConvolutionBloomSettings_CenterUV_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_CenterUV_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Boost intensity of select pixels  prior to computing bloom convolution (Min, Max, Multiplier).  Max < Min disables
		/// </summary>
		public float ConvolutionBoostMax
		{
			get => E_PROP_FConvolutionBloomSettings_PreFilterMax_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_PreFilterMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Boost intensity of select pixels  prior to computing bloom convolution (Min, Max, Multiplier).  Max < Min disables
		/// </summary>
		public float ConvolutionBoostMin
		{
			get => E_PROP_FConvolutionBloomSettings_PreFilterMin_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_PreFilterMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Boost intensity of select pixels  prior to computing bloom convolution (Min, Max, Multiplier).  Max < Min disables
		/// </summary>
		public float ConvolutionBoostMult
		{
			get => E_PROP_FConvolutionBloomSettings_PreFilterMult_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_PreFilterMult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Relative size of the convolution kernel image compared to the minor axis of the viewport
		/// </summary>
		public float ConvolutionScale
		{
			get => E_PROP_FConvolutionBloomSettings_Size_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_Size_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings outPostProcessSettings)
			=> E_FConvolutionBloomSettings_ExportToPostProcessSettings(this, outPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FConvolutionBloomSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FConvolutionBloomSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FConvolutionBloomSettings(Adress, false);
		}}}
