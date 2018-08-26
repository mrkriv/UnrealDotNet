// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:254

namespace UnrealEngine
{
	[ManageType("ManageSkeletalMeshComponent")]
	public partial class ManageSkeletalMeshComponent : USkeletalMeshComponent
	{
		public ManageSkeletalMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSkeletalMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSkeletalMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSkeletalMeshComponent>(PtrDesc);
		}}}
