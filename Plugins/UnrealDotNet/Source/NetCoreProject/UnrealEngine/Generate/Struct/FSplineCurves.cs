using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Types of coordinate space accepted by the functions.
	/// </summary>
	public partial class FSplineCurves
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FSplineCurves()
		{
			NativePointer = E_CreateStruct_FSplineCurves();
			IsRef = false;
		}

		internal FSplineCurves(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FSplineCurves();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FSplineCurves_UpdateSpline(FSplineCurves Self, bool bClosedLoop, bool bStationaryEndpoints, int ReparamStepsPerSegment, bool bLoopPositionOverride, float LoopPosition, IntPtr Scale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FSplineCurves_GetSegmentLength(FSplineCurves Self, int Index, float Param, bool bClosedLoop, IntPtr Scale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FSplineCurves_GetSplineLength(FSplineCurves Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Update the spline's internal data according to the passed-in params
		/// @param	bClosedLoop				Whether the spline is to be considered as a closed loop.
		/// @param	bStationaryEndpoints	Whether the endpoints of the spline are considered stationary when traversing the spline at non-constant velocity.  Essentially this sets the endpoints' tangents to zero vectors.
		/// @param	ReparamStepsPerSegment	Number of steps per spline segment to place in the reparameterization table
		/// @param	bLoopPositionOverride	Whether to override the loop position with LoopPosition
		/// @param	LoopPosition			The loop position to use instead of the last key
		/// @param	Scale3D					The world scale to override
		/// </summary>
		public void UpdateSpline(bool bClosedLoop, bool bStationaryEndpoints, int ReparamStepsPerSegment, bool bLoopPositionOverride, float LoopPosition, FVector Scale3D)
			=> E_FSplineCurves_UpdateSpline(this, bClosedLoop, bStationaryEndpoints, ReparamStepsPerSegment, bLoopPositionOverride, LoopPosition, Scale3D);
		
		
		/// <summary>
		/// Returns the length of the specified spline segment up to the parametric value given
		/// </summary>
		public float GetSegmentLength(int Index, float Param, bool bClosedLoop, FVector Scale3D)
			=> E_FSplineCurves_GetSegmentLength(this, Index, Param, bClosedLoop, Scale3D);
		
		
		/// <summary>
		/// Returns total length along this spline
		/// </summary>
		public float GetSplineLength()
			=> E_FSplineCurves_GetSplineLength(this);
		
		#endregion
		
		public static implicit operator IntPtr(FSplineCurves Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSplineCurves(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSplineCurves(Adress, false);
		}}}
