// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:60

namespace UnrealEngine
{
	[ManageType("ManageInterpToMovementComponent")]
	public partial class ManageInterpToMovementComponent : UInterpToMovementComponent
	{
		public ManageInterpToMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		protected override void UpdateControlPoints(bool inForceUpdate) { }
		
		public static implicit operator IntPtr(ManageInterpToMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageInterpToMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageInterpToMovementComponent>(PtrDesc);
		}}}
