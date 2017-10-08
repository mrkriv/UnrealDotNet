using System;
using System.Runtime.InteropServices;

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FConvolutionBloomSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FConvolutionBloomSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
		#endregion
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FConvolutionBloomSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FConvolutionBloomSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FConvolutionBloomSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FConvolutionBloomSettings(Adress, false);
		}}}
