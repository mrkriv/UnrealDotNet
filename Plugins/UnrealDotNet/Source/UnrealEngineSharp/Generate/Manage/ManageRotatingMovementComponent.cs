using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

namespace UnrealEngine
{
	[ManageType("ManageRotatingMovementComponent")]
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
