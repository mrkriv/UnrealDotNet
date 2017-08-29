using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A vector in 3-D space composed of components (X, Y, Z) with floating point precision.
	/// </summary>
	public partial class FVector
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FVector()
		{
			NativePointer = E_CreateStruct_FVector();
			IsRef = false;
		}

		internal FVector(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_CreateStruct_FVector();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_FVector_X_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FVector_X_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_FVector_Y_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FVector_Y_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PROP_FVector_Z_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_PROP_FVector_Z_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_OPER_FVector_u(FVector Self, IntPtr V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FVector_CrossProduct(FVector Self, IntPtr A, IntPtr B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_OPER_FVector_i(FVector Self, IntPtr V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector_DotProduct(FVector Self, IntPtr A, IntPtr B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_Equals(FVector Self, IntPtr V, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_AllComponentsEqual(FVector Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector_Set(FVector Self, float InX, float InY, float InZ);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector_GetMax(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_IsZero(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_Normalize(FVector Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector_ToDirectionAndLength(FVector Self, IntPtr OutDir, float OutLength);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FVector_GridSnap(FVector Self, float GridSz);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FVector_GetClampedToSize(FVector Self, float Min, float Max);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector_AddBounded(FVector Self, IntPtr V, float Radius);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FVector_RotateAngleAxis(FVector Self, float AngleDeg, IntPtr Axis);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector_CosineAngle2D(FVector Self, IntPtr B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FVector_ToOrientationRotator(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FVector_ToOrientationQuat(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector_FindBestAxisVectors(FVector Self, IntPtr Axis1, IntPtr Axis2);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector_UnwindEuler(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FVector_UnitCartesianToSpherical(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector_CreateOrthonormalBasis(FVector Self, IntPtr XAxis, IntPtr YAxis, IntPtr ZAxis);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_PointsAreSame(FVector Self, IntPtr P, IntPtr Q);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_PointsAreNear(FVector Self, IntPtr Point1, IntPtr Point2, float Dist);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector_PointPlaneDist(FVector Self, IntPtr Point, IntPtr PlaneBase, IntPtr PlaneNormal);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_Coplanar(FVector Self, IntPtr Base1, IntPtr Normal1, IntPtr Base2, IntPtr Normal2, float ParallelCosineThreshold);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Vector's X component.
		/// </summary>
		public float X
		{
			get => E_PROP_FVector_X_GET(NativePointer);
			set => E_PROP_FVector_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Vector's Y component.
		/// </summary>
		public float Y
		{
			get => E_PROP_FVector_Y_GET(NativePointer);
			set => E_PROP_FVector_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Vector's Z component.
		/// </summary>
		public float Z
		{
			get => E_PROP_FVector_Z_GET(NativePointer);
			set => E_PROP_FVector_Z_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Calculate cross product between this and another vector.
		/// @param V The other vector.
		/// @return The cross product.
		/// </summary>
		public static FVector operator^(FVector Self, FVector V)
			=> E_OPER_FVector_u(Self, V);
		
		
		/// <summary>
		/// Calculate the cross product of two vectors.
		/// @param A The first vector.
		/// @param B The second vector.
		/// @return The cross product.
		/// </summary>
		public FVector CrossProduct(FVector A, FVector B)
			=> E_FVector_CrossProduct(this, A, B);
		
		
		/// <summary>
		/// Calculate the dot product between this and another vector.
		/// @param V The other vector.
		/// @return The dot product.
		/// </summary>
		public static float operator|(FVector Self, FVector V)
			=> E_OPER_FVector_i(Self, V);
		
		
		/// <summary>
		/// Calculate the dot product of two vectors.
		/// @param A The first vector.
		/// @param B The second vector.
		/// @return The dot product.
		/// </summary>
		public float DotProduct(FVector A, FVector B)
			=> E_FVector_DotProduct(this, A, B);
		
		
		/// <summary>
		/// Check against another vector for equality, within specified error limits.
		/// @param V The vector to check against.
		/// @param Tolerance Error tolerance.
		/// @return true if the vectors are equal within tolerance limits, false otherwise.
		/// </summary>
		public bool Equals(FVector V, float Tolerance)
			=> E_FVector_Equals(this, V, Tolerance);
		
		
		/// <summary>
		/// Checks whether all components of this vector are the same, within a tolerance.
		/// @param Tolerance Error tolerance.
		/// @return true if the vectors are equal within tolerance limits, false otherwise.
		/// </summary>
		public bool AllComponentsEqual(float Tolerance)
			=> E_FVector_AllComponentsEqual(this, Tolerance);
		
		
		/// <summary>
		/// Set the values of the vector directly.
		/// @param InX New X coordinate.
		/// @param InY New Y coordinate.
		/// @param InZ New Z coordinate.
		/// </summary>
		public void Set(float InX, float InY, float InZ)
			=> E_FVector_Set(this, InX, InY, InZ);
		
		
		/// <summary>
		/// Get the maximum value of the vector's components.
		/// @return The maximum value of the vector's components.
		/// </summary>
		public float GetMax()
			=> E_FVector_GetMax(this);
		
		
		/// <summary>
		/// Checks whether all components of the vector are exactly zero.
		/// @return true if the vector is exactly zero, false otherwise.
		/// </summary>
		public bool IsZero()
			=> E_FVector_IsZero(this);
		
		
		/// <summary>
		/// Normalize this vector in-place if it is large enough, set it to (0,0,0) otherwise.
		/// @param Tolerance Minimum squared length of vector for normalization.
		/// @return true if the vector was normalized correctly, false otherwise.
		/// </summary>
		public bool Normalize(float Tolerance)
			=> E_FVector_Normalize(this, Tolerance);
		
		
		/// <summary>
		/// Util to convert this vector into a unit direction vector and its original length.
		/// @param OutDir Reference passed in to store unit direction vector.
		/// @param OutLength Reference passed in to store length of the vector.
		/// </summary>
		public void ToDirectionAndLength(FVector OutDir, float OutLength)
			=> E_FVector_ToDirectionAndLength(this, OutDir, OutLength);
		
		
		/// <summary>
		/// Gets a copy of this vector snapped to a grid.
		/// @param GridSz Grid dimension.
		/// @return A copy of this vector snapped to a grid.
		/// @see FMath::GridSnap()
		/// </summary>
		public FVector GridSnap(float GridSz)
			=> E_FVector_GridSnap(this, GridSz);
		
		
		/// <summary>
		/// Create a copy of this vector, with its magnitude clamped between Min and Max.
		/// </summary>
		public FVector GetClampedToSize(float Min, float Max)
			=> E_FVector_GetClampedToSize(this, Min, Max);
		
		
		/// <summary>
		/// Add a vector to this and clamp the result in a cube.
		/// @param V Vector to add.
		/// @param Radius Half size of the cube.
		/// </summary>
		public void AddBounded(FVector V, float Radius)
			=> E_FVector_AddBounded(this, V, Radius);
		
		
		/// <summary>
		/// Rotates around Axis (assumes Axis.Size() == 1).
		/// @param Angle Angle to rotate (in degrees).
		/// @param Axis Axis to rotate around.
		/// @return Rotated Vector.
		/// </summary>
		public FVector RotateAngleAxis(float AngleDeg, FVector Axis)
			=> E_FVector_RotateAngleAxis(this, AngleDeg, Axis);
		
		
		/// <summary>
		/// Returns the cosine of the angle between this vector and another projected onto the XY plane (no Z).
		/// @param B the other vector to find the 2D cosine of the angle with.
		/// @return The cosine.
		/// </summary>
		public float CosineAngle2D(FVector B)
			=> E_FVector_CosineAngle2D(this, B);
		
		
		/// <summary>
		/// Return the FRotator orientation corresponding to the direction in which the vector points.
		/// Sets Yaw and Pitch to the proper numbers, and sets Roll to zero because the roll can't be determined from a vector.
		/// @return FRotator from the Vector's direction, without any roll.
		/// @see ToOrientationQuat()
		/// </summary>
		public FRotator ToOrientationRotator()
			=> E_FVector_ToOrientationRotator(this);
		
		
		/// <summary>
		/// Return the Quaternion orientation corresponding to the direction in which the vector points.
		/// Similar to the FRotator version, returns a result without roll such that it preserves the up vector.
		/// @note If you don't care about preserving the up vector and just want the most direct rotation, you can use the faster
		/// 'FQuat::FindBetweenVectors(FVector::ForwardVector, YourVector)' or 'FQuat::FindBetweenNormals(...)' if you know the vector is of unit length.
		/// @return Quaternion from the Vector's direction, without any roll.
		/// @see ToOrientationRotator(), FQuat::FindBetweenVectors()
		/// </summary>
		public FQuat ToOrientationQuat()
			=> E_FVector_ToOrientationQuat(this);
		
		
		/// <summary>
		/// Find good arbitrary axis vectors to represent U and V axes of a plane,
		/// using this vector as the normal of the plane.
		/// @param Axis1 Reference to first axis.
		/// @param Axis2 Reference to second axis.
		/// </summary>
		public void FindBestAxisVectors(FVector Axis1, FVector Axis2)
			=> E_FVector_FindBestAxisVectors(this, Axis1, Axis2);
		
		
		/// <summary>
		/// When this vector contains Euler angles (degrees), ensure that angles are between +/-180
		/// </summary>
		public void UnwindEuler()
			=> E_FVector_UnwindEuler(this);
		
		
		/// <summary>
		/// Converts a Cartesian unit vector into spherical coordinates on the unit sphere.
		/// @return Output Theta will be in the range [0, PI], and output Phi will be in the range [-PI, PI].
		/// </summary>
		public FVector2D UnitCartesianToSpherical()
			=> E_FVector_UnitCartesianToSpherical(this);
		
		
		/// <summary>
		/// Create an orthonormal basis from a basis with at least two orthogonal vectors.
		/// It may change the directions of the X and Y axes to make the basis orthogonal,
		/// but it won't change the direction of the Z axis.
		/// All axes will be normalized.
		/// @param XAxis The input basis' XAxis, and upon return the orthonormal basis' XAxis.
		/// @param YAxis The input basis' YAxis, and upon return the orthonormal basis' YAxis.
		/// @param ZAxis The input basis' ZAxis, and upon return the orthonormal basis' ZAxis.
		/// </summary>
		public void CreateOrthonormalBasis(FVector XAxis, FVector YAxis, FVector ZAxis)
			=> E_FVector_CreateOrthonormalBasis(this, XAxis, YAxis, ZAxis);
		
		
		/// <summary>
		/// Compare two points and see if they're the same, using a threshold.
		/// @param P First vector.
		/// @param Q Second vector.
		/// @return Whether points are the same within a threshold. Uses fast distance approximation (linear per-component distance).
		/// </summary>
		public bool PointsAreSame(FVector P, FVector Q)
			=> E_FVector_PointsAreSame(this, P, Q);
		
		
		/// <summary>
		/// Compare two points and see if they're within specified distance.
		/// @param Point1 First vector.
		/// @param Point2 Second vector.
		/// @param Dist Specified distance.
		/// @return Whether two points are within the specified distance. Uses fast distance approximation (linear per-component distance).
		/// </summary>
		public bool PointsAreNear(FVector Point1, FVector Point2, float Dist)
			=> E_FVector_PointsAreNear(this, Point1, Point2, Dist);
		
		
		/// <summary>
		/// Calculate the signed distance (in the direction of the normal) between a point and a plane.
		/// @param Point The Point we are checking.
		/// @param PlaneBase The Base Point in the plane.
		/// @param PlaneNormal The Normal of the plane (assumed to be unit length).
		/// @return Signed distance between point and plane.
		/// </summary>
		public float PointPlaneDist(FVector Point, FVector PlaneBase, FVector PlaneNormal)
			=> E_FVector_PointPlaneDist(this, Point, PlaneBase, PlaneNormal);
		
		
		/// <summary>
		/// See if two planes are coplanar. They are coplanar if the normals are nearly parallel and the planes include the same set of points.
		/// @param Base1 The base point in the first plane.
		/// @param Normal1 The normal of the first plane.
		/// @param Base2 The base point in the second plane.
		/// @param Normal2 The normal of the second plane.
		/// @param ParallelCosineThreshold Normals are parallel if absolute value of dot product is greater than or equal to this.
		/// @return true if the planes are coplanar, false otherwise.
		/// </summary>
		public bool Coplanar(FVector Base1, FVector Normal1, FVector Base2, FVector Normal2, float ParallelCosineThreshold)
			=> E_FVector_Coplanar(this, Base1, Normal1, Base2, Normal2, ParallelCosineThreshold);
		
		#endregion
		
		public static implicit operator IntPtr(FVector Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FVector(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector(Adress, false);
		}}}
