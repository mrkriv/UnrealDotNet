using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:603

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
		private static extern IntPtr E_PROP_UEngine_PhysicErrorCorrection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngine_PhysicErrorCorrection_SET(IntPtr Ptr, IntPtr Value);
		
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
		private static extern void E_UEngine_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UEngine_GetDynamicResolutionStatus(IntPtr Self);
		
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
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEngine_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEngine_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UEngine_GetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_OnClusterMarkedAsPendingKill(IntPtr Self);
		
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

		public FRigidBodyErrorCorrection PhysicErrorCorrection
		{
			get => E_PROP_UEngine_PhysicErrorCorrection_GET(NativePointer);
			set => E_PROP_UEngine_PhysicErrorCorrection_SET(NativePointer, value);
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
		public override void FinishDestroy()
			=> E_UEngine_FinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns the current status of dynamic resolution. </para>
		/// </summary>
		public EDynamicResolutionStatus GetDynamicResolutionStatus()
			=> (EDynamicResolutionStatus)E_UEngine_GetDynamicResolutionStatus(this);
		
		
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
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_UEngine_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an </para>
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy()
			=> E_UEngine_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public override bool CheckDefaultSubobjectsInternal()
			=> E_UEngine_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_UEngine_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_UEngine_GetDetailedInfoInternal(this);
		
		public override UWorld GetWorld()
			=> E_UEngine_GetWorld(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_UEngine_IsAsset(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine if the object is forced to be editor only or not </para>
		/// <return>true if this object should never be loaded outside the editor </return>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_UEngine_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_UEngine_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_UEngine_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_UEngine_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_UEngine_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the </para>
		/// <para>potentially asynchronous object cleanup. </para>
		/// <return>True if the object's asynchronous cleanup has completed and it is ready for FinishDestroy to be called. </return>
		/// </summary>
		public override bool IsReadyForFinishDestroy()
			=> E_UEngine_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_UEngine_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_UEngine_IsSupportedForNetworking(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_UEngine_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_UEngine_Modify(this, bAlwaysMarkDirty);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on clients </para>
		/// <return>true if this object should be loaded on clients </return>
		/// </summary>
		public override bool NeedsLoadForClient()
			=> E_UEngine_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will still get loaded if NeedsLoadForServer/Client are true </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_UEngine_NeedsLoadForEditorGame(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on servers </para>
		/// <return>true if this object should be loaded on servers </return>
		/// </summary>
		public override bool NeedsLoadForServer()
			=> E_UEngine_NeedsLoadForServer(this);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_UEngine_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_UEngine_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_UEngine_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor and after the properties have been initialized, including those loaded from config. </para>
		/// <para>mainly this is to emulate some behavior of when the constructor was called after the properties were initialized. </para>
		/// </summary>
		public override void PostInitProperties()
			=> E_UEngine_PostInitProperties(this);
		
		
		/// <summary>
		/// <para>Do any object-specific cleanup required immediately after loading an object, </para>
		/// <para>and immediately after any undo/redo. </para>
		/// </summary>
		public override void PostLoad()
			=> E_UEngine_PostLoad(this);
		
		
		/// <summary>
		/// <para>Called right after receiving a bunch </para>
		/// </summary>
		public override void PostNetReceive()
			=> E_UEngine_PostNetReceive(this);
		
		
		/// <summary>
		/// <para>Test the selection state of a UObject </para>
		/// <return>true if the object is selected, false otherwise. </return>
		/// <para>@todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better </para>
		/// </summary>
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_UEngine_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies()
			=> E_UEngine_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UEngine_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_UEngine_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// <para>Called right before receiving a bunch </para>
		/// </summary>
		public override void PreNetReceive()
			=> E_UEngine_PreNetReceive(this);
		
		public override void ShutdownAfterError()
			=> E_UEngine_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_UEngine_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_UEngine_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public override bool CanBeInCluster()
			=> E_UEngine_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_UEngine_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_UEngine_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(UEngine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UEngine(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngine>(PtrDesc);
		}}}
