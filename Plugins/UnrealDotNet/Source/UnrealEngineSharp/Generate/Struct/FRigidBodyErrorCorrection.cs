// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1190

namespace UnrealEngine
{
	public  partial class FRigidBodyErrorCorrection : NativeStructWrapper
	{
		internal FRigidBodyErrorCorrection(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRigidBodyErrorCorrection() :
			base(E_CreateStruct_FRigidBodyErrorCorrection(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRigidBodyErrorCorrection();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_AngleLerp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_AngleLerp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_AngularVelocityCoefficient_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_AngularVelocityCoefficient_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationDistanceSq_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationDistanceSq_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationSeconds_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationSeconds_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationSimilarity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationSimilarity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_ErrorPerAngularDifference_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_ErrorPerAngularDifference_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_ErrorPerLinearDifference_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_ErrorPerLinearDifference_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_LinearVelocityCoefficient_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_LinearVelocityCoefficient_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_MaxRestoredStateError_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_MaxRestoredStateError_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_PingExtrapolation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_PingExtrapolation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRigidBodyErrorCorrection_PositionLerp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRigidBodyErrorCorrection_PositionLerp_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>How much to directly lerp to the correct angle. </para>
		/// </summary>
		public float AngleLerp
		{
			get => E_PROP_FRigidBodyErrorCorrection_AngleLerp_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_AngleLerp_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>This is the angular analog to LinearVelocityCoefficient. </para>
		/// </summary>
		public float AngularVelocityCoefficient
		{
			get => E_PROP_FRigidBodyErrorCorrection_AngularVelocityCoefficient_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_AngularVelocityCoefficient_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If the body has moved less than the square root of </para>
		/// <para>this amount towards a resolved state in the previous </para>
		/// <para>frame, then error may accumulate towards a hard snap. </para>
		/// </summary>
		public float ErrorAccumulationDistanceSq
		{
			get => E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationDistanceSq_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationDistanceSq_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Number of seconds to remain in a heuristically </para>
		/// <para>unresolveable state before hard snapping. </para>
		/// </summary>
		public float ErrorAccumulationSeconds
		{
			get => E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationSeconds_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationSeconds_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If the previous error projected onto the current error </para>
		/// <para>is greater than this value (indicating "similarity" </para>
		/// <para>between states), then error may accumulate towards a </para>
		/// <para>hard snap. </para>
		/// </summary>
		public float ErrorAccumulationSimilarity
		{
			get => E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationSimilarity_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_ErrorAccumulationSimilarity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Error per degree </para>
		/// </summary>
		public float ErrorPerAngularDifference
		{
			get => E_PROP_FRigidBodyErrorCorrection_ErrorPerAngularDifference_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_ErrorPerAngularDifference_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Error per centimeter </para>
		/// </summary>
		public float ErrorPerLinearDifference
		{
			get => E_PROP_FRigidBodyErrorCorrection_ErrorPerLinearDifference_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_ErrorPerLinearDifference_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>This is the coefficient `k` in the differential equation: </para>
		/// <para>dx/dt = k ( x_target(t) - x(t) ), which is used to update </para>
		/// <para>the velocity in a replication step. </para>
		/// </summary>
		public float LinearVelocityCoefficient
		{
			get => E_PROP_FRigidBodyErrorCorrection_LinearVelocityCoefficient_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_LinearVelocityCoefficient_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Maximum allowable error for a state to be considered "resolved" </para>
		/// </summary>
		public float MaxRestoredStateError
		{
			get => E_PROP_FRigidBodyErrorCorrection_MaxRestoredStateError_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_MaxRestoredStateError_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Value between 0 and 1 which indicates how much velocity </para>
		/// <para>and ping based correction to use </para>
		/// </summary>
		public float PingExtrapolation
		{
			get => E_PROP_FRigidBodyErrorCorrection_PingExtrapolation_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_PingExtrapolation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>How much to directly lerp to the correct position. Generally </para>
		/// <para>this should be very low, if not zero. A higher value will </para>
		/// <para>increase precision along with jerkiness. </para>
		/// </summary>
		public float PositionLerp
		{
			get => E_PROP_FRigidBodyErrorCorrection_PositionLerp_GET(NativePointer);
			set => E_PROP_FRigidBodyErrorCorrection_PositionLerp_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRigidBodyErrorCorrection self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRigidBodyErrorCorrection(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRigidBodyErrorCorrection(Adress, false);
		}}}
