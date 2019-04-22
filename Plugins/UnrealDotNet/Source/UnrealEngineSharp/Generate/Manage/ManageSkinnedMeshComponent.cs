// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:195

namespace UnrealEngine
{
	[ManageType("ManageSkinnedMeshComponent")]
	public partial class ManageSkinnedMeshComponent : USkinnedMeshComponent
	{
		public ManageSkinnedMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSkinnedMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSkinnedMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSkinnedMeshComponent>(PtrDesc);
		}}}
