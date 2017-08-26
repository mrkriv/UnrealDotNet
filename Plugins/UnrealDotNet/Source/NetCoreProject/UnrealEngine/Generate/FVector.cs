using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FVector
	{
		
		public float X { get; set; }
		public float Y { get; set; }
		public float Z { get; set; }
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FVector_CrossProduct(FVector Self, FVector A, FVector B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector_DotProduct(FVector Self, FVector A, FVector B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_Equals(FVector Self, FVector V, float Tolerance);
		
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
		private static extern void E_FVector_ToDirectionAndLength(FVector Self, FVector OutDir, float OutLength);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FVector_GridSnap(FVector Self, float GridSz);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FVector_GetClampedToSize(FVector Self, float Min, float Max);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector_AddBounded(FVector Self, FVector V, float Radius);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FVector_RotateAngleAxis(FVector Self, float AngleDeg, FVector Axis);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector_CosineAngle2D(FVector Self, FVector B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_FVector_ToOrientationRotator(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FVector_ToOrientationQuat(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector_FindBestAxisVectors(FVector Self, FVector Axis1, FVector Axis2);
		
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
		private static extern FVector2D E_FVector_UnitCartesianToSpherical(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector_CreateOrthonormalBasis(FVector Self, FVector XAxis, FVector YAxis, FVector ZAxis);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_PointsAreSame(FVector Self, FVector P, FVector Q);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_PointsAreNear(FVector Self, FVector Point1, FVector Point2, float Dist);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector_PointPlaneDist(FVector Self, FVector Point, FVector PlaneBase, FVector PlaneNormal);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector_Coplanar(FVector Self, FVector Base1, FVector Normal1, FVector Base2, FVector Normal2, float ParallelCosineThreshold);
		
		#endregion
		
		#region ExternMethods
		public FVector CrossProduct(FVector A, FVector B)
		{
			return E_FVector_CrossProduct(this, A, B);
		}

		public float DotProduct(FVector A, FVector B)
		{
			return E_FVector_DotProduct(this, A, B);
		}

		public bool Equals(FVector V, float Tolerance)
		{
			return E_FVector_Equals(this, V, Tolerance);
		}

		public bool AllComponentsEqual(float Tolerance)
		{
			return E_FVector_AllComponentsEqual(this, Tolerance);
		}

		public void Set(float InX, float InY, float InZ)
		{
			E_FVector_Set(this, InX, InY, InZ);
		}

		public float GetMax()
		{
			return E_FVector_GetMax(this);
		}

		public bool IsZero()
		{
			return E_FVector_IsZero(this);
		}

		public bool Normalize(float Tolerance)
		{
			return E_FVector_Normalize(this, Tolerance);
		}

		public void ToDirectionAndLength(FVector OutDir, float OutLength)
		{
			E_FVector_ToDirectionAndLength(this, OutDir, OutLength);
		}

		public FVector GridSnap(float GridSz)
		{
			return E_FVector_GridSnap(this, GridSz);
		}

		public FVector GetClampedToSize(float Min, float Max)
		{
			return E_FVector_GetClampedToSize(this, Min, Max);
		}

		public void AddBounded(FVector V, float Radius)
		{
			E_FVector_AddBounded(this, V, Radius);
		}

		public FVector RotateAngleAxis(float AngleDeg, FVector Axis)
		{
			return E_FVector_RotateAngleAxis(this, AngleDeg, Axis);
		}

		public float CosineAngle2D(FVector B)
		{
			return E_FVector_CosineAngle2D(this, B);
		}

		public FRotator ToOrientationRotator()
		{
			return E_FVector_ToOrientationRotator(this);
		}

		public FQuat ToOrientationQuat()
		{
			return E_FVector_ToOrientationQuat(this);
		}

		public void FindBestAxisVectors(FVector Axis1, FVector Axis2)
		{
			E_FVector_FindBestAxisVectors(this, Axis1, Axis2);
		}

		public void UnwindEuler()
		{
			E_FVector_UnwindEuler(this);
		}

		public FVector2D UnitCartesianToSpherical()
		{
			return E_FVector_UnitCartesianToSpherical(this);
		}

		public void CreateOrthonormalBasis(FVector XAxis, FVector YAxis, FVector ZAxis)
		{
			E_FVector_CreateOrthonormalBasis(this, XAxis, YAxis, ZAxis);
		}

		public bool PointsAreSame(FVector P, FVector Q)
		{
			return E_FVector_PointsAreSame(this, P, Q);
		}

		public bool PointsAreNear(FVector Point1, FVector Point2, float Dist)
		{
			return E_FVector_PointsAreNear(this, Point1, Point2, Dist);
		}

		public float PointPlaneDist(FVector Point, FVector PlaneBase, FVector PlaneNormal)
		{
			return E_FVector_PointPlaneDist(this, Point, PlaneBase, PlaneNormal);
		}

		public bool Coplanar(FVector Base1, FVector Normal1, FVector Base2, FVector Normal2, float ParallelCosineThreshold)
		{
			return E_FVector_Coplanar(this, Base1, Normal1, Base2, Normal2, ParallelCosineThreshold);
		}

		#endregion
		
	}}
