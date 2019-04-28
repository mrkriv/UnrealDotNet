// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:362

namespace UnrealEngine
{
	public  partial class FBroadphaseSettings : NativeStructWrapper
	{
		internal FBroadphaseSettings(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBroadphaseSettings() :
			base(E_CreateStruct_FBroadphaseSettings(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FBroadphaseSettings_bUseMBPOnClient_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBroadphaseSettings_bUseMBPOnClient_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FBroadphaseSettings_bUseMBPOnServer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBroadphaseSettings_bUseMBPOnServer_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBroadphaseSettings_MBPBounds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBroadphaseSettings_MBPBounds_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBroadphaseSettings();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether to use MBP (Multi Broadphase Pruning
		/// </summary>
		public bool bUseMBPOnClient
		{
			get => E_PROP_FBroadphaseSettings_bUseMBPOnClient_GET(NativePointer);
			set => E_PROP_FBroadphaseSettings_bUseMBPOnClient_SET(NativePointer, value);
		}

		public bool bUseMBPOnServer
		{
			get => E_PROP_FBroadphaseSettings_bUseMBPOnServer_GET(NativePointer);
			set => E_PROP_FBroadphaseSettings_bUseMBPOnServer_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Total bounds for MBP, must cover the game world or collisions are disabled for out of bounds actors
		/// </summary>
		public FBox MBPBounds
		{
			get => E_PROP_FBroadphaseSettings_MBPBounds_GET(NativePointer);
			set => E_PROP_FBroadphaseSettings_MBPBounds_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBroadphaseSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator FBroadphaseSettings(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBroadphaseSettings(Adress, false);
		}}}
