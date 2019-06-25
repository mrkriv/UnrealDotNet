// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Services\BTService_BlueprintBase.h:24

namespace UnrealEngine
{
	public partial class UBTService_BlueprintBase : UBTService
	{
		public UBTService_BlueprintBase(IntPtr adress)
			: base(adress)
		{
		}

		public UBTService_BlueprintBase(UObject Parent = null, string Name = "BTService_BlueprintBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTService_BlueprintBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTService_BlueprintBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTService_BlueprintBase_IsServiceActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_BlueprintBase_ReceiveActivation(IntPtr self, IntPtr ownerActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_BlueprintBase_ReceiveActivationAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_BlueprintBase_ReceiveDeactivation(IntPtr self, IntPtr ownerActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_BlueprintBase_ReceiveDeactivationAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_BlueprintBase_ReceiveSearchStart(IntPtr self, IntPtr ownerActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_BlueprintBase_ReceiveSearchStartAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_BlueprintBase_ReceiveTick(IntPtr self, IntPtr ownerActor, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_BlueprintBase_ReceiveTickAI(IntPtr self, IntPtr ownerController, IntPtr controlledPawn, float deltaSeconds);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// check if service is currently being active
		/// </summary>
		protected bool IsServiceActive()
			=> E_UBTService_BlueprintBase_IsServiceActive(this);
		
		protected void ReceiveActivation(AActor ownerActor)
			=> E_UBTService_BlueprintBase_ReceiveActivation(this, ownerActor);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveActivation function.
		/// <see cref="ReceiveActivation"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveActivationAI(AAIController ownerController, APawn controlledPawn)
			=> E_UBTService_BlueprintBase_ReceiveActivationAI(this, ownerController, controlledPawn);
		
		protected void ReceiveDeactivation(AActor ownerActor)
			=> E_UBTService_BlueprintBase_ReceiveDeactivation(this, ownerActor);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveDeactivation function.
		/// <see cref="ReceiveDeactivation"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveDeactivationAI(AAIController ownerController, APawn controlledPawn)
			=> E_UBTService_BlueprintBase_ReceiveDeactivationAI(this, ownerController, controlledPawn);
		
		protected void ReceiveSearchStart(AActor ownerActor)
			=> E_UBTService_BlueprintBase_ReceiveSearchStart(this, ownerActor);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveSearchStart function.
		/// <see cref="ReceiveSearchStart"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveSearchStartAI(AAIController ownerController, APawn controlledPawn)
			=> E_UBTService_BlueprintBase_ReceiveSearchStartAI(this, ownerController, controlledPawn);
		
		protected void ReceiveTick(AActor ownerActor, float deltaSeconds)
			=> E_UBTService_BlueprintBase_ReceiveTick(this, ownerActor, deltaSeconds);
		
		
		/// <summary>
		/// Alternative AI version of ReceiveTick function.
		/// <see cref="ReceiveTick"/>
		/// <para>@Note that if both generic and AI event versions are implemented only the more </para>
		/// suitable one will be called, meaning the AI version if called for AI, generic one otherwise
		/// </summary>
		protected void ReceiveTickAI(AAIController ownerController, APawn controlledPawn, float deltaSeconds)
			=> E_UBTService_BlueprintBase_ReceiveTickAI(this, ownerController, controlledPawn, deltaSeconds);
		
		#endregion
		
		public static implicit operator IntPtr(UBTService_BlueprintBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTService_BlueprintBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTService_BlueprintBase>(PtrDesc);
		}}}
