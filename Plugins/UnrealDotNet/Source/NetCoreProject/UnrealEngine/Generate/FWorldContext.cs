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
	public partial struct FWorldContext
	{
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FWorldContext_AddRef(FWorldContext Self, UWorld WorldPtr);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FWorldContext_SetCurrentWorld(FWorldContext Self, UWorld World);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern UWorld E_FWorldContext_World(FWorldContext Self);
		
		#endregion
		
		#region Property
		public FSeamlessTravelHandler SeamlessTravelHandler { get; set; } 
		
		/// <summary>
		/// TravelType for pending client connects
		/// </summary>
		public byte TravelType { get; set; } 
		public int PIEInstance { get; set; } 
		public bool RunAsDedicated { get; set; } 
		
		/// <summary>
		/// Is this world context waiting for an online login to complete (for PIE)
		/// </summary>
		public bool bWaitingOnOnlineSubsystem { get; set; } 
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Adds an external reference
		/// </summary>
		public void AddRef(UWorld WorldPtr)
			=> E_FWorldContext_AddRef(this, WorldPtr);
		
		
		/// <summary>
		/// Set CurrentWorld and update external reference pointers to reflect this
		/// </summary>
		public void SetCurrentWorld(UWorld World)
			=> E_FWorldContext_SetCurrentWorld(this, World);
		
		public UWorld World()
			=> E_FWorldContext_World(this);
		
		#endregion
		
	}}
