// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\TouchInterface.h:56

namespace UnrealEngine
{
	public  partial class UTouchInterface : UObject
	{
		public UTouchInterface(IntPtr Adress)
			: base(Adress)
		{
		}

		public UTouchInterface(UObject Parent = null, string Name = "TouchInterface")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UTouchInterface(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UTouchInterface(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UTouchInterface self)
		{
			return self.NativePointer;
		}

		public static implicit operator UTouchInterface(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UTouchInterface>(PtrDesc);
		}}}
