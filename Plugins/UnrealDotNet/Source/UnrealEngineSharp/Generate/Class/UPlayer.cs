// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

namespace UnrealEngine
{
	public partial class UPlayer : UObject
	{
		public UPlayer(IntPtr adress)
			: base(adress)
		{
		}

		public UPlayer(UObject Parent = null, string Name = "Player")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPlayer(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPlayer_ConfiguredInternetSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlayer_ConfiguredInternetSpeed_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPlayer_ConfiguredLanSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlayer_ConfiguredLanSpeed_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UPlayer_CurrentNetSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlayer_CurrentNetSpeed_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UPlayer_PlayerController_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPlayer_PlayerController_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPlayer(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UPlayer_ConsoleCommand(IntPtr self, string cmd, bool bWriteToLog);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPlayer_GetPlayerController(IntPtr self, IntPtr inWorld);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPlayer_SwitchController(IntPtr self, IntPtr pC);
		
		#endregion
		
		#region Property
		public int ConfiguredInternetSpeed
		{
			get => E_PROP_UPlayer_ConfiguredInternetSpeed_GET(NativePointer);
			set => E_PROP_UPlayer_ConfiguredInternetSpeed_SET(NativePointer, value);
		}

		public int ConfiguredLanSpeed
		{
			get => E_PROP_UPlayer_ConfiguredLanSpeed_GET(NativePointer);
			set => E_PROP_UPlayer_ConfiguredLanSpeed_SET(NativePointer, value);
		}

		public int CurrentNetSpeed
		{
			get => E_PROP_UPlayer_CurrentNetSpeed_GET(NativePointer);
			set => E_PROP_UPlayer_CurrentNetSpeed_SET(NativePointer, value);
		}

		public APlayerController PlayerController
		{
			get => E_PROP_UPlayer_PlayerController_GET(NativePointer);
			set => E_PROP_UPlayer_PlayerController_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Executes the Exec() command
		/// </summary>
		/// <param name="command">command to execute (string of commands optionally separated by a | (pipe))</param>
		/// <param name="bWriteToLog">write out to the log</param>
		public string ConsoleCommand(string cmd, bool bWriteToLog = true)
			=> E_UPlayer_ConsoleCommand(this, cmd, bWriteToLog);
		
		
		/// <summary>
		/// Gets the player controller in the given world for this player.
		/// </summary>
		/// <param name="inWorld">The world in which to search for player controllers.</param>
		/// <return>The</return>
		public APlayerController GetPlayerController(UWorld inWorld)
			=> E_UPlayer_GetPlayerController(this, inWorld);
		
		
		/// <summary>
		/// Dynamically assign Controller to Player and set viewport.
		/// </summary>
		/// <param name="pC">new player controller to assign to player</param>
		public virtual void SwitchController(APlayerController pC)
			=> E_UPlayer_SwitchController(this, pC);
		
		#endregion
		
		public static implicit operator IntPtr(UPlayer self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPlayer(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPlayer>(PtrDesc);
		}}}
