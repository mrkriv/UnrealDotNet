// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PoseableMeshComponent.h:17

namespace UnrealEngine
{
	public  partial class UPoseableMeshComponent : USkinnedMeshComponent
	{
		public UPoseableMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPoseableMeshComponent(UObject Parent = null, string Name = "PoseableMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPoseableMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPoseableMeshComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UPoseableMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UPoseableMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPoseableMeshComponent>(PtrDesc);
		}}}
