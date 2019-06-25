// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_ConeCheck.h:15

namespace UnrealEngine
{
	public partial class FBTConeCheckDecoratorMemory : NativeStructWrapper
	{
		public FBTConeCheckDecoratorMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTConeCheckDecoratorMemory() :
			base(E_CreateStruct_FBTConeCheckDecoratorMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FBTConeCheckDecoratorMemory_bLastRawResult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTConeCheckDecoratorMemory_bLastRawResult_SET(IntPtr Ptr, bool Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTConeCheckDecoratorMemory();
		
		#endregion
		
		#region Property
		public bool bLastRawResult
		{
			get => E_PROP_FBTConeCheckDecoratorMemory_bLastRawResult_GET(NativePointer);
			set => E_PROP_FBTConeCheckDecoratorMemory_bLastRawResult_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTConeCheckDecoratorMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTConeCheckDecoratorMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTConeCheckDecoratorMemory(adress, false);
		}}}
