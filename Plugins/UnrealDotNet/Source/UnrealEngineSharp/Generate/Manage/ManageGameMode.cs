// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameMode.h:35

namespace UnrealEngine
{
	[ManageType("ManageGameMode")]
	public partial class ManageGameMode : AGameMode, IManageWrapper
	{
		public ManageGameMode(IntPtr adress)
			: base(adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_AbortMatch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_EndMatch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_HandleLeavingMap(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_HandleMatchAborted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_HandleMatchHasEnded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_HandleMatchHasStarted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_HandleMatchIsWaitingToStart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_MatineeCancelled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_OnMatchStateSet(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostCommitMapChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_RestartGame(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_SetBandwidthLimit(IntPtr self, float asyncIOBandwidthLimit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_StartMatch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_InitGameState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostSeamlessTravel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_ResetLevel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_ReturnToMainMenuHost(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_StartPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_StartToLeaveMap(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_BeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_ClearCrossLevelReferences(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_Destroyed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_ForceNetRelevant(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_ForceNetUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_GatherCurrentMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_InvalidateLightingCacheDetailed(IntPtr self, bool bTranslationOnly);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_K2_DestroyActor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_LifeSpanExpired(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_MarkComponentsAsPendingKill(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_NotifyActorBeginCursorOver(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_NotifyActorEndCursorOver(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_OnRep_AttachmentReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_OnRep_Instigator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_OnRep_Owner(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_OnRep_ReplicatedMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_OnRep_ReplicateMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_OnReplicationPausedChanged(IntPtr self, bool bIsReplicationPaused);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_OutsideWorldBounds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostActorCreated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostInitializeComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostNetInit(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostNetReceiveLocationAndRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostNetReceivePhysicState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostNetReceiveRole(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostRegisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostUnregisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PreInitializeComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PreRegisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PrestreamTextures(IntPtr self, float seconds, bool bEnableStreaming, int cinematicTextureGroups);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_RegisterActorTickFunctions(IntPtr self, bool bRegister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_RegisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_ReregisterAllComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_RerunConstructionScripts(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_Reset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_RewindForReplay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_SetActorHiddenInGame(IntPtr self, bool bNewHidden);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_SetLifeSpan(IntPtr self, float inLifespan);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_SetReplicateMovement(IntPtr self, bool bInReplicateMovement);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_TearOff(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_TeleportSucceeded(IntPtr self, bool bIsATest);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_Tick(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_TornOff(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_UnregisterAllComponents(IntPtr self, bool bForReregister);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_BeginDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_FinishDestroy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_MarkAsEditorOnlySubobject(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostCDOContruct(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostEditImport(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostInitProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostLoad(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostRepNotifies(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PostSaveRoot(IntPtr self, bool bCleanupIsRequired);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PreDestroyFromReplication(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_PreNetReceive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_ShutdownAfterError(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_CreateCluster(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E__Supper__AGameMode_OnClusterMarkedAsPendingKill(IntPtr self);
		
		#endregion
		
		#region Methods
		
		/// <summary>
		/// Report that a match has failed due to unrecoverable error
		/// </summary>
		public override void AbortMatch()
			=> E__Supper__AGameMode_AbortMatch(this);
		
		
		/// <summary>
		/// Transition from InProgress to WaitingPostMatch. You can call this manually, will also get called if ReadyToEndMatch returns true
		/// </summary>
		public override void EndMatch()
			=> E__Supper__AGameMode_EndMatch(this);
		
		
		/// <summary>
		/// Called when the match transitions to LeavingMap
		/// </summary>
		protected override void HandleLeavingMap()
			=> E__Supper__AGameMode_HandleLeavingMap(this);
		
		
		/// <summary>
		/// Called when the match transitions to Aborted
		/// </summary>
		protected override void HandleMatchAborted()
			=> E__Supper__AGameMode_HandleMatchAborted(this);
		
		
		/// <summary>
		/// Called when the map transitions to WaitingPostMatch
		/// </summary>
		protected override void HandleMatchHasEnded()
			=> E__Supper__AGameMode_HandleMatchHasEnded(this);
		
		
		/// <summary>
		/// Called when the state transitions to InProgress
		/// </summary>
		protected override void HandleMatchHasStarted()
			=> E__Supper__AGameMode_HandleMatchHasStarted(this);
		
		
		/// <summary>
		/// Called when the state transitions to WaitingToStart
		/// </summary>
		protected override void HandleMatchIsWaitingToStart()
			=> E__Supper__AGameMode_HandleMatchIsWaitingToStart(this);
		
		
		/// <summary>
		/// Called when this PC is in cinematic mode, and its matinee is canceled by the user.
		/// </summary>
		public override void MatineeCancelled()
			=> E__Supper__AGameMode_MatineeCancelled(this);
		
		
		/// <summary>
		/// Overridable virtual function to dispatch the appropriate transition functions before GameState and Blueprints get SetMatchState calls.
		/// </summary>
		protected override void OnMatchStateSet()
			=> E__Supper__AGameMode_OnMatchStateSet(this);
		
		
		/// <summary>
		/// Called from CommitMapChange after unloading previous level and loading new level+sublevels. Used for asynchronous level streaming
		/// </summary>
		public override void PostCommitMapChange()
			=> E__Supper__AGameMode_PostCommitMapChange(this);
		
		
		/// <summary>
		/// Restart the game, by default travel to the current map
		/// </summary>
		public override void RestartGame()
			=> E__Supper__AGameMode_RestartGame(this);
		
		public override void SetBandwidthLimit(float asyncIOBandwidthLimit)
			=> E__Supper__AGameMode_SetBandwidthLimit(this, asyncIOBandwidthLimit);
		
		
		/// <summary>
		/// Transition from WaitingToStart to InProgress. You can call this manually, will also get called if ReadyToStartMatch returns true
		/// </summary>
		public override void StartMatch()
			=> E__Supper__AGameMode_StartMatch(this);
		
		
		/// <summary>
		/// Initialize the GameState actor with default settings
		/// <para>called during PreInitializeComponents() of the GameMode after a GameState has been spawned </para>
		/// as well as during Reset()
		/// </summary>
		public override void InitGameState()
			=> E__Supper__AGameMode_InitGameState(this);
		
		
		/// <summary>
		/// Called after a seamless level transition has been completed on the *new* GameMode.
		/// <para>Used to reinitialize players already in the game as they won't have *Login() called on them </para>
		/// </summary>
		public override void PostSeamlessTravel()
			=> E__Supper__AGameMode_PostSeamlessTravel(this);
		
		
		/// <summary>
		/// Overridable function called when resetting level. This is used to reset the game state while staying in the same map
		/// <para>Default implementation calls Reset() on all actors except GameMode and Controllers </para>
		/// </summary>
		public override void ResetLevel()
			=> E__Supper__AGameMode_ResetLevel(this);
		
		
		/// <summary>
		/// Return to main menu, and disconnect any players
		/// </summary>
		public override void ReturnToMainMenuHost()
			=> E__Supper__AGameMode_ReturnToMainMenuHost(this);
		
		
		/// <summary>
		/// Transitions to calls BeginPlay on actors.
		/// </summary>
		public override void StartPlay()
			=> E__Supper__AGameMode_StartPlay(this);
		
		
		/// <summary>
		/// Start the transition out of the current map. Called at start of seamless travel, or right before map change for hard travel.
		/// </summary>
		public override void StartToLeaveMap()
			=> E__Supper__AGameMode_StartToLeaveMap(this);
		
		
		/// <summary>
		/// Overridable native event for when play begins for this actor.
		/// </summary>
		protected override void BeginPlay()
			=> E__Supper__AGameMode_BeginPlay(this);
		
		
		/// <summary>
		/// Do anything needed to clear out cross level references; Called from ULevel::PreSave
		/// </summary>
		public override void ClearCrossLevelReferences()
			=> E__Supper__AGameMode_ClearCrossLevelReferences(this);
		
		
		/// <summary>
		/// Called when this actor is explicitly being destroyed during gameplay or in the editor, not called during level streaming or gameplay ending
		/// </summary>
		public override void Destroyed()
			=> E__Supper__AGameMode_Destroyed(this);
		
		
		/// <summary>
		/// Forces this actor to be net relevant if it is not already by default
		/// </summary>
		public override void ForceNetRelevant()
			=> E__Supper__AGameMode_ForceNetRelevant(this);
		
		
		/// <summary>
		/// Force actor to be updated to clients/demo net drivers
		/// </summary>
		public override void ForceNetUpdate()
			=> E__Supper__AGameMode_ForceNetUpdate(this);
		
		
		/// <summary>
		/// Fills ReplicatedMovement property
		/// </summary>
		public override void GatherCurrentMovement()
			=> E__Supper__AGameMode_GatherCurrentMovement(this);
		
		
		/// <summary>
		/// Invalidates anything produced by the last lighting build.
		/// </summary>
		public override void InvalidateLightingCacheDetailed(bool bTranslationOnly)
			=> E__Supper__AGameMode_InvalidateLightingCacheDetailed(this, bTranslationOnly);
		
		
		/// <summary>
		/// Destroy the actor
		/// </summary>
		public override void DestroyActor()
			=> E__Supper__AGameMode_K2_DestroyActor(this);
		
		
		/// <summary>
		/// Called when the lifespan of an actor expires (if he has one).
		/// </summary>
		public override void LifeSpanExpired()
			=> E__Supper__AGameMode_LifeSpanExpired(this);
		
		
		/// <summary>
		/// Called to mark all components as pending kill when the actor is being destroyed
		/// </summary>
		public override void MarkComponentsAsPendingKill()
			=> E__Supper__AGameMode_MarkComponentsAsPendingKill(this);
		
		
		/// <summary>
		/// Event when this actor has the mouse moved over it with the clickable interface.
		/// </summary>
		public override void NotifyActorBeginCursorOver()
			=> E__Supper__AGameMode_NotifyActorBeginCursorOver(this);
		
		
		/// <summary>
		/// Event when this actor has the mouse moved off of it with the clickable interface.
		/// </summary>
		public override void NotifyActorEndCursorOver()
			=> E__Supper__AGameMode_NotifyActorEndCursorOver(this);
		
		public override void OnRep_AttachmentReplication()
			=> E__Supper__AGameMode_OnRep_AttachmentReplication(this);
		
		public override void OnRep_Instigator()
			=> E__Supper__AGameMode_OnRep_Instigator(this);
		
		protected override void OnRep_Owner()
			=> E__Supper__AGameMode_OnRep_Owner(this);
		
		public override void OnRep_ReplicatedMovement()
			=> E__Supper__AGameMode_OnRep_ReplicatedMovement(this);
		
		public override void OnRep_ReplicateMovement()
			=> E__Supper__AGameMode_OnRep_ReplicateMovement(this);
		
		
		/// <summary>
		/// Called on the client when the replication paused value is changed
		/// </summary>
		public override void OnReplicationPausedChanged(bool bIsReplicationPaused)
			=> E__Supper__AGameMode_OnReplicationPausedChanged(this, bIsReplicationPaused);
		
		
		/// <summary>
		/// Called when the Actor is outside the hard limit on world bounds
		/// </summary>
		public override void OutsideWorldBounds()
			=> E__Supper__AGameMode_OutsideWorldBounds(this);
		
		
		/// <summary>
		/// Called when an actor is done spawning into the world (from UWorld::SpawnActor), both in the editor and during gameplay
		/// <para>For actors with a root component, the location and rotation will have already been set. </para>
		/// This is called before calling construction scripts, but after native components have been created
		/// </summary>
		public override void PostActorCreated()
			=> E__Supper__AGameMode_PostActorCreated(this);
		
		
		/// <summary>
		/// Allow actors to initialize themselves on the C++ side after all of their components have been initialized, only called during gameplay
		/// </summary>
		public override void PostInitializeComponents()
			=> E__Supper__AGameMode_PostInitializeComponents(this);
		
		
		/// <summary>
		/// Always called immediately after spawning and reading in replicated properties
		/// </summary>
		public override void PostNetInit()
			=> E__Supper__AGameMode_PostNetInit(this);
		
		
		/// <summary>
		/// Update location and rotation from ReplicatedMovement. Not called for simulated physics!
		/// </summary>
		public override void PostNetReceiveLocationAndRotation()
			=> E__Supper__AGameMode_PostNetReceiveLocationAndRotation(this);
		
		
		/// <summary>
		/// Update and smooth simulated physic state, replaces PostNetReceiveLocation() and PostNetReceiveVelocity()
		/// </summary>
		public override void PostNetReceivePhysicState()
			=> E__Supper__AGameMode_PostNetReceivePhysicState(this);
		
		
		/// <summary>
		/// Always called immediately after a new Role is received from the remote.
		/// </summary>
		public override void PostNetReceiveRole()
			=> E__Supper__AGameMode_PostNetReceiveRole(this);
		
		
		/// <summary>
		/// Called after all the components in the Components array are registered, called both in editor and during gameplay
		/// </summary>
		public override void PostRegisterAllComponents()
			=> E__Supper__AGameMode_PostRegisterAllComponents(this);
		
		
		/// <summary>
		/// Called after all currently registered components are cleared
		/// </summary>
		public override void PostUnregisterAllComponents()
			=> E__Supper__AGameMode_PostUnregisterAllComponents(this);
		
		
		/// <summary>
		/// Called right before components are initialized, only called during gameplay
		/// </summary>
		public override void PreInitializeComponents()
			=> E__Supper__AGameMode_PreInitializeComponents(this);
		
		
		/// <summary>
		/// Called before all the components in the Components array are registered, called both in editor and during gameplay
		/// </summary>
		public override void PreRegisterAllComponents()
			=> E__Supper__AGameMode_PreRegisterAllComponents(this);
		
		
		/// <summary>
		/// Calls PrestreamTextures() for all the actor's meshcomponents.
		/// </summary>
		/// <param name="seconds">Number of seconds to force all mip-levels to be resident</param>
		/// <param name="bEnableStreaming">Whether to start (true) or stop (false) streaming</param>
		/// <param name="cinematicTextureGroups">Bitfield indicating which texture groups that use extra high-resolution mips</param>
		public override void PrestreamTextures(float seconds, bool bEnableStreaming, int cinematicTextureGroups)
			=> E__Supper__AGameMode_PrestreamTextures(this, seconds, bEnableStreaming, cinematicTextureGroups);
		
		
		/// <summary>
		/// Virtual call chain to register all tick functions for the actor class hierarchy
		/// </summary>
		/// <param name="bRegister">true to register, false, to unregister</param>
		protected override void RegisterActorTickFunctions(bool bRegister)
			=> E__Supper__AGameMode_RegisterActorTickFunctions(this, bRegister);
		
		
		/// <summary>
		/// Ensure that all the components in the Components array are registered
		/// </summary>
		public override void RegisterAllComponents()
			=> E__Supper__AGameMode_RegisterAllComponents(this);
		
		
		/// <summary>
		/// Will reregister all components on this actor. Does a lot of work - should only really be used in editor, generally use UpdateComponentTransforms or MarkComponentsRenderStateDirty.
		/// </summary>
		public override void ReregisterAllComponents()
			=> E__Supper__AGameMode_ReregisterAllComponents(this);
		
		
		/// <summary>
		/// Rerun construction scripts, destroying all autogenerated components; will attempt to preserve the root component location.
		/// </summary>
		public override void RerunConstructionScripts()
			=> E__Supper__AGameMode_RerunConstructionScripts(this);
		
		
		/// <summary>
		/// Reset actor to initial state - used when restarting level without reloading.
		/// </summary>
		public override void Reset()
			=> E__Supper__AGameMode_Reset(this);
		
		
		/// <summary>
		/// Called on the actor before checkpoint data is applied during a replay.
		/// <para>Only called if bReplayRewindable is set. </para>
		/// </summary>
		public override void RewindForReplay()
			=> E__Supper__AGameMode_RewindForReplay(this);
		
		
		/// <summary>
		/// Sets the actor to be hidden in the game
		/// </summary>
		/// <param name="bNewHidden">Whether or not to hide the actor and all its components</param>
		public override void SetActorHiddenInGame(bool bNewHidden)
			=> E__Supper__AGameMode_SetActorHiddenInGame(this, bNewHidden);
		
		
		/// <summary>
		/// Set the lifespan of this actor. When it expires the object will be destroyed. If requested lifespan is 0, the timer is cleared and the actor will not be destroyed.
		/// </summary>
		public override void SetLifeSpan(float inLifespan)
			=> E__Supper__AGameMode_SetLifeSpan(this, inLifespan);
		
		
		/// <summary>
		/// Set whether this actor's movement replicates to network clients.
		/// </summary>
		/// <param name="bInReplicateMovement">Whether this Actor's movement replicates to clients.</param>
		public override void SetReplicateMovement(bool bInReplicateMovement)
			=> E__Supper__AGameMode_SetReplicateMovement(this, bInReplicateMovement);
		
		
		/// <summary>
		/// Networking - Server - TearOff this actor to stop replication to clients. Will set bTearOff to true.
		/// </summary>
		public override void TearOff()
			=> E__Supper__AGameMode_TearOff(this);
		
		
		/// <summary>
		/// Called from TeleportTo() when teleport succeeds
		/// </summary>
		public override void TeleportSucceeded(bool bIsATest)
			=> E__Supper__AGameMode_TeleportSucceeded(this, bIsATest);
		
		
		/// <summary>
		/// Function called every frame on this Actor. Override this function to implement custom logic to be executed every frame.
		/// <para>Note that Tick is disabled by default, and you will need to check PrimaryActorTick.bCanEverTick is set to true to enable it. </para>
		/// </summary>
		/// <param name="deltaSeconds">Game time elapsed during last frame modified by the time dilation</param>
		public override void Tick(float deltaSeconds)
			=> E__Supper__AGameMode_Tick(this, deltaSeconds);
		
		
		/// <summary>
		/// Networking - called on client when actor is torn off (bTearOff==true), meaning it's no longer replicated to clients.
		/// <para>@see bTearOff </para>
		/// </summary>
		public override void TornOff()
			=> E__Supper__AGameMode_TornOff(this);
		
		
		/// <summary>
		/// Unregister all currently registered components
		/// </summary>
		/// <param name="bForReregister">If true, RegisterAllComponents will be called immediately after this so some slow operations can be avoided</param>
		public override void UnregisterAllComponents(bool bForReregister)
			=> E__Supper__AGameMode_UnregisterAllComponents(this, bForReregister);
		
		
		/// <summary>
		/// Called before destroying the object.  This is called immediately upon deciding to destroy the object, to allow the object to begin an
		/// <para>asynchronous cleanup process. </para>
		/// </summary>
		public override void BeginDestroy()
			=> E__Supper__AGameMode_BeginDestroy(this);
		
		
		/// <summary>
		/// Called to finish destroying the object.  After UObject::FinishDestroy is called, the object's memory should no longer be accessed.
		/// <para>@warning Because properties are destroyed here, Super::FinishDestroy() should always be called at the end of your child class's FinishDestroy() method, rather than at the beginning. </para>
		/// </summary>
		public override void FinishDestroy()
			=> E__Supper__AGameMode_FinishDestroy(this);
		
		
		/// <summary>
		/// Called during subobject creation to mark this component as editor only, which causes it to get stripped in packaged builds
		/// </summary>
		public override void MarkAsEditorOnlySubobject()
			=> E__Supper__AGameMode_MarkAsEditorOnlySubobject(this);
		
		
		/// <summary>
		/// Called after the C++ constructor has run on the CDO for a class. This is an obscure routine used to deal with the recursion
		/// <para>in the construction of the default materials </para>
		/// </summary>
		public override void PostCDOContruct()
			=> E__Supper__AGameMode_PostCDOContruct(this);
		
		
		/// <summary>
		/// Called after importing property values for this object (paste, duplicate or .t3d import)
		/// <para>Allow the object to perform any cleanup for properties which shouldn't be duplicated or </para>
		/// are unsupported by the script serialization
		/// </summary>
		public override void PostEditImport()
			=> E__Supper__AGameMode_PostEditImport(this);
		
		
		/// <summary>
		/// Called after the C++ constructor and after the properties have been initialized, including those loaded from config.
		/// <para>This is called before any serialization or other setup has happened. </para>
		/// </summary>
		public override void PostInitProperties()
			=> E__Supper__AGameMode_PostInitProperties(this);
		
		
		/// <summary>
		/// Do any object-specific cleanup required immediately after loading an object.
		/// <para>This is not called for newly-created objects, and by default will always execute on the game thread. </para>
		/// </summary>
		public override void PostLoad()
			=> E__Supper__AGameMode_PostLoad(this);
		
		
		/// <summary>
		/// Called right after receiving a bunch
		/// </summary>
		public override void PostNetReceive()
			=> E__Supper__AGameMode_PostNetReceive(this);
		
		
		/// <summary>
		/// Called right after calling all OnRep notifies (called even when there are no notifies)
		/// </summary>
		public override void PostRepNotifies()
			=> E__Supper__AGameMode_PostRepNotifies(this);
		
		
		/// <summary>
		/// Called from within SavePackage on the passed in base/root object.
		/// <para>This function is called after the package has been saved and can perform cleanup. </para>
		/// </summary>
		/// <param name="bCleanupIsRequired">Whether PreSaveRoot dirtied state that needs to be cleaned up</param>
		public override void PostSaveRoot(bool bCleanupIsRequired)
			=> E__Supper__AGameMode_PostSaveRoot(this, bCleanupIsRequired);
		
		
		/// <summary>
		/// Called right before being marked for destruction due to network replication
		/// </summary>
		public override void PreDestroyFromReplication()
			=> E__Supper__AGameMode_PreDestroyFromReplication(this);
		
		
		/// <summary>
		/// Called right before receiving a bunch
		/// </summary>
		public override void PreNetReceive()
			=> E__Supper__AGameMode_PreNetReceive(this);
		
		
		/// <summary>
		/// After a critical error, perform any mission-critical cleanup, such as restoring the video mode orreleasing hardware resources.
		/// </summary>
		public override void ShutdownAfterError()
			=> E__Supper__AGameMode_ShutdownAfterError(this);
		
		
		/// <summary>
		/// Called after PostLoad to create UObject cluster
		/// </summary>
		public override void CreateCluster()
			=> E__Supper__AGameMode_CreateCluster(this);
		
		
		/// <summary>
		/// Called during Garbage Collection to perform additional cleanup when the cluster is about to be destroyed due to PendingKill flag being set on it.
		/// </summary>
		public override void OnClusterMarkedAsPendingKill()
			=> E__Supper__AGameMode_OnClusterMarkedAsPendingKill(this);
		
		#endregion
		
		public static implicit operator IntPtr(ManageGameMode self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameMode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameMode>(PtrDesc);
		}}}
