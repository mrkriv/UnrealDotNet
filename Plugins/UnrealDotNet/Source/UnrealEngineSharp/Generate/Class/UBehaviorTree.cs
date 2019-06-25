// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTree.h:15

namespace UnrealEngine
{
	public partial class UBehaviorTree : UObject
	{
		public UBehaviorTree(IntPtr adress)
			: base(adress)
		{
		}

		public UBehaviorTree(UObject Parent = null, string Name = "BehaviorTree")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBehaviorTree(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UBehaviorTree_RootNode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBehaviorTree_RootNode_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBehaviorTree(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		public UBTCompositeNode RootNode
		{
			get => E_PROP_UBehaviorTree_RootNode_GET(NativePointer);
			set => E_PROP_UBehaviorTree_RootNode_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBehaviorTree self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBehaviorTree(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBehaviorTree>(PtrDesc);
		}}}
