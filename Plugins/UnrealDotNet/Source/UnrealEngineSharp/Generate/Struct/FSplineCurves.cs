// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SplineComponent.h:41

namespace UnrealEngine
{
	public  partial class FSplineCurves : NativeStructWrapper
	{
		internal FSplineCurves(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSplineCurves() :
			base(E_CreateStruct_FSplineCurves(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplineCurves();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FSplineCurves_GetSegmentLength(IntPtr self, int index, float param, bool bClosedLoop, IntPtr scale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FSplineCurves_GetSplineLength(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSplineCurves_UpdateSpline(IntPtr self, bool bClosedLoop, bool bStationaryEndpoints, int reparamStepsPerSegment, bool bLoopPositionOverride, float loopPosition, IntPtr scale3D);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns the length of the specified spline segment up to the parametric value given </para>
		/// </summary>
		public float GetSegmentLength(int index, float param, bool bClosedLoop, FVector scale3D)
			=> E_FSplineCurves_GetSegmentLength(this, index, param, bClosedLoop, scale3D);
		
		
		/// <summary>
		/// <para>Returns total length along this spline </para>
		/// </summary>
		public float GetSplineLength()
			=> E_FSplineCurves_GetSplineLength(this);
		
		
		/// <summary>
		/// <para>Update the spline's internal data according to the passed-in params </para>
		/// <param name="bClosedLoop">Whether the spline is to be considered as a closed loop. </param>
		/// <param name="bStationaryEndpoints">Whether the endpoints of the spline are considered stationary when traversing the spline at non-constant velocity.  Essentially this sets the endpoints' tangents to zero vectors. </param>
		/// <param name="ReparamStepsPerSegment">Number of steps per spline segment to place in the reparameterization table </param>
		/// <param name="bLoopPositionOverride">Whether to override the loop position with LoopPosition </param>
		/// <param name="LoopPosition">The loop position to use instead of the last key </param>
		/// <param name="Scale3D">The world scale to override </param>
		/// </summary>
		public void UpdateSpline(bool bClosedLoop, bool bStationaryEndpoints, int reparamStepsPerSegment, bool bLoopPositionOverride, float loopPosition, FVector scale3D)
			=> E_FSplineCurves_UpdateSpline(this, bClosedLoop, bStationaryEndpoints, reparamStepsPerSegment, bLoopPositionOverride, loopPosition, scale3D);
		
		#endregion
		
		public static implicit operator IntPtr(FSplineCurves self)
		{
			return self.NativePointer;
		}

		public static implicit operator FSplineCurves(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSplineCurves(Adress, false);
		}}}
