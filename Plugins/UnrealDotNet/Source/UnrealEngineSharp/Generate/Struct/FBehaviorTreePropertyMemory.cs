// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:462

namespace UnrealEngine
{
	public partial class FBehaviorTreePropertyMemory : NativeStructWrapper
	{
		public FBehaviorTreePropertyMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBehaviorTreePropertyMemory() :
			base(E_CreateStruct_FBehaviorTreePropertyMemory(), false)
		{
		}

		public FBehaviorTreePropertyMemory(int value) :
			base(E_CreateStruct_FBehaviorTreePropertyMemory_int32(value), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreePropertyMemory();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreePropertyMemory_int32(int value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FBehaviorTreePropertyMemory_Pack(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public int Pack()
			=> E_FBehaviorTreePropertyMemory_Pack(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBehaviorTreePropertyMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBehaviorTreePropertyMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBehaviorTreePropertyMemory(adress, false);
		}}}
