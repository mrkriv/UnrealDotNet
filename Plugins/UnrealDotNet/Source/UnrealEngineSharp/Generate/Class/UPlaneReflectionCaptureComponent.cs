// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PlaneReflectionCaptureComponent.h:13

namespace UnrealEngine
{
	public  partial class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public UPlaneReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPlaneReflectionCaptureComponent(UObject Parent = null, string Name = "PlaneReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPlaneReflectionCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPlaneReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UPlaneReflectionCaptureComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UPlaneReflectionCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPlaneReflectionCaptureComponent>(PtrDesc);
		}}}
