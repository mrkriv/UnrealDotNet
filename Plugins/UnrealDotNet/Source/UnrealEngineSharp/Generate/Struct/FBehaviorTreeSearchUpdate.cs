// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:378

namespace UnrealEngine
{
	public partial class FBehaviorTreeSearchUpdate : NativeStructWrapper
	{
		public FBehaviorTreeSearchUpdate(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBehaviorTreeSearchUpdate() :
			base(E_CreateStruct_FBehaviorTreeSearchUpdate(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBehaviorTreeSearchUpdate_AuxNode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeSearchUpdate_AuxNode_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBehaviorTreeSearchUpdate_bPostUpdate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeSearchUpdate_bPostUpdate_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBehaviorTreeSearchUpdate_TaskNode_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeSearchUpdate_TaskNode_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeSearchUpdate();
		
		#endregion
		
		#region Property
		public UBTAuxiliaryNode AuxNode
		{
			get => E_PROP_FBehaviorTreeSearchUpdate_AuxNode_GET(NativePointer);
			set => E_PROP_FBehaviorTreeSearchUpdate_AuxNode_SET(NativePointer, value);
		}

		
		/// <summary>
		/// if set, this entry will be applied AFTER other are processed
		/// </summary>
		public byte bPostUpdate
		{
			get => E_PROP_FBehaviorTreeSearchUpdate_bPostUpdate_GET(NativePointer);
			set => E_PROP_FBehaviorTreeSearchUpdate_bPostUpdate_SET(NativePointer, value);
		}

		public UBTTaskNode TaskNode
		{
			get => E_PROP_FBehaviorTreeSearchUpdate_TaskNode_GET(NativePointer);
			set => E_PROP_FBehaviorTreeSearchUpdate_TaskNode_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBehaviorTreeSearchUpdate self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBehaviorTreeSearchUpdate(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBehaviorTreeSearchUpdate(adress, false);
		}}}
