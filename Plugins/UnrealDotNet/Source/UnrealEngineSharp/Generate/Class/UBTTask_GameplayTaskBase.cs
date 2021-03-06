// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_GameplayTaskBase.h:26

namespace UnrealEngine
{
	public partial class UBTTask_GameplayTaskBase : UBTTaskNode
	{
		public UBTTask_GameplayTaskBase(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_GameplayTaskBase(UObject Parent = null, string Name = "BTTask_GameplayTaskBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_GameplayTaskBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_GameplayTaskBase(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_GameplayTaskBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_GameplayTaskBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_GameplayTaskBase>(PtrDesc);
		}}}
