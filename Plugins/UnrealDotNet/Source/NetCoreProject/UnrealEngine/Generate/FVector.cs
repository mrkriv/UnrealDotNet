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
		private static extern FVector E_CrossProduct(FVector Self, FVector A, FVector B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_DotProduct(FVector Self, FVector A, FVector B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Equals(FVector Self, FVector V, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_AllComponentsEqual(FVector Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Set(FVector Self, float InX, float InY, float InZ);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_GetMax(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_IsZero(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Normalize(FVector Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_ToDirectionAndLength(FVector Self, FVector OutDir, float OutLength);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_GridSnap(FVector Self, float GridSz);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_GetClampedToSize(FVector Self, float Min, float Max);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_AddBounded(FVector Self, FVector V, float Radius);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_RotateAngleAxis(FVector Self, float AngleDeg, FVector Axis);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_CosineAngle2D(FVector Self, FVector B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FindBestAxisVectors(FVector Self, FVector Axis1, FVector Axis2);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_UnwindEuler(FVector Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_CreateOrthonormalBasis(FVector Self, FVector XAxis, FVector YAxis, FVector ZAxis);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PointsAreSame(FVector Self, FVector P, FVector Q);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_PointsAreNear(FVector Self, FVector Point1, FVector Point2, float Dist);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_PointPlaneDist(FVector Self, FVector Point, FVector PlaneBase, FVector PlaneNormal);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_Coplanar(FVector Self, FVector Base1, FVector Normal1, FVector Base2, FVector Normal2, float ParallelCosineThreshold);
		
		#endregion
		
		#region ExternMethods
		public FVector CrossProduct(FVector A, FVector B)
		{
			return E_CrossProduct(this, A, B);
		}

		public float DotProduct(FVector A, FVector B)
		{
			return E_DotProduct(this, A, B);
		}

		public bool Equals(FVector V, float Tolerance)
		{
			return E_Equals(this, V, Tolerance);
		}

		public bool AllComponentsEqual(float Tolerance)
		{
			return E_AllComponentsEqual(this, Tolerance);
		}

		public void Set(float InX, float InY, float InZ)
		{
			E_Set(this, InX, InY, InZ);
		}

		public float GetMax()
		{
			return E_GetMax(this);
		}

		public bool IsZero()
		{
			return E_IsZero(this);
		}

		public bool Normalize(float Tolerance)
		{
			return E_Normalize(this, Tolerance);
		}

		public void ToDirectionAndLength(FVector OutDir, float OutLength)
		{
			E_ToDirectionAndLength(this, OutDir, OutLength);
		}

		public FVector GridSnap(float GridSz)
		{
			return E_GridSnap(this, GridSz);
		}

		public FVector GetClampedToSize(float Min, float Max)
		{
			return E_GetClampedToSize(this, Min, Max);
		}

		public void AddBounded(FVector V, float Radius)
		{
			E_AddBounded(this, V, Radius);
		}

		public FVector RotateAngleAxis(float AngleDeg, FVector Axis)
		{
			return E_RotateAngleAxis(this, AngleDeg, Axis);
		}

		public float CosineAngle2D(FVector B)
		{
			return E_CosineAngle2D(this, B);
		}

		public void FindBestAxisVectors(FVector Axis1, FVector Axis2)
		{
			E_FindBestAxisVectors(this, Axis1, Axis2);
		}

		public void UnwindEuler()
		{
			E_UnwindEuler(this);
		}

		public void CreateOrthonormalBasis(FVector XAxis, FVector YAxis, FVector ZAxis)
		{
			E_CreateOrthonormalBasis(this, XAxis, YAxis, ZAxis);
		}

		public bool PointsAreSame(FVector P, FVector Q)
		{
			return E_PointsAreSame(this, P, Q);
		}

		public bool PointsAreNear(FVector Point1, FVector Point2, float Dist)
		{
			return E_PointsAreNear(this, Point1, Point2, Dist);
		}

		public float PointPlaneDist(FVector Point, FVector PlaneBase, FVector PlaneNormal)
		{
			return E_PointPlaneDist(this, Point, PlaneBase, PlaneNormal);
		}

		public bool Coplanar(FVector Base1, FVector Normal1, FVector Base2, FVector Normal2, float ParallelCosineThreshold)
		{
			return E_Coplanar(this, Base1, Normal1, Base2, Normal2, ParallelCosineThreshold);
		}

		#endregion
		
	}}
