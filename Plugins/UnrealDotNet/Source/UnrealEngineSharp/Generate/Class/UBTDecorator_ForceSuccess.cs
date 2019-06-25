// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_ForceSuccess.h:20

namespace UnrealEngine
{
	public partial class UBTDecorator_ForceSuccess : UBTDecorator
	{
		public UBTDecorator_ForceSuccess(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_ForceSuccess(UObject Parent = null, string Name = "BTDecorator_ForceSuccess")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_ForceSuccess(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_ForceSuccess(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_ForceSuccess self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_ForceSuccess(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_ForceSuccess>(PtrDesc);
		}}}
