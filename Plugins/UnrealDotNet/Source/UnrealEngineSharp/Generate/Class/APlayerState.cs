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
	public  partial class APlayerState : AInfo
	{
		public APlayerState(IntPtr Adress)
			: base(Adress)
		{
		}

		public APlayerState(UObject Parent = null, string Name = "PlayerState")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_APlayerState(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APlayerState_bFromPreviousLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_bFromPreviousLevel_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APlayerState_bHasBeenWelcomed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_bHasBeenWelcomed_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APlayerState_bIsABot_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_bIsABot_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APlayerState_bIsInactive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_bIsInactive_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APlayerState_bIsSpectator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_bIsSpectator_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APlayerState_bOnlySpectator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_bOnlySpectator_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APlayerState_bUseCustomPlayerNames_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_bUseCustomPlayerNames_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerState_ExactPing_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_ExactPing_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerState_ExactPingV2_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_ExactPingV2_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_APlayerState_OldName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_OldName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_APlayerState_Ping_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_Ping_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_APlayerState_PlayerId_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_PlayerId_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_APlayerState_PlayerName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_PlayerName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_APlayerState_SavedNetworkAddress_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_SavedNetworkAddress_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_APlayerState_Score_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_Score_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_APlayerState_SessionName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_SessionName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_APlayerState_StartTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_StartTime_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_APlayerState(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_ClientInitialize(IntPtr self, IntPtr c);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_CopyProperties(IntPtr self, IntPtr playerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_DispatchCopyProperties(IntPtr self, IntPtr playerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_DispatchOverrideWith(IntPtr self, IntPtr playerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APlayerState_Duplicate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_APlayerState_GetOldPlayerName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_APlayerState_GetPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_APlayerState_GetPlayerName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_APlayerState_GetPlayerNameCustom(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_HandleWelcomeMessage(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerState_IsPrimaryPlayer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_OnDeactivated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_OnReactivated(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_OnRep_bIsInactive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_OnRep_PlayerId(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_OnRep_PlayerName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_OnRep_Score(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_OnRep_UniqueId(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_OverrideWith(IntPtr self, IntPtr playerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_RecalculateAvgPing(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_ReceiveCopyProperties(IntPtr self, IntPtr newPlayerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_ReceiveOverrideWith(IntPtr self, IntPtr oldPlayerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_RegisterPlayerWithSession(IntPtr self, bool bWasFromInvite);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_SeamlessTravelTo(IntPtr self, IntPtr newPlayerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_SetOldPlayerName(IntPtr self, string s);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_SetPlayerName(IntPtr self, string s);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_SetPlayerNameInternal(IntPtr self, string s);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_SetShouldUpdateReplicatedPing(IntPtr self, bool bInShouldUpdateReplicatedPing);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_APlayerState_ShouldBroadCastWelcomeMessage(IntPtr self, bool bExiting);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_UnregisterPlayerWithSession(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_APlayerState_UpdatePing(IntPtr self, float inPing);
		
		#endregion
		
		#region Property
		public byte bFromPreviousLevel
		{
			get => E_PROP_APlayerState_bFromPreviousLevel_GET(NativePointer);
			set => E_PROP_APlayerState_bFromPreviousLevel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// client side flag - whether this player has been welcomed or not (player entered message)
		/// </summary>
		public byte bHasBeenWelcomed
		{
			get => E_PROP_APlayerState_bHasBeenWelcomed_GET(NativePointer);
			set => E_PROP_APlayerState_bHasBeenWelcomed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// True if this PlayerState is associated with an AIController
		/// </summary>
		public byte bIsABot
		{
			get => E_PROP_APlayerState_bIsABot_GET(NativePointer);
			set => E_PROP_APlayerState_bIsABot_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Means this PlayerState came from the GameMode's InactivePlayerArray
		/// </summary>
		public byte bIsInactive
		{
			get => E_PROP_APlayerState_bIsInactive_GET(NativePointer);
			set => E_PROP_APlayerState_bIsInactive_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Whether this player is currently a spectator
		/// </summary>
		public byte bIsSpectator
		{
			get => E_PROP_APlayerState_bIsSpectator_GET(NativePointer);
			set => E_PROP_APlayerState_bIsSpectator_SET(NativePointer, value);
		}

		public byte bOnlySpectator
		{
			get => E_PROP_APlayerState_bOnlySpectator_GET(NativePointer);
			set => E_PROP_APlayerState_bOnlySpectator_SET(NativePointer, value);
		}

		
		/// <summary>
		/// if set, GetPlayerName() will call virtual GetPlayerNameCustom() to allow custom access
		/// </summary>
		public byte bUseCustomPlayerNames
		{
			get => E_PROP_APlayerState_bUseCustomPlayerNames_GET(NativePointer);
			set => E_PROP_APlayerState_bUseCustomPlayerNames_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Exact ping as float (rounded and compressed in replicated Ping)
		/// </summary>
		public float ExactPing
		{
			get => E_PROP_APlayerState_ExactPing_GET(NativePointer);
			set => E_PROP_APlayerState_ExactPing_SET(NativePointer, value);
		}

		public float ExactPingV2
		{
			get => E_PROP_APlayerState_ExactPingV2_GET(NativePointer);
			set => E_PROP_APlayerState_ExactPingV2_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Previous player name.  Saved on client-side to detect player name changes.
		/// </summary>
		public string OldName
		{
			get => E_PROP_APlayerState_OldName_GET(NativePointer);
			set => E_PROP_APlayerState_OldName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Replicated compressed ping for this player (holds ping in msec divided by 4)
		/// </summary>
		public byte Ping
		{
			get => E_PROP_APlayerState_Ping_GET(NativePointer);
			set => E_PROP_APlayerState_Ping_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Unique net id number. Actual value varies based on current online subsystem, use it only as a guaranteed unique number per player.
		/// </summary>
		public int PlayerId
		{
			get => E_PROP_APlayerState_PlayerId_GET(NativePointer);
			set => E_PROP_APlayerState_PlayerId_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Player name, or blank if none.
		/// </summary>
		public string PlayerName
		{
			get => E_PROP_APlayerState_PlayerName_GET(NativePointer);
			set => E_PROP_APlayerState_PlayerName_SET(NativePointer, value);
		}

		public string SavedNetworkAddress
		{
			get => E_PROP_APlayerState_SavedNetworkAddress_GET(NativePointer);
			set => E_PROP_APlayerState_SavedNetworkAddress_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Player's current score.
		/// </summary>
		public float Score
		{
			get => E_PROP_APlayerState_Score_GET(NativePointer);
			set => E_PROP_APlayerState_Score_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The session that the player needs to join/remove from as it is created/leaves
		/// </summary>
		public string SessionName
		{
			get => E_PROP_APlayerState_SessionName_GET(NativePointer);
			set => E_PROP_APlayerState_SessionName_SET(NativePointer, value);
		}

		public int StartTime
		{
			get => E_PROP_APlayerState_StartTime_GET(NativePointer);
			set => E_PROP_APlayerState_StartTime_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Called by Controller when its PlayerState is initially replicated.
		/// </summary>
		public virtual void ClientInitialize(AController c)
			=> E_APlayerState_ClientInitialize(this, c);
		
		
		/// <summary>
		/// Copy properties which need to be saved in inactive PlayerState
		/// </summary>
		protected virtual void CopyProperties(APlayerState playerState)
			=> E_APlayerState_CopyProperties(this, playerState);
		
		public void DispatchCopyProperties(APlayerState playerState)
			=> E_APlayerState_DispatchCopyProperties(this, playerState);
		
		
		/// <summary>
		/// calls OverrideWith and triggers OnOverrideWith for BP extension
		/// </summary>
		public void DispatchOverrideWith(APlayerState playerState)
			=> E_APlayerState_DispatchOverrideWith(this, playerState);
		
		
		/// <summary>
		/// Create duplicate PlayerState (for saving Inactive PlayerState)
		/// </summary>
		public virtual APlayerState Duplicate()
			=> E_APlayerState_Duplicate(this);
		
		
		/// <summary>
		/// returns previous player name
		/// </summary>
		public virtual string GetOldPlayerName()
			=> E_APlayerState_GetOldPlayerName(this);
		
		
		/// <summary>
		/// Return the pawn controlled by this Player State.
		/// </summary>
		public APawn GetPawn()
			=> E_APlayerState_GetPawn(this);
		
		
		/// <summary>
		/// returns current player name
		/// </summary>
		public string GetPlayerName()
			=> E_APlayerState_GetPlayerName(this);
		
		
		/// <summary>
		/// custom access to player name, called only when bUseCustomPlayerNames is set
		/// </summary>
		public virtual string GetPlayerNameCustom()
			=> E_APlayerState_GetPlayerNameCustom(this);
		
		
		/// <summary>
		/// called after receiving player name
		/// </summary>
		protected virtual void HandleWelcomeMessage()
			=> E_APlayerState_HandleWelcomeMessage(this);
		
		
		/// <summary>
		/// return true if PlayerState is primary (ie. non-splitscreen) player
		/// </summary>
		public virtual bool IsPrimaryPlayer()
			=> E_APlayerState_IsPrimaryPlayer(this);
		
		
		/// <summary>
		/// Called on the server when the owning player has disconnected, by default this method destroys this player state
		/// </summary>
		public virtual void OnDeactivated()
			=> E_APlayerState_OnDeactivated(this);
		
		
		/// <summary>
		/// Called on the server when the owning player has reconnected and this player state is added to the active players array
		/// </summary>
		public virtual void OnReactivated()
			=> E_APlayerState_OnReactivated(this);
		
		public virtual void OnRep_bIsInactive()
			=> E_APlayerState_OnRep_bIsInactive(this);
		
		public virtual void OnRep_PlayerId()
			=> E_APlayerState_OnRep_PlayerId(this);
		
		public virtual void OnRep_PlayerName()
			=> E_APlayerState_OnRep_PlayerName(this);
		
		public virtual void OnRep_Score()
			=> E_APlayerState_OnRep_Score(this);
		
		public virtual void OnRep_UniqueId()
			=> E_APlayerState_OnRep_UniqueId(this);
		
		protected virtual void OverrideWith(APlayerState playerState)
			=> E_APlayerState_OverrideWith(this, playerState);
		
		
		/// <summary>
		/// Recalculates the replicated Ping value once per second (both clientside and serverside), based upon collected ping data
		/// </summary>
		public virtual void RecalculateAvgPing()
			=> E_APlayerState_RecalculateAvgPing(this);
		
		protected void ReceiveCopyProperties(APlayerState newPlayerState)
			=> E_APlayerState_ReceiveCopyProperties(this, newPlayerState);
		
		protected void ReceiveOverrideWith(APlayerState oldPlayerState)
			=> E_APlayerState_ReceiveOverrideWith(this, oldPlayerState);
		
		
		/// <summary>
		/// Register a player with the online subsystem
		/// </summary>
		/// <param name="bWasFromInvite">was this player invited directly</param>
		public virtual void RegisterPlayerWithSession(bool bWasFromInvite)
			=> E_APlayerState_RegisterPlayerWithSession(this, bWasFromInvite);
		
		
		/// <summary>
		/// called by seamless travel when initializing a player on the other side - copy properties to the new PlayerState that should persist
		/// </summary>
		public virtual void SeamlessTravelTo(APlayerState newPlayerState)
			=> E_APlayerState_SeamlessTravelTo(this, newPlayerState);
		
		
		/// <summary>
		/// set the player name to S
		/// </summary>
		public virtual void SetOldPlayerName(string s)
			=> E_APlayerState_SetOldPlayerName(this, s);
		
		
		/// <summary>
		/// set the player name to S
		/// </summary>
		public virtual void SetPlayerName(string s)
			=> E_APlayerState_SetPlayerName(this, s);
		
		
		/// <summary>
		/// set the player name to S locally, does not trigger net updates
		/// </summary>
		public virtual void SetPlayerNameInternal(string s)
			=> E_APlayerState_SetPlayerNameInternal(this, s);
		
		
		/// <summary>
		/// Sets whether or not the replicated ping value is updated automatically.
		/// </summary>
		protected void SetShouldUpdateReplicatedPing(bool bInShouldUpdateReplicatedPing)
			=> E_APlayerState_SetShouldUpdateReplicatedPing(this, bInShouldUpdateReplicatedPing);
		
		
		/// <summary>
		/// Returns true if should broadcast player welcome/left messages.
		/// <para>Current conditions: must be a human player a network game </para>
		/// </summary>
		public virtual bool ShouldBroadCastWelcomeMessage(bool bExiting)
			=> E_APlayerState_ShouldBroadCastWelcomeMessage(this, bExiting);
		
		
		/// <summary>
		/// Unregister a player with the online subsystem
		/// </summary>
		public virtual void UnregisterPlayerWithSession()
			=> E_APlayerState_UnregisterPlayerWithSession(this);
		
		
		/// <summary>
		/// Receives ping updates for the client (both clientside and serverside), from the net driver
		/// <para>NOTE: This updates much more frequently clientside, thus the clientside ping will often be different to what the server displays </para>
		/// </summary>
		public virtual void UpdatePing(float inPing)
			=> E_APlayerState_UpdatePing(this, inPing);
		
		#endregion
		
		public static implicit operator IntPtr(APlayerState self)
		{
			return self.NativePointer;
		}

		public static implicit operator APlayerState(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<APlayerState>(PtrDesc);
		}}}
