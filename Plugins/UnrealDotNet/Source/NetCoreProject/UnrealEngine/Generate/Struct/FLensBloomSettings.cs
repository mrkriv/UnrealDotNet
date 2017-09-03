using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FLensBloomSettings : NativeStructWrapper
	{
		public FLensBloomSettings() : base(E_CreateStruct_FLensBloomSettings(), false)
		{
		}

		internal FLensBloomSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FLensBloomSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FLensBloomSettings_Convolution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLensBloomSettings_Convolution_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Bloom convolution method specific settings. </para>
		/// </summary>
		public FConvolutionBloomSettings Convolution
		{
			get => E_PROP_FLensBloomSettings_Convolution_GET(NativePointer);
			set => E_PROP_FLensBloomSettings_Convolution_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLensBloomSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLensBloomSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensBloomSettings(Adress, false);
		}}}
