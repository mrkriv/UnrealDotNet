// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BrainComponent.h:117

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageBrainComponent
	/// brain component owning this observer
	/// </summary>
	public partial class UBrainComponent : UActorComponent
	{
		public UBrainComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UBrainComponent(UObject Parent = null, string Name = "BrainComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBrainComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UBrainComponent_AIMessage_MoveFinished_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UBrainComponent_AIMessage_QueryFinished_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UBrainComponent_AIMessage_RepathFailed_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBrainComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBrainComponent_Cleanup(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBrainComponent_GetAIOwner(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBrainComponent_GetDebugInfoString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBrainComponent_IsPaused(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBrainComponent_IsRunning(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBrainComponent_PauseLogic(IntPtr self, string reason);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBrainComponent_RequestLogicRestartOnUnlock(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBrainComponent_RestartLogic(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBrainComponent_StopLogic(IntPtr self, string reason);
		
		#endregion
		
		#region Property
		public static string AIMessage_MoveFinished
		{
			get => E_PROP_UBrainComponent_AIMessage_MoveFinished_GET();
		}

		public static string AIMessage_QueryFinished
		{
			get => E_PROP_UBrainComponent_AIMessage_QueryFinished_GET();
		}

		public static string AIMessage_RepathFailed
		{
			get => E_PROP_UBrainComponent_AIMessage_RepathFailed_GET();
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// AI logic won't be needed anymore, stop all activity and run cleanup
		/// </summary>
		public virtual void Cleanup()
			=> E_UBrainComponent_Cleanup(this);
		
		public AAIController GetAIOwner()
			=> E_UBrainComponent_GetAIOwner(this);
		
		public virtual string GetDebugInfoString()
			=> E_UBrainComponent_GetDebugInfoString(this);
		
		public virtual bool IsPaused()
			=> E_UBrainComponent_IsPaused(this);
		
		public virtual bool IsRunning()
			=> E_UBrainComponent_IsRunning(this);
		
		public virtual void PauseLogic(string reason)
			=> E_UBrainComponent_PauseLogic(this, reason);
		
		
		/// <summary>
		/// To be called in case we want to restart AI logic while it's still being locked.
		/// <para>On subsequent ResumeLogic instead RestartLogic will be called. </para>
		/// @note this call does nothing if logic is not locked at the moment of call
		/// </summary>
		public void RequestLogicRestartOnUnlock()
			=> E_UBrainComponent_RequestLogicRestartOnUnlock(this);
		
		public virtual void RestartLogic()
			=> E_UBrainComponent_RestartLogic(this);
		
		public virtual void StopLogic(string reason)
			=> E_UBrainComponent_StopLogic(this, reason);
		
		#endregion
		
		public static implicit operator IntPtr(UBrainComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBrainComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBrainComponent>(PtrDesc);
		}}}
