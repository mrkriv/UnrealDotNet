using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Helper structure encapsulating functionality used to defer marking actors and their components as pending
	/// kill till right before garbage collection by registering a callback.
	/// </summary>
	public partial class FLevelStreamingGCHelper
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FLevelStreamingGCHelper()
		{
			NativePointer = E_CreateStruct_FLevelStreamingGCHelper();
			IsRef = false;
		}

		internal FLevelStreamingGCHelper(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_CreateStruct_FLevelStreamingGCHelper();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
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
		
		public static implicit operator IntPtr(FLevelStreamingGCHelper Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLevelStreamingGCHelper(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelStreamingGCHelper(Adress, false);
		}}}
