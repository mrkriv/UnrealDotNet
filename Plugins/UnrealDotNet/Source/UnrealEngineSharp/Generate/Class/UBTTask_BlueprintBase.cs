// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_BlueprintBase.h:24

namespace UnrealEngine
{
	public partial class UBTTask_BlueprintBase : UBTTaskNode
	{
		public UBTTask_BlueprintBase(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_BlueprintBase(UObject Parent = null, string Name = "BTTask_BlueprintBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_BlueprintBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_BlueprintBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_FinishAbort(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_FinishExecute(IntPtr self, bool bSuccess);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTTask_BlueprintBase_IsTaskAborting(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTTask_BlueprintBase_IsTaskExecuting(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_ReceiveAbort(IntPtr self, IntPtr ownerActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_ReceiveAbortAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_ReceiveExecute(IntPtr self, IntPtr ownerActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_ReceiveExecuteAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_ReceiveTick(IntPtr self, IntPtr ownerActor, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_ReceiveTickAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_SetFinishOnMessage(IntPtr self, string messageName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_BlueprintBase_SetFinishOnMessageWithId(IntPtr self, string messageName);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// aborts task execution
		/// </summary>
		protected void FinishAbort()
			=> E_UBTTask_BlueprintBase_FinishAbort(this);
		
		
		/// <summary>
		/// finishes task execution with Success or Fail result
		/// </summary>
		protected void FinishExecute(bool bSuccess)
			=> E_UBTTask_BlueprintBase_FinishExecute(this, bSuccess);
		
		
		/// <summary>
		/// check if task is currently being aborted
		/// </summary>
		protected bool IsTaskAborting()
			=> E_UBTTask_BlueprintBase_IsTaskAborting(this);
		
		
		/// <summary>
		/// check if task is currently being executed
		/// </summary>
		protected bool IsTaskExecuting()
			=> E_UBTTask_BlueprintBase_IsTaskExecuting(this);
		
		protected void ReceiveAbort(AActor ownerActor)
			=> E_UBTTask_BlueprintBase_ReceiveAbort(this, ownerActor);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveAbort
		/// <see cref="ReceiveAbort"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveAbortAI(AAIController ownerController, APawn controlledPawn)
			=> E_UBTTask_BlueprintBase_ReceiveAbortAI(this, ownerController, controlledPawn);
		
		protected void ReceiveExecute(AActor ownerActor)
			=> E_UBTTask_BlueprintBase_ReceiveExecute(this, ownerActor);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveExecute
		/// <see cref="ReceiveExecute"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveExecuteAI(AAIController ownerController, APawn controlledPawn)
			=> E_UBTTask_BlueprintBase_ReceiveExecuteAI(this, ownerController, controlledPawn);
		
		protected void ReceiveTick(AActor ownerActor, float deltaSeconds)
			=> E_UBTTask_BlueprintBase_ReceiveTick(this, ownerActor, deltaSeconds);
		
		
		/// <summary>
		/// Alternative AI version of tick function.
		/// <see cref="ReceiveTick"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
			=> E_UBTTask_BlueprintBase_ReceiveTickAI(this, ownerController, controlledPawn, deltaSeconds);
		
		
		/// <summary>
		/// task execution will be finished (with result 'Success') after receiving specified message
		/// </summary>
		protected void SetFinishOnMessage(string messageName)
			=> E_UBTTask_BlueprintBase_SetFinishOnMessage(this, messageName);
		
		
		/// <summary>
		/// task execution will be finished (with result 'Success') after receiving specified message with indicated ID
		/// </summary>
		protected void SetFinishOnMessageWithId(string messageName)
			=> E_UBTTask_BlueprintBase_SetFinishOnMessageWithId(this, messageName);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_BlueprintBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_BlueprintBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_BlueprintBase>(PtrDesc);
		}}}
