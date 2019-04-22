// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SphereReflectionCaptureComponent.h:13

namespace UnrealEngine
{
	public  partial class USphereReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public USphereReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USphereReflectionCaptureComponent(UObject Parent = null, string Name = "SphereReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USphereReflectionCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USphereReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USphereReflectionCaptureComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USphereReflectionCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USphereReflectionCaptureComponent>(PtrDesc);
		}}}
