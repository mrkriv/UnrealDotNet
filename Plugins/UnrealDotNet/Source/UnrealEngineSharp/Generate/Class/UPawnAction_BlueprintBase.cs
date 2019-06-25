// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_BlueprintBase.h:13

namespace UnrealEngine
{
	public partial class UPawnAction_BlueprintBase : UPawnAction
	{
		public UPawnAction_BlueprintBase(IntPtr adress)
			: base(adress)
		{
		}

		public UPawnAction_BlueprintBase(UObject Parent = null, string Name = "PawnAction_BlueprintBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnAction_BlueprintBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnAction_BlueprintBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_BlueprintBase_ActionPause(IntPtr self, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_BlueprintBase_ActionResume(IntPtr self, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_BlueprintBase_ActionStart(IntPtr self, IntPtr controlledPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_BlueprintBase_ActionTick(IntPtr self, IntPtr controlledPawn, float deltaSeconds);
		
		#endregion
		
		#region ExternMethods
		public void ActionPause(APawn controlledPawn)
			=> E_UPawnAction_BlueprintBase_ActionPause(this, controlledPawn);
		
		public void ActionResume(APawn controlledPawn)
			=> E_UPawnAction_BlueprintBase_ActionResume(this, controlledPawn);
		
		public void ActionStart(APawn controlledPawn)
			=> E_UPawnAction_BlueprintBase_ActionStart(this, controlledPawn);
		
		public void ActionTick(APawn controlledPawn, float deltaSeconds)
			=> E_UPawnAction_BlueprintBase_ActionTick(this, controlledPawn, deltaSeconds);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnAction_BlueprintBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPawnAction_BlueprintBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnAction_BlueprintBase>(PtrDesc);
		}}}
