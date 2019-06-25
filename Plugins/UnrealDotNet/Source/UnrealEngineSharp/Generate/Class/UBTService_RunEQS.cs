// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Services\BTService_RunEQS.h:21

namespace UnrealEngine
{
	public partial class UBTService_RunEQS : UBTService_BlackboardBase
	{
		public UBTService_RunEQS(IntPtr adress)
			: base(adress)
		{
		}

		public UBTService_RunEQS(UObject Parent = null, string Name = "BTService_RunEQS")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTService_RunEQS(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTService_RunEQS(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTService_RunEQS self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTService_RunEQS(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTService_RunEQS>(PtrDesc);
		}}}
