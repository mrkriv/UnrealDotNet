// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTService.h:35

namespace UnrealEngine
{
	public partial class UBTService : UBTAuxiliaryNode
	{
		public UBTService(IntPtr adress)
			: base(adress)
		{
		}

		public UBTService(UObject Parent = null, string Name = "BTService")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTService(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTService(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBTService_GetStaticServiceDescription(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBTService_GetStaticTickIntervalDescription(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_NotifyParentActivation(IntPtr self, IntPtr searchData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_OnSearchStart(IntPtr self, IntPtr searchData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTService_ScheduleNextTick(IntPtr self, byte nodeMemory);
		
		#endregion
		
		#region ExternMethods
		protected virtual string GetStaticServiceDescription()
			=> E_UBTService_GetStaticServiceDescription(this);
		
		protected string GetStaticTickIntervalDescription()
			=> E_UBTService_GetStaticTickIntervalDescription(this);
		
		public void NotifyParentActivation(FBehaviorTreeSearchData searchData)
			=> E_UBTService_NotifyParentActivation(this, searchData);
		
		
		/// <summary>
		/// called when search enters underlying branch
		/// <para>this function should be considered as const (don't modify state of object) if node is not instanced! </para>
		/// </summary>
		protected virtual void OnSearchStart(FBehaviorTreeSearchData searchData)
			=> E_UBTService_OnSearchStart(this, searchData);
		
		
		/// <summary>
		/// set next tick time
		/// </summary>
		protected void ScheduleNextTick(byte nodeMemory)
			=> E_UBTService_ScheduleNextTick(this, nodeMemory);
		
		#endregion
		
		public static implicit operator IntPtr(UBTService self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTService(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTService>(PtrDesc);
		}}}
