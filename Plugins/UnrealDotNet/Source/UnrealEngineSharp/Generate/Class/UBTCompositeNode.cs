// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTCompositeNode.h:88

namespace UnrealEngine
{
	public partial class UBTCompositeNode : UBTNode
	{
		public UBTCompositeNode(IntPtr adress)
			: base(adress)
		{
		}

		public UBTCompositeNode(UObject Parent = null, string Name = "BTCompositeNode")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTCompositeNode(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTCompositeNode(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTCompositeNode_CanNotifyDecoratorsOnActivation(IntPtr self, IntPtr searchData, int childIdx);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTCompositeNode_CanPushSubtree(IntPtr self, IntPtr ownerComp, byte nodeMemory, int childIdx);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTCompositeNode_DoDecoratorsAllowExecution(IntPtr self, IntPtr ownerComp, int instanceIdx, int childIdx);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UBTCompositeNode_GetChildIndex(IntPtr self, IntPtr searchData, IntPtr childNode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UBTCompositeNode_GetChildIndex_o1(IntPtr self, IntPtr childNode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBTCompositeNode_GetChildNode(IntPtr self, int index);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UBTCompositeNode_GetChildrenNum(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UBTCompositeNode_GetMatchingChildIndex(IntPtr self, int activeInstanceIdx, IntPtr nodeIdx);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTCompositeNode_IsApplyingDecoratorScope(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTCompositeNode_NotifyDecoratorsOnActivation(IntPtr self, IntPtr searchData, int childIdx);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTCompositeNode_NotifyNodeActivation(IntPtr self, IntPtr searchData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTCompositeNode_OnChildActivation(IntPtr self, IntPtr searchData, IntPtr childNode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTCompositeNode_OnChildActivation_o1(IntPtr self, IntPtr searchData, int childIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTCompositeNode_OnNodeActivation(IntPtr self, IntPtr searchData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTCompositeNode_OnNodeRestart(IntPtr self, IntPtr searchData);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// check if NotifyDecoratorsOnActivation is allowed, requires bUseDecoratorsActivationCheck flag
		/// </summary>
		protected virtual bool CanNotifyDecoratorsOnActivation(FBehaviorTreeSearchData searchData, int childIdx)
			=> E_UBTCompositeNode_CanNotifyDecoratorsOnActivation(this, searchData, childIdx);
		
		
		/// <summary>
		/// check if child node can execute new subtree
		/// </summary>
		public virtual bool CanPushSubtree(UBehaviorTreeComponent ownerComp, byte nodeMemory, int childIdx)
			=> E_UBTCompositeNode_CanPushSubtree(this, ownerComp, nodeMemory, childIdx);
		
		
		/// <summary>
		/// is child execution allowed by decorators?
		/// </summary>
		public bool DoDecoratorsAllowExecution(UBehaviorTreeComponent ownerComp, int instanceIdx, int childIdx)
			=> E_UBTCompositeNode_DoDecoratorsAllowExecution(this, ownerComp, instanceIdx, childIdx);
		
		
		/// <summary>
		/// get index of child node (handle subtrees)
		/// </summary>
		public int GetChildIndex(FBehaviorTreeSearchData searchData, UBTNode childNode)
			=> E_UBTCompositeNode_GetChildIndex(this, searchData, childNode);
		
		
		/// <summary>
		/// get index of child node
		/// </summary>
		public int GetChildIndex(UBTNode childNode)
			=> E_UBTCompositeNode_GetChildIndex_o1(this, childNode);
		
		
		/// <summary>
		/// </summary>
		/// <return>child</return>
		public UBTNode GetChildNode(int index)
			=> E_UBTCompositeNode_GetChildNode(this, index);
		
		
		/// <summary>
		/// </summary>
		/// <return>children</return>
		public int GetChildrenNum()
			=> E_UBTCompositeNode_GetChildrenNum(this);
		
		
		/// <summary>
		/// find branch containing specified node index
		/// </summary>
		public int GetMatchingChildIndex(int activeInstanceIdx, FBTNodeIndex nodeIdx)
			=> E_UBTCompositeNode_GetMatchingChildIndex(this, activeInstanceIdx, nodeIdx);
		
		public bool IsApplyingDecoratorScope()
			=> E_UBTCompositeNode_IsApplyingDecoratorScope(this);
		
		
		/// <summary>
		/// runs through decorators on given child node and notify them about activation
		/// </summary>
		protected void NotifyDecoratorsOnActivation(FBehaviorTreeSearchData searchData, int childIdx)
			=> E_UBTCompositeNode_NotifyDecoratorsOnActivation(this, searchData, childIdx);
		
		
		/// <summary>
		/// called when start enters this node
		/// </summary>
		protected virtual void NotifyNodeActivation(FBehaviorTreeSearchData searchData)
			=> E_UBTCompositeNode_NotifyNodeActivation(this, searchData);
		
		
		/// <summary>
		/// called before passing search to child node
		/// </summary>
		public void OnChildActivation(FBehaviorTreeSearchData searchData, UBTNode childNode)
			=> E_UBTCompositeNode_OnChildActivation(this, searchData, childNode);
		
		public void OnChildActivation(FBehaviorTreeSearchData searchData, int childIndex)
			=> E_UBTCompositeNode_OnChildActivation_o1(this, searchData, childIndex);
		
		
		/// <summary>
		/// called when start enters this node
		/// </summary>
		public void OnNodeActivation(FBehaviorTreeSearchData searchData)
			=> E_UBTCompositeNode_OnNodeActivation(this, searchData);
		
		
		/// <summary>
		/// called when search needs to reactivate this node
		/// </summary>
		public void OnNodeRestart(FBehaviorTreeSearchData searchData)
			=> E_UBTCompositeNode_OnNodeRestart(this, searchData);
		
		#endregion
		
		public static implicit operator IntPtr(UBTCompositeNode self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTCompositeNode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTCompositeNode>(PtrDesc);
		}}}
