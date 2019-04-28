// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:61

namespace UnrealEngine
{
	public  partial class UInterpToMovementComponent : UMovementComponent
	{
		public UInterpToMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UInterpToMovementComponent(UObject Parent = null, string Name = "InterpToMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UInterpToMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UInterpToMovementComponent_BehaviourType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInterpToMovementComponent_BehaviourType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UInterpToMovementComponent_Duration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInterpToMovementComponent_Duration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UInterpToMovementComponent_MaxSimulationIterations_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInterpToMovementComponent_MaxSimulationIterations_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UInterpToMovementComponent_MaxSimulationTimeStep_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInterpToMovementComponent_MaxSimulationTimeStep_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInterpToMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_AddControlPointPosition(IntPtr self, IntPtr pos, bool bPositionIsRelative);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UInterpToMovementComponent_CalculateNewTime(IntPtr self, float timeNow, float delta, IntPtr hitResult, bool inBroadcastEvent, bool outStopped, float outTimeRemainder);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInterpToMovementComponent_CheckStillInWorld(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UInterpToMovementComponent_ComputeMoveDelta(IntPtr self, float time);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_FinaliseControlPoints(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UInterpToMovementComponent_GetSimulationTimeStep(IntPtr self, float remainingTime, int iterations);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInterpToMovementComponent_HandleHitWall(IntPtr self, IntPtr hit, float timeTick, IntPtr moveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInterpToMovementComponent_HasStoppedSimulation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_ResetControlPoints(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_RestartMovement(IntPtr self, float initialDirection);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_ReverseDirection(IntPtr self, IntPtr hit, float time, bool inBroadcastEvent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInterpToMovementComponent_ShouldUseSubStepping(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_StopSimulating(IntPtr self, IntPtr hitResult);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_UpdateControlPoints(IntPtr self, bool inForceUpdate);
		
		#endregion
		
		#region Property
		public EInterpToBehaviourType BehaviourType
		{
			get => (EInterpToBehaviourType)E_PROP_UInterpToMovementComponent_BehaviourType_GET(NativePointer);
			set => E_PROP_UInterpToMovementComponent_BehaviourType_SET(NativePointer, (byte)value);
		}

		public float Duration
		{
			get => E_PROP_UInterpToMovementComponent_Duration_GET(NativePointer);
			set => E_PROP_UInterpToMovementComponent_Duration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max number of iterations used for each discrete simulation step.
		/// <para>Increasing this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance. </para>
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// <see cref="MaxSimulationTimeStep"/>
		/// </summary>
		public int MaxSimulationIterations
		{
			get => E_PROP_UInterpToMovementComponent_MaxSimulationIterations_GET(NativePointer);
			set => E_PROP_UInterpToMovementComponent_MaxSimulationIterations_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Max time delta for each discrete simulation step.
		/// <para>Lowering this value can address issues with fast-moving objects or complex collision scenarios, at the cost of performance. </para>
		/// WARNING: if (MaxSimulationTimeStep * MaxSimulationIterations) is too low for the min framerate, the last simulation step may exceed MaxSimulationTimeStep to complete the simulation.
		/// <see cref="MaxSimulationIterations"/>
		/// </summary>
		public float MaxSimulationTimeStep
		{
			get => E_PROP_UInterpToMovementComponent_MaxSimulationTimeStep_GET(NativePointer);
			set => E_PROP_UInterpToMovementComponent_MaxSimulationTimeStep_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public virtual void AddControlPointPosition(FVector pos, bool bPositionIsRelative)
			=> E_UInterpToMovementComponent_AddControlPointPosition(this, pos, bPositionIsRelative);
		
		protected float CalculateNewTime(float timeNow, float delta, FHitResult hitResult, bool inBroadcastEvent, bool outStopped, float outTimeRemainder)
			=> E_UInterpToMovementComponent_CalculateNewTime(this, timeNow, delta, hitResult, inBroadcastEvent, outStopped, outTimeRemainder);
		
		
		/// <summary>
		/// This will check to see if the InterpTo is still in the world.  It will check things like
		/// <para>the KillZ, outside world bounds, etc. and handle the situation. </para>
		/// </summary>
		public virtual bool CheckStillInWorld()
			=> E_UInterpToMovementComponent_CheckStillInWorld(this);
		
		
		/// <summary>
		/// Compute the distance for the given time.
		/// </summary>
		protected virtual FVector ComputeMoveDelta(float time)
			=> E_UInterpToMovementComponent_ComputeMoveDelta(this, time);
		
		public void FinaliseControlPoints()
			=> E_UInterpToMovementComponent_FinaliseControlPoints(this);
		
		
		/// <summary>
		/// Compute remaining time step given remaining time and current iterations.
		/// <para>The last iteration (limited by MaxSimulationIterations) always returns the remaining time, which may violate MaxSimulationTimeStep. </para>
		/// <see cref="MaxSimulationTimeStep"/>
		/// <see cref="ShouldUseSubStepping"/>
		/// </summary>
		/// <param name="remainingTime">Remaining time in the tick.</param>
		/// <param name="iterations">Current iteration of the tick (starting at 1).</param>
		/// <return>The</return>
		public float GetSimulationTimeStep(float remainingTime, int iterations)
			=> E_UInterpToMovementComponent_GetSimulationTimeStep(this, remainingTime, iterations);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		protected bool HandleHitWall(FHitResult hit, float timeTick, FVector moveDelta)
			=> E_UInterpToMovementComponent_HandleHitWall(this, hit, timeTick, moveDelta);
		
		public bool HasStoppedSimulation()
			=> E_UInterpToMovementComponent_HasStoppedSimulation(this);
		
		public void ResetControlPoints()
			=> E_UInterpToMovementComponent_ResetControlPoints(this);
		
		public void RestartMovement(float initialDirection)
			=> E_UInterpToMovementComponent_RestartMovement(this, initialDirection);
		
		protected void ReverseDirection(FHitResult hit, float time, bool inBroadcastEvent)
			=> E_UInterpToMovementComponent_ReverseDirection(this, hit, time, inBroadcastEvent);
		
		
		/// <summary>
		/// Determine whether or not to use substepping in the InterpTo motion update.
		/// <para>If true, GetSimulationTimeStep() will be used to time-slice the update. If false, all remaining time will be used during the tick. </para>
		/// <see cref="GetSimulationTimeStep"/>
		/// </summary>
		/// <return>Whether</return>
		public virtual bool ShouldUseSubStepping()
			=> E_UInterpToMovementComponent_ShouldUseSubStepping(this);
		
		
		/// <summary>
		/// Clears the reference to UpdatedComponent, fires stop event, and stops ticking.
		/// </summary>
		public void StopSimulating(FHitResult hitResult)
			=> E_UInterpToMovementComponent_StopSimulating(this, hitResult);
		
		protected virtual void UpdateControlPoints(bool inForceUpdate)
			=> E_UInterpToMovementComponent_UpdateControlPoints(this, inForceUpdate);
		
		#endregion
		
		public static implicit operator IntPtr(UInterpToMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UInterpToMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UInterpToMovementComponent>(PtrDesc);
		}}}
