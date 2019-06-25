// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTNode.h:30

namespace UnrealEngine
{
	public partial class FBTInstancedNodeMemory : NativeStructWrapper
	{
		public FBTInstancedNodeMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTInstancedNodeMemory() :
			base(E_CreateStruct_FBTInstancedNodeMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FBTInstancedNodeMemory_NodeIdx_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTInstancedNodeMemory_NodeIdx_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTInstancedNodeMemory();
		
		#endregion
		
		#region Property
		public int NodeIdx
		{
			get => E_PROP_FBTInstancedNodeMemory_NodeIdx_GET(NativePointer);
			set => E_PROP_FBTInstancedNodeMemory_NodeIdx_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTInstancedNodeMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTInstancedNodeMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTInstancedNodeMemory(adress, false);
		}}}
