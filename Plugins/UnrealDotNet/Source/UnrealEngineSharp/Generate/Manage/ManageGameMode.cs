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
		/// <para>Add PlayerState to the inactive list, remove from the active list </para>
		/// </summary>
		public override void AddInactivePlayer(APlayerState playerState, APlayerController pC) { }
		
		
		/// <summary>
		/// <para>Broadcast a string to all players. </para>
		/// </summary>
		public override void Broadcast(AActor sender, string msg, string type) { }
		
		
		/// <summary>
		/// <para>Called when the match transitions to LeavingMap </para>
		/// </summary>
		protected override void HandleLeavingMap() { }
		
		
		/// <summary>
		/// <para>Called when the match transitions to Aborted </para>
		/// </summary>
		protected override void HandleMatchAborted() { }
		
		
		/// <summary>
		/// <para>Called when the map transitions to WaitingPostMatch </para>
		/// </summary>
		protected override void HandleMatchHasEnded() { }
		
		
		/// <summary>
		/// <para>Called when the state transitions to InProgress </para>
		/// </summary>
		protected override void HandleMatchHasStarted() { }
		
		
		/// <summary>
		/// <para>Called when the state transitions to WaitingToStart </para>
		/// </summary>
		protected override void HandleMatchIsWaitingToStart() { }
		
		
		/// <summary>
		/// <para>Called when this PC is in cinematic mode, and its matinee is canceled by the user. </para>
		/// </summary>
		public override void MatineeCancelled() { }
		
		
		/// <summary>
		/// <para>Overridable virtual function to dispatch the appropriate transition functions before GameState and Blueprints get SetMatchState calls. </para>
		/// </summary>
		protected override void OnMatchStateSet() { }
		
		
		/// <summary>
		/// <para>Override PC's PlayerState with the values in OldPlayerState as part of the inactive player handling </para>
		/// </summary>
		public override void OverridePlayerState(APlayerController pC, APlayerState oldPlayerState) { }
		
		
		/// <summary>
		/// <para>Called from CommitMapChange after unloading previous level and loading new level+sublevels. Used for asynchronous level streaming </para>
		/// </summary>
		public override void PostCommitMapChange() { }
		
		
		/// <summary>
		/// <para>Called from CommitMapChange before unloading previous level. Used for asynchronous level streaming </para>
		/// <param name="PreviousMapName">Name of the previous persistent level </param>
		/// <param name="NextMapName">Name of the persistent level being streamed to </param>
		/// </summary>
		public override void PreCommitMapChange(string previousMapName, string nextMapName) { }
		
		
		/// <summary>
		/// <para>Exec command to broadcast a string to all players </para>
		/// </summary>
		public override void Say(string msg) { }
		
		public override void SendPlayer(APlayerController aPlayer, string uRL) { }
		
		public override void SetBandwidthLimit(float asyncIOBandwidthLimit) { }
		
		
		/// <summary>
		/// <para>Updates the match state and calls the appropriate transition functions </para>
		/// </summary>
		protected override void SetMatchState(string newState) { }
		
		
		/// <summary>
		/// <para>SetViewTarget of player control on server change </para>
		/// </summary>
		public override void SetSeamlessTravelViewTarget(APlayerController pC) { }
		
		public override void StartNewPlayer(APlayerController newPlayer) { }
		
		public static implicit operator IntPtr(ManageGameMode self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageGameMode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameMode>(PtrDesc);
		}}}
