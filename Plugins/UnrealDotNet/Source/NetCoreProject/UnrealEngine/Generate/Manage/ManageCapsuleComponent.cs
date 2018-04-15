using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\CapsuleComponent.h:16

namespace UnrealEngine
{
	public partial class ManageCapsuleComponent : UCapsuleComponent
	{
		public ManageCapsuleComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageCapsuleComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageCapsuleComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCapsuleComponent>(PtrDesc);
		}}}
