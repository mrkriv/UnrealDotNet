// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ReflectionCaptureComponent.h:28

namespace UnrealEngine
{
	public  partial class UReflectionCaptureComponent : USceneComponent
	{
		public UReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UReflectionCaptureComponent(UObject Parent = null, string Name = "ReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UReflectionCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UReflectionCaptureComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UReflectionCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UReflectionCaptureComponent>(PtrDesc);
		}}}
