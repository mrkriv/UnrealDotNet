using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USkyLightComponent : ULightComponentBase
	{
		public USkyLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USkyLightComponent_AverageBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_AverageBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_USkyLightComponent_bHasEverCaptured_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_bHasEverCaptured_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USkyLightComponent_BlendDestinationAverageBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_BlendDestinationAverageBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USkyLightComponent_BlendFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_BlendFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_USkyLightComponent_bSavedConstructionScriptValuesValid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_bSavedConstructionScriptValuesValid_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkyLightComponent_RecaptureSky(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkyLightComponent_SanitizeCubemapSize(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkyLightComponent_SetCaptureIsDirty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USkyLightComponent_UpdateLimitedRenderingStateFast(IntPtr Self);
		
		#endregion
		
		#region Property
		protected float AverageBrightness
		{
			get => E_PROP_USkyLightComponent_AverageBrightness_GET(NativePointer);
			set => E_PROP_USkyLightComponent_AverageBrightness_SET(NativePointer, value);
		}

		protected bool bHasEverCaptured
		{
			get => E_PROP_USkyLightComponent_bHasEverCaptured_GET(NativePointer);
			set => E_PROP_USkyLightComponent_bHasEverCaptured_SET(NativePointer, value);
		}

		protected float BlendDestinationAverageBrightness
		{
			get => E_PROP_USkyLightComponent_BlendDestinationAverageBrightness_GET(NativePointer);
			set => E_PROP_USkyLightComponent_BlendDestinationAverageBrightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If 0, no blend is present.  If > 0, BlendDestinationProcessedSkyTexture and BlendDestinationIrradianceEnvironmentMap must be generated and used for rendering. </para>
		/// </summary>
		protected float BlendFraction
		{
			get => E_PROP_USkyLightComponent_BlendFraction_GET(NativePointer);
			set => E_PROP_USkyLightComponent_BlendFraction_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Indicates whether the cached data stored in GetComponentInstanceData is valid to be applied in ApplyComponentInstanceData. </para>
		/// </summary>
		protected bool bSavedConstructionScriptValuesValid
		{
			get => E_PROP_USkyLightComponent_bSavedConstructionScriptValuesValid_GET(NativePointer);
			set => E_PROP_USkyLightComponent_bSavedConstructionScriptValuesValid_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Recaptures the scene for the skylight. </para>
		/// <para>This is useful for making sure the sky light is up to date after changing something in the world that it would capture. </para>
		/// <para>Warning: this is very costly and will definitely cause a hitch. </para>
		/// </summary>
		public void RecaptureSky()
			=> E_USkyLightComponent_RecaptureSky(this);
		
		public void SanitizeCubemapSize()
			=> E_USkyLightComponent_SanitizeCubemapSize(this);
		
		public void SetBlendDestinationCaptureIsDirty()
			=> E_USkyLightComponent_SetBlendDestinationCaptureIsDirty(this);
		
		
		/// <summary>
		/// <para>Indicates that the capture needs to recapture the scene, adds it to the recapture queue. </para>
		/// </summary>
		public void SetCaptureIsDirty()
			=> E_USkyLightComponent_SetCaptureIsDirty(this);
		
		protected void UpdateLimitedRenderingStateFast()
			=> E_USkyLightComponent_UpdateLimitedRenderingStateFast(this);
		
		#endregion
		
		public static implicit operator IntPtr(USkyLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USkyLightComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USkyLightComponent ?? new USkyLightComponent(Adress);
		}}}
