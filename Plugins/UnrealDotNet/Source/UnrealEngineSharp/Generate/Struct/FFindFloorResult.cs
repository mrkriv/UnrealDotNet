using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:34

namespace UnrealEngine
{
	public  partial class FFindFloorResult : NativeStructWrapper
	{
		internal FFindFloorResult(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFindFloorResult() :
			base(E_CreateStruct_FFindFloorResult(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFindFloorResult();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFindFloorResult_FloorDist_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFindFloorResult_FloorDist_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FFindFloorResult_HitResult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFindFloorResult_HitResult_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FFindFloorResult_LineDist_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFindFloorResult_LineDist_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFindFloorResult_Clear(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FFindFloorResult_GetDistanceToFloor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FFindFloorResult_IsWalkableFloor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFindFloorResult_SetFromLineTrace(IntPtr Self, IntPtr InHit, float InSweepFloorDist, float InLineDist, bool bIsWalkableFloor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFindFloorResult_SetFromSweep(IntPtr Self, IntPtr InHit, float InSweepFloorDist, bool bIsWalkableFloor);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The distance to the floor, computed from the swept capsule trace. </para>
		/// </summary>
		public float FloorDist
		{
			get => E_PROP_FFindFloorResult_FloorDist_GET(NativePointer);
			set => E_PROP_FFindFloorResult_FloorDist_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Hit result of the test that found a floor. Includes more specific data about the point of impact and surface normal at that point. </para>
		/// </summary>
		public FHitResult HitResult
		{
			get => E_PROP_FFindFloorResult_HitResult_GET(NativePointer);
			set => E_PROP_FFindFloorResult_HitResult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The distance to the floor, computed from the trace. Only valid if bLineTrace is true. </para>
		/// </summary>
		public float LineDist
		{
			get => E_PROP_FFindFloorResult_LineDist_GET(NativePointer);
			set => E_PROP_FFindFloorResult_LineDist_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Clear()
			=> E_FFindFloorResult_Clear(this);
		
		
		/// <summary>
		/// <para>Gets the distance to floor, either LineDist or FloorDist. </para>
		/// </summary>
		public float GetDistanceToFloor()
			=> E_FFindFloorResult_GetDistanceToFloor(this);
		
		
		/// <summary>
		/// <para>Returns true if the floor result hit a walkable surface. </para>
		/// </summary>
		public bool IsWalkableFloor()
			=> E_FFindFloorResult_IsWalkableFloor(this);
		
		public void SetFromLineTrace(FHitResult InHit, float InSweepFloorDist, float InLineDist, bool bIsWalkableFloor)
			=> E_FFindFloorResult_SetFromLineTrace(this, InHit, InSweepFloorDist, InLineDist, bIsWalkableFloor);
		
		public void SetFromSweep(FHitResult InHit, float InSweepFloorDist, bool bIsWalkableFloor)
			=> E_FFindFloorResult_SetFromSweep(this, InHit, InSweepFloorDist, bIsWalkableFloor);
		
		#endregion
		
		public static implicit operator IntPtr(FFindFloorResult Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFindFloorResult(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFindFloorResult(Adress, false);
		}}}
