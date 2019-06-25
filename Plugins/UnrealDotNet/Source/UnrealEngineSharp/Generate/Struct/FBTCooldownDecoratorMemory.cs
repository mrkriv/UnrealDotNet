// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_Cooldown.h:10

namespace UnrealEngine
{
	public partial class FBTCooldownDecoratorMemory : NativeStructWrapper
	{
		public FBTCooldownDecoratorMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTCooldownDecoratorMemory() :
			base(E_CreateStruct_FBTCooldownDecoratorMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTCooldownDecoratorMemory_bRequestedRestart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTCooldownDecoratorMemory_bRequestedRestart_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBTCooldownDecoratorMemory_LastUseTimestamp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTCooldownDecoratorMemory_LastUseTimestamp_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTCooldownDecoratorMemory();
		
		#endregion
		
		#region Property
		public byte bRequestedRestart
		{
			get => E_PROP_FBTCooldownDecoratorMemory_bRequestedRestart_GET(NativePointer);
			set => E_PROP_FBTCooldownDecoratorMemory_bRequestedRestart_SET(NativePointer, value);
		}

		public float LastUseTimestamp
		{
			get => E_PROP_FBTCooldownDecoratorMemory_LastUseTimestamp_GET(NativePointer);
			set => E_PROP_FBTCooldownDecoratorMemory_LastUseTimestamp_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTCooldownDecoratorMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTCooldownDecoratorMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTCooldownDecoratorMemory(adress, false);
		}}}
