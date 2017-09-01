using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FConvolutionBloomSettings
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FConvolutionBloomSettings()
		{
			NativePointer = E_CreateStruct_FConvolutionBloomSettings();
			IsRef = false;
		}

		internal FConvolutionBloomSettings(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FConvolutionBloomSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FConvolutionBloomSettings_Size_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FConvolutionBloomSettings_Size_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector2D E_PROP_FConvolutionBloomSettings_CenterUV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FConvolutionBloomSettings_CenterUV_SET(IntPtr Ptr, FVector2D Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FConvolutionBloomSettings_PreFilterMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FConvolutionBloomSettings_PreFilterMin_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FConvolutionBloomSettings_PreFilterMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FConvolutionBloomSettings_PreFilterMax_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FConvolutionBloomSettings_PreFilterMult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FConvolutionBloomSettings_PreFilterMult_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FConvolutionBloomSettings_BufferScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FConvolutionBloomSettings_BufferScale_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Relative size of the convolution kernel image compared to the minor axis of the viewport
		/// </summary>
		public float ConvolutionScale
		{
			get => E_PROP_FConvolutionBloomSettings_Size_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_Size_SET(NativePointer, value);
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
		public float ConvolutionBoostMin
		{
			get => E_PROP_FConvolutionBloomSettings_PreFilterMin_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_PreFilterMin_SET(NativePointer, value);
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
		public float ConvolutionBoostMult
		{
			get => E_PROP_FConvolutionBloomSettings_PreFilterMult_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_PreFilterMult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Implicit buffer region as a fraction of the screen size to insure the bloom does not wrap across the screen.  Larger sizes have perf impact.
		/// </summary>
		public float ConvolutionBuffer
		{
			get => E_PROP_FConvolutionBloomSettings_BufferScale_GET(NativePointer);
			set => E_PROP_FConvolutionBloomSettings_BufferScale_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FConvolutionBloomSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FConvolutionBloomSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FConvolutionBloomSettings(Adress, false);
		}}}
