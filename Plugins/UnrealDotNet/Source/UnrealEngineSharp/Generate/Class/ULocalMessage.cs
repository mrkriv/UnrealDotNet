// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\LocalMessage.h:57

namespace UnrealEngine
{
	public  partial class ULocalMessage : UObject
	{
		public ULocalMessage(IntPtr Adress)
			: base(Adress)
		{
		}

		public ULocalMessage(UObject Parent = null, string Name = "LocalMessage")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULocalMessage(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULocalMessage(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ULocalMessage self)
		{
			return self.NativePointer;
		}

		public static implicit operator ULocalMessage(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULocalMessage>(PtrDesc);
		}}}
