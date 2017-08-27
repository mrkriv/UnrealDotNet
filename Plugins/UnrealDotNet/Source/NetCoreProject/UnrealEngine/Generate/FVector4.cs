using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A 4D homogeneous vector, 4x1 FLOATs, 16-byte aligned.
	/// </summary>
	public partial struct FVector4
	{
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector4 E_OP_FVector4_p(FVector4 Self, FVector4 V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector4_Equals(FVector4 Self, FVector4 V, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector4_IsUnit3(FVector4 Self, float LengthSquaredTolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_FVector4_ToOrientationRotator(FVector4 Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FVector4_ToOrientationQuat(FVector4 Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector4_Set(FVector4 Self, float InX, float InY, float InZ, float InW);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector4_Size3(FVector4 Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector4_ContainsNaN(FVector4 Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector4_FindBestAxisVectors3(FVector4 Self, FVector4 Axis1, FVector4 Axis2);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector4_DiagnosticCheckNaN(FVector4 Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The vector's X-component.
		/// </summary>
		public float X { get; set; } 
		
		/// <summary>
		/// The vector's Y-component.
		/// </summary>
		public float Y { get; set; } 
		
		/// <summary>
		/// The vector's Z-component.
		/// </summary>
		public float Z { get; set; } 
		
		/// <summary>
		/// The vector's W-component.
		/// </summary>
		public float W { get; set; } 
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Gets the result of adding a vector to this.
		/// @param V The vector to add.
		/// @return The result of vector addition.
		/// </summary>
		public static FVector4 operator+(FVector4 Self, FVector4 V)
			=> E_OP_FVector4_p(Self, V);
		
		
		/// <summary>
		/// Error tolerant comparison.
		/// @param V Vector to compare against.
		/// @param Tolerance Error Tolerance.
		/// @return true if the two vectors are equal within specified tolerance, otherwise false.
		/// </summary>
		public bool Equals(FVector4 V, float Tolerance)
			=> E_FVector4_Equals(this, V, Tolerance);
		
		
		/// <summary>
		/// Check if the vector is of unit length, with specified tolerance.
		/// @param LengthSquaredTolerance Tolerance against squared length.
		/// @return true if the vector is a unit vector within the specified tolerance.
		/// </summary>
		public bool IsUnit3(float LengthSquaredTolerance)
			=> E_FVector4_IsUnit3(this, LengthSquaredTolerance);
		
		
		/// <summary>
		/// Return the FRotator orientation corresponding to the direction in which the vector points.
		/// Sets Yaw and Pitch to the proper numbers, and sets roll to zero because the roll can't be determined from a vector.
		/// @return FRotator from the Vector's direction.
		/// </summary>
		public FRotator ToOrientationRotator()
			=> E_FVector4_ToOrientationRotator(this);
		
		
		/// <summary>
		/// Return the Quaternion orientation corresponding to the direction in which the vector points.
		/// @return Quaternion from the Vector's direction.
		/// </summary>
		public FQuat ToOrientationQuat()
			=> E_FVector4_ToOrientationQuat(this);
		
		
		/// <summary>
		/// Set all of the vectors coordinates.
		/// @param InX New X Coordinate.
		/// @param InY New Y Coordinate.
		/// @param InZ New Z Coordinate.
		/// @param InW New W Coordinate.
		/// </summary>
		public void Set(float InX, float InY, float InZ, float InW)
			=> E_FVector4_Set(this, InX, InY, InZ, InW);
		
		
		/// <summary>
		/// Get the length of this vector not taking W component into account.
		/// @return The length of this vector.
		/// </summary>
		public float Size3()
			=> E_FVector4_Size3(this);
		
		
		/// <summary>
		/// Utility to check if there are any non-finite values (NaN or Inf) in this vector.
		/// </summary>
		public bool ContainsNaN()
			=> E_FVector4_ContainsNaN(this);
		
		
		/// <summary>
		/// Find good arbitrary axis vectors to represent U and V axes of a plane,
		/// given just the normal.
		/// </summary>
		public void FindBestAxisVectors3(FVector4 Axis1, FVector4 Axis2)
			=> E_FVector4_FindBestAxisVectors3(this, Axis1, Axis2);
		
		public void DiagnosticCheckNaN()
			=> E_FVector4_DiagnosticCheckNaN(this);
		
		#endregion
		
	}}
