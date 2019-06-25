// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_KeepInCone.h:13

namespace UnrealEngine
{
	public partial class FBTKeepInConeDecoratorMemory : NativeStructWrapper
	{
		public FBTKeepInConeDecoratorMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTKeepInConeDecoratorMemory() :
			base(E_CreateStruct_FBTKeepInConeDecoratorMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBTKeepInConeDecoratorMemory_InitialDirection_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTKeepInConeDecoratorMemory_InitialDirection_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTKeepInConeDecoratorMemory();
		
		#endregion
		
		#region Property
		public FVector InitialDirection
		{
			get => E_PROP_FBTKeepInConeDecoratorMemory_InitialDirection_GET(NativePointer);
			set => E_PROP_FBTKeepInConeDecoratorMemory_InitialDirection_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTKeepInConeDecoratorMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTKeepInConeDecoratorMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTKeepInConeDecoratorMemory(adress, false);
		}}}
