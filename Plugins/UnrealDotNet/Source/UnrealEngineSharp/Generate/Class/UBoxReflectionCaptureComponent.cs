// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BoxReflectionCaptureComponent.h:13

namespace UnrealEngine
{
	public  partial class UBoxReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public UBoxReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UBoxReflectionCaptureComponent(UObject Parent = null, string Name = "BoxReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBoxReflectionCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBoxReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBoxReflectionCaptureComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UBoxReflectionCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBoxReflectionCaptureComponent>(PtrDesc);
		}}}
