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
	public  partial class FVector : NativeStructWrapper
	{
		internal FVector(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FVector() :
			base(E_CreateStruct_FVector(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor initializing all components to a single float value. </para>
		/// <param name="InF">Value to set all components to. </param>
		/// </summary>
		public FVector(float inF) :
			base(E_CreateStruct_FVector_float(inF), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor using initial values for each component. </para>
		/// <param name="InX">X Coordinate. </param>
		/// <param name="InY">Y Coordinate. </param>
		/// <param name="InZ">Z Coordinate. </param>
		/// </summary>
		public FVector(float inX, float inY, float inZ) :
			base(E_CreateStruct_FVector_float_float_float(inX, inY, inZ), false)
		{
		}

		
		/// <summary>
		/// <para>Constructs a vector from an FVector2D and Z value. </para>
		/// <param name="V">Vector to copy from. </param>
		/// <param name="InZ">Z Coordinate. </param>
		/// </summary>
		public FVector(FVector2D v, float inZ) :
			base(E_CreateStruct_FVector_FVector2D_float(v, inZ), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor using the XYZ components from a 4D vector. </para>
		/// <param name="V">4D Vector to copy from. </param>
		/// </summary>
		public FVector(FVector4 v) :
			base(E_CreateStruct_FVector_FVector4(v), false)
		{
		}

		
		/// <summary>
		/// <para>Constructs a vector from an FLinearColor. </para>
		/// <param name="InColor">Color to copy from. </param>
		/// </summary>
		public FVector(FLinearColor inColor) :
			base(E_CreateStruct_FVector_FLinearColor(inColor), false)
		{
		}

		
		/// <summary>
		/// <para>Constructs a vector from an FIntVector. </para>
		/// <param name="InVector">FIntVector to copy from. </param>
		/// </summary>
		public FVector(FIntVector inVector) :
			base(E_CreateStruct_FVector_FIntVector(inVector), false)
		{
		}

		
		/// <summary>
		/// <para>Constructs a vector from an FIntPoint. </para>
		/// <param name="A">Int Point used to set X and Y coordinates, Z is set to zero. </param>
		/// </summary>
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
		private static extern float E_FVector_EvaluateBezier(IntPtr self, IntPtr controlPoints, int numPoints, IntPtr outPoints);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_FindBestAxisVectors(IntPtr self, IntPtr axis1, IntPtr axis2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_GenerateClusterCenters(IntPtr self, IntPtr clusters, IntPtr points, int numIterations, int numConnectionsToBeValid);
		
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
		/// <para>Vector's X component. </para>
		/// </summary>
		public float X
		{
			get => E_PROP_FVector_X_GET(NativePointer);
			set => E_PROP_FVector_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Vector's Y component. </para>
		/// </summary>
		public float Y
		{
			get => E_PROP_FVector_Y_GET(NativePointer);
			set => E_PROP_FVector_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Vector's Z component. </para>
		/// </summary>
		public float Z
		{
			get => E_PROP_FVector_Z_GET(NativePointer);
			set => E_PROP_FVector_Z_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add a vector to this and clamp the result in a cube. </para>
		/// <param name="V">Vector to add. </param>
		/// <param name="Radius">Half size of the cube. </param>
		/// </summary>
		public void AddBounded(FVector v, float radius)
			=> E_FVector_AddBounded(this, v, radius);
		
		
		/// <summary>
		/// <para>Checks whether all components of this vector are the same, within a tolerance. </para>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if the vectors are equal within tolerance limits, false otherwise. </return>
		/// </summary>
		public bool AllComponentsEqual(float tolerance)
			=> E_FVector_AllComponentsEqual(this, tolerance);
		
		
		/// <summary>
		/// <para>Get a copy of this vector, clamped inside of a cube. </para>
		/// </summary>
		public FVector BoundToBox(FVector min, FVector max)
			=> E_FVector_BoundToBox(this, min, max);
		
		
		/// <summary>
		/// <para>Get a copy of this vector, clamped inside of a cube. </para>
		/// <param name="Radius">Half size of the cube. </param>
		/// <return>A copy of this vector, bound by cube. </return>
		/// </summary>
		public FVector BoundToCube(float radius)
			=> E_FVector_BoundToCube(this, radius);
		
		
		/// <summary>
		/// <para>Compute pushout of a box from a plane. </para>
		/// <param name="Normal">The plane normal. </param>
		/// <param name="Size">The size of the box. </param>
		/// <return>Pushout required. </return>
		/// </summary>
		public float BoxPushOut(FVector normal, FVector size)
			=> E_FVector_BoxPushOut(this, normal, size);
		
		
		/// <summary>
		/// <para>See if two normal vectors are coincident (nearly parallel and point in the same direction). </para>
		/// <param name="Normal1">First normalized vector. </param>
		/// <param name="Normal2">Second normalized vector. </param>
		/// <param name="ParallelCosineThreshold">Normals are coincident if dot product (cosine of angle between them) is greater than or equal to this. For example: cos(1.0 degrees). </param>
		/// <return>true if vectors are coincident (nearly parallel and point in the same direction), false otherwise. </return>
		/// </summary>
		public bool Coincident(FVector normal1, FVector normal2, float parallelCosineThreshold)
			=> E_FVector_Coincident(this, normal1, normal2, parallelCosineThreshold);
		
		
		/// <summary>
		/// <para>Gets a specific component of the vector. </para>
		/// <param name="Index">The index of the component required. </param>
		/// <return>Reference to the specified component. </return>
		/// </summary>
		public float Component(int index)
			=> E_FVector_Component(this, index);
		
		
		/// <summary>
		/// <para>Gets the component-wise max of two vectors. </para>
		/// </summary>
		public FVector ComponentMax(FVector other)
			=> E_FVector_ComponentMax(this, other);
		
		
		/// <summary>
		/// <para>Gets the component-wise min of two vectors. </para>
		/// </summary>
		public FVector ComponentMin(FVector other)
			=> E_FVector_ComponentMin(this, other);
		
		
		/// <summary>
		/// <para>Utility to check if there are any non-finite values (NaN or Inf) in this vector. </para>
		/// <return>true if there are any non-finite values in this vector, false otherwise. </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FVector_ContainsNaN(this);
		
		
		/// <summary>
		/// <para>See if two planes are coplanar. They are coplanar if the normals are nearly parallel and the planes include the same set of points. </para>
		/// <param name="Base1">The base point in the first plane. </param>
		/// <param name="Normal1">The normal of the first plane. </param>
		/// <param name="Base2">The base point in the second plane. </param>
		/// <param name="Normal2">The normal of the second plane. </param>
		/// <param name="ParallelCosineThreshold">Normals are parallel if absolute value of dot product is greater than or equal to this. </param>
		/// <return>true if the planes are coplanar, false otherwise. </return>
		/// </summary>
		public bool Coplanar(FVector base1, FVector normal1, FVector base2, FVector normal2, float parallelCosineThreshold)
			=> E_FVector_Coplanar(this, base1, normal1, base2, normal2, parallelCosineThreshold);
		
		
		/// <summary>
		/// <para>Returns the cosine of the angle between this vector and another projected onto the XY plane (no Z). </para>
		/// <param name="B">the other vector to find the 2D cosine of the angle with. </param>
		/// <return>The cosine. </return>
		/// </summary>
		public float CosineAngle2D(FVector b)
			=> E_FVector_CosineAngle2D(this, b);
		
		
		/// <summary>
		/// <para>Create an orthonormal basis from a basis with at least two orthogonal vectors. </para>
		/// <para>It may change the directions of the X and Y axes to make the basis orthogonal, </para>
		/// <para>but it won't change the direction of the Z axis. </para>
		/// <para>All axes will be normalized. </para>
		/// <param name="XAxis">The input basis' XAxis, and upon return the orthonormal basis' XAxis. </param>
		/// <param name="YAxis">The input basis' YAxis, and upon return the orthonormal basis' YAxis. </param>
		/// <param name="ZAxis">The input basis' ZAxis, and upon return the orthonormal basis' ZAxis. </param>
		/// </summary>
		public void CreateOrthonormalBasis(FVector xAxis, FVector yAxis, FVector zAxis)
			=> E_FVector_CreateOrthonormalBasis(this, xAxis, yAxis, zAxis);
		
		
		/// <summary>
		/// <para>Calculate the cross product of two vectors. </para>
		/// <param name="A">The first vector. </param>
		/// <param name="B">The second vector. </param>
		/// <return>The cross product. </return>
		/// </summary>
		public FVector CrossProduct(FVector a, FVector b)
			=> E_FVector_CrossProduct(this, a, b);
		
		
		/// <summary>
		/// <para>Converts a vector containing degree values to a vector containing radian values. </para>
		/// <param name="DegVector">Vector containing degree values </param>
		/// <return>Vector containing radian values </return>
		/// </summary>
		public FVector DegreesToRadians(FVector degVector)
			=> E_FVector_DegreesToRadians(this, degVector);
		
		public void DiagnosticCheckNaN()
			=> E_FVector_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// <para>Euclidean distance between two points. </para>
		/// <param name="V1">The first point. </param>
		/// <param name="V2">The second point. </param>
		/// <return>The distance between two points. </return>
		/// </summary>
		public float Dist(FVector v1, FVector v2)
			=> E_FVector_Dist(this, v1, v2);
		
		public float Dist2D(FVector v1, FVector v2)
			=> E_FVector_Dist2D(this, v1, v2);
		
		public float Distance(FVector v1, FVector v2)
			=> E_FVector_Distance(this, v1, v2);
		
		
		/// <summary>
		/// <para>Squared distance between two points. </para>
		/// <param name="V1">The first point. </param>
		/// <param name="V2">The second point. </param>
		/// <return>The squared distance between two points. </return>
		/// </summary>
		public float DistSquared(FVector v1, FVector v2)
			=> E_FVector_DistSquared(this, v1, v2);
		
		public float DistSquared2D(FVector v1, FVector v2)
			=> E_FVector_DistSquared2D(this, v1, v2);
		
		
		/// <summary>
		/// <para>Squared distance between two points in the XY plane only. </para>
		/// <param name="V1">The first point. </param>
		/// <param name="V2">The second point. </param>
		/// <return>The squared distance between two points in the XY plane </return>
		/// </summary>
		public float DistSquaredXY(FVector v1, FVector v2)
			=> E_FVector_DistSquaredXY(this, v1, v2);
		
		
		/// <summary>
		/// <para>Euclidean distance between two points in the XY plane (ignoring Z). </para>
		/// <param name="V1">The first point. </param>
		/// <param name="V2">The second point. </param>
		/// <return>The distance between two points in the XY plane. </return>
		/// </summary>
		public float DistXY(FVector v1, FVector v2)
			=> E_FVector_DistXY(this, v1, v2);
		
		
		/// <summary>
		/// <para>Calculate the dot product of two vectors. </para>
		/// <param name="A">The first vector. </param>
		/// <param name="B">The second vector. </param>
		/// <return>The dot product. </return>
		/// </summary>
		public float DotProduct(FVector a, FVector b)
			=> E_FVector_DotProduct(this, a, b);
		
		
		/// <summary>
		/// <para>Check against another vector for equality, within specified error limits. </para>
		/// <param name="V">The vector to check against. </param>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if the vectors are equal within tolerance limits, false otherwise. </return>
		/// </summary>
		public bool Equals(FVector v, float tolerance)
			=> E_FVector_Equals(this, v, tolerance);
		
		
		/// <summary>
		/// <para>Generates a list of sample points on a Bezier curve defined by 2 points. </para>
		/// <param name="ControlPoints">Array of 4 FVectors (vert1, controlpoint1, controlpoint2, vert2). </param>
		/// <param name="NumPoints">Number of samples. </param>
		/// <param name="OutPoints">Receives the output samples. </param>
		/// <return>The path length. </return>
		/// </summary>
		public float EvaluateBezier(FVector controlPoints, int numPoints, TArray<FVector> outPoints)
			=> E_FVector_EvaluateBezier(this, controlPoints, numPoints, outPoints);
		
		
		/// <summary>
		/// <para>Find good arbitrary axis vectors to represent U and V axes of a plane, </para>
		/// <para>using this vector as the normal of the plane. </para>
		/// <param name="Axis1">Reference to first axis. </param>
		/// <param name="Axis2">Reference to second axis. </param>
		/// </summary>
		public void FindBestAxisVectors(FVector axis1, FVector axis2)
			=> E_FVector_FindBestAxisVectors(this, axis1, axis2);
		
		
		/// <summary>
		/// <para>Given a current set of cluster centers, a set of points, iterate N times to move clusters to be central. </para>
		/// <param name="Clusters">Reference to array of Clusters. </param>
		/// <param name="Points">Set of points. </param>
		/// <param name="NumIterations">Number of iterations. </param>
		/// <param name="NumConnectionsToBeValid">Sometimes you will have long strings that come off the mass of points </param>
		/// <para>which happen to have been chosen as Cluster starting points.  You want to be able to disregard those. </para>
		/// </summary>
		public void GenerateClusterCenters(TArray<FVector> clusters, TArray<FVector> points, int numIterations, int numConnectionsToBeValid)
			=> E_FVector_GenerateClusterCenters(this, clusters, points, numIterations, numConnectionsToBeValid);
		
		
		/// <summary>
		/// <para>Get a copy of this vector with absolute value of each component. </para>
		/// <return>A copy of this vector with absolute value of each component. </return>
		/// </summary>
		public FVector GetAbs()
			=> E_FVector_GetAbs(this);
		
		
		/// <summary>
		/// <para>Get the maximum absolute value of the vector's components. </para>
		/// <return>The maximum absolute value of the vector's components. </return>
		/// </summary>
		public float GetAbsMax()
			=> E_FVector_GetAbsMax(this);
		
		
		/// <summary>
		/// <para>Get the minimum absolute value of the vector's components. </para>
		/// <return>The minimum absolute value of the vector's components. </return>
		/// </summary>
		public float GetAbsMin()
			=> E_FVector_GetAbsMin(this);
		
		
		/// <summary>
		/// <para>Create a copy of this vector, with its maximum magnitude clamped to MaxSize. </para>
		/// </summary>
		public FVector GetClampedToMaxSize(float maxSize)
			=> E_FVector_GetClampedToMaxSize(this, maxSize);
		
		
		/// <summary>
		/// <para>Create a copy of this vector, with the maximum 2D magnitude clamped to MaxSize. Z is unchanged. </para>
		/// </summary>
		public FVector GetClampedToMaxSize2D(float maxSize)
			=> E_FVector_GetClampedToMaxSize2D(this, maxSize);
		
		
		/// <summary>
		/// <para>Create a copy of this vector, with its magnitude clamped between Min and Max. </para>
		/// </summary>
		public FVector GetClampedToSize(float min, float max)
			=> E_FVector_GetClampedToSize(this, min, max);
		
		
		/// <summary>
		/// <para>Create a copy of this vector, with the 2D magnitude clamped between Min and Max. Z is unchanged. </para>
		/// </summary>
		public FVector GetClampedToSize2D(float min, float max)
			=> E_FVector_GetClampedToSize2D(this, min, max);
		
		
		/// <summary>
		/// <para>Get the maximum value of the vector's components. </para>
		/// <return>The maximum value of the vector's components. </return>
		/// </summary>
		public float GetMax()
			=> E_FVector_GetMax(this);
		
		
		/// <summary>
		/// <para>Get the minimum value of the vector's components. </para>
		/// <return>The minimum value of the vector's components. </return>
		/// </summary>
		public float GetMin()
			=> E_FVector_GetMin(this);
		
		
		/// <summary>
		/// <para>Gets a normalized copy of the vector, checking it is safe to do so based on the length. </para>
		/// <para>Returns zero vector if vector length is too small to safely normalize. </para>
		/// <param name="Tolerance">Minimum squared vector length. </param>
		/// <return>A normalized copy if safe, (0,0,0) otherwise. </return>
		/// </summary>
		public FVector GetSafeNormal(float tolerance)
			=> E_FVector_GetSafeNormal(this, tolerance);
		
		
		/// <summary>
		/// <para>Gets a normalized copy of the 2D components of the vector, checking it is safe to do so. Z is set to zero. </para>
		/// <para>Returns zero vector if vector length is too small to normalize. </para>
		/// <param name="Tolerance">Minimum squared vector length. </param>
		/// <return>Normalized copy if safe, otherwise returns zero vector. </return>
		/// </summary>
		public FVector GetSafeNormal2D(float tolerance)
			=> E_FVector_GetSafeNormal2D(this, tolerance);
		
		
		/// <summary>
		/// <para>Get a copy of the vector as sign only. </para>
		/// <para>Each component is set to +1 or -1, with the sign of zero treated as +1. </para>
		/// <param name="A">copy of the vector with each component set to +1 or -1 </param>
		/// </summary>
		public FVector GetSignVector()
			=> E_FVector_GetSignVector(this);
		
		
		/// <summary>
		/// <para>Calculates normalized version of vector without checking for zero length. </para>
		/// <return>Normalized version of vector. </return>
		/// <para>@see GetSafeNormal() </para>
		/// </summary>
		public FVector GetUnsafeNormal()
			=> E_FVector_GetUnsafeNormal(this);
		
		
		/// <summary>
		/// <para>Calculates normalized 2D version of vector without checking for zero length. </para>
		/// <return>Normalized version of vector. </return>
		/// <para>@see GetSafeNormal2D() </para>
		/// </summary>
		public FVector GetUnsafeNormal2D()
			=> E_FVector_GetUnsafeNormal2D(this);
		
		
		/// <summary>
		/// <para>Gets a copy of this vector snapped to a grid. </para>
		/// <param name="GridSz">Grid dimension. </param>
		/// <return>A copy of this vector snapped to a grid. </return>
		/// <para>@see FMath::GridSnap() </para>
		/// </summary>
		public FVector GridSnap(float gridSz)
			=> E_FVector_GridSnap(this, gridSz);
		
		
		/// <summary>
		/// <para>Convert a direction vector into a 'heading' angle. </para>
		/// <return>Heading' angle between +/-PI. 0 is pointing down +X. </return>
		/// </summary>
		public float HeadingAngle()
			=> E_FVector_HeadingAngle(this);
		
		
		/// <summary>
		/// <para>Initialize this Vector based on an FString. The String is expected to contain X=, Y=, Z=. </para>
		/// <para>The FVector will be bogus when InitFromString returns false. </para>
		/// <param name="InSourceString">FString containing the vector values. </param>
		/// <return>true if the X,Y,Z values were read successfully; false otherwise. </return>
		/// </summary>
		public bool InitFromString(string inSourceString)
			=> E_FVector_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// <para>Checks whether vector is near to zero within a specified tolerance. </para>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if the vector is near to zero, false otherwise. </return>
		/// </summary>
		public bool IsNearlyZero(float tolerance)
			=> E_FVector_IsNearlyZero(this, tolerance);
		
		
		/// <summary>
		/// <para>Checks whether vector is normalized. </para>
		/// <return>true if normalized, false otherwise. </return>
		/// </summary>
		public bool IsNormalized()
			=> E_FVector_IsNormalized(this);
		
		
		/// <summary>
		/// <para>Check whether X, Y and Z are nearly equal. </para>
		/// <param name="Tolerance">Specified Tolerance. </param>
		/// <return>true if X == Y == Z within the specified tolerance. </return>
		/// </summary>
		public bool IsUniform(float tolerance)
			=> E_FVector_IsUniform(this, tolerance);
		
		
		/// <summary>
		/// <para>Check if the vector is of unit length, with specified tolerance. </para>
		/// <param name="LengthSquaredTolerance">Tolerance against squared length. </param>
		/// <return>true if the vector is a unit vector within the specified tolerance. </return>
		/// </summary>
		public bool IsUnit(float lengthSquaredTolerance)
			=> E_FVector_IsUnit(this, lengthSquaredTolerance);
		
		
		/// <summary>
		/// <para>Checks whether all components of the vector are exactly zero. </para>
		/// <return>true if the vector is exactly zero, false otherwise. </return>
		/// </summary>
		public bool IsZero()
			=> E_FVector_IsZero(this);
		
		
		/// <summary>
		/// <para>Mirrors a vector about a plane. </para>
		/// <param name="Plane">Plane to mirror about. </param>
		/// <return>Mirrored vector. </return>
		/// </summary>
		public FVector MirrorByPlane(FPlane plane)
			=> E_FVector_MirrorByPlane(this, plane);
		
		
		/// <summary>
		/// <para>Mirror a vector about a normal vector. </para>
		/// <param name="MirrorNormal">Normal vector to mirror about. </param>
		/// <return>Mirrored vector. </return>
		/// </summary>
		public FVector MirrorByVector(FVector mirrorNormal)
			=> E_FVector_MirrorByVector(this, mirrorNormal);
		
		
		/// <summary>
		/// <para>Normalize this vector in-place if it is larger than a given tolerance. Leaves it unchanged if not. </para>
		/// <param name="Tolerance">Minimum squared length of vector for normalization. </param>
		/// <return>true if the vector was normalized correctly, false otherwise. </return>
		/// </summary>
		public bool Normalize(float tolerance)
			=> E_FVector_Normalize(this, tolerance);
		
		
		/// <summary>
		/// <para>See if two normal vectors are nearly orthogonal (perpendicular), meaning the angle between them is close to 90 degrees. </para>
		/// <param name="Normal1">First normalized vector. </param>
		/// <param name="Normal2">Second normalized vector. </param>
		/// <param name="OrthogonalCosineThreshold">Normals are orthogonal if absolute value of dot product (cosine of angle between them) is less than or equal to this. For example: cos(89.0 degrees). </param>
		/// <return>true if vectors are orthogonal (perpendicular), false otherwise. </return>
		/// </summary>
		public bool Orthogonal(FVector normal1, FVector normal2, float orthogonalCosineThreshold)
			=> E_FVector_Orthogonal(this, normal1, normal2, orthogonalCosineThreshold);
		
		
		/// <summary>
		/// <para>See if two normal vectors are nearly parallel, meaning the angle between them is close to 0 degrees. </para>
		/// <param name="Normal1">First normalized vector. </param>
		/// <param name="Normal1">Second normalized vector. </param>
		/// <param name="ParallelCosineThreshold">Normals are parallel if absolute value of dot product (cosine of angle between them) is greater than or equal to this. For example: cos(1.0 degrees). </param>
		/// <return>true if vectors are nearly parallel, false otherwise. </return>
		/// </summary>
		public bool Parallel(FVector normal1, FVector normal2, float parallelCosineThreshold)
			=> E_FVector_Parallel(this, normal1, normal2, parallelCosineThreshold);
		
		
		/// <summary>
		/// <para>Calculate the signed distance (in the direction of the normal) between a point and a plane. </para>
		/// <param name="Point">The Point we are checking. </param>
		/// <param name="PlaneBase">The Base Point in the plane. </param>
		/// <param name="PlaneNormal">The Normal of the plane (assumed to be unit length). </param>
		/// <return>Signed distance between point and plane. </return>
		/// </summary>
		public float PointPlaneDist(FVector point, FVector planeBase, FVector planeNormal)
			=> E_FVector_PointPlaneDist(this, point, planeBase, planeNormal);
		
		
		/// <summary>
		/// <para>Calculate the projection of a point on the given plane. </para>
		/// <param name="Point">The point to project onto the plane </param>
		/// <param name="Plane">The plane </param>
		/// <return>Projection of Point onto Plane </return>
		/// </summary>
		public FVector PointPlaneProject(FVector point, FPlane plane)
			=> E_FVector_PointPlaneProject(this, point, plane);
		
		
		/// <summary>
		/// <para>Calculate the projection of a point on the plane defined by counter-clockwise (CCW) points A,B,C. </para>
		/// <param name="Point">The point to project onto the plane </param>
		/// <param name="A">1st of three points in CCW order defining the plane </param>
		/// <param name="B">2nd of three points in CCW order defining the plane </param>
		/// <param name="C">3rd of three points in CCW order defining the plane </param>
		/// <return>Projection of Point onto plane ABC </return>
		/// </summary>
		public FVector PointPlaneProject(FVector point, FVector a, FVector b, FVector c)
			=> E_FVector_PointPlaneProject_o1(this, point, a, b, c);
		
		
		/// <summary>
		/// <para>Calculate the projection of a point on the plane defined by PlaneBase and PlaneNormal. </para>
		/// <param name="Point">The point to project onto the plane </param>
		/// <param name="PlaneBase">Point on the plane </param>
		/// <param name="PlaneNorm">Normal of the plane (assumed to be unit length). </param>
		/// <return>Projection of Point onto plane </return>
		/// </summary>
		public FVector PointPlaneProject(FVector point, FVector planeBase, FVector planeNormal)
			=> E_FVector_PointPlaneProject_o2(this, point, planeBase, planeNormal);
		
		
		/// <summary>
		/// <para>Compare two points and see if they're within specified distance. </para>
		/// <param name="Point1">First vector. </param>
		/// <param name="Point2">Second vector. </param>
		/// <param name="Dist">Specified distance. </param>
		/// <return>Whether two points are within the specified distance. Uses fast distance approximation (linear per-component distance). </return>
		/// </summary>
		public bool PointsAreNear(FVector point1, FVector point2, float dist)
			=> E_FVector_PointsAreNear(this, point1, point2, dist);
		
		
		/// <summary>
		/// <para>Compare two points and see if they're the same, using a threshold. </para>
		/// <param name="P">First vector. </param>
		/// <param name="Q">Second vector. </param>
		/// <return>Whether points are the same within a threshold. Uses fast distance approximation (linear per-component distance). </return>
		/// </summary>
		public bool PointsAreSame(FVector p, FVector q)
			=> E_FVector_PointsAreSame(this, p, q);
		
		
		/// <summary>
		/// <para>Projects 2D components of vector based on Z. </para>
		/// <return>Projected version of vector based on Z. </return>
		/// </summary>
		public FVector Projection()
			=> E_FVector_Projection(this);
		
		
		/// <summary>
		/// <para>Gets a copy of this vector projected onto the input vector. </para>
		/// <param name="A">Vector to project onto, does not assume it is normalized. </param>
		/// <return>Projected vector. </return>
		/// </summary>
		public FVector ProjectOnTo(FVector a)
			=> E_FVector_ProjectOnTo(this, a);
		
		
		/// <summary>
		/// <para>Gets a copy of this vector projected onto the input vector, which is assumed to be unit length. </para>
		/// <param name="Normal">Vector to project onto (assumed to be unit length). </param>
		/// <return>Projected vector. </return>
		/// </summary>
		public FVector ProjectOnToNormal(FVector normal)
			=> E_FVector_ProjectOnToNormal(this, normal);
		
		
		/// <summary>
		/// <para>Converts a vector containing radian values to a vector containing degree values. </para>
		/// <param name="RadVector">Vector containing radian values </param>
		/// <return>Vector  containing degree values </return>
		/// </summary>
		public FVector RadiansToDegrees(FVector radVector)
			=> E_FVector_RadiansToDegrees(this, radVector);
		
		
		/// <summary>
		/// <para>Gets the reciprocal of this vector, avoiding division by zero. </para>
		/// <para>Zero components are set to BIG_NUMBER. </para>
		/// <return>Reciprocal of this vector. </return>
		/// </summary>
		public FVector Reciprocal()
			=> E_FVector_Reciprocal(this);
		
		
		/// <summary>
		/// <para>Rotates around Axis (assumes Axis.Size() == 1). </para>
		/// <param name="Angle">Angle to rotate (in degrees). </param>
		/// <param name="Axis">Axis to rotate around. </param>
		/// <return>Rotated Vector. </return>
		/// </summary>
		public FVector RotateAngleAxis(float angleDeg, FVector axis)
			=> E_FVector_RotateAngleAxis(this, angleDeg, axis);
		
		
		/// <summary>
		/// <para>Return the FRotator orientation corresponding to the direction in which the vector points. </para>
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets Roll to zero because the roll can't be determined from a vector. </para>
		/// <para>@note Identical to 'ToOrientationRotator()' and preserved for legacy reasons. </para>
		/// <return>FRotator from the Vector's direction. </return>
		/// <para>@see ToOrientationRotator(), ToOrientationQuat() </para>
		/// </summary>
		public FRotator Rotation()
			=> E_FVector_Rotation(this);
		
		
		/// <summary>
		/// <para>Set the values of the vector directly. </para>
		/// <param name="InX">New X coordinate. </param>
		/// <param name="InY">New Y coordinate. </param>
		/// <param name="InZ">New Z coordinate. </param>
		/// </summary>
		public void Set(float inX, float inY, float inZ)
			=> E_FVector_Set(this, inX, inY, inZ);
		
		
		/// <summary>
		/// <para>Get the length (magnitude) of this vector. </para>
		/// <return>The length of this vector. </return>
		/// </summary>
		public float Size()
			=> E_FVector_Size(this);
		
		
		/// <summary>
		/// <para>Get the length of the 2D components of this vector. </para>
		/// <return>The 2D length of this vector. </return>
		/// </summary>
		public float Size2D()
			=> E_FVector_Size2D(this);
		
		
		/// <summary>
		/// <para>Get the squared length of this vector. </para>
		/// <return>The squared length of this vector. </return>
		/// </summary>
		public float SizeSquared()
			=> E_FVector_SizeSquared(this);
		
		
		/// <summary>
		/// <para>Get the squared length of the 2D components of this vector. </para>
		/// <return>The squared 2D length of this vector. </return>
		/// </summary>
		public float SizeSquared2D()
			=> E_FVector_SizeSquared2D(this);
		
		
		/// <summary>
		/// <para>Get a short textural representation of this vector, for compact readable logging. </para>
		/// </summary>
		public string ToCompactString()
			=> E_FVector_ToCompactString(this);
		
		
		/// <summary>
		/// <para>Get a short locale aware textural representation of this vector, for compact readable logging. </para>
		/// </summary>
		public string ToCompactText()
			=> E_FVector_ToCompactText(this);
		
		
		/// <summary>
		/// <para>Util to convert this vector into a unit direction vector and its original length. </para>
		/// <param name="OutDir">Reference passed in to store unit direction vector. </param>
		/// <param name="OutLength">Reference passed in to store length of the vector. </param>
		/// </summary>
		public void ToDirectionAndLength(FVector outDir, float outLength)
			=> E_FVector_ToDirectionAndLength(this, outDir, outLength);
		
		
		/// <summary>
		/// <para>Return the Quaternion orientation corresponding to the direction in which the vector points. </para>
		/// <para>Similar to the FRotator version, returns a result without roll such that it preserves the up vector. </para>
		/// <para>@note If you don't care about preserving the up vector and just want the most direct rotation, you can use the faster </para>
		/// <para>'FQuat::FindBetweenVectors(FVector::ForwardVector, YourVector)' or 'FQuat::FindBetweenNormals(...)' if you know the vector is of unit length. </para>
		/// <return>Quaternion from the Vector's direction, without any roll. </return>
		/// <para>@see ToOrientationRotator(), FQuat::FindBetweenVectors() </para>
		/// </summary>
		public FQuat ToOrientationQuat()
			=> E_FVector_ToOrientationQuat(this);
		
		
		/// <summary>
		/// <para>Return the FRotator orientation corresponding to the direction in which the vector points. </para>
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets Roll to zero because the roll can't be determined from a vector. </para>
		/// <return>FRotator from the Vector's direction, without any roll. </return>
		/// <para>@see ToOrientationQuat() </para>
		/// </summary>
		public FRotator ToOrientationRotator()
			=> E_FVector_ToOrientationRotator(this);
		
		
		/// <summary>
		/// <para>Get a textual representation of this vector. </para>
		/// <return>A string describing the vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FVector_ToString(this);
		
		
		/// <summary>
		/// <para>Get a locale aware textual representation of this vector. </para>
		/// <return>A string describing the vector. </return>
		/// </summary>
		public string ToText()
			=> E_FVector_ToText(this);
		
		
		/// <summary>
		/// <para>Triple product of three vectors: X dot (Y cross Z). </para>
		/// <param name="X">The first vector. </param>
		/// <param name="Y">The second vector. </param>
		/// <param name="Z">The third vector. </param>
		/// <return>The triple product: X dot (Y cross Z). </return>
		/// </summary>
		public float Triple(FVector x, FVector y, FVector z)
			=> E_FVector_Triple(this, x, y, z);
		
		
		/// <summary>
		/// <para>Converts a Cartesian unit vector into spherical coordinates on the unit sphere. </para>
		/// <return>Output Theta will be in the range [0, PI], and output Phi will be in the range [-PI, PI]. </return>
		/// </summary>
		public FVector2D UnitCartesianToSpherical()
			=> E_FVector_UnitCartesianToSpherical(this);
		
		
		/// <summary>
		/// <para>When this vector contains Euler angles (degrees), ensure that angles are between +/-180 </para>
		/// </summary>
		public void UnwindEuler()
			=> E_FVector_UnwindEuler(this);
		
		
		/// <summary>
		/// <para>Calculate the projection of a vector on the plane defined by PlaneNormal. </para>
		/// <param name="V">The vector to project onto the plane. </param>
		/// <param name="PlaneNormal">Normal of the plane (assumed to be unit length). </param>
		/// <return>Projection of V onto plane. </return>
		/// </summary>
		public FVector VectorPlaneProject(FVector v, FVector planeNormal)
			=> E_FVector_VectorPlaneProject(this, v, planeNormal);
		
		#endregion
		
		public static implicit operator IntPtr(FVector self)
		{
			return self.NativePointer;
		}

		public static implicit operator FVector(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector(Adress, false);
		}}}
