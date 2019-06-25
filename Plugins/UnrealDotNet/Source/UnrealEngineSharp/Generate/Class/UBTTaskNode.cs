// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTTaskNode.h:28

namespace UnrealEngine
{
	public partial class UBTTaskNode : UBTNode
	{
		public UBTTaskNode(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTaskNode(UObject Parent = null, string Name = "BTTaskNode")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTaskNode(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTaskNode(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTaskNode_FinishLatentAbort(IntPtr self, IntPtr ownerComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTaskNode_OnMessage(IntPtr self, IntPtr ownerComp, byte nodeMemory, string message, int requestID, bool bSuccess);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTTaskNode_ShouldIgnoreRestartSelf(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTaskNode_StopWaitingForMessages(IntPtr self, IntPtr ownerComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTaskNode_TickTask(IntPtr self, IntPtr ownerComp, byte nodeMemory, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTaskNode_WaitForMessage(IntPtr self, IntPtr ownerComp, string messageType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTaskNode_WaitForMessage_o1(IntPtr self, IntPtr ownerComp, string messageType, int requestID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTaskNode_WrappedTickTask(IntPtr self, IntPtr ownerComp, byte nodeMemory, float deltaSeconds);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// helper function: finishes latent aborting
		/// </summary>
		public void FinishLatentAbort(UBehaviorTreeComponent ownerComp)
			=> E_UBTTaskNode_FinishLatentAbort(this, ownerComp);
		
		
		/// <summary>
		/// message handler, default implementation will finish latent execution/abortion
		/// <para>this function should be considered as const (don't modify state of object) if node is not instanced! </para>
		/// </summary>
		protected virtual void OnMessage(UBehaviorTreeComponent ownerComp, byte nodeMemory, string message, int requestID, bool bSuccess)
			=> E_UBTTaskNode_OnMessage(this, ownerComp, nodeMemory, message, requestID, bSuccess);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool ShouldIgnoreRestartSelf()
			=> E_UBTTaskNode_ShouldIgnoreRestartSelf(this);
		
		
		/// <summary>
		/// unregister message observers
		/// </summary>
		protected void StopWaitingForMessages(UBehaviorTreeComponent ownerComp)
			=> E_UBTTaskNode_StopWaitingForMessages(this, ownerComp);
		
		
		/// <summary>
		/// ticks this task
		/// <para>this function should be considered as const (don't modify state of object) if node is not instanced! </para>
		/// </summary>
		protected virtual void TickTask(UBehaviorTreeComponent ownerComp, byte nodeMemory, float deltaSeconds)
			=> E_UBTTaskNode_TickTask(this, ownerComp, nodeMemory, deltaSeconds);
		
		
		/// <summary>
		/// register message observer
		/// </summary>
		protected void WaitForMessage(UBehaviorTreeComponent ownerComp, string messageType)
			=> E_UBTTaskNode_WaitForMessage(this, ownerComp, messageType);
		
		protected void WaitForMessage(UBehaviorTreeComponent ownerComp, string messageType, int requestID)
			=> E_UBTTaskNode_WaitForMessage_o1(this, ownerComp, messageType, requestID);
		
		
		/// <summary>
		/// wrapper for node instancing: TickTask
		/// </summary>
		public void WrappedTickTask(UBehaviorTreeComponent ownerComp, byte nodeMemory, float deltaSeconds)
			=> E_UBTTaskNode_WrappedTickTask(this, ownerComp, nodeMemory, deltaSeconds);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTaskNode self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTaskNode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTaskNode>(PtrDesc);
		}}}
