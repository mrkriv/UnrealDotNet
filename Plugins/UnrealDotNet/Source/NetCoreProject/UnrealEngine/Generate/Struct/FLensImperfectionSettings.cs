using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FLensImperfectionSettings
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FLensImperfectionSettings()
		{
			NativePointer = E_CreateStruct_FLensImperfectionSettings();
			IsRef = false;
		}

		internal FLensImperfectionSettings(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FLensImperfectionSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FLensImperfectionSettings_DirtMaskIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FLensImperfectionSettings_DirtMaskIntensity_SET(IntPtr Ptr, float Value);
		
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

		#endregion
		
		public static implicit operator IntPtr(FLensImperfectionSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLensImperfectionSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLensImperfectionSettings(Adress, false);
		}}}
