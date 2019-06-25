// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_RunBehavior.h:23

namespace UnrealEngine
{
	public partial class UBTTask_RunBehavior : UBTTaskNode
	{
		public UBTTask_RunBehavior(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_RunBehavior(UObject Parent = null, string Name = "BTTask_RunBehavior")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_RunBehavior(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_RunBehavior(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UBTTask_RunBehavior_GetInjectedNodesCount(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBTTask_RunBehavior_GetSubtreeAsset(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// @returns number of injected nodes
		/// </summary>
		public int GetInjectedNodesCount()
			=> E_UBTTask_RunBehavior_GetInjectedNodesCount(this);
		
		
		/// <summary>
		/// @returns subtree asset
		/// </summary>
		public UBehaviorTree GetSubtreeAsset()
			=> E_UBTTask_RunBehavior_GetSubtreeAsset(this);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_RunBehavior self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_RunBehavior(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_RunBehavior>(PtrDesc);
		}}}
