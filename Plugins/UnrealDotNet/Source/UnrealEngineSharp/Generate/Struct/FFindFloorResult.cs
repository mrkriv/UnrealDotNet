// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CharacterMovementComponent.h:34

namespace UnrealEngine
{
	public partial class FFindFloorResult : NativeStructWrapper
	{
		public FFindFloorResult(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FFindFloorResult() :
			base(E_CreateStruct_FFindFloorResult(), false)
		{
		}

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
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFindFloorResult();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFindFloorResult_Clear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FFindFloorResult_GetDistanceToFloor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FFindFloorResult_IsWalkableFloor(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFindFloorResult_SetFromLineTrace(IntPtr self, IntPtr inHit, float inSweepFloorDist, float inLineDist, bool bIsWalkableFloor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFindFloorResult_SetFromSweep(IntPtr self, IntPtr inHit, float inSweepFloorDist, bool bIsWalkableFloor);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The distance to the floor, computed from the swept capsule trace.
		/// </summary>
		public float FloorDist
		{
			get => E_PROP_FFindFloorResult_FloorDist_GET(NativePointer);
			set => E_PROP_FFindFloorResult_FloorDist_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Hit result of the test that found a floor. Includes more specific data about the point of impact and surface normal at that point.
		/// </summary>
		public FHitResult HitResult
		{
			get => E_PROP_FFindFloorResult_HitResult_GET(NativePointer);
			set => E_PROP_FFindFloorResult_HitResult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The distance to the floor, computed from the trace. Only valid if bLineTrace is true.
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
		/// Gets the distance to floor, either LineDist or FloorDist.
		/// </summary>
		public float GetDistanceToFloor()
			=> E_FFindFloorResult_GetDistanceToFloor(this);
		
		
		/// <summary>
		/// Returns true if the floor result hit a walkable surface.
		/// </summary>
		public bool IsWalkableFloor()
			=> E_FFindFloorResult_IsWalkableFloor(this);
		
		public void SetFromLineTrace(FHitResult inHit, float inSweepFloorDist, float inLineDist, bool bIsWalkableFloor)
			=> E_FFindFloorResult_SetFromLineTrace(this, inHit, inSweepFloorDist, inLineDist, bIsWalkableFloor);
		
		public void SetFromSweep(FHitResult inHit, float inSweepFloorDist, bool bIsWalkableFloor)
			=> E_FFindFloorResult_SetFromSweep(this, inHit, inSweepFloorDist, bIsWalkableFloor);
		
		#endregion
		
		public static implicit operator IntPtr(FFindFloorResult self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFindFloorResult(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FFindFloorResult(adress, false);
		}}}
