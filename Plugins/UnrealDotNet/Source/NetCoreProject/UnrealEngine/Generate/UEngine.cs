using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Abstract base class of all Engine classes, responsible for management of systems critical to editor or game systems.
	/// Also defines default classes for certain engine systems.
	/// </summary>
	public partial class UEngine : UObject
	{
		public UEngine(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_MinLightMapDensity_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MinLightMapDensity_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_IdealLightMapDensity_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_IdealLightMapDensity_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_MaxLightMapDensity_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MaxLightMapDensity_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_RenderLightMapDensityColorScale_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_RenderLightMapDensityColorScale_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_PROP_UEngine_TickCycles_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_TickCycles_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_PROP_UEngine_GameCycles_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_GameCycles_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_PROP_UEngine_ClientCycles_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_ClientCycles_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_NearClipPlane_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_NearClipPlane_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_PROP_UEngine_MaximumLoopIterationCount_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MaximumLoopIterationCount_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_FixedFrameRate_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_FixedFrameRate_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_StreamingDistanceFactor_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_StreamingDistanceFactor_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_MeshLODRange_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MeshLODRange_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_CameraRotationThreshold_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_CameraRotationThreshold_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_CameraTranslationThreshold_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_CameraTranslationThreshold_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_PrimitiveProbablyVisibleTime_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_PrimitiveProbablyVisibleTime_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_MaxOcclusionPixelsFraction_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MaxOcclusionPixelsFraction_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_PROP_UEngine_MaxParticleResize_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MaxParticleResize_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_PROP_UEngine_MaxParticleResizeWarn_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MaxParticleResizeWarn_SET(IntPtr Ptr, int Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_NetClientTicksPerSecond_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_NetClientTicksPerSecond_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_DisplayGamma_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_DisplayGamma_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_MinDesiredFrameRate_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_MinDesiredFrameRate_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_SelectionHighlightIntensity_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_SelectionHighlightIntensity_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_BSPSelectionHighlightIntensity_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_BSPSelectionHighlightIntensity_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_HoverHighlightIntensity_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_HoverHighlightIntensity_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_UEngine_SelectionHighlightIntensityBillboards_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_SelectionHighlightIntensityBillboards_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PROP_UEngine_bIsInitialized_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_UEngine_bIsInitialized_SET(IntPtr Ptr, bool Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UEngine_RestoreSelectedMaterialColor(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UEngine_WorldAdded(IntPtr Self, UWorld World);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UEngine_IsInitialized(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UEngine_Tick(IntPtr Self, float DeltaSeconds, bool bIdleMode);
		
		#endregion
		
		#region Property
		public float MaxPixelShaderAdditiveComplexityCount
		{
			get => E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_GET(NativePointer);
			set => E_PROP_UEngine_MaxPixelShaderAdditiveComplexityCount_SET(NativePointer, value);
		}

		public float MaxES2PixelShaderAdditiveComplexityCount
		{
			get => E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_GET(NativePointer);
			set => E_PROP_UEngine_MaxES2PixelShaderAdditiveComplexityCount_SET(NativePointer, value);
		}

		public float MinLightMapDensity
		{
			get => E_PROP_UEngine_MinLightMapDensity_GET(NativePointer);
			set => E_PROP_UEngine_MinLightMapDensity_SET(NativePointer, value);
		}

		public float IdealLightMapDensity
		{
			get => E_PROP_UEngine_IdealLightMapDensity_GET(NativePointer);
			set => E_PROP_UEngine_IdealLightMapDensity_SET(NativePointer, value);
		}

		public float MaxLightMapDensity
		{
			get => E_PROP_UEngine_MaxLightMapDensity_GET(NativePointer);
			set => E_PROP_UEngine_MaxLightMapDensity_SET(NativePointer, value);
		}

		public float RenderLightMapDensityGrayscaleScale
		{
			get => E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_GET(NativePointer);
			set => E_PROP_UEngine_RenderLightMapDensityGrayscaleScale_SET(NativePointer, value);
		}

		public float RenderLightMapDensityColorScale
		{
			get => E_PROP_UEngine_RenderLightMapDensityColorScale_GET(NativePointer);
			set => E_PROP_UEngine_RenderLightMapDensityColorScale_SET(NativePointer, value);
		}

		public int TickCycles
		{
			get => E_PROP_UEngine_TickCycles_GET(NativePointer);
			set => E_PROP_UEngine_TickCycles_SET(NativePointer, value);
		}

		public int GameCycles
		{
			get => E_PROP_UEngine_GameCycles_GET(NativePointer);
			set => E_PROP_UEngine_GameCycles_SET(NativePointer, value);
		}

		public int ClientCycles
		{
			get => E_PROP_UEngine_ClientCycles_GET(NativePointer);
			set => E_PROP_UEngine_ClientCycles_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The distance of the camera's near clipping plane.
		/// </summary>
		public float NearClipPlane
		{
			get => E_PROP_UEngine_NearClipPlane_GET(NativePointer);
			set => E_PROP_UEngine_NearClipPlane_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Script maximum loop iteration count used as a threshold to warn users about script execution runaway
		/// </summary>
		public int MaximumLoopIterationCount
		{
			get => E_PROP_UEngine_MaximumLoopIterationCount_GET(NativePointer);
			set => E_PROP_UEngine_MaximumLoopIterationCount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The fixed framerate to use.
		/// </summary>
		public float FixedFrameRate
		{
			get => E_PROP_UEngine_FixedFrameRate_GET(NativePointer);
			set => E_PROP_UEngine_FixedFrameRate_SET(NativePointer, value);
		}

		public int NumPawnsAllowedToBeSpawnedInAFrame
		{
			get => E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_GET(NativePointer);
			set => E_PROP_UEngine_NumPawnsAllowedToBeSpawnedInAFrame_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Fudge factor for tweaking the distance based miplevel determination
		/// </summary>
		public float StreamingDistanceFactor
		{
			get => E_PROP_UEngine_StreamingDistanceFactor_GET(NativePointer);
			set => E_PROP_UEngine_StreamingDistanceFactor_SET(NativePointer, value);
		}

		public float MeshLODRange
		{
			get => E_PROP_UEngine_MeshLODRange_GET(NativePointer);
			set => E_PROP_UEngine_MeshLODRange_SET(NativePointer, value);
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

		public float PrimitiveProbablyVisibleTime
		{
			get => E_PROP_UEngine_PrimitiveProbablyVisibleTime_GET(NativePointer);
			set => E_PROP_UEngine_PrimitiveProbablyVisibleTime_SET(NativePointer, value);
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

		public float NetClientTicksPerSecond
		{
			get => E_PROP_UEngine_NetClientTicksPerSecond_GET(NativePointer);
			set => E_PROP_UEngine_NetClientTicksPerSecond_SET(NativePointer, value);
		}

		public float DisplayGamma
		{
			get => E_PROP_UEngine_DisplayGamma_GET(NativePointer);
			set => E_PROP_UEngine_DisplayGamma_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Minimum desired framerate setting
		/// </summary>
		public float MinDesiredFrameRate
		{
			get => E_PROP_UEngine_MinDesiredFrameRate_GET(NativePointer);
			set => E_PROP_UEngine_MinDesiredFrameRate_SET(NativePointer, value);
		}

		public float SelectionHighlightIntensity
		{
			get => E_PROP_UEngine_SelectionHighlightIntensity_GET(NativePointer);
			set => E_PROP_UEngine_SelectionHighlightIntensity_SET(NativePointer, value);
		}

		public float SelectionMeshSectionHighlightIntensity
		{
			get => E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_GET(NativePointer);
			set => E_PROP_UEngine_SelectionMeshSectionHighlightIntensity_SET(NativePointer, value);
		}

		public float BSPSelectionHighlightIntensity
		{
			get => E_PROP_UEngine_BSPSelectionHighlightIntensity_GET(NativePointer);
			set => E_PROP_UEngine_BSPSelectionHighlightIntensity_SET(NativePointer, value);
		}

		public float HoverHighlightIntensity
		{
			get => E_PROP_UEngine_HoverHighlightIntensity_GET(NativePointer);
			set => E_PROP_UEngine_HoverHighlightIntensity_SET(NativePointer, value);
		}

		public float SelectionHighlightIntensityBillboards
		{
			get => E_PROP_UEngine_SelectionHighlightIntensityBillboards_GET(NativePointer);
			set => E_PROP_UEngine_SelectionHighlightIntensityBillboards_SET(NativePointer, value);
		}

		public bool bIsInitialized
		{
			get => E_PROP_UEngine_bIsInitialized_GET(NativePointer);
			set => E_PROP_UEngine_bIsInitialized_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Restores the selected material color back to the user setting
		/// </summary>
		public void RestoreSelectedMaterialColor()
			=> E_UEngine_RestoreSelectedMaterialColor(NativePointer);
		
		
		/// <summary>
		/// Needs to be called when a world is added to broadcast messages.
		/// </summary>
		public void WorldAdded(UWorld World)
			=> E_UEngine_WorldAdded(NativePointer, World);
		
		public bool IsInitialized()
			=> E_UEngine_IsInitialized(NativePointer);
		
		
		/// <summary>
		/// Update everything.
		/// </summary>
		public void Tick(float DeltaSeconds, bool bIdleMode)
			=> E_UEngine_Tick(NativePointer, DeltaSeconds, bIdleMode);
		
		#endregion
		
		public static implicit operator IntPtr(UEngine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UEngine(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UEngine(Adress);
		}}}
