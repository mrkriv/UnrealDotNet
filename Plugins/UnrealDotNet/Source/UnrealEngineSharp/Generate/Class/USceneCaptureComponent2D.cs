// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent2D.h:20

namespace UnrealEngine
{
	public  partial class USceneCaptureComponent2D : USceneCaptureComponent
	{
		public USceneCaptureComponent2D(IntPtr Adress)
			: base(Adress)
		{
		}

		public USceneCaptureComponent2D(UObject Parent = null, string Name = "SceneCaptureComponent2D")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneCaptureComponent2D(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneCaptureComponent2D(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponent2D self)
		{
			return self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent2D(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneCaptureComponent2D>(PtrDesc);
		}}}
