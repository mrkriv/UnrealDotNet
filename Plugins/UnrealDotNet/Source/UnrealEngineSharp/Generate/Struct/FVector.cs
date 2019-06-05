// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Vector.h:29

namespace UnrealEngine
{
	public partial class FVector : NativeStructWrapper
	{
		public FVector(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FVector() :
			base(E_CreateStruct_FVector(), false)
		{
		}

		
		/// <summary>
		/// Constructor initializing all components to a single float value.
		/// </summary>
		/// <param name="inF">Value to set all components to.</param>
		public FVector(float inF) :
			base(E_CreateStruct_FVector_float(inF), false)
		{
		}

		
		/// <summary>
		/// Constructor using initial values for each component.
		/// </summary>
		/// <param name="inX">X Coordinate.</param>
		/// <param name="inY">Y Coordinate.</param>
		/// <param name="inZ">Z Coordinate.</param>
		public FVector(float inX, float inY, float inZ) :
			base(E_CreateStruct_FVector_float_float_float(inX, inY, inZ), false)
		{
		}

		
		/// <summary>
		/// Constructs a vector from an FVector2D and Z value.
		/// </summary>
		/// <param name="v">Vector to copy from.</param>
		/// <param name="inZ">Z Coordinate.</param>
		public FVector(FVector2D v, float inZ) :
			base(E_CreateStruct_FVector_FVector2D_float(v, inZ), false)
		{
		}

		
		/// <summary>
		/// Constructor using the XYZ components from a 4D vector.
		/// </summary>
		/// <param name="v">4D Vector to copy from.</param>
		public FVector(FVector4 v) :
			base(E_CreateStruct_FVector_FVector4(v), false)
		{
		}

		
		/// <summary>
		/// Constructs a vector from an FLinearColor.
		/// </summary>
		/// <param name="inColor">Color to copy from.</param>
		public FVector(FLinearColor inColor) :
			base(E_CreateStruct_FVector_FLinearColor(inColor), false)
		{
		}

		
		/// <summary>
		/// Constructs a vector from an FIntVector.
		/// </summary>
		/// <param name="inVector">FIntVector to copy from.</param>
		public FVector(FIntVector inVector) :
			base(E_CreateStruct_FVector_FIntVector(inVector), false)
		{
		}

		
		/// <summary>
		/// Constructs a vector from an FIntPoint.
		/// </summary>
		/// <param name="a">Int Point used to set X and Y coordinates, Z is set to zero.</param>
		public FVector(FIntPoint a) :
			base(E_CreateStruct_FVector_FIntPoint(a), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector_X_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector_Y_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector_Z_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector_Z_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_float(float inF);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_float_float_float(float inX, float inY, float inZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_FVector2D_float(IntPtr v, float inZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_FVector4(IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_FLinearColor(IntPtr inColor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_FIntVector(IntPtr inVector);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_FIntPoint(IntPtr a);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_AddBounded(IntPtr self, IntPtr v, float radius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_AllComponentsEqual(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_BoundToBox(IntPtr self, IntPtr min, IntPtr max);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_BoundToCube(IntPtr self, float radius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_BoxPushOut(IntPtr self, IntPtr normal, IntPtr size);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_Coincident(IntPtr self, IntPtr normal1, IntPtr normal2, float parallelCosineThreshold);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_Component(IntPtr self, int index);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ComponentMax(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ComponentMin(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_ContainsNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_Coplanar(IntPtr self, IntPtr base1, IntPtr normal1, IntPtr base2, IntPtr normal2, float parallelCosineThreshold);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_CosineAngle2D(IntPtr self, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_CreateOrthonormalBasis(IntPtr self, IntPtr xAxis, IntPtr yAxis, IntPtr zAxis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_CrossProduct(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_DegreesToRadians(IntPtr self, IntPtr degVector);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_DiagnosticCheckNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_Dist(IntPtr self, IntPtr v1, IntPtr v2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_Dist2D(IntPtr self, IntPtr v1, IntPtr v2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_Distance(IntPtr self, IntPtr v1, IntPtr v2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_DistSquared(IntPtr self, IntPtr v1, IntPtr v2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_DistSquared2D(IntPtr self, IntPtr v1, IntPtr v2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_DistSquaredXY(IntPtr self, IntPtr v1, IntPtr v2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_DistXY(IntPtr self, IntPtr v1, IntPtr v2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_DotProduct(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_Equals(IntPtr self, IntPtr v, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_FindBestAxisVectors(IntPtr self, IntPtr axis1, IntPtr axis2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetAbs(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_GetAbsMax(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_GetAbsMin(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetClampedToMaxSize(IntPtr self, float maxSize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetClampedToMaxSize2D(IntPtr self, float maxSize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetClampedToSize(IntPtr self, float min, float max);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetClampedToSize2D(IntPtr self, float min, float max);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_GetMax(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_GetMin(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetSafeNormal(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetSafeNormal2D(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetSignVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetUnsafeNormal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetUnsafeNormal2D(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GridSnap(IntPtr self, float gridSz);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_HeadingAngle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_InitFromString(IntPtr self, string inSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsNearlyZero(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsNormalized(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsUniform(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsUnit(IntPtr self, float lengthSquaredTolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsZero(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_MirrorByPlane(IntPtr self, IntPtr plane);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_MirrorByVector(IntPtr self, IntPtr mirrorNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_Normalize(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_Orthogonal(IntPtr self, IntPtr normal1, IntPtr normal2, float orthogonalCosineThreshold);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_Parallel(IntPtr self, IntPtr normal1, IntPtr normal2, float parallelCosineThreshold);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_PointPlaneDist(IntPtr self, IntPtr point, IntPtr planeBase, IntPtr planeNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_PointPlaneProject(IntPtr self, IntPtr point, IntPtr plane);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_PointPlaneProject_o1(IntPtr self, IntPtr point, IntPtr a, IntPtr b, IntPtr c);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_PointPlaneProject_o2(IntPtr self, IntPtr point, IntPtr planeBase, IntPtr planeNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_PointsAreNear(IntPtr self, IntPtr point1, IntPtr point2, float dist);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_PointsAreSame(IntPtr self, IntPtr p, IntPtr q);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_Projection(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ProjectOnTo(IntPtr self, IntPtr a);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ProjectOnToNormal(IntPtr self, IntPtr normal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_RadiansToDegrees(IntPtr self, IntPtr radVector);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_Reciprocal(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_RotateAngleAxis(IntPtr self, float angleDeg, IntPtr axis);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_Rotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_Set(IntPtr self, float inX, float inY, float inZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_Size(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_Size2D(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_SizeSquared(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_SizeSquared2D(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector_ToCompactString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector_ToCompactText(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_ToDirectionAndLength(IntPtr self, IntPtr outDir, float outLength);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ToOrientationQuat(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ToOrientationRotator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector_ToString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector_ToText(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_Triple(IntPtr self, IntPtr x, IntPtr y, IntPtr z);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_UnitCartesianToSpherical(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_UnwindEuler(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_VectorPlaneProject(IntPtr self, IntPtr v, IntPtr planeNormal);
		
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
		/// Add a vector to this and clamp the result in a cube.
		/// </summary>
		/// <param name="v">Vector to add.</param>
		/// <param name="radius">Half size of the cube.</param>
		public void AddBounded(FVector v, float radius)
			=> E_FVector_AddBounded(this, v, radius);
		
		
		/// <summary>
		/// Checks whether all components of this vector are the same, within a tolerance.
		/// </summary>
		/// <param name="tolerance">Error tolerance.</param>
		/// <return>true</return>
		public bool AllComponentsEqual(float tolerance)
			=> E_FVector_AllComponentsEqual(this, tolerance);
		
		
		/// <summary>
		/// Get a copy of this vector, clamped inside of a cube.
		/// </summary>
		public FVector BoundToBox(FVector min, FVector max)
			=> E_FVector_BoundToBox(this, min, max);
		
		
		/// <summary>
		/// Get a copy of this vector, clamped inside of a cube.
		/// </summary>
		/// <param name="radius">Half size of the cube.</param>
		/// <return>A</return>
		public FVector BoundToCube(float radius)
			=> E_FVector_BoundToCube(this, radius);
		
		
		/// <summary>
		/// Compute pushout of a box from a plane.
		/// </summary>
		/// <param name="normal">The plane normal.</param>
		/// <param name="size">The size of the box.</param>
		/// <return>Pushout</return>
		public float BoxPushOut(FVector normal, FVector size)
			=> E_FVector_BoxPushOut(this, normal, size);
		
		
		/// <summary>
		/// See if two normal vectors are coincident (nearly parallel and point in the same direction).
		/// </summary>
		/// <param name="normal1">First normalized vector.</param>
		/// <param name="normal2">Second normalized vector.</param>
		/// <param name="parallelCosineThreshold">Normals are coincident if dot product (cosine of angle between them) is greater than or equal to this. For example: cos(1.0 degrees).</param>
		/// <return>true</return>
		public bool Coincident(FVector normal1, FVector normal2, float parallelCosineThreshold)
			=> E_FVector_Coincident(this, normal1, normal2, parallelCosineThreshold);
		
		
		/// <summary>
		/// Gets a specific component of the vector.
		/// </summary>
		/// <param name="index">The index of the component required.</param>
		/// <return>Reference</return>
		public float Component(int index)
			=> E_FVector_Component(this, index);
		
		
		/// <summary>
		/// Gets the component-wise max of two vectors.
		/// </summary>
		public FVector ComponentMax(FVector other)
			=> E_FVector_ComponentMax(this, other);
		
		
		/// <summary>
		/// Gets the component-wise min of two vectors.
		/// </summary>
		public FVector ComponentMin(FVector other)
			=> E_FVector_ComponentMin(this, other);
		
		
		/// <summary>
		/// Utility to check if there are any non-finite values (NaN or Inf) in this vector.
		/// </summary>
		/// <return>true</return>
		public bool ContainsNaN()
			=> E_FVector_ContainsNaN(this);
		
		
		/// <summary>
		/// See if two planes are coplanar. They are coplanar if the normals are nearly parallel and the planes include the same set of points.
		/// </summary>
		/// <param name="base1">The base point in the first plane.</param>
		/// <param name="normal1">The normal of the first plane.</param>
		/// <param name="base2">The base point in the second plane.</param>
		/// <param name="normal2">The normal of the second plane.</param>
		/// <param name="parallelCosineThreshold">Normals are parallel if absolute value of dot product is greater than or equal to this.</param>
		/// <return>true</return>
		public bool Coplanar(FVector base1, FVector normal1, FVector base2, FVector normal2, float parallelCosineThreshold)
			=> E_FVector_Coplanar(this, base1, normal1, base2, normal2, parallelCosineThreshold);
		
		
		/// <summary>
		/// Returns the cosine of the angle between this vector and another projected onto the XY plane (no Z).
		/// </summary>
		/// <param name="b">the other vector to find the 2D cosine of the angle with.</param>
		/// <return>The</return>
		public float CosineAngle2D(FVector b)
			=> E_FVector_CosineAngle2D(this, b);
		
		
		/// <summary>
		/// Create an orthonormal basis from a basis with at least two orthogonal vectors.
		/// <para>It may change the directions of the X and Y axes to make the basis orthogonal, </para>
		/// but it won't change the direction of the Z axis.
		/// <para>All axes will be normalized. </para>
		/// </summary>
		/// <param name="xAxis">The input basis' XAxis, and upon return the orthonormal basis' XAxis.</param>
		/// <param name="yAxis">The input basis' YAxis, and upon return the orthonormal basis' YAxis.</param>
		/// <param name="zAxis">The input basis' ZAxis, and upon return the orthonormal basis' ZAxis.</param>
		public void CreateOrthonormalBasis(FVector xAxis, FVector yAxis, FVector zAxis)
			=> E_FVector_CreateOrthonormalBasis(this, xAxis, yAxis, zAxis);
		
		
		/// <summary>
		/// Calculate the cross product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <return>The</return>
		public FVector CrossProduct(FVector a, FVector b)
			=> E_FVector_CrossProduct(this, a, b);
		
		
		/// <summary>
		/// Converts a vector containing degree values to a vector containing radian values.
		/// </summary>
		/// <param name="degVector">Vector containing degree values</param>
		/// <return>Vector</return>
		public FVector DegreesToRadians(FVector degVector)
			=> E_FVector_DegreesToRadians(this, degVector);
		
		public void DiagnosticCheckNaN()
			=> E_FVector_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// Euclidean distance between two points.
		/// </summary>
		/// <param name="v1">The first point.</param>
		/// <param name="v2">The second point.</param>
		/// <return>The</return>
		public float Dist(FVector v1, FVector v2)
			=> E_FVector_Dist(this, v1, v2);
		
		public float Dist2D(FVector v1, FVector v2)
			=> E_FVector_Dist2D(this, v1, v2);
		
		public float Distance(FVector v1, FVector v2)
			=> E_FVector_Distance(this, v1, v2);
		
		
		/// <summary>
		/// Squared distance between two points.
		/// </summary>
		/// <param name="v1">The first point.</param>
		/// <param name="v2">The second point.</param>
		/// <return>The</return>
		public float DistSquared(FVector v1, FVector v2)
			=> E_FVector_DistSquared(this, v1, v2);
		
		public float DistSquared2D(FVector v1, FVector v2)
			=> E_FVector_DistSquared2D(this, v1, v2);
		
		
		/// <summary>
		/// Squared distance between two points in the XY plane only.
		/// </summary>
		/// <param name="v1">The first point.</param>
		/// <param name="v2">The second point.</param>
		/// <return>The</return>
		public float DistSquaredXY(FVector v1, FVector v2)
			=> E_FVector_DistSquaredXY(this, v1, v2);
		
		
		/// <summary>
		/// Euclidean distance between two points in the XY plane (ignoring Z).
		/// </summary>
		/// <param name="v1">The first point.</param>
		/// <param name="v2">The second point.</param>
		/// <return>The</return>
		public float DistXY(FVector v1, FVector v2)
			=> E_FVector_DistXY(this, v1, v2);
		
		
		/// <summary>
		/// Calculate the dot product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <return>The</return>
		public float DotProduct(FVector a, FVector b)
			=> E_FVector_DotProduct(this, a, b);
		
		
		/// <summary>
		/// Check against another vector for equality, within specified error limits.
		/// </summary>
		/// <param name="v">The vector to check against.</param>
		/// <param name="tolerance">Error tolerance.</param>
		/// <return>true</return>
		public bool Equals(FVector v, float tolerance)
			=> E_FVector_Equals(this, v, tolerance);
		
		
		/// <summary>
		/// Find good arbitrary axis vectors to represent U and V axes of a plane,
		/// <para>using this vector as the normal of the plane. </para>
		/// </summary>
		/// <param name="axis1">Reference to first axis.</param>
		/// <param name="axis2">Reference to second axis.</param>
		public void FindBestAxisVectors(FVector axis1, FVector axis2)
			=> E_FVector_FindBestAxisVectors(this, axis1, axis2);
		
		
		/// <summary>
		/// Get a copy of this vector with absolute value of each component.
		/// </summary>
		/// <return>A</return>
		public FVector GetAbs()
			=> E_FVector_GetAbs(this);
		
		
		/// <summary>
		/// Get the maximum absolute value of the vector's components.
		/// </summary>
		/// <return>The</return>
		public float GetAbsMax()
			=> E_FVector_GetAbsMax(this);
		
		
		/// <summary>
		/// Get the minimum absolute value of the vector's components.
		/// </summary>
		/// <return>The</return>
		public float GetAbsMin()
			=> E_FVector_GetAbsMin(this);
		
		
		/// <summary>
		/// Create a copy of this vector, with its maximum magnitude clamped to MaxSize.
		/// </summary>
		public FVector GetClampedToMaxSize(float maxSize)
			=> E_FVector_GetClampedToMaxSize(this, maxSize);
		
		
		/// <summary>
		/// Create a copy of this vector, with the maximum 2D magnitude clamped to MaxSize. Z is unchanged.
		/// </summary>
		public FVector GetClampedToMaxSize2D(float maxSize)
			=> E_FVector_GetClampedToMaxSize2D(this, maxSize);
		
		
		/// <summary>
		/// Create a copy of this vector, with its magnitude clamped between Min and Max.
		/// </summary>
		public FVector GetClampedToSize(float min, float max)
			=> E_FVector_GetClampedToSize(this, min, max);
		
		
		/// <summary>
		/// Create a copy of this vector, with the 2D magnitude clamped between Min and Max. Z is unchanged.
		/// </summary>
		public FVector GetClampedToSize2D(float min, float max)
			=> E_FVector_GetClampedToSize2D(this, min, max);
		
		
		/// <summary>
		/// Get the maximum value of the vector's components.
		/// </summary>
		/// <return>The</return>
		public float GetMax()
			=> E_FVector_GetMax(this);
		
		
		/// <summary>
		/// Get the minimum value of the vector's components.
		/// </summary>
		/// <return>The</return>
		public float GetMin()
			=> E_FVector_GetMin(this);
		
		
		/// <summary>
		/// Gets a normalized copy of the vector, checking it is safe to do so based on the length.
		/// <para>Returns zero vector if vector length is too small to safely normalize. </para>
		/// </summary>
		/// <param name="tolerance">Minimum squared vector length.</param>
		/// <return>A</return>
		public FVector GetSafeNormal(float tolerance)
			=> E_FVector_GetSafeNormal(this, tolerance);
		
		
		/// <summary>
		/// Gets a normalized copy of the 2D components of the vector, checking it is safe to do so. Z is set to zero.
		/// <para>Returns zero vector if vector length is too small to normalize. </para>
		/// </summary>
		/// <param name="tolerance">Minimum squared vector length.</param>
		/// <return>Normalized</return>
		public FVector GetSafeNormal2D(float tolerance)
			=> E_FVector_GetSafeNormal2D(this, tolerance);
		
		
		/// <summary>
		/// Get a copy of the vector as sign only.
		/// <para>Each component is set to +1 or -1, with the sign of zero treated as +1. </para>
		/// </summary>
		/// <param name="a">copy of the vector with each component set to +1 or -1</param>
		public FVector GetSignVector()
			=> E_FVector_GetSignVector(this);
		
		
		/// <summary>
		/// Calculates normalized version of vector without checking for zero length.
		/// <see cref="GetSafeNormal"/>
		/// </summary>
		/// <return>Normalized</return>
		public FVector GetUnsafeNormal()
			=> E_FVector_GetUnsafeNormal(this);
		
		
		/// <summary>
		/// Calculates normalized 2D version of vector without checking for zero length.
		/// <see cref="GetSafeNormal2D"/>
		/// </summary>
		/// <return>Normalized</return>
		public FVector GetUnsafeNormal2D()
			=> E_FVector_GetUnsafeNormal2D(this);
		
		
		/// <summary>
		/// Gets a copy of this vector snapped to a grid.
		/// <see cref="FMath"/>
		/// </summary>
		/// <param name="gridSz">Grid dimension.</param>
		/// <return>A</return>
		public FVector GridSnap(float gridSz)
			=> E_FVector_GridSnap(this, gridSz);
		
		
		/// <summary>
		/// Convert a direction vector into a 'heading' angle.
		/// </summary>
		/// <return>Heading</return>
		public float HeadingAngle()
			=> E_FVector_HeadingAngle(this);
		
		
		/// <summary>
		/// Initialize this Vector based on an FString. The String is expected to contain X=, Y=, Z=.
		/// <para>The FVector will be bogus when InitFromString returns false. </para>
		/// </summary>
		/// <param name="inSourceString">FString containing the vector values.</param>
		/// <return>true</return>
		public bool InitFromString(string inSourceString)
			=> E_FVector_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// Checks whether vector is near to zero within a specified tolerance.
		/// </summary>
		/// <param name="tolerance">Error tolerance.</param>
		/// <return>true</return>
		public bool IsNearlyZero(float tolerance)
			=> E_FVector_IsNearlyZero(this, tolerance);
		
		
		/// <summary>
		/// Checks whether vector is normalized.
		/// </summary>
		/// <return>true</return>
		public bool IsNormalized()
			=> E_FVector_IsNormalized(this);
		
		
		/// <summary>
		/// Check whether X, Y and Z are nearly equal.
		/// </summary>
		/// <param name="tolerance">Specified Tolerance.</param>
		/// <return>true</return>
		public bool IsUniform(float tolerance)
			=> E_FVector_IsUniform(this, tolerance);
		
		
		/// <summary>
		/// Check if the vector is of unit length, with specified tolerance.
		/// </summary>
		/// <param name="lengthSquaredTolerance">Tolerance against squared length.</param>
		/// <return>true</return>
		public bool IsUnit(float lengthSquaredTolerance)
			=> E_FVector_IsUnit(this, lengthSquaredTolerance);
		
		
		/// <summary>
		/// Checks whether all components of the vector are exactly zero.
		/// </summary>
		/// <return>true</return>
		public bool IsZero()
			=> E_FVector_IsZero(this);
		
		
		/// <summary>
		/// Mirrors a vector about a plane.
		/// </summary>
		/// <param name="plane">Plane to mirror about.</param>
		/// <return>Mirrored</return>
		public FVector MirrorByPlane(FPlane plane)
			=> E_FVector_MirrorByPlane(this, plane);
		
		
		/// <summary>
		/// Mirror a vector about a normal vector.
		/// </summary>
		/// <param name="mirrorNormal">Normal vector to mirror about.</param>
		/// <return>Mirrored</return>
		public FVector MirrorByVector(FVector mirrorNormal)
			=> E_FVector_MirrorByVector(this, mirrorNormal);
		
		
		/// <summary>
		/// Normalize this vector in-place if it is larger than a given tolerance. Leaves it unchanged if not.
		/// </summary>
		/// <param name="tolerance">Minimum squared length of vector for normalization.</param>
		/// <return>true</return>
		public bool Normalize(float tolerance)
			=> E_FVector_Normalize(this, tolerance);
		
		
		/// <summary>
		/// See if two normal vectors are nearly orthogonal (perpendicular), meaning the angle between them is close to 90 degrees.
		/// </summary>
		/// <param name="normal1">First normalized vector.</param>
		/// <param name="normal2">Second normalized vector.</param>
		/// <param name="orthogonalCosineThreshold">Normals are orthogonal if absolute value of dot product (cosine of angle between them) is less than or equal to this. For example: cos(89.0 degrees).</param>
		/// <return>true</return>
		public bool Orthogonal(FVector normal1, FVector normal2, float orthogonalCosineThreshold)
			=> E_FVector_Orthogonal(this, normal1, normal2, orthogonalCosineThreshold);
		
		
		/// <summary>
		/// See if two normal vectors are nearly parallel, meaning the angle between them is close to 0 degrees.
		/// </summary>
		/// <param name="normal1">First normalized vector.</param>
		/// <param name="normal1">Second normalized vector.</param>
		/// <param name="parallelCosineThreshold">Normals are parallel if absolute value of dot product (cosine of angle between them) is greater than or equal to this. For example: cos(1.0 degrees).</param>
		/// <return>true</return>
		public bool Parallel(FVector normal1, FVector normal2, float parallelCosineThreshold)
			=> E_FVector_Parallel(this, normal1, normal2, parallelCosineThreshold);
		
		
		/// <summary>
		/// Calculate the signed distance (in the direction of the normal) between a point and a plane.
		/// </summary>
		/// <param name="point">The Point we are checking.</param>
		/// <param name="planeBase">The Base Point in the plane.</param>
		/// <param name="planeNormal">The Normal of the plane (assumed to be unit length).</param>
		/// <return>Signed</return>
		public float PointPlaneDist(FVector point, FVector planeBase, FVector planeNormal)
			=> E_FVector_PointPlaneDist(this, point, planeBase, planeNormal);
		
		
		/// <summary>
		/// Calculate the projection of a point on the given plane.
		/// </summary>
		/// <param name="point">The point to project onto the plane</param>
		/// <param name="plane">The plane</param>
		/// <return>Projection</return>
		public FVector PointPlaneProject(FVector point, FPlane plane)
			=> E_FVector_PointPlaneProject(this, point, plane);
		
		
		/// <summary>
		/// Calculate the projection of a point on the plane defined by counter-clockwise (CCW) points A,B,C.
		/// </summary>
		/// <param name="point">The point to project onto the plane</param>
		/// <param name="a">1st of three points in CCW order defining the plane</param>
		/// <param name="b">2nd of three points in CCW order defining the plane</param>
		/// <param name="c">3rd of three points in CCW order defining the plane</param>
		/// <return>Projection</return>
		public FVector PointPlaneProject(FVector point, FVector a, FVector b, FVector c)
			=> E_FVector_PointPlaneProject_o1(this, point, a, b, c);
		
		
		/// <summary>
		/// Calculate the projection of a point on the plane defined by PlaneBase and PlaneNormal.
		/// </summary>
		/// <param name="point">The point to project onto the plane</param>
		/// <param name="planeBase">Point on the plane</param>
		/// <param name="planeNorm">Normal of the plane (assumed to be unit length).</param>
		/// <return>Projection</return>
		public FVector PointPlaneProject(FVector point, FVector planeBase, FVector planeNormal)
			=> E_FVector_PointPlaneProject_o2(this, point, planeBase, planeNormal);
		
		
		/// <summary>
		/// Compare two points and see if they're within specified distance.
		/// </summary>
		/// <param name="point1">First vector.</param>
		/// <param name="point2">Second vector.</param>
		/// <param name="dist">Specified distance.</param>
		/// <return>Whether</return>
		public bool PointsAreNear(FVector point1, FVector point2, float dist)
			=> E_FVector_PointsAreNear(this, point1, point2, dist);
		
		
		/// <summary>
		/// Compare two points and see if they're the same, using a threshold.
		/// </summary>
		/// <param name="p">First vector.</param>
		/// <param name="q">Second vector.</param>
		/// <return>Whether</return>
		public bool PointsAreSame(FVector p, FVector q)
			=> E_FVector_PointsAreSame(this, p, q);
		
		
		/// <summary>
		/// Projects 2D components of vector based on Z.
		/// </summary>
		/// <return>Projected</return>
		public FVector Projection()
			=> E_FVector_Projection(this);
		
		
		/// <summary>
		/// Gets a copy of this vector projected onto the input vector.
		/// </summary>
		/// <param name="a">Vector to project onto, does not assume it is normalized.</param>
		/// <return>Projected</return>
		public FVector ProjectOnTo(FVector a)
			=> E_FVector_ProjectOnTo(this, a);
		
		
		/// <summary>
		/// Gets a copy of this vector projected onto the input vector, which is assumed to be unit length.
		/// </summary>
		/// <param name="normal">Vector to project onto (assumed to be unit length).</param>
		/// <return>Projected</return>
		public FVector ProjectOnToNormal(FVector normal)
			=> E_FVector_ProjectOnToNormal(this, normal);
		
		
		/// <summary>
		/// Converts a vector containing radian values to a vector containing degree values.
		/// </summary>
		/// <param name="radVector">Vector containing radian values</param>
		/// <return>Vector</return>
		public FVector RadiansToDegrees(FVector radVector)
			=> E_FVector_RadiansToDegrees(this, radVector);
		
		
		/// <summary>
		/// Gets the reciprocal of this vector, avoiding division by zero.
		/// <para>Zero components are set to BIG_NUMBER. </para>
		/// </summary>
		/// <return>Reciprocal</return>
		public FVector Reciprocal()
			=> E_FVector_Reciprocal(this);
		
		
		/// <summary>
		/// Rotates around Axis (assumes Axis.Size() == 1).
		/// </summary>
		/// <param name="angle">Angle to rotate (in degrees).</param>
		/// <param name="axis">Axis to rotate around.</param>
		/// <return>Rotated</return>
		public FVector RotateAngleAxis(float angleDeg, FVector axis)
			=> E_FVector_RotateAngleAxis(this, angleDeg, axis);
		
		
		/// <summary>
		/// Return the FRotator orientation corresponding to the direction in which the vector points.
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets Roll to zero because the roll can't be determined from a vector. </para>
		/// @note Identical to 'ToOrientationRotator()' and preserved for legacy reasons.
		/// <see cref="ToOrientationRotator"/>
		/// </summary>
		/// <return>FRotator</return>
		public FRotator Rotation()
			=> E_FVector_Rotation(this);
		
		
		/// <summary>
		/// Set the values of the vector directly.
		/// </summary>
		/// <param name="inX">New X coordinate.</param>
		/// <param name="inY">New Y coordinate.</param>
		/// <param name="inZ">New Z coordinate.</param>
		public void Set(float inX, float inY, float inZ)
			=> E_FVector_Set(this, inX, inY, inZ);
		
		
		/// <summary>
		/// Get the length (magnitude) of this vector.
		/// </summary>
		/// <return>The</return>
		public float Size()
			=> E_FVector_Size(this);
		
		
		/// <summary>
		/// Get the length of the 2D components of this vector.
		/// </summary>
		/// <return>The</return>
		public float Size2D()
			=> E_FVector_Size2D(this);
		
		
		/// <summary>
		/// Get the squared length of this vector.
		/// </summary>
		/// <return>The</return>
		public float SizeSquared()
			=> E_FVector_SizeSquared(this);
		
		
		/// <summary>
		/// Get the squared length of the 2D components of this vector.
		/// </summary>
		/// <return>The</return>
		public float SizeSquared2D()
			=> E_FVector_SizeSquared2D(this);
		
		
		/// <summary>
		/// Get a short textural representation of this vector, for compact readable logging.
		/// </summary>
		public string ToCompactString()
			=> E_FVector_ToCompactString(this);
		
		
		/// <summary>
		/// Get a short locale aware textural representation of this vector, for compact readable logging.
		/// </summary>
		public string ToCompactText()
			=> E_FVector_ToCompactText(this);
		
		
		/// <summary>
		/// Util to convert this vector into a unit direction vector and its original length.
		/// </summary>
		/// <param name="outDir">Reference passed in to store unit direction vector.</param>
		/// <param name="outLength">Reference passed in to store length of the vector.</param>
		public void ToDirectionAndLength(FVector outDir, float outLength)
			=> E_FVector_ToDirectionAndLength(this, outDir, outLength);
		
		
		/// <summary>
		/// Return the Quaternion orientation corresponding to the direction in which the vector points.
		/// <para>Similar to the FRotator version, returns a result without roll such that it preserves the up vector. </para>
		/// @note If you don't care about preserving the up vector and just want the most direct rotation, you can use the faster
		/// <para>'FQuat::FindBetweenVectors(FVector::ForwardVector, YourVector)' or 'FQuat::FindBetweenNormals(...)' if you know the vector is of unit length. </para>
		/// <see cref="ToOrientationRotator"/>
		/// </summary>
		/// <return>Quaternion</return>
		public FQuat ToOrientationQuat()
			=> E_FVector_ToOrientationQuat(this);
		
		
		/// <summary>
		/// Return the FRotator orientation corresponding to the direction in which the vector points.
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets Roll to zero because the roll can't be determined from a vector. </para>
		/// <see cref="ToOrientationQuat"/>
		/// </summary>
		/// <return>FRotator</return>
		public FRotator ToOrientationRotator()
			=> E_FVector_ToOrientationRotator(this);
		
		
		/// <summary>
		/// Get a textual representation of this vector.
		/// </summary>
		/// <return>A</return>
		public override string ToString()
			=> E_FVector_ToString(this);
		
		
		/// <summary>
		/// Get a locale aware textual representation of this vector.
		/// </summary>
		/// <return>A</return>
		public string ToText()
			=> E_FVector_ToText(this);
		
		
		/// <summary>
		/// Triple product of three vectors: X dot (Y cross Z).
		/// </summary>
		/// <param name="x">The first vector.</param>
		/// <param name="y">The second vector.</param>
		/// <param name="z">The third vector.</param>
		/// <return>The</return>
		public float Triple(FVector x, FVector y, FVector z)
			=> E_FVector_Triple(this, x, y, z);
		
		
		/// <summary>
		/// Converts a Cartesian unit vector into spherical coordinates on the unit sphere.
		/// </summary>
		/// <return>Output</return>
		public FVector2D UnitCartesianToSpherical()
			=> E_FVector_UnitCartesianToSpherical(this);
		
		
		/// <summary>
		/// When this vector contains Euler angles (degrees), ensure that angles are between +/-180
		/// </summary>
		public void UnwindEuler()
			=> E_FVector_UnwindEuler(this);
		
		
		/// <summary>
		/// Calculate the projection of a vector on the plane defined by PlaneNormal.
		/// </summary>
		/// <param name="v">The vector to project onto the plane.</param>
		/// <param name="planeNormal">Normal of the plane (assumed to be unit length).</param>
		/// <return>Projection</return>
		public FVector VectorPlaneProject(FVector v, FVector planeNormal)
			=> E_FVector_VectorPlaneProject(this, v, planeNormal);
		
		#endregion
		
		public static implicit operator IntPtr(FVector self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FVector(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FVector(adress, false);
		}}}
