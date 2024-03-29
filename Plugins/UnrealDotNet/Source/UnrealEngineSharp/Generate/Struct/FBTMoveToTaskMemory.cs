// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_MoveTo.h:17

namespace UnrealEngine
{
	public partial class FBTMoveToTaskMemory : NativeStructWrapper
	{
		public FBTMoveToTaskMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTMoveToTaskMemory() :
			base(E_CreateStruct_FBTMoveToTaskMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTMoveToTaskMemory_bObserverCanFinishTask_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTMoveToTaskMemory_bObserverCanFinishTask_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTMoveToTaskMemory_bWaitingForPath_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTMoveToTaskMemory_bWaitingForPath_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBTMoveToTaskMemory_PreviousGoalLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTMoveToTaskMemory_PreviousGoalLocation_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTMoveToTaskMemory();
		
		#endregion
		
		#region Property
		public byte bObserverCanFinishTask
		{
			get => E_PROP_FBTMoveToTaskMemory_bObserverCanFinishTask_GET(NativePointer);
			set => E_PROP_FBTMoveToTaskMemory_bObserverCanFinishTask_SET(NativePointer, value);
		}

		public byte bWaitingForPath
		{
			get => E_PROP_FBTMoveToTaskMemory_bWaitingForPath_GET(NativePointer);
			set => E_PROP_FBTMoveToTaskMemory_bWaitingForPath_SET(NativePointer, value);
		}

		public FVector PreviousGoalLocation
		{
			get => E_PROP_FBTMoveToTaskMemory_PreviousGoalLocation_GET(NativePointer);
			set => E_PROP_FBTMoveToTaskMemory_PreviousGoalLocation_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTMoveToTaskMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTMoveToTaskMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTMoveToTaskMemory(adress, false);
		}}}
