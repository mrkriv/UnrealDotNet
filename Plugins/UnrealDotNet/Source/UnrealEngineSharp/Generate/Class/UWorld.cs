// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\World.h:783

namespace UnrealEngine
{
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

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_AudioTimeSeconds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_AudioTimeSeconds_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bActorsInitialized_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bActorsInitialized_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bAggressiveLOD_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bAggressiveLOD_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bAllowAudioPlayback_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bAllowAudioPlayback_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bAreConstraintsDirty_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bAreConstraintsDirty_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bBegunPlay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bBegunPlay_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bCreateRenderStateForHiddenComponents_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bCreateRenderStateForHiddenComponents_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UWorld_bDebugDrawAllTraceTags_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bDebugDrawAllTraceTags_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bDebugPauseExecution_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bDebugPauseExecution_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bDropDetail_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bDropDetail_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bInTick_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bInTick_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bIsBuilt_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsBuilt_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bIsCameraMoveableWhenPaused_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsCameraMoveableWhenPaused_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bIsDefaultLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsDefaultLevel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bIsLevelStreamingFrozen_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsLevelStreamingFrozen_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bIsRunningConstructionScript_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsRunningConstructionScript_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bIsTearingDown_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsTearingDown_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bIsWorldInitialized_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bIsWorldInitialized_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bKismetScriptError_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bKismetScriptError_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bMatchStarted_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bMatchStarted_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bPlayersOnly_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bPlayersOnly_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bPlayersOnlyPending_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bPlayersOnlyPending_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bPostTickComponentUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bPostTickComponentUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bRequestedBlockOnAsyncLoading_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bRequestedBlockOnAsyncLoading_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bShouldSimulatePhysics_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bShouldSimulatePhysics_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bStartup_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bStartup_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bTickNewlySpawned_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bTickNewlySpawned_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bTriggerPostLoadMap_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bTriggerPostLoadMap_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UWorld_bWorldWasLoadedThisTick_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_bWorldWasLoadedThisTick_SET(IntPtr Ptr, byte Value);
		
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
		private static extern TemplatePointerDescription E_PROP_UWorld_PreparingLevelNames_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_PreparingLevelNames_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_RealTimeSeconds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_RealTimeSeconds_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UWorld_StreamingLevelsPrefix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_StreamingLevelsPrefix_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UWorld_StreamingVolumeUpdateDelay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_StreamingVolumeUpdateDelay_SET(IntPtr Ptr, int Value);
		
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
		private static extern TemplatePointerDescription E_PROP_UWorld_ViewLocationsRenderedLastFrame_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_ViewLocationsRenderedLastFrame_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UWorld(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_AddNetworkActor(IntPtr self, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_AddPawn(IntPtr self, IntPtr pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_AllowLevelLoadRequests(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_AreActorsInitialized(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_AreAlwaysLoadedLevelsLoaded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_AsyncLoadAlwaysLoadedLevelsForSeamlessTravel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_BeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_BroadcastLevelsChanged(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_BuildPIEPackagePrefix(IntPtr self, int pIEInstanceID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CancelPendingMapChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CleanupActors(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CleanupWorld(IntPtr self, bool bSessionEnded, bool bCleanupResources, IntPtr newWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ClearActorComponentEndOfFrameUpdate(IntPtr self, IntPtr component);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ClearStreamingLevels(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ClearWorldComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CommitMapChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CommitModelSurfaces(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ConditionallyBuildStreamingData(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_ContainsActor(IntPtr self, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_ConvertToPIEPackageName(IntPtr self, string packageName, int pIEInstanceID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CreateFXSystem(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_DebugDrawSceneQueries(IntPtr self, string usedTraceTag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DelayGarbageCollection(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DelayStreamingVolumeUpdates(IntPtr self, int inFrameDelay);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_DestroyActor(IntPtr self, IntPtr actor, bool bNetForce, bool bShouldModifyLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DestroyDemoNetDriver(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DestroyWorld(IntPtr self, bool bInformEngineOfWorld, IntPtr newWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_DuplicateRequestedLevels(IntPtr self, string mapName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorld_DuplicateWorldForPIE(IntPtr self, string packageName, IntPtr owningWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_EditorDestroyActor(IntPtr self, IntPtr actor, bool bShouldModifyLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_EncroachingBlockingGeometry(IntPtr self, IntPtr testActor, IntPtr testLocation, IntPtr testRotation, IntPtr proposedAdjustment);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_EnsureCollisionTreeIsBuilt(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_FindTeleportSpot(IntPtr self, IntPtr testActor, IntPtr placeLocation, IntPtr placeRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_FinishPhysicsSim(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_FlushLevelStreaming(IntPtr self, byte flushType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ForceGarbageCollection(IntPtr self, bool bFullPurge);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetActiveLevelCollectionIndex(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetActorCount(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetAudioTimeSeconds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetDefaultGravityZ(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetDeltaSeconds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetDetailMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetGravityZ(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_GetMapName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UWorld_GetNetMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetNonDefaultPhysicsVolumeCount(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetNumLevels(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetNumPawns(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetNumPlayerControllers(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetProgressDenominator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetRealTimeSeconds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_GetShouldForceUnloadStreamingLevels(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_GetShouldForceVisibleStreamingLevels(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetTimeBetweenGarbageCollectionPasses(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetTimeSeconds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetUnpausedTimeSeconds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_HandleTimelineScrubbed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_HasBegunPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_HasDefaultPhysicsVolume(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_HasEndOfFrameUpdates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_HasMarkedObjectsPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_InitializeActorsForPlay(IntPtr self, IntPtr inURL, bool bResetTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_InvalidateModelSurface(IntPtr self, bool bCurrentLevelOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsCameraMoveable(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsClient(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsEditorWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsGameWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsInSeamlessTravel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsMapChangeReady(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsNavigationRebuilt(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsNetMode(IntPtr self, byte mode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPaused(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayInEditor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayingClientReplay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayingReplay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayInMobilePreview(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayInPreview(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPlayInVulkanPreview(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPreparingMapChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsPreviewWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsRecordingClientReplay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsServer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_IsVisibilityRequestPending(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_Listen(IntPtr self, IntPtr inURL);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(IntPtr self, IntPtr component, bool bForceGameThread);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_MarkObjectsPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PerformGarbageCollectionAndCleanupActors(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PopulateStreamingLevelsToConsider(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PrepareMapChange(IntPtr self, IntPtr levelNames);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ProcessLevelStreamingVolumes(IntPtr self, IntPtr overrideViewLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PropagateLightingScenarioChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_RemapCompiledScriptActor(IntPtr self, string str);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RemoveActor(IntPtr self, IntPtr actor, bool bShouldModifyLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RemoveNetworkActor(IntPtr self, IntPtr actor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RemovePawn(IntPtr self, IntPtr pawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_RemovePIEPrefix(IntPtr self, string source);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_RemoveStreamingLevelAt(IntPtr self, int indexToRemove);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RenameToPIEWorld(IntPtr self, int pIEInstanceID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_RequiresHitProxies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RunTickGroup(IntPtr self, byte group, bool bBlockTillComplete);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SendAllEndOfFrameUpdates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetActiveLevelCollection(IntPtr self, int levelCollectionIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_SetGameMode(IntPtr self, IntPtr inURL);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetMapNeedsLightingFullyRebuilt(IntPtr self, int inNumLightingUnbuiltObjects, int inNumUnbuiltReflectionCaptures);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetMaterialParameterCollectionInstanceNeedsUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetSeamlessTravelMidpointPause(IntPtr self, bool bNowPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetShouldForceUnloadStreamingLevels(IntPtr self, bool bInShouldForceUnloadStreamingLevels);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetShouldForceVisibleStreamingLevels(IntPtr self, bool bInShouldForceVisibleStreamingLevels);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetShouldTick(IntPtr self, bool bInShouldTick);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetTimeUntilNextGarbageCollection(IntPtr self, float minTimeUntilNextPass);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetupParameterCollectionInstances(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetupPhysicsTickFunctions(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_ShouldTick(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_StartPhysicsSim(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UWorld_StripPIEPrefixFromPackageName(IntPtr self, string packageName, string prefix);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_Tick(IntPtr self, byte tickType, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_TickNetClient(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_TimeSince(IntPtr self, float time);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_TransferBlueprintDebugReferences(IntPtr self, IntPtr newWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_TriggerStreamingDataRebuild(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateAllSkyCaptures(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_UpdateCullDistanceVolumes(IntPtr self, IntPtr actorToUpdate, IntPtr componentToUpdate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateLevelStreaming(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateParameterCollectionInstances(IntPtr self, bool bUpdateInstanceUniformBuffers, bool bRecreateUniformBuffer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_UpdateWorldComponents(IntPtr self, bool bRerunConstructionScripts, bool bCurrentLevelOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_UsesGameHiddenFlags(IntPtr self);
		
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
		/// <para>Whether actors have been initialized for play </para>
		/// </summary>
		public byte bActorsInitialized
		{
			get => E_PROP_UWorld_bActorsInitialized_GET(NativePointer);
			set => E_PROP_UWorld_bActorsInitialized_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>frame rate is well below DesiredFrameRate, so make LOD more aggressive </para>
		/// </summary>
		public byte bAggressiveLOD
		{
			get => E_PROP_UWorld_bAggressiveLOD_GET(NativePointer);
			set => E_PROP_UWorld_bAggressiveLOD_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Indicates this scene always allows audio playback. </para>
		/// </summary>
		public byte bAllowAudioPlayback
		{
			get => E_PROP_UWorld_bAllowAudioPlayback_GET(NativePointer);
			set => E_PROP_UWorld_bAllowAudioPlayback_SET(NativePointer, value);
		}

		public byte bAreConstraintsDirty
		{
			get => E_PROP_UWorld_bAreConstraintsDirty_GET(NativePointer);
			set => E_PROP_UWorld_bAreConstraintsDirty_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether BeginPlay has been called on actors </para>
		/// </summary>
		public byte bBegunPlay
		{
			get => E_PROP_UWorld_bBegunPlay_GET(NativePointer);
			set => E_PROP_UWorld_bBegunPlay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If TRUE, 'hidden' components will still create render proxy, so can draw info (see USceneComponent::ShouldRender) </para>
		/// </summary>
		public byte bCreateRenderStateForHiddenComponents
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

		public byte bDebugPauseExecution
		{
			get => E_PROP_UWorld_bDebugPauseExecution_GET(NativePointer);
			set => E_PROP_UWorld_bDebugPauseExecution_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>True we want to execute a call to UpdateCulledTriggerVolumes during Tick </para>
		/// </summary>
		public byte bDoDelayedUpdateCullDistanceVolumes
		{
			get => E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_GET(NativePointer);
			set => E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>frame rate is below DesiredFrameRate, so drop high detail actors </para>
		/// </summary>
		public byte bDropDetail
		{
			get => E_PROP_UWorld_bDropDetail_GET(NativePointer);
			set => E_PROP_UWorld_bDropDetail_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether we are in the middle of ticking actors/components or not </para>
		/// </summary>
		public byte bInTick
		{
			get => E_PROP_UWorld_bInTick_GET(NativePointer);
			set => E_PROP_UWorld_bInTick_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether we have already built the collision tree or not </para>
		/// </summary>
		public byte bIsBuilt
		{
			get => E_PROP_UWorld_bIsBuilt_GET(NativePointer);
			set => E_PROP_UWorld_bIsBuilt_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When set, camera is potentially moveable even when paused </para>
		/// </summary>
		public byte bIsCameraMoveableWhenPaused
		{
			get => E_PROP_UWorld_bIsCameraMoveableWhenPaused_GET(NativePointer);
			set => E_PROP_UWorld_bIsCameraMoveableWhenPaused_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>That map is default map or not </para>
		/// </summary>
		public byte bIsDefaultLevel
		{
			get => E_PROP_UWorld_bIsDefaultLevel_GET(NativePointer);
			set => E_PROP_UWorld_bIsDefaultLevel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Is level streaming currently frozen? </para>
		/// </summary>
		public byte bIsLevelStreamingFrozen
		{
			get => E_PROP_UWorld_bIsLevelStreamingFrozen_GET(NativePointer);
			set => E_PROP_UWorld_bIsLevelStreamingFrozen_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true this world is in the process of running the construction script for an actor </para>
		/// </summary>
		public byte bIsRunningConstructionScript
		{
			get => E_PROP_UWorld_bIsRunningConstructionScript_GET(NativePointer);
			set => E_PROP_UWorld_bIsRunningConstructionScript_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Is the world being torn down </para>
		/// </summary>
		public byte bIsTearingDown
		{
			get => E_PROP_UWorld_bIsTearingDown_GET(NativePointer);
			set => E_PROP_UWorld_bIsTearingDown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether world object has been initialized via Init() </para>
		/// </summary>
		public byte bIsWorldInitialized
		{
			get => E_PROP_UWorld_bIsWorldInitialized_GET(NativePointer);
			set => E_PROP_UWorld_bIsWorldInitialized_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>This is a bool that indicates that one or more blueprints in the level (blueprint instances, level script, etc) </para>
		/// <para>have compile errors that could not be automatically resolved. </para>
		/// </summary>
		public byte bKismetScriptError
		{
			get => E_PROP_UWorld_bKismetScriptError_GET(NativePointer);
			set => E_PROP_UWorld_bKismetScriptError_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether the match has been started </para>
		/// </summary>
		public byte bMatchStarted
		{
			get => E_PROP_UWorld_bMatchStarted_GET(NativePointer);
			set => E_PROP_UWorld_bMatchStarted_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>When ticking the world, only update players. </para>
		/// </summary>
		public byte bPlayersOnly
		{
			get => E_PROP_UWorld_bPlayersOnly_GET(NativePointer);
			set => E_PROP_UWorld_bPlayersOnly_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Indicates that at the end the frame bPlayersOnly will be set to true. </para>
		/// </summary>
		public byte bPlayersOnlyPending
		{
			get => E_PROP_UWorld_bPlayersOnlyPending_GET(NativePointer);
			set => E_PROP_UWorld_bPlayersOnlyPending_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Indicates that during world ticking we are doing the final component update of dirty components </para>
		/// <para>(after PostAsyncWork and effect physics scene has run. </para>
		/// </summary>
		public byte bPostTickComponentUpdate
		{
			get => E_PROP_UWorld_bPostTickComponentUpdate_GET(NativePointer);
			set => E_PROP_UWorld_bPostTickComponentUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether it was requested that the engine bring up a loading screen and block on async loading. </para>
		/// </summary>
		public byte bRequestedBlockOnAsyncLoading
		{
			get => E_PROP_UWorld_bRequestedBlockOnAsyncLoading_GET(NativePointer);
			set => E_PROP_UWorld_bRequestedBlockOnAsyncLoading_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true this world will tick physics to simulate. This isn't same as having Physics Scene. </para>
		/// <para>You need Physics Scene if you'd like to trace. This flag changed ticking </para>
		/// </summary>
		public byte bShouldSimulatePhysics
		{
			get => E_PROP_UWorld_bShouldSimulatePhysics_GET(NativePointer);
			set => E_PROP_UWorld_bShouldSimulatePhysics_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Is the world in its actor initialization phase. </para>
		/// </summary>
		public byte bStartup
		{
			get => E_PROP_UWorld_bStartup_GET(NativePointer);
			set => E_PROP_UWorld_bStartup_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>We are in the middle of actor ticking, so add tasks for newly spawned actors </para>
		/// </summary>
		public byte bTickNewlySpawned
		{
			get => E_PROP_UWorld_bTickNewlySpawned_GET(NativePointer);
			set => E_PROP_UWorld_bTickNewlySpawned_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Triggers a call to PostLoadMap() the next Tick, turns off loading movie if LoadMap() has been called. </para>
		/// </summary>
		public byte bTriggerPostLoadMap
		{
			get => E_PROP_UWorld_bTriggerPostLoadMap_GET(NativePointer);
			set => E_PROP_UWorld_bTriggerPostLoadMap_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>set for one tick after completely loading and initializing a new world </para>
		/// <para>(regardless of whether it's LoadMap() or seamless travel) </para>
		/// </summary>
		public byte bWorldWasLoadedThisTick
		{
			get => E_PROP_UWorld_bWorldWasLoadedThisTick_GET(NativePointer);
			set => E_PROP_UWorld_bWorldWasLoadedThisTick_SET(NativePointer, value);
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
		/// <para>array of levels that were loaded into this map via PrepareMapChange() / CommitMapChange() (to inform newly joining clients) </para>
		/// </summary>
		public TArray<string> PreparingLevelNames
		{
			get => E_PROP_UWorld_PreparingLevelNames_GET(NativePointer);
			set => E_PROP_UWorld_PreparingLevelNames_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Time in seconds since level began play, but IS NOT paused when the game is paused, and IS NOT dilated/clamped. </para>
		/// </summary>
		public float RealTimeSeconds
		{
			get => E_PROP_UWorld_RealTimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_RealTimeSeconds_SET(NativePointer, value);
		}

		public string StreamingLevelsPrefix
		{
			get => E_PROP_UWorld_StreamingLevelsPrefix_GET(NativePointer);
			set => E_PROP_UWorld_StreamingLevelsPrefix_SET(NativePointer, value);
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

		
		/// <summary>
		/// <para>View locations rendered in the previous frame, if any. </para>
		/// </summary>
		public TArray<FVector> ViewLocationsRenderedLastFrame
		{
			get => E_PROP_UWorld_ViewLocationsRenderedLastFrame_GET(NativePointer);
			set => E_PROP_UWorld_ViewLocationsRenderedLastFrame_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Adds the passed in actor to the special network actor list </para>
		/// <para>This list is used to specifically single out actors that are relevant for networking without having to scan the much large list </para>
		/// <param name="Actor">Actor to add </param>
		/// </summary>
		public void AddNetworkActor(AActor actor)
			=> E_UWorld_AddNetworkActor(this, actor);
		
		
		/// <summary>
		/// <para>Inserts the passed in pawn at the front of the linked list of pawns. </para>
		/// <param name="Pawn">Pawn to insert, use NULL to clear list </param>
		/// </summary>
		public void AddPawn(APawn pawn)
			=> E_UWorld_AddPawn(this, pawn);
		
		
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
		public string BuildPIEPackagePrefix(int pIEInstanceID)
			=> E_UWorld_BuildPIEPackagePrefix(this, pIEInstanceID);
		
		
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
		public void CleanupWorld(bool bSessionEnded = true, bool bCleanupResources = true, UWorld newWorld = null)
			=> E_UWorld_CleanupWorld(this, bSessionEnded, bCleanupResources, newWorld);
		
		
		/// <summary>
		/// <para>Clears the need for a component to have a end of frame update </para>
		/// <param name="Component">Component to update at the end of the frame </param>
		/// </summary>
		public void ClearActorComponentEndOfFrameUpdate(UActorComponent component)
			=> E_UWorld_ClearActorComponentEndOfFrameUpdate(this, component);
		
		
		/// <summary>
		/// <para>Reset the streaming levels array </para>
		/// </summary>
		public void ClearStreamingLevels()
			=> E_UWorld_ClearStreamingLevels(this);
		
		
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
		public bool ContainsActor(AActor actor)
			=> E_UWorld_ContainsActor(this, actor);
		
		
		/// <summary>
		/// <para>Given a PackageName and a PIE Instance ID return the name of that Package when being run as a PIE world </para>
		/// </summary>
		public string ConvertToPIEPackageName(string packageName, int pIEInstanceID)
			=> E_UWorld_ConvertToPIEPackageName(this, packageName, pIEInstanceID);
		
		
		/// <summary>
		/// <para>Creates a new FX system for this world </para>
		/// </summary>
		public void CreateFXSystem()
			=> E_UWorld_CreateFXSystem(this);
		
		public bool DebugDrawSceneQueries(string usedTraceTag)
			=> E_UWorld_DebugDrawSceneQueries(this, usedTraceTag);
		
		
		/// <summary>
		/// <para>Requests a one frame delay of Garbage Collection </para>
		/// </summary>
		public void DelayGarbageCollection()
			=> E_UWorld_DelayGarbageCollection(this);
		
		
		/// <summary>
		/// <para>Sets the number of frames to delay Streaming Volume updating, </para>
		/// <para>useful if you preload a bunch of levels but the camera hasn't caught up yet </para>
		/// </summary>
		public void DelayStreamingVolumeUpdates(int inFrameDelay)
			=> E_UWorld_DelayStreamingVolumeUpdates(this, inFrameDelay);
		
		
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
		public bool DestroyActor(AActor actor, bool bNetForce = false, bool bShouldModifyLevel = true)
			=> E_UWorld_DestroyActor(this, actor, bNetForce, bShouldModifyLevel);
		
		
		/// <summary>
		/// <para>Utility function to handle Exec/Console Command for setting the speed of a replay </para>
		/// </summary>
		public void DestroyDemoNetDriver()
			=> E_UWorld_DestroyDemoNetDriver(this);
		
		
		/// <summary>
		/// <para>Destroy this World instance. If destroying the world to load a different world, supply it here to prevent GC of the new world or it's sublevels. </para>
		/// </summary>
		public void DestroyWorld(bool bInformEngineOfWorld, UWorld newWorld = null)
			=> E_UWorld_DestroyWorld(this, bInformEngineOfWorld, newWorld);
		
		
		/// <summary>
		/// <para>Creates a new level collection of type DynamicDuplicatedLevels by duplicating the levels in DynamicSourceLevels. </para>
		/// <para>Should only be called by engine. </para>
		/// <param name="MapName">The name of the soure map, used as a parameter to UEngine::Experimental_ShouldPreDuplicateMap </param>
		/// </summary>
		public void DuplicateRequestedLevels(string mapName)
			=> E_UWorld_DuplicateRequestedLevels(this, mapName);
		
		
		/// <summary>
		/// <para>Given a loaded editor UWorld, duplicate it for play in editor purposes with OwningWorld as the world with the persistent level. </para>
		/// </summary>
		public UWorld DuplicateWorldForPIE(string packageName, UWorld owningWorld)
			=> E_UWorld_DuplicateWorldForPIE(this, packageName, owningWorld);
		
		
		/// <summary>
		/// <para>Wrapper for DestroyActor() that should be called in the editor. </para>
		/// <param name="bShouldModifyLevel">If true, Modify() the level before removing the actor. </param>
		/// </summary>
		public bool EditorDestroyActor(AActor actor, bool bShouldModifyLevel)
			=> E_UWorld_EditorDestroyActor(this, actor, bShouldModifyLevel);
		
		
		/// <summary>
		/// <para>@Return true if Actor would encroach at TestLocation on something that blocks it.  Returns a ProposedAdjustment that might result in an unblocked TestLocation. </para>
		/// </summary>
		public bool EncroachingBlockingGeometry(AActor testActor, FVector testLocation, FRotator testRotation, FVector proposedAdjustment = null)
			=> E_UWorld_EncroachingBlockingGeometry(this, testActor, testLocation, testRotation, proposedAdjustment);
		
		
		/// <summary>
		/// <para>Ensures that the collision detection tree is fully built. This should be called after the full level reload to make sure </para>
		/// <para>the first traces are not abysmally slow. </para>
		/// </summary>
		public void EnsureCollisionTreeIsBuilt()
			=> E_UWorld_EnsureCollisionTreeIsBuilt(this);
		
		
		/// <summary>
		/// <para>Try to find an acceptable non-colliding location to place TestActor as close to possible to PlaceLocation. Expects PlaceLocation to be a valid location inside the level. </para>
		/// <para>Returns true if a location without blocking collision is found, in which case PlaceLocation is overwritten with the new clear location. </para>
		/// <para>Returns false if no suitable location could be found, in which case PlaceLocation is unmodified. </para>
		/// </summary>
		public bool FindTeleportSpot(AActor testActor, FVector placeLocation, FRotator placeRotation)
			=> E_UWorld_FindTeleportSpot(this, testActor, placeLocation, placeRotation);
		
		
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
		public void FlushLevelStreaming(EFlushLevelStreamingType flushType)
			=> E_UWorld_FlushLevelStreaming(this, (byte)flushType);
		
		
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
		/// <para>Returns the name of the current map, taking into account using a dummy persistent world </para>
		/// <para>and loading levels into it via PrepareMapChange. </para>
		/// <return>name of the current map </return>
		/// </summary>
		public string GetMapName()
			=> E_UWorld_GetMapName(this);
		
		
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
		/// <return>Returns the number of Player Controllers. </return>
		/// </summary>
		public int GetNumPlayerControllers()
			=> E_UWorld_GetNumPlayerControllers(this);
		
		
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
		
		public bool GetShouldForceUnloadStreamingLevels()
			=> E_UWorld_GetShouldForceUnloadStreamingLevels(this);
		
		public bool GetShouldForceVisibleStreamingLevels()
			=> E_UWorld_GetShouldForceVisibleStreamingLevels(this);
		
		
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
		
		public void HandleTimelineScrubbed()
			=> E_UWorld_HandleTimelineScrubbed(this);
		
		
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
		
		
		/// <summary>
		/// <para>Returns true if we have any updates that have been deferred to the end of the current frame. </para>
		/// </summary>
		public bool HasEndOfFrameUpdates()
			=> E_UWorld_HasEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Indicates that the world has marked contained objects as pending kill </para>
		/// </summary>
		public bool HasMarkedObjectsPendingKill()
			=> E_UWorld_HasMarkedObjectsPendingKill(this);
		
		
		/// <summary>
		/// <para>Initializes all actors and prepares them to start gameplay </para>
		/// <param name="InURL">commandline URL </param>
		/// <param name="bResetTime">optional) whether the WorldSettings's TimeSeconds should be reset to zero </param>
		/// </summary>
		public void InitializeActorsForPlay(FURL inURL, bool bResetTime = true)
			=> E_UWorld_InitializeActorsForPlay(this, inURL, bResetTime);
		
		
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
		public bool IsNetMode(ENetMode mode)
			=> E_UWorld_IsNetMode(this, (byte)mode);
		
		
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
		/// <para>Returns true if the demo net driver exists and is playing a client recorded replay. </para>
		/// </summary>
		public bool IsPlayingClientReplay()
			=> E_UWorld_IsPlayingClientReplay(this);
		
		
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
		
		public bool Listen(FURL inURL)
			=> E_UWorld_Listen(this, inURL);
		
		
		/// <summary>
		/// <para>Mark a component as needing an end of frame update </para>
		/// <param name="Component">Component to update at the end of the frame </param>
		/// <param name="bForceGameThread">if true, force this to happen on the game thread </param>
		/// </summary>
		public void MarkActorComponentForNeededEndOfFrameUpdate(UActorComponent component, bool bForceGameThread)
			=> E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(this, component, bForceGameThread);
		
		
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
		/// <para>Examine all streaming levels and determine which ones should be considered. </para>
		/// </summary>
		public void PopulateStreamingLevelsToConsider()
			=> E_UWorld_PopulateStreamingLevelsToConsider(this);
		
		
		/// <summary>
		/// <para>asynchronously loads the given levels in preparation for a streaming map transition. </para>
		/// <para>This codepath is designed for worlds that heavily use level streaming and GameModes where the game state should </para>
		/// <para>be preserved through a transition. </para>
		/// <param name="LevelNames">the names of the level packages to load. LevelNames[0] will be the new persistent (primary) level </param>
		/// </summary>
		public void PrepareMapChange(TArray<string> levelNames)
			=> E_UWorld_PrepareMapChange(this, levelNames);
		
		
		/// <summary>
		/// <para>Issues level streaming load/unload requests based on whether </para>
		/// <para>local players are inside/outside level streaming volumes. </para>
		/// <param name="OverrideViewLocation">Optional position used to override the location used to calculate current streaming volumes </param>
		/// </summary>
		public void ProcessLevelStreamingVolumes(FVector overrideViewLocation = null)
			=> E_UWorld_ProcessLevelStreamingVolumes(this, overrideViewLocation);
		
		
		/// <summary>
		/// <para>Propagates a change to the active lighting scenario. </para>
		/// </summary>
		public void PropagateLightingScenarioChange()
			=> E_UWorld_PropagateLightingScenarioChange(this);
		
		
		/// <summary>
		/// <para>Given a level script actor, modify the string such that it points to the correct instance of the object. For replays. </para>
		/// </summary>
		public bool RemapCompiledScriptActor(string str)
			=> E_UWorld_RemapCompiledScriptActor(this, str);
		
		
		/// <summary>
		/// <para>Removes the passed in actor from the actor lists. Please note that the code actually doesn't physically remove the </para>
		/// <para>index but rather clears it so other indices are still valid and the actors array size doesn't change. </para>
		/// <param name="Actor">Actor to remove. </param>
		/// <param name="bShouldModifyLevel">If true, Modify() the level before removing the actor if in the editor. </param>
		/// </summary>
		public void RemoveActor(AActor actor, bool bShouldModifyLevel)
			=> E_UWorld_RemoveActor(this, actor, bShouldModifyLevel);
		
		
		/// <summary>
		/// <para>Removes the passed in actor to from special network actor list </para>
		/// <param name="Actor">Actor to remove </param>
		/// </summary>
		public void RemoveNetworkActor(AActor actor)
			=> E_UWorld_RemoveNetworkActor(this, actor);
		
		
		/// <summary>
		/// <para>Removes the passed in pawn from the linked list of pawns. </para>
		/// <param name="Pawn">Pawn to remove </param>
		/// </summary>
		public void RemovePawn(APawn pawn)
			=> E_UWorld_RemovePawn(this, pawn);
		
		
		/// <summary>
		/// <para>Given a string, return that string with any PIE prefix removed </para>
		/// </summary>
		public string RemovePIEPrefix(string source)
			=> E_UWorld_RemovePIEPrefix(this, source);
		
		
		/// <summary>
		/// <para>Remove a streaming level to the list of streamed levels to consider. </para>
		/// <para>Returns true if the specified index was a valid index for removal. </para>
		/// </summary>
		public bool RemoveStreamingLevelAt(int indexToRemove)
			=> E_UWorld_RemoveStreamingLevelAt(this, indexToRemove);
		
		
		/// <summary>
		/// <para>Rename this world such that it has the prefix on names for the given PIE Instance ID </para>
		/// </summary>
		public void RenameToPIEWorld(int pIEInstanceID)
			=> E_UWorld_RenameToPIEWorld(this, pIEInstanceID);
		
		
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
		public void RunTickGroup(ETickingGroup group, bool bBlockTillComplete)
			=> E_UWorld_RunTickGroup(this, (byte)group, bBlockTillComplete);
		
		
		/// <summary>
		/// <para>Send all render updates to the rendering thread. </para>
		/// </summary>
		public void SendAllEndOfFrameUpdates()
			=> E_UWorld_SendAllEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// <para>Sets the level collection and its context on this world. Should only be called by FScopedLevelCollectionContextSwitch. </para>
		/// </summary>
		public void SetActiveLevelCollection(int levelCollectionIndex)
			=> E_UWorld_SetActiveLevelCollection(this, levelCollectionIndex);
		
		
		/// <summary>
		/// <para>Spawns GameMode for the level. </para>
		/// </summary>
		public bool SetGameMode(FURL inURL)
			=> E_UWorld_SetGameMode(this, inURL);
		
		
		/// <summary>
		/// <para>Sets NumLightingUnbuiltObjects to the specified value.  Marks the worldsettings package dirty if the value changed. </para>
		/// <param name="InNumLightingUnbuiltObjects">The new value. </param>
		/// </summary>
		public void SetMapNeedsLightingFullyRebuilt(int inNumLightingUnbuiltObjects, int inNumUnbuiltReflectionCaptures)
			=> E_UWorld_SetMapNeedsLightingFullyRebuilt(this, inNumLightingUnbuiltObjects, inNumUnbuiltReflectionCaptures);
		
		
		/// <summary>
		/// <para>Used to indicate a UMaterialParameterCollectionInstance needs a deferred update </para>
		/// </summary>
		public void SetMaterialParameterCollectionInstanceNeedsUpdate()
			=> E_UWorld_SetMaterialParameterCollectionInstanceNeedsUpdate(this);
		
		
		/// <summary>
		/// <para>this function allows pausing the seamless travel in the middle, </para>
		/// <para>right before it starts loading the destination (i.e. while in the transition level) </para>
		/// <para>this gives the opportunity to perform any other loading tasks before the final transition </para>
		/// <para>this function has no effect if we have already started loading the destination (you will get a log warning if this is the case) </para>
		/// <param name="bNowPaused">whether the transition should now be paused </param>
		/// </summary>
		public void SetSeamlessTravelMidpointPause(bool bNowPaused)
			=> E_UWorld_SetSeamlessTravelMidpointPause(this, bNowPaused);
		
		public void SetShouldForceUnloadStreamingLevels(bool bInShouldForceUnloadStreamingLevels)
			=> E_UWorld_SetShouldForceUnloadStreamingLevels(this, bInShouldForceUnloadStreamingLevels);
		
		public void SetShouldForceVisibleStreamingLevels(bool bInShouldForceVisibleStreamingLevels)
			=> E_UWorld_SetShouldForceVisibleStreamingLevels(this, bInShouldForceVisibleStreamingLevels);
		
		
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
		public void SetTimeUntilNextGarbageCollection(float minTimeUntilNextPass)
			=> E_UWorld_SetTimeUntilNextGarbageCollection(this, minTimeUntilNextPass);
		
		
		/// <summary>
		/// <para>Creates instances for each parameter collection in memory.  Called when a world is created. </para>
		/// </summary>
		public void SetupParameterCollectionInstances()
			=> E_UWorld_SetupParameterCollectionInstances(this);
		
		
		/// <summary>
		/// <para>Set up the physics tick function if they aren't already </para>
		/// </summary>
		public void SetupPhysicsTickFunctions(float deltaSeconds)
			=> E_UWorld_SetupPhysicsTickFunctions(this, deltaSeconds);
		
		
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
		public string StripPIEPrefixFromPackageName(string packageName, string prefix)
			=> E_UWorld_StripPIEPrefixFromPackageName(this, packageName, prefix);
		
		
		/// <summary>
		/// <para>Update the level after a variable amount of time, DeltaSeconds, has passed. </para>
		/// <para>All child actors are ticked after their owners have been ticked. </para>
		/// </summary>
		public void Tick(ELevelTick tickType, float deltaSeconds)
			=> E_UWorld_Tick(this, (byte)tickType, deltaSeconds);
		
		
		/// <summary>
		/// <para>Do per frame tick behaviors related to the network driver </para>
		/// </summary>
		public void TickNetClient(float deltaSeconds)
			=> E_UWorld_TickNetClient(this, deltaSeconds);
		
		
		/// <summary>
		/// <para>Helper for getting the time since a certain time. </para>
		/// </summary>
		public float TimeSince(float time)
			=> E_UWorld_TimeSince(this, time);
		
		
		/// <summary>
		/// <para>Transfers the set of Kismet / Blueprint objects being debugged to the new world that are not already present, and updates blueprints accordingly </para>
		/// <param name="NewWorld">The new world to find equivalent objects in </param>
		/// </summary>
		public void TransferBlueprintDebugReferences(UWorld newWorld)
			=> E_UWorld_TransferBlueprintDebugReferences(this, newWorld);
		
		
		/// <summary>
		/// <para>Triggers a call to ULevel::BuildStreamingData(this,NULL,NULL) within a few seconds. </para>
		/// </summary>
		public void TriggerStreamingDataRebuild()
			=> E_UWorld_TriggerStreamingDataRebuild(this);
		
		
		/// <summary>
		/// <para>Purges all sky capture cached derived data and forces a re-render of captured scene data. </para>
		/// </summary>
		public void UpdateAllSkyCaptures()
			=> E_UWorld_UpdateAllSkyCaptures(this);
		
		
		/// <summary>
		/// <para>Updates cull distance volumes for a specified component or a specified actor or all actors </para>
		/// <param name="ComponentToUpdate">If specified just that Component will be updated </param>
		/// <param name="ActorToUpdate">If specified (and ComponentToUpdate is not specified), all Components owned by this Actor will be updated </param>
		/// <return>True if the passed in actors or components were within a volume </return>
		/// </summary>
		public bool UpdateCullDistanceVolumes(AActor actorToUpdate = null, UPrimitiveComponent componentToUpdate = null)
			=> E_UWorld_UpdateCullDistanceVolumes(this, actorToUpdate, componentToUpdate);
		
		
		/// <summary>
		/// <para>Updates sub-levels (load/unload/show/hide) using streaming levels current state </para>
		/// </summary>
		public void UpdateLevelStreaming()
			=> E_UWorld_UpdateLevelStreaming(this);
		
		
		/// <summary>
		/// <para>Updates this world's scene with the list of instances, and optionally updates each instance's uniform buffer. </para>
		/// </summary>
		public void UpdateParameterCollectionInstances(bool bUpdateInstanceUniformBuffers, bool bRecreateUniformBuffer)
			=> E_UWorld_UpdateParameterCollectionInstances(this, bUpdateInstanceUniformBuffers, bRecreateUniformBuffer);
		
		
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
		
		#endregion
		
		public static implicit operator IntPtr(UWorld self)
		{
			return self.NativePointer;
		}

		public static implicit operator UWorld(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UWorld>(PtrDesc);
		}}}
