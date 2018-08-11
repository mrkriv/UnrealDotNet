using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

namespace UnrealEngine
{
	public partial class ManageProjectileMovementComponent : UProjectileMovementComponent
	{
		public ManageProjectileMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageProjectileMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageProjectileMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageProjectileMovementComponent>(PtrDesc);
		}}}
