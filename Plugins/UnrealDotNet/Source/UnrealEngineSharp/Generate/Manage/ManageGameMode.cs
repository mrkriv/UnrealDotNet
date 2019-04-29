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
	public partial class ManageGameMode : AGameMode
	{
		public ManageGameMode(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Report that a match has failed due to unrecoverable error
		/// </summary>
		public override void AbortMatch() { }
		
		
		/// <summary>
		/// Add PlayerState to the inactive list, remove from the active list
		/// </summary>
		public override void AddInactivePlayer(APlayerState playerState, APlayerController pC) { }
		
		
		/// <summary>
		/// Broadcast a string to all players.
		/// </summary>
		public override void Broadcast(AActor sender, string msg, string type) { }
		
		
		/// <summary>
		/// Transition from InProgress to WaitingPostMatch. You can call this manually, will also get called if ReadyToEndMatch returns true
		/// </summary>
		public override void EndMatch() { }
		
		
		/// <summary>
		/// Called when the match transitions to LeavingMap
		/// </summary>
		protected override void HandleLeavingMap() { }
		
		
		/// <summary>
		/// Called when the match transitions to Aborted
		/// </summary>
		protected override void HandleMatchAborted() { }
		
		
		/// <summary>
		/// Called when the map transitions to WaitingPostMatch
		/// </summary>
		protected override void HandleMatchHasEnded() { }
		
		
		/// <summary>
		/// Called when the state transitions to InProgress
		/// </summary>
		protected override void HandleMatchHasStarted() { }
		
		
		/// <summary>
		/// Called when the state transitions to WaitingToStart
		/// </summary>
		protected override void HandleMatchIsWaitingToStart() { }
		
		
		/// <summary>
		/// Called when this PC is in cinematic mode, and its matinee is canceled by the user.
		/// </summary>
		public override void MatineeCancelled() { }
		
		
		/// <summary>
		/// Overridable virtual function to dispatch the appropriate transition functions before GameState and Blueprints get SetMatchState calls.
		/// </summary>
		protected override void OnMatchStateSet() { }
		
		
		/// <summary>
		/// Override PC's PlayerState with the values in OldPlayerState as part of the inactive player handling
		/// </summary>
		public override void OverridePlayerState(APlayerController pC, APlayerState oldPlayerState) { }
		
		
		/// <summary>
		/// Called from CommitMapChange after unloading previous level and loading new level+sublevels. Used for asynchronous level streaming
		/// </summary>
		public override void PostCommitMapChange() { }
		
		
		/// <summary>
		/// Called from CommitMapChange before unloading previous level. Used for asynchronous level streaming
		/// </summary>
		/// <param name="previousMapName">Name of the previous persistent level</param>
		/// <param name="nextMapName">Name of the persistent level being streamed to</param>
		public override void PreCommitMapChange(string previousMapName, string nextMapName) { }
		
		
		/// <summary>
		/// Restart the game, by default travel to the current map
		/// </summary>
		public override void RestartGame() { }
		
		
		/// <summary>
		/// Exec command to broadcast a string to all players
		/// </summary>
		public override void Say(string msg) { }
		
		public override void SendPlayer(APlayerController aPlayer, string uRL) { }
		
		public override void SetBandwidthLimit(float asyncIOBandwidthLimit) { }
		
		
		/// <summary>
		/// Updates the match state and calls the appropriate transition functions
		/// </summary>
		protected override void SetMatchState(string newState) { }
		
		
		/// <summary>
		/// SetViewTarget of player control on server change
		/// </summary>
		public override void SetSeamlessTravelViewTarget(APlayerController pC) { }
		
		
		/// <summary>
		/// Transition from WaitingToStart to InProgress. You can call this manually, will also get called if ReadyToStartMatch returns true
		/// </summary>
		public override void StartMatch() { }
		
		public override void StartNewPlayer(APlayerController newPlayer) { }
		
		public static implicit operator IntPtr(ManageGameMode self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameMode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameMode>(PtrDesc);
		}}}
