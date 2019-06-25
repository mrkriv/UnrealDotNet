// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_TagCooldown.h:11

namespace UnrealEngine
{
	public partial class FBTTagCooldownDecoratorMemory : NativeStructWrapper
	{
		public FBTTagCooldownDecoratorMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTTagCooldownDecoratorMemory() :
			base(E_CreateStruct_FBTTagCooldownDecoratorMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTTagCooldownDecoratorMemory_bRequestedRestart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTTagCooldownDecoratorMemory_bRequestedRestart_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTTagCooldownDecoratorMemory();
		
		#endregion
		
		#region Property
		public byte bRequestedRestart
		{
			get => E_PROP_FBTTagCooldownDecoratorMemory_bRequestedRestart_GET(NativePointer);
			set => E_PROP_FBTTagCooldownDecoratorMemory_bRequestedRestart_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTTagCooldownDecoratorMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTTagCooldownDecoratorMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTTagCooldownDecoratorMemory(adress, false);
		}}}
