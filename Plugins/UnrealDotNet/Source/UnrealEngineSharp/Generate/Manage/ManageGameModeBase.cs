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
	[ManageType("ManageGameModeBase")]
	public partial class ManageGameModeBase : AGameModeBase
	{
		public ManageGameModeBase(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Sets the name for a controller
		/// </summary>
		/// <param name="controller">The controller of the player to change the name of</param>
		/// <param name="newName">The name to set the player to</param>
		/// <param name="bNameChange">Whether the name is changing or if this is the first time it has been set</param>
		public override void ChangeName(AController controller, string newName, bool bNameChange) { }
		
		
		/// <summary>
		/// Handles second half of RestartPlayer
		/// </summary>
		protected override void FinishRestartPlayer(AController newPlayer, FRotator startRotation) { }
		
		
		/// <summary>
		/// Handles all player initialization that is shared between the travel methods
		/// <para>(i.e. called from both PostLogin() and HandleSeamlessTravelPlayer()) </para>
		/// </summary>
		protected override void GenericPlayerInitialization(AController c) { }
		
		
		/// <summary>
		/// Initialize the game.
		/// <para>The GameMode's InitGame() event is called before any other functions (including PreInitializeComponents() ) </para>
		/// and is used by the GameMode to initialize parameters and spawn its helper classes.
		/// <para>@warning: this is called before actors' PreInitializeComponents. </para>
		/// </summary>
		public override void InitGame(string mapName, string options, string errorMessage) { }
		
		
		/// <summary>
		/// Initialize the GameState actor with default settings
		/// <para>called during PreInitializeComponents() of the GameMode after a GameState has been spawned </para>
		/// as well as during Reset()
		/// </summary>
		public override void InitGameState() { }
		
		
		/// <summary>
		/// Handles initializing a seamless travel player, handles logic similar to InitNewPlayer
		/// </summary>
		protected override void InitSeamlessTravelPlayer(AController newController) { }
		
		
		/// <summary>
		/// Called when a Controller with a PlayerState leaves the game or is destroyed
		/// </summary>
		public override void Logout(AController exiting) { }
		
		
		/// <summary>
		/// Called after a successful login.  This is the first place it is safe to call replicated functions on the PlayerController.
		/// </summary>
		public override void PostLogin(APlayerController newPlayer) { }
		
		
		/// <summary>
		/// Called after a seamless level transition has been completed on the *new* GameMode.
		/// <para>Used to reinitialize players already in the game as they won't have *Login() called on them </para>
		/// </summary>
		public override void PostSeamlessTravel() { }
		
		
		/// <summary>
		/// Handles request for server to travel to a new URL, with all players
		/// </summary>
		public override void ProcessServerTravel(string uRL, bool bAbsolute) { }
		
		
		/// <summary>
		/// Replicates the current level streaming status to the given PlayerController
		/// </summary>
		protected override void ReplicateStreamingStatus(APlayerController pC) { }
		
		
		/// <summary>
		/// Overridable function called when resetting level. This is used to reset the game state while staying in the same map
		/// <para>Default implementation calls Reset() on all actors except GameMode and Controllers </para>
		/// </summary>
		public override void ResetLevel() { }
		
		
		/// <summary>
		/// Tries to spawn the player's pawn, at the location returned by FindPlayerStart
		/// </summary>
		public override void RestartPlayer(AController newPlayer) { }
		
		
		/// <summary>
		/// Tries to spawn the player's pawn at the specified actor's location
		/// </summary>
		public override void RestartPlayerAtPlayerStart(AController newPlayer, AActor startSpot) { }
		
		
		/// <summary>
		/// Tries to spawn the player's pawn at a specific location
		/// </summary>
		public override void RestartPlayerAtTransform(AController newPlayer, FTransform spawnTransform) { }
		
		
		/// <summary>
		/// Return to main menu, and disconnect any players
		/// </summary>
		public override void ReturnToMainMenuHost() { }
		
		
		/// <summary>
		/// Initializes player pawn back to starting values, called from RestartPlayer
		/// </summary>
		public override void SetPlayerDefaults(APawn playerPawn) { }
		
		
		/// <summary>
		/// Transitions to calls BeginPlay on actors.
		/// </summary>
		public override void StartPlay() { }
		
		
		/// <summary>
		/// Start the transition out of the current map. Called at start of seamless travel, or right before map change for hard travel.
		/// </summary>
		public override void StartToLeaveMap() { }
		
		
		/// <summary>
		/// Used to swap a viewport/connection's PlayerControllers when seamless traveling and the new GameMode's
		/// <para>controller class is different than the previous </para>
		/// includes network handling
		/// </summary>
		/// <param name="oldPC">the old PC that should be discarded</param>
		/// <param name="newPC">the new PC that should be used for the player</param>
		public override void SwapPlayerControllers(APlayerController oldPC, APlayerController newPC) { }
		
		
		/// <summary>
		/// Used to notify the game type that it is ok to update a player's gameplay
		/// <para>specific muting information now. The playercontroller needs to notify </para>
		/// the server when it is possible to do so or the unique net id will be
		/// <para>incorrect and the muting not work. </para>
		/// </summary>
		/// <param name="aPlayer">the playercontroller that is ready for updates</param>
		protected override void UpdateGameplayMuteList(APlayerController aPlayer) { }
		
		public static implicit operator IntPtr(ManageGameModeBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameModeBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameModeBase>(PtrDesc);
		}}}
