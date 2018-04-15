using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\HierarchicalInstancedStaticMeshComponent.h:60

namespace UnrealEngine
{
	public partial class ManageHierarchicalInstancedStaticMeshComponent : UHierarchicalInstancedStaticMeshComponent
	{
		public ManageHierarchicalInstancedStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageHierarchicalInstancedStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageHierarchicalInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageHierarchicalInstancedStaticMeshComponent>(PtrDesc);
		}}}
