// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_Move.h:27

namespace UnrealEngine
{
	public partial class UPawnAction_Move : UPawnAction
	{
		public UPawnAction_Move(IntPtr adress)
			: base(adress)
		{
		}

		public UPawnAction_Move(UObject Parent = null, string Name = "PawnAction_Move")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnAction_Move(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnAction_Move(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Move_CheckAlreadyAtGoal(IntPtr self, IntPtr controller, IntPtr testLocation, float radius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Move_CheckAlreadyAtGoal_o1(IntPtr self, IntPtr controller, IntPtr testGoal, float radius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_ClearPath(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_ClearPendingRepath(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_ClearTimers(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_DeferredPerformMoveAction(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_EnableChildAbortionOnPathUpdate(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_EnableGoalLocationProjectionToNavigation(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_EnablePathUpdateOnMoveGoalLocationChange(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_EnableStrafing(IntPtr self, bool bNewStrafing);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Move_IsPartialPathAllowed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Move_PerformMoveAction(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_SetAcceptableRadius(IntPtr self, float newAcceptableRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_SetAllowPartialPath(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_SetFinishOnOverlap(IntPtr self, bool bNewFinishOnOverlap);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Move_TryToRepath(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public bool CheckAlreadyAtGoal(AAIController controller, FVector testLocation, float radius)
			=> E_UPawnAction_Move_CheckAlreadyAtGoal(this, controller, testLocation, radius);
		
		public bool CheckAlreadyAtGoal(AAIController controller, AActor testGoal, float radius)
			=> E_UPawnAction_Move_CheckAlreadyAtGoal_o1(this, controller, testGoal, radius);
		
		protected void ClearPath()
			=> E_UPawnAction_Move_ClearPath(this);
		
		protected void ClearPendingRepath()
			=> E_UPawnAction_Move_ClearPendingRepath(this);
		
		protected void ClearTimers()
			=> E_UPawnAction_Move_ClearTimers(this);
		
		protected void DeferredPerformMoveAction()
			=> E_UPawnAction_Move_DeferredPerformMoveAction(this);
		
		public void EnableChildAbortionOnPathUpdate(bool bEnable)
			=> E_UPawnAction_Move_EnableChildAbortionOnPathUpdate(this, bEnable);
		
		public void EnableGoalLocationProjectionToNavigation(bool bEnable)
			=> E_UPawnAction_Move_EnableGoalLocationProjectionToNavigation(this, bEnable);
		
		public void EnablePathUpdateOnMoveGoalLocationChange(bool bEnable)
			=> E_UPawnAction_Move_EnablePathUpdateOnMoveGoalLocationChange(this, bEnable);
		
		public void EnableStrafing(bool bNewStrafing)
			=> E_UPawnAction_Move_EnableStrafing(this, bNewStrafing);
		
		protected virtual bool IsPartialPathAllowed()
			=> E_UPawnAction_Move_IsPartialPathAllowed(this);
		
		protected bool PerformMoveAction()
			=> E_UPawnAction_Move_PerformMoveAction(this);
		
		public void SetAcceptableRadius(float newAcceptableRadius)
			=> E_UPawnAction_Move_SetAcceptableRadius(this, newAcceptableRadius);
		
		public void SetAllowPartialPath(bool bEnable)
			=> E_UPawnAction_Move_SetAllowPartialPath(this, bEnable);
		
		public void SetFinishOnOverlap(bool bNewFinishOnOverlap)
			=> E_UPawnAction_Move_SetFinishOnOverlap(this, bNewFinishOnOverlap);
		
		protected void TryToRepath()
			=> E_UPawnAction_Move_TryToRepath(this);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnAction_Move self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPawnAction_Move(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnAction_Move>(PtrDesc);
		}}}
