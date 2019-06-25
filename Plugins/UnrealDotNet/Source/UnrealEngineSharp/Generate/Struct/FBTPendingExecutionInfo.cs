// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeComponent.h:51

namespace UnrealEngine
{
	public partial class FBTPendingExecutionInfo : NativeStructWrapper
	{
		public FBTPendingExecutionInfo(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTPendingExecutionInfo() :
			base(E_CreateStruct_FBTPendingExecutionInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBTPendingExecutionInfo_NextTask_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTPendingExecutionInfo_NextTask_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTPendingExecutionInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBTPendingExecutionInfo_IsSet(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBTPendingExecutionInfo_Lock(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBTPendingExecutionInfo_Unlock(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// next task to execute
		/// </summary>
		public UBTTaskNode NextTask
		{
			get => E_PROP_FBTPendingExecutionInfo_NextTask_GET(NativePointer);
			set => E_PROP_FBTPendingExecutionInfo_NextTask_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool IsSet()
			=> E_FBTPendingExecutionInfo_IsSet(this);
		
		public void Lock()
			=> E_FBTPendingExecutionInfo_Lock(this);
		
		public void Unlock()
			=> E_FBTPendingExecutionInfo_Unlock(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBTPendingExecutionInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTPendingExecutionInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTPendingExecutionInfo(adress, false);
		}}}
