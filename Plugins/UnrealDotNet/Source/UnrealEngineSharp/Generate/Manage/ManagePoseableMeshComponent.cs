using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\PoseableMeshComponent.h:17

namespace UnrealEngine
{
	[ManageType("ManagePoseableMeshComponent")]
	public partial class ManagePoseableMeshComponent : UPoseableMeshComponent
	{
		public ManagePoseableMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManagePoseableMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManagePoseableMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePoseableMeshComponent>(PtrDesc);
		}}}
