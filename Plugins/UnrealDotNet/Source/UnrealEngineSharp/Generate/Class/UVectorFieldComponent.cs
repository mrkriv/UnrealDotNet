// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\VectorFieldComponent.h:18

namespace UnrealEngine
{
	public  partial class UVectorFieldComponent : UPrimitiveComponent
	{
		public UVectorFieldComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UVectorFieldComponent(UObject Parent = null, string Name = "VectorFieldComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UVectorFieldComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UVectorFieldComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UVectorFieldComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UVectorFieldComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UVectorFieldComponent>(PtrDesc);
		}}}
