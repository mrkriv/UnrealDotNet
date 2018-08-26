// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\ProjectileMovementComponent.h:22

namespace UnrealEngine
{
	public  partial class UProjectileMovementComponent : UMovementComponent
	{
		public UProjectileMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UProjectileMovementComponent(UObject Parent = null, string Name = "ProjectileMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UProjectileMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UProjectileMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeAcceleration(IntPtr self, IntPtr inVelocity, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeBounceResult(IntPtr self, IntPtr hit, float timeSlice, IntPtr moveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeHomingAcceleration(IntPtr self, IntPtr inVelocity, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_ComputeMoveDelta(IntPtr self, IntPtr inVelocity, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UProjectileMovementComponent_HandleBlockingHit(IntPtr self, IntPtr hit, float timeTick, IntPtr moveDelta, float subTickTimeRemaining);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UProjectileMovementComponent_HandleSliding(IntPtr self, IntPtr hit, float subTickTimeRemaining);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UProjectileMovementComponent_LimitVelocity(IntPtr self, IntPtr newVelocity);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Compute the acceleration that will be applied </para>
		/// </summary>
		protected virtual FVector ComputeAcceleration(FVector inVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeAcceleration(this, inVelocity, deltaTime);
		
		
		/// <summary>
		/// <para>Computes result of a bounce and returns the new velocity. </para>
		/// </summary>
		protected virtual FVector ComputeBounceResult(FHitResult hit, float timeSlice, FVector moveDelta)
			=> E_UProjectileMovementComponent_ComputeBounceResult(this, hit, timeSlice, moveDelta);
		
		
		/// <summary>
		/// <para>Allow the projectile to track towards its homing target. </para>
		/// </summary>
		protected virtual FVector ComputeHomingAcceleration(FVector inVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeHomingAcceleration(this, inVelocity, deltaTime);
		
		
		/// <summary>
		/// <para>Compute the distance we should move in the given time, at a given a velocity. </para>
		/// </summary>
		protected virtual FVector ComputeMoveDelta(FVector inVelocity, float deltaTime)
			=> E_UProjectileMovementComponent_ComputeMoveDelta(this, inVelocity, deltaTime);
		
		
		/// <summary>
		/// <para>Handle blocking hit during simulation update. Checks that simulation remains valid after collision. </para>
		/// <para>If simulating then calls HandleImpact(), and returns EHandleHitWallResult::Deflect by default to enable multi-bounce and sliding support through HandleDeflection(). </para>
		/// <para>If no longer simulating then returns EHandleHitWallResult::Abort, which aborts attempts at further simulation. </para>
		/// <param name="Hit">Blocking hit that occurred. </param>
		/// <param name="TimeTick">Time delta of last move that resulted in the blocking hit. </param>
		/// <param name="MoveDelta">Movement delta for the current sub-step. </param>
		/// <param name="SubTickTimeRemaining">How much time to continue simulating in the current sub-step, which may change as a result of this function. </param>
		/// <para>Initial default value is: TimeTick * (1.f - Hit.Time) </para>
		/// <return>Result indicating how simulation should proceed. </return>
		/// <para>@see EHandleHitWallResult, HandleImpact() </para>
		/// </summary>
		protected virtual EHandleBlockingHitResult HandleBlockingHit(FHitResult hit, float timeTick, FVector moveDelta, float subTickTimeRemaining)
			=> (EHandleBlockingHitResult)E_UProjectileMovementComponent_HandleBlockingHit(this, hit, timeTick, moveDelta, subTickTimeRemaining);
		
		
		/// <summary>
		/// <para>Handle case where projectile is sliding along a surface. </para>
		/// <para>Velocity will be parallel to the impact surface upon entry to this method. </para>
		/// <param name="InitialHit">Hit result of impact causing slide. May be modified by this function to reflect any subsequent movement. </param>
		/// <param name="SubTickTimeRemaining">Time remaining in the tick. This function may update this time with any reduction to the simulation time requested. </param>
		/// <return>True if simulation of the projectile should continue, false otherwise. </return>
		/// </summary>
		protected virtual bool HandleSliding(FHitResult hit, float subTickTimeRemaining)
			=> E_UProjectileMovementComponent_HandleSliding(this, hit, subTickTimeRemaining);
		
		
		/// <summary>
		/// <para>Don't allow velocity magnitude to exceed MaxSpeed, if MaxSpeed is non-zero. </para>
		/// </summary>
		protected FVector LimitVelocity(FVector newVelocity)
			=> E_UProjectileMovementComponent_LimitVelocity(this, newVelocity);
		
		#endregion
		
		public static implicit operator IntPtr(UProjectileMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UProjectileMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UProjectileMovementComponent>(PtrDesc);
		}}}
