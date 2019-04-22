// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:120

namespace UnrealEngine
{
	[ManageType("ManageInstancedStaticMeshComponent")]
	public partial class ManageInstancedStaticMeshComponent : UInstancedStaticMeshComponent
	{
		public ManageInstancedStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageInstancedStaticMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageInstancedStaticMeshComponent>(PtrDesc);
		}}}
