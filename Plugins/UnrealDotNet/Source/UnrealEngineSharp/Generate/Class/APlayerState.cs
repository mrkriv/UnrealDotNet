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
		private static extern StringWrapper E_PROP_APlayerState_SavedNetworkAddress_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_APlayerState_SavedNetworkAddress_SET(IntPtr Ptr, string Value);
		
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
		/// <para>client side flag - whether this player has been welcomed or not (player entered message) </para>
		/// </summary>
		public byte bHasBeenWelcomed
		{
			get => E_PROP_APlayerState_bHasBeenWelcomed_GET(NativePointer);
			set => E_PROP_APlayerState_bHasBeenWelcomed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>True if this PlayerState is associated with an AIController </para>
		/// </summary>
		public byte bIsABot
		{
			get => E_PROP_APlayerState_bIsABot_GET(NativePointer);
			set => E_PROP_APlayerState_bIsABot_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Means this PlayerState came from the GameMode's InactivePlayerArray </para>
		/// </summary>
		public byte bIsInactive
		{
			get => E_PROP_APlayerState_bIsInactive_GET(NativePointer);
			set => E_PROP_APlayerState_bIsInactive_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Whether this player is currently a spectator </para>
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
		/// <para>if set, GetPlayerName() will call virtual GetPlayerNameCustom() to allow custom access </para>
		/// </summary>
		public byte bUseCustomPlayerNames
		{
			get => E_PROP_APlayerState_bUseCustomPlayerNames_GET(NativePointer);
			set => E_PROP_APlayerState_bUseCustomPlayerNames_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Exact ping as float (rounded and compressed in replicated Ping) </para>
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

		public string SavedNetworkAddress
		{
			get => E_PROP_APlayerState_SavedNetworkAddress_GET(NativePointer);
			set => E_PROP_APlayerState_SavedNetworkAddress_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The session that the player needs to join/remove from as it is created/leaves </para>
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
		/// <para>Called by Controller when its PlayerState is initially replicated. </para>
		/// </summary>
		public virtual void ClientInitialize(AController c)
			=> E_APlayerState_ClientInitialize(this, c);
		
		
		/// <summary>
		/// <para>Copy properties which need to be saved in inactive PlayerState </para>
		/// </summary>
		protected virtual void CopyProperties(APlayerState playerState)
			=> E_APlayerState_CopyProperties(this, playerState);
		
		public void DispatchCopyProperties(APlayerState playerState)
			=> E_APlayerState_DispatchCopyProperties(this, playerState);
		
		
		/// <summary>
		/// <para>calls OverrideWith and triggers OnOverrideWith for BP extension </para>
		/// </summary>
		public void DispatchOverrideWith(APlayerState playerState)
			=> E_APlayerState_DispatchOverrideWith(this, playerState);
		
		
		/// <summary>
		/// <para>Create duplicate PlayerState (for saving Inactive PlayerState) </para>
		/// </summary>
		public virtual APlayerState Duplicate()
			=> E_APlayerState_Duplicate(this);
		
		
		/// <summary>
		/// <para>returns previous player name </para>
		/// </summary>
		public virtual string GetOldPlayerName()
			=> E_APlayerState_GetOldPlayerName(this);
		
		
		/// <summary>
		/// <para>Return the pawn controlled by this Player State. </para>
		/// </summary>
		public APawn GetPawn()
			=> E_APlayerState_GetPawn(this);
		
		
		/// <summary>
		/// <para>returns current player name </para>
		/// </summary>
		public string GetPlayerName()
			=> E_APlayerState_GetPlayerName(this);
		
		
		/// <summary>
		/// <para>custom access to player name, called only when bUseCustomPlayerNames is set </para>
		/// </summary>
		public virtual string GetPlayerNameCustom()
			=> E_APlayerState_GetPlayerNameCustom(this);
		
		
		/// <summary>
		/// <para>called after receiving player name </para>
		/// </summary>
		protected virtual void HandleWelcomeMessage()
			=> E_APlayerState_HandleWelcomeMessage(this);
		
		
		/// <summary>
		/// <para>return true if PlayerState is primary (ie. non-splitscreen) player </para>
		/// </summary>
		public virtual bool IsPrimaryPlayer()
			=> E_APlayerState_IsPrimaryPlayer(this);
		
		
		/// <summary>
		/// <para>Called on the server when the owning player has disconnected, by default this method destroys this player state </para>
		/// </summary>
		public virtual void OnDeactivated()
			=> E_APlayerState_OnDeactivated(this);
		
		
		/// <summary>
		/// <para>Called on the server when the owning player has reconnected and this player state is added to the active players array </para>
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
		/// <para>Recalculates the replicated Ping value once per second (both clientside and serverside), based upon collected ping data </para>
		/// </summary>
		public virtual void RecalculateAvgPing()
			=> E_APlayerState_RecalculateAvgPing(this);
		
		protected void ReceiveCopyProperties(APlayerState newPlayerState)
			=> E_APlayerState_ReceiveCopyProperties(this, newPlayerState);
		
		protected void ReceiveOverrideWith(APlayerState oldPlayerState)
			=> E_APlayerState_ReceiveOverrideWith(this, oldPlayerState);
		
		
		/// <summary>
		/// <para>Register a player with the online subsystem </para>
		/// <param name="bWasFromInvite">was this player invited directly </param>
		/// </summary>
		public virtual void RegisterPlayerWithSession(bool bWasFromInvite)
			=> E_APlayerState_RegisterPlayerWithSession(this, bWasFromInvite);
		
		
		/// <summary>
		/// <para>called by seamless travel when initializing a player on the other side - copy properties to the new PlayerState that should persist </para>
		/// </summary>
		public virtual void SeamlessTravelTo(APlayerState newPlayerState)
			=> E_APlayerState_SeamlessTravelTo(this, newPlayerState);
		
		
		/// <summary>
		/// <para>set the player name to S </para>
		/// </summary>
		public virtual void SetOldPlayerName(string s)
			=> E_APlayerState_SetOldPlayerName(this, s);
		
		
		/// <summary>
		/// <para>set the player name to S </para>
		/// </summary>
		public virtual void SetPlayerName(string s)
			=> E_APlayerState_SetPlayerName(this, s);
		
		
		/// <summary>
		/// <para>set the player name to S locally, does not trigger net updates </para>
		/// </summary>
		public virtual void SetPlayerNameInternal(string s)
			=> E_APlayerState_SetPlayerNameInternal(this, s);
		
		
		/// <summary>
		/// <para>Sets whether or not the replicated ping value is updated automatically. </para>
		/// </summary>
		protected void SetShouldUpdateReplicatedPing(bool bInShouldUpdateReplicatedPing)
			=> E_APlayerState_SetShouldUpdateReplicatedPing(this, bInShouldUpdateReplicatedPing);
		
		
		/// <summary>
		/// <para>Returns true if should broadcast player welcome/left messages. </para>
		/// <para>Current conditions: must be a human player a network game </para>
		/// </summary>
		public virtual bool ShouldBroadCastWelcomeMessage(bool bExiting)
			=> E_APlayerState_ShouldBroadCastWelcomeMessage(this, bExiting);
		
		
		/// <summary>
		/// <para>Unregister a player with the online subsystem </para>
		/// </summary>
		public virtual void UnregisterPlayerWithSession()
			=> E_APlayerState_UnregisterPlayerWithSession(this);
		
		
		/// <summary>
		/// <para>Receives ping updates for the client (both clientside and serverside), from the net driver </para>
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
