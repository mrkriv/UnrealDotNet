// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\EngineMessage.h:11

namespace UnrealEngine
{
	public  partial class UEngineMessage : ULocalMessage
	{
		public UEngineMessage(IntPtr Adress)
			: base(Adress)
		{
		}

		public UEngineMessage(UObject Parent = null, string Name = "EngineMessage")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEngineMessage(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEngineMessage(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UEngineMessage self)
		{
			return self.NativePointer;
		}

		public static implicit operator UEngineMessage(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngineMessage>(PtrDesc);
		}}}
