// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:295

namespace UnrealEngine
{
	public partial class FBehaviorTreeInstance : NativeStructWrapper
	{
		public FBehaviorTreeInstance(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBehaviorTreeInstance() :
			base(E_CreateStruct_FBehaviorTreeInstance(), false)
		{
		}

		public FBehaviorTreeInstance(FBehaviorTreeInstance other) :
			base(E_CreateStruct_FBehaviorTreeInstance_FBehaviorTreeInstance(other), false)
		{
		}

		public FBehaviorTreeInstance(int memorySize) :
			base(E_CreateStruct_FBehaviorTreeInstance_int32(memorySize), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBehaviorTreeInstance_ActiveNode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeInstance_ActiveNode_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBehaviorTreeInstance_InstanceIdIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeInstance_InstanceIdIndex_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBehaviorTreeInstance_RootNode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeInstance_RootNode_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeInstance();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeInstance_FBehaviorTreeInstance(IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeInstance_int32(int memorySize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBehaviorTreeInstance_DecMemoryStats(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBehaviorTreeInstance_IncMemoryStats(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// active node in template
		/// </summary>
		public UBTNode ActiveNode
		{
			get => E_PROP_FBehaviorTreeInstance_ActiveNode_GET(NativePointer);
			set => E_PROP_FBehaviorTreeInstance_ActiveNode_SET(NativePointer, value);
		}

		
		/// <summary>
		/// index of identifier (BehaviorTreeComponent.KnownInstances)
		/// </summary>
		public byte InstanceIdIndex
		{
			get => E_PROP_FBehaviorTreeInstance_InstanceIdIndex_GET(NativePointer);
			set => E_PROP_FBehaviorTreeInstance_InstanceIdIndex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// root node in template
		/// </summary>
		public UBTCompositeNode RootNode
		{
			get => E_PROP_FBehaviorTreeInstance_RootNode_GET(NativePointer);
			set => E_PROP_FBehaviorTreeInstance_RootNode_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void DecMemoryStats()
			=> E_FBehaviorTreeInstance_DecMemoryStats(this);
		
		public void IncMemoryStats()
			=> E_FBehaviorTreeInstance_IncMemoryStats(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBehaviorTreeInstance self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBehaviorTreeInstance(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBehaviorTreeInstance(adress, false);
		}}}
