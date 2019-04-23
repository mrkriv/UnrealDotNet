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
		/// <para>Called by Controller when its PlayerState is initially replicated. </para>
		/// </summary>
		public override void ClientInitialize(AController c) { }
		
		
		/// <summary>
		/// <para>Copy properties which need to be saved in inactive PlayerState </para>
		/// </summary>
		protected override void CopyProperties(APlayerState playerState) { }
		
		
		/// <summary>
		/// <para>called after receiving player name </para>
		/// </summary>
		protected override void HandleWelcomeMessage() { }
		
		
		/// <summary>
		/// <para>Called on the server when the owning player has disconnected, by default this method destroys this player state </para>
		/// </summary>
		public override void OnDeactivated() { }
		
		
		/// <summary>
		/// <para>Called on the server when the owning player has reconnected and this player state is added to the active players array </para>
		/// </summary>
		public override void OnReactivated() { }
		
		public override void OnRep_bIsInactive() { }
		
		public override void OnRep_PlayerId() { }
		
		public override void OnRep_PlayerName() { }
		
		public override void OnRep_Score() { }
		
		public override void OnRep_UniqueId() { }
		
		protected override void OverrideWith(APlayerState playerState) { }
		
		
		/// <summary>
		/// <para>Recalculates the replicated Ping value once per second (both clientside and serverside), based upon collected ping data </para>
		/// </summary>
		public override void RecalculateAvgPing() { }
		
		
		/// <summary>
		/// <para>Register a player with the online subsystem </para>
		/// <param name="bWasFromInvite">was this player invited directly </param>
		/// </summary>
		public override void RegisterPlayerWithSession(bool bWasFromInvite) { }
		
		
		/// <summary>
		/// <para>called by seamless travel when initializing a player on the other side - copy properties to the new PlayerState that should persist </para>
		/// </summary>
		public override void SeamlessTravelTo(APlayerState newPlayerState) { }
		
		
		/// <summary>
		/// <para>set the player name to S </para>
		/// </summary>
		public override void SetOldPlayerName(string s) { }
		
		
		/// <summary>
		/// <para>set the player name to S </para>
		/// </summary>
		public override void SetPlayerName(string s) { }
		
		
		/// <summary>
		/// <para>set the player name to S locally, does not trigger net updates </para>
		/// </summary>
		public override void SetPlayerNameInternal(string s) { }
		
		
		/// <summary>
		/// <para>Unregister a player with the online subsystem </para>
		/// </summary>
		public override void UnregisterPlayerWithSession() { }
		
		
		/// <summary>
		/// <para>Receives ping updates for the client (both clientside and serverside), from the net driver </para>
		/// <para>NOTE: This updates much more frequently clientside, thus the clientside ping will often be different to what the server displays </para>
		/// </summary>
		public override void UpdatePing(float inPing) { }
		
		public static implicit operator IntPtr(ManagePlayerState self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManagePlayerState(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayerState>(PtrDesc);
		}}}
