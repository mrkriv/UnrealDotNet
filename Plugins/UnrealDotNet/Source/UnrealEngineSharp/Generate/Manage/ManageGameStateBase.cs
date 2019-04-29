// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameStateBase.h:29

namespace UnrealEngine
{
	[ManageType("ManageGameStateBase")]
	public partial class ManageGameStateBase : AGameStateBase
	{
		public ManageGameStateBase(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Add PlayerState to the PlayerArray
		/// </summary>
		public override void AddPlayerState(APlayerState playerState) { }
		
		
		/// <summary>
		/// Allow game states to react to asset packages being loaded asynchronously
		/// </summary>
		public override void AsyncPackageLoaded(UObject package) { }
		
		
		/// <summary>
		/// Called by game mode to set the started play bool
		/// </summary>
		public override void HandleBeginPlay() { }
		
		protected override void OnRep_GameModeClass() { }
		
		protected override void OnRep_ReplicatedHasBegunPlay() { }
		
		protected override void OnRep_ReplicatedWorldTimeSeconds() { }
		
		protected override void OnRep_SpectatorClass() { }
		
		
		/// <summary>
		/// Called when the GameClass property is set (at startup for the server, after the variable has been replicated on clients)
		/// </summary>
		public override void ReceivedGameModeClass() { }
		
		
		/// <summary>
		/// Called when the SpectatorClass property is set (at startup for the server, after the variable has been replicated on clients)
		/// </summary>
		public override void ReceivedSpectatorClass() { }
		
		
		/// <summary>
		/// Remove PlayerState from the PlayerArray.
		/// </summary>
		public override void RemovePlayerState(APlayerState playerState) { }
		
		
		/// <summary>
		/// Called during seamless travel transition twice (once when the transition map is loaded, once when destination map is loaded)
		/// </summary>
		public override void SeamlessTravelTransitionCheckpoint(bool bToTransitionMap) { }
		
		
		/// <summary>
		/// Called periodically to update ReplicatedWorldTimeSeconds
		/// </summary>
		protected override void UpdateServerTimeSeconds() { }
		
		public static implicit operator IntPtr(ManageGameStateBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameStateBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameStateBase>(PtrDesc);
		}}}
