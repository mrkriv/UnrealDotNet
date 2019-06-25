// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_PawnActionBase.h:30

namespace UnrealEngine
{
	public partial class UBTTask_PawnActionBase : UBTTaskNode
	{
		public UBTTask_PawnActionBase(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_PawnActionBase(UObject Parent = null, string Name = "BTTask_PawnActionBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_PawnActionBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_PawnActionBase(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_PawnActionBase_OnActionLost(IntPtr self, IntPtr action);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// called when action is removed from stack (FinishedAborting) by some external event
		/// <para>default behavior: finish task as failed </para>
		/// </summary>
		protected virtual void OnActionLost(UPawnAction action)
			=> E_UBTTask_PawnActionBase_OnActionLost(this, action);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_PawnActionBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_PawnActionBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_PawnActionBase>(PtrDesc);
		}}}
