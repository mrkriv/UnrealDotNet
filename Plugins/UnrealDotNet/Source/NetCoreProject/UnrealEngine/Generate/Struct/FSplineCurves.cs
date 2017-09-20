using System;
using System.Runtime.InteropServices;

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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplineCurves();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FSplineCurves_GetSegmentLength(IntPtr Self, int Index, float Param, bool bClosedLoop, IntPtr Scale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FSplineCurves_GetSplineLength(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSplineCurves_UpdateSpline(IntPtr Self, bool bClosedLoop, bool bStationaryEndpoints, int ReparamStepsPerSegment, bool bLoopPositionOverride, float LoopPosition, IntPtr Scale3D);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns the length of the specified spline segment up to the parametric value given </para>
		/// </summary>
		public float GetSegmentLength(int Index, float Param, bool bClosedLoop, FVector Scale3D)
			=> E_FSplineCurves_GetSegmentLength(this, Index, Param, bClosedLoop, Scale3D);
		
		
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
		public void UpdateSpline(bool bClosedLoop, bool bStationaryEndpoints, int ReparamStepsPerSegment, bool bLoopPositionOverride, float LoopPosition, FVector Scale3D)
			=> E_FSplineCurves_UpdateSpline(this, bClosedLoop, bStationaryEndpoints, ReparamStepsPerSegment, bLoopPositionOverride, LoopPosition, Scale3D);
		
		#endregion
		
		public static implicit operator IntPtr(FSplineCurves Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSplineCurves(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSplineCurves(Adress, false);
		}
}
}
