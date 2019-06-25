// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_Loop.h:21

namespace UnrealEngine
{
	public partial class UBTDecorator_Loop : UBTDecorator
	{
		public UBTDecorator_Loop(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_Loop(UObject Parent = null, string Name = "BTDecorator_Loop")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_Loop(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UBTDecorator_Loop_bInfiniteLoop_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_Loop_bInfiniteLoop_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTDecorator_Loop_InfiniteLoopTimeoutTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_Loop_InfiniteLoopTimeoutTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UBTDecorator_Loop_NumLoops_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTDecorator_Loop_NumLoops_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_Loop(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// infinite loop
		/// </summary>
		public bool bInfiniteLoop
		{
			get => E_PROP_UBTDecorator_Loop_bInfiniteLoop_GET(NativePointer);
			set => E_PROP_UBTDecorator_Loop_bInfiniteLoop_SET(NativePointer, value);
		}

		
		/// <summary>
		/// timeout (when looping infinitely, when we finish a loop we will check whether we have spent this time looping, if we have we will stop looping). A negative value means loop forever.
		/// </summary>
		public float InfiniteLoopTimeoutTime
		{
			get => E_PROP_UBTDecorator_Loop_InfiniteLoopTimeoutTime_GET(NativePointer);
			set => E_PROP_UBTDecorator_Loop_InfiniteLoopTimeoutTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// number of executions
		/// </summary>
		public int NumLoops
		{
			get => E_PROP_UBTDecorator_Loop_NumLoops_GET(NativePointer);
			set => E_PROP_UBTDecorator_Loop_NumLoops_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_Loop self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_Loop(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_Loop>(PtrDesc);
		}}}
