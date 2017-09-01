using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FReflectionCaptureFullHDR
	{
		protected readonly IntPtr NativePointer;
		
		public FReflectionCaptureFullHDR(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FReflectionCaptureFullHDR_CubemapSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FReflectionCaptureFullHDR_CubemapSize_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FReflectionCaptureFullHDR_HasValidData(IntPtr Self);
		
		#endregion
		
		#region Property
		public int CubemapSize
		{
			get => E_PROP_FReflectionCaptureFullHDR_CubemapSize_GET(NativePointer);
			set => E_PROP_FReflectionCaptureFullHDR_CubemapSize_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool HasValidData()
			=> E_FReflectionCaptureFullHDR_HasValidData(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(FReflectionCaptureFullHDR Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FReflectionCaptureFullHDR(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FReflectionCaptureFullHDR(Adress);
		}}}
