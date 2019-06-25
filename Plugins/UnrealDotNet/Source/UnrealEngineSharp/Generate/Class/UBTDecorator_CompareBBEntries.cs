// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Decorators\BTDecorator_CompareBBEntries.h:30

namespace UnrealEngine
{
	public partial class UBTDecorator_CompareBBEntries : UBTDecorator
	{
		public UBTDecorator_CompareBBEntries(IntPtr adress)
			: base(adress)
		{
		}

		public UBTDecorator_CompareBBEntries(UObject Parent = null, string Name = "BTDecorator_CompareBBEntries")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTDecorator_CompareBBEntries(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTDecorator_CompareBBEntries(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTDecorator_CompareBBEntries self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTDecorator_CompareBBEntries(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTDecorator_CompareBBEntries>(PtrDesc);
		}}}
