// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\LocalPlayer.h:36

namespace UnrealEngine
{
	public partial class FLocalPlayerContext : NativeStructWrapper
	{
		public FLocalPlayerContext(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FLocalPlayerContext() :
			base(E_CreateStruct_FLocalPlayerContext(), false)
		{
		}

		public FLocalPlayerContext(ULocalPlayer inLocalPlayer, UWorld inWorld) :
			base(E_CreateStruct_FLocalPlayerContext_ULocalPlayer_UWorld(inLocalPlayer, inWorld), false)
		{
		}

		public FLocalPlayerContext(APlayerController inPlayerController) :
			base(E_CreateStruct_FLocalPlayerContext_APlayerController(inPlayerController), false)
		{
		}

		public FLocalPlayerContext(FLocalPlayerContext inPlayerContext) :
			base(E_CreateStruct_FLocalPlayerContext_FLocalPlayerContext(inPlayerContext), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLocalPlayerContext();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLocalPlayerContext_ULocalPlayer_UWorld(IntPtr inLocalPlayer, IntPtr inWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLocalPlayerContext_APlayerController(IntPtr inPlayerController);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLocalPlayerContext_FLocalPlayerContext(IntPtr inPlayerContext);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FLocalPlayerContext_GetGameState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FLocalPlayerContext_GetHUD(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FLocalPlayerContext_GetLocalPlayer(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FLocalPlayerContext_GetPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FLocalPlayerContext_GetPlayerController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FLocalPlayerContext_GetPlayerState(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FLocalPlayerContext_GetWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FLocalPlayerContext_IsFromLocalPlayer(IntPtr self, IntPtr actorToTest);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FLocalPlayerContext_IsInitialized(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FLocalPlayerContext_IsValid(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Getter for the Game State Base
		/// </summary>
		public AGameStateBase GetGameState()
			=> E_FLocalPlayerContext_GetGameState(this);
		
		
		/// <summary>
		/// Getter for this player's HUD
		/// </summary>
		public AHUD GetHUD()
			=> E_FLocalPlayerContext_GetHUD(this);
		
		
		/// <summary>
		/// Returns the local player.
		/// </summary>
		public ULocalPlayer GetLocalPlayer()
			=> E_FLocalPlayerContext_GetLocalPlayer(this);
		
		
		/// <summary>
		/// Getter for the base pawn of this player
		/// </summary>
		public APawn GetPawn()
			=> E_FLocalPlayerContext_GetPawn(this);
		
		
		/// <summary>
		/// Returns the player controller.
		/// </summary>
		public APlayerController GetPlayerController()
			=> E_FLocalPlayerContext_GetPlayerController(this);
		
		
		/// <summary>
		/// Getter for the Player State
		/// </summary>
		public APlayerState GetPlayerState()
			=> E_FLocalPlayerContext_GetPlayerState(this);
		
		
		/// <summary>
		/// Returns the world context.
		/// </summary>
		public UWorld GetWorld()
			=> E_FLocalPlayerContext_GetWorld(this);
		
		
		/// <summary>
		/// This function tests if the given Actor is connected to the Local Player in any way.
		/// <para>It tests against the APlayerController, APlayerState, and APawn. </para>
		/// </summary>
		public bool IsFromLocalPlayer(AActor actorToTest)
			=> E_FLocalPlayerContext_IsFromLocalPlayer(this, actorToTest);
		
		
		/// <summary>
		/// Is this context initialized
		/// </summary>
		public bool IsInitialized()
			=> E_FLocalPlayerContext_IsInitialized(this);
		
		
		/// <summary>
		/// Is this context initialized and still valid?
		/// </summary>
		public bool IsValid()
			=> E_FLocalPlayerContext_IsValid(this);
		
		#endregion
		
		public static implicit operator IntPtr(FLocalPlayerContext self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FLocalPlayerContext(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FLocalPlayerContext(adress, false);
		}}}
