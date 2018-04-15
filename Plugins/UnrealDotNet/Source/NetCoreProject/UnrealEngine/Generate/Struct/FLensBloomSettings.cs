using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:347

namespace UnrealEngine
{
	public  partial class FLensBloomSettings : NativeStructWrapper
	{
		internal FLensBloomSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLensBloomSettings() :
			base(E_CreateStruct_FLensBloomSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLensBloomSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FLensBloomSettings_Convolution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensBloomSettings_Convolution_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLensBloomSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
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
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FLensBloomSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FLensBloomSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLensBloomSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensBloomSettings(Adress, false);
		}}}
