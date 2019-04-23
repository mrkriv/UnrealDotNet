// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\ScalarRegister.h:26

namespace UnrealEngine
{
	public  partial class ScalarRegister : NativeWrapper
	{
		public ScalarRegister(IntPtr Adress)
			: base(Adress)
		{
		}

		public ScalarRegister(UObject Parent = null, string Name = "calarRegister")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ScalarRegister(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ScalarRegister(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ScalarRegister self)
		{
			return self.NativePointer;
		}

		public static implicit operator ScalarRegister(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ScalarRegister>(PtrDesc);
		}}}
