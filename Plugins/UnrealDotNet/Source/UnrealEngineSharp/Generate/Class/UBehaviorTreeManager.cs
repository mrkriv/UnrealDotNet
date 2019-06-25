// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeManager.h:33

namespace UnrealEngine
{
	public partial class UBehaviorTreeManager : UObject
	{
		public UBehaviorTreeManager(IntPtr adress)
			: base(adress)
		{
		}

		public UBehaviorTreeManager(UObject Parent = null, string Name = "BehaviorTreeManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBehaviorTreeManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UBehaviorTreeManager_MaxDebuggerSteps_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBehaviorTreeManager_MaxDebuggerSteps_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBehaviorTreeManager(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeManager_AddActiveComponent(IntPtr self, IntPtr component);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeManager_DumpUsageStats(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UBehaviorTreeManager_GetAlignedDataSize(IntPtr self, int size);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBehaviorTreeManager_GetCurrent(IntPtr self, IntPtr world);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBehaviorTreeManager_GetCurrent_o1(IntPtr self, IntPtr worldContextObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeManager_RemoveActiveComponent(IntPtr self, IntPtr component);
		
		#endregion
		
		#region Property
		public int MaxDebuggerSteps
		{
			get => E_PROP_UBehaviorTreeManager_MaxDebuggerSteps_GET(NativePointer);
			set => E_PROP_UBehaviorTreeManager_MaxDebuggerSteps_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// register new behavior tree component for tracking
		/// </summary>
		public void AddActiveComponent(UBehaviorTreeComponent component)
			=> E_UBehaviorTreeManager_AddActiveComponent(this, component);
		
		public void DumpUsageStats()
			=> E_UBehaviorTreeManager_DumpUsageStats(this);
		
		
		/// <summary>
		/// get aligned memory size
		/// </summary>
		public int GetAlignedDataSize(int size)
			=> E_UBehaviorTreeManager_GetAlignedDataSize(this, size);
		
		public UBehaviorTreeManager GetCurrent(UWorld world)
			=> E_UBehaviorTreeManager_GetCurrent(this, world);
		
		public UBehaviorTreeManager GetCurrent(UObject worldContextObject)
			=> E_UBehaviorTreeManager_GetCurrent_o1(this, worldContextObject);
		
		
		/// <summary>
		/// unregister behavior tree component from tracking
		/// </summary>
		public void RemoveActiveComponent(UBehaviorTreeComponent component)
			=> E_UBehaviorTreeManager_RemoveActiveComponent(this, component);
		
		#endregion
		
		public static implicit operator IntPtr(UBehaviorTreeManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBehaviorTreeManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBehaviorTreeManager>(PtrDesc);
		}}}
