using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\MeshComponent.h:21

namespace UnrealEngine
{
	public partial class ManageMeshComponent : UMeshComponent
	{
		public ManageMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageMeshComponent>(PtrDesc);
		}}}
