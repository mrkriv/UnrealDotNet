// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:295

namespace UnrealEngine
{
	public partial class FWorldContext : NativeStructWrapper
	{
		public FWorldContext(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FWorldContext() :
			base(E_CreateStruct_FWorldContext(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FWorldContext_ContextHandle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_ContextHandle_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FWorldContext_GameViewport_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_GameViewport_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FWorldContext_LastRemoteURL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_LastRemoteURL_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FWorldContext_LastURL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_LastURL_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FWorldContext_PendingMapChangeFailureDescription_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_PendingMapChangeFailureDescription_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FWorldContext_PIEInstance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_PIEInstance_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FWorldContext_PIEPrefix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_PIEPrefix_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FWorldContext_RunAsDedicated_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_RunAsDedicated_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FWorldContext_TravelType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_TravelType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FWorldContext_TravelURL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_TravelURL_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWorldContext();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FWorldContext_SetCurrentWorld(IntPtr self, IntPtr world);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FWorldContext_World(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Is this world context waiting for an online login to complete (for PIE)
		/// </summary>
		public bool bWaitingOnOnlineSubsystem
		{
			get => E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_GET(NativePointer);
			set => E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_SET(NativePointer, value);
		}

		public string ContextHandle
		{
			get => E_PROP_FWorldContext_ContextHandle_GET(NativePointer);
			set => E_PROP_FWorldContext_ContextHandle_SET(NativePointer, value);
		}

		public UGameViewportClient GameViewport
		{
			get => E_PROP_FWorldContext_GameViewport_GET(NativePointer);
			set => E_PROP_FWorldContext_GameViewport_SET(NativePointer, value);
		}

		public FURL LastRemoteURL
		{
			get => E_PROP_FWorldContext_LastRemoteURL_GET(NativePointer);
			set => E_PROP_FWorldContext_LastRemoteURL_SET(NativePointer, value);
		}

		public FURL LastURL
		{
			get => E_PROP_FWorldContext_LastURL_GET(NativePointer);
			set => E_PROP_FWorldContext_LastURL_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Human readable error string for any failure during a map change request. Empty if there were no failures.
		/// </summary>
		public string PendingMapChangeFailureDescription
		{
			get => E_PROP_FWorldContext_PendingMapChangeFailureDescription_GET(NativePointer);
			set => E_PROP_FWorldContext_PendingMapChangeFailureDescription_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The PIE instance of this world, -1 is default
		/// </summary>
		public int PIEInstance
		{
			get => E_PROP_FWorldContext_PIEInstance_GET(NativePointer);
			set => E_PROP_FWorldContext_PIEInstance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The Prefix in front of PIE level names, empty is default
		/// </summary>
		public string PIEPrefix
		{
			get => E_PROP_FWorldContext_PIEPrefix_GET(NativePointer);
			set => E_PROP_FWorldContext_PIEPrefix_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Is this running as a dedicated server
		/// </summary>
		public bool RunAsDedicated
		{
			get => E_PROP_FWorldContext_RunAsDedicated_GET(NativePointer);
			set => E_PROP_FWorldContext_RunAsDedicated_SET(NativePointer, value);
		}

		
		/// <summary>
		/// TravelType for pending client connects
		/// </summary>
		public byte TravelType
		{
			get => E_PROP_FWorldContext_TravelType_GET(NativePointer);
			set => E_PROP_FWorldContext_TravelType_SET(NativePointer, value);
		}

		
		/// <summary>
		/// URL to travel to for pending client connect
		/// </summary>
		public string TravelURL
		{
			get => E_PROP_FWorldContext_TravelURL_GET(NativePointer);
			set => E_PROP_FWorldContext_TravelURL_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Set CurrentWorld and update external reference pointers to reflect this
		/// </summary>
		public void SetCurrentWorld(UWorld world)
			=> E_FWorldContext_SetCurrentWorld(this, world);
		
		public UWorld World()
			=> E_FWorldContext_World(this);
		
		#endregion
		
		public static implicit operator IntPtr(FWorldContext self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FWorldContext(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FWorldContext(adress, false);
		}}}
