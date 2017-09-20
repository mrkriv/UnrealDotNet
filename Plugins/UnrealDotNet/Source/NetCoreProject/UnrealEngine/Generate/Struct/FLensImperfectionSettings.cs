using System;
using System.Runtime.InteropServices;

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLensImperfectionSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLensImperfectionSettings_DirtMaskIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensImperfectionSettings_DirtMaskIntensity_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>BloomDirtMask intensity </para>
		/// </summary>
		public float DirtMaskIntensity
		{
			get => E_PROP_FLensImperfectionSettings_DirtMaskIntensity_GET(NativePointer);
			set => E_PROP_FLensImperfectionSettings_DirtMaskIntensity_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLensImperfectionSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLensImperfectionSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensImperfectionSettings(Adress, false);
		}}}
