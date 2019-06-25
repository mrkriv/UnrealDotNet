// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_GameplayTaskBase.h:10

namespace UnrealEngine
{
	public partial class FBTGameplayTaskMemory : NativeStructWrapper
	{
		public FBTGameplayTaskMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTGameplayTaskMemory() :
			base(E_CreateStruct_FBTGameplayTaskMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTGameplayTaskMemory_bObserverCanFinishTask_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTGameplayTaskMemory_bObserverCanFinishTask_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTGameplayTaskMemory();
		
		#endregion
		
		#region Property
		public byte bObserverCanFinishTask
		{
			get => E_PROP_FBTGameplayTaskMemory_bObserverCanFinishTask_GET(NativePointer);
			set => E_PROP_FBTGameplayTaskMemory_bObserverCanFinishTask_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTGameplayTaskMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTGameplayTaskMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTGameplayTaskMemory(adress, false);
		}}}
