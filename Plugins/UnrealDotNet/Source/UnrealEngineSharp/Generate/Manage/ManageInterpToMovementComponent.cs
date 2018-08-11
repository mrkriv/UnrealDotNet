using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:60

namespace UnrealEngine
{
	public partial class ManageInterpToMovementComponent : UInterpToMovementComponent
	{
		public ManageInterpToMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		protected override void UpdateControlPoints(bool InForceUpdate) { }
		
		public static implicit operator IntPtr(ManageInterpToMovementComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageInterpToMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageInterpToMovementComponent>(PtrDesc);
		}}}
