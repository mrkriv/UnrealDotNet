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
		/// <para>Add a player to the admin list of this session </para>
		/// <param name="AdminPlayer">player to add to the list </param>
		/// </summary>
		public override void AddAdmin(APlayerController adminPlayer) { }
		
		
		/// <summary>
		/// <para>Dump session info to log for debugging. </para>
		/// </summary>
		public override void DumpSessionState() { }
		
		
		/// <summary>
		/// <para>Handle when the match has completed </para>
		/// </summary>
		public override void HandleMatchHasEnded() { }
		
		
		/// <summary>
		/// <para>Handle when the match has started </para>
		/// </summary>
		public override void HandleMatchHasStarted() { }
		
		
		/// <summary>
		/// <para>Handle when the match enters waiting to start </para>
		/// </summary>
		public override void HandleMatchIsWaitingToStart() { }
		
		
		/// <summary>
		/// <para>Initialize options based on passed in options string </para>
		/// </summary>
		public override void InitOptions(string options) { }
		
		
		/// <summary>
		/// <para>Called when a PlayerController logs out of game. </para>
		/// <param name="PC">player controller currently logging out </param>
		/// </summary>
		public override void NotifyLogout(APlayerController pC) { }
		
		
		/// <summary>
		/// <para>Delegate triggered on auto login completion </para>
		/// </summary>
		public override void OnAutoLoginComplete(int localUserNum, bool bWasSuccessful, string error) { }
		
		
		/// <summary>
		/// <para>Called by GameMode::PostLogin to give session code chance to do work after PostLogin </para>
		/// <param name="NewPlayer">player logging in </param>
		/// </summary>
		public override void PostLogin(APlayerController newPlayer) { }
		
		
		/// <summary>
		/// <para>called after a seamless level transition has been completed on the *new* GameMode </para>
		/// <para>used to reinitialize players already in the game as they won't have *Login() called on them </para>
		/// </summary>
		public override void PostSeamlessTravel() { }
		
		
		/// <summary>
		/// <para>Allow a dedicated server a chance to register itself with an online service </para>
		/// </summary>
		public override void RegisterServer() { }
		
		
		/// <summary>
		/// <para>Callback when autologin was expected but failed </para>
		/// </summary>
		public override void RegisterServerFailed() { }
		
		
		/// <summary>
		/// <para>Remove a player from the admin list of this session </para>
		/// <param name="AdminPlayer">player to remove from the list </param>
		/// </summary>
		public override void RemoveAdmin(APlayerController adminPlayer) { }
		
		
		/// <summary>
		/// <para>Restart the session </para>
		/// </summary>
		public override void Restart() { }
		
		
		/// <summary>
		/// <para>Gracefully tell all clients then local players to return to lobby </para>
		/// </summary>
		public override void ReturnToMainMenuHost() { }
		
		
		/// <summary>
		/// <para>Unregister a player from the online service session </para>
		/// <param name="ExitingPlayer">the player to unregister </param>
		/// </summary>
		public override void UnregisterPlayer(APlayerController exitingPlayer) { }
		
		
		/// <summary>
		/// <para>Update session join parameters </para>
		/// <param name="SessionName">name of session to update </param>
		/// <param name="bPublicSearchable">can the game be found via matchmaking </param>
		/// <param name="bAllowInvites">can you invite friends </param>
		/// <param name="bJoinViaPresence">anyone who can see you can join the game </param>
		/// <param name="bJoinViaPresenceFriendsOnly">can only friends actively join your game </param>
		/// </summary>
		public override void UpdateSessionJoinability(string inSessionName, bool bPublicSearchable, bool bAllowInvites, bool bJoinViaPresence, bool bJoinViaPresenceFriendsOnly) { }
		
		public static implicit operator IntPtr(ManageGameSession self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageGameSession(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameSession>(PtrDesc);
		}}}
