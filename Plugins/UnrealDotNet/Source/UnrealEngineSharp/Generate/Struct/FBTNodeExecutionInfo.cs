// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeComponent.h:25

namespace UnrealEngine
{
	public partial class FBTNodeExecutionInfo : NativeStructWrapper
	{
		public FBTNodeExecutionInfo(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTNodeExecutionInfo() :
			base(E_CreateStruct_FBTNodeExecutionInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTNodeExecutionInfo_bIsRestart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTNodeExecutionInfo_bIsRestart_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTNodeExecutionInfo_bTryNextChild_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTNodeExecutionInfo_bTryNextChild_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBTNodeExecutionInfo_ExecuteNode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTNodeExecutionInfo_ExecuteNode_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBTNodeExecutionInfo_SearchEnd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTNodeExecutionInfo_SearchEnd_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBTNodeExecutionInfo_SearchStart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTNodeExecutionInfo_SearchStart_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTNodeExecutionInfo();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// if set, request was not instigated by finishing task/initialization but is a restart (e.g. decorator)
		/// </summary>
		public byte bIsRestart
		{
			get => E_PROP_FBTNodeExecutionInfo_bIsRestart_GET(NativePointer);
			set => E_PROP_FBTNodeExecutionInfo_bIsRestart_SET(NativePointer, value);
		}

		
		/// <summary>
		/// if set, tree will try to execute next child of composite instead of forcing branch containing SearchStart
		/// </summary>
		public byte bTryNextChild
		{
			get => E_PROP_FBTNodeExecutionInfo_bTryNextChild_GET(NativePointer);
			set => E_PROP_FBTNodeExecutionInfo_bTryNextChild_SET(NativePointer, value);
		}

		
		/// <summary>
		/// node to be executed
		/// </summary>
		public UBTCompositeNode ExecuteNode
		{
			get => E_PROP_FBTNodeExecutionInfo_ExecuteNode_GET(NativePointer);
			set => E_PROP_FBTNodeExecutionInfo_ExecuteNode_SET(NativePointer, value);
		}

		
		/// <summary>
		/// index of last task allowed to be executed
		/// </summary>
		public FBTNodeIndex SearchEnd
		{
			get => E_PROP_FBTNodeExecutionInfo_SearchEnd_GET(NativePointer);
			set => E_PROP_FBTNodeExecutionInfo_SearchEnd_SET(NativePointer, value);
		}

		
		/// <summary>
		/// index of first task allowed to be executed
		/// </summary>
		public FBTNodeIndex SearchStart
		{
			get => E_PROP_FBTNodeExecutionInfo_SearchStart_GET(NativePointer);
			set => E_PROP_FBTNodeExecutionInfo_SearchStart_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTNodeExecutionInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTNodeExecutionInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTNodeExecutionInfo(adress, false);
		}}}
