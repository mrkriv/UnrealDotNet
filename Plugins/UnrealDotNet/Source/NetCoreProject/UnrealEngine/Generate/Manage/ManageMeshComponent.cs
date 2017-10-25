using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\MeshComponent.h:20

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
