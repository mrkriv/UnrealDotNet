// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:120

namespace UnrealEngine
{
	public  partial class UInstancedStaticMeshComponent : UStaticMeshComponent
	{
		public UInstancedStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UInstancedStaticMeshComponent(UObject Parent = null, string Name = "InstancedStaticMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UInstancedStaticMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInstancedStaticMeshComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UInstancedStaticMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UInstancedStaticMeshComponent>(PtrDesc);
		}}}
