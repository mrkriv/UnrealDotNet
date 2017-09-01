using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// FWorldContext
	/// A context for dealing with UWorlds at the engine level. As the engine brings up and destroys world, we need a way to keep straight
	/// what world belongs to what.
	/// WorldContexts can be thought of as a track. By default we have 1 track that we load and unload levels on. Adding a second context is adding
	/// a second track; another track of progression for worlds to live on.
	/// For the GameEngine, there will be one WorldContext until we decide to support multiple simultaneous worlds.
	/// For the EditorEngine, there may be one WorldContext for the EditorWorld and one for the PIE World.
	/// FWorldContext provides both a way to manage 'the current PIE UWorld*' as well as state that goes along with connecting/travelling to
	/// new worlds.
	/// FWorldContext should remain internal to the UEngine classes. Outside code should not keep pointers or try to manage FWorldContexts directly.
	/// Outside code can steal deal with UWorld*, and pass UWorld*s into Engine level functions. The Engine code can look up the relevant context
	/// for a given UWorld*.
	/// For convenience, FWorldContext can maintain outside pointers to UWorld*s. For example, PIE can tie UWorld* UEditorEngine::PlayWorld to the PIE
	/// world context. If the PIE UWorld changes, the UEditorEngine::PlayWorld pointer will be automatically updated. This is done with AddRef() and
	/// SetCurrentWorld().
	/// </summary>
	public partial class FWorldContext
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FWorldContext()
		{
			NativePointer = E_CreateStruct_FWorldContext();
			IsRef = false;
		}

		internal FWorldContext(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FWorldContext();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FWorldContext_ContextHandle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWorldContext_ContextHandle_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FWorldContext_TravelURL_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWorldContext_TravelURL_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_FWorldContext_TravelType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWorldContext_TravelType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FWorldContext_PendingMapChangeFailureDescription_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWorldContext_PendingMapChangeFailureDescription_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FWorldContext_PIEInstance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWorldContext_PIEInstance_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FWorldContext_PIEPrefix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWorldContext_PIEPrefix_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FWorldContext_PIERemapPrefix_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWorldContext_PIERemapPrefix_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FWorldContext_RunAsDedicated_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWorldContext_RunAsDedicated_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FWorldContext_SetCurrentWorld(FWorldContext Self, IntPtr World);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FWorldContext_World(FWorldContext Self);
		
		#endregion
		
		#region Property
		public string ContextHandle
		{
			get => E_PROP_FWorldContext_ContextHandle_GET(NativePointer);
			set => E_PROP_FWorldContext_ContextHandle_SET(NativePointer, value);
		}

		
		/// <summary>
		/// URL to travel to for pending client connect
		/// </summary>
		public string TravelURL
		{
			get => E_PROP_FWorldContext_TravelURL_GET(NativePointer);
			set => E_PROP_FWorldContext_TravelURL_SET(NativePointer, value);
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
		/// Human readable error string for any failure during a map change request. Empty if there were no failures.
		/// </summary>
		public string PendingMapChangeFailureDescription
		{
			get => E_PROP_FWorldContext_PendingMapChangeFailureDescription_GET(NativePointer);
			set => E_PROP_FWorldContext_PendingMapChangeFailureDescription_SET(NativePointer, value);
		}

		public int PIEInstance
		{
			get => E_PROP_FWorldContext_PIEInstance_GET(NativePointer);
			set => E_PROP_FWorldContext_PIEInstance_SET(NativePointer, value);
		}

		public string PIEPrefix
		{
			get => E_PROP_FWorldContext_PIEPrefix_GET(NativePointer);
			set => E_PROP_FWorldContext_PIEPrefix_SET(NativePointer, value);
		}

		public string PIERemapPrefix
		{
			get => E_PROP_FWorldContext_PIERemapPrefix_GET(NativePointer);
			set => E_PROP_FWorldContext_PIERemapPrefix_SET(NativePointer, value);
		}

		public bool RunAsDedicated
		{
			get => E_PROP_FWorldContext_RunAsDedicated_GET(NativePointer);
			set => E_PROP_FWorldContext_RunAsDedicated_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Is this world context waiting for an online login to complete (for PIE)
		/// </summary>
		public bool bWaitingOnOnlineSubsystem
		{
			get => E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_GET(NativePointer);
			set => E_PROP_FWorldContext_bWaitingOnOnlineSubsystem_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Set CurrentWorld and update external reference pointers to reflect this
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
