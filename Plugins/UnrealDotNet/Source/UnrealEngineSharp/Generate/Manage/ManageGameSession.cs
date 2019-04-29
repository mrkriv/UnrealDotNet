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
	[ManageType("ManageGameSession")]
	public partial class ManageGameSession : AGameSession
	{
		public ManageGameSession(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Add a player to the admin list of this session
		/// </summary>
		/// <param name="adminPlayer">player to add to the list</param>
		public override void AddAdmin(APlayerController adminPlayer) { }
		
		
		/// <summary>
		/// Dump session info to log for debugging.
		/// </summary>
		public override void DumpSessionState() { }
		
		
		/// <summary>
		/// Handle when the match has completed
		/// </summary>
		public override void HandleMatchHasEnded() { }
		
		
		/// <summary>
		/// Handle when the match has started
		/// </summary>
		public override void HandleMatchHasStarted() { }
		
		
		/// <summary>
		/// Handle when the match enters waiting to start
		/// </summary>
		public override void HandleMatchIsWaitingToStart() { }
		
		
		/// <summary>
		/// Initialize options based on passed in options string
		/// </summary>
		public override void InitOptions(string options) { }
		
		
		/// <summary>
		/// Called when a PlayerController logs out of game.
		/// </summary>
		/// <param name="pC">player controller currently logging out</param>
		public override void NotifyLogout(APlayerController pC) { }
		
		
		/// <summary>
		/// Delegate triggered on auto login completion
		/// </summary>
		public override void OnAutoLoginComplete(int localUserNum, bool bWasSuccessful, string error) { }
		
		
		/// <summary>
		/// Called by GameMode::PostLogin to give session code chance to do work after PostLogin
		/// </summary>
		/// <param name="newPlayer">player logging in</param>
		public override void PostLogin(APlayerController newPlayer) { }
		
		
		/// <summary>
		/// called after a seamless level transition has been completed on the *new* GameMode
		/// <para>used to reinitialize players already in the game as they won't have *Login() called on them </para>
		/// </summary>
		public override void PostSeamlessTravel() { }
		
		
		/// <summary>
		/// Allow a dedicated server a chance to register itself with an online service
		/// </summary>
		public override void RegisterServer() { }
		
		
		/// <summary>
		/// Callback when autologin was expected but failed
		/// </summary>
		public override void RegisterServerFailed() { }
		
		
		/// <summary>
		/// Remove a player from the admin list of this session
		/// </summary>
		/// <param name="adminPlayer">player to remove from the list</param>
		public override void RemoveAdmin(APlayerController adminPlayer) { }
		
		
		/// <summary>
		/// Restart the session
		/// </summary>
		public override void Restart() { }
		
		
		/// <summary>
		/// Gracefully tell all clients then local players to return to lobby
		/// </summary>
		public override void ReturnToMainMenuHost() { }
		
		
		/// <summary>
		/// Unregister a player from the online service session
		/// </summary>
		/// <param name="exitingPlayer">the player to unregister</param>
		public override void UnregisterPlayer(APlayerController exitingPlayer) { }
		
		
		/// <summary>
		/// Update session join parameters
		/// </summary>
		/// <param name="sessionName">name of session to update</param>
		/// <param name="bPublicSearchable">can the game be found via matchmaking</param>
		/// <param name="bAllowInvites">can you invite friends</param>
		/// <param name="bJoinViaPresence">anyone who can see you can join the game</param>
		/// <param name="bJoinViaPresenceFriendsOnly">can only friends actively join your game</param>
		public override void UpdateSessionJoinability(string inSessionName, bool bPublicSearchable, bool bAllowInvites, bool bJoinViaPresence, bool bJoinViaPresenceFriendsOnly) { }
		
		public static implicit operator IntPtr(ManageGameSession self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameSession(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameSession>(PtrDesc);
		}}}
