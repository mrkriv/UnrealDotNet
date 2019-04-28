// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameState.h:16

namespace UnrealEngine
{
	[ManageType("ManageGameState")]
	public partial class ManageGameState : AGameState
	{
		public ManageGameState(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Called periodically, overridden by subclasses
		/// </summary>
		public override void DefaultTimer() { }
		
		
		/// <summary>
		/// Called when the match transitions to LeavingMap
		/// </summary>
		protected override void HandleLeavingMap() { }
		
		
		/// <summary>
		/// Called when the map transitions to WaitingPostMatch
		/// </summary>
		protected override void HandleMatchHasEnded() { }
		
		
		/// <summary>
		/// Called when the state transitions to InProgress
		/// </summary>
		protected override void HandleMatchHasStarted() { }
		
		
		/// <summary>
		/// Called when the state transitions to WaitingToStart
		/// </summary>
		protected override void HandleMatchIsWaitingToStart() { }
		
		public override void OnRep_ElapsedTime() { }
		
		public override void OnRep_MatchState() { }
		
		public static implicit operator IntPtr(ManageGameState self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageGameState(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameState>(PtrDesc);
		}}}
