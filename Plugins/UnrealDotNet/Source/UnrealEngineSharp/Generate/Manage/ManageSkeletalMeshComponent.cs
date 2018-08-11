using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkeletalMeshComponent.h:254

namespace UnrealEngine
{
	public partial class ManageSkeletalMeshComponent : USkeletalMeshComponent
	{
		public ManageSkeletalMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSkeletalMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSkeletalMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSkeletalMeshComponent>(PtrDesc);
		}}}
