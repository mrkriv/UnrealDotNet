using System;
using System.Runtime.InteropServices;

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
