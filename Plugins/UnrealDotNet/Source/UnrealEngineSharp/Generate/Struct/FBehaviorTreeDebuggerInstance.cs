// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:212

namespace UnrealEngine
{
	public partial class FBehaviorTreeDebuggerInstance : NativeStructWrapper
	{
		public FBehaviorTreeDebuggerInstance(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBehaviorTreeDebuggerInstance() :
			base(E_CreateStruct_FBehaviorTreeDebuggerInstance(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBehaviorTreeDebuggerInstance_RootNode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeDebuggerInstance_RootNode_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBehaviorTreeDebuggerInstance_TreeAsset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeDebuggerInstance_TreeAsset_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeDebuggerInstance();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBehaviorTreeDebuggerInstance_IsValid(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// root node in template
		/// </summary>
		public UBTCompositeNode RootNode
		{
			get => E_PROP_FBehaviorTreeDebuggerInstance_RootNode_GET(NativePointer);
			set => E_PROP_FBehaviorTreeDebuggerInstance_RootNode_SET(NativePointer, value);
		}

		
		/// <summary>
		/// behavior tree asset
		/// </summary>
		public UBehaviorTree TreeAsset
		{
			get => E_PROP_FBehaviorTreeDebuggerInstance_TreeAsset_GET(NativePointer);
			set => E_PROP_FBehaviorTreeDebuggerInstance_TreeAsset_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool IsValid()
			=> E_FBehaviorTreeDebuggerInstance_IsValid(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBehaviorTreeDebuggerInstance self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBehaviorTreeDebuggerInstance(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBehaviorTreeDebuggerInstance(adress, false);
		}}}
