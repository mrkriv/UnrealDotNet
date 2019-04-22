// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PoseableMeshComponent.h:17

namespace UnrealEngine
{
	[ManageType("ManagePoseableMeshComponent")]
	public partial class ManagePoseableMeshComponent : UPoseableMeshComponent
	{
		public ManagePoseableMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManagePoseableMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManagePoseableMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePoseableMeshComponent>(PtrDesc);
		}}}
