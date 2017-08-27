using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// The World is the top level object representing a map or a sandbox in which Actors and Components will exist and be rendered.
	/// A World can be a single Persistent Level with an optional list of streaming levels that are loaded and unloaded via volumes and blueprint functions
	/// or it can be a collection of levels organized with a World Composition.
	/// In a standalone game, generally only a single World exists except during seamless area transitions when both a destination and current world exists.
	/// In the editor many Worlds exist: The level being edited, each PIE instance, each editor tool which has an interactive rendered viewport, and many more.
	/// </summary>
	public partial class UWorld : UObject
	{
		public UWorld(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_CreateFXSystem(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_SetShouldTick(IntPtr Self, bool bInShouldTick);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_ShouldTick(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_UWorld_GetNumPawns(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_UWorld_GetTimeSeconds(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_UWorld_TimeSince(IntPtr Self, float Time);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_AddNetworkActor(IntPtr Self, AActor Actor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_ContainsActor(IntPtr Self, AActor Actor);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_UWorld_AllowAudioPlayback(IntPtr Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_UpdateWorldComponents(IntPtr Self, bool bRerunConstructionScripts, bool bCurrentLevelOnly);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_CleanupWorld(IntPtr Self, bool bSessionEnded, bool bCleanupResources, UWorld NewWorld);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UWorld_InitWorld(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether we are in the middle of ticking actors/components or not
		/// </summary>
		public bool bInTick { get; set; } 
		
		/// <summary>
		/// Whether we have already built the collision tree or not
		/// </summary>
		public bool bIsBuilt { get; set; } 
		
		/// <summary>
		/// We are in the middle of actor ticking, so add tasks for newly spawned actors
		/// </summary>
		public bool bTickNewlySpawned { get; set; } 
		
		/// <summary>
		/// Indicates that during world ticking we are doing the final component update of dirty components
		/// (after PostAsyncWork and effect physics scene has run.
		/// </summary>
		public bool bPostTickComponentUpdate { get; set; } 
		
		/// <summary>
		/// Counter for allocating game- unique controller player numbers
		/// </summary>
		public int PlayerNum { get; set; } 
		
		/// <summary>
		/// Time in seconds (game time so we respect time dilation) since the last time we purged references to pending kill objects
		/// </summary>
		public float TimeSinceLastPendingKillPurge { get; set; } 
		
		/// <summary>
		/// Whether a full purge has been triggered, so that the next GarbageCollect will do a full purge no matter what.
		/// </summary>
		public bool FullPurgeTriggered { get; set; } 
		
		/// <summary>
		/// Whether we should delay GC for one frame to finish some pending operation
		/// </summary>
		public bool bShouldDelayGarbageCollect { get; set; } 
		
		/// <summary>
		/// Whether world object has been initialized via Init()
		/// </summary>
		public bool bIsWorldInitialized { get; set; } 
		
		/// <summary>
		/// Number of frames to delay Streaming Volume updating, useful if you preload a bunch of levels but the camera hasn't caught up yet (INDEX_NONE for infinite)
		/// </summary>
		public int StreamingVolumeUpdateDelay { get; set; } 
		
		/// <summary>
		/// Is level streaming currently frozen?
		/// </summary>
		public bool bIsLevelStreamingFrozen { get; set; } 
		
		/// <summary>
		/// Is forcibly unloading streaming levels?
		/// </summary>
		public bool bShouldForceUnloadStreamingLevels { get; set; } 
		
		/// <summary>
		/// Is forcibly making streaming levels visible?
		/// </summary>
		public bool bShouldForceVisibleStreamingLevels { get; set; } 
		
		/// <summary>
		/// True we want to execute a call to UpdateCulledTriggerVolumes during Tick
		/// </summary>
		public bool bDoDelayedUpdateCullDistanceVolumes { get; set; } 
		
		/// <summary>
		/// Force UsesGameHiddenFlags to return true.
		/// </summary>
		public bool bHack_Force_UsesGameHiddenFlags_True { get; set; } 
		
		/// <summary>
		/// If true this world is in the process of running the construction script for an actor
		/// </summary>
		public bool bIsRunningConstructionScript { get; set; } 
		
		/// <summary>
		/// If true this world will tick physics to simulate. This isn't same as having Physics Scene.
		/// You need Physics Scene if you'd like to trace. This flag changed ticking
		/// </summary>
		public bool bShouldSimulatePhysics { get; set; } 
		
		/// <summary>
		/// If TRUE, 'hidden' components will still create render proxy, so can draw info (see USceneComponent::ShouldRender)
		/// </summary>
		public bool bCreateRenderStateForHiddenComponents { get; set; } 
		
		/// <summary>
		/// When set to true, all scene queries will be drawn
		/// </summary>
		public bool bDebugDrawAllTraceTags { get; set; } 
		
		/// <summary>
		/// Time in FPlatformTime::Seconds unbuilt time was last encountered. 0 means not yet.
		/// </summary>
		public double LastTimeUnbuiltLightingWasEncountered { get; set; } 
		
		/// <summary>
		/// Time in seconds since level began play, but IS paused when the game is paused, and IS dilated/clamped.
		/// </summary>
		public float TimeSeconds { get; set; } 
		
		/// <summary>
		/// Time in seconds since level began play, but IS NOT paused when the game is paused, and IS dilated/clamped.
		/// </summary>
		public float UnpausedTimeSeconds { get; set; } 
		
		/// <summary>
		/// Time in seconds since level began play, but IS NOT paused when the game is paused, and IS NOT dilated/clamped.
		/// </summary>
		public float RealTimeSeconds { get; set; } 
		
		/// <summary>
		/// Time in seconds since level began play, but IS paused when the game is paused, and IS NOT dilated/clamped.
		/// </summary>
		public float AudioTimeSeconds { get; set; } 
		
		/// <summary>
		/// Frame delta time in seconds adjusted by e.g. time dilation.
		/// </summary>
		public float DeltaTimeSeconds { get; set; } 
		
		/// <summary>
		/// time at which to start pause
		/// </summary>
		public float PauseDelay { get; set; } 
		
		/// <summary>
		/// World origin offset value. Non-zero only for a single frame when origin is rebased
		/// </summary>
		public FVector OriginOffsetThisFrame { get; set; } 
		
		/// <summary>
		/// Amount of time to wait before traveling to next map, gives clients time to receive final RPCs @see ServerTravelPause
		/// </summary>
		public float NextSwitchCountdown { get; set; } 
		
		/// <summary>
		/// Num of components missing valid texture streaming data. Updated in map check.
		/// </summary>
		public int NumTextureStreamingUnbuiltComponents { get; set; } 
		
		/// <summary>
		/// Num of resources that have changed since the last texture streaming build. Updated in map check.
		/// </summary>
		public int NumTextureStreamingDirtyResources { get; set; } 
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Creates a new FX system for this world
		/// </summary>
		public void CreateFXSystem()
			=> E_UWorld_CreateFXSystem(NativePointer);
		
		
		/// <summary>
		/// Sets whether or not this world is ticked by the engine, but use it at your own risk! This could
		/// have unintended consequences if used carelessly. That said, for worlds that are not interactive
		/// and not rendering, it can save the cost of ticking them. This should probably never be used
		/// for a primary game world.
		/// </summary>
		public void SetShouldTick(bool bInShouldTick)
			=> E_UWorld_SetShouldTick(NativePointer, bInShouldTick);
		
		
		/// <summary>
		/// Returns whether or not this world is currently ticking. See SetShouldTick.
		/// </summary>
		public bool ShouldTick()
			=> E_UWorld_ShouldTick(NativePointer);
		
		
		/// <summary>
		/// @return Returns the number of Pawns.
		/// </summary>
		public int GetNumPawns()
			=> E_UWorld_GetNumPawns(NativePointer);
		
		
		/// <summary>
		/// Returns time in seconds since world was brought up for play, IS stopped when game pauses, IS dilated/clamped
		/// @return time in seconds since world was brought up for play
		/// </summary>
		public float GetTimeSeconds()
			=> E_UWorld_GetTimeSeconds(NativePointer);
		
		
		/// <summary>
		/// Helper for getting the time since a certain time.
		/// </summary>
		public float TimeSince(float Time)
			=> E_UWorld_TimeSince(NativePointer, Time);
		
		
		/// <summary>
		/// Adds the passed in actor to the special network actor list
		/// This list is used to specifically single out actors that are relevant for networking without having to scan the much large list
		/// @param	Actor	Actor to add
		/// </summary>
		public void AddNetworkActor(AActor Actor)
			=> E_UWorld_AddNetworkActor(NativePointer, Actor);
		
		
		/// <summary>
		/// Returns whether the passed in actor is part of any of the loaded levels actors array.
		/// Warning: Will return true for pending kill actors!
		/// @param	Actor	Actor to check whether it is contained by any level
		/// @return	true if actor is contained by any of the loaded levels, false otherwise
		/// </summary>
		public bool ContainsActor(AActor Actor)
			=> E_UWorld_ContainsActor(NativePointer, Actor);
		
		
		/// <summary>
		/// Returns whether audio playback is allowed for this scene.
		/// @return true if current world is GWorld, false otherwise
		/// </summary>
		public bool AllowAudioPlayback()
			=> E_UWorld_AllowAudioPlayback(NativePointer);
		
		
		/// <summary>
		/// Updates world components like e.g. line batcher and all level components.
		/// @param	bRerunConstructionScripts	If we should rerun construction scripts on actors
		/// @param	bCurrentLevelOnly			If true, affect only the current level.
		/// </summary>
		public void UpdateWorldComponents(bool bRerunConstructionScripts, bool bCurrentLevelOnly)
			=> E_UWorld_UpdateWorldComponents(NativePointer, bRerunConstructionScripts, bCurrentLevelOnly);
		
		
		/// <summary>
		/// Cleans up components, streaming data and assorted other intermediate data.
		/// @param bSessionEnded whether to notify the viewport that the game session has ended
		/// @param NewWorld Optional new world that will be loaded after this world is cleaned up. Specify a new world to prevent it and it's sublevels from being GCed during map transitions.
		/// </summary>
		public void CleanupWorld(bool bSessionEnded = true, bool bCleanupResources = true, UWorld NewWorld = null)
			=> E_UWorld_CleanupWorld(NativePointer, bSessionEnded, bCleanupResources, NewWorld);
		
		
		/// <summary>
		/// Initializes the world, associates the persistent level and sets the proper zones.
		/// </summary>
		public void InitWorld()
			=> E_UWorld_InitWorld(NativePointer);
		
		#endregion
		
		public static explicit operator IntPtr(UWorld Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UWorld(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UWorld(Adress);
		}}}
