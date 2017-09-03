using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageLevelStreamingGCHelper
	/// <para>Helper structure encapsulating functionality used to defer marking actors and their components as pending </para>
	/// <para>kill till right before garbage collection by registering a callback. </para>
	/// </summary>
	public  partial class FLevelStreamingGCHelper : NativeStructWrapper
	{
		public FLevelStreamingGCHelper() : base(E_CreateStruct_FLevelStreamingGCHelper(), false)
		{
		}

		internal FLevelStreamingGCHelper(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FLevelStreamingGCHelper();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(FLevelStreamingGCHelper Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(FLevelStreamingGCHelper Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FLevelStreamingGCHelper_PrepareStreamedOutLevelsForGC(FLevelStreamingGCHelper Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FLevelStreamingGCHelper_VerifyLevelsGotRemovedByGC(FLevelStreamingGCHelper Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Register with the garbage collector to receive callbacks pre and post garbage collection </para>
		/// </summary>
		public void AddGarbageCollectorCallback()
			=> E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(this);
		
		
		/// <summary>
		/// <return>The number of levels pending a purge by the garbage collector </return>
		/// </summary>
		public int GetNumLevelsPendingPurge()
			=> E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(this);
		
		
		/// <summary>
		/// <para>Prepares levels that are marked for unload for the GC call by marking their actors and components as </para>
		/// <para>pending kill. </para>
		/// </summary>
		public void PrepareStreamedOutLevelsForGC()
			=> E_FLevelStreamingGCHelper_PrepareStreamedOutLevelsForGC(this);
		
		
		/// <summary>
		/// <para>Verify that the level packages are no longer around. </para>
		/// </summary>
		public void VerifyLevelsGotRemovedByGC()
			=> E_FLevelStreamingGCHelper_VerifyLevelsGotRemovedByGC(this);
		
		#endregion
		
		public static implicit operator IntPtr(FLevelStreamingGCHelper Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLevelStreamingGCHelper(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelStreamingGCHelper(Adress, false);
		}}}
