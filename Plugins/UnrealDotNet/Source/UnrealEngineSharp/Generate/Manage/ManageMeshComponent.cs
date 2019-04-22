// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\MeshComponent.h:21

namespace UnrealEngine
{
	[ManageType("ManageMeshComponent")]
	public partial class ManageMeshComponent : UMeshComponent
	{
		public ManageMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageMeshComponent>(PtrDesc);
		}}}
