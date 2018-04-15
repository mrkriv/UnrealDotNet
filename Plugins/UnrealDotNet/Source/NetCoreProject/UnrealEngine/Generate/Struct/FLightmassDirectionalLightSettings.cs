using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1551

namespace UnrealEngine
{
	public  partial class FLightmassDirectionalLightSettings : FLightmassLightSettings
	{
		internal FLightmassDirectionalLightSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightmassDirectionalLightSettings() :
			base(E_CreateStruct_FLightmassDirectionalLightSettings(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightmassDirectionalLightSettings();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FLightmassDirectionalLightSettings_LightSourceAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightmassDirectionalLightSettings_LightSourceAngle_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Angle that the directional light's emissive surface extends relative to a receiver, affects penumbra sizes. </para>
		/// </summary>
		public float LightSourceAngle
		{
			get => E_PROP_FLightmassDirectionalLightSettings_LightSourceAngle_GET(NativePointer);
			set => E_PROP_FLightmassDirectionalLightSettings_LightSourceAngle_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLightmassDirectionalLightSettings Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLightmassDirectionalLightSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightmassDirectionalLightSettings(Adress, false);
		}}}
