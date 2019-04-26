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
		/// <para>Sets the name for a controller </para>
		/// <param name="Controller">The controller of the player to change the name of </param>
		/// <param name="NewName">The name to set the player to </param>
		/// <param name="bNameChange">Whether the name is changing or if this is the first time it has been set </param>
		/// </summary>
		public override void ChangeName(AController controller, string newName, bool bNameChange) { }
		
		
		/// <summary>
		/// <para>Handles second half of RestartPlayer </para>
		/// </summary>
		protected override void FinishRestartPlayer(AController newPlayer, FRotator startRotation) { }
		
		
		/// <summary>
		/// <para>Handles all player initialization that is shared between the travel methods </para>
		/// <para>(i.e. called from both PostLogin() and HandleSeamlessTravelPlayer()) </para>
		/// </summary>
		protected override void GenericPlayerInitialization(AController c) { }
		
		
		/// <summary>
		/// <para>Initialize the game. </para>
		/// <para>The GameMode's InitGame() event is called before any other functions (including PreInitializeComponents() ) </para>
		/// <para>and is used by the GameMode to initialize parameters and spawn its helper classes. </para>
		/// <para>@warning: this is called before actors' PreInitializeComponents. </para>
		/// </summary>
		public override void InitGame(string mapName, string options, string errorMessage) { }
		
		
		/// <summary>
		/// <para>Initialize the GameState actor with default settings </para>
		/// <para>called during PreInitializeComponents() of the GameMode after a GameState has been spawned </para>
		/// <para>as well as during Reset() </para>
		/// </summary>
		public override void InitGameState() { }
		
		
		/// <summary>
		/// <para>Handles initializing a seamless travel player, handles logic similar to InitNewPlayer </para>
		/// </summary>
		protected override void InitSeamlessTravelPlayer(AController newController) { }
		
		
		/// <summary>
		/// <para>Called when a Controller with a PlayerState leaves the game or is destroyed </para>
		/// </summary>
		public override void Logout(AController exiting) { }
		
		
		/// <summary>
		/// <para>Called after a successful login.  This is the first place it is safe to call replicated functions on the PlayerController. </para>
		/// </summary>
		public override void PostLogin(APlayerController newPlayer) { }
		
		
		/// <summary>
		/// <para>Called after a seamless level transition has been completed on the *new* GameMode. </para>
		/// <para>Used to reinitialize players already in the game as they won't have *Login() called on them </para>
		/// </summary>
		public override void PostSeamlessTravel() { }
		
		
		/// <summary>
		/// <para>Handles request for server to travel to a new URL, with all players </para>
		/// </summary>
		public override void ProcessServerTravel(string uRL, bool bAbsolute) { }
		
		
		/// <summary>
		/// <para>Replicates the current level streaming status to the given PlayerController </para>
		/// </summary>
		protected override void ReplicateStreamingStatus(APlayerController pC) { }
		
		
		/// <summary>
		/// <para>Overridable function called when resetting level. This is used to reset the game state while staying in the same map </para>
		/// <para>Default implementation calls Reset() on all actors except GameMode and Controllers </para>
		/// </summary>
		public override void ResetLevel() { }
		
		
		/// <summary>
		/// <para>Tries to spawn the player's pawn, at the location returned by FindPlayerStart </para>
		/// </summary>
		public override void RestartPlayer(AController newPlayer) { }
		
		
		/// <summary>
		/// <para>Tries to spawn the player's pawn at the specified actor's location </para>
		/// </summary>
		public override void RestartPlayerAtPlayerStart(AController newPlayer, AActor startSpot) { }
		
		
		/// <summary>
		/// <para>Tries to spawn the player's pawn at a specific location </para>
		/// </summary>
		public override void RestartPlayerAtTransform(AController newPlayer, FTransform spawnTransform) { }
		
		
		/// <summary>
		/// <para>Return to main menu, and disconnect any players </para>
		/// </summary>
		public override void ReturnToMainMenuHost() { }
		
		
		/// <summary>
		/// <para>Initializes player pawn back to starting values, called from RestartPlayer </para>
		/// </summary>
		public override void SetPlayerDefaults(APawn playerPawn) { }
		
		
		/// <summary>
		/// <para>Transitions to calls BeginPlay on actors. </para>
		/// </summary>
		public override void StartPlay() { }
		
		
		/// <summary>
		/// <para>Start the transition out of the current map. Called at start of seamless travel, or right before map change for hard travel. </para>
		/// </summary>
		public override void StartToLeaveMap() { }
		
		
		/// <summary>
		/// <para>Used to swap a viewport/connection's PlayerControllers when seamless traveling and the new GameMode's </para>
		/// <para>controller class is different than the previous </para>
		/// <para>includes network handling </para>
		/// <param name="OldPC">the old PC that should be discarded </param>
		/// <param name="NewPC">the new PC that should be used for the player </param>
		/// </summary>
		public override void SwapPlayerControllers(APlayerController oldPC, APlayerController newPC) { }
		
		
		/// <summary>
		/// <para>Used to notify the game type that it is ok to update a player's gameplay </para>
		/// <para>specific muting information now. The playercontroller needs to notify </para>
		/// <para>the server when it is possible to do so or the unique net id will be </para>
		/// <para>incorrect and the muting not work. </para>
		/// <param name="aPlayer">the playercontroller that is ready for updates </param>
		/// </summary>
		protected override void UpdateGameplayMuteList(APlayerController aPlayer) { }
		
		public static implicit operator IntPtr(ManageGameModeBase self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageGameModeBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameModeBase>(PtrDesc);
		}}}
