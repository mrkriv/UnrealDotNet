// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTCompositeNode.h:67

namespace UnrealEngine
{
	public partial class FBTCompositeChild : NativeStructWrapper
	{
		public FBTCompositeChild(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTCompositeChild() :
			base(E_CreateStruct_FBTCompositeChild(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBTCompositeChild_ChildComposite_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTCompositeChild_ChildComposite_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBTCompositeChild_ChildTask_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTCompositeChild_ChildTask_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTCompositeChild();
		
		#endregion
		
		#region Property
		public UBTCompositeNode ChildComposite
		{
			get => E_PROP_FBTCompositeChild_ChildComposite_GET(NativePointer);
			set => E_PROP_FBTCompositeChild_ChildComposite_SET(NativePointer, value);
		}

		public UBTTaskNode ChildTask
		{
			get => E_PROP_FBTCompositeChild_ChildTask_GET(NativePointer);
			set => E_PROP_FBTCompositeChild_ChildTask_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTCompositeChild self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTCompositeChild(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTCompositeChild(adress, false);
		}}}
