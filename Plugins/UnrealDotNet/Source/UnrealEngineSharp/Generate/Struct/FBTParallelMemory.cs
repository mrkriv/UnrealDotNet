// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Composites\BTComposite_SimpleParallel.h:31

namespace UnrealEngine
{
	public partial class FBTParallelMemory : FBTCompositeMemory
	{
		public FBTParallelMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTParallelMemory() :
			base(E_CreateStruct_FBTParallelMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTParallelMemory_bForceBackgroundTree_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTParallelMemory_bForceBackgroundTree_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTParallelMemory_bMainTaskIsActive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTParallelMemory_bMainTaskIsActive_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTParallelMemory_bRepeatMainTask_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTParallelMemory_bRepeatMainTask_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FBTParallelMemory_LastSearchId_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTParallelMemory_LastSearchId_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTParallelMemory();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// try running background tree task even if main task has finished
		/// </summary>
		public byte bForceBackgroundTree
		{
			get => E_PROP_FBTParallelMemory_bForceBackgroundTree_GET(NativePointer);
			set => E_PROP_FBTParallelMemory_bForceBackgroundTree_SET(NativePointer, value);
		}

		
		/// <summary>
		/// set when main task is running
		/// </summary>
		public byte bMainTaskIsActive
		{
			get => E_PROP_FBTParallelMemory_bMainTaskIsActive_GET(NativePointer);
			set => E_PROP_FBTParallelMemory_bMainTaskIsActive_SET(NativePointer, value);
		}

		
		/// <summary>
		/// set when main task needs to be repeated
		/// </summary>
		public byte bRepeatMainTask
		{
			get => E_PROP_FBTParallelMemory_bRepeatMainTask_GET(NativePointer);
			set => E_PROP_FBTParallelMemory_bRepeatMainTask_SET(NativePointer, value);
		}

		
		/// <summary>
		/// last Id of search, detect infinite loops when there isn't any valid task in background tree
		/// </summary>
		public int LastSearchId
		{
			get => E_PROP_FBTParallelMemory_LastSearchId_GET(NativePointer);
			set => E_PROP_FBTParallelMemory_LastSearchId_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTParallelMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTParallelMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTParallelMemory(adress, false);
		}}}
