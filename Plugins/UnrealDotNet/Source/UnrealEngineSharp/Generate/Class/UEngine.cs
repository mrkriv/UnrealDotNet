using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:630

namespace UnrealEngine
{
	public  partial class UEngine : UObject
	{
		public UEngine(IntPtr Adress)
			: base(Adress)
		{
		}

		public UEngine(UObject Parent = null, string Name = "Engine")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEngine(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEngine(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UEngine_bIsInitialized_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_bIsInitialized_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_BSPSelectionHighlightIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_BSPSelectionHighlightIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_CameraRotationThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_CameraRotationThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_CameraTranslationThreshold_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_CameraTranslationThreshold_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UEngine_ClientCycles_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_ClientCycles_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_DisplayGamma_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_DisplayGamma_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_FixedFrameRate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_FixedFrameRate_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UEngine_GameCycles_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_GameCycles_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEngine_GameScreenshotSaveDirectory_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_GameScreenshotSaveDirectory_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UEngine_GameSingleton_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_GameSingleton_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_HoverHighlightIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_HoverHighlightIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_IdealLightMapDensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_IdealLightMapDensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_LevelColorationLitMaterialName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_LevelColorationLitMaterialName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_LevelColorationUnlitMaterialName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_LevelColorationUnlitMaterialName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_LightingTexelDensityName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_LightingTexelDensityName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_MaxES3PixelShaderAdditiveComplexityCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MaxES3PixelShaderAdditiveComplexityCount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UEngine_MaximumLoopIterationCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MaximumLoopIterationCount_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_MaxLightMapDensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MaxLightMapDensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_MaxOcclusionPixelsFraction_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MaxOcclusionPixelsFraction_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UEngine_MaxParticleResize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MaxParticleResize_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UEngine_MaxParticleResizeWarn_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MaxParticleResizeWarn_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_MeshLODRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MeshLODRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_MinDesiredFrameRate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MinDesiredFrameRate_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_MinLightMapDensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_MinLightMapDensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_NearClipPlane_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_NearClipPlane_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_NetClientTicksPerSecond_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_NetClientTicksPerSecond_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_ParticleEventManagerClassPath_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_ParticleEventManagerClassPath_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_PrimitiveProbablyVisibleTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_PrimitiveProbablyVisibleTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_RenderLightMapDensityColorScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_RenderLightMapDensityColorScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_SelectionHighlightIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_SelectionHighlightIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_SelectionHighlightIntensityBillboards_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_SelectionHighlightIntensityBillboards_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_ShadedLevelColorationLitMaterialName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_ShadedLevelColorationLitMaterialName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UEngine_StreamingDistanceFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_StreamingDistanceFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UEngine_TickCycles_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_TickCycles_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_TransitionDescription_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_TransitionDescription_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_TransitionGameMode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_TransitionGameMode_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_VertexColorMaterialName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_VertexColorMaterialName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_VertexColorViewModeMaterialName_AlphaAsColor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_VertexColorViewModeMaterialName_AlphaAsColor_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_VertexColorViewModeMaterialName_BlueOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_VertexColorViewModeMaterialName_BlueOnly_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_VertexColorViewModeMaterialName_ColorOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_VertexColorViewModeMaterialName_ColorOnly_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_VertexColorViewModeMaterialName_GreenOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_VertexColorViewModeMaterialName_GreenOnly_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_VertexColorViewModeMaterialName_RedOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_VertexColorViewModeMaterialName_RedOnly_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngine_WireframeMaterialName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_WireframeMaterialName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_GetDynamicResolutionCurrentStateInfos(IntPtr Self, IntPtr OutInfos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_GetDynamicResolutionUserSetting(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsInitialized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_ParseCommandline(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PauseDynamicResolution(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PreExit(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_RestoreSelectedMaterialColor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_ResumeDynamicResolution(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_SetDynamicResolutionUserSetting(IntPtr Self, bool Enable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_ShutdownAudioDeviceManager(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_ShutdownHMD(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_Start(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_Tick(IntPtr Self, float DeltaSeconds, bool bIdleMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_WorldAdded(IntPtr Self, IntPtr World);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_WorldDestroyed(IntPtr Self, IntPtr InWorld);
		
		#endregion
		
		#region Property
		public bool bIsInitialized
		{
			get => E_PROP_UEngine_bIsInitialized_GET(NativePointer);
			set => E_PROP_UEngine_bIsInitialized_SET(NativePointer, value);
		}

		public float BSPSelectionHighlightIntensity
		{
			get => E_PROP_UEngine_BSPSelectionHighlightIntensity_GET(NativePointer);
			set => E_PROP_UEngine_BSPSelectionHighlightIntensity_SET(NativePointer, value);
		}

		public float CameraRotationThreshold
		{
			get => E_PROP_UEngine_CameraRotationThreshold_GET(NativePointer);
			set => E_PROP_UEngine_CameraRotationThreshold_SET(NativePointer, value);
		}

		public float CameraTranslationThreshold
		{
			get => E_PROP_UEngine_CameraTranslationThreshold_GET(NativePointer);
			set => E_PROP_UEngine_CameraTranslationThreshold_SET(NativePointer, value);
		}

		public int ClientCycles
		{
			get => E_PROP_UEngine_ClientCycles_GET(NativePointer);
			set => E_PROP_UEngine_ClientCycles_SET(NativePointer, value);
		}

		public float DisplayGamma
		{
			get => E_PROP_UEngine_DisplayGamma_GET(NativePointer);
			set => E_PROP_UEngine_DisplayGamma_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The fixed framerate to use. </para>
		/// </summary>
		public float FixedFrameRate
		{
			get => E_PROP_UEngine_FixedFrameRate_GET(NativePointer);
			set => E_PROP_UEngine_FixedFrameRate_SET(NativePointer, value);
		}

		public int GameCycles
		{
			get => E_PROP_UEngine_GameCycles_GET(NativePointer);
			set => E_PROP_UEngine_GameCycles_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The save directory for newly created screenshots </para>
		/// </summary>
		public FDirectoryPath GameScreenshotSaveDirectory
		{
			get => E_PROP_UEngine_GameScreenshotSaveDirectory_GET(NativePointer);
			set => E_PROP_UEngine_GameScreenshotSaveDirectory_SET(NativePointer, value);
		}

		public UObject GameSingleton
		{
			get => E_PROP_UEngine_GameSingleton_GET(NativePointer);
			set => E_PROP_UEngine_GameSingleton_SET(NativePointer, value);
		}

		public float HoverHighlightIntensity
		{
			get => E_PROP_UEngine_HoverHighlightIntensity_GET(NativePointer);
			set => E_PROP_UEngine_HoverHighlightIntensity_SET(NativePointer, value);
		}

		public float IdealLightMapDensity
		{
			get => E_PROP_UEngine_IdealLightMapDensity_GET(NativePointer);
			set => E_PROP_UEngine_IdealLightMapDensity_SET(NativePointer, value);
		}

		public string LevelColorationLitMaterialName
		{
			get => E_PROP_UEngine_LevelColorationLitMaterialName_GET(NativePointer);
			set => E_PROP_UEngine_LevelColorationLitMaterialName_SET(NativePointer, value);
		}

		public string LevelColorationUnlitMaterialName
		{
			get => E_PROP_UEngine_LevelColorationUnlitMaterialName_GET(NativePointer);
			set => E_PROP_UEngine_LevelColorationUnlitMaterialName_SET(NativePointer, value);
		}

		public string LightingTexelDensityName
		{
			get => E_PROP_UEngine_LightingTexelDensityName_GET(NativePointer);
			set => E_PROP_UEngine_LightingTexelDensityName_SET(NativePointer, value);
		}

		public float MaxES2PixelShaderAdditiveComplexityCount
		{
			get => E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_GET(NativePointer);
			set => E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_SET(NativePointer, value);
		}

		public float MaxES3PixelShaderAdditiveComplexityCount
		{
			get => E_PROP_UEngine_MaxES3PixelShaderAdditiveComplexityCount_GET(NativePointer);
			set => E_PROP_UEngine_MaxES3PixelShaderAdditiveComplexityCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Script maximum loop iteration count used as a threshold to warn users about script execution runaway </para>
		/// </summary>
		public int MaximumLoopIterationCount
		{
			get => E_PROP_UEngine_MaximumLoopIterationCount_GET(NativePointer);
			set => E_PROP_UEngine_MaximumLoopIterationCount_SET(NativePointer, value);
		}

		public float MaxLightMapDensity
		{
			get => E_PROP_UEngine_MaxLightMapDensity_GET(NativePointer);
			set => E_PROP_UEngine_MaxLightMapDensity_SET(NativePointer, value);
		}

		public float MaxOcclusionPixelsFraction
		{
			get => E_PROP_UEngine_MaxOcclusionPixelsFraction_GET(NativePointer);
			set => E_PROP_UEngine_MaxOcclusionPixelsFraction_SET(NativePointer, value);
		}

		public int MaxParticleResize
		{
			get => E_PROP_UEngine_MaxParticleResize_GET(NativePointer);
			set => E_PROP_UEngine_MaxParticleResize_SET(NativePointer, value);
		}

		public int MaxParticleResizeWarn
		{
			get => E_PROP_UEngine_MaxParticleResizeWarn_GET(NativePointer);
			set => E_PROP_UEngine_MaxParticleResizeWarn_SET(NativePointer, value);
		}

		public float MaxPixelShaderAdditiveComplexityCount
		{
			get => E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_GET(NativePointer);
			set => E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_SET(NativePointer, value);
		}

		public float MeshLODRange
		{
			get => E_PROP_UEngine_MeshLODRange_GET(NativePointer);
			set => E_PROP_UEngine_MeshLODRange_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Minimum desired framerate setting </para>
		/// </summary>
		public float MinDesiredFrameRate
		{
			get => E_PROP_UEngine_MinDesiredFrameRate_GET(NativePointer);
			set => E_PROP_UEngine_MinDesiredFrameRate_SET(NativePointer, value);
		}

		public float MinLightMapDensity
		{
			get => E_PROP_UEngine_MinLightMapDensity_GET(NativePointer);
			set => E_PROP_UEngine_MinLightMapDensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The distance of the camera's near clipping plane. </para>
		/// </summary>
		public float NearClipPlane
		{
			get => E_PROP_UEngine_NearClipPlane_GET(NativePointer);
			set => E_PROP_UEngine_NearClipPlane_SET(NativePointer, value);
		}

		public float NetClientTicksPerSecond
		{
			get => E_PROP_UEngine_NetClientTicksPerSecond_GET(NativePointer);
			set => E_PROP_UEngine_NetClientTicksPerSecond_SET(NativePointer, value);
		}

		public int NumPawnsAllowedToBeSpawnedInAFrame
		{
			get => E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_GET(NativePointer);
			set => E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_SET(NativePointer, value);
		}

		public string ParticleEventManagerClassPath
		{
			get => E_PROP_UEngine_ParticleEventManagerClassPath_GET(NativePointer);
			set => E_PROP_UEngine_ParticleEventManagerClassPath_SET(NativePointer, value);
		}

		public float PrimitiveProbablyVisibleTime
		{
			get => E_PROP_UEngine_PrimitiveProbablyVisibleTime_GET(NativePointer);
			set => E_PROP_UEngine_PrimitiveProbablyVisibleTime_SET(NativePointer, value);
		}

		public float RenderLightMapDensityColorScale
		{
			get => E_PROP_UEngine_RenderLightMapDensityColorScale_GET(NativePointer);
			set => E_PROP_UEngine_RenderLightMapDensityColorScale_SET(NativePointer, value);
		}

		public float RenderLightMapDensityGrayscaleScale
		{
			get => E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_GET(NativePointer);
			set => E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_SET(NativePointer, value);
		}

		public float SelectionHighlightIntensity
		{
			get => E_PROP_UEngine_SelectionHighlightIntensity_GET(NativePointer);
			set => E_PROP_UEngine_SelectionHighlightIntensity_SET(NativePointer, value);
		}

		public float SelectionHighlightIntensityBillboards
		{
			get => E_PROP_UEngine_SelectionHighlightIntensityBillboards_GET(NativePointer);
			set => E_PROP_UEngine_SelectionHighlightIntensityBillboards_SET(NativePointer, value);
		}

		public float SelectionMeshSectionHighlightIntensity
		{
			get => E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_GET(NativePointer);
			set => E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_SET(NativePointer, value);
		}

		public string ShadedLevelColorationLitMaterialName
		{
			get => E_PROP_UEngine_ShadedLevelColorationLitMaterialName_GET(NativePointer);
			set => E_PROP_UEngine_ShadedLevelColorationLitMaterialName_SET(NativePointer, value);
		}

		public string ShadedLevelColorationUnlitMaterialName
		{
			get => E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_GET(NativePointer);
			set => E_PROP_UEngine_ShadedLevelColorationUnlitMaterialName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Fudge factor for tweaking the distance based miplevel determination </para>
		/// </summary>
		public float StreamingDistanceFactor
		{
			get => E_PROP_UEngine_StreamingDistanceFactor_GET(NativePointer);
			set => E_PROP_UEngine_StreamingDistanceFactor_SET(NativePointer, value);
		}

		public int TickCycles
		{
			get => E_PROP_UEngine_TickCycles_GET(NativePointer);
			set => E_PROP_UEngine_TickCycles_SET(NativePointer, value);
		}

		public string TransitionDescription
		{
			get => E_PROP_UEngine_TransitionDescription_GET(NativePointer);
			set => E_PROP_UEngine_TransitionDescription_SET(NativePointer, value);
		}

		public string TransitionGameMode
		{
			get => E_PROP_UEngine_TransitionGameMode_GET(NativePointer);
			set => E_PROP_UEngine_TransitionGameMode_SET(NativePointer, value);
		}

		public string VertexColorMaterialName
		{
			get => E_PROP_UEngine_VertexColorMaterialName_GET(NativePointer);
			set => E_PROP_UEngine_VertexColorMaterialName_SET(NativePointer, value);
		}

		public string VertexColorViewModeMaterialName_AlphaAsColor
		{
			get => E_PROP_UEngine_VertexColorViewModeMaterialName_AlphaAsColor_GET(NativePointer);
			set => E_PROP_UEngine_VertexColorViewModeMaterialName_AlphaAsColor_SET(NativePointer, value);
		}

		public string VertexColorViewModeMaterialName_BlueOnly
		{
			get => E_PROP_UEngine_VertexColorViewModeMaterialName_BlueOnly_GET(NativePointer);
			set => E_PROP_UEngine_VertexColorViewModeMaterialName_BlueOnly_SET(NativePointer, value);
		}

		public string VertexColorViewModeMaterialName_ColorOnly
		{
			get => E_PROP_UEngine_VertexColorViewModeMaterialName_ColorOnly_GET(NativePointer);
			set => E_PROP_UEngine_VertexColorViewModeMaterialName_ColorOnly_SET(NativePointer, value);
		}

		public string VertexColorViewModeMaterialName_GreenOnly
		{
			get => E_PROP_UEngine_VertexColorViewModeMaterialName_GreenOnly_GET(NativePointer);
			set => E_PROP_UEngine_VertexColorViewModeMaterialName_GreenOnly_SET(NativePointer, value);
		}

		public string VertexColorViewModeMaterialName_RedOnly
		{
			get => E_PROP_UEngine_VertexColorViewModeMaterialName_RedOnly_GET(NativePointer);
			set => E_PROP_UEngine_VertexColorViewModeMaterialName_RedOnly_SET(NativePointer, value);
		}

		public string WireframeMaterialName
		{
			get => E_PROP_UEngine_WireframeMaterialName_GET(NativePointer);
			set => E_PROP_UEngine_WireframeMaterialName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Queries informations about the current state dynamic resolution. </para>
		/// </summary>
		public void GetDynamicResolutionCurrentStateInfos(FDynamicResolutionStateInfos OutInfos)
			=> E_UEngine_GetDynamicResolutionCurrentStateInfos(this, OutInfos);
		
		
		/// <summary>
		/// <para>Get the user setting for dynamic resolution. </para>
		/// </summary>
		public bool GetDynamicResolutionUserSetting()
			=> E_UEngine_GetDynamicResolutionUserSetting(this);
		
		public virtual bool IsInitialized()
			=> E_UEngine_IsInitialized(this);
		
		
		/// <summary>
		/// <para>Called at startup, in the middle of FEngineLoop::Init. </para>
		/// </summary>
		public void ParseCommandline()
			=> E_UEngine_ParseCommandline(this);
		
		
		/// <summary>
		/// <para>Pause dynamic resolution for this frame. </para>
		/// </summary>
		public void PauseDynamicResolution()
			=> E_UEngine_PauseDynamicResolution(this);
		
		
		/// <summary>
		/// <para>Called at shutdown, just before the exit purge. </para>
		/// </summary>
		public virtual void PreExit()
			=> E_UEngine_PreExit(this);
		
		
		/// <summary>
		/// <para>Restores the selected material color back to the user setting </para>
		/// </summary>
		public void RestoreSelectedMaterialColor()
			=> E_UEngine_RestoreSelectedMaterialColor(this);
		
		
		/// <summary>
		/// <para>Resume dynamic resolution for this frame. </para>
		/// </summary>
		public void ResumeDynamicResolution()
			=> E_UEngine_ResumeDynamicResolution(this);
		
		
		/// <summary>
		/// <para>Set the user setting for dynamic resolution. </para>
		/// </summary>
		public void SetDynamicResolutionUserSetting(bool Enable)
			=> E_UEngine_SetDynamicResolutionUserSetting(this, Enable);
		
		public virtual void ShutdownAudioDeviceManager()
			=> E_UEngine_ShutdownAudioDeviceManager(this);
		
		public void ShutdownHMD()
			=> E_UEngine_ShutdownHMD(this);
		
		
		/// <summary>
		/// <para>Start the game, separate from the initialize call to allow for post initialize configuration before the game starts. </para>
		/// </summary>
		public virtual void Start()
			=> E_UEngine_Start(this);
		
		
		/// <summary>
		/// <para>Update everything. </para>
		/// </summary>
		public virtual void Tick(float DeltaSeconds, bool bIdleMode)
			=> E_UEngine_Tick(this, DeltaSeconds, bIdleMode);
		
		
		/// <summary>
		/// <para>Needs to be called when a world is added to broadcast messages. </para>
		/// </summary>
		public virtual void WorldAdded(UWorld World)
			=> E_UEngine_WorldAdded(this, World);
		
		
		/// <summary>
		/// <para>Needs to be called when a world is destroyed to broadcast messages. </para>
		/// </summary>
		public virtual void WorldDestroyed(UWorld InWorld)
			=> E_UEngine_WorldDestroyed(this, InWorld);
		
		#endregion
		
		public static implicit operator IntPtr(UEngine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UEngine(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngine>(PtrDesc);
		}}}
