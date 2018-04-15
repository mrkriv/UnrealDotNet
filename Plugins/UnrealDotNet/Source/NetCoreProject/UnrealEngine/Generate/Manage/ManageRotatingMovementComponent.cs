using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

namespace UnrealEngine
{
	public partial class ManageRotatingMovementComponent : URotatingMovementComponent
	{
		public ManageRotatingMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageRotatingMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageRotatingMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageRotatingMovementComponent>(PtrDesc);
		}}}
