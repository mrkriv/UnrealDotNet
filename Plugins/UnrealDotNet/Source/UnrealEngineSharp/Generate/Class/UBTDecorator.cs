// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTDecorator.h:38

namespace UnrealEngine
{
	public partial class UBTDecorator : UBTAuxiliaryNode
	{
		public UBTDecorator(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator(UObject Parent = null, string Name = "BTDecorator")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_CalculateRawConditionValue(IntPtr self, IntPtr ownerComp, byte nodeMemory);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_ConditionalFlowAbort(IntPtr self, IntPtr ownerComp, byte requestMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_InitializeDecorator(IntPtr self, byte inChildIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_IsFlowAbortModeValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_IsInversed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_OnNodeActivation(IntPtr self, IntPtr searchData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_SetIsInversed(IntPtr self, bool bShouldBeInversed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_UpdateFlowAbortMode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_WrappedCanExecute(IntPtr self, IntPtr ownerComp, byte nodeMemory);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_WrappedOnNodeActivation(IntPtr self, IntPtr searchData);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// calculates raw, core value of decorator's condition. Should not include calling IsInversed
		/// </summary>
		protected virtual bool CalculateRawConditionValue(UBehaviorTreeComponent ownerComp, byte nodeMemory)
			=> E_UBTDecorator_CalculateRawConditionValue(this, ownerComp, nodeMemory);
		
		
		/// <summary>
		/// more "flow aware" version of calling RequestExecution(this) on owning behavior tree component
		/// <para>should be used in external events that may change result of CalculateRawConditionValue </para>
		/// </summary>
		protected void ConditionalFlowAbort(UBehaviorTreeComponent ownerComp, EBTDecoratorAbortRequest requestMode)
			=> E_UBTDecorator_ConditionalFlowAbort(this, ownerComp, (byte)requestMode);
		
		protected void InitializeDecorator(byte inChildIndex)
			=> E_UBTDecorator_InitializeDecorator(this, inChildIndex);
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsFlowAbortModeValid()
			=> E_UBTDecorator_IsFlowAbortModeValid(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsInversed()
			=> E_UBTDecorator_IsInversed(this);
		
		
		/// <summary>
		/// called when underlying node is activated
		/// <para>this function should be considered as const (don't modify state of object) if node is not instanced! </para>
		/// </summary>
		protected virtual void OnNodeActivation(FBehaviorTreeSearchData searchData)
			=> E_UBTDecorator_OnNodeActivation(this, searchData);
		
		protected void SetIsInversed(bool bShouldBeInversed)
			=> E_UBTDecorator_SetIsInversed(this, bShouldBeInversed);
		
		
		/// <summary>
		/// modify current flow abort mode, so it can be used with parent composite
		/// </summary>
		public void UpdateFlowAbortMode()
			=> E_UBTDecorator_UpdateFlowAbortMode(this);
		
		
		/// <summary>
		/// wrapper for node instancing: CalculateRawConditionValue
		/// </summary>
		public bool WrappedCanExecute(UBehaviorTreeComponent ownerComp, byte nodeMemory)
			=> E_UBTDecorator_WrappedCanExecute(this, ownerComp, nodeMemory);
		
		
		/// <summary>
		/// wrapper for node instancing: OnNodeActivation
		/// </summary>
		public void WrappedOnNodeActivation(FBehaviorTreeSearchData searchData)
			=> E_UBTDecorator_WrappedOnNodeActivation(this, searchData);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator>(PtrDesc);
		}
}
}
