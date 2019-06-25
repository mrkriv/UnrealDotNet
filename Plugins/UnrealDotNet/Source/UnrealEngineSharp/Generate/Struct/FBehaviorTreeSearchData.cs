// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:410

namespace UnrealEngine
{
	public partial class FBehaviorTreeSearchData : NativeStructWrapper
	{
		public FBehaviorTreeSearchData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBehaviorTreeSearchData(UBehaviorTreeComponent inOwnerComp) :
			base(E_CreateStruct_FBehaviorTreeSearchData_UBehaviorTreeComponent(inOwnerComp), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBehaviorTreeSearchData_OwnerComp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeSearchData_OwnerComp_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FBehaviorTreeSearchData_RollbackInstanceIdx_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeSearchData_RollbackInstanceIdx_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBehaviorTreeSearchData_SearchEnd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeSearchData_SearchEnd_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FBehaviorTreeSearchData_SearchId_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeSearchData_SearchId_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBehaviorTreeSearchData_SearchStart_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBehaviorTreeSearchData_SearchStart_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBehaviorTreeSearchData_UBehaviorTreeComponent(IntPtr inOwnerComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBehaviorTreeSearchData_AddUniqueUpdate(IntPtr self, IntPtr updateInfo);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBehaviorTreeSearchData_AssignSearchId(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBehaviorTreeSearchData_Reset(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// BT component
		/// </summary>
		public UBehaviorTreeComponent OwnerComp
		{
			get => E_PROP_FBehaviorTreeSearchData_OwnerComp_GET(NativePointer);
			set => E_PROP_FBehaviorTreeSearchData_OwnerComp_SET(NativePointer, value);
		}

		
		/// <summary>
		/// active instance index to rollback to
		/// </summary>
		public int RollbackInstanceIdx
		{
			get => E_PROP_FBehaviorTreeSearchData_RollbackInstanceIdx_GET(NativePointer);
			set => E_PROP_FBehaviorTreeSearchData_RollbackInstanceIdx_SET(NativePointer, value);
		}

		
		/// <summary>
		/// last node allowed in search
		/// </summary>
		public FBTNodeIndex SearchEnd
		{
			get => E_PROP_FBehaviorTreeSearchData_SearchEnd_GET(NativePointer);
			set => E_PROP_FBehaviorTreeSearchData_SearchEnd_SET(NativePointer, value);
		}

		
		/// <summary>
		/// search unique number
		/// </summary>
		public int SearchId
		{
			get => E_PROP_FBehaviorTreeSearchData_SearchId_GET(NativePointer);
			set => E_PROP_FBehaviorTreeSearchData_SearchId_SET(NativePointer, value);
		}

		
		/// <summary>
		/// first node allowed in search
		/// </summary>
		public FBTNodeIndex SearchStart
		{
			get => E_PROP_FBehaviorTreeSearchData_SearchStart_GET(NativePointer);
			set => E_PROP_FBehaviorTreeSearchData_SearchStart_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// adds update info to PendingUpdates array, removing all previous updates for this node
		/// </summary>
		public void AddUniqueUpdate(FBehaviorTreeSearchUpdate updateInfo)
			=> E_FBehaviorTreeSearchData_AddUniqueUpdate(this, updateInfo);
		
		
		/// <summary>
		/// assign unique Id number
		/// </summary>
		public void AssignSearchId()
			=> E_FBehaviorTreeSearchData_AssignSearchId(this);
		
		
		/// <summary>
		/// clear state of search
		/// </summary>
		public void Reset()
			=> E_FBehaviorTreeSearchData_Reset(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBehaviorTreeSearchData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBehaviorTreeSearchData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBehaviorTreeSearchData(adress, false);
		}}}
