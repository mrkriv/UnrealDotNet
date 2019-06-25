// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnActionsComponent.h:78

namespace UnrealEngine
{
	public partial class UPawnActionsComponent : UActorComponent
	{
		public UPawnActionsComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UPawnActionsComponent(UObject Parent = null, string Name = "PawnActionsComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnActionsComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnActionsComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnActionsComponent_CacheControlledPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UPawnActionsComponent_GetActionEventsQueueSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnActionsComponent_GetControlledPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnActionsComponent_GetController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnActionsComponent_GetCurrentAction(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnActionsComponent_SetControlledPawn(IntPtr self, IntPtr newPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnActionsComponent_UpdateAILogicLock(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnActionsComponent_UpdateCurrentAction(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		protected APawn CacheControlledPawn()
			=> E_UPawnActionsComponent_CacheControlledPawn(this);
		
		public int GetActionEventsQueueSize()
			=> E_UPawnActionsComponent_GetActionEventsQueueSize(this);
		
		public APawn GetControlledPawn()
			=> E_UPawnActionsComponent_GetControlledPawn(this);
		
		public AController GetController()
			=> E_UPawnActionsComponent_GetController(this);
		
		public UPawnAction GetCurrentAction()
			=> E_UPawnActionsComponent_GetCurrentAction(this);
		
		
		/// <summary>
		/// Use it to save component work to figure out what it's controlling
		/// <para>or if component can't/won't be able to figure it out properly </para>
		/// @NOTE will throw a log warning if trying to set ControlledPawn if it's already set
		/// </summary>
		public void SetControlledPawn(APawn newPawn)
			=> E_UPawnActionsComponent_SetControlledPawn(this, newPawn);
		
		protected void UpdateAILogicLock()
			=> E_UPawnActionsComponent_UpdateAILogicLock(this);
		
		
		/// <summary>
		/// Finds the action that should be running. If it's different from CurrentAction
		/// <para>then CurrentAction gets paused and newly selected action gets started up </para>
		/// </summary>
		protected void UpdateCurrentAction()
			=> E_UPawnActionsComponent_UpdateCurrentAction(this);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnActionsComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPawnActionsComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnActionsComponent>(PtrDesc);
		}}}
