using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\World.h:732

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageWorld
	/// <para>The destructor restores the context on the world that was saved in the constructor. </para>
	/// </summary>
	public sealed partial class UWorld : UObject
	{
		public UWorld(IntPtr Adress)
			: base(Adress)
		{
		}

		public UWorld(UObject Parent = null, string Name = "World")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UWorld(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UWorld(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_AudioTimeSeconds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_AudioTimeSeconds_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bCreateRenderStateForHiddenComponents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bCreateRenderStateForHiddenComponents_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bDebugDrawAllTraceTags_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bDebugDrawAllTraceTags_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bHack_Force_UsesGameHiddenFlags_True_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bHack_Force_UsesGameHiddenFlags_True_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bInTick_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bInTick_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bIsBuilt_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsBuilt_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bIsLevelStreamingFrozen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsLevelStreamingFrozen_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bIsRunningConstructionScript_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsRunningConstructionScript_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bIsWorldInitialized_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsWorldInitialized_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bPostTickComponentUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bPostTickComponentUpdate_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bShouldForceUnloadStreamingLevels_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bShouldForceUnloadStreamingLevels_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bShouldForceVisibleStreamingLevels_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bShouldForceVisibleStreamingLevels_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bShouldSimulatePhysics_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bShouldSimulatePhysics_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bTickNewlySpawned_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bTickNewlySpawned_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UWorld_CommittedPersistentLevelName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_CommittedPersistentLevelName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UWorld_DebugDrawTraceTag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_DebugDrawTraceTag_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_DeltaTimeSeconds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_DeltaTimeSeconds_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_FlushLevelStreamingType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_FlushLevelStreamingType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_SET(IntPtr Ptr, double Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_NextSwitchCountdown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_NextSwitchCountdown_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_NextTravelType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_NextTravelType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UWorld_NextURL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_NextURL_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UWorld_NumTextureStreamingDirtyResources_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_NumTextureStreamingDirtyResources_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UWorld_OriginOffsetThisFrame_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_OriginOffsetThisFrame_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_PauseDelay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_PauseDelay_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UWorld_PlayerNum_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_PlayerNum_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_RealTimeSeconds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_RealTimeSeconds_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UWorld_StreamingVolumeUpdateDelay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_StreamingVolumeUpdateDelay_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_TickGroup_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_TickGroup_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_TimeSeconds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_TimeSeconds_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_UnpausedTimeSeconds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_UnpausedTimeSeconds_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UWorld_URL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_URL_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_AddNetworkActor(IntPtr Self, IntPtr Actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_AddPawn(IntPtr Self, IntPtr Pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_AllowLevelLoadRequests(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_AreActorsInitialized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_AreAlwaysLoadedLevelsLoaded(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_AsyncLoadAlwaysLoadedLevelsForSeamlessTravel(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UWorld_AttemptDeriveFromURL(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_BeginPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_BroadcastLevelsChanged(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_BuildPIEPackagePrefix(IntPtr Self, int PIEInstanceID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CancelPendingMapChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CleanupActors(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CleanupWorld(IntPtr Self, bool bSessionEnded, bool bCleanupResources, IntPtr NewWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ClearActorComponentEndOfFrameUpdate(IntPtr Self, IntPtr Component);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ClearWorldComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CommitMapChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CommitModelSurfaces(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ConditionallyBuildStreamingData(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_ContainsActor(IntPtr Self, IntPtr Actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_ConvertToPIEPackageName(IntPtr Self, string PackageName, int PIEInstanceID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CreateFXSystem(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CreatePhysicsScene(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_DebugDrawSceneQueries(IntPtr Self, string UsedTraceTag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DelayGarbageCollection(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DelayStreamingVolumeUpdates(IntPtr Self, int InFrameDelay);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_DestroyActor(IntPtr Self, IntPtr Actor, bool bNetForce, bool bShouldModifyLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DestroyDemoNetDriver(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DestroyWorld(IntPtr Self, bool bInformEngineOfWorld, IntPtr NewWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DuplicateRequestedLevels(IntPtr Self, string MapName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorld_DuplicateWorldForPIE(IntPtr Self, string PackageName, IntPtr OwningWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_EditorDestroyActor(IntPtr Self, IntPtr Actor, bool bShouldModifyLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_EncroachingBlockingGeometry(IntPtr Self, IntPtr TestActor, IntPtr TestLocation, IntPtr TestRotation, IntPtr ProposedAdjustment);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_EnsureCollisionTreeIsBuilt(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_FindCollectionIndexByType(IntPtr Self, byte InType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_FindOrAddCollectionByType_Index(IntPtr Self, byte InType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_FindTeleportSpot(IntPtr Self, IntPtr TestActor, IntPtr PlaceLocation, IntPtr PlaceRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_FinishPhysicsSim(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_FlushLevelStreaming(IntPtr Self, byte FlushType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ForceGarbageCollection(IntPtr Self, bool bFullPurge);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetActiveLevelCollectionIndex(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetActorCount(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetAudioTimeSeconds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetDefaultGravityZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetDeltaSeconds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetDetailMode(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetGravityZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetMonoFarFieldCullingDistance(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UWorld_GetNetMode(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetNonDefaultPhysicsVolumeCount(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetNumLevels(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetNumPawns(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetProgressDenominator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetRealTimeSeconds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetTimeBetweenGarbageCollectionPasses(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetTimeSeconds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetUnpausedTimeSeconds(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_HasBegunPlay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_HasDefaultPhysicsVolume(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_HasEndOfFrameUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_InitializeActorsForPlay(IntPtr Self, IntPtr InURL, bool bResetTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_InvalidateModelSurface(IntPtr Self, bool bCurrentLevelOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsCameraMoveable(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsEditorWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsGameWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsInSeamlessTravel(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsMapChangeReady(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsNavigationRebuilt(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsNetMode(IntPtr Self, byte Mode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPaused(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayInEditor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayingReplay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayInMobilePreview(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayInPreview(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayInVulkanPreview(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPreparingMapChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPreviewWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsRecordingClientReplay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsVisibilityRequestPending(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_Listen(IntPtr Self, IntPtr InURL);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(IntPtr Self, IntPtr Component, bool bForceGameThread);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_MarkObjectsPendingKill(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PerformGarbageCollectionAndCleanupActors(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ProcessLevelStreamingVolumes(IntPtr Self, IntPtr OverrideViewLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PropagateLightingScenarioChange(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_RemapCompiledScriptActor(IntPtr Self, string Str);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RemoveActor(IntPtr Self, IntPtr Actor, bool bShouldModifyLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RemoveNetworkActor(IntPtr Self, IntPtr Actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RemovePawn(IntPtr Self, IntPtr Pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_RemovePIEPrefix(IntPtr Self, string Source);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RenameToPIEWorld(IntPtr Self, int PIEInstanceID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_RequiresHitProxies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RunTickGroup(IntPtr Self, byte Group, bool bBlockTillComplete);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SendAllEndOfFrameUpdates(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetActiveLevelCollection(IntPtr Self, int LevelCollectionIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_SetGameMode(IntPtr Self, IntPtr InURL);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetMapNeedsLightingFullyRebuilt(IntPtr Self, int InNumLightingUnbuiltObjects, int InNumUnbuiltReflectionCaptures);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetSeamlessTravelMidpointPause(IntPtr Self, bool bNowPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetShouldTick(IntPtr Self, bool bInShouldTick);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetTimeUntilNextGarbageCollection(IntPtr Self, float MinTimeUntilNextPass);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetupParameterCollectionInstances(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetupPhysicsTickFunctions(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_ShouldTick(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_StartPhysicsSim(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_StripPIEPrefixFromPackageName(IntPtr Self, string PackageName, string Prefix);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_Tick(IntPtr Self, byte TickType, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_TickNetClient(IntPtr Self, float DeltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_TimeSince(IntPtr Self, float Time);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_TransferBlueprintDebugReferences(IntPtr Self, IntPtr NewWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_TriggerStreamingDataRebuild(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateActorComponentEndOfFrameUpdateState(IntPtr Self, IntPtr Component);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateAllSkyCaptures(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateCullDistanceVolumes(IntPtr Self, IntPtr ActorToUpdate, IntPtr ComponentToUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateLevelStreaming(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateParameterCollectionInstances(IntPtr Self, bool bUpdateInstanceUniformBuffers);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateWorldComponents(IntPtr Self, bool bRerunConstructionScripts, bool bCurrentLevelOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_UsesGameHiddenFlags(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_AreNativePropertiesIdenticalTo(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_BeginDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_CheckDefaultSubobjectsInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_FinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_GetDesc(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_GetDetailedInfoInternal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorld_GetWorld(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsAsset(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsEditorOnly(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsFullNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsLocalizedResource(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsNameStableForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPostLoadThreadSafe(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsReadyForFinishDestroy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsSafeForRootSet(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsSupportedForNetworking(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_MarkAsEditorOnlySubobject(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_Modify(IntPtr Self, bool bAlwaysMarkDirty);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_NeedsLoadForClient(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_NeedsLoadForEditorGame(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_NeedsLoadForServer(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_NotifyObjectReferenceEliminated(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PostCDOContruct(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PostEditImport(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PostInitProperties(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PostLoad(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PostNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PostRename(IntPtr Self, IntPtr OldOuter, string OldName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PostRepNotifies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PostSaveRoot(IntPtr Self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PreDestroyFromReplication(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PreNetReceive(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ShutdownAfterError(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_AddToCluster(IntPtr Self, IntPtr ClusterRootOrObjectFromCluster, bool bAddAsMutableObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_CanBeClusterRoot(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_CanBeInCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CreateCluster(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_OnClusterMarkedAsPendingKill(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Time in seconds since level began play, but IS paused when the game is paused, and IS NOT dilated/clamped. </para>
		/// </summary>
		public float AudioTimeSeconds
		{
			get => E_PROP_UWorld_AudioTimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_AudioTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If TRUE, 'hidden' components will still create render proxy, so can draw info (see USceneComponent::ShouldRender) </para>
		/// </summary>
		public bool bCreateRenderStateForHiddenComponents
		{
			get => E_PROP_UWorld_bCreateRenderStateForHiddenComponents_GET(NativePointer);
			set => E_PROP_UWorld_bCreateRenderStateForHiddenComponents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When set to true, all scene queries will be drawn </para>
		/// </summary>
		public bool bDebugDrawAllTraceTags
		{
			get => E_PROP_UWorld_bDebugDrawAllTraceTags_GET(NativePointer);
			set => E_PROP_UWorld_bDebugDrawAllTraceTags_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>True we want to execute a call to UpdateCulledTriggerVolumes during Tick </para>
		/// </summary>
		public bool bDoDelayedUpdateCullDistanceVolumes
		{
			get => E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_GET(NativePointer);
			set => E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Force UsesGameHiddenFlags to return true. </para>
		/// </summary>
		public bool bHack_Force_UsesGameHiddenFlags_True
		{
			get => E_PROP_UWorld_bHack_Force_UsesGameHiddenFlags_True_GET(NativePointer);
			set => E_PROP_UWorld_bHack_Force_UsesGameHiddenFlags_True_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether we are in the middle of ticking actors/components or not </para>
		/// </summary>
		public bool bInTick
		{
			get => E_PROP_UWorld_bInTick_GET(NativePointer);
			set => E_PROP_UWorld_bInTick_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether we have already built the collision tree or not </para>
		/// </summary>
		public bool bIsBuilt
		{
			get => E_PROP_UWorld_bIsBuilt_GET(NativePointer);
			set => E_PROP_UWorld_bIsBuilt_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Is level streaming currently frozen? </para>
		/// </summary>
		public bool bIsLevelStreamingFrozen
		{
			get => E_PROP_UWorld_bIsLevelStreamingFrozen_GET(NativePointer);
			set => E_PROP_UWorld_bIsLevelStreamingFrozen_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true this world is in the process of running the construction script for an actor </para>
		/// </summary>
		public bool bIsRunningConstructionScript
		{
			get => E_PROP_UWorld_bIsRunningConstructionScript_GET(NativePointer);
			set => E_PROP_UWorld_bIsRunningConstructionScript_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether world object has been initialized via Init() </para>
		/// </summary>
		public bool bIsWorldInitialized
		{
			get => E_PROP_UWorld_bIsWorldInitialized_GET(NativePointer);
			set => E_PROP_UWorld_bIsWorldInitialized_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Indicates that during world ticking we are doing the final component update of dirty components </para>
		/// <para>(after PostAsyncWork and effect physics scene has run. </para>
		/// </summary>
		public bool bPostTickComponentUpdate
		{
			get => E_PROP_UWorld_bPostTickComponentUpdate_GET(NativePointer);
			set => E_PROP_UWorld_bPostTickComponentUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Is forcibly unloading streaming levels? </para>
		/// </summary>
		public bool bShouldForceUnloadStreamingLevels
		{
			get => E_PROP_UWorld_bShouldForceUnloadStreamingLevels_GET(NativePointer);
			set => E_PROP_UWorld_bShouldForceUnloadStreamingLevels_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Is forcibly making streaming levels visible? </para>
		/// </summary>
		public bool bShouldForceVisibleStreamingLevels
		{
			get => E_PROP_UWorld_bShouldForceVisibleStreamingLevels_GET(NativePointer);
			set => E_PROP_UWorld_bShouldForceVisibleStreamingLevels_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true this world will tick physics to simulate. This isn't same as having Physics Scene. </para>
		/// <para>You need Physics Scene if you'd like to trace. This flag changed ticking </para>
		/// </summary>
		public bool bShouldSimulatePhysics
		{
			get => E_PROP_UWorld_bShouldSimulatePhysics_GET(NativePointer);
			set => E_PROP_UWorld_bShouldSimulatePhysics_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>We are in the middle of actor ticking, so add tasks for newly spawned actors </para>
		/// </summary>
		public bool bTickNewlySpawned
		{
			get => E_PROP_UWorld_bTickNewlySpawned_GET(NativePointer);
			set => E_PROP_UWorld_bTickNewlySpawned_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Name of persistent level if we've loaded levels via CommitMapChange() that aren't normally in the StreamingLevels array (to inform newly joining clients) </para>
		/// </summary>
		public string CommittedPersistentLevelName
		{
			get => E_PROP_UWorld_CommittedPersistentLevelName_GET(NativePointer);
			set => E_PROP_UWorld_CommittedPersistentLevelName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When non-'None', all line traces where the TraceTag match this will be drawn </para>
		/// </summary>
		public string DebugDrawTraceTag
		{
			get => E_PROP_UWorld_DebugDrawTraceTag_GET(NativePointer);
			set => E_PROP_UWorld_DebugDrawTraceTag_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Frame delta time in seconds adjusted by e.g. time dilation. </para>
		/// </summary>
		public float DeltaTimeSeconds
		{
			get => E_PROP_UWorld_DeltaTimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_DeltaTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether we flushing level streaming state </para>
		/// </summary>
		public EFlushLevelStreamingType FlushLevelStreamingType
		{
			get => (EFlushLevelStreamingType)E_PROP_UWorld_FlushLevelStreamingType_GET(NativePointer);
			set => E_PROP_UWorld_FlushLevelStreamingType_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Time in FPlatformTime::Seconds unbuilt time was last encountered. 0 means not yet. </para>
		/// </summary>
		public double LastTimeUnbuiltLightingWasEncountered
		{
			get => E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_GET(NativePointer);
			set => E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Amount of time to wait before traveling to next map, gives clients time to receive final RPCs @see ServerTravelPause </para>
		/// </summary>
		public float NextSwitchCountdown
		{
			get => E_PROP_UWorld_NextSwitchCountdown_GET(NativePointer);
			set => E_PROP_UWorld_NextSwitchCountdown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The type of travel to perform next when doing a server travel </para>
		/// </summary>
		public ETravelType NextTravelType
		{
			get => (ETravelType)E_PROP_UWorld_NextTravelType_GET(NativePointer);
			set => E_PROP_UWorld_NextTravelType_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>The URL to be used for the upcoming server travel </para>
		/// </summary>
		public string NextURL
		{
			get => E_PROP_UWorld_NextURL_GET(NativePointer);
			set => E_PROP_UWorld_NextURL_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Num of resources that have changed since the last texture streaming build. Updated in map check. </para>
		/// </summary>
		public int NumTextureStreamingDirtyResources
		{
			get => E_PROP_UWorld_NumTextureStreamingDirtyResources_GET(NativePointer);
			set => E_PROP_UWorld_NumTextureStreamingDirtyResources_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Num of components missing valid texture streaming data. Updated in map check. </para>
		/// </summary>
		public int NumTextureStreamingUnbuiltComponents
		{
			get => E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_GET(NativePointer);
			set => E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>World origin offset value. Non-zero only for a single frame when origin is rebased </para>
		/// </summary>
		public FVector OriginOffsetThisFrame
		{
			get => E_PROP_UWorld_OriginOffsetThisFrame_GET(NativePointer);
			set => E_PROP_UWorld_OriginOffsetThisFrame_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>time at which to start pause </para>
		/// </summary>
		public float PauseDelay
		{
			get => E_PROP_UWorld_PauseDelay_GET(NativePointer);
			set => E_PROP_UWorld_PauseDelay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Counter for allocating game- unique controller player numbers </para>
		/// </summary>
		public int PlayerNum
		{
			get => E_PROP_UWorld_PlayerNum_GET(NativePointer);
			set => E_PROP_UWorld_PlayerNum_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Time in seconds since level began play, but IS NOT paused when the game is paused, and IS NOT dilated/clamped. </para>
		/// </summary>
		public float RealTimeSeconds
		{
			get => E_PROP_UWorld_RealTimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_RealTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Number of frames to delay Streaming Volume updating, useful if you preload a bunch of levels but the camera hasn't caught up yet (INDEX_NONE for infinite) </para>
		/// </summary>
		public int StreamingVolumeUpdateDelay
		{
			get => E_PROP_UWorld_StreamingVolumeUpdateDelay_GET(NativePointer);
			set => E_PROP_UWorld_StreamingVolumeUpdateDelay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The current ticking group </para>
		/// </summary>
		public ETickingGroup TickGroup
		{
			get => (ETickingGroup)E_PROP_UWorld_TickGroup_GET(NativePointer);
			set => E_PROP_UWorld_TickGroup_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Time in seconds since level began play, but IS paused when the game is paused, and IS dilated/clamped. </para>
		/// </summary>
		public float TimeSeconds
		{
			get => E_PROP_UWorld_TimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_TimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Time in seconds since level began play, but IS NOT paused when the game is paused, and IS dilated/clamped. </para>
		/// </summary>
		public float UnpausedTimeSeconds
		{
			get => E_PROP_UWorld_UnpausedTimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_UnpausedTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The URL that was used when loading this World. </para>
		/// </summary>
		public FURL URL
		{
			get => E_PROP_UWorld_URL_GET(NativePointer);
			set => E_PROP_UWorld_URL_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Adds the passed in actor to the special network actor list </para>
		/// <para>This list is used to specifically single out actors that are relevant for networking without having to scan the much large list </para>
		/// <param name="Actor">Actor to add </param>
		/// </summary>
		public void AddNetworkActor(AActor Actor)
			=> E_UWorld_AddNetworkActor(this, Actor);
		
		
		/// <summary>
		/// <para>Inserts the passed in pawn at the front of the linked list of pawns. </para>
		/// <param name="Pawn">Pawn to insert, use NULL to clear list </param>
		/// </summary>
		public void AddPawn(APawn Pawn)
			=> E_UWorld_AddPawn(this, Pawn);
		
		
		/// <summary>
		/// <para>Returns whether the level streaming code is allowed to issue load requests. </para>
		/// <return>true if level load requests are allowed, false otherwise. </return>
		/// </summary>
		public bool AllowLevelLoadRequests()
			=> E_UWorld_AllowLevelLoadRequests(this);
		
		
		/// <summary>
		/// <para>Returns true if the actors have been initialized and are ready to start play </para>
		/// </summary>
		public bool AreActorsInitialized()
			=> E_UWorld_AreActorsInitialized(this);
		
		
		/// <summary>
		/// <para>Returns whether all the 'always loaded' levels are loaded. </para>
		/// </summary>
		public bool AreAlwaysLoadedLevelsLoaded()
			=> E_UWorld_AreAlwaysLoadedLevelsLoaded(this);
		
		
		/// <summary>
		/// <para>Requests async loading of any 'always loaded' level. Used in seamless travel to prevent blocking in the first UpdateLevelStreaming. </para>
		/// </summary>
		public void AsyncLoadAlwaysLoadedLevelsForSeamlessTravel()
			=> E_UWorld_AsyncLoadAlwaysLoadedLevelsForSeamlessTravel(this);
		
		
		/// <summary>
		/// <para>Attempts to derive the net mode from URL </para>
		/// </summary>
		public ENetMode AttemptDeriveFromURL()
			=> (ENetMode)E_UWorld_AttemptDeriveFromURL(this);
		
		
		/// <summary>
		/// <para>Start gameplay. This will cause the game mode to transition to the correct state and call BeginPlay on all actors </para>
		/// </summary>
		public void BeginPlay()
			=> E_UWorld_BeginPlay(this);
		
		
		/// <summary>
		/// <para>Broadcasts that the number of levels has changed. </para>
		/// </summary>
		public void BroadcastLevelsChanged()
			=> E_UWorld_BroadcastLevelsChanged(this);
		
		
		/// <summary>
		/// <para>Return the prefix for PIE packages given a PIE Instance ID </para>
		/// </summary>
		public string BuildPIEPackagePrefix(int PIEInstanceID)
			=> E_UWorld_BuildPIEPackagePrefix(this, PIEInstanceID);
		
		
		/// <summary>
		/// <para>cancels pending map change (@note: we can't cancel pending async loads, so this won't immediately free the memory) </para>
		/// </summary>
		public void CancelPendingMapChange()
			=> E_UWorld_CancelPendingMapChange(this);
		
		
		/// <summary>
		/// <para>Remove NULL entries from actor list. Only does so for dynamic actors to avoid resorting. </para>
		/// <para>In theory static actors shouldn't be deleted during gameplay. </para>
		/// </summary>
		public void CleanupActors()
			=> E_UWorld_CleanupActors(this);
		
		
		/// <summary>
		/// <para>Cleans up components, streaming data and assorted other intermediate data. </para>
		/// <param name="bSessionEnded">whether to notify the viewport that the game session has ended </param>
		/// <param name="NewWorld">Optional new world that will be loaded after this world is cleaned up. Specify a new world to prevent it and it's sublevels from being GCed during map transitions. </param>
		/// </summary>
		public void CleanupWorld(bool bSessionEnded = true, bool bCleanupResources = true, UWorld NewWorld = null)
			=> E_UWorld_CleanupWorld(this, bSessionEnded, bCleanupResources, NewWorld);
		
		
		/// <summary>
		/// <para>Clears the need for a component to have a end of frame update </para>
		/// <param name="Component">Component to update at the end of the frame </param>
		/// </summary>
		public void ClearActorComponentEndOfFrameUpdate(UActorComponent Component)
			=> E_UWorld_ClearActorComponentEndOfFrameUpdate(this, Component);
		
		
		/// <summary>
		/// <para>Clears all level components and world components like e.g. line batcher. </para>
		/// </summary>
		public void ClearWorldComponents()
			=> E_UWorld_ClearWorldComponents(this);
		
		
		/// <summary>
		/// <para>actually performs the map transition prepared by PrepareMapChange() </para>
		/// <para>it happens in the next tick to avoid GC issues </para>
		/// <para>if a map change is being prepared but isn't ready yet, the transition code will block until it is </para>
		/// <para>wait until IsMapChangeReady() returns true if this is undesired behavior </para>
		/// </summary>
		public void CommitMapChange()
			=> E_UWorld_CommitMapChange(this);
		
		
		/// <summary>
		/// <para>Commits changes made to the surfaces of the UModels of all levels. </para>
		/// </summary>
		public void CommitModelSurfaces()
			=> E_UWorld_CommitModelSurfaces(this);
		
		
		/// <summary>
		/// <para>Calls ULevel::BuildStreamingData(this,NULL,NULL) if it has been triggered within the last few seconds. </para>
		/// </summary>
		public void ConditionallyBuildStreamingData()
			=> E_UWorld_ConditionallyBuildStreamingData(this);
		
		
		/// <summary>
		/// <para>Returns whether the passed in actor is part of any of the loaded levels actors array. </para>
		/// <para>Warning: Will return true for pending kill actors! </para>
		/// <param name="Actor">Actor to check whether it is contained by any level </param>
		/// <return>true if actor is contained by any of the loaded levels, false otherwise </return>
		/// </summary>
		public bool ContainsActor(AActor Actor)
			=> E_UWorld_ContainsActor(this, Actor);
		
		
		/// <summary>
		/// <para>Given a PackageName and a PIE Instance ID return the name of that Package when being run as a PIE world </para>
		/// </summary>
		public string ConvertToPIEPackageName(string PackageName, int PIEInstanceID)
			=> E_UWorld_ConvertToPIEPackageName(this, PackageName, PIEInstanceID);
		
		
		/// <summary>
		/// <para>Creates a new FX system for this world </para>
		/// </summary>
		public void CreateFXSystem()
			=> E_UWorld_CreateFXSystem(this);
		
		
		/// <summary>
		/// <para>Creates a new physics scene for this world. </para>
		/// </summary>
		public void CreatePhysicsScene()
			=> E_UWorld_CreatePhysicsScene(this);
		
		public bool DebugDrawSceneQueries(string UsedTraceTag)
			=> E_UWorld_DebugDrawSceneQueries(this, UsedTraceTag);
		
		
		/// <summary>
		/// <para>Requests a one frame delay of Garbage Collection </para>
		/// </summary>
		public void DelayGarbageCollection()
			=> E_UWorld_DelayGarbageCollection(this);
		
		
		/// <summary>
		/// <para>Sets the number of frames to delay Streaming Volume updating, </para>
		/// <para>useful if you preload a bunch of levels but the camera hasn't caught up yet </para>
		/// </summary>
		public void DelayStreamingVolumeUpdates(int InFrameDelay)
			=> E_UWorld_DelayStreamingVolumeUpdates(this, InFrameDelay);
		
		
		/// <summary>
		/// <para>Removes the actor from its level's actor list and generally cleans up the engine's internal state. </para>
		/// <para>What this function does not do, but is handled via garbage collection instead, is remove references </para>
		/// <para>to this actor from all other actors, and kill the actor's resources.  This function is set up so that </para>
		/// <para>no problems occur even if the actor is being destroyed inside its recursion stack. </para>
		/// <param name="ThisActor">Actor to remove. </param>
		/// <param name="bNetForce">opt] Ignored unless called during play.  Default is false. </param>
		/// <param name="bShouldModifyLevel">opt] If true, Modify() the level before removing the actor.  Default is true. </param>
		/// <return>true if destroyed or already marked for destruction, false if actor couldn't be destroyed. </return>
		/// </summary>
		public bool DestroyActor(AActor Actor, bool bNetForce = false, bool bShouldModifyLevel = true)
			=> E_UWorld_DestroyActor(this, Actor, bNetForce, bShouldModifyLevel);
		
		
		/// <summary>
		/// <para>Utility function to handle Exec/Console Command for setting the speed of a replay </para>
		/// </summary>
		public void DestroyDemoNetDriver()
			=> E_UWorld_DestroyDemoNetDriver(this);
		
		
		/// <summary>
		/// <para>Destroy this World instance. If destroying the world to load a different world, supply it here to prevent GC of the new world or it's sublevels. </para>
		/// </summary>
		public void DestroyWorld(bool bInformEngineOfWorld, UWorld NewWorld = null)
			=> E_UWorld_DestroyWorld(this, bInformEngineOfWorld, NewWorld);
		
		
		/// <summary>
		/// <para>Creates a new level collection of type DynamicDuplicatedLevels by duplicating the levels in DynamicSourceLevels. </para>
		/// <para>Should only be called by engine. </para>
		/// <param name="MapName">The name of the soure map, used as a parameter to UEngine::Experimental_ShouldPreDuplicateMap </param>
		/// </summary>
		public void DuplicateRequestedLevels(string MapName)
			=> E_UWorld_DuplicateRequestedLevels(this, MapName);
		
		
		/// <summary>
		/// <para>Given a loaded editor UWorld, duplicate it for play in editor purposes with OwningWorld as the world with the persistent level. </para>
		/// </summary>
		public UWorld DuplicateWorldForPIE(string PackageName, UWorld OwningWorld)
			=> E_UWorld_DuplicateWorldForPIE(this, PackageName, OwningWorld);
		
		
		/// <summary>
		/// <para>Wrapper for DestroyActor() that should be called in the editor. </para>
		/// <param name="bShouldModifyLevel">If true, Modify() the level before removing the actor. </param>
		/// </summary>
		public bool EditorDestroyActor(AActor Actor, bool bShouldModifyLevel)
			=> E_UWorld_EditorDestroyActor(this, Actor, bShouldModifyLevel);
		
		
		/// <summary>
		/// <para>@Return true if Actor would encroach at TestLocation on something that blocks it.  Returns a ProposedAdjustment that might result in an unblocked TestLocation. </para>
		/// </summary>
		public bool EncroachingBlockingGeometry(AActor TestActor, FVector TestLocation, FRotator TestRotation, FVector ProposedAdjustment = null)
			=> E_UWorld_EncroachingBlockingGeometry(this, TestActor, TestLocation, TestRotation, ProposedAdjustment);
		
		
		/// <summary>
		/// <para>Ensures that the collision detection tree is fully built. This should be called after the full level reload to make sure </para>
		/// <para>the first traces are not abysmally slow. </para>
		/// </summary>
		public void EnsureCollisionTreeIsBuilt()
			=> E_UWorld_EnsureCollisionTreeIsBuilt(this);
		
		
		/// <summary>
		/// <para>Returns the index of the FLevelCollection with the given InType, or INDEX_NONE if a collection of that type hasn't been created yet. </para>
		/// </summary>
		public int FindCollectionIndexByType(ELevelCollectionType InType)
			=> E_UWorld_FindCollectionIndexByType(this, (byte)InType);
		
		
		/// <summary>
		/// <para>Returns the index of the first FLevelCollection of the given InType. If one does not exist, it is created and its index returned. </para>
		/// </summary>
		public int FindOrAddCollectionByType_Index(ELevelCollectionType InType)
			=> E_UWorld_FindOrAddCollectionByType_Index(this, (byte)InType);
		
		
		/// <summary>
		/// <para>Try to find an acceptable position to place TestActor as close to possible to PlaceLocation.  Expects PlaceLocation to be a valid location inside the level. </para>
		/// </summary>
		public bool FindTeleportSpot(AActor TestActor, FVector PlaceLocation, FRotator PlaceRotation)
			=> E_UWorld_FindTeleportSpot(this, TestActor, PlaceLocation, PlaceRotation);
		
		
		/// <summary>
		/// <para>Waits for the physics scene to be done processing </para>
		/// </summary>
		public void FinishPhysicsSim()
			=> E_UWorld_FinishPhysicsSim(this);
		
		
		/// <summary>
		/// <para>Flushes level streaming in blocking fashion and returns when all levels are loaded/ visible/ hidden </para>
		/// <para>so further calls to UpdateLevelStreaming won't do any work unless state changes. Basically blocks </para>
		/// <para>on all async operation like updating components. </para>
		/// <param name="FlushType">Whether to only flush level visibility operations (optional) </param>
		/// </summary>
		public void FlushLevelStreaming(EFlushLevelStreamingType FlushType)
			=> E_UWorld_FlushLevelStreaming(this, (byte)FlushType);
		
		
		/// <summary>
		/// <para>Updates the timer between garbage collection such that at the next opportunity garbage collection will be run. </para>
		/// </summary>
		public void ForceGarbageCollection(bool bFullPurge = false)
			=> E_UWorld_ForceGarbageCollection(this, bFullPurge);
		
		
		/// <summary>
		/// <para>Returns the index of the level collection which currently has its context set on this world. May be INDEX_NONE. </para>
		/// <para>If not INDEX_NONE, this implies that execution is currently within the scope of an FScopedLevelCollectionContextSwitch for this world. </para>
		/// </summary>
		public int GetActiveLevelCollectionIndex()
			=> E_UWorld_GetActiveLevelCollectionIndex(this);
		
		
		/// <summary>
		/// <para>Returns the actor count. </para>
		/// </summary>
		public int GetActorCount()
			=> E_UWorld_GetActorCount(this);
		
		
		/// <summary>
		/// <para>Returns time in seconds since world was brought up for play, IS stopped when game pauses, NOT dilated/clamped </para>
		/// <return>time in seconds since world was brought up for play </return>
		/// </summary>
		public float GetAudioTimeSeconds()
			=> E_UWorld_GetAudioTimeSeconds(this);
		
		
		/// <summary>
		/// <para>Returns the Z component of the default world gravity. </para>
		/// <return>Z component of the default world gravity. </return>
		/// </summary>
		public float GetDefaultGravityZ()
			=> E_UWorld_GetDefaultGravityZ(this);
		
		
		/// <summary>
		/// <para>Returns the frame delta time in seconds adjusted by e.g. time dilation. </para>
		/// <return>frame delta time in seconds adjusted by e.g. time dilation </return>
		/// </summary>
		public float GetDeltaSeconds()
			=> E_UWorld_GetDeltaSeconds(this);
		
		
		/// <summary>
		/// <return>the current detail mode, like EDetailMode but can be outside of the range </return>
		/// </summary>
		public int GetDetailMode()
			=> E_UWorld_GetDetailMode(this);
		
		
		/// <summary>
		/// <para>Returns the Z component of the current world gravity. </para>
		/// <return>Z component of current world gravity. </return>
		/// </summary>
		public float GetGravityZ()
			=> E_UWorld_GetGravityZ(this);
		
		
		/// <summary>
		/// <para>Helper for getting the mono far field culling distance. </para>
		/// </summary>
		public float GetMonoFarFieldCullingDistance()
			=> E_UWorld_GetMonoFarFieldCullingDistance(this);
		
		
		/// <summary>
		/// <para>Returns the net mode this world is running under. </para>
		/// <para>@see IsNetMode() </para>
		/// </summary>
		public ENetMode GetNetMode()
			=> (ENetMode)E_UWorld_GetNetMode(this);
		
		
		/// <summary>
		/// <para>Get the count of all PhysicsVolumes in the world that are not a DefaultPhysicsVolume. </para>
		/// </summary>
		public int GetNonDefaultPhysicsVolumeCount()
			=> E_UWorld_GetNonDefaultPhysicsVolumeCount(this);
		
		
		/// <summary>
		/// <para>Return the number of levels in this world. </para>
		/// </summary>
		public int GetNumLevels()
			=> E_UWorld_GetNumLevels(this);
		
		
		/// <summary>
		/// <return>Returns the number of Pawns. </return>
		/// </summary>
		public int GetNumPawns()
			=> E_UWorld_GetNumPawns(this);
		
		
		/// <summary>
		/// <para>Returns the actor count. </para>
		/// </summary>
		public int GetProgressDenominator()
			=> E_UWorld_GetProgressDenominator(this);
		
		
		/// <summary>
		/// <para>Returns time in seconds since world was brought up for play, does NOT stop when game pauses, NOT dilated/clamped </para>
		/// <return>time in seconds since world was brought up for play </return>
		/// </summary>
		public float GetRealTimeSeconds()
			=> E_UWorld_GetRealTimeSeconds(this);
		
		
		/// <summary>
		/// <para>Returns the current desired time between garbage collection passes (not the time remaining) </para>
		/// </summary>
		public float GetTimeBetweenGarbageCollectionPasses()
			=> E_UWorld_GetTimeBetweenGarbageCollectionPasses(this);
		
		
		/// <summary>
		/// <para>Returns time in seconds since world was brought up for play, IS stopped when game pauses, IS dilated/clamped </para>
		/// <return>time in seconds since world was brought up for play </return>
		/// </summary>
		public float GetTimeSeconds()
			=> E_UWorld_GetTimeSeconds(this);
		
		
		/// <summary>
		/// <para>Returns time in seconds since world was brought up for play, IS NOT stopped when game pauses, IS dilated/clamped </para>
		/// <return>time in seconds since world was brought up for play </return>
		/// </summary>
		public float GetUnpausedTimeSeconds()
			=> E_UWorld_GetUnpausedTimeSeconds(this);
		
		
		/// <summary>
		/// <para>Returns true if gameplay has already started, false otherwise. </para>
		/// </summary>
		public bool HasBegunPlay()
			=> E_UWorld_HasBegunPlay(this);
		
		
		/// <summary>
		/// <para>Returns true if a DefaultPhysicsVolume has been created. </para>
		/// </summary>
		public bool HasDefaultPhysicsVolume()
			=> E_UWorld_HasDefaultPhysicsVolume(this);
		
		public bool HasEndOfFrameUpdates()
			=> E_UWorld_HasEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Initializes all actors and prepares them to start gameplay </para>
		/// <param name="InURL">commandline URL </param>
		/// <param name="bResetTime">optional) whether the WorldSettings's TimeSeconds should be reset to zero </param>
		/// </summary>
		public void InitializeActorsForPlay(FURL InURL, bool bResetTime = true)
			=> E_UWorld_InitializeActorsForPlay(this, InURL, bResetTime);
		
		
		/// <summary>
		/// <para>Discards the cached data used to render the levels' UModel.  Assumes that the </para>
		/// <para>faces and vertex positions haven't changed, only the applied materials. </para>
		/// <param name="bCurrentLevelOnly">If true, affect only the current level. </param>
		/// </summary>
		public void InvalidateModelSurface(bool bCurrentLevelOnly)
			=> E_UWorld_InvalidateModelSurface(this, bCurrentLevelOnly);
		
		
		/// <summary>
		/// <return>true if the camera is in a moveable state (taking pausedness into account) </return>
		/// </summary>
		public bool IsCameraMoveable()
			=> E_UWorld_IsCameraMoveable(this);
		
		
		/// <summary>
		/// <return>true if this level is a client </return>
		/// </summary>
		public bool IsClient()
			=> E_UWorld_IsClient(this);
		
		
		/// <summary>
		/// <para>Returns true if this world is any kind of editor world (including editor preview worlds) </para>
		/// </summary>
		public bool IsEditorWorld()
			=> E_UWorld_IsEditorWorld(this);
		
		
		/// <summary>
		/// <para>Returns true if this world is any kind of game world (including PIE worlds) </para>
		/// </summary>
		public bool IsGameWorld()
			=> E_UWorld_IsGameWorld(this);
		
		
		/// <summary>
		/// <return>whether we're currently in a seamless transition </return>
		/// </summary>
		public bool IsInSeamlessTravel()
			=> E_UWorld_IsInSeamlessTravel(this);
		
		
		/// <summary>
		/// <return>true if there is a map change being prepared, returns whether that change is ready to be committed, otherwise false </return>
		/// </summary>
		public bool IsMapChangeReady()
			=> E_UWorld_IsMapChangeReady(this);
		
		
		/// <summary>
		/// <para>Retrieves information whether all navigation with this world has been rebuilt </para>
		/// </summary>
		public bool IsNavigationRebuilt()
			=> E_UWorld_IsNavigationRebuilt(this);
		
		
		/// <summary>
		/// <para>Test whether net mode is the given mode. </para>
		/// <para>In optimized non-editor builds this can be more efficient than GetNetMode() </para>
		/// <para>because it can check the static build flags without considering PIE. </para>
		/// </summary>
		public bool IsNetMode(ENetMode Mode)
			=> E_UWorld_IsNetMode(this, (byte)Mode);
		
		
		/// <summary>
		/// <return>true if the world is in the paused state </return>
		/// </summary>
		public bool IsPaused()
			=> E_UWorld_IsPaused(this);
		
		
		/// <summary>
		/// <para>Returns whether script is executing within the editor. </para>
		/// </summary>
		public bool IsPlayInEditor()
			=> E_UWorld_IsPlayInEditor(this);
		
		
		/// <summary>
		/// <para>Returns true if we are currently playing a replay </para>
		/// </summary>
		public bool IsPlayingReplay()
			=> E_UWorld_IsPlayingReplay(this);
		
		
		/// <summary>
		/// <para>Returns whether script is executing within a mobile preview window </para>
		/// </summary>
		public bool IsPlayInMobilePreview()
			=> E_UWorld_IsPlayInMobilePreview(this);
		
		
		/// <summary>
		/// <para>Returns whether script is executing within a preview window </para>
		/// </summary>
		public bool IsPlayInPreview()
			=> E_UWorld_IsPlayInPreview(this);
		
		
		/// <summary>
		/// <para>Returns whether script is executing within a vulkan preview window </para>
		/// </summary>
		public bool IsPlayInVulkanPreview()
			=> E_UWorld_IsPlayInVulkanPreview(this);
		
		
		/// <summary>
		/// <return>true if there's a map change currently in progress </return>
		/// </summary>
		public bool IsPreparingMapChange()
			=> E_UWorld_IsPreparingMapChange(this);
		
		
		/// <summary>
		/// <para>Returns true if this world is a preview game world (editor or game) </para>
		/// </summary>
		public bool IsPreviewWorld()
			=> E_UWorld_IsPreviewWorld(this);
		
		
		/// <summary>
		/// <para>Returns true if the game net driver exists and is a client and the demo net driver exists and is a server. </para>
		/// </summary>
		public bool IsRecordingClientReplay()
			=> E_UWorld_IsRecordingClientReplay(this);
		
		
		/// <summary>
		/// <return>true if this level is a server </return>
		/// </summary>
		public bool IsServer()
			=> E_UWorld_IsServer(this);
		
		
		/// <summary>
		/// <return>whether there is at least one level with a pending visibility request </return>
		/// </summary>
		public bool IsVisibilityRequestPending()
			=> E_UWorld_IsVisibilityRequestPending(this);
		
		public bool Listen(FURL InURL)
			=> E_UWorld_Listen(this, InURL);
		
		
		/// <summary>
		/// <para>Mark a component as needing an end of frame update </para>
		/// <param name="Component">Component to update at the end of the frame </param>
		/// <param name="bForceGameThread">if true, force this to happen on the game thread </param>
		/// </summary>
		public void MarkActorComponentForNeededEndOfFrameUpdate(UActorComponent Component, bool bForceGameThread)
			=> E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(this, Component, bForceGameThread);
		
		
		/// <summary>
		/// <para>Marks all objects that have this World as an Outer as pending kill </para>
		/// </summary>
		public void MarkObjectsPendingKill()
			=> E_UWorld_MarkObjectsPendingKill(this);
		
		
		/// <summary>
		/// <para>Interface to allow WorldSettings to request immediate garbage collection </para>
		/// </summary>
		public void PerformGarbageCollectionAndCleanupActors()
			=> E_UWorld_PerformGarbageCollectionAndCleanupActors(this);
		
		
		/// <summary>
		/// <para>Issues level streaming load/unload requests based on whether </para>
		/// <para>local players are inside/outside level streaming volumes. </para>
		/// <param name="OverrideViewLocation">Optional position used to override the location used to calculate current streaming volumes </param>
		/// </summary>
		public void ProcessLevelStreamingVolumes(FVector OverrideViewLocation = null)
			=> E_UWorld_ProcessLevelStreamingVolumes(this, OverrideViewLocation);
		
		
		/// <summary>
		/// <para>Propagates a change to the active lighting scenario. </para>
		/// </summary>
		public void PropagateLightingScenarioChange()
			=> E_UWorld_PropagateLightingScenarioChange(this);
		
		
		/// <summary>
		/// <para>Given a level script actor, modify the string such that it points to the correct instance of the object. For replays. </para>
		/// </summary>
		public bool RemapCompiledScriptActor(string Str)
			=> E_UWorld_RemapCompiledScriptActor(this, Str);
		
		
		/// <summary>
		/// <para>Removes the passed in actor from the actor lists. Please note that the code actually doesn't physically remove the </para>
		/// <para>index but rather clears it so other indices are still valid and the actors array size doesn't change. </para>
		/// <param name="Actor">Actor to remove. </param>
		/// <param name="bShouldModifyLevel">If true, Modify() the level before removing the actor if in the editor. </param>
		/// </summary>
		public void RemoveActor(AActor Actor, bool bShouldModifyLevel)
			=> E_UWorld_RemoveActor(this, Actor, bShouldModifyLevel);
		
		
		/// <summary>
		/// <para>Removes the passed in actor to from special network actor list </para>
		/// <param name="Actor">Actor to remove </param>
		/// </summary>
		public void RemoveNetworkActor(AActor Actor)
			=> E_UWorld_RemoveNetworkActor(this, Actor);
		
		
		/// <summary>
		/// <para>Removes the passed in pawn from the linked list of pawns. </para>
		/// <param name="Pawn">Pawn to remove </param>
		/// </summary>
		public void RemovePawn(APawn Pawn)
			=> E_UWorld_RemovePawn(this, Pawn);
		
		
		/// <summary>
		/// <para>Given a string, return that string with any PIE prefix removed </para>
		/// </summary>
		public string RemovePIEPrefix(string Source)
			=> E_UWorld_RemovePIEPrefix(this, Source);
		
		
		/// <summary>
		/// <para>Rename this world such that it has the prefix on names for the given PIE Instance ID </para>
		/// </summary>
		public void RenameToPIEWorld(int PIEInstanceID)
			=> E_UWorld_RenameToPIEWorld(this, PIEInstanceID);
		
		
		/// <summary>
		/// <para>Accessor for bRequiresHitProxies. </para>
		/// </summary>
		public bool RequiresHitProxies()
			=> E_UWorld_RequiresHitProxies(this);
		
		
		/// <summary>
		/// <para>Run a tick group, ticking all actors and components </para>
		/// <param name="Group">Ticking group to run </param>
		/// <param name="bBlockTillComplete">if true, do not return until all ticks are complete </param>
		/// </summary>
		public void RunTickGroup(ETickingGroup Group, bool bBlockTillComplete)
			=> E_UWorld_RunTickGroup(this, (byte)Group, bBlockTillComplete);
		
		
		/// <summary>
		/// <para>Send all render updates to the rendering thread. </para>
		/// </summary>
		public void SendAllEndOfFrameUpdates()
			=> E_UWorld_SendAllEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Sets the level collection and its context on this world. Should only be called by FScopedLevelCollectionContextSwitch. </para>
		/// </summary>
		public void SetActiveLevelCollection(int LevelCollectionIndex)
			=> E_UWorld_SetActiveLevelCollection(this, LevelCollectionIndex);
		
		
		/// <summary>
		/// <para>Spawns GameMode for the level. </para>
		/// </summary>
		public bool SetGameMode(FURL InURL)
			=> E_UWorld_SetGameMode(this, InURL);
		
		
		/// <summary>
		/// <para>Sets NumLightingUnbuiltObjects to the specified value.  Marks the worldsettings package dirty if the value changed. </para>
		/// <param name="InNumLightingUnbuiltObjects">The new value. </param>
		/// </summary>
		public void SetMapNeedsLightingFullyRebuilt(int InNumLightingUnbuiltObjects, int InNumUnbuiltReflectionCaptures)
			=> E_UWorld_SetMapNeedsLightingFullyRebuilt(this, InNumLightingUnbuiltObjects, InNumUnbuiltReflectionCaptures);
		
		
		/// <summary>
		/// <para>this function allows pausing the seamless travel in the middle, </para>
		/// <para>right before it starts loading the destination (i.e. while in the transition level) </para>
		/// <para>this gives the opportunity to perform any other loading tasks before the final transition </para>
		/// <para>this function has no effect if we have already started loading the destination (you will get a log warning if this is the case) </para>
		/// <param name="bNowPaused">whether the transition should now be paused </param>
		/// </summary>
		public void SetSeamlessTravelMidpointPause(bool bNowPaused)
			=> E_UWorld_SetSeamlessTravelMidpointPause(this, bNowPaused);
		
		
		/// <summary>
		/// <para>Sets whether or not this world is ticked by the engine, but use it at your own risk! This could </para>
		/// <para>have unintended consequences if used carelessly. That said, for worlds that are not interactive </para>
		/// <para>and not rendering, it can save the cost of ticking them. This should probably never be used </para>
		/// <para>for a primary game world. </para>
		/// </summary>
		public void SetShouldTick(bool bInShouldTick)
			=> E_UWorld_SetShouldTick(this, bInShouldTick);
		
		
		/// <summary>
		/// <para>Updates the timer (as a one-off) that is used to trigger garbage collection; this should only be used for things </para>
		/// <para>like performance tests, using it recklessly can dramatically increase memory usage and cost of the eventual GC. </para>
		/// <para>Note: Things that force a GC will still force a GC after using this method (and they will also reset the timer) </para>
		/// </summary>
		public void SetTimeUntilNextGarbageCollection(float MinTimeUntilNextPass)
			=> E_UWorld_SetTimeUntilNextGarbageCollection(this, MinTimeUntilNextPass);
		
		
		/// <summary>
		/// <para>Creates instances for each parameter collection in memory.  Called when a world is created. </para>
		/// </summary>
		public void SetupParameterCollectionInstances()
			=> E_UWorld_SetupParameterCollectionInstances(this);
		
		
		/// <summary>
		/// <para>Set up the physics tick function if they aren't already </para>
		/// </summary>
		public void SetupPhysicsTickFunctions(float DeltaSeconds)
			=> E_UWorld_SetupPhysicsTickFunctions(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Returns whether or not this world is currently ticking. See SetShouldTick. </para>
		/// </summary>
		public bool ShouldTick()
			=> E_UWorld_ShouldTick(this);
		
		
		/// <summary>
		/// <para>Begin physics simulation </para>
		/// </summary>
		public void StartPhysicsSim()
			=> E_UWorld_StartPhysicsSim(this);
		
		
		/// <summary>
		/// <para>Given a PackageName and a prefix type, get back to the original package name (i.e. the saved map name) </para>
		/// </summary>
		public string StripPIEPrefixFromPackageName(string PackageName, string Prefix)
			=> E_UWorld_StripPIEPrefixFromPackageName(this, PackageName, Prefix);
		
		
		/// <summary>
		/// <para>Update the level after a variable amount of time, DeltaSeconds, has passed. </para>
		/// <para>All child actors are ticked after their owners have been ticked. </para>
		/// </summary>
		public void Tick(ELevelTick TickType, float DeltaSeconds)
			=> E_UWorld_Tick(this, (byte)TickType, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Do per frame tick behaviors related to the network driver </para>
		/// </summary>
		public void TickNetClient(float DeltaSeconds)
			=> E_UWorld_TickNetClient(this, DeltaSeconds);
		
		
		/// <summary>
		/// <para>Helper for getting the time since a certain time. </para>
		/// </summary>
		public float TimeSince(float Time)
			=> E_UWorld_TimeSince(this, Time);
		
		
		/// <summary>
		/// <para>Transfers the set of Kismet / Blueprint objects being debugged to the new world that are not already present, and updates blueprints accordingly </para>
		/// <param name="NewWorld">The new world to find equivalent objects in </param>
		/// </summary>
		public void TransferBlueprintDebugReferences(UWorld NewWorld)
			=> E_UWorld_TransferBlueprintDebugReferences(this, NewWorld);
		
		
		/// <summary>
		/// <para>Triggers a call to ULevel::BuildStreamingData(this,NULL,NULL) within a few seconds. </para>
		/// </summary>
		public void TriggerStreamingDataRebuild()
			=> E_UWorld_TriggerStreamingDataRebuild(this);
		
		
		/// <summary>
		/// <para>Updates an ActorComponent's cached state of whether it has been marked for end of frame update based on the current </para>
		/// <para>state of the World's NeedsEndOfFrameUpdate arrays </para>
		/// <param name="Component">Component to update the cached state of </param>
		/// </summary>
		public void UpdateActorComponentEndOfFrameUpdateState(UActorComponent Component)
			=> E_UWorld_UpdateActorComponentEndOfFrameUpdateState(this, Component);
		
		
		/// <summary>
		/// <para>Purges all sky capture cached derived data and forces a re-render of captured scene data. </para>
		/// </summary>
		public void UpdateAllSkyCaptures()
			=> E_UWorld_UpdateAllSkyCaptures(this);
		
		
		/// <summary>
		/// <para>Updates cull distance volumes for a specified component or a specified actor or all actors </para>
		/// <param name="ComponentToUpdate">If specified just that Component will be updated </param>
		/// <param name="ActorToUpdate">If specified (and ComponentToUpdate is not specified), all Components owned by this Actor will be updated </param>
		/// </summary>
		public void UpdateCullDistanceVolumes(AActor ActorToUpdate = null, UPrimitiveComponent ComponentToUpdate = null)
			=> E_UWorld_UpdateCullDistanceVolumes(this, ActorToUpdate, ComponentToUpdate);
		
		
		/// <summary>
		/// <para>Updates sub-levels (load/unload/show/hide) using streaming levels current state </para>
		/// </summary>
		public void UpdateLevelStreaming()
			=> E_UWorld_UpdateLevelStreaming(this);
		
		
		/// <summary>
		/// <para>Updates this world's scene with the list of instances, and optionally updates each instance's uniform buffer. </para>
		/// </summary>
		public void UpdateParameterCollectionInstances(bool bUpdateInstanceUniformBuffers)
			=> E_UWorld_UpdateParameterCollectionInstances(this, bUpdateInstanceUniformBuffers);
		
		
		/// <summary>
		/// <para>Updates world components like e.g. line batcher and all level components. </para>
		/// <param name="bRerunConstructionScripts">If we should rerun construction scripts on actors </param>
		/// <param name="bCurrentLevelOnly">If true, affect only the current level. </param>
		/// </summary>
		public void UpdateWorldComponents(bool bRerunConstructionScripts, bool bCurrentLevelOnly)
			=> E_UWorld_UpdateWorldComponents(this, bRerunConstructionScripts, bCurrentLevelOnly);
		
		
		/// <summary>
		/// <para>Returns true if this world should look at game hidden flags instead of editor hidden flags for the purposes of rendering </para>
		/// </summary>
		public bool UsesGameHiddenFlags()
			=> E_UWorld_UsesGameHiddenFlags(this);
		
		
		/// <summary>
		/// <para>Returns whether native properties are identical to the one of the passed in component. </para>
		/// <param name="Other">Other component to compare against </param>
		/// <return>true if native properties are identical, false otherwise </return>
		/// </summary>
		public override bool AreNativePropertiesIdenticalTo(UObject Other)
			=> E_UWorld_AreNativePropertiesIdenticalTo(this, Other);
		
		
		/// <summary>
		/// <para>Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an </para>
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy()
			=> E_UWorld_BeginDestroy(this);
		
		
		/// <summary>
		/// <para>Checks default sub-object assumptions. </para>
		/// <return>true if the assumptions are met, false otherwise. </return>
		/// </summary>
		public override bool CheckDefaultSubobjectsInternal()
			=> E_UWorld_CheckDefaultSubobjectsInternal(this);
		
		
		/// <summary>
		/// <para>Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed. </para>
		/// <para>note: because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's </para>
		/// <para>FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E_UWorld_FinishDestroy(this);
		
		
		/// <summary>
		/// <return>a one line description of an object for viewing in the thumbnail view of the generic browser </return>
		/// </summary>
		public override string GetDesc()
			=> E_UWorld_GetDesc(this);
		
		
		/// <summary>
		/// <para>This function actually does the work for the GetDetailInfo and is virtual. </para>
		/// <para>It should only be called from GetDetailedInfo as GetDetailedInfo is safe to call on NULL object pointers </para>
		/// </summary>
		public override string GetDetailedInfoInternal()
			=> E_UWorld_GetDetailedInfoInternal(this);
		
		public override UWorld GetWorld()
			=> E_UWorld_GetWorld(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered an asset. </para>
		/// </summary>
		public override bool IsAsset()
			=> E_UWorld_IsAsset(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine if the object is forced to be editor only or not </para>
		/// <return>true if this object should never be loaded outside the editor </return>
		/// </summary>
		public override bool IsEditorOnly()
			=> E_UWorld_IsEditorOnly(this);
		
		
		/// <summary>
		/// <para>IsFullNameStableForNetworking means an object can be referred to its full path name over the network </para>
		/// </summary>
		public override bool IsFullNameStableForNetworking()
			=> E_UWorld_IsFullNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is considered a localized resource. </para>
		/// </summary>
		public override bool IsLocalizedResource()
			=> E_UWorld_IsLocalizedResource(this);
		
		
		/// <summary>
		/// <para>IsNameStableForNetworking means an object can be referred to its path name (relative to outer) over the network </para>
		/// </summary>
		public override bool IsNameStableForNetworking()
			=> E_UWorld_IsNameStableForNetworking(this);
		
		
		/// <summary>
		/// <para>Called during async load to determine if PostLoad can be called on the loading thread. </para>
		/// <return>true if this object's PostLoad is thread safe </return>
		/// </summary>
		public override bool IsPostLoadThreadSafe()
			=> E_UWorld_IsPostLoadThreadSafe(this);
		
		
		/// <summary>
		/// <para>Called to check if the object is ready for FinishDestroy.  This is called after BeginDestroy to check the completion of the </para>
		/// <para>potentially asynchronous object cleanup. </para>
		/// <return>True if the object's asynchronous cleanup has completed and it is ready for FinishDestroy to be called. </return>
		/// </summary>
		public override bool IsReadyForFinishDestroy()
			=> E_UWorld_IsReadyForFinishDestroy(this);
		
		
		/// <summary>
		/// <para>Returns true if this object is safe to add to the root set. </para>
		/// </summary>
		public override bool IsSafeForRootSet()
			=> E_UWorld_IsSafeForRootSet(this);
		
		
		/// <summary>
		/// <para>IsSupportedForNetworking means an object can be referenced over the network </para>
		/// </summary>
		public override bool IsSupportedForNetworking()
			=> E_UWorld_IsSupportedForNetworking(this);
		
		public override void MarkAsEditorOnlySubobject()
			=> E_UWorld_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// <para>Note that the object will be modified.  If we are currently recording into the </para>
		/// <para>transaction buffer (undo/redo), save a copy of this object into the buffer and </para>
		/// <para>marks the package as needing to be saved. </para>
		/// <param name="bAlwaysMarkDirty">if true, marks the package dirty even if we aren't </param>
		/// <para>currently recording an active undo/redo transaction </para>
		/// <return>true if the object was saved to the transaction buffer </return>
		/// </summary>
		public override bool Modify(bool bAlwaysMarkDirty)
			=> E_UWorld_Modify(this, bAlwaysMarkDirty);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on clients </para>
		/// <return>true if this object should be loaded on clients </return>
		/// </summary>
		public override bool NeedsLoadForClient()
			=> E_UWorld_NeedsLoadForClient(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will still get loaded if NeedsLoadForServer/Client are true </para>
		/// <return>true if this object should always be loaded for editor game </return>
		/// </summary>
		public override bool NeedsLoadForEditorGame()
			=> E_UWorld_NeedsLoadForEditorGame(this);
		
		
		/// <summary>
		/// <para>Called during saving to determine the load flags to save with the object. </para>
		/// <para>If false, this object will be discarded on servers </para>
		/// <return>true if this object should be loaded on servers </return>
		/// </summary>
		public override bool NeedsLoadForServer()
			=> E_UWorld_NeedsLoadForServer(this);
		
		public override void NotifyObjectReferenceEliminated()
			=> E_UWorld_NotifyObjectReferenceEliminated(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion </para>
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E_UWorld_PostCDOContruct(this);
		
		
		/// <summary>
		/// <para>Called after importing property values for this object (paste, duplicate or .t3d import) </para>
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// <para>are unsupported by the script serialization </para>
		/// </summary>
		public override void PostEditImport()
			=> E_UWorld_PostEditImport(this);
		
		
		/// <summary>
		/// <para>Called after the C++ constructor and after the properties have been initialized, including those loaded from config. </para>
		/// <para>mainly this is to emulate some behavior of when the constructor was called after the properties were initialized. </para>
		/// </summary>
		public override void PostInitProperties()
			=> E_UWorld_PostInitProperties(this);
		
		
		/// <summary>
		/// <para>Do any object-specific cleanup required immediately after loading an object, </para>
		/// <para>and immediately after any undo/redo. </para>
		/// </summary>
		public override void PostLoad()
			=> E_UWorld_PostLoad(this);
		
		
		/// <summary>
		/// <para>Called right after receiving a bunch </para>
		/// </summary>
		public override void PostNetReceive()
			=> E_UWorld_PostNetReceive(this);
		
		
		/// <summary>
		/// <para>Test the selection state of a UObject </para>
		/// <return>true if the object is selected, false otherwise. </return>
		/// <para>@todo UE4 this doesn't belong here, but it doesn't belong anywhere else any better </para>
		/// </summary>
		public override void PostRename(UObject OldOuter, string OldName)
			=> E_UWorld_PostRename(this, OldOuter, OldName);
		
		
		/// <summary>
		/// <para>Called right after calling all OnRep notifies (called even when there are no notifies) </para>
		/// </summary>
		public override void PostRepNotifies()
			=> E_UWorld_PostRepNotifies(this);
		
		
		/// <summary>
		/// <para>Called from within SavePackage on the passed in base/ root. This function is being called after the package </para>
		/// <para>has been saved and can perform cleanup. </para>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up </param>
		/// </summary>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E_UWorld_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// <para>Called right before being marked for destruction due to network replication </para>
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E_UWorld_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// <para>Called right before receiving a bunch </para>
		/// </summary>
		public override void PreNetReceive()
			=> E_UWorld_PreNetReceive(this);
		
		public override void ShutdownAfterError()
			=> E_UWorld_ShutdownAfterError(this);
		
		
		/// <summary>
		/// <para>Adds this objects to a GC cluster that already exists </para>
		/// <param name="ClusterRootOrObjectFromCluster">Object that belongs to the cluster we want to add this object to. </param>
		/// <param name="Add">this object to the target cluster as a mutable object without adding this object's references. </param>
		/// </summary>
		public override void AddToCluster(UObjectBaseUtility ClusterRootOrObjectFromCluster, bool bAddAsMutableObject)
			=> E_UWorld_AddToCluster(this, ClusterRootOrObjectFromCluster, bAddAsMutableObject);
		
		
		/// <summary>
		/// <para>Called after load to determine if the object can be a cluster root </para>
		/// <return>true if this object can be a cluster root </return>
		/// </summary>
		public override bool CanBeClusterRoot()
			=> E_UWorld_CanBeClusterRoot(this);
		
		
		/// <summary>
		/// <para>Called during cluster construction if the object can be added to a cluster </para>
		/// <return>true if this object can be inside of a cluster </return>
		/// </summary>
		public override bool CanBeInCluster()
			=> E_UWorld_CanBeInCluster(this);
		
		
		/// <summary>
		/// <para>Called after PostLoad to create UObject cluster </para>
		/// </summary>
		public override void CreateCluster()
			=> E_UWorld_CreateCluster(this);
		
		
		/// <summary>
		/// <para>Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it. </para>
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E_UWorld_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(UWorld Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UWorld(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UWorld>(PtrDesc);
		}}}
