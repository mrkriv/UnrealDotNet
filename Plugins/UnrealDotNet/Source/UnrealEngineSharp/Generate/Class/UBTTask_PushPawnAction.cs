// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_PushPawnAction.h:17

namespace UnrealEngine
{
	public partial class UBTTask_PushPawnAction : UBTTask_PawnActionBase
	{
		public UBTTask_PushPawnAction(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_PushPawnAction(UObject Parent = null, string Name = "BTTask_PushPawnAction")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_PushPawnAction(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_PushPawnAction(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_PushPawnAction self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_PushPawnAction(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_PushPawnAction>(PtrDesc);
		}}}
