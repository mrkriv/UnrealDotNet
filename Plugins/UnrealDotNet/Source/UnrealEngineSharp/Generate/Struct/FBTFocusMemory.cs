// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Services\BTService_DefaultFocus.h:15

namespace UnrealEngine
{
	public partial class FBTFocusMemory : NativeStructWrapper
	{
		public FBTFocusMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTFocusMemory() :
			base(E_CreateStruct_FBTFocusMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FBTFocusMemory_bActorSet_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTFocusMemory_bActorSet_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBTFocusMemory_FocusActorSet_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTFocusMemory_FocusActorSet_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBTFocusMemory_FocusLocationSet_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTFocusMemory_FocusLocationSet_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTFocusMemory();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBTFocusMemory_Reset(IntPtr self);
		
		#endregion
		
		#region Property
		public bool bActorSet
		{
			get => E_PROP_FBTFocusMemory_bActorSet_GET(NativePointer);
			set => E_PROP_FBTFocusMemory_bActorSet_SET(NativePointer, value);
		}

		public AActor FocusActorSet
		{
			get => E_PROP_FBTFocusMemory_FocusActorSet_GET(NativePointer);
			set => E_PROP_FBTFocusMemory_FocusActorSet_SET(NativePointer, value);
		}

		public FVector FocusLocationSet
		{
			get => E_PROP_FBTFocusMemory_FocusLocationSet_GET(NativePointer);
			set => E_PROP_FBTFocusMemory_FocusLocationSet_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Reset()
			=> E_FBTFocusMemory_Reset(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBTFocusMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTFocusMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTFocusMemory(adress, false);
		}}}
