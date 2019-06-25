// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_BlueprintBase.h:33

namespace UnrealEngine
{
	public partial class UBTDecorator_BlueprintBase : UBTDecorator
	{
		public UBTDecorator_BlueprintBase(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_BlueprintBase(UObject Parent = null, string Name = "BTDecorator_BlueprintBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_BlueprintBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_BlueprintBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_BlueprintBase_CalculateRawConditionValueImpl(IntPtr self, IntPtr ownerComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_BlueprintBase_GetNeedsTickForConditionChecking(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_BlueprintBase_GetShouldAbort(IntPtr self, IntPtr ownerComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_BlueprintBase_InitializeProperties(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_BlueprintBase_IsDecoratorExecutionActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_BlueprintBase_IsDecoratorObserverActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_BlueprintBase_PerformConditionCheck(IntPtr self, IntPtr ownerActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTDecorator_BlueprintBase_PerformConditionCheckAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_BlueprintBase_ReceiveExecutionStart(IntPtr self, IntPtr ownerActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_BlueprintBase_ReceiveExecutionStartAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_BlueprintBase_ReceiveObserverActivated(IntPtr self, IntPtr ownerActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_BlueprintBase_ReceiveObserverActivatedAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_BlueprintBase_ReceiveObserverDeactivated(IntPtr self, IntPtr ownerActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_BlueprintBase_ReceiveObserverDeactivatedAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_BlueprintBase_ReceiveTick(IntPtr self, IntPtr ownerActor, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTDecorator_BlueprintBase_ReceiveTickAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn, float deltaSeconds);
		
		#endregion
		
		#region ExternMethods
		protected bool CalculateRawConditionValueImpl(UBehaviorTreeComponent ownerComp)
			=> E_UBTDecorator_BlueprintBase_CalculateRawConditionValueImpl(this, ownerComp);
		
		protected bool GetNeedsTickForConditionChecking()
			=> E_UBTDecorator_BlueprintBase_GetNeedsTickForConditionChecking(this);
		
		
		/// <summary>
		/// return if this decorator should abort in current circumstances
		/// </summary>
		public bool GetShouldAbort(UBehaviorTreeComponent ownerComp)
			=> E_UBTDecorator_BlueprintBase_GetShouldAbort(this, ownerComp);
		
		
		/// <summary>
		/// initialize data about blueprint defined properties
		/// </summary>
		public void InitializeProperties()
			=> E_UBTDecorator_BlueprintBase_InitializeProperties(this);
		
		
		/// <summary>
		/// check if decorator is part of currently active branch
		/// </summary>
		protected bool IsDecoratorExecutionActive()
			=> E_UBTDecorator_BlueprintBase_IsDecoratorExecutionActive(this);
		
		
		/// <summary>
		/// check if decorator's observer is currently active
		/// </summary>
		protected bool IsDecoratorObserverActive()
			=> E_UBTDecorator_BlueprintBase_IsDecoratorObserverActive(this);
		
		protected bool PerformConditionCheck(AActor ownerActor)
			=> E_UBTDecorator_BlueprintBase_PerformConditionCheck(this, ownerActor);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveConditionCheck
		/// <see cref="ReceiveConditionCheck"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected bool PerformConditionCheckAI(AAIController ownerController, APawn controlledPawn)
			=> E_UBTDecorator_BlueprintBase_PerformConditionCheckAI(this, ownerController, controlledPawn);
		
		protected void ReceiveExecutionStart(AActor ownerActor)
			=> E_UBTDecorator_BlueprintBase_ReceiveExecutionStart(this, ownerActor);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveExecutionStart
		/// <see cref="ReceiveExecutionStart"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveExecutionStartAI(AAIController ownerController, APawn controlledPawn)
			=> E_UBTDecorator_BlueprintBase_ReceiveExecutionStartAI(this, ownerController, controlledPawn);
		
		protected void ReceiveObserverActivated(AActor ownerActor)
			=> E_UBTDecorator_BlueprintBase_ReceiveObserverActivated(this, ownerActor);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveObserverActivated
		/// <see cref="ReceiveObserverActivated"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveObserverActivatedAI(AAIController ownerController, APawn controlledPawn)
			=> E_UBTDecorator_BlueprintBase_ReceiveObserverActivatedAI(this, ownerController, controlledPawn);
		
		protected void ReceiveObserverDeactivated(AActor ownerActor)
			=> E_UBTDecorator_BlueprintBase_ReceiveObserverDeactivated(this, ownerActor);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveObserverDeactivated
		/// <see cref="ReceiveObserverDeactivated"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveObserverDeactivatedAI(AAIController ownerController, APawn controlledPawn)
			=> E_UBTDecorator_BlueprintBase_ReceiveObserverDeactivatedAI(this, ownerController, controlledPawn);
		
		protected void ReceiveTick(AActor ownerActor, float deltaSeconds)
			=> E_UBTDecorator_BlueprintBase_ReceiveTick(this, ownerActor, deltaSeconds);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveTick
		/// <see cref="ReceiveTick"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
			=> E_UBTDecorator_BlueprintBase_ReceiveTickAI(this, ownerController, controlledPawn, deltaSeconds);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_BlueprintBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_BlueprintBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_BlueprintBase>(PtrDesc);
		}}}
