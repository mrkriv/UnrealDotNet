using System;
using System.Runtime.InteropServices;

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
