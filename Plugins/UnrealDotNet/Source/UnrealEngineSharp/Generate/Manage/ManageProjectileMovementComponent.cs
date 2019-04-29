// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

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
		/// Moves the UpdatedComponent, which is also the interpolation target for the interpolated component. If there is not interpolated component, this simply moves UpdatedComponent.
		/// <para>Use this typically from PostNetReceiveLocationAndRotation() or similar from an Actor. </para>
		/// </summary>
		public override void MoveInterpolationTarget(FVector newLocation, FRotator newRotation) { }
		
		
		/// <summary>
		/// Resets interpolation so that interpolated component snaps back to the initial location/rotation without any additional offsets.
		/// </summary>
		public override void ResetInterpolation() { }
		
		
		/// <summary>
		/// Assigns the component that will be used for network interpolation/smoothing. It is expected that this is a component attached somewhere below the UpdatedComponent.
		/// <para>When network updates use MoveInterpolationTarget() to move the UpdatedComponent, the interpolated component's relative offset will be maintained and smoothed over </para>
		/// the course of future component ticks. The current relative location and rotation of the component is saved as the target offset for future interpolation.
		/// <see cref="MoveInterpolationTarget"/>
		/// </summary>
		public override void SetInterpolatedComponent(USceneComponent component) { }
		
		
		/// <summary>
		/// Sets the velocity to the new value, rotated into Actor space.
		/// </summary>
		public override void SetVelocityInLocalSpace(FVector newVelocity) { }
		
		
		/// <summary>
		/// Clears the reference to UpdatedComponent, fires stop event (OnProjectileStop), and stops ticking (if bAutoUpdateTickRegistration is true).
		/// </summary>
		public override void StopSimulating(FHitResult hitResult) { }
		
		protected override void TickInterpolation(float deltaTime) { }
		
		public static implicit operator IntPtr(ManageProjectileMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageProjectileMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageProjectileMovementComponent>(PtrDesc);
		}}}
