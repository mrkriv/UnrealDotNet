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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInterpToMovementComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UInterpToMovementComponent_CalculateNewTime(IntPtr self, float timeNow, float delta, IntPtr hitResult, bool inBroadcastEvent, bool outStopped, float outTimeRemainder);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UInterpToMovementComponent_ComputeMoveDelta(IntPtr self, float time);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInterpToMovementComponent_HandleHitWall(IntPtr self, IntPtr hit, float timeTick, IntPtr moveDelta);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_ReverseDirection(IntPtr self, IntPtr hit, float time, bool inBroadcastEvent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInterpToMovementComponent_UpdateControlPoints(IntPtr self, bool inForceUpdate);
		
		#endregion
		
		#region ExternMethods
		protected float CalculateNewTime(float timeNow, float delta, FHitResult hitResult, bool inBroadcastEvent, bool outStopped, float outTimeRemainder)
			=> E_UInterpToMovementComponent_CalculateNewTime(this, timeNow, delta, hitResult, inBroadcastEvent, outStopped, outTimeRemainder);
		
		
		/// <summary>
		/// <para>Compute the distance for the given time. </para>
		/// </summary>
		protected virtual FVector ComputeMoveDelta(float time)
			=> E_UInterpToMovementComponent_ComputeMoveDelta(this, time);
		
		
		/// <summary>
		/// <return>true if the simulation should stop. </return>
		/// </summary>
		protected bool HandleHitWall(FHitResult hit, float timeTick, FVector moveDelta)
			=> E_UInterpToMovementComponent_HandleHitWall(this, hit, timeTick, moveDelta);
		
		protected void ReverseDirection(FHitResult hit, float time, bool inBroadcastEvent)
			=> E_UInterpToMovementComponent_ReverseDirection(this, hit, time, inBroadcastEvent);
		
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
