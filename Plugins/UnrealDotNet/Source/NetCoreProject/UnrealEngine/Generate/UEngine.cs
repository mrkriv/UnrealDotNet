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
		public float MaxPixelShaderAdditiveComplexityCount { get; set; } 
		public float MaxES2PixelShaderAdditiveComplexityCount { get; set; } 
		public float MinLightMapDensity { get; set; } 
		public float IdealLightMapDensity { get; set; } 
		public float MaxLightMapDensity { get; set; } 
		public float RenderLightMapDensityGrayscaleScale { get; set; } 
		public float RenderLightMapDensityColorScale { get; set; } 
		public int TickCycles { get; set; } 
		public int GameCycles { get; set; } 
		public int ClientCycles { get; set; } 
		
		/// <summary>
		/// The distance of the camera's near clipping plane.
		/// </summary>
		public float NearClipPlane { get; set; } 
		
		/// <summary>
		/// Script maximum loop iteration count used as a threshold to warn users about script execution runaway
		/// </summary>
		public int MaximumLoopIterationCount { get; set; } 
		
		/// <summary>
		/// The fixed framerate to use.
		/// </summary>
		public float FixedFrameRate { get; set; } 
		public int NumPawnsAllowedToBeSpawnedInAFrame { get; set; } 
		
		/// <summary>
		/// Fudge factor for tweaking the distance based miplevel determination
		/// </summary>
		public float StreamingDistanceFactor { get; set; } 
		public float MeshLODRange { get; set; } 
		public float CameraRotationThreshold { get; set; } 
		public float CameraTranslationThreshold { get; set; } 
		public float PrimitiveProbablyVisibleTime { get; set; } 
		public float MaxOcclusionPixelsFraction { get; set; } 
		public int MaxParticleResize { get; set; } 
		public int MaxParticleResizeWarn { get; set; } 
		public float NetClientTicksPerSecond { get; set; } 
		public float DisplayGamma { get; set; } 
		
		/// <summary>
		/// Minimum desired framerate setting
		/// </summary>
		public float MinDesiredFrameRate { get; set; } 
		public float SelectionHighlightIntensity { get; set; } 
		public float SelectionMeshSectionHighlightIntensity { get; set; } 
		public float BSPSelectionHighlightIntensity { get; set; } 
		public float HoverHighlightIntensity { get; set; } 
		public float SelectionHighlightIntensityBillboards { get; set; } 
		public bool bIsInitialized { get; set; } 
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
		
		public static explicit operator IntPtr(UEngine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UEngine(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UEngine(Adress);
		}}}
