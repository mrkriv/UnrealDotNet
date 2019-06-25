// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction.h:47

namespace UnrealEngine
{
	public partial class UPawnAction : UObject
	{
		public UPawnAction(IntPtr adress)
			: base(adress)
		{
		}

		public UPawnAction(UObject Parent = null, string Name = "PawnAction")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnAction(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnAction(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Activate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnAction_GetChildAction(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnAction_GetController(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UPawnAction_GetDisplayName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnAction_GetInstigator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnAction_GetOwnerComponent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnAction_GetParentAction(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnAction_GetPawn(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UPawnAction_GetPriorityName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UPawnAction_GetStateDescription(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_HasActionObserver(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_HasBeenStarted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_IsActive(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_IsBeingAborted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_IsFinished(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_IsPaused(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_OnPopped(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Pause(IntPtr self, IntPtr pausedBy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_PushChildAction(IntPtr self, IntPtr action);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Resume(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_SetOwnerComponent(IntPtr self, IntPtr component);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_ShouldPauseMovement(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_Start(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_StopWaitingForMessages(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Tick(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_TickAction(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPawnAction_WantsTick(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// starts or resumes action, depending on internal state
		/// </summary>
		protected bool Activate()
			=> E_UPawnAction_Activate(this);
		
		public UPawnAction GetChildAction()
			=> E_UPawnAction_GetChildAction(this);
		
		public AController GetController()
			=> E_UPawnAction_GetController(this);
		
		public virtual string GetDisplayName()
			=> E_UPawnAction_GetDisplayName(this);
		
		public UObject GetInstigator()
			=> E_UPawnAction_GetInstigator(this);
		
		protected UPawnActionsComponent GetOwnerComponent()
			=> E_UPawnAction_GetOwnerComponent(this);
		
		public UPawnAction GetParentAction()
			=> E_UPawnAction_GetParentAction(this);
		
		public APawn GetPawn()
			=> E_UPawnAction_GetPawn(this);
		
		public string GetPriorityName()
			=> E_UPawnAction_GetPriorityName(this);
		
		public string GetStateDescription()
			=> E_UPawnAction_GetStateDescription(this);
		
		public bool HasActionObserver()
			=> E_UPawnAction_HasActionObserver(this);
		
		protected bool HasBeenStarted()
			=> E_UPawnAction_HasBeenStarted(this);
		
		public bool IsActive()
			=> E_UPawnAction_IsActive(this);
		
		public bool IsBeingAborted()
			=> E_UPawnAction_IsBeingAborted(this);
		
		public bool IsFinished()
			=> E_UPawnAction_IsFinished(this);
		
		public bool IsPaused()
			=> E_UPawnAction_IsPaused(this);
		
		protected void OnPopped()
			=> E_UPawnAction_OnPopped(this);
		
		
		/// <summary>
		/// called to pause action when higher priority or child action kicks in
		/// </summary>
		protected virtual bool Pause(UPawnAction pausedBy)
			=> E_UPawnAction_Pause(this, pausedBy);
		
		
		/// <summary>
		/// apart from doing regular push request copies additional values from Parent, like Priority and Instigator
		/// </summary>
		protected bool PushChildAction(UPawnAction action)
			=> E_UPawnAction_PushChildAction(this, action);
		
		
		/// <summary>
		/// called to resume action after being paused
		/// </summary>
		protected virtual bool Resume()
			=> E_UPawnAction_Resume(this);
		
		protected void SetOwnerComponent(UPawnActionsComponent component)
			=> E_UPawnAction_SetOwnerComponent(this, component);
		
		public bool ShouldPauseMovement()
			=> E_UPawnAction_ShouldPauseMovement(this);
		
		
		/// <summary>
		/// called to start off the Action
		/// <para>@NOTE if action fails to start no finishing or aborting mechanics will be triggered </para>
		/// </summary>
		/// <return>true</return>
		protected virtual bool Start()
			=> E_UPawnAction_Start(this);
		
		protected void StopWaitingForMessages()
			=> E_UPawnAction_StopWaitingForMessages(this);
		
		protected virtual void Tick(float deltaTime)
			=> E_UPawnAction_Tick(this, deltaTime);
		
		protected void TickAction(float deltaTime)
			=> E_UPawnAction_TickAction(this, deltaTime);
		
		public bool WantsTick()
			=> E_UPawnAction_WantsTick(this);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnAction self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPawnAction(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnAction>(PtrDesc);
		}}}
