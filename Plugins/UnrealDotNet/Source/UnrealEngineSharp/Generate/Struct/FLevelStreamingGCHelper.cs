// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\World.h:249

namespace UnrealEngine
{
	public  partial class FLevelStreamingGCHelper : NativeStructWrapper
	{
		internal FLevelStreamingGCHelper(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLevelStreamingGCHelper() :
			base(E_CreateStruct_FLevelStreamingGCHelper(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelStreamingGCHelper();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLevelStreamingGCHelper_PrepareStreamedOutLevelsForGC(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FLevelStreamingGCHelper_VerifyLevelsGotRemovedByGC(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Register with the garbage collector to receive callbacks pre and post garbage collection
		/// </summary>
		public void AddGarbageCollectorCallback()
			=> E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>The</return>
		public int GetNumLevelsPendingPurge()
			=> E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(this);
		
		
		/// <summary>
		/// Prepares levels that are marked for unload for the GC call by marking their actors and components as
		/// <para>pending kill. </para>
		/// </summary>
		public void PrepareStreamedOutLevelsForGC()
			=> E_FLevelStreamingGCHelper_PrepareStreamedOutLevelsForGC(this);
		
		
		/// <summary>
		/// Verify that the level packages are no longer around.
		/// </summary>
		public void VerifyLevelsGotRemovedByGC()
			=> E_FLevelStreamingGCHelper_VerifyLevelsGotRemovedByGC(this);
		
		#endregion
		
		public static implicit operator IntPtr(FLevelStreamingGCHelper self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FLevelStreamingGCHelper(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FLevelStreamingGCHelper(adress, false);
		}}}
