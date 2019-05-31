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
	public  partial class AGameStateBase : AInfo
	{
		public AGameStateBase(IntPtr adress)
			: base(adress)
		{
		}

		public AGameStateBase(UObject Parent = null, string Name = "GameStateBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AGameStateBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_AGameStateBase_AuthorityGameMode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_AGameStateBase_AuthorityGameMode_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AGameStateBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_AddPlayerState(IntPtr self, IntPtr playerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_AsyncPackageLoaded(IntPtr self, IntPtr package);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_AGameStateBase_GetDefaultGameMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AGameStateBase_GetPlayerRespawnDelay(IntPtr self, IntPtr controller);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AGameStateBase_GetPlayerStartTime(IntPtr self, IntPtr controller);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_AGameStateBase_GetServerWorldTimeSeconds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_HandleBeginPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameStateBase_HasBegunPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_AGameStateBase_HasMatchStarted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_OnRep_GameModeClass(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_OnRep_ReplicatedHasBegunPlay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_OnRep_ReplicatedWorldTimeSeconds(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_OnRep_SpectatorClass(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_ReceivedGameModeClass(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_ReceivedSpectatorClass(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_RemovePlayerState(IntPtr self, IntPtr playerState);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_SeamlessTravelTransitionCheckpoint(IntPtr self, bool bToTransitionMap);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_AGameStateBase_UpdateServerTimeSeconds(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Instance of the current game mode, exists only on the server. For non-authority clients, this will be NULL.
		/// </summary>
		public AGameModeBase AuthorityGameMode
		{
			get => E_PROP_AGameStateBase_AuthorityGameMode_GET(NativePointer);
			set => E_PROP_AGameStateBase_AuthorityGameMode_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Add PlayerState to the PlayerArray
		/// </summary>
		public virtual void AddPlayerState(APlayerState playerState)
			=> E_AGameStateBase_AddPlayerState(this, playerState);
		
		
		/// <summary>
		/// Allow game states to react to asset packages being loaded asynchronously
		/// </summary>
		public virtual void AsyncPackageLoaded(UObject package)
			=> E_AGameStateBase_AsyncPackageLoaded(this, package);
		
		
		/// <summary>
		/// Helper to return the default object of the GameModeBase class corresponding to this GameState. This object is not safe to modify.
		/// </summary>
		public AGameModeBase GetDefaultGameMode()
			=> E_AGameStateBase_GetDefaultGameMode(this);
		
		
		/// <summary>
		/// Returns how much time needs to be spent before a player can respawn
		/// </summary>
		public virtual float GetPlayerRespawnDelay(AController controller)
			=> E_AGameStateBase_GetPlayerRespawnDelay(this, controller);
		
		
		/// <summary>
		/// Returns the time that should be used as when a player started
		/// </summary>
		public virtual float GetPlayerStartTime(AController controller)
			=> E_AGameStateBase_GetPlayerStartTime(this, controller);
		
		
		/// <summary>
		/// Returns the simulated TimeSeconds on the server, will be synchronized on client and server
		/// </summary>
		public virtual float GetServerWorldTimeSeconds()
			=> E_AGameStateBase_GetServerWorldTimeSeconds(this);
		
		
		/// <summary>
		/// Called by game mode to set the started play bool
		/// </summary>
		public virtual void HandleBeginPlay()
			=> E_AGameStateBase_HandleBeginPlay(this);
		
		
		/// <summary>
		/// Returns true if the world has started play (called BeginPlay on actors)
		/// </summary>
		public virtual bool HasBegunPlay()
			=> E_AGameStateBase_HasBegunPlay(this);
		
		
		/// <summary>
		/// Returns true if the world has started match (called MatchStarted callbacks)
		/// </summary>
		public virtual bool HasMatchStarted()
			=> E_AGameStateBase_HasMatchStarted(this);
		
		protected virtual void OnRep_GameModeClass()
			=> E_AGameStateBase_OnRep_GameModeClass(this);
		
		protected virtual void OnRep_ReplicatedHasBegunPlay()
			=> E_AGameStateBase_OnRep_ReplicatedHasBegunPlay(this);
		
		protected virtual void OnRep_ReplicatedWorldTimeSeconds()
			=> E_AGameStateBase_OnRep_ReplicatedWorldTimeSeconds(this);
		
		protected virtual void OnRep_SpectatorClass()
			=> E_AGameStateBase_OnRep_SpectatorClass(this);
		
		
		/// <summary>
		/// Called when the GameClass property is set (at startup for the server, after the variable has been replicated on clients)
		/// </summary>
		public virtual void ReceivedGameModeClass()
			=> E_AGameStateBase_ReceivedGameModeClass(this);
		
		
		/// <summary>
		/// Called when the SpectatorClass property is set (at startup for the server, after the variable has been replicated on clients)
		/// </summary>
		public virtual void ReceivedSpectatorClass()
			=> E_AGameStateBase_ReceivedSpectatorClass(this);
		
		
		/// <summary>
		/// Remove PlayerState from the PlayerArray.
		/// </summary>
		public virtual void RemovePlayerState(APlayerState playerState)
			=> E_AGameStateBase_RemovePlayerState(this, playerState);
		
		
		/// <summary>
		/// Called during seamless travel transition twice (once when the transition map is loaded, once when destination map is loaded)
		/// </summary>
		public virtual void SeamlessTravelTransitionCheckpoint(bool bToTransitionMap)
			=> E_AGameStateBase_SeamlessTravelTransitionCheckpoint(this, bToTransitionMap);
		
		
		/// <summary>
		/// Called periodically to update ReplicatedWorldTimeSeconds
		/// </summary>
		protected virtual void UpdateServerTimeSeconds()
			=> E_AGameStateBase_UpdateServerTimeSeconds(this);
		
		#endregion
		
		public static implicit operator IntPtr(AGameStateBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AGameStateBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AGameStateBase>(PtrDesc);
		}}}
