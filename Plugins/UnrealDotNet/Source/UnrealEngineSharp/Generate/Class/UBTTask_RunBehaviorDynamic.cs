// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_RunBehaviorDynamic.h:21

namespace UnrealEngine
{
	public partial class UBTTask_RunBehaviorDynamic : UBTTaskNode
	{
		public UBTTask_RunBehaviorDynamic(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_RunBehaviorDynamic(UObject Parent = null, string Name = "BTTask_RunBehaviorDynamic")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_RunBehaviorDynamic(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_RunBehaviorDynamic(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTTask_RunBehaviorDynamic_SetBehaviorAsset(IntPtr self, IntPtr newBehaviorAsset);
		
		#endregion
		
		#region ExternMethods
		public bool SetBehaviorAsset(UBehaviorTree newBehaviorAsset)
			=> E_UBTTask_RunBehaviorDynamic_SetBehaviorAsset(this, newBehaviorAsset);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_RunBehaviorDynamic self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_RunBehaviorDynamic(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_RunBehaviorDynamic>(PtrDesc);
		}}}
