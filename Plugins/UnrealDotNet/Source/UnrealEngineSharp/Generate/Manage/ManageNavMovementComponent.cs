// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\NavMovementComponent.h:25

namespace UnrealEngine
{
	[ManageType("ManageNavMovementComponent")]
	public partial class ManageNavMovementComponent : UNavMovementComponent
	{
		public ManageNavMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>path following: request new velocity </para>
		/// </summary>
		public override void RequestDirectMove(FVector moveVelocity, bool bForceMaxSpeed) { }
		
		
		/// <summary>
		/// <para>path following: request new move input (normal vector = full strength) </para>
		/// </summary>
		public override void RequestPathMove(FVector moveInput) { }
		
		
		/// <summary>
		/// <para>Stops applying further movement (usually zeros acceleration). </para>
		/// </summary>
		public override void StopActiveMovement() { }
		
		public static implicit operator IntPtr(ManageNavMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageNavMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageNavMovementComponent>(PtrDesc);
		}}}
