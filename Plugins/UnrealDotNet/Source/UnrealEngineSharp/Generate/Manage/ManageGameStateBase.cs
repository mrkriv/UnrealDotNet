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
		/// <para>Add PlayerState to the PlayerArray </para>
		/// </summary>
		public override void AddPlayerState(APlayerState playerState) { }
		
		
		/// <summary>
		/// <para>Allow game states to react to asset packages being loaded asynchronously </para>
		/// </summary>
		public override void AsyncPackageLoaded(UObject package) { }
		
		
		/// <summary>
		/// <para>Called by game mode to set the started play bool </para>
		/// </summary>
		public override void HandleBeginPlay() { }
		
		protected override void OnRep_GameModeClass() { }
		
		protected override void OnRep_ReplicatedHasBegunPlay() { }
		
		protected override void OnRep_ReplicatedWorldTimeSeconds() { }
		
		protected override void OnRep_SpectatorClass() { }
		
		
		/// <summary>
		/// <para>Called when the GameClass property is set (at startup for the server, after the variable has been replicated on clients) </para>
		/// </summary>
		public override void ReceivedGameModeClass() { }
		
		
		/// <summary>
		/// <para>Called when the SpectatorClass property is set (at startup for the server, after the variable has been replicated on clients) </para>
		/// </summary>
		public override void ReceivedSpectatorClass() { }
		
		
		/// <summary>
		/// <para>Remove PlayerState from the PlayerArray. </para>
		/// </summary>
		public override void RemovePlayerState(APlayerState playerState) { }
		
		
		/// <summary>
		/// <para>Called during seamless travel transition twice (once when the transition map is loaded, once when destination map is loaded) </para>
		/// </summary>
		public override void SeamlessTravelTransitionCheckpoint(bool bToTransitionMap) { }
		
		
		/// <summary>
		/// <para>Called periodically to update ReplicatedWorldTimeSeconds </para>
		/// </summary>
		protected override void UpdateServerTimeSeconds() { }
		
		public static implicit operator IntPtr(ManageGameStateBase self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageGameStateBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameStateBase>(PtrDesc);
		}}}
