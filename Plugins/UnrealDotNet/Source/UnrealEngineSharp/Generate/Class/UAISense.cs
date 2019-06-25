// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense.h:19

namespace UnrealEngine
{
	public partial class UAISense : UObject
	{
		public UAISense(IntPtr adress)
			: base(adress)
		{
		}

		public UAISense(UObject Parent = null, string Name = "AISense")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISense(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISense(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_CleanseInvalidSources(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAISense_GetDebugLegend(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAISense_GetDebugName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UAISense_GetDefaultExpirationAge(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UAISense_GetPerceptionSystem(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAISense_NeedsNotificationOnForgetting(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_OnListenerForgetsActor(IntPtr self, IntPtr listener, IntPtr actorToForget);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_OnListenerForgetsAll(IntPtr self, IntPtr listener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_OnListenerRemoved(IntPtr self, IntPtr newListener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_OnListenerUpdate(IntPtr self, IntPtr newListener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_OnNewListener(IntPtr self, IntPtr newListener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_OnNewPawn(IntPtr self, IntPtr newPawn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAISense_ProgressTime(IntPtr self, float deltaSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_RegisterSource(IntPtr self, IntPtr sourceActors);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_RegisterWrappedEvent(IntPtr self, IntPtr perceptionEvent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_RequestImmediateUpdate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_RequestUpdateInSeconds(IntPtr self, float updateInSeconds);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAISense_ShouldAutoRegisterAllPawnsAsSources(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Tick(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_UnregisterSource(IntPtr self, IntPtr sourceActors);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UAISense_Update(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAISense_WantsNewPawnNotification(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UAISense_WantsUpdateOnlyOnPerceptionValueChange(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public virtual void CleanseInvalidSources()
			=> E_UAISense_CleanseInvalidSources(this);
		
		protected virtual string GetDebugLegend()
			=> E_UAISense_GetDebugLegend(this);
		
		protected string GetDebugName()
			=> E_UAISense_GetDebugName(this);
		
		public float GetDefaultExpirationAge()
			=> E_UAISense_GetDefaultExpirationAge(this);
		
		protected UAIPerceptionSystem GetPerceptionSystem()
			=> E_UAISense_GetPerceptionSystem(this);
		
		public bool NeedsNotificationOnForgetting()
			=> E_UAISense_NeedsNotificationOnForgetting(this);
		
		public virtual void OnListenerForgetsActor(FPerceptionListener listener, AActor actorToForget)
			=> E_UAISense_OnListenerForgetsActor(this, listener, actorToForget);
		
		public virtual void OnListenerForgetsAll(FPerceptionListener listener)
			=> E_UAISense_OnListenerForgetsAll(this, listener);
		
		public void OnListenerRemoved(FPerceptionListener newListener)
			=> E_UAISense_OnListenerRemoved(this, newListener);
		
		public void OnListenerUpdate(FPerceptionListener newListener)
			=> E_UAISense_OnListenerUpdate(this, newListener);
		
		public void OnNewListener(FPerceptionListener newListener)
			=> E_UAISense_OnNewListener(this, newListener);
		
		
		/// <summary>
		/// gets called when perception system gets notified about new spawned pawn.
		/// <para>@Note: do not call super implementation. It's used to detect when subclasses don't override it </para>
		/// </summary>
		protected virtual void OnNewPawn(APawn newPawn)
			=> E_UAISense_OnNewPawn(this, newPawn);
		
		
		/// <summary>
		/// </summary>
		/// <return>should</return>
		public bool ProgressTime(float deltaSeconds)
			=> E_UAISense_ProgressTime(this, deltaSeconds);
		
		public virtual void RegisterSource(AActor sourceActors)
			=> E_UAISense_RegisterSource(this, sourceActors);
		
		public virtual void RegisterWrappedEvent(UAISenseEvent perceptionEvent)
			=> E_UAISense_RegisterWrappedEvent(this, perceptionEvent);
		
		
		/// <summary>
		/// will result in updating as soon as possible
		/// </summary>
		protected void RequestImmediateUpdate()
			=> E_UAISense_RequestImmediateUpdate(this);
		
		
		/// <summary>
		/// will result in updating in specified number of seconds
		/// </summary>
		protected void RequestUpdateInSeconds(float updateInSeconds)
			=> E_UAISense_RequestUpdateInSeconds(this, updateInSeconds);
		
		public bool ShouldAutoRegisterAllPawnsAsSources()
			=> E_UAISense_ShouldAutoRegisterAllPawnsAsSources(this);
		
		public void Tick()
			=> E_UAISense_Tick(this);
		
		public virtual void UnregisterSource(AActor sourceActors)
			=> E_UAISense_UnregisterSource(this, sourceActors);
		
		
		/// <summary>
		/// </summary>
		/// <return>time</return>
		protected virtual float Update()
			=> E_UAISense_Update(this);
		
		public bool WantsNewPawnNotification()
			=> E_UAISense_WantsNewPawnNotification(this);
		
		public bool WantsUpdateOnlyOnPerceptionValueChange()
			=> E_UAISense_WantsUpdateOnlyOnPerceptionValueChange(this);
		
		#endregion
		
		public static implicit operator IntPtr(UAISense self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISense(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISense>(PtrDesc);
		}}}
