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
	public  partial class AGameMode : AGameModeBase
	{
		public AGameMode(IntPtr adress)
			: base(adress)
		{
		}

		public AGameMode(UObject Parent = null, string Name = "GameMode")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AGameMode(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_AGameMode_MinRespawnDelay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameMode_MinRespawnDelay_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameMode_NumBots_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameMode_NumBots_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameMode_NumPlayers_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameMode_NumPlayers_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameMode_NumSpectators_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameMode_NumSpectators_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameMode_NumTravellingPlayers_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameMode_NumTravellingPlayers_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AGameMode(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_AbortMatch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_AddInactivePlayer(IntPtr self, IntPtr playerState, IntPtr pC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_Broadcast(IntPtr self, IntPtr sender, string msg, string type);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_EndMatch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameMode_FindInactivePlayer(IntPtr self, IntPtr pC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AGameMode_GetDefaultGameClassPath(IntPtr self, string mapName, string options, string portal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AGameMode_GetMatchState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AGameMode_GetNetworkNumber(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameMode_GetTravelType(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_HandleLeavingMap(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_HandleMatchAborted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_HandleMatchHasEnded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_HandleMatchHasStarted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_HandleMatchIsWaitingToStart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameMode_HasMatchEnded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameMode_IsMatchInProgress(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_K2_OnSetMatchState(IntPtr self, string newState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_MatineeCancelled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_OnMatchStateSet(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_OverridePlayerState(IntPtr self, IntPtr pC, IntPtr oldPlayerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_PlayerSwitchedToSpectatorOnly(IntPtr self, IntPtr pC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_PostCommitMapChange(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_PreCommitMapChange(IntPtr self, string previousMapName, string nextMapName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameMode_ReadyToEndMatch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameMode_ReadyToStartMatch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_RemovePlayerControllerFromPlayerCount(IntPtr self, IntPtr pC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_RestartGame(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_Say(IntPtr self, string msg);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_SendPlayer(IntPtr self, IntPtr aPlayer, string uRL);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_SetBandwidthLimit(IntPtr self, float asyncIOBandwidthLimit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_SetMatchState(IntPtr self, string newState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_SetSeamlessTravelViewTarget(IntPtr self, IntPtr pC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_StartMatch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameMode_StartNewPlayer(IntPtr self, IntPtr newPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AGameMode_StaticGetFullGameClassName(IntPtr self, string str);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Minimum time before player can respawn after dying.
		/// </summary>
		public float MinimumRespawnDelay
		{
			get => E_PROP_AGameMode_MinRespawnDelay_GET(NativePointer);
			set => E_PROP_AGameMode_MinRespawnDelay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// number of non-human players (AI controlled but participating as a player).
		/// </summary>
		public int NumBots
		{
			get => E_PROP_AGameMode_NumBots_GET(NativePointer);
			set => E_PROP_AGameMode_NumBots_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current number of human players.
		/// </summary>
		public int NumPlayers
		{
			get => E_PROP_AGameMode_NumPlayers_GET(NativePointer);
			set => E_PROP_AGameMode_NumPlayers_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Current number of spectators.
		/// </summary>
		public int NumSpectators
		{
			get => E_PROP_AGameMode_NumSpectators_GET(NativePointer);
			set => E_PROP_AGameMode_NumSpectators_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Number of players that are still traveling from a previous map
		/// </summary>
		public int NumTravellingPlayers
		{
			get => E_PROP_AGameMode_NumTravellingPlayers_GET(NativePointer);
			set => E_PROP_AGameMode_NumTravellingPlayers_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Report that a match has failed due to unrecoverable error
		/// </summary>
		public virtual void AbortMatch()
			=> E_AGameMode_AbortMatch(this);
		
		
		/// <summary>
		/// Add PlayerState to the inactive list, remove from the active list
		/// </summary>
		public virtual void AddInactivePlayer(APlayerState playerState, APlayerController pC)
			=> E_AGameMode_AddInactivePlayer(this, playerState, pC);
		
		
		/// <summary>
		/// Broadcast a string to all players.
		/// </summary>
		public virtual void Broadcast(AActor sender, string msg, string type)
			=> E_AGameMode_Broadcast(this, sender, msg, type);
		
		
		/// <summary>
		/// Transition from InProgress to WaitingPostMatch. You can call this manually, will also get called if ReadyToEndMatch returns true
		/// </summary>
		public virtual void EndMatch()
			=> E_AGameMode_EndMatch(this);
		
		
		/// <summary>
		/// Attempt to find and associate an inactive PlayerState with entering PC.
		/// <para>@Returns true if a PlayerState was found and associated with PC. </para>
		/// </summary>
		public virtual bool FindInactivePlayer(APlayerController pC)
			=> E_AGameMode_FindInactivePlayer(this, pC);
		
		public virtual string GetDefaultGameClassPath(string mapName, string options, string portal)
			=> E_AGameMode_GetDefaultGameClassPath(this, mapName, options, portal);
		
		
		/// <summary>
		/// Returns the current match state, this is an accessor to protect the state machine flow
		/// </summary>
		public string GetMatchState()
			=> E_AGameMode_GetMatchState(this);
		
		
		/// <summary>
		/// Get local address
		/// </summary>
		public virtual string GetNetworkNumber()
			=> E_AGameMode_GetNetworkNumber(this);
		
		
		/// <summary>
		/// Return true if we want to travel_absolute, used by RestartGame by default
		/// </summary>
		public virtual bool GetTravelType()
			=> E_AGameMode_GetTravelType(this);
		
		
		/// <summary>
		/// Called when the match transitions to LeavingMap
		/// </summary>
		protected virtual void HandleLeavingMap()
			=> E_AGameMode_HandleLeavingMap(this);
		
		
		/// <summary>
		/// Called when the match transitions to Aborted
		/// </summary>
		protected virtual void HandleMatchAborted()
			=> E_AGameMode_HandleMatchAborted(this);
		
		
		/// <summary>
		/// Called when the map transitions to WaitingPostMatch
		/// </summary>
		protected virtual void HandleMatchHasEnded()
			=> E_AGameMode_HandleMatchHasEnded(this);
		
		
		/// <summary>
		/// Called when the state transitions to InProgress
		/// </summary>
		protected virtual void HandleMatchHasStarted()
			=> E_AGameMode_HandleMatchHasStarted(this);
		
		
		/// <summary>
		/// Called when the state transitions to WaitingToStart
		/// </summary>
		protected virtual void HandleMatchIsWaitingToStart()
			=> E_AGameMode_HandleMatchIsWaitingToStart(this);
		
		
		/// <summary>
		/// Returns true if the match state is WaitingPostMatch or later
		/// </summary>
		public virtual bool HasMatchEnded()
			=> E_AGameMode_HasMatchEnded(this);
		
		
		/// <summary>
		/// Returns true if the match state is InProgress or other gameplay state
		/// </summary>
		public virtual bool IsMatchInProgress()
			=> E_AGameMode_IsMatchInProgress(this);
		
		
		/// <summary>
		/// Implementable event to respond to match state changes
		/// </summary>
		protected void OnSetMatchState(string newState)
			=> E_AGameMode_K2_OnSetMatchState(this, newState);
		
		
		/// <summary>
		/// Called when this PC is in cinematic mode, and its matinee is canceled by the user.
		/// </summary>
		public virtual void MatineeCancelled()
			=> E_AGameMode_MatineeCancelled(this);
		
		
		/// <summary>
		/// Overridable virtual function to dispatch the appropriate transition functions before GameState and Blueprints get SetMatchState calls.
		/// </summary>
		protected virtual void OnMatchStateSet()
			=> E_AGameMode_OnMatchStateSet(this);
		
		
		/// <summary>
		/// Override PC's PlayerState with the values in OldPlayerState as part of the inactive player handling
		/// </summary>
		public virtual void OverridePlayerState(APlayerController pC, APlayerState oldPlayerState)
			=> E_AGameMode_OverridePlayerState(this, pC, oldPlayerState);
		
		
		/// <summary>
		/// Will remove the controller from the correct count then add them to the spectator count.
		/// </summary>
		public void PlayerSwitchedToSpectatorOnly(APlayerController pC)
			=> E_AGameMode_PlayerSwitchedToSpectatorOnly(this, pC);
		
		
		/// <summary>
		/// Called from CommitMapChange after unloading previous level and loading new level+sublevels. Used for asynchronous level streaming
		/// </summary>
		public virtual void PostCommitMapChange()
			=> E_AGameMode_PostCommitMapChange(this);
		
		
		/// <summary>
		/// Called from CommitMapChange before unloading previous level. Used for asynchronous level streaming
		/// </summary>
		/// <param name="previousMapName">Name of the previous persistent level</param>
		/// <param name="nextMapName">Name of the persistent level being streamed to</param>
		public virtual void PreCommitMapChange(string previousMapName, string nextMapName)
			=> E_AGameMode_PreCommitMapChange(this, previousMapName, nextMapName);
		
		
		/// <summary>
		/// Returns true if ready to End Match. Games should override this
		/// </summary>
		protected bool ReadyToEndMatch()
			=> E_AGameMode_ReadyToEndMatch(this);
		
		
		/// <summary>
		/// Returns true if ready to Start Match. Games should override this
		/// </summary>
		protected bool ReadyToStartMatch()
			=> E_AGameMode_ReadyToStartMatch(this);
		
		
		/// <summary>
		/// Removes the passed in player controller from the correct count for player/spectator/tranistioning
		/// </summary>
		public void RemovePlayerControllerFromPlayerCount(APlayerController pC)
			=> E_AGameMode_RemovePlayerControllerFromPlayerCount(this, pC);
		
		
		/// <summary>
		/// Restart the game, by default travel to the current map
		/// </summary>
		public virtual void RestartGame()
			=> E_AGameMode_RestartGame(this);
		
		
		/// <summary>
		/// Exec command to broadcast a string to all players
		/// </summary>
		public virtual void Say(string msg)
			=> E_AGameMode_Say(this, msg);
		
		public virtual void SendPlayer(APlayerController aPlayer, string uRL)
			=> E_AGameMode_SendPlayer(this, aPlayer, uRL);
		
		public virtual void SetBandwidthLimit(float asyncIOBandwidthLimit)
			=> E_AGameMode_SetBandwidthLimit(this, asyncIOBandwidthLimit);
		
		
		/// <summary>
		/// Updates the match state and calls the appropriate transition functions
		/// </summary>
		protected virtual void SetMatchState(string newState)
			=> E_AGameMode_SetMatchState(this, newState);
		
		
		/// <summary>
		/// SetViewTarget of player control on server change
		/// </summary>
		public virtual void SetSeamlessTravelViewTarget(APlayerController pC)
			=> E_AGameMode_SetSeamlessTravelViewTarget(this, pC);
		
		
		/// <summary>
		/// Transition from WaitingToStart to InProgress. You can call this manually, will also get called if ReadyToStartMatch returns true
		/// </summary>
		public virtual void StartMatch()
			=> E_AGameMode_StartMatch(this);
		
		public virtual void StartNewPlayer(APlayerController newPlayer)
			=> E_AGameMode_StartNewPlayer(this, newPlayer);
		
		public string StaticGetFullGameClassName(string str)
			=> E_AGameMode_StaticGetFullGameClassName(this, str);
		
		#endregion
		
		public static implicit operator IntPtr(AGameMode self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AGameMode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AGameMode>(PtrDesc);
		}}}
