using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Used to create fogging effects such as clouds but with a density that is related to the height of the fog.
	/// </summary>
	public partial class UExponentialHeightFogComponent : USceneComponent
	{
		public UExponentialHeightFogComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UExponentialHeightFogComponent_SetFogDensity(IntPtr Self, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UExponentialHeightFogComponent_SetVolumetricFog(IntPtr Self, bool bNewValue);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Whether to use FogInscatteringColor for the Sky Light volumetric scattering color and DirectionalInscatteringColor for the Directional Light scattering color.
		/// Make sure your directional light has 'Atmosphere Sun Light' enabled!
		/// Enabling this allows Volumetric fog to better match Height fog in the distance, but produces non-physical volumetric lighting that may not match surface lighting.
		/// </summary>
		public void SetFogDensity(float Value)
			=> E_UExponentialHeightFogComponent_SetFogDensity(NativePointer, Value);
		
		public void SetVolumetricFog(bool bNewValue)
			=> E_UExponentialHeightFogComponent_SetVolumetricFog(NativePointer, bNewValue);
		
		#endregion
		
		public static implicit operator IntPtr(UExponentialHeightFogComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UExponentialHeightFogComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UExponentialHeightFogComponent(Adress);
		}}}
