// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\FloatingPawnMovement.h:22

namespace UnrealEngine
{
	public partial class UFloatingPawnMovement : UPawnMovementComponent
	{
		public UFloatingPawnMovement(IntPtr adress)
			: base(adress)
		{
		}

		public UFloatingPawnMovement(UObject Parent = null, string Name = "FloatingPawnMovement")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UFloatingPawnMovement(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UFloatingPawnMovement_Acceleration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UFloatingPawnMovement_Acceleration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UFloatingPawnMovement_Deceleration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UFloatingPawnMovement_Deceleration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UFloatingPawnMovement_MaxSpeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UFloatingPawnMovement_MaxSpeed_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UFloatingPawnMovement_TurningBoost_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UFloatingPawnMovement_TurningBoost_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UFloatingPawnMovement(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UFloatingPawnMovement_ApplyControlInputToVelocity(IntPtr self, float deltaTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UFloatingPawnMovement_LimitWorldBounds(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Acceleration applied by input (rate of change of velocity)
		/// </summary>
		public float Acceleration
		{
			get => E_PROP_UFloatingPawnMovement_Acceleration_GET(NativePointer);
			set => E_PROP_UFloatingPawnMovement_Acceleration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Deceleration applied when there is no input (rate of change of velocity)
		/// </summary>
		public float Deceleration
		{
			get => E_PROP_UFloatingPawnMovement_Deceleration_GET(NativePointer);
			set => E_PROP_UFloatingPawnMovement_Deceleration_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum velocity magnitude allowed for the controlled Pawn.
		/// </summary>
		public float MaxSpeed
		{
			get => E_PROP_UFloatingPawnMovement_MaxSpeed_GET(NativePointer);
			set => E_PROP_UFloatingPawnMovement_MaxSpeed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Setting affecting extra force applied when changing direction, making turns have less drift and become more responsive.
		/// <para>Velocity magnitude is not allowed to increase, that only happens due to normal acceleration. It may decrease with large direction changes. </para>
		/// Larger values apply extra force to reach the target direction more quickly, while a zero value disables any extra turn force.
		/// </summary>
		public float TurningBoost
		{
			get => E_PROP_UFloatingPawnMovement_TurningBoost_GET(NativePointer);
			set => E_PROP_UFloatingPawnMovement_TurningBoost_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Update Velocity based on input. Also applies gravity.
		/// </summary>
		protected virtual void ApplyControlInputToVelocity(float deltaTime)
			=> E_UFloatingPawnMovement_ApplyControlInputToVelocity(this, deltaTime);
		
		
		/// <summary>
		/// Prevent Pawn from leaving the world bounds (if that restriction is enabled in WorldSettings)
		/// </summary>
		protected virtual bool LimitWorldBounds()
			=> E_UFloatingPawnMovement_LimitWorldBounds(this);
		
		#endregion
		
		public static implicit operator IntPtr(UFloatingPawnMovement self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UFloatingPawnMovement(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UFloatingPawnMovement>(PtrDesc);
		}}}
