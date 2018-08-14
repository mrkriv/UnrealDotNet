using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:114

namespace UnrealEngine
{
	[ManageType("ManageInstancedStaticMeshComponent")]
	public partial class ManageInstancedStaticMeshComponent : UInstancedStaticMeshComponent
	{
		public ManageInstancedStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageInstancedStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageInstancedStaticMeshComponent>(PtrDesc);
		}}}
