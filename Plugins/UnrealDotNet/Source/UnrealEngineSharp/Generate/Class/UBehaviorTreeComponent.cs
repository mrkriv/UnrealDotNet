// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeComponent.h:81

namespace UnrealEngine
{
	public partial class UBehaviorTreeComponent : UBrainComponent
	{
		public UBehaviorTreeComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UBehaviorTreeComponent(UObject Parent = null, string Name = "BehaviorTreeComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBehaviorTreeComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UBehaviorTreeComponent_ChildIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBehaviorTreeComponent_ChildIndex_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBehaviorTreeComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UBehaviorTreeComponent_FindInstanceContainingNode(IntPtr self, IntPtr node);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBehaviorTreeComponent_FindTemplateNode(IntPtr self, IntPtr node);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBehaviorTreeComponent_GetActiveNode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBehaviorTreeComponent_GetCurrentTree(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UBehaviorTreeComponent_GetNodeMemory(IntPtr self, IntPtr node, int instanceIdx);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBehaviorTreeComponent_GetRootTree(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBehaviorTreeComponent_IsAbortPending(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBehaviorTreeComponent_IsExecutingBranch(IntPtr self, IntPtr node);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBehaviorTreeComponent_IsRestartPending(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_ProcessExecutionRequest(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_RegisterMessageObserver(IntPtr self, IntPtr taskNode, string messageType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_RegisterParallelTask(IntPtr self, IntPtr taskNode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_RequestExecution(IntPtr self, IntPtr requestedBy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_RestartTree(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_ScheduleExecutionUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBehaviorTreeComponent_TreeHasBeenStarted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_UnregisterAuxNodesInBranch(IntPtr self, IntPtr node, bool bApplyImmediately);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_UnregisterAuxNodesInRange(IntPtr self, IntPtr fromIndex, IntPtr toIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_UnregisterAuxNodesUpTo(IntPtr self, IntPtr index);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_UnregisterMessageObserversFrom(IntPtr self, IntPtr taskNode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeComponent_UnregisterMessageObserversFrom_o1(IntPtr self, IntPtr taskIdx);
		
		#endregion
		
		#region Property
		public int ChildIndex
		{
			get => E_PROP_UBehaviorTreeComponent_ChildIndex_GET(NativePointer);
			set => E_PROP_UBehaviorTreeComponent_ChildIndex_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// tries to find behavior tree instance in context
		/// </summary>
		public int FindInstanceContainingNode(UBTNode node)
			=> E_UBehaviorTreeComponent_FindInstanceContainingNode(this, node);
		
		
		/// <summary>
		/// tries to find template node for given instanced node
		/// </summary>
		public UBTNode FindTemplateNode(UBTNode node)
			=> E_UBehaviorTreeComponent_FindTemplateNode(this, node);
		
		
		/// <summary>
		/// </summary>
		/// <return>active</return>
		public UBTNode GetActiveNode()
			=> E_UBehaviorTreeComponent_GetActiveNode(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>current</return>
		public UBehaviorTree GetCurrentTree()
			=> E_UBehaviorTreeComponent_GetCurrentTree(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>node</return>
		public byte GetNodeMemory(UBTNode node, int instanceIdx)
			=> E_UBehaviorTreeComponent_GetNodeMemory(this, node, instanceIdx);
		
		
		/// <summary>
		/// </summary>
		/// <return>tree</return>
		public UBehaviorTree GetRootTree()
			=> E_UBehaviorTreeComponent_GetRootTree(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsAbortPending()
			=> E_UBehaviorTreeComponent_IsAbortPending(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsExecutingBranch(UBTNode node)
			=> E_UBehaviorTreeComponent_IsExecutingBranch(this, node);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsRestartPending()
			=> E_UBehaviorTreeComponent_IsRestartPending(this);
		
		
		/// <summary>
		/// process execution flow
		/// </summary>
		public void ProcessExecutionRequest()
			=> E_UBehaviorTreeComponent_ProcessExecutionRequest(this);
		
		
		/// <summary>
		/// setup message observer for given task
		/// </summary>
		public void RegisterMessageObserver(UBTTaskNode taskNode, string messageType)
			=> E_UBehaviorTreeComponent_RegisterMessageObserver(this, taskNode, messageType);
		
		
		/// <summary>
		/// add active parallel task
		/// </summary>
		public void RegisterParallelTask(UBTTaskNode taskNode)
			=> E_UBehaviorTreeComponent_RegisterParallelTask(this, taskNode);
		
		
		/// <summary>
		/// request execution change: helpers for decorator nodes
		/// </summary>
		public void RequestExecution(UBTDecorator requestedBy)
			=> E_UBehaviorTreeComponent_RequestExecution(this, requestedBy);
		
		
		/// <summary>
		/// restarts execution from root
		/// </summary>
		public void RestartTree()
			=> E_UBehaviorTreeComponent_RestartTree(this);
		
		
		/// <summary>
		/// schedule execution flow update in next tick
		/// </summary>
		public void ScheduleExecutionUpdate()
			=> E_UBehaviorTreeComponent_ScheduleExecutionUpdate(this);
		
		
		/// <summary>
		/// indicates instance has been initialized to work with specific BT asset
		/// </summary>
		public bool TreeHasBeenStarted()
			=> E_UBehaviorTreeComponent_TreeHasBeenStarted(this);
		
		
		/// <summary>
		/// unregister all aux nodes in branch of tree
		/// </summary>
		public void UnregisterAuxNodesInBranch(UBTCompositeNode node, bool bApplyImmediately = true)
			=> E_UBehaviorTreeComponent_UnregisterAuxNodesInBranch(this, node, bApplyImmediately);
		
		
		/// <summary>
		/// unregister all aux nodes between given execution index range: FromIndex < AuxIndex < ToIndex
		/// </summary>
		public void UnregisterAuxNodesInRange(FBTNodeIndex fromIndex, FBTNodeIndex toIndex)
			=> E_UBehaviorTreeComponent_UnregisterAuxNodesInRange(this, fromIndex, toIndex);
		
		
		/// <summary>
		/// unregister all aux nodes less important than given index
		/// </summary>
		public void UnregisterAuxNodesUpTo(FBTNodeIndex index)
			=> E_UBehaviorTreeComponent_UnregisterAuxNodesUpTo(this, index);
		
		
		/// <summary>
		/// remove message observers registered with task
		/// </summary>
		public void UnregisterMessageObserversFrom(UBTTaskNode taskNode)
			=> E_UBehaviorTreeComponent_UnregisterMessageObserversFrom(this, taskNode);
		
		public void UnregisterMessageObserversFrom(FBTNodeIndex taskIdx)
			=> E_UBehaviorTreeComponent_UnregisterMessageObserversFrom_o1(this, taskIdx);
		
		#endregion
		
		public static implicit operator IntPtr(UBehaviorTreeComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBehaviorTreeComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBehaviorTreeComponent>(PtrDesc);
		}}}
