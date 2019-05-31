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
	public  partial class AGameState : AGameStateBase
	{
		public AGameState(IntPtr adress)
			: base(adress)
		{
		}

		public AGameState(UObject Parent = null, string Name = "GameState")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AGameState(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_AGameState_ElapsedTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameState_ElapsedTime_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AGameState(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameState_DefaultTimer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_AGameState_GetMatchState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameState_HandleLeavingMap(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameState_HandleMatchHasEnded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameState_HandleMatchHasStarted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameState_HandleMatchIsWaitingToStart(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameState_HasMatchEnded(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameState_IsMatchInProgress(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameState_OnRep_ElapsedTime(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameState_OnRep_MatchState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameState_SetMatchState(IntPtr self, string newState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameState_ShouldShowGore(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Elapsed game time since match has started.
		/// </summary>
		public int ElapsedTime
		{
			get => E_PROP_AGameState_ElapsedTime_GET(NativePointer);
			set => E_PROP_AGameState_ElapsedTime_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Called periodically, overridden by subclasses
		/// </summary>
		public virtual void DefaultTimer()
			=> E_AGameState_DefaultTimer(this);
		
		
		/// <summary>
		/// Returns the current match state, this is an accessor to protect the state machine flow
		/// </summary>
		public string GetMatchState()
			=> E_AGameState_GetMatchState(this);
		
		
		/// <summary>
		/// Called when the match transitions to LeavingMap
		/// </summary>
		protected virtual void HandleLeavingMap()
			=> E_AGameState_HandleLeavingMap(this);
		
		
		/// <summary>
		/// Called when the map transitions to WaitingPostMatch
		/// </summary>
		protected virtual void HandleMatchHasEnded()
			=> E_AGameState_HandleMatchHasEnded(this);
		
		
		/// <summary>
		/// Called when the state transitions to InProgress
		/// </summary>
		protected virtual void HandleMatchHasStarted()
			=> E_AGameState_HandleMatchHasStarted(this);
		
		
		/// <summary>
		/// Called when the state transitions to WaitingToStart
		/// </summary>
		protected virtual void HandleMatchIsWaitingToStart()
			=> E_AGameState_HandleMatchIsWaitingToStart(this);
		
		
		/// <summary>
		/// Returns true if match is WaitingPostMatch or later
		/// </summary>
		public virtual bool HasMatchEnded()
			=> E_AGameState_HasMatchEnded(this);
		
		
		/// <summary>
		/// Returns true if we're in progress
		/// </summary>
		public virtual bool IsMatchInProgress()
			=> E_AGameState_IsMatchInProgress(this);
		
		public virtual void OnRep_ElapsedTime()
			=> E_AGameState_OnRep_ElapsedTime(this);
		
		public virtual void OnRep_MatchState()
			=> E_AGameState_OnRep_MatchState(this);
		
		
		/// <summary>
		/// Updates the match state and calls the appropriate transition functions, only valid on server
		/// </summary>
		public void SetMatchState(string newState)
			=> E_AGameState_SetMatchState(this, newState);
		
		public virtual bool ShouldShowGore()
			=> E_AGameState_ShouldShowGore(this);
		
		#endregion
		
		public static implicit operator IntPtr(AGameState self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AGameState(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AGameState>(PtrDesc);
		}}}
