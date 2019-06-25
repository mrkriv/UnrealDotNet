// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Services\BTService_DefaultFocus.h:34

namespace UnrealEngine
{
	public partial class UBTService_DefaultFocus : UBTService_BlackboardBase
	{
		public UBTService_DefaultFocus(IntPtr adress)
			: base(adress)
		{
		}

		public UBTService_DefaultFocus(UObject Parent = null, string Name = "BTService_DefaultFocus")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTService_DefaultFocus(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTService_DefaultFocus(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTService_DefaultFocus self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTService_DefaultFocus(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTService_DefaultFocus>(PtrDesc);
		}}}
