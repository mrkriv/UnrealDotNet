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
		public UWorld(IntPtr adress)
			: base(adress)
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
		private static extern ObjectPointerDescription E_PROP_UWorld_ForegroundLineBatcher_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_ForegroundLineBatcher_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_SET(IntPtr Ptr, double Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UWorld_LineBatcher_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_LineBatcher_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UWorld_NetworkManager_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_NetworkManager_SET(IntPtr Ptr, IntPtr Value);
		
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
		private static extern IntPtr E_PROP_UWorld_OriginLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_OriginLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UWorld_OriginOffsetThisFrame_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_OriginOffsetThisFrame_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_PauseDelay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_PauseDelay_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UWorld_PersistentLineBatcher_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_PersistentLineBatcher_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UWorld_PlayerNum_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_PlayerNum_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UWorld_RealTimeSeconds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_RealTimeSeconds_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UWorld_RequestedOriginLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UWorld_RequestedOriginLocation_SET(IntPtr Ptr, IntPtr Value);
		
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
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UWorld(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_AddController(IntPtr self, IntPtr controller);
		
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
		private static extern void E_UWorld_CopyGameState(IntPtr self, IntPtr fromGameMode, IntPtr fromGameState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CreateFXSystem(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_CreatePhysicsScene(IntPtr self, IntPtr settings);
		
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
		private static extern ObjectPointerDescription E_UWorld_GetAuthGameMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorld_GetCanvasForDrawMaterialToRenderTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorld_GetCanvasForRenderingToTarget(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetDefaultGravityZ(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UWorld_GetDeltaSeconds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UWorld_GetDetailMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorld_GetFirstLocalPlayerFromController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorld_GetFirstPlayerController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorld_GetGameState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UWorld_GetGameViewport(IntPtr self);
		
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
		private static extern ObjectPointerDescription E_UWorld_GetWorldSettings(IntPtr self, bool bCheckStreamingPersistent, bool bChecked);
		
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
		private static extern void E_UWorld_InitializeNewWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_InitWorld(IntPtr self);
		
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
		private static extern ObjectPointerDescription E_UWorld_K2_GetWorldSettings(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_LineTraceSingleByChannel(IntPtr self, IntPtr outHit, IntPtr start, IntPtr end, byte traceChannel, IntPtr @params, IntPtr responseParam);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_LineTraceSingleByObjectType(IntPtr self, IntPtr outHit, IntPtr start, IntPtr end, IntPtr objectQueryParams, IntPtr @params);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_LineTraceSingleByProfile(IntPtr self, IntPtr outHit, IntPtr start, IntPtr end, string profileName, IntPtr @params);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_LineTraceTestByChannel(IntPtr self, IntPtr start, IntPtr end, byte traceChannel, IntPtr @params, IntPtr responseParam);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_LineTraceTestByObjectType(IntPtr self, IntPtr start, IntPtr end, IntPtr objectQueryParams, IntPtr @params);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_LineTraceTestByProfile(IntPtr self, IntPtr start, IntPtr end, string profileName, IntPtr @params);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_Listen(IntPtr self, IntPtr inURL);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_LoadSecondaryLevels(IntPtr self, bool bForce);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(IntPtr self, IntPtr component, bool bForceGameThread);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_MarkObjectsPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_NavigateTo(IntPtr self, IntPtr inLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PerformGarbageCollectionAndCleanupActors(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PopulateStreamingLevelsToConsider(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_ProcessLevelStreamingVolumes(IntPtr self, IntPtr overrideViewLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_PropagateLightingScenarioChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RegisterAutoActivateCamera(IntPtr self, IntPtr cameraActor, int playerIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_RemapCompiledScriptActor(IntPtr self, string str);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RemoveActor(IntPtr self, IntPtr actor, bool bShouldModifyLevel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RemoveController(IntPtr self, IntPtr controller);
		
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
		private static extern void E_UWorld_RequestNewWorldOrigin(IntPtr self, IntPtr inNewOriginLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_RequiresHitProxies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_RunTickGroup(IntPtr self, byte group, bool bBlockTillComplete);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SeamlessTravel(IntPtr self, string inURL, bool bAbsolute);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SendAllEndOfFrameUpdates(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetActiveLevelCollection(IntPtr self, int levelCollectionIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_SetGameMode(IntPtr self, IntPtr inURL);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetGameState(IntPtr self, IntPtr newGameState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetMapNeedsLightingFullyRebuilt(IntPtr self, int inNumLightingUnbuiltObjects, int inNumUnbuiltReflectionCaptures);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UWorld_SetMaterialParameterCollectionInstanceNeedsUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UWorld_SetNewWorldOrigin(IntPtr self, IntPtr inNewOriginLocation);
		
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
		/// Time in seconds since level began play, but IS paused when the game is paused, and IS NOT dilated/clamped.
		/// </summary>
		public float AudioTimeSeconds
		{
			get => E_PROP_UWorld_AudioTimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_AudioTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether actors have been initialized for play
		/// </summary>
		public byte bActorsInitialized
		{
			get => E_PROP_UWorld_bActorsInitialized_GET(NativePointer);
			set => E_PROP_UWorld_bActorsInitialized_SET(NativePointer, value);
		}

		
		/// <summary>
		/// frame rate is well below DesiredFrameRate, so make LOD more aggressive
		/// </summary>
		public byte bAggressiveLOD
		{
			get => E_PROP_UWorld_bAggressiveLOD_GET(NativePointer);
			set => E_PROP_UWorld_bAggressiveLOD_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Indicates this scene always allows audio playback.
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
		/// Whether BeginPlay has been called on actors
		/// </summary>
		public byte bBegunPlay
		{
			get => E_PROP_UWorld_bBegunPlay_GET(NativePointer);
			set => E_PROP_UWorld_bBegunPlay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If TRUE, 'hidden' components will still create render proxy, so can draw info (see USceneComponent::ShouldRender)
		/// </summary>
		public byte bCreateRenderStateForHiddenComponents
		{
			get => E_PROP_UWorld_bCreateRenderStateForHiddenComponents_GET(NativePointer);
			set => E_PROP_UWorld_bCreateRenderStateForHiddenComponents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When set to true, all scene queries will be drawn
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
		/// True we want to execute a call to UpdateCulledTriggerVolumes during Tick
		/// </summary>
		public byte bDoDelayedUpdateCullDistanceVolumes
		{
			get => E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_GET(NativePointer);
			set => E_PROP_UWorld_bDoDelayedUpdateCullDistanceVolumes_SET(NativePointer, value);
		}

		
		/// <summary>
		/// frame rate is below DesiredFrameRate, so drop high detail actors
		/// </summary>
		public byte bDropDetail
		{
			get => E_PROP_UWorld_bDropDetail_GET(NativePointer);
			set => E_PROP_UWorld_bDropDetail_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we are in the middle of ticking actors/components or not
		/// </summary>
		public byte bInTick
		{
			get => E_PROP_UWorld_bInTick_GET(NativePointer);
			set => E_PROP_UWorld_bInTick_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we have already built the collision tree or not
		/// </summary>
		public byte bIsBuilt
		{
			get => E_PROP_UWorld_bIsBuilt_GET(NativePointer);
			set => E_PROP_UWorld_bIsBuilt_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When set, camera is potentially moveable even when paused
		/// </summary>
		public byte bIsCameraMoveableWhenPaused
		{
			get => E_PROP_UWorld_bIsCameraMoveableWhenPaused_GET(NativePointer);
			set => E_PROP_UWorld_bIsCameraMoveableWhenPaused_SET(NativePointer, value);
		}

		
		/// <summary>
		/// That map is default map or not
		/// </summary>
		public byte bIsDefaultLevel
		{
			get => E_PROP_UWorld_bIsDefaultLevel_GET(NativePointer);
			set => E_PROP_UWorld_bIsDefaultLevel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Is level streaming currently frozen?
		/// </summary>
		public byte bIsLevelStreamingFrozen
		{
			get => E_PROP_UWorld_bIsLevelStreamingFrozen_GET(NativePointer);
			set => E_PROP_UWorld_bIsLevelStreamingFrozen_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true this world is in the process of running the construction script for an actor
		/// </summary>
		public byte bIsRunningConstructionScript
		{
			get => E_PROP_UWorld_bIsRunningConstructionScript_GET(NativePointer);
			set => E_PROP_UWorld_bIsRunningConstructionScript_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Is the world being torn down
		/// </summary>
		public byte bIsTearingDown
		{
			get => E_PROP_UWorld_bIsTearingDown_GET(NativePointer);
			set => E_PROP_UWorld_bIsTearingDown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether world object has been initialized via Init()
		/// </summary>
		public byte bIsWorldInitialized
		{
			get => E_PROP_UWorld_bIsWorldInitialized_GET(NativePointer);
			set => E_PROP_UWorld_bIsWorldInitialized_SET(NativePointer, value);
		}

		
		/// <summary>
		/// This is a bool that indicates that one or more blueprints in the level (blueprint instances, level script, etc)
		/// <para>have compile errors that could not be automatically resolved. </para>
		/// </summary>
		public byte bKismetScriptError
		{
			get => E_PROP_UWorld_bKismetScriptError_GET(NativePointer);
			set => E_PROP_UWorld_bKismetScriptError_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether the match has been started
		/// </summary>
		public byte bMatchStarted
		{
			get => E_PROP_UWorld_bMatchStarted_GET(NativePointer);
			set => E_PROP_UWorld_bMatchStarted_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When ticking the world, only update players.
		/// </summary>
		public byte bPlayersOnly
		{
			get => E_PROP_UWorld_bPlayersOnly_GET(NativePointer);
			set => E_PROP_UWorld_bPlayersOnly_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Indicates that at the end the frame bPlayersOnly will be set to true.
		/// </summary>
		public byte bPlayersOnlyPending
		{
			get => E_PROP_UWorld_bPlayersOnlyPending_GET(NativePointer);
			set => E_PROP_UWorld_bPlayersOnlyPending_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Indicates that during world ticking we are doing the final component update of dirty components
		/// <para>(after PostAsyncWork and effect physics scene has run. </para>
		/// </summary>
		public byte bPostTickComponentUpdate
		{
			get => E_PROP_UWorld_bPostTickComponentUpdate_GET(NativePointer);
			set => E_PROP_UWorld_bPostTickComponentUpdate_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether it was requested that the engine bring up a loading screen and block on async loading.
		/// </summary>
		public byte bRequestedBlockOnAsyncLoading
		{
			get => E_PROP_UWorld_bRequestedBlockOnAsyncLoading_GET(NativePointer);
			set => E_PROP_UWorld_bRequestedBlockOnAsyncLoading_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true this world will tick physics to simulate. This isn't same as having Physics Scene.
		/// <para>You need Physics Scene if you'd like to trace. This flag changed ticking </para>
		/// </summary>
		public byte bShouldSimulatePhysics
		{
			get => E_PROP_UWorld_bShouldSimulatePhysics_GET(NativePointer);
			set => E_PROP_UWorld_bShouldSimulatePhysics_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Is the world in its actor initialization phase.
		/// </summary>
		public byte bStartup
		{
			get => E_PROP_UWorld_bStartup_GET(NativePointer);
			set => E_PROP_UWorld_bStartup_SET(NativePointer, value);
		}

		
		/// <summary>
		/// We are in the middle of actor ticking, so add tasks for newly spawned actors
		/// </summary>
		public byte bTickNewlySpawned
		{
			get => E_PROP_UWorld_bTickNewlySpawned_GET(NativePointer);
			set => E_PROP_UWorld_bTickNewlySpawned_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Triggers a call to PostLoadMap() the next Tick, turns off loading movie if LoadMap() has been called.
		/// </summary>
		public byte bTriggerPostLoadMap
		{
			get => E_PROP_UWorld_bTriggerPostLoadMap_GET(NativePointer);
			set => E_PROP_UWorld_bTriggerPostLoadMap_SET(NativePointer, value);
		}

		
		/// <summary>
		/// set for one tick after completely loading and initializing a new world
		/// <para>(regardless of whether it's LoadMap() or seamless travel) </para>
		/// </summary>
		public byte bWorldWasLoadedThisTick
		{
			get => E_PROP_UWorld_bWorldWasLoadedThisTick_GET(NativePointer);
			set => E_PROP_UWorld_bWorldWasLoadedThisTick_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Name of persistent level if we've loaded levels via CommitMapChange() that aren't normally in the StreamingLevels array (to inform newly joining clients)
		/// </summary>
		public string CommittedPersistentLevelName
		{
			get => E_PROP_UWorld_CommittedPersistentLevelName_GET(NativePointer);
			set => E_PROP_UWorld_CommittedPersistentLevelName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// When non-'None', all line traces where the TraceTag match this will be drawn
		/// </summary>
		public string DebugDrawTraceTag
		{
			get => E_PROP_UWorld_DebugDrawTraceTag_GET(NativePointer);
			set => E_PROP_UWorld_DebugDrawTraceTag_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Frame delta time in seconds adjusted by e.g. time dilation.
		/// </summary>
		public float DeltaTimeSeconds
		{
			get => E_PROP_UWorld_DeltaTimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_DeltaTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether we flushing level streaming state
		/// </summary>
		public EFlushLevelStreamingType FlushLevelStreamingType
		{
			get => (EFlushLevelStreamingType)E_PROP_UWorld_FlushLevelStreamingType_GET(NativePointer);
			set => E_PROP_UWorld_FlushLevelStreamingType_SET(NativePointer, (byte)value);
		}

		public ULineBatchComponent ForegroundLineBatcher
		{
			get => E_PROP_UWorld_ForegroundLineBatcher_GET(NativePointer);
			set => E_PROP_UWorld_ForegroundLineBatcher_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in FPlatformTime::Seconds unbuilt time was last encountered. 0 means not yet.
		/// </summary>
		public double LastTimeUnbuiltLightingWasEncountered
		{
			get => E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_GET(NativePointer);
			set => E_PROP_UWorld_LastTimeUnbuiltLightingWasEncountered_SET(NativePointer, value);
		}

		public ULineBatchComponent LineBatcher
		{
			get => E_PROP_UWorld_LineBatcher_GET(NativePointer);
			set => E_PROP_UWorld_LineBatcher_SET(NativePointer, value);
		}

		public AGameNetworkManager NetworkManager
		{
			get => E_PROP_UWorld_NetworkManager_GET(NativePointer);
			set => E_PROP_UWorld_NetworkManager_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Amount of time to wait before traveling to next map, gives clients time to receive final RPCs @see ServerTravelPause
		/// </summary>
		public float NextSwitchCountdown
		{
			get => E_PROP_UWorld_NextSwitchCountdown_GET(NativePointer);
			set => E_PROP_UWorld_NextSwitchCountdown_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The URL to be used for the upcoming server travel
		/// </summary>
		public string NextURL
		{
			get => E_PROP_UWorld_NextURL_GET(NativePointer);
			set => E_PROP_UWorld_NextURL_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Num of resources that have changed since the last texture streaming build. Updated in map check.
		/// </summary>
		public int NumTextureStreamingDirtyResources
		{
			get => E_PROP_UWorld_NumTextureStreamingDirtyResources_GET(NativePointer);
			set => E_PROP_UWorld_NumTextureStreamingDirtyResources_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Num of components missing valid texture streaming data. Updated in map check.
		/// </summary>
		public int NumTextureStreamingUnbuiltComponents
		{
			get => E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_GET(NativePointer);
			set => E_PROP_UWorld_NumTextureStreamingUnbuiltComponents_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current location of this world origin
		/// </summary>
		public FIntVector OriginLocation
		{
			get => E_PROP_UWorld_OriginLocation_GET(NativePointer);
			set => E_PROP_UWorld_OriginLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// World origin offset value. Non-zero only for a single frame when origin is rebased
		/// </summary>
		public FVector OriginOffsetThisFrame
		{
			get => E_PROP_UWorld_OriginOffsetThisFrame_GET(NativePointer);
			set => E_PROP_UWorld_OriginOffsetThisFrame_SET(NativePointer, value);
		}

		
		/// <summary>
		/// time at which to start pause
		/// </summary>
		public float PauseDelay
		{
			get => E_PROP_UWorld_PauseDelay_GET(NativePointer);
			set => E_PROP_UWorld_PauseDelay_SET(NativePointer, value);
		}

		public ULineBatchComponent PersistentLineBatcher
		{
			get => E_PROP_UWorld_PersistentLineBatcher_GET(NativePointer);
			set => E_PROP_UWorld_PersistentLineBatcher_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Counter for allocating game- unique controller player numbers
		/// </summary>
		public int PlayerNum
		{
			get => E_PROP_UWorld_PlayerNum_GET(NativePointer);
			set => E_PROP_UWorld_PlayerNum_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds since level began play, but IS NOT paused when the game is paused, and IS NOT dilated/clamped.
		/// </summary>
		public float RealTimeSeconds
		{
			get => E_PROP_UWorld_RealTimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_RealTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Requested new world origin location
		/// </summary>
		public FIntVector RequestedOriginLocation
		{
			get => E_PROP_UWorld_RequestedOriginLocation_GET(NativePointer);
			set => E_PROP_UWorld_RequestedOriginLocation_SET(NativePointer, value);
		}

		public string StreamingLevelsPrefix
		{
			get => E_PROP_UWorld_StreamingLevelsPrefix_GET(NativePointer);
			set => E_PROP_UWorld_StreamingLevelsPrefix_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Number of frames to delay Streaming Volume updating, useful if you preload a bunch of levels but the camera hasn't caught up yet (INDEX_NONE for infinite)
		/// </summary>
		public int StreamingVolumeUpdateDelay
		{
			get => E_PROP_UWorld_StreamingVolumeUpdateDelay_GET(NativePointer);
			set => E_PROP_UWorld_StreamingVolumeUpdateDelay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds since level began play, but IS paused when the game is paused, and IS dilated/clamped.
		/// </summary>
		public float TimeSeconds
		{
			get => E_PROP_UWorld_TimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_TimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds since level began play, but IS NOT paused when the game is paused, and IS dilated/clamped.
		/// </summary>
		public float UnpausedTimeSeconds
		{
			get => E_PROP_UWorld_UnpausedTimeSeconds_GET(NativePointer);
			set => E_PROP_UWorld_UnpausedTimeSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The URL that was used when loading this World.
		/// </summary>
		public FURL URL
		{
			get => E_PROP_UWorld_URL_GET(NativePointer);
			set => E_PROP_UWorld_URL_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Inserts the passed in controller at the front of the linked list of controllers.
		/// </summary>
		/// <param name="controller">Controller to insert, use NULL to clear list</param>
		public void AddController(AController controller)
			=> E_UWorld_AddController(this, controller);
		
		
		/// <summary>
		/// Adds the passed in actor to the special network actor list
		/// <para>This list is used to specifically single out actors that are relevant for networking without having to scan the much large list </para>
		/// </summary>
		/// <param name="actor">Actor to add</param>
		public void AddNetworkActor(AActor actor)
			=> E_UWorld_AddNetworkActor(this, actor);
		
		
		/// <summary>
		/// Inserts the passed in pawn at the front of the linked list of pawns.
		/// </summary>
		/// <param name="pawn">Pawn to insert, use NULL to clear list</param>
		public void AddPawn(APawn pawn)
			=> E_UWorld_AddPawn(this, pawn);
		
		
		/// <summary>
		/// Returns whether the level streaming code is allowed to issue load requests.
		/// </summary>
		/// <return>true</return>
		public bool AllowLevelLoadRequests()
			=> E_UWorld_AllowLevelLoadRequests(this);
		
		
		/// <summary>
		/// Returns true if the actors have been initialized and are ready to start play
		/// </summary>
		public bool AreActorsInitialized()
			=> E_UWorld_AreActorsInitialized(this);
		
		
		/// <summary>
		/// Returns whether all the 'always loaded' levels are loaded.
		/// </summary>
		public bool AreAlwaysLoadedLevelsLoaded()
			=> E_UWorld_AreAlwaysLoadedLevelsLoaded(this);
		
		
		/// <summary>
		/// Requests async loading of any 'always loaded' level. Used in seamless travel to prevent blocking in the first UpdateLevelStreaming.
		/// </summary>
		public void AsyncLoadAlwaysLoadedLevelsForSeamlessTravel()
			=> E_UWorld_AsyncLoadAlwaysLoadedLevelsForSeamlessTravel(this);
		
		
		/// <summary>
		/// Start gameplay. This will cause the game mode to transition to the correct state and call BeginPlay on all actors
		/// </summary>
		public void BeginPlay()
			=> E_UWorld_BeginPlay(this);
		
		
		/// <summary>
		/// Broadcasts that the number of levels has changed.
		/// </summary>
		public void BroadcastLevelsChanged()
			=> E_UWorld_BroadcastLevelsChanged(this);
		
		
		/// <summary>
		/// Return the prefix for PIE packages given a PIE Instance ID
		/// </summary>
		public string BuildPIEPackagePrefix(int pIEInstanceID)
			=> E_UWorld_BuildPIEPackagePrefix(this, pIEInstanceID);
		
		
		/// <summary>
		/// cancels pending map change (@note: we can't cancel pending async loads, so this won't immediately free the memory)
		/// </summary>
		public void CancelPendingMapChange()
			=> E_UWorld_CancelPendingMapChange(this);
		
		
		/// <summary>
		/// Remove NULL entries from actor list. Only does so for dynamic actors to avoid resorting.
		/// <para>In theory static actors shouldn't be deleted during gameplay. </para>
		/// </summary>
		public void CleanupActors()
			=> E_UWorld_CleanupActors(this);
		
		
		/// <summary>
		/// Cleans up components, streaming data and assorted other intermediate data.
		/// </summary>
		/// <param name="bSessionEnded">whether to notify the viewport that the game session has ended</param>
		/// <param name="newWorld">Optional new world that will be loaded after this world is cleaned up. Specify a new world to prevent it and it's sublevels from being GCed during map transitions.</param>
		public void CleanupWorld(bool bSessionEnded = true, bool bCleanupResources = true, UWorld newWorld = null)
			=> E_UWorld_CleanupWorld(this, bSessionEnded, bCleanupResources, newWorld);
		
		
		/// <summary>
		/// Clears the need for a component to have a end of frame update
		/// </summary>
		/// <param name="component">Component to update at the end of the frame</param>
		public void ClearActorComponentEndOfFrameUpdate(UActorComponent component)
			=> E_UWorld_ClearActorComponentEndOfFrameUpdate(this, component);
		
		
		/// <summary>
		/// Reset the streaming levels array
		/// </summary>
		public void ClearStreamingLevels()
			=> E_UWorld_ClearStreamingLevels(this);
		
		
		/// <summary>
		/// Clears all level components and world components like e.g. line batcher.
		/// </summary>
		public void ClearWorldComponents()
			=> E_UWorld_ClearWorldComponents(this);
		
		
		/// <summary>
		/// actually performs the map transition prepared by PrepareMapChange()
		/// <para>it happens in the next tick to avoid GC issues </para>
		/// if a map change is being prepared but isn't ready yet, the transition code will block until it is
		/// <para>wait until IsMapChangeReady() returns true if this is undesired behavior </para>
		/// </summary>
		public void CommitMapChange()
			=> E_UWorld_CommitMapChange(this);
		
		
		/// <summary>
		/// Commits changes made to the surfaces of the UModels of all levels.
		/// </summary>
		public void CommitModelSurfaces()
			=> E_UWorld_CommitModelSurfaces(this);
		
		
		/// <summary>
		/// Calls ULevel::BuildStreamingData(this,NULL,NULL) if it has been triggered within the last few seconds.
		/// </summary>
		public void ConditionallyBuildStreamingData()
			=> E_UWorld_ConditionallyBuildStreamingData(this);
		
		
		/// <summary>
		/// Returns whether the passed in actor is part of any of the loaded levels actors array.
		/// <para>Warning: Will return true for pending kill actors! </para>
		/// </summary>
		/// <param name="actor">Actor to check whether it is contained by any level</param>
		/// <return>true</return>
		public bool ContainsActor(AActor actor)
			=> E_UWorld_ContainsActor(this, actor);
		
		
		/// <summary>
		/// Given a PackageName and a PIE Instance ID return the name of that Package when being run as a PIE world
		/// </summary>
		public string ConvertToPIEPackageName(string packageName, int pIEInstanceID)
			=> E_UWorld_ConvertToPIEPackageName(this, packageName, pIEInstanceID);
		
		
		/// <summary>
		/// Copies GameState properties from the GameMode.
		/// </summary>
		public void CopyGameState(AGameModeBase fromGameMode, AGameStateBase fromGameState)
			=> E_UWorld_CopyGameState(this, fromGameMode, fromGameState);
		
		
		/// <summary>
		/// Creates a new FX system for this world
		/// </summary>
		public void CreateFXSystem()
			=> E_UWorld_CreateFXSystem(this);
		
		
		/// <summary>
		/// Creates a new physics scene for this world.
		/// </summary>
		public void CreatePhysicsScene(AWorldSettings settings = null)
			=> E_UWorld_CreatePhysicsScene(this, settings);
		
		public bool DebugDrawSceneQueries(string usedTraceTag)
			=> E_UWorld_DebugDrawSceneQueries(this, usedTraceTag);
		
		
		/// <summary>
		/// Requests a one frame delay of Garbage Collection
		/// </summary>
		public void DelayGarbageCollection()
			=> E_UWorld_DelayGarbageCollection(this);
		
		
		/// <summary>
		/// Sets the number of frames to delay Streaming Volume updating,
		/// <para>useful if you preload a bunch of levels but the camera hasn't caught up yet </para>
		/// </summary>
		public void DelayStreamingVolumeUpdates(int inFrameDelay)
			=> E_UWorld_DelayStreamingVolumeUpdates(this, inFrameDelay);
		
		
		/// <summary>
		/// Removes the actor from its level's actor list and generally cleans up the engine's internal state.
		/// <para>What this function does not do, but is handled via garbage collection instead, is remove references </para>
		/// to this actor from all other actors, and kill the actor's resources.  This function is set up so that
		/// <para>no problems occur even if the actor is being destroyed inside its recursion stack. </para>
		/// </summary>
		/// <param name="thisActor">Actor to remove.</param>
		/// <param name="bNetForce">opt] Ignored unless called during play.  Default is false.</param>
		/// <param name="bShouldModifyLevel">opt] If true, Modify() the level before removing the actor.  Default is true.</param>
		/// <return>true</return>
		public bool DestroyActor(AActor actor, bool bNetForce = false, bool bShouldModifyLevel = true)
			=> E_UWorld_DestroyActor(this, actor, bNetForce, bShouldModifyLevel);
		
		
		/// <summary>
		/// Utility function to handle Exec/Console Command for setting the speed of a replay
		/// </summary>
		public void DestroyDemoNetDriver()
			=> E_UWorld_DestroyDemoNetDriver(this);
		
		
		/// <summary>
		/// Destroy this World instance. If destroying the world to load a different world, supply it here to prevent GC of the new world or it's sublevels.
		/// </summary>
		public void DestroyWorld(bool bInformEngineOfWorld, UWorld newWorld = null)
			=> E_UWorld_DestroyWorld(this, bInformEngineOfWorld, newWorld);
		
		
		/// <summary>
		/// Creates a new level collection of type DynamicDuplicatedLevels by duplicating the levels in DynamicSourceLevels.
		/// <para>Should only be called by engine. </para>
		/// </summary>
		/// <param name="mapName">The name of the soure map, used as a parameter to UEngine::Experimental_ShouldPreDuplicateMap</param>
		public void DuplicateRequestedLevels(string mapName)
			=> E_UWorld_DuplicateRequestedLevels(this, mapName);
		
		
		/// <summary>
		/// Given a loaded editor UWorld, duplicate it for play in editor purposes with OwningWorld as the world with the persistent level.
		/// </summary>
		public UWorld DuplicateWorldForPIE(string packageName, UWorld owningWorld)
			=> E_UWorld_DuplicateWorldForPIE(this, packageName, owningWorld);
		
		
		/// <summary>
		/// Wrapper for DestroyActor() that should be called in the editor.
		/// </summary>
		/// <param name="bShouldModifyLevel">If true, Modify() the level before removing the actor.</param>
		public bool EditorDestroyActor(AActor actor, bool bShouldModifyLevel)
			=> E_UWorld_EditorDestroyActor(this, actor, bShouldModifyLevel);
		
		
		/// <summary>
		/// @Return true if Actor would encroach at TestLocation on something that blocks it.  Returns a ProposedAdjustment that might result in an unblocked TestLocation.
		/// </summary>
		public bool EncroachingBlockingGeometry(AActor testActor, FVector testLocation, FRotator testRotation, FVector proposedAdjustment = null)
			=> E_UWorld_EncroachingBlockingGeometry(this, testActor, testLocation, testRotation, proposedAdjustment);
		
		
		/// <summary>
		/// Ensures that the collision detection tree is fully built. This should be called after the full level reload to make sure
		/// <para>the first traces are not abysmally slow. </para>
		/// </summary>
		public void EnsureCollisionTreeIsBuilt()
			=> E_UWorld_EnsureCollisionTreeIsBuilt(this);
		
		
		/// <summary>
		/// Try to find an acceptable non-colliding location to place TestActor as close to possible to PlaceLocation. Expects PlaceLocation to be a valid location inside the level.
		/// <para>Returns true if a location without blocking collision is found, in which case PlaceLocation is overwritten with the new clear location. </para>
		/// Returns false if no suitable location could be found, in which case PlaceLocation is unmodified.
		/// </summary>
		public bool FindTeleportSpot(AActor testActor, FVector placeLocation, FRotator placeRotation)
			=> E_UWorld_FindTeleportSpot(this, testActor, placeLocation, placeRotation);
		
		
		/// <summary>
		/// Waits for the physics scene to be done processing
		/// </summary>
		public void FinishPhysicsSim()
			=> E_UWorld_FinishPhysicsSim(this);
		
		
		/// <summary>
		/// Flushes level streaming in blocking fashion and returns when all levels are loaded/ visible/ hidden
		/// <para>so further calls to UpdateLevelStreaming won't do any work unless state changes. Basically blocks </para>
		/// on all async operation like updating components.
		/// </summary>
		/// <param name="flushType">Whether to only flush level visibility operations (optional)</param>
		public void FlushLevelStreaming(EFlushLevelStreamingType flushType)
			=> E_UWorld_FlushLevelStreaming(this, (byte)flushType);
		
		
		/// <summary>
		/// Updates the timer between garbage collection such that at the next opportunity garbage collection will be run.
		/// </summary>
		public void ForceGarbageCollection(bool bFullPurge = false)
			=> E_UWorld_ForceGarbageCollection(this, bFullPurge);
		
		
		/// <summary>
		/// Returns the index of the level collection which currently has its context set on this world. May be INDEX_NONE.
		/// <para>If not INDEX_NONE, this implies that execution is currently within the scope of an FScopedLevelCollectionContextSwitch for this world. </para>
		/// </summary>
		public int GetActiveLevelCollectionIndex()
			=> E_UWorld_GetActiveLevelCollectionIndex(this);
		
		
		/// <summary>
		/// Returns the actor count.
		/// </summary>
		public int GetActorCount()
			=> E_UWorld_GetActorCount(this);
		
		
		/// <summary>
		/// Returns time in seconds since world was brought up for play, IS stopped when game pauses, NOT dilated/clamped
		/// </summary>
		/// <return>time</return>
		public float GetAudioTimeSeconds()
			=> E_UWorld_GetAudioTimeSeconds(this);
		
		
		/// <summary>
		/// Returns the current Game Mode instance, which is always valid during gameplay on the server.
		/// <para>This will only return a valid pointer on the server. Will always return null on a client. </para>
		/// </summary>
		public AGameModeBase GetAuthGameMode()
			=> E_UWorld_GetAuthGameMode(this);
		
		public UCanvas GetCanvasForDrawMaterialToRenderTarget()
			=> E_UWorld_GetCanvasForDrawMaterialToRenderTarget(this);
		
		
		/// <summary>
		/// Gets the canvas object for rendering to a render target.  Will allocate one if needed.
		/// </summary>
		public UCanvas GetCanvasForRenderingToTarget()
			=> E_UWorld_GetCanvasForRenderingToTarget(this);
		
		
		/// <summary>
		/// Returns the Z component of the default world gravity.
		/// </summary>
		/// <return>Z</return>
		public float GetDefaultGravityZ()
			=> E_UWorld_GetDefaultGravityZ(this);
		
		
		/// <summary>
		/// Returns the frame delta time in seconds adjusted by e.g. time dilation.
		/// </summary>
		/// <return>frame</return>
		public float GetDeltaSeconds()
			=> E_UWorld_GetDeltaSeconds(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>the</return>
		public int GetDetailMode()
			=> E_UWorld_GetDetailMode(this);
		
		public ULocalPlayer GetFirstLocalPlayerFromController()
			=> E_UWorld_GetFirstLocalPlayerFromController(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>Returns</return>
		public APlayerController GetFirstPlayerController()
			=> E_UWorld_GetFirstPlayerController(this);
		
		
		/// <summary>
		/// Returns the current GameState instance.
		/// </summary>
		public AGameStateBase GetGameState()
			=> E_UWorld_GetGameState(this);
		
		
		/// <summary>
		/// Returns a reference to the game viewport displaying this world if one exists.
		/// </summary>
		public UGameViewportClient GetGameViewport()
			=> E_UWorld_GetGameViewport(this);
		
		
		/// <summary>
		/// Returns the Z component of the current world gravity.
		/// </summary>
		/// <return>Z</return>
		public float GetGravityZ()
			=> E_UWorld_GetGravityZ(this);
		
		
		/// <summary>
		/// Returns the name of the current map, taking into account using a dummy persistent world
		/// <para>and loading levels into it via PrepareMapChange. </para>
		/// </summary>
		/// <return>name</return>
		public string GetMapName()
			=> E_UWorld_GetMapName(this);
		
		
		/// <summary>
		/// Returns the net mode this world is running under.
		/// <see cref="IsNetMode"/>
		/// </summary>
		public ENetMode GetNetMode()
			=> (ENetMode)E_UWorld_GetNetMode(this);
		
		
		/// <summary>
		/// Get the count of all PhysicsVolumes in the world that are not a DefaultPhysicsVolume.
		/// </summary>
		public int GetNonDefaultPhysicsVolumeCount()
			=> E_UWorld_GetNonDefaultPhysicsVolumeCount(this);
		
		
		/// <summary>
		/// Return the number of levels in this world.
		/// </summary>
		public int GetNumLevels()
			=> E_UWorld_GetNumLevels(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>Returns</return>
		public int GetNumPawns()
			=> E_UWorld_GetNumPawns(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>Returns</return>
		public int GetNumPlayerControllers()
			=> E_UWorld_GetNumPlayerControllers(this);
		
		
		/// <summary>
		/// Returns the actor count.
		/// </summary>
		public int GetProgressDenominator()
			=> E_UWorld_GetProgressDenominator(this);
		
		
		/// <summary>
		/// Returns time in seconds since world was brought up for play, does NOT stop when game pauses, NOT dilated/clamped
		/// </summary>
		/// <return>time</return>
		public float GetRealTimeSeconds()
			=> E_UWorld_GetRealTimeSeconds(this);
		
		public bool GetShouldForceUnloadStreamingLevels()
			=> E_UWorld_GetShouldForceUnloadStreamingLevels(this);
		
		public bool GetShouldForceVisibleStreamingLevels()
			=> E_UWorld_GetShouldForceVisibleStreamingLevels(this);
		
		
		/// <summary>
		/// Returns the current desired time between garbage collection passes (not the time remaining)
		/// </summary>
		public float GetTimeBetweenGarbageCollectionPasses()
			=> E_UWorld_GetTimeBetweenGarbageCollectionPasses(this);
		
		
		/// <summary>
		/// Returns time in seconds since world was brought up for play, IS stopped when game pauses, IS dilated/clamped
		/// </summary>
		/// <return>time</return>
		public float GetTimeSeconds()
			=> E_UWorld_GetTimeSeconds(this);
		
		
		/// <summary>
		/// Returns time in seconds since world was brought up for play, IS NOT stopped when game pauses, IS dilated/clamped
		/// </summary>
		/// <return>time</return>
		public float GetUnpausedTimeSeconds()
			=> E_UWorld_GetUnpausedTimeSeconds(this);
		
		public AWorldSettings GetWorldSettings(bool bCheckStreamingPersistent = false, bool bChecked = true)
			=> E_UWorld_GetWorldSettings(this, bCheckStreamingPersistent, bChecked);
		
		public void HandleTimelineScrubbed()
			=> E_UWorld_HandleTimelineScrubbed(this);
		
		
		/// <summary>
		/// Returns true if gameplay has already started, false otherwise.
		/// </summary>
		public bool HasBegunPlay()
			=> E_UWorld_HasBegunPlay(this);
		
		
		/// <summary>
		/// Returns true if a DefaultPhysicsVolume has been created.
		/// </summary>
		public bool HasDefaultPhysicsVolume()
			=> E_UWorld_HasDefaultPhysicsVolume(this);
		
		
		/// <summary>
		/// Returns true if we have any updates that have been deferred to the end of the current frame.
		/// </summary>
		public bool HasEndOfFrameUpdates()
			=> E_UWorld_HasEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// Indicates that the world has marked contained objects as pending kill
		/// </summary>
		public bool HasMarkedObjectsPendingKill()
			=> E_UWorld_HasMarkedObjectsPendingKill(this);
		
		
		/// <summary>
		/// Initializes all actors and prepares them to start gameplay
		/// </summary>
		/// <param name="inURL">commandline URL</param>
		/// <param name="bResetTime">optional) whether the WorldSettings's TimeSeconds should be reset to zero</param>
		public void InitializeActorsForPlay(FURL inURL, bool bResetTime = true)
			=> E_UWorld_InitializeActorsForPlay(this, inURL, bResetTime);
		
		
		/// <summary>
		/// Initializes a newly created world.
		/// </summary>
		public void InitializeNewWorld()
			=> E_UWorld_InitializeNewWorld(this);
		
		
		/// <summary>
		/// Initializes the world, associates the persistent level and sets the proper zones.
		/// </summary>
		public void InitWorld()
			=> E_UWorld_InitWorld(this);
		
		
		/// <summary>
		/// Discards the cached data used to render the levels' UModel.  Assumes that the
		/// <para>faces and vertex positions haven't changed, only the applied materials. </para>
		/// </summary>
		/// <param name="bCurrentLevelOnly">If true, affect only the current level.</param>
		public void InvalidateModelSurface(bool bCurrentLevelOnly)
			=> E_UWorld_InvalidateModelSurface(this, bCurrentLevelOnly);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsCameraMoveable()
			=> E_UWorld_IsCameraMoveable(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsClient()
			=> E_UWorld_IsClient(this);
		
		
		/// <summary>
		/// Returns true if this world is any kind of editor world (including editor preview worlds)
		/// </summary>
		public bool IsEditorWorld()
			=> E_UWorld_IsEditorWorld(this);
		
		
		/// <summary>
		/// Returns true if this world is any kind of game world (including PIE worlds)
		/// </summary>
		public bool IsGameWorld()
			=> E_UWorld_IsGameWorld(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>whether</return>
		public bool IsInSeamlessTravel()
			=> E_UWorld_IsInSeamlessTravel(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsMapChangeReady()
			=> E_UWorld_IsMapChangeReady(this);
		
		
		/// <summary>
		/// Retrieves information whether all navigation with this world has been rebuilt
		/// </summary>
		public bool IsNavigationRebuilt()
			=> E_UWorld_IsNavigationRebuilt(this);
		
		
		/// <summary>
		/// Test whether net mode is the given mode.
		/// <para>In optimized non-editor builds this can be more efficient than GetNetMode() </para>
		/// because it can check the static build flags without considering PIE.
		/// </summary>
		public bool IsNetMode(ENetMode mode)
			=> E_UWorld_IsNetMode(this, (byte)mode);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsPaused()
			=> E_UWorld_IsPaused(this);
		
		
		/// <summary>
		/// Returns whether script is executing within the editor.
		/// </summary>
		public bool IsPlayInEditor()
			=> E_UWorld_IsPlayInEditor(this);
		
		
		/// <summary>
		/// Returns true if the demo net driver exists and is playing a client recorded replay.
		/// </summary>
		public bool IsPlayingClientReplay()
			=> E_UWorld_IsPlayingClientReplay(this);
		
		
		/// <summary>
		/// Returns true if we are currently playing a replay
		/// </summary>
		public bool IsPlayingReplay()
			=> E_UWorld_IsPlayingReplay(this);
		
		
		/// <summary>
		/// Returns whether script is executing within a mobile preview window
		/// </summary>
		public bool IsPlayInMobilePreview()
			=> E_UWorld_IsPlayInMobilePreview(this);
		
		
		/// <summary>
		/// Returns whether script is executing within a preview window
		/// </summary>
		public bool IsPlayInPreview()
			=> E_UWorld_IsPlayInPreview(this);
		
		
		/// <summary>
		/// Returns whether script is executing within a vulkan preview window
		/// </summary>
		public bool IsPlayInVulkanPreview()
			=> E_UWorld_IsPlayInVulkanPreview(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsPreparingMapChange()
			=> E_UWorld_IsPreparingMapChange(this);
		
		
		/// <summary>
		/// Returns true if this world is a preview game world (editor or game)
		/// </summary>
		public bool IsPreviewWorld()
			=> E_UWorld_IsPreviewWorld(this);
		
		
		/// <summary>
		/// Returns true if the game net driver exists and is a client and the demo net driver exists and is a server.
		/// </summary>
		public bool IsRecordingClientReplay()
			=> E_UWorld_IsRecordingClientReplay(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsServer()
			=> E_UWorld_IsServer(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>whether</return>
		public bool IsVisibilityRequestPending()
			=> E_UWorld_IsVisibilityRequestPending(this);
		
		
		/// <summary>
		/// Returns the AWorldSettings actor associated with this world.
		/// </summary>
		/// <return>AWorldSettings</return>
		public AWorldSettings K2_GetWorldSettings()
			=> E_UWorld_K2_GetWorldSettings(this);
		
		
		/// <summary>
		/// Trace a ray against the world using a specific channel and return the first blocking hit
		/// </summary>
		/// <param name="outHit">First blocking hit found</param>
		/// <param name="start">Start location of the ray</param>
		/// <param name="end">End location of the ray</param>
		/// <param name="traceChannel">The 'channel' that this ray is in, used to determine which components to hit</param>
		/// <param name="@params">Additional parameters used for the trace</param>
		/// <param name="responseParam">ResponseContainer to be used for this trace</param>
		/// <return>TRUE</return>
		public bool LineTraceSingleByChannel(FHitResult outHit, FVector start, FVector end, ECollisionChannel traceChannel, FCollisionQueryParams @params, FCollisionResponseParams responseParam)
			=> E_UWorld_LineTraceSingleByChannel(this, outHit, start, end, (byte)traceChannel, @params, responseParam);
		
		
		/// <summary>
		/// Trace a ray against the world using object types and return the first blocking hit
		/// </summary>
		/// <param name="outHit">First blocking hit found</param>
		/// <param name="start">Start location of the ray</param>
		/// <param name="end">End location of the ray</param>
		/// <param name="objectQueryParams">List of object types it's looking for</param>
		/// <param name="@params">Additional parameters used for the trace</param>
		/// <return>TRUE</return>
		public bool LineTraceSingleByObjectType(FHitResult outHit, FVector start, FVector end, FCollisionObjectQueryParams objectQueryParams, FCollisionQueryParams @params)
			=> E_UWorld_LineTraceSingleByObjectType(this, outHit, start, end, objectQueryParams, @params);
		
		
		/// <summary>
		/// Trace a ray against the world using a specific profile and return the first blocking hit
		/// </summary>
		/// <param name="outHit">First blocking hit found</param>
		/// <param name="start">Start location of the ray</param>
		/// <param name="end">End location of the ray</param>
		/// <param name="profileName">The 'profile' used to determine which components to hit</param>
		/// <param name="@params">Additional parameters used for the trace</param>
		/// <return>TRUE</return>
		public bool LineTraceSingleByProfile(FHitResult outHit, FVector start, FVector end, string profileName, FCollisionQueryParams @params)
			=> E_UWorld_LineTraceSingleByProfile(this, outHit, start, end, profileName, @params);
		
		
		/// <summary>
		/// Trace a ray against the world using a specific channel and return if a blocking hit is found.
		/// </summary>
		/// <param name="start">Start location of the ray</param>
		/// <param name="end">End location of the ray</param>
		/// <param name="traceChannel">The 'channel' that this ray is in, used to determine which components to hit</param>
		/// <param name="@params">Additional parameters used for the trace</param>
		/// <param name="responseParam">ResponseContainer to be used for this trace</param>
		/// <return>TRUE</return>
		public bool LineTraceTestByChannel(FVector start, FVector end, ECollisionChannel traceChannel, FCollisionQueryParams @params, FCollisionResponseParams responseParam)
			=> E_UWorld_LineTraceTestByChannel(this, start, end, (byte)traceChannel, @params, responseParam);
		
		
		/// <summary>
		/// Trace a ray against the world using object types and return if a blocking hit is found.
		/// </summary>
		/// <param name="start">Start location of the ray</param>
		/// <param name="end">End location of the ray</param>
		/// <param name="objectQueryParams">List of object types it's looking for</param>
		/// <param name="@params">Additional parameters used for the trace</param>
		/// <return>TRUE</return>
		public bool LineTraceTestByObjectType(FVector start, FVector end, FCollisionObjectQueryParams objectQueryParams, FCollisionQueryParams @params)
			=> E_UWorld_LineTraceTestByObjectType(this, start, end, objectQueryParams, @params);
		
		
		/// <summary>
		/// Trace a ray against the world using a specific profile and return if a blocking hit is found.
		/// </summary>
		/// <param name="start">Start location of the ray</param>
		/// <param name="end">End location of the ray</param>
		/// <param name="profileName">The 'profile' used to determine which components to hit</param>
		/// <param name="@params">Additional parameters used for the trace</param>
		/// <return>TRUE</return>
		public bool LineTraceTestByProfile(FVector start, FVector end, string profileName, FCollisionQueryParams @params)
			=> E_UWorld_LineTraceTestByProfile(this, start, end, profileName, @params);
		
		public bool Listen(FURL inURL)
			=> E_UWorld_Listen(this, inURL);
		
		
		/// <summary>
		/// Called after GWorld has been set. Used to load, but not associate, all
		/// <para>levels in the world in the Editor and at least create linkers in the game. </para>
		/// Should only be called against GWorld::PersistentLevel's WorldSettings.
		/// </summary>
		/// <param name="bForce">If true, load the levels even is a commandlet</param>
		public void LoadSecondaryLevels(bool bForce = false)
			=> E_UWorld_LoadSecondaryLevels(this, bForce);
		
		
		/// <summary>
		/// Mark a component as needing an end of frame update
		/// </summary>
		/// <param name="component">Component to update at the end of the frame</param>
		/// <param name="bForceGameThread">if true, force this to happen on the game thread</param>
		public void MarkActorComponentForNeededEndOfFrameUpdate(UActorComponent component, bool bForceGameThread)
			=> E_UWorld_MarkActorComponentForNeededEndOfFrameUpdate(this, component, bForceGameThread);
		
		
		/// <summary>
		/// Marks this world and all objects within as pending kill
		/// </summary>
		public void MarkObjectsPendingKill()
			=> E_UWorld_MarkObjectsPendingKill(this);
		
		
		/// <summary>
		/// Sets world origin at specified position and stream-in all relevant levels
		/// </summary>
		public void NavigateTo(FIntVector inLocation)
			=> E_UWorld_NavigateTo(this, inLocation);
		
		
		/// <summary>
		/// Interface to allow WorldSettings to request immediate garbage collection
		/// </summary>
		public void PerformGarbageCollectionAndCleanupActors()
			=> E_UWorld_PerformGarbageCollectionAndCleanupActors(this);
		
		
		/// <summary>
		/// Examine all streaming levels and determine which ones should be considered.
		/// </summary>
		public void PopulateStreamingLevelsToConsider()
			=> E_UWorld_PopulateStreamingLevelsToConsider(this);
		
		
		/// <summary>
		/// Issues level streaming load/unload requests based on whether
		/// <para>local players are inside/outside level streaming volumes. </para>
		/// </summary>
		/// <param name="overrideViewLocation">Optional position used to override the location used to calculate current streaming volumes</param>
		public void ProcessLevelStreamingVolumes(FVector overrideViewLocation = null)
			=> E_UWorld_ProcessLevelStreamingVolumes(this, overrideViewLocation);
		
		
		/// <summary>
		/// Propagates a change to the active lighting scenario.
		/// </summary>
		public void PropagateLightingScenarioChange()
			=> E_UWorld_PropagateLightingScenarioChange(this);
		
		
		/// <summary>
		/// Register a CameraActor that auto-activates for a PlayerController.
		/// </summary>
		public void RegisterAutoActivateCamera(ACameraActor cameraActor, int playerIndex)
			=> E_UWorld_RegisterAutoActivateCamera(this, cameraActor, playerIndex);
		
		
		/// <summary>
		/// Given a level script actor, modify the string such that it points to the correct instance of the object. For replays.
		/// </summary>
		public bool RemapCompiledScriptActor(string str)
			=> E_UWorld_RemapCompiledScriptActor(this, str);
		
		
		/// <summary>
		/// Removes the passed in actor from the actor lists. Please note that the code actually doesn't physically remove the
		/// <para>index but rather clears it so other indices are still valid and the actors array size doesn't change. </para>
		/// </summary>
		/// <param name="actor">Actor to remove.</param>
		/// <param name="bShouldModifyLevel">If true, Modify() the level before removing the actor if in the editor.</param>
		public void RemoveActor(AActor actor, bool bShouldModifyLevel)
			=> E_UWorld_RemoveActor(this, actor, bShouldModifyLevel);
		
		
		/// <summary>
		/// Removes the passed in controller from the linked list of controllers.
		/// </summary>
		/// <param name="controller">Controller to remove</param>
		public void RemoveController(AController controller)
			=> E_UWorld_RemoveController(this, controller);
		
		
		/// <summary>
		/// Removes the passed in actor to from special network actor list
		/// </summary>
		/// <param name="actor">Actor to remove</param>
		public void RemoveNetworkActor(AActor actor)
			=> E_UWorld_RemoveNetworkActor(this, actor);
		
		
		/// <summary>
		/// Removes the passed in pawn from the linked list of pawns.
		/// </summary>
		/// <param name="pawn">Pawn to remove</param>
		public void RemovePawn(APawn pawn)
			=> E_UWorld_RemovePawn(this, pawn);
		
		
		/// <summary>
		/// Given a string, return that string with any PIE prefix removed
		/// </summary>
		public string RemovePIEPrefix(string source)
			=> E_UWorld_RemovePIEPrefix(this, source);
		
		
		/// <summary>
		/// Remove a streaming level to the list of streamed levels to consider.
		/// <para>Returns true if the specified index was a valid index for removal. </para>
		/// </summary>
		public bool RemoveStreamingLevelAt(int indexToRemove)
			=> E_UWorld_RemoveStreamingLevelAt(this, indexToRemove);
		
		
		/// <summary>
		/// Rename this world such that it has the prefix on names for the given PIE Instance ID
		/// </summary>
		public void RenameToPIEWorld(int pIEInstanceID)
			=> E_UWorld_RenameToPIEWorld(this, pIEInstanceID);
		
		
		/// <summary>
		/// Request to translate world origin to specified position on next tick
		/// </summary>
		public void RequestNewWorldOrigin(FIntVector inNewOriginLocation)
			=> E_UWorld_RequestNewWorldOrigin(this, inNewOriginLocation);
		
		
		/// <summary>
		/// Accessor for bRequiresHitProxies.
		/// </summary>
		public bool RequiresHitProxies()
			=> E_UWorld_RequiresHitProxies(this);
		
		
		/// <summary>
		/// Run a tick group, ticking all actors and components
		/// </summary>
		/// <param name="group">Ticking group to run</param>
		/// <param name="bBlockTillComplete">if true, do not return until all ticks are complete</param>
		public void RunTickGroup(ETickingGroup group, bool bBlockTillComplete)
			=> E_UWorld_RunTickGroup(this, (byte)group, bBlockTillComplete);
		
		
		/// <summary>
		/// seamlessly travels to the given URL by first loading the entry level in the background,
		/// <para>switching to it, and then loading the specified level. Does not disrupt network communication or disconnect clients. </para>
		/// You may need to implement GameModeBase::GetSeamlessTravelActorList(), PlayerController::GetSeamlessTravelActorList(),
		/// <para>GameModeBase::PostSeamlessTravel(), and/or GameModeBase::HandleSeamlessTravelPlayer() to handle preserving any information </para>
		/// that should be maintained (player teams, etc)
		/// <para>This codepath is designed for worlds that use little or no level streaming and GameModes where the game state </para>
		/// is reset/reloaded when transitioning. (like UT)
		/// <para>so it is only needed for clients </para>
		/// </summary>
		/// <param name="uRL">the URL to travel to; must be on the same server as the current URL</param>
		/// <param name="bAbsolute">opt) - if true, URL is absolute, otherwise relative</param>
		/// <param name="mapPackageGuid">opt) - the GUID of the map package to travel to - this is used to find the file when it has been auto-downloaded,</param>
		public void SeamlessTravel(string inURL, bool bAbsolute = false)
			=> E_UWorld_SeamlessTravel(this, inURL, bAbsolute);
		
		
		/// <summary>
		/// Send all render updates to the rendering thread.
		/// </summary>
		public void SendAllEndOfFrameUpdates()
			=> E_UWorld_SendAllEndOfFrameUpdates(this);
		
		
		/// <summary>
		/// Sets the level collection and its context on this world. Should only be called by FScopedLevelCollectionContextSwitch.
		/// </summary>
		public void SetActiveLevelCollection(int levelCollectionIndex)
			=> E_UWorld_SetActiveLevelCollection(this, levelCollectionIndex);
		
		
		/// <summary>
		/// Spawns GameMode for the level.
		/// </summary>
		public bool SetGameMode(FURL inURL)
			=> E_UWorld_SetGameMode(this, inURL);
		
		
		/// <summary>
		/// Sets the current GameState instance on this world and the game state's level collection.
		/// </summary>
		public void SetGameState(AGameStateBase newGameState)
			=> E_UWorld_SetGameState(this, newGameState);
		
		
		/// <summary>
		/// Sets NumLightingUnbuiltObjects to the specified value.  Marks the worldsettings package dirty if the value changed.
		/// </summary>
		/// <param name="inNumLightingUnbuiltObjects">The new value.</param>
		public void SetMapNeedsLightingFullyRebuilt(int inNumLightingUnbuiltObjects, int inNumUnbuiltReflectionCaptures)
			=> E_UWorld_SetMapNeedsLightingFullyRebuilt(this, inNumLightingUnbuiltObjects, inNumUnbuiltReflectionCaptures);
		
		
		/// <summary>
		/// Used to indicate a UMaterialParameterCollectionInstance needs a deferred update
		/// </summary>
		public void SetMaterialParameterCollectionInstanceNeedsUpdate()
			=> E_UWorld_SetMaterialParameterCollectionInstanceNeedsUpdate(this);
		
		
		/// <summary>
		/// Translate world origin to specified position
		/// </summary>
		public bool SetNewWorldOrigin(FIntVector inNewOriginLocation)
			=> E_UWorld_SetNewWorldOrigin(this, inNewOriginLocation);
		
		
		/// <summary>
		/// this function allows pausing the seamless travel in the middle,
		/// <para>right before it starts loading the destination (i.e. while in the transition level) </para>
		/// this gives the opportunity to perform any other loading tasks before the final transition
		/// <para>this function has no effect if we have already started loading the destination (you will get a log warning if this is the case) </para>
		/// </summary>
		/// <param name="bNowPaused">whether the transition should now be paused</param>
		public void SetSeamlessTravelMidpointPause(bool bNowPaused)
			=> E_UWorld_SetSeamlessTravelMidpointPause(this, bNowPaused);
		
		public void SetShouldForceUnloadStreamingLevels(bool bInShouldForceUnloadStreamingLevels)
			=> E_UWorld_SetShouldForceUnloadStreamingLevels(this, bInShouldForceUnloadStreamingLevels);
		
		public void SetShouldForceVisibleStreamingLevels(bool bInShouldForceVisibleStreamingLevels)
			=> E_UWorld_SetShouldForceVisibleStreamingLevels(this, bInShouldForceVisibleStreamingLevels);
		
		
		/// <summary>
		/// Sets whether or not this world is ticked by the engine, but use it at your own risk! This could
		/// <para>have unintended consequences if used carelessly. That said, for worlds that are not interactive </para>
		/// and not rendering, it can save the cost of ticking them. This should probably never be used
		/// <para>for a primary game world. </para>
		/// </summary>
		public void SetShouldTick(bool bInShouldTick)
			=> E_UWorld_SetShouldTick(this, bInShouldTick);
		
		
		/// <summary>
		/// Updates the timer (as a one-off) that is used to trigger garbage collection; this should only be used for things
		/// <para>like performance tests, using it recklessly can dramatically increase memory usage and cost of the eventual GC. </para>
		/// Note: Things that force a GC will still force a GC after using this method (and they will also reset the timer)
		/// </summary>
		public void SetTimeUntilNextGarbageCollection(float minTimeUntilNextPass)
			=> E_UWorld_SetTimeUntilNextGarbageCollection(this, minTimeUntilNextPass);
		
		
		/// <summary>
		/// Creates instances for each parameter collection in memory.  Called when a world is created.
		/// </summary>
		public void SetupParameterCollectionInstances()
			=> E_UWorld_SetupParameterCollectionInstances(this);
		
		
		/// <summary>
		/// Set up the physics tick function if they aren't already
		/// </summary>
		public void SetupPhysicsTickFunctions(float deltaSeconds)
			=> E_UWorld_SetupPhysicsTickFunctions(this, deltaSeconds);
		
		
		/// <summary>
		/// Returns whether or not this world is currently ticking. See SetShouldTick.
		/// </summary>
		public bool ShouldTick()
			=> E_UWorld_ShouldTick(this);
		
		
		/// <summary>
		/// Begin physics simulation
		/// </summary>
		public void StartPhysicsSim()
			=> E_UWorld_StartPhysicsSim(this);
		
		
		/// <summary>
		/// Given a PackageName and a prefix type, get back to the original package name (i.e. the saved map name)
		/// </summary>
		public string StripPIEPrefixFromPackageName(string packageName, string prefix)
			=> E_UWorld_StripPIEPrefixFromPackageName(this, packageName, prefix);
		
		
		/// <summary>
		/// Update the level after a variable amount of time, DeltaSeconds, has passed.
		/// <para>All child actors are ticked after their owners have been ticked. </para>
		/// </summary>
		public void Tick(ELevelTick tickType, float deltaSeconds)
			=> E_UWorld_Tick(this, (byte)tickType, deltaSeconds);
		
		
		/// <summary>
		/// Do per frame tick behaviors related to the network driver
		/// </summary>
		public void TickNetClient(float deltaSeconds)
			=> E_UWorld_TickNetClient(this, deltaSeconds);
		
		
		/// <summary>
		/// Helper for getting the time since a certain time.
		/// </summary>
		public float TimeSince(float time)
			=> E_UWorld_TimeSince(this, time);
		
		
		/// <summary>
		/// Transfers the set of Kismet / Blueprint objects being debugged to the new world that are not already present, and updates blueprints accordingly
		/// </summary>
		/// <param name="newWorld">The new world to find equivalent objects in</param>
		public void TransferBlueprintDebugReferences(UWorld newWorld)
			=> E_UWorld_TransferBlueprintDebugReferences(this, newWorld);
		
		
		/// <summary>
		/// Triggers a call to ULevel::BuildStreamingData(this,NULL,NULL) within a few seconds.
		/// </summary>
		public void TriggerStreamingDataRebuild()
			=> E_UWorld_TriggerStreamingDataRebuild(this);
		
		
		/// <summary>
		/// Purges all sky capture cached derived data and forces a re-render of captured scene data.
		/// </summary>
		public void UpdateAllSkyCaptures()
			=> E_UWorld_UpdateAllSkyCaptures(this);
		
		
		/// <summary>
		/// Updates cull distance volumes for a specified component or a specified actor or all actors
		/// </summary>
		/// <param name="componentToUpdate">If specified just that Component will be updated</param>
		/// <param name="actorToUpdate">If specified (and ComponentToUpdate is not specified), all Components owned by this Actor will be updated</param>
		/// <return>True</return>
		public bool UpdateCullDistanceVolumes(AActor actorToUpdate = null, UPrimitiveComponent componentToUpdate = null)
			=> E_UWorld_UpdateCullDistanceVolumes(this, actorToUpdate, componentToUpdate);
		
		
		/// <summary>
		/// Updates sub-levels (load/unload/show/hide) using streaming levels current state
		/// </summary>
		public void UpdateLevelStreaming()
			=> E_UWorld_UpdateLevelStreaming(this);
		
		
		/// <summary>
		/// Updates this world's scene with the list of instances, and optionally updates each instance's uniform buffer.
		/// </summary>
		public void UpdateParameterCollectionInstances(bool bUpdateInstanceUniformBuffers, bool bRecreateUniformBuffer)
			=> E_UWorld_UpdateParameterCollectionInstances(this, bUpdateInstanceUniformBuffers, bRecreateUniformBuffer);
		
		
		/// <summary>
		/// Updates world components like e.g. line batcher and all level components.
		/// </summary>
		/// <param name="bRerunConstructionScripts">If we should rerun construction scripts on actors</param>
		/// <param name="bCurrentLevelOnly">If true, affect only the current level.</param>
		public void UpdateWorldComponents(bool bRerunConstructionScripts, bool bCurrentLevelOnly)
			=> E_UWorld_UpdateWorldComponents(this, bRerunConstructionScripts, bCurrentLevelOnly);
		
		
		/// <summary>
		/// Returns true if this world should look at game hidden flags instead of editor hidden flags for the purposes of rendering
		/// </summary>
		public bool UsesGameHiddenFlags()
			=> E_UWorld_UsesGameHiddenFlags(this);
		
		#endregion
		
		public static implicit operator IntPtr(UWorld self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UWorld(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UWorld>(PtrDesc);
		}}}
