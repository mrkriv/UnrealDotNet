// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameSession.h:27

namespace UnrealEngine
{
	public  partial class AGameSession : AInfo
	{
		public AGameSession(IntPtr Adress)
			: base(Adress)
		{
		}

		public AGameSession(UObject Parent = null, string Name = "GameSession")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AGameSession(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_AGameSession_bRequiresPushToTalk_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameSession_bRequiresPushToTalk_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameSession_MaxPartySize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameSession_MaxPartySize_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameSession_MaxPlayers_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameSession_MaxPlayers_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameSession_MaxSpectators_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameSession_MaxSpectators_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_AGameSession_MaxSplitscreensPerConnection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameSession_MaxSplitscreensPerConnection_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_AGameSession_SessionName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameSession_SessionName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AGameSession(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_AddAdmin(IntPtr self, IntPtr adminPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AGameSession_ApproveLogin(IntPtr self, string options);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameSession_AtCapacity(IntPtr self, bool bSpectator);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameSession_BanPlayer(IntPtr self, IntPtr bannedPlayer, string banReason);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameSession_CanRestartGame(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_DumpSessionState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_AGameSession_GetNextPlayerID(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_HandleMatchHasEnded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_HandleMatchHasStarted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_HandleMatchIsWaitingToStart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameSession_HandleStartMatchRequest(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_InitOptions(IntPtr self, string options);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameSession_KickPlayer(IntPtr self, IntPtr kickedPlayer, string kickReason);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_NotifyLogout(IntPtr self, IntPtr pC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_OnAutoLoginComplete(IntPtr self, int localUserNum, bool bWasSuccessful, string error);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_PostLogin(IntPtr self, IntPtr newPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_PostSeamlessTravel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameSession_ProcessAutoLogin(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_RegisterServer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_RegisterServerFailed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_RemoveAdmin(IntPtr self, IntPtr adminPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameSession_RequiresPushToTalk(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_Restart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_ReturnToMainMenuHost(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_UnregisterPlayer(IntPtr self, IntPtr exitingPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameSession_UpdateSessionJoinability(IntPtr self, string inSessionName, bool bPublicSearchable, bool bAllowInvites, bool bJoinViaPresence, bool bJoinViaPresenceFriendsOnly);
		
		#endregion
		
		#region Property
		public bool bRequiresPushToTalk
		{
			get => E_PROP_AGameSession_bRequiresPushToTalk_GET(NativePointer);
			set => E_PROP_AGameSession_bRequiresPushToTalk_SET(NativePointer, value);
		}

		public int MaxPartySize
		{
			get => E_PROP_AGameSession_MaxPartySize_GET(NativePointer);
			set => E_PROP_AGameSession_MaxPartySize_SET(NativePointer, value);
		}

		public int MaxPlayers
		{
			get => E_PROP_AGameSession_MaxPlayers_GET(NativePointer);
			set => E_PROP_AGameSession_MaxPlayers_SET(NativePointer, value);
		}

		public int MaxSpectators
		{
			get => E_PROP_AGameSession_MaxSpectators_GET(NativePointer);
			set => E_PROP_AGameSession_MaxSpectators_SET(NativePointer, value);
		}

		public byte MaxSplitscreensPerConnection
		{
			get => E_PROP_AGameSession_MaxSplitscreensPerConnection_GET(NativePointer);
			set => E_PROP_AGameSession_MaxSplitscreensPerConnection_SET(NativePointer, value);
		}

		public string SessionName
		{
			get => E_PROP_AGameSession_SessionName_GET(NativePointer);
			set => E_PROP_AGameSession_SessionName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add a player to the admin list of this session </para>
		/// <param name="AdminPlayer">player to add to the list </param>
		/// </summary>
		public virtual void AddAdmin(APlayerController adminPlayer)
			=> E_AGameSession_AddAdmin(this, adminPlayer);
		
		
		/// <summary>
		/// <para>Called from GameMode.PreLogin() and Login(). </para>
		/// <param name="Options">The URL options (e.g. name/spectator) the player has passed </param>
		/// <return>Non-empty Error String if player not approved </return>
		/// </summary>
		public virtual string ApproveLogin(string options)
			=> E_AGameSession_ApproveLogin(this, options);
		
		
		/// <summary>
		/// <return>true if there is no room on the server for an additional player </return>
		/// </summary>
		public virtual bool AtCapacity(bool bSpectator)
			=> E_AGameSession_AtCapacity(this, bSpectator);
		
		
		/// <summary>
		/// <para>Forcibly remove player from the server and ban them permanently </para>
		/// <param name="BannedPlayer">player to ban </param>
		/// <param name="KickReason">text reason to display to player </param>
		/// <return>true if player was able to be banned, false otherwise </return>
		/// </summary>
		public virtual bool BanPlayer(APlayerController bannedPlayer, string banReason)
			=> E_AGameSession_BanPlayer(this, bannedPlayer, banReason);
		
		
		/// <summary>
		/// <para>Called from GameMode.RestartGame(). </para>
		/// </summary>
		public virtual bool CanRestartGame()
			=> E_AGameSession_CanRestartGame(this);
		
		
		/// <summary>
		/// <para>Dump session info to log for debugging. </para>
		/// </summary>
		public virtual void DumpSessionState()
			=> E_AGameSession_DumpSessionState(this);
		
		
		/// <summary>
		/// <return>A new unique player ID </return>
		/// </summary>
		public int GetNextPlayerID()
			=> E_AGameSession_GetNextPlayerID(this);
		
		
		/// <summary>
		/// <para>Handle when the match has completed </para>
		/// </summary>
		public virtual void HandleMatchHasEnded()
			=> E_AGameSession_HandleMatchHasEnded(this);
		
		
		/// <summary>
		/// <para>Handle when the match has started </para>
		/// </summary>
		public virtual void HandleMatchHasStarted()
			=> E_AGameSession_HandleMatchHasStarted(this);
		
		
		/// <summary>
		/// <para>Handle when the match enters waiting to start </para>
		/// </summary>
		public virtual void HandleMatchIsWaitingToStart()
			=> E_AGameSession_HandleMatchIsWaitingToStart(this);
		
		
		/// <summary>
		/// <para>@RETURNS true if GameSession handled the request, in case it wants to stall for some reason. Otherwise, game mode will start immediately </para>
		/// </summary>
		public virtual bool HandleStartMatchRequest()
			=> E_AGameSession_HandleStartMatchRequest(this);
		
		
		/// <summary>
		/// <para>Initialize options based on passed in options string </para>
		/// </summary>
		public virtual void InitOptions(string options)
			=> E_AGameSession_InitOptions(this, options);
		
		
		/// <summary>
		/// <para>Forcibly remove player from the server </para>
		/// <param name="KickedPlayer">player to kick </param>
		/// <param name="KickReason">text reason to display to player </param>
		/// <return>true if player was able to be kicked, false otherwise </return>
		/// </summary>
		public virtual bool KickPlayer(APlayerController kickedPlayer, string kickReason)
			=> E_AGameSession_KickPlayer(this, kickedPlayer, kickReason);
		
		
		/// <summary>
		/// <para>Called when a PlayerController logs out of game. </para>
		/// <param name="PC">player controller currently logging out </param>
		/// </summary>
		public virtual void NotifyLogout(APlayerController pC)
			=> E_AGameSession_NotifyLogout(this, pC);
		
		
		/// <summary>
		/// <para>Delegate triggered on auto login completion </para>
		/// </summary>
		public virtual void OnAutoLoginComplete(int localUserNum, bool bWasSuccessful, string error)
			=> E_AGameSession_OnAutoLoginComplete(this, localUserNum, bWasSuccessful, error);
		
		
		/// <summary>
		/// <para>Called by GameMode::PostLogin to give session code chance to do work after PostLogin </para>
		/// <param name="NewPlayer">player logging in </param>
		/// </summary>
		public virtual void PostLogin(APlayerController newPlayer)
			=> E_AGameSession_PostLogin(this, newPlayer);
		
		
		/// <summary>
		/// <para>called after a seamless level transition has been completed on the *new* GameMode </para>
		/// <para>used to reinitialize players already in the game as they won't have *Login() called on them </para>
		/// </summary>
		public virtual void PostSeamlessTravel()
			=> E_AGameSession_PostSeamlessTravel(this);
		
		
		/// <summary>
		/// <para>Allow an online service to process a login if specified on the commandline with -auth_login/-auth_password </para>
		/// <return>true if login is in progress, false otherwise </return>
		/// </summary>
		public virtual bool ProcessAutoLogin()
			=> E_AGameSession_ProcessAutoLogin(this);
		
		
		/// <summary>
		/// <para>Allow a dedicated server a chance to register itself with an online service </para>
		/// </summary>
		public virtual void RegisterServer()
			=> E_AGameSession_RegisterServer(this);
		
		
		/// <summary>
		/// <para>Callback when autologin was expected but failed </para>
		/// </summary>
		public virtual void RegisterServerFailed()
			=> E_AGameSession_RegisterServerFailed(this);
		
		
		/// <summary>
		/// <para>Remove a player from the admin list of this session </para>
		/// <param name="AdminPlayer">player to remove from the list </param>
		/// </summary>
		public virtual void RemoveAdmin(APlayerController adminPlayer)
			=> E_AGameSession_RemoveAdmin(this, adminPlayer);
		
		
		/// <summary>
		/// <para>Does the session require push to talk </para>
		/// <return>true if a push to talk keybinding is required or if voice is always enabled </return>
		/// </summary>
		public virtual bool RequiresPushToTalk()
			=> E_AGameSession_RequiresPushToTalk(this);
		
		
		/// <summary>
		/// <para>Restart the session </para>
		/// </summary>
		public virtual void Restart()
			=> E_AGameSession_Restart(this);
		
		
		/// <summary>
		/// <para>Gracefully tell all clients then local players to return to lobby </para>
		/// </summary>
		public virtual void ReturnToMainMenuHost()
			=> E_AGameSession_ReturnToMainMenuHost(this);
		
		
		/// <summary>
		/// <para>Unregister a player from the online service session </para>
		/// <param name="ExitingPlayer">the player to unregister </param>
		/// </summary>
		public virtual void UnregisterPlayer(APlayerController exitingPlayer)
			=> E_AGameSession_UnregisterPlayer(this, exitingPlayer);
		
		
		/// <summary>
		/// <para>Update session join parameters </para>
		/// <param name="SessionName">name of session to update </param>
		/// <param name="bPublicSearchable">can the game be found via matchmaking </param>
		/// <param name="bAllowInvites">can you invite friends </param>
		/// <param name="bJoinViaPresence">anyone who can see you can join the game </param>
		/// <param name="bJoinViaPresenceFriendsOnly">can only friends actively join your game </param>
		/// </summary>
		public virtual void UpdateSessionJoinability(string inSessionName, bool bPublicSearchable, bool bAllowInvites, bool bJoinViaPresence, bool bJoinViaPresenceFriendsOnly)
			=> E_AGameSession_UpdateSessionJoinability(this, inSessionName, bPublicSearchable, bAllowInvites, bJoinViaPresence, bJoinViaPresenceFriendsOnly);
		
		#endregion
		
		public static implicit operator IntPtr(AGameSession self)
		{
			return self.NativePointer;
		}

		public static implicit operator AGameSession(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AGameSession>(PtrDesc);
		}}}
