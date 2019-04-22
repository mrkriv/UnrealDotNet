// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

namespace UnrealEngine
{
	[ManageType("ManageProjectileMovementComponent")]
	public partial class ManageProjectileMovementComponent : UProjectileMovementComponent
	{
		public ManageProjectileMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Moves the UpdatedComponent, which is also the interpolation target for the interpolated component. If there is not interpolated component, this simply moves UpdatedComponent. </para>
		/// <para>Use this typically from PostNetReceiveLocationAndRotation() or similar from an Actor. </para>
		/// </summary>
		public override void MoveInterpolationTarget(FVector newLocation, FRotator newRotation) { }
		
		
		/// <summary>
		/// <para>Resets interpolation so that interpolated component snaps back to the initial location/rotation without any additional offsets. </para>
		/// </summary>
		public override void ResetInterpolation() { }
		
		
		/// <summary>
		/// <para>Assigns the component that will be used for network interpolation/smoothing. It is expected that this is a component attached somewhere below the UpdatedComponent. </para>
		/// <para>When network updates use MoveInterpolationTarget() to move the UpdatedComponent, the interpolated component's relative offset will be maintained and smoothed over </para>
		/// <para>the course of future component ticks. The current relative location and rotation of the component is saved as the target offset for future interpolation. </para>
		/// <para>@see MoveInterpolationTarget(), bInterpMovement, bInterpRotation </para>
		/// </summary>
		public override void SetInterpolatedComponent(USceneComponent component) { }
		
		
		/// <summary>
		/// <para>Sets the velocity to the new value, rotated into Actor space. </para>
		/// </summary>
		public override void SetVelocityInLocalSpace(FVector newVelocity) { }
		
		
		/// <summary>
		/// <para>Clears the reference to UpdatedComponent, fires stop event (OnProjectileStop), and stops ticking (if bAutoUpdateTickRegistration is true). </para>
		/// </summary>
		public override void StopSimulating(FHitResult hitResult) { }
		
		protected override void TickInterpolation(float deltaTime) { }
		
		public static implicit operator IntPtr(ManageProjectileMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageProjectileMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageProjectileMovementComponent>(PtrDesc);
		}}}
