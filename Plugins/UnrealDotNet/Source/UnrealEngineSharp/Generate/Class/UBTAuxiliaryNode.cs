// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTAuxiliaryNode.h:31

namespace UnrealEngine
{
	public partial class UBTAuxiliaryNode : UBTNode
	{
		public UBTAuxiliaryNode(IntPtr adress)
			: base(adress)
		{
		}

		public UBTAuxiliaryNode(UObject Parent = null, string Name = "BTAuxiliaryNode")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTAuxiliaryNode(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTAuxiliaryNode(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UBTAuxiliaryNode_GetChildIndex(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBTAuxiliaryNode_GetMyNode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UBTAuxiliaryNode_GetNextTickRemainingTime(IntPtr self, byte nodeMemory);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTAuxiliaryNode_InitializeParentLink(IntPtr self, byte inChildIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTAuxiliaryNode_OnBecomeRelevant(IntPtr self, IntPtr ownerComp, byte nodeMemory);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTAuxiliaryNode_OnCeaseRelevant(IntPtr self, IntPtr ownerComp, byte nodeMemory);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTAuxiliaryNode_SetNextTickTime(IntPtr self, byte nodeMemory, float remainingTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTAuxiliaryNode_TickNode(IntPtr self, IntPtr ownerComp, byte nodeMemory, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTAuxiliaryNode_WrappedOnBecomeRelevant(IntPtr self, IntPtr ownerComp, byte nodeMemory);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTAuxiliaryNode_WrappedOnCeaseRelevant(IntPtr self, IntPtr ownerComp, byte nodeMemory);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTAuxiliaryNode_WrappedTickNode(IntPtr self, IntPtr ownerComp, byte nodeMemory, float deltaSeconds);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// </summary>
		/// <return>index</return>
		public byte GetChildIndex()
			=> E_UBTAuxiliaryNode_GetChildIndex(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>parent</return>
		public UBTNode GetMyNode()
			=> E_UBTAuxiliaryNode_GetMyNode(this);
		
		
		/// <summary>
		/// gets remaining time for next tick
		/// </summary>
		protected float GetNextTickRemainingTime(byte nodeMemory)
			=> E_UBTAuxiliaryNode_GetNextTickRemainingTime(this, nodeMemory);
		
		
		/// <summary>
		/// fill in data about tree structure
		/// </summary>
		public void InitializeParentLink(byte inChildIndex)
			=> E_UBTAuxiliaryNode_InitializeParentLink(this, inChildIndex);
		
		
		/// <summary>
		/// called when auxiliary node becomes active
		/// <para>this function should be considered as const (don't modify state of object) if node is not instanced! </para>
		/// </summary>
		protected virtual void OnBecomeRelevant(UBehaviorTreeComponent ownerComp, byte nodeMemory)
			=> E_UBTAuxiliaryNode_OnBecomeRelevant(this, ownerComp, nodeMemory);
		
		
		/// <summary>
		/// called when auxiliary node becomes inactive
		/// <para>this function should be considered as const (don't modify state of object) if node is not instanced! </para>
		/// </summary>
		protected virtual void OnCeaseRelevant(UBehaviorTreeComponent ownerComp, byte nodeMemory)
			=> E_UBTAuxiliaryNode_OnCeaseRelevant(this, ownerComp, nodeMemory);
		
		
		/// <summary>
		/// sets next tick time
		/// </summary>
		protected void SetNextTickTime(byte nodeMemory, float remainingTime)
			=> E_UBTAuxiliaryNode_SetNextTickTime(this, nodeMemory, remainingTime);
		
		
		/// <summary>
		/// tick function
		/// <para>this function should be considered as const (don't modify state of object) if node is not instanced! </para>
		/// </summary>
		protected virtual void TickNode(UBehaviorTreeComponent ownerComp, byte nodeMemory, float deltaSeconds)
			=> E_UBTAuxiliaryNode_TickNode(this, ownerComp, nodeMemory, deltaSeconds);
		
		
		/// <summary>
		/// wrapper for node instancing: OnBecomeRelevant
		/// </summary>
		public void WrappedOnBecomeRelevant(UBehaviorTreeComponent ownerComp, byte nodeMemory)
			=> E_UBTAuxiliaryNode_WrappedOnBecomeRelevant(this, ownerComp, nodeMemory);
		
		
		/// <summary>
		/// wrapper for node instancing: OnCeaseRelevant
		/// </summary>
		public void WrappedOnCeaseRelevant(UBehaviorTreeComponent ownerComp, byte nodeMemory)
			=> E_UBTAuxiliaryNode_WrappedOnCeaseRelevant(this, ownerComp, nodeMemory);
		
		
		/// <summary>
		/// wrapper for node instancing: TickNode
		/// </summary>
		public void WrappedTickNode(UBehaviorTreeComponent ownerComp, byte nodeMemory, float deltaSeconds)
			=> E_UBTAuxiliaryNode_WrappedTickNode(this, ownerComp, nodeMemory, deltaSeconds);
		
		#endregion
		
		public static implicit operator IntPtr(UBTAuxiliaryNode self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTAuxiliaryNode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTAuxiliaryNode>(PtrDesc);
		}}}
