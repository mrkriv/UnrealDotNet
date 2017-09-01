using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A spline component is a spline shape which can be used for other purposes (e.g. animating objects). It contains debug rendering capabilities.
	/// @see https://docs.unrealengine.com/latest/INT/Resources/ContentExamples/Blueprint_Splines
	/// </summary>
	public partial class USplineComponent : UPrimitiveComponent
	{
		public USplineComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_USplineComponent_DefaultUpVector_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USplineComponent_DefaultUpVector_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineComponent_UpdateSpline(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USplineComponent_GetScaleAtSplineInputKey(IntPtr Self, float InKey);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_USplineComponent_GetNumSplinePoints(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineComponent_SetDrawDebug(IntPtr Self, bool bShow);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineComponent_SetClosedLoop(IntPtr Self, bool bInClosedLoop, bool bUpdateSpline);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineComponent_SetClosedLoopAtPosition(IntPtr Self, bool bInClosedLoop, float Key, bool bUpdateSpline);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_USplineComponent_IsClosedLoop(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineComponent_AddPoint(IntPtr Self, IntPtr Point, bool bUpdateSpline);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineComponent_RemoveSplinePoint(IntPtr Self, int Index, bool bUpdateSpline);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineComponent_AddSplineWorldPoint(IntPtr Self, IntPtr Position);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineComponent_SetWorldLocationAtSplinePoint(IntPtr Self, int PointIndex, IntPtr InLocation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USplineComponent_GetWorldLocationAtSplinePoint(IntPtr Self, int PointIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineComponent_GetLocalLocationAndTangentAtSplinePoint(IntPtr Self, int PointIndex, IntPtr LocalLocation, IntPtr LocalTangent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USplineComponent_GetDistanceAlongSplineAtSplinePoint(IntPtr Self, int PointIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USplineComponent_GetSplineLength(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USplineComponent_GetInputKeyAtDistanceAlongSpline(IntPtr Self, float Distance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USplineComponent_GetWorldRotationAtDistanceAlongSpline(IntPtr Self, float Distance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USplineComponent_GetWorldLocationAtTime(IntPtr Self, float Time, bool bUseConstantVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USplineComponent_GetWorldRotationAtTime(IntPtr Self, float Time, bool bUseConstantVelocity);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USplineComponent_FindInputKeyClosestToWorldLocation(IntPtr Self, IntPtr WorldLocation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USplineComponent_FindScaleClosestToWorldLocation(IntPtr Self, IntPtr WorldLocation);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Default up vector in local space to be used when calculating transforms along the spline
		/// </summary>
		public FVector DefaultUpVector
		{
			get => E_PROP_USplineComponent_DefaultUpVector_GET(NativePointer);
			set => E_PROP_USplineComponent_DefaultUpVector_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Update the spline tangents and SplineReparamTable
		/// </summary>
		public void UpdateSpline()
			=> E_USplineComponent_UpdateSpline(NativePointer);
		
		
		/// <summary>
		/// Get scale at the provided input key value
		/// </summary>
		public FVector GetScaleAtSplineInputKey(float InKey)
			=> E_USplineComponent_GetScaleAtSplineInputKey(NativePointer, InKey);
		
		public int GetNumSplinePoints()
			=> E_USplineComponent_GetNumSplinePoints(NativePointer);
		
		
		/// <summary>
		/// Specify whether this spline should be rendered when the Editor/Game spline show flag is set
		/// </summary>
		public void SetDrawDebug(bool bShow)
			=> E_USplineComponent_SetDrawDebug(NativePointer, bShow);
		
		
		/// <summary>
		/// Specify whether the spline is a closed loop or not. The loop position will be at 1.0 after the last point's input key
		/// </summary>
		public void SetClosedLoop(bool bInClosedLoop, bool bUpdateSpline = true)
			=> E_USplineComponent_SetClosedLoop(NativePointer, bInClosedLoop, bUpdateSpline);
		
		
		/// <summary>
		/// Specify whether the spline is a closed loop or not, and if so, the input key corresponding to the loop point
		/// </summary>
		public void SetClosedLoopAtPosition(bool bInClosedLoop, float Key, bool bUpdateSpline = true)
			=> E_USplineComponent_SetClosedLoopAtPosition(NativePointer, bInClosedLoop, Key, bUpdateSpline);
		
		
		/// <summary>
		/// Check whether the spline is a closed loop or not
		/// </summary>
		public bool IsClosedLoop()
			=> E_USplineComponent_IsClosedLoop(NativePointer);
		
		
		/// <summary>
		/// Adds an FSplinePoint to the spline. This contains its input key, position, tangent, rotation and scale.
		/// </summary>
		public void AddPoint(FSplinePoint Point, bool bUpdateSpline = true)
			=> E_USplineComponent_AddPoint(NativePointer, Point, bUpdateSpline);
		
		
		/// <summary>
		/// Removes point at specified index from the spline
		/// </summary>
		public void RemoveSplinePoint(int Index, bool bUpdateSpline = true)
			=> E_USplineComponent_RemoveSplinePoint(NativePointer, Index, bUpdateSpline);
		
		
		/// <summary>
		/// Adds a world space point to the spline
		/// </summary>
		public void AddSplineWorldPoint(FVector Position)
			=> E_USplineComponent_AddSplineWorldPoint(NativePointer, Position);
		
		
		/// <summary>
		/// Move an existing point to a new world location
		/// </summary>
		public void SetWorldLocationAtSplinePoint(int PointIndex, FVector InLocation)
			=> E_USplineComponent_SetWorldLocationAtSplinePoint(NativePointer, PointIndex, InLocation);
		
		
		/// <summary>
		/// Get the world location at spline point
		/// </summary>
		public FVector GetWorldLocationAtSplinePoint(int PointIndex)
			=> E_USplineComponent_GetWorldLocationAtSplinePoint(NativePointer, PointIndex);
		
		
		/// <summary>
		/// Get local location and tangent at a spline point
		/// </summary>
		public void GetLocalLocationAndTangentAtSplinePoint(int PointIndex, FVector LocalLocation, FVector LocalTangent)
			=> E_USplineComponent_GetLocalLocationAndTangentAtSplinePoint(NativePointer, PointIndex, LocalLocation, LocalTangent);
		
		
		/// <summary>
		/// Get the distance along the spline at the spline point
		/// </summary>
		public float GetDistanceAlongSplineAtSplinePoint(int PointIndex)
			=> E_USplineComponent_GetDistanceAlongSplineAtSplinePoint(NativePointer, PointIndex);
		
		
		/// <summary>
		/// Returns total length along this spline
		/// </summary>
		public float GetSplineLength()
			=> E_USplineComponent_GetSplineLength(NativePointer);
		
		
		/// <summary>
		/// Given a distance along the length of this spline, return the corresponding input key at that point
		/// </summary>
		public float GetInputKeyAtDistanceAlongSpline(float Distance)
			=> E_USplineComponent_GetInputKeyAtDistanceAlongSpline(NativePointer, Distance);
		
		
		/// <summary>
		/// Given a distance along the length of this spline, return a rotation corresponding to the spline's rotation there, in world space.
		/// </summary>
		public FRotator GetWorldRotationAtDistanceAlongSpline(float Distance)
			=> E_USplineComponent_GetWorldRotationAtDistanceAlongSpline(NativePointer, Distance);
		
		
		/// <summary>
		/// Given a time from 0 to the spline duration, return the point in space where this puts you
		/// </summary>
		public FVector GetWorldLocationAtTime(float Time, bool bUseConstantVelocity = false)
			=> E_USplineComponent_GetWorldLocationAtTime(NativePointer, Time, bUseConstantVelocity);
		
		
		/// <summary>
		/// Given a time from 0 to the spline duration, return a rotation corresponding to the spline's position and direction there.
		/// </summary>
		public FRotator GetWorldRotationAtTime(float Time, bool bUseConstantVelocity = false)
			=> E_USplineComponent_GetWorldRotationAtTime(NativePointer, Time, bUseConstantVelocity);
		
		
		/// <summary>
		/// Given a location, in world space, return the input key closest to that location.
		/// </summary>
		public float FindInputKeyClosestToWorldLocation(FVector WorldLocation)
			=> E_USplineComponent_FindInputKeyClosestToWorldLocation(NativePointer, WorldLocation);
		
		
		/// <summary>
		/// Given a location, in world space, return the spline's scale closest to the location.
		/// </summary>
		public FVector FindScaleClosestToWorldLocation(FVector WorldLocation)
			=> E_USplineComponent_FindScaleClosestToWorldLocation(NativePointer, WorldLocation);
		
		#endregion
		
		public static implicit operator IntPtr(USplineComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USplineComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new USplineComponent(Adress);
		}}}
