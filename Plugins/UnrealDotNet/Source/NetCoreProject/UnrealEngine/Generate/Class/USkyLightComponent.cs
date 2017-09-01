using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Construct the sky light from the specified cubemap.
	/// </summary>
	public partial class USkyLightComponent : ULightComponentBase
	{
		public USkyLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_USkyLightComponent_bSavedConstructionScriptValuesValid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_bSavedConstructionScriptValuesValid_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_USkyLightComponent_bHasEverCaptured_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_bHasEverCaptured_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USkyLightComponent_AverageBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_AverageBrightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USkyLightComponent_BlendFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_BlendFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USkyLightComponent_BlendDestinationAverageBrightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USkyLightComponent_BlendDestinationAverageBrightness_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Indicates whether the cached data stored in GetComponentInstanceData is valid to be applied in ApplyComponentInstanceData.
		/// </summary>
		protected bool bSavedConstructionScriptValuesValid
		{
			get => E_PROP_USkyLightComponent_bSavedConstructionScriptValuesValid_GET(NativePointer);
			set => E_PROP_USkyLightComponent_bSavedConstructionScriptValuesValid_SET(NativePointer, value);
		}

		protected bool bHasEverCaptured
		{
			get => E_PROP_USkyLightComponent_bHasEverCaptured_GET(NativePointer);
			set => E_PROP_USkyLightComponent_bHasEverCaptured_SET(NativePointer, value);
		}

		protected float AverageBrightness
		{
			get => E_PROP_USkyLightComponent_AverageBrightness_GET(NativePointer);
			set => E_PROP_USkyLightComponent_AverageBrightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If 0, no blend is present.  If > 0, BlendDestinationProcessedSkyTexture and BlendDestinationIrradianceEnvironmentMap must be generated and used for rendering.
		/// </summary>
		protected float BlendFraction
		{
			get => E_PROP_USkyLightComponent_BlendFraction_GET(NativePointer);
			set => E_PROP_USkyLightComponent_BlendFraction_SET(NativePointer, value);
		}

		protected float BlendDestinationAverageBrightness
		{
			get => E_PROP_USkyLightComponent_BlendDestinationAverageBrightness_GET(NativePointer);
			set => E_PROP_USkyLightComponent_BlendDestinationAverageBrightness_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(USkyLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USkyLightComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new USkyLightComponent(Adress);
		}}}
