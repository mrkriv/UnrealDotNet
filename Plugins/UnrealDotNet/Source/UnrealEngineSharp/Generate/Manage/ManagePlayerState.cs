// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:64

namespace UnrealEngine
{
	[ManageType("ManagePlayerState")]
	public partial class ManagePlayerState : APlayerState
	{
		public ManagePlayerState(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Called by Controller when its PlayerState is initially replicated.
		/// </summary>
		public override void ClientInitialize(AController c) { }
		
		
		/// <summary>
		/// Copy properties which need to be saved in inactive PlayerState
		/// </summary>
		protected override void CopyProperties(APlayerState playerState) { }
		
		
		/// <summary>
		/// called after receiving player name
		/// </summary>
		protected override void HandleWelcomeMessage() { }
		
		
		/// <summary>
		/// Called on the server when the owning player has disconnected, by default this method destroys this player state
		/// </summary>
		public override void OnDeactivated() { }
		
		
		/// <summary>
		/// Called on the server when the owning player has reconnected and this player state is added to the active players array
		/// </summary>
		public override void OnReactivated() { }
		
		public override void OnRep_bIsInactive() { }
		
		public override void OnRep_PlayerId() { }
		
		public override void OnRep_PlayerName() { }
		
		public override void OnRep_Score() { }
		
		public override void OnRep_UniqueId() { }
		
		protected override void OverrideWith(APlayerState playerState) { }
		
		
		/// <summary>
		/// Recalculates the replicated Ping value once per second (both clientside and serverside), based upon collected ping data
		/// </summary>
		public override void RecalculateAvgPing() { }
		
		
		/// <summary>
		/// Register a player with the online subsystem
		/// </summary>
		/// <param name="bWasFromInvite">was this player invited directly</param>
		public override void RegisterPlayerWithSession(bool bWasFromInvite) { }
		
		
		/// <summary>
		/// called by seamless travel when initializing a player on the other side - copy properties to the new PlayerState that should persist
		/// </summary>
		public override void SeamlessTravelTo(APlayerState newPlayerState) { }
		
		
		/// <summary>
		/// set the player name to S
		/// </summary>
		public override void SetOldPlayerName(string s) { }
		
		
		/// <summary>
		/// set the player name to S
		/// </summary>
		public override void SetPlayerName(string s) { }
		
		
		/// <summary>
		/// set the player name to S locally, does not trigger net updates
		/// </summary>
		public override void SetPlayerNameInternal(string s) { }
		
		
		/// <summary>
		/// Unregister a player with the online subsystem
		/// </summary>
		public override void UnregisterPlayerWithSession() { }
		
		
		/// <summary>
		/// Receives ping updates for the client (both clientside and serverside), from the net driver
		/// <para>NOTE: This updates much more frequently clientside, thus the clientside ping will often be different to what the server displays </para>
		/// </summary>
		public override void UpdatePing(float inPing) { }
		
		public static implicit operator IntPtr(ManagePlayerState self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManagePlayerState(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayerState>(PtrDesc);
		}}}
