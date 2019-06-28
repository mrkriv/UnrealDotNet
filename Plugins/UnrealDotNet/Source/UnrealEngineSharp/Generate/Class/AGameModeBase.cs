// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameModeBase.h:46

namespace UnrealEngine
{
	public partial class AGameModeBase : AInfo
	{
		public AGameModeBase(IntPtr adress)
			: base(adress)
		{
		}

		public AGameModeBase(UObject Parent = null, string Name = "GameModeBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AGameModeBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_AGameModeBase_DefaultPlayerName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameModeBase_DefaultPlayerName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_AGameModeBase_GameSession_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameModeBase_GameSession_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_AGameModeBase_GameState_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameModeBase_GameState_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_AGameModeBase_OptionsString_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameModeBase_OptionsString_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AGameModeBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_AllowCheats(IntPtr self, IntPtr p);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_AllowPausing(IntPtr self, IntPtr pC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_CanServerTravel(IntPtr self, string uRL, bool bAbsolute);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_CanSpectate(IntPtr self, IntPtr viewer, IntPtr viewTarget);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_ChangeName(IntPtr self, IntPtr controller, string newName, bool bNameChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AGameModeBase_ChoosePlayerStart(IntPtr self, IntPtr player);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_ClearPause(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AGameModeBase_FindPlayerStart(IntPtr self, IntPtr player, string incomingName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_FinishRestartPlayer(IntPtr self, IntPtr newPlayer, IntPtr startRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_ForceClearUnpauseDelegates(IntPtr self, IntPtr pauseActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_GenericPlayerInitialization(IntPtr self, IntPtr c);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_AGameModeBase_GetNumPlayers(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_AGameModeBase_GetNumSpectators(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_HandleStartingNewPlayer(IntPtr self, IntPtr newPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_HasMatchStarted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_InitGame(IntPtr self, string mapName, string options, string errorMessage);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_InitGameState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_InitializeHUDForPlayer(IntPtr self, IntPtr newPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_InitSeamlessTravelPlayer(IntPtr self, IntPtr newController);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_InitStartSpot(IntPtr self, IntPtr startSpot, IntPtr newPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_IsHandlingReplays(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_IsPaused(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AGameModeBase_K2_FindPlayerStart(IntPtr self, IntPtr player, string incomingName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_K2_OnChangeName(IntPtr self, IntPtr other, string newName, bool bNameChange);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_K2_OnLogout(IntPtr self, IntPtr exitingController);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_K2_OnRestartPlayer(IntPtr self, IntPtr newPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_K2_OnSwapPlayerControllers(IntPtr self, IntPtr oldPC, IntPtr newPC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_K2_PostLogin(IntPtr self, IntPtr newPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_Logout(IntPtr self, IntPtr exiting);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_MustSpectate(IntPtr self, IntPtr newPlayerController);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_PlayerCanRestart(IntPtr self, IntPtr player);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_PostLogin(IntPtr self, IntPtr newPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_PostSeamlessTravel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_ProcessServerTravel(IntPtr self, string uRL, bool bAbsolute);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_ReplicateStreamingStatus(IntPtr self, IntPtr pC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_ResetLevel(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_RestartPlayer(IntPtr self, IntPtr newPlayer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_RestartPlayerAtPlayerStart(IntPtr self, IntPtr newPlayer, IntPtr startSpot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_RestartPlayerAtTransform(IntPtr self, IntPtr newPlayer, IntPtr spawnTransform);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_ReturnToMainMenuHost(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_SetPause(IntPtr self, IntPtr pC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_SetPlayerDefaults(IntPtr self, IntPtr playerPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_ShouldReset(IntPtr self, IntPtr actorToReset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_ShouldSpawnAtStartSpot(IntPtr self, IntPtr player);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_ShouldStartInCinematicMode(IntPtr self, IntPtr player, bool outHidePlayer, bool outHideHud, bool outDisableMovement, bool outDisableTurning);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AGameModeBase_SpawnDefaultPawnAtTransform(IntPtr self, IntPtr newPlayer, IntPtr spawnTransform);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AGameModeBase_SpawnDefaultPawnFor(IntPtr self, IntPtr newPlayer, IntPtr startSpot);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AGameModeBase_SpawnPlayerController(IntPtr self, byte inRemoteRole, string options);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AGameModeBase_SpawnPlayerController_o1(IntPtr self, byte inRemoteRole, IntPtr spawnLocation, IntPtr spawnRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameModeBase_SpawnPlayerFromSimulate(IntPtr self, IntPtr newLocation, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AGameModeBase_SpawnReplayPlayerController(IntPtr self, byte inRemoteRole, IntPtr spawnLocation, IntPtr spawnRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_StartPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_StartToLeaveMap(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_SwapPlayerControllers(IntPtr self, IntPtr oldPC, IntPtr newPC);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameModeBase_UpdateGameplayMuteList(IntPtr self, IntPtr aPlayer);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The default player name assigned to players that join with no name specified.
		/// </summary>
		public string DefaultPlayerName
		{
			get => E_PROP_AGameModeBase_DefaultPlayerName_GET(NativePointer);
			set => E_PROP_AGameModeBase_DefaultPlayerName_SET(NativePointer, value);
		}

		public AGameSession GameSession
		{
			get => E_PROP_AGameModeBase_GameSession_GET(NativePointer);
			set => E_PROP_AGameModeBase_GameSession_SET(NativePointer, value);
		}

		public AGameStateBase GameState
		{
			get => E_PROP_AGameModeBase_GameState_GET(NativePointer);
			set => E_PROP_AGameModeBase_GameState_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Save options string and parse it when needed
		/// </summary>
		public string OptionsString
		{
			get => E_PROP_AGameModeBase_OptionsString_GET(NativePointer);
			set => E_PROP_AGameModeBase_OptionsString_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public virtual bool AllowCheats(APlayerController p)
			=> E_AGameModeBase_AllowCheats(this, p);
		
		
		/// <summary>
		/// Returns true if the player is allowed to pause the game
		/// </summary>
		public virtual bool AllowPausing(APlayerController pC)
			=> E_AGameModeBase_AllowPausing(this, pC);
		
		
		/// <summary>
		/// Returns true if allowed to server travel
		/// </summary>
		public virtual bool CanServerTravel(string uRL, bool bAbsolute)
			=> E_AGameModeBase_CanServerTravel(this, uRL, bAbsolute);
		
		
		/// <summary>
		/// Return whether Viewer is allowed to spectate from the point of view of ViewTarget.
		/// </summary>
		public bool CanSpectate(APlayerController viewer, APlayerState viewTarget)
			=> E_AGameModeBase_CanSpectate(this, viewer, viewTarget);
		
		
		/// <summary>
		/// Sets the name for a controller
		/// </summary>
		/// <param name="controller">The controller of the player to change the name of</param>
		/// <param name="newName">The name to set the player to</param>
		/// <param name="bNameChange">Whether the name is changing or if this is the first time it has been set</param>
		public virtual void ChangeName(AController controller, string newName, bool bNameChange)
			=> E_AGameModeBase_ChangeName(this, controller, newName, bNameChange);
		
		
		/// <summary>
		/// Return the 'best' player start for this player to spawn from
		/// <para>Default implementation looks for a random unoccupied spot </para>
		/// @returns AActor chosen as player start (usually a PlayerStart)
		/// </summary>
		/// <param name="player">is the controller for whom we are choosing a playerstart</param>
		public AActor ChoosePlayerStart(AController player)
			=> E_AGameModeBase_ChoosePlayerStart(this, player);
		
		
		/// <summary>
		/// Checks the list of delegates to determine if the pausing can be cleared. If
		/// <para>the delegate says it's ok to unpause, that delegate is removed from the list </para>
		/// and the rest are checked. The game is considered unpaused when the list is
		/// <para>empty. </para>
		/// </summary>
		public virtual bool ClearPause()
			=> E_AGameModeBase_ClearPause(this);
		
		
		/// <summary>
		/// Return the specific player start actor that should be used for the next spawn
		/// <para>This will either use a previously saved startactor, or calls ChoosePlayerStart </para>
		/// @returns Actor chosen as player start (usually a PlayerStart)
		/// </summary>
		/// <param name="player">The AController for whom we are choosing a Player Start</param>
		/// <param name="incomingName">Specifies the tag of a Player Start to use</param>
		public AActor FindPlayerStart(AController player, string incomingName)
			=> E_AGameModeBase_FindPlayerStart(this, player, incomingName);
		
		
		/// <summary>
		/// Handles second half of RestartPlayer
		/// </summary>
		protected virtual void FinishRestartPlayer(AController newPlayer, FRotator startRotation)
			=> E_AGameModeBase_FinishRestartPlayer(this, newPlayer, startRotation);
		
		
		/// <summary>
		/// Forcibly removes an object's CanUnpause delegates from the list of pausers.  If any of the object's CanUnpause delegate
		/// <para>handlers were in the list, triggers a call to ClearPause(). </para>
		/// Called when the player controller is being destroyed to prevent the game from being stuck in a paused state when a PC that
		/// <para>paused the game is destroyed before the game is unpaused. </para>
		/// </summary>
		public void ForceClearUnpauseDelegates(AActor pauseActor)
			=> E_AGameModeBase_ForceClearUnpauseDelegates(this, pauseActor);
		
		
		/// <summary>
		/// Handles all player initialization that is shared between the travel methods
		/// <para>(i.e. called from both PostLogin() and HandleSeamlessTravelPlayer()) </para>
		/// </summary>
		protected virtual void GenericPlayerInitialization(AController c)
			=> E_AGameModeBase_GenericPlayerInitialization(this, c);
		
		
		/// <summary>
		/// Returns number of active human players, excluding spectators
		/// </summary>
		public virtual int GetNumPlayers()
			=> E_AGameModeBase_GetNumPlayers(this);
		
		
		/// <summary>
		/// Returns number of human players currently spectating
		/// </summary>
		public virtual int GetNumSpectators()
			=> E_AGameModeBase_GetNumSpectators(this);
		
		
		/// <summary>
		/// Signals that a player is ready to enter the game, which may start it up
		/// </summary>
		public void HandleStartingNewPlayer(APlayerController newPlayer)
			=> E_AGameModeBase_HandleStartingNewPlayer(this, newPlayer);
		
		
		/// <summary>
		/// Returns true if the match start callbacks have been called
		/// </summary>
		public virtual bool HasMatchStarted()
			=> E_AGameModeBase_HasMatchStarted(this);
		
		
		/// <summary>
		/// Initialize the game.
		/// <para>The GameMode's InitGame() event is called before any other functions (including PreInitializeComponents() ) </para>
		/// and is used by the GameMode to initialize parameters and spawn its helper classes.
		/// <para>@warning: this is called before actors' PreInitializeComponents. </para>
		/// </summary>
		public virtual void InitGame(string mapName, string options, string errorMessage)
			=> E_AGameModeBase_InitGame(this, mapName, options, errorMessage);
		
		
		/// <summary>
		/// Initialize the GameState actor with default settings
		/// <para>called during PreInitializeComponents() of the GameMode after a GameState has been spawned </para>
		/// as well as during Reset()
		/// </summary>
		public virtual void InitGameState()
			=> E_AGameModeBase_InitGameState(this);
		
		
		/// <summary>
		/// Initialize the AHUD object for a player. Games can override this to do something different
		/// </summary>
		protected void InitializeHUDForPlayer(APlayerController newPlayer)
			=> E_AGameModeBase_InitializeHUDForPlayer(this, newPlayer);
		
		
		/// <summary>
		/// Handles initializing a seamless travel player, handles logic similar to InitNewPlayer
		/// </summary>
		protected virtual void InitSeamlessTravelPlayer(AController newController)
			=> E_AGameModeBase_InitSeamlessTravelPlayer(this, newController);
		
		
		/// <summary>
		/// Called from RestartPlayerAtPlayerStart, can be used to initialize the start spawn actor
		/// </summary>
		public void InitStartSpot(AActor startSpot, AController newPlayer)
			=> E_AGameModeBase_InitStartSpot(this, startSpot, newPlayer);
		
		
		/// <summary>
		/// Returns true if replays will start/stop during gameplay starting/stopping
		/// </summary>
		public virtual bool IsHandlingReplays()
			=> E_AGameModeBase_IsHandlingReplays(this);
		
		
		/// <summary>
		/// Returns true if the game is paused
		/// </summary>
		public virtual bool IsPaused()
			=> E_AGameModeBase_IsPaused(this);
		
		
		/// <summary>
		/// Return the specific player start actor that should be used for the next spawn
		/// <para>This will either use a previously saved startactor, or calls ChoosePlayerStart </para>
		/// @returns Actor chosen as player start (usually a PlayerStart)
		/// </summary>
		/// <param name="player">The AController for whom we are choosing a Player Start</param>
		/// <param name="incomingName">Specifies the tag of a Player Start to use</param>
		public AActor K2_FindPlayerStart(AController player, string incomingName)
			=> E_AGameModeBase_K2_FindPlayerStart(this, player, incomingName);
		
		
		/// <summary>
		/// Overridable event for GameMode blueprint to respond to a change name call
		/// </summary>
		/// <param name="controller">The controller of the player to change the name of</param>
		/// <param name="newName">The name to set the player to</param>
		/// <param name="bNameChange">Whether the name is changing or if this is the first time it has been set</param>
		public void OnChangeName(AController other, string newName, bool bNameChange)
			=> E_AGameModeBase_K2_OnChangeName(this, other, newName, bNameChange);
		
		
		/// <summary>
		/// Implementable event when a Controller with a PlayerState leaves the game.
		/// </summary>
		public void OnLogout(AController exitingController)
			=> E_AGameModeBase_K2_OnLogout(this, exitingController);
		
		
		/// <summary>
		/// Implementable event called at the end of RestartPlayer
		/// </summary>
		public void OnRestartPlayer(AController newPlayer)
			=> E_AGameModeBase_K2_OnRestartPlayer(this, newPlayer);
		
		
		/// <summary>
		/// Called when a PlayerController is swapped to a new one during seamless travel
		/// </summary>
		protected void OnSwapPlayerControllers(APlayerController oldPC, APlayerController newPC)
			=> E_AGameModeBase_K2_OnSwapPlayerControllers(this, oldPC, newPC);
		
		
		/// <summary>
		/// Notification that a player has successfully logged in, and has been given a player controller
		/// </summary>
		public void OnPostLogin(APlayerController newPlayer)
			=> E_AGameModeBase_K2_PostLogin(this, newPlayer);
		
		
		/// <summary>
		/// Called when a Controller with a PlayerState leaves the game or is destroyed
		/// </summary>
		public virtual void Logout(AController exiting)
			=> E_AGameModeBase_Logout(this, exiting);
		
		
		/// <summary>
		/// Returns true if NewPlayerController may only join the server as a spectator.
		/// </summary>
		public bool MustSpectate(APlayerController newPlayerController)
			=> E_AGameModeBase_MustSpectate(this, newPlayerController);
		
		
		/// <summary>
		/// Returns true if it's valid to call RestartPlayer. By default will call Player->CanRestartPlayer
		/// </summary>
		public bool PlayerCanRestart(APlayerController player)
			=> E_AGameModeBase_PlayerCanRestart(this, player);
		
		
		/// <summary>
		/// Called after a successful login.  This is the first place it is safe to call replicated functions on the PlayerController.
		/// </summary>
		public virtual void PostLogin(APlayerController newPlayer)
			=> E_AGameModeBase_PostLogin(this, newPlayer);
		
		
		/// <summary>
		/// Called after a seamless level transition has been completed on the *new* GameMode.
		/// <para>Used to reinitialize players already in the game as they won't have *Login() called on them </para>
		/// </summary>
		public virtual void PostSeamlessTravel()
			=> E_AGameModeBase_PostSeamlessTravel(this);
		
		
		/// <summary>
		/// Handles request for server to travel to a new URL, with all players
		/// </summary>
		public virtual void ProcessServerTravel(string uRL, bool bAbsolute)
			=> E_AGameModeBase_ProcessServerTravel(this, uRL, bAbsolute);
		
		
		/// <summary>
		/// Replicates the current level streaming status to the given PlayerController
		/// </summary>
		protected virtual void ReplicateStreamingStatus(APlayerController pC)
			=> E_AGameModeBase_ReplicateStreamingStatus(this, pC);
		
		
		/// <summary>
		/// Overridable function called when resetting level. This is used to reset the game state while staying in the same map
		/// <para>Default implementation calls Reset() on all actors except GameMode and Controllers </para>
		/// </summary>
		public virtual void ResetLevel()
			=> E_AGameModeBase_ResetLevel(this);
		
		
		/// <summary>
		/// Tries to spawn the player's pawn, at the location returned by FindPlayerStart
		/// </summary>
		public virtual void RestartPlayer(AController newPlayer)
			=> E_AGameModeBase_RestartPlayer(this, newPlayer);
		
		
		/// <summary>
		/// Tries to spawn the player's pawn at the specified actor's location
		/// </summary>
		public virtual void RestartPlayerAtPlayerStart(AController newPlayer, AActor startSpot)
			=> E_AGameModeBase_RestartPlayerAtPlayerStart(this, newPlayer, startSpot);
		
		
		/// <summary>
		/// Tries to spawn the player's pawn at a specific location
		/// </summary>
		public virtual void RestartPlayerAtTransform(AController newPlayer, FTransform spawnTransform)
			=> E_AGameModeBase_RestartPlayerAtTransform(this, newPlayer, spawnTransform);
		
		
		/// <summary>
		/// Return to main menu, and disconnect any players
		/// </summary>
		public virtual void ReturnToMainMenuHost()
			=> E_AGameModeBase_ReturnToMainMenuHost(this);
		
		
		/// <summary>
		/// Adds the delegate to the list if the player Controller has the right to pause
		/// <para>the game. The delegate is called to see if it is ok to unpause the game, e.g. </para>
		/// the reason the game was paused has been cleared.
		/// </summary>
		/// <param name="pC">the player Controller to check for admin privs</param>
		/// <param name="canUnpauseDelegate">the delegate to query when checking for unpause</param>
		public virtual bool SetPause(APlayerController pC)
			=> E_AGameModeBase_SetPause(this, pC);
		
		
		/// <summary>
		/// Initializes player pawn back to starting values, called from RestartPlayer
		/// </summary>
		public virtual void SetPlayerDefaults(APawn playerPawn)
			=> E_AGameModeBase_SetPlayerDefaults(this, playerPawn);
		
		
		/// <summary>
		/// Overridable function to determine whether an Actor should have Reset called when the game has Reset called on it.
		/// <para>Default implementation returns true </para>
		/// false if the GameMode will manually reset it or if the actor does not need to be reset
		/// </summary>
		/// <param name="actorToReset">The actor to make a determination for</param>
		/// <return>true</return>
		public bool ShouldReset(AActor actorToReset)
			=> E_AGameModeBase_ShouldReset(this, actorToReset);
		
		
		/// <summary>
		/// Return true if FindPlayerStart should use the StartSpot stored on Player instead of calling ChoosePlayerStart
		/// </summary>
		protected virtual bool ShouldSpawnAtStartSpot(AController player)
			=> E_AGameModeBase_ShouldSpawnAtStartSpot(this, player);
		
		
		/// <summary>
		/// Check to see if we should start in cinematic mode (e.g. matinee movie capture).
		/// <para>false if if we should not. </para>
		/// </summary>
		/// <param name="outHidePlayer">Whether to hide the player</param>
		/// <param name="outHideHud">Whether to hide the HUD</param>
		/// <param name="outDisableMovement">Whether to disable movement</param>
		/// <param name="outDisableTurning">Whether to disable turning</param>
		/// <return>bool</return>
		protected virtual bool ShouldStartInCinematicMode(APlayerController player, bool outHidePlayer, bool outHideHud, bool outDisableMovement, bool outDisableTurning)
			=> E_AGameModeBase_ShouldStartInCinematicMode(this, player, outHidePlayer, outHideHud, outDisableMovement, outDisableTurning);
		
		
		/// <summary>
		/// Called during RestartPlayer to actually spawn the player's pawn, when using a transform
		/// </summary>
		/// <param name="newPlayer">Controller for whom this pawn is spawned</param>
		/// <param name="startSpot">Actor at which to spawn pawn</param>
		/// <return>a</return>
		public APawn SpawnDefaultPawnAtTransform(AController newPlayer, FTransform spawnTransform)
			=> E_AGameModeBase_SpawnDefaultPawnAtTransform(this, newPlayer, spawnTransform);
		
		
		/// <summary>
		/// Called during RestartPlayer to actually spawn the player's pawn, when using a start spot
		/// </summary>
		/// <param name="newPlayer">Controller for whom this pawn is spawned</param>
		/// <param name="startSpot">Actor at which to spawn pawn</param>
		/// <return>a</return>
		public APawn SpawnDefaultPawnFor(AController newPlayer, AActor startSpot)
			=> E_AGameModeBase_SpawnDefaultPawnFor(this, newPlayer, startSpot);
		
		
		/// <summary>
		/// Spawns the appropriate PlayerController for the given options; split out from Login() for easier overriding.
		/// <para>Override this to conditionally spawn specialized PlayerControllers, for instance. </para>
		/// </summary>
		/// <param name="remoteRole">the role this controller will play remotely</param>
		/// <param name="options">the options string from the new player's URL</param>
		/// <return>PlayerController</return>
		public virtual APlayerController SpawnPlayerController(ENetRole inRemoteRole, string options)
			=> E_AGameModeBase_SpawnPlayerController(this, (byte)inRemoteRole, options);
		
		public virtual APlayerController SpawnPlayerController(ENetRole inRemoteRole, FVector spawnLocation, FRotator spawnRotation)
			=> E_AGameModeBase_SpawnPlayerController_o1(this, (byte)inRemoteRole, spawnLocation, spawnRotation);
		
		
		/// <summary>
		/// Used in the editor to spawn a PIE player after the game has already started
		/// </summary>
		public virtual bool SpawnPlayerFromSimulate(FVector newLocation, FRotator newRotation)
			=> E_AGameModeBase_SpawnPlayerFromSimulate(this, newLocation, newRotation);
		
		public virtual APlayerController SpawnReplayPlayerController(ENetRole inRemoteRole, FVector spawnLocation, FRotator spawnRotation)
			=> E_AGameModeBase_SpawnReplayPlayerController(this, (byte)inRemoteRole, spawnLocation, spawnRotation);
		
		
		/// <summary>
		/// Transitions to calls BeginPlay on actors.
		/// </summary>
		public virtual void StartPlay()
			=> E_AGameModeBase_StartPlay(this);
		
		
		/// <summary>
		/// Start the transition out of the current map. Called at start of seamless travel, or right before map change for hard travel.
		/// </summary>
		public virtual void StartToLeaveMap()
			=> E_AGameModeBase_StartToLeaveMap(this);
		
		
		/// <summary>
		/// Used to swap a viewport/connection's PlayerControllers when seamless traveling and the new GameMode's
		/// <para>controller class is different than the previous </para>
		/// includes network handling
		/// </summary>
		/// <param name="oldPC">the old PC that should be discarded</param>
		/// <param name="newPC">the new PC that should be used for the player</param>
		public virtual void SwapPlayerControllers(APlayerController oldPC, APlayerController newPC)
			=> E_AGameModeBase_SwapPlayerControllers(this, oldPC, newPC);
		
		
		/// <summary>
		/// Used to notify the game type that it is ok to update a player's gameplay
		/// <para>specific muting information now. The playercontroller needs to notify </para>
		/// the server when it is possible to do so or the unique net id will be
		/// <para>incorrect and the muting not work. </para>
		/// </summary>
		/// <param name="aPlayer">the playercontroller that is ready for updates</param>
		protected virtual void UpdateGameplayMuteList(APlayerController aPlayer)
			=> E_AGameModeBase_UpdateGameplayMuteList(this, aPlayer);
		
		#endregion
		
		public static implicit operator IntPtr(AGameModeBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AGameModeBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AGameModeBase>(PtrDesc);
		}}}
