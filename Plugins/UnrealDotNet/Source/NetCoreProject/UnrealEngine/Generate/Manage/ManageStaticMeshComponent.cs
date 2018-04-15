using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\StaticMeshComponent.h:154

namespace UnrealEngine
{
	public partial class ManageStaticMeshComponent : UStaticMeshComponent
	{
		public ManageStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageStaticMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageStaticMeshComponent>(PtrDesc);
		}}}
