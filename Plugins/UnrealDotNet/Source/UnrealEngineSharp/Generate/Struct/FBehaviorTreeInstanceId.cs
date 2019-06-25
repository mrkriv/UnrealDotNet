// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:266

namespace UnrealEngine
{
	public partial class FBehaviorTreeInstanceId : NativeStructWrapper
	{
		public FBehaviorTreeInstanceId(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBehaviorTreeInstanceId() :
			base(E_CreateStruct_FBehaviorTreeInstanceId(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FBehaviorTreeInstanceId_FirstNodeInstance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeInstanceId_FirstNodeInstance_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBehaviorTreeInstanceId_RootNode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeInstanceId_RootNode_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBehaviorTreeInstanceId_TreeAsset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeInstanceId_TreeAsset_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeInstanceId();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// index of first node instance (BehaviorTreeComponent.NodeInstances)
		/// </summary>
		public int FirstNodeInstance
		{
			get => E_PROP_FBehaviorTreeInstanceId_FirstNodeInstance_GET(NativePointer);
			set => E_PROP_FBehaviorTreeInstanceId_FirstNodeInstance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// root node in template for cleanup purposes
		/// </summary>
		public UBTCompositeNode RootNode
		{
			get => E_PROP_FBehaviorTreeInstanceId_RootNode_GET(NativePointer);
			set => E_PROP_FBehaviorTreeInstanceId_RootNode_SET(NativePointer, value);
		}

		
		/// <summary>
		/// behavior tree asset
		/// </summary>
		public UBehaviorTree TreeAsset
		{
			get => E_PROP_FBehaviorTreeInstanceId_TreeAsset_GET(NativePointer);
			set => E_PROP_FBehaviorTreeInstanceId_TreeAsset_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBehaviorTreeInstanceId self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBehaviorTreeInstanceId(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBehaviorTreeInstanceId(adress, false);
		}}}
