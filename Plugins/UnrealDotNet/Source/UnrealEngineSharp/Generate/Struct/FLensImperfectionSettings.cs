using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:374

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLensImperfectionSettings();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLensImperfectionSettings_DirtMaskIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLensImperfectionSettings_DirtMaskIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLensImperfectionSettings_ExportToPostProcessSettings(IntPtr Self, IntPtr OutPostProcessSettings);
		
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
		
		#region ExternMethods
		public void ExportToPostProcessSettings(FPostProcessSettings OutPostProcessSettings)
			=> E_FLensImperfectionSettings_ExportToPostProcessSettings(this, OutPostProcessSettings);
		
		#endregion
		
		public static implicit operator IntPtr(FLensImperfectionSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLensImperfectionSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensImperfectionSettings(Adress, false);
		}}}
