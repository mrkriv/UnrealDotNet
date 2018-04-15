using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:267

namespace UnrealEngine
{
	public  partial class FWorldContext : NativeStructWrapper
	{
		internal FWorldContext(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FWorldContext() :
			base(E_CreateStruct_FWorldContext(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWorldContext();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FWorldContext_ContextHandle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWorldContext_ContextHandle_SET(IntPtr Ptr, string Value);
		
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
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FWorldContext_SetCurrentWorld(IntPtr Self, IntPtr World);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FWorldContext_World(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Is this world context waiting for an online login to complete (for PIE) </para>
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
		/// <para>Human readable error string for any failure during a map change request. Empty if there were no failures. </para>
		/// </summary>
		public string PendingMapChangeFailureDescription
		{
			get => E_PROP_FWorldContext_PendingMapChangeFailureDescription_GET(NativePointer);
			set => E_PROP_FWorldContext_PendingMapChangeFailureDescription_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The PIE instance of this world, -1 is default </para>
		/// </summary>
		public int PIEInstance
		{
			get => E_PROP_FWorldContext_PIEInstance_GET(NativePointer);
			set => E_PROP_FWorldContext_PIEInstance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The Prefix in front of PIE level names, empty is default </para>
		/// </summary>
		public string PIEPrefix
		{
			get => E_PROP_FWorldContext_PIEPrefix_GET(NativePointer);
			set => E_PROP_FWorldContext_PIEPrefix_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Is this running as a dedicated server </para>
		/// </summary>
		public bool RunAsDedicated
		{
			get => E_PROP_FWorldContext_RunAsDedicated_GET(NativePointer);
			set => E_PROP_FWorldContext_RunAsDedicated_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>TravelType for pending client connects </para>
		/// </summary>
		public byte TravelType
		{
			get => E_PROP_FWorldContext_TravelType_GET(NativePointer);
			set => E_PROP_FWorldContext_TravelType_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>URL to travel to for pending client connect </para>
		/// </summary>
		public string TravelURL
		{
			get => E_PROP_FWorldContext_TravelURL_GET(NativePointer);
			set => E_PROP_FWorldContext_TravelURL_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Set CurrentWorld and update external reference pointers to reflect this </para>
		/// </summary>
		public void SetCurrentWorld(UWorld World)
			=> E_FWorldContext_SetCurrentWorld(this, World);
		
		public UWorld World()
			=> E_FWorldContext_World(this);
		
		#endregion
		
		public static implicit operator IntPtr(FWorldContext Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FWorldContext(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWorldContext(Adress, false);
		}}}
