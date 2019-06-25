// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_Loop.h:9

namespace UnrealEngine
{
	public partial class FBTLoopDecoratorMemory : NativeStructWrapper
	{
		public FBTLoopDecoratorMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTLoopDecoratorMemory() :
			base(E_CreateStruct_FBTLoopDecoratorMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTLoopDecoratorMemory_RemainingExecutions_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTLoopDecoratorMemory_RemainingExecutions_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FBTLoopDecoratorMemory_SearchId_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTLoopDecoratorMemory_SearchId_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBTLoopDecoratorMemory_TimeStarted_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTLoopDecoratorMemory_TimeStarted_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTLoopDecoratorMemory();
		
		#endregion
		
		#region Property
		public byte RemainingExecutions
		{
			get => E_PROP_FBTLoopDecoratorMemory_RemainingExecutions_GET(NativePointer);
			set => E_PROP_FBTLoopDecoratorMemory_RemainingExecutions_SET(NativePointer, value);
		}

		public int SearchId
		{
			get => E_PROP_FBTLoopDecoratorMemory_SearchId_GET(NativePointer);
			set => E_PROP_FBTLoopDecoratorMemory_SearchId_SET(NativePointer, value);
		}

		public float TimeStarted
		{
			get => E_PROP_FBTLoopDecoratorMemory_TimeStarted_GET(NativePointer);
			set => E_PROP_FBTLoopDecoratorMemory_TimeStarted_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTLoopDecoratorMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTLoopDecoratorMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTLoopDecoratorMemory(adress, false);
		}}}
