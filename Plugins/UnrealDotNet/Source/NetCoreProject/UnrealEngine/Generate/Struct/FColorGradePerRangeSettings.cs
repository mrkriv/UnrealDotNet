using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageColorGradePerRangeSettings
	/// <para>Fast Fourier Transform Image based convolution, intended for cinematics (too expensive for games) </para>
	/// </summary>
	public  partial class FColorGradePerRangeSettings : NativeStructWrapper
	{
		public FColorGradePerRangeSettings() : base(E_CreateStruct_FColorGradePerRangeSettings(), false)
		{
		}

		internal FColorGradePerRangeSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FColorGradePerRangeSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Contrast_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Contrast_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Gain_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Gain_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Gamma_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Gamma_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Offset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Offset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FColorGradePerRangeSettings_Saturation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FColorGradePerRangeSettings_Saturation_SET(IntPtr Ptr, IntPtr Value);
		
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
		
		public static implicit operator IntPtr(FColorGradePerRangeSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FColorGradePerRangeSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FColorGradePerRangeSettings(Adress, false);
		}}}
