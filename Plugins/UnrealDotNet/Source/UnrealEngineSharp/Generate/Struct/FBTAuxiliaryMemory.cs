// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTAuxiliaryNode.h:10

namespace UnrealEngine
{
	public partial class FBTAuxiliaryMemory : FBTInstancedNodeMemory
	{
		public FBTAuxiliaryMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTAuxiliaryMemory() :
			base(E_CreateStruct_FBTAuxiliaryMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBTAuxiliaryMemory_AccumulatedDeltaTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTAuxiliaryMemory_AccumulatedDeltaTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBTAuxiliaryMemory_NextTickRemainingTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTAuxiliaryMemory_NextTickRemainingTime_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTAuxiliaryMemory();
		
		#endregion
		
		#region Property
		public float AccumulatedDeltaTime
		{
			get => E_PROP_FBTAuxiliaryMemory_AccumulatedDeltaTime_GET(NativePointer);
			set => E_PROP_FBTAuxiliaryMemory_AccumulatedDeltaTime_SET(NativePointer, value);
		}

		public float NextTickRemainingTime
		{
			get => E_PROP_FBTAuxiliaryMemory_NextTickRemainingTime_GET(NativePointer);
			set => E_PROP_FBTAuxiliaryMemory_NextTickRemainingTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTAuxiliaryMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTAuxiliaryMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTAuxiliaryMemory(adress, false);
		}}}
