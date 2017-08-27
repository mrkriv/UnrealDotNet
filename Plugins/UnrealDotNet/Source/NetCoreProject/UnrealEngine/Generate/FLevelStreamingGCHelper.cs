using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Helper structure encapsulating functionality used to defer marking actors and their components as pending
	/// kill till right before garbage collection by registering a callback.
	/// </summary>
	public partial struct FLevelStreamingGCHelper
	{
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(FLevelStreamingGCHelper Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern int E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(FLevelStreamingGCHelper Self);
		
		#endregion
		
		#region Property
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Register with the garbage collector to receive callbacks pre and post garbage collection
		/// </summary>
		public void AddGarbageCollectorCallback()
			=> E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(this);
		
		
		/// <summary>
		/// @return	The number of levels pending a purge by the garbage collector
		/// </summary>
		public int GetNumLevelsPendingPurge()
			=> E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(this);
		
		#endregion
		
	}}
