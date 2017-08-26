using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FBox2D
	{
		
		public FVector2D Min { get; set; }
		public FVector2D Max { get; set; }
		public bool bIsValid { get; set; }
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FBox2D_ComputeSquaredDistanceToPoint(FBox2D Self, FVector2D Point);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FBox2D E_FBox2D_ExpandBy(FBox2D Self, float W);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FBox2D_GetArea(FBox2D Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector2D E_FBox2D_GetCenter(FBox2D Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FBox2D_GetCenterAndExtents(FBox2D Self, FVector2D center, FVector2D Extents);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector2D E_FBox2D_GetClosestPointTo(FBox2D Self, FVector2D Point);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FBox2D_Init(FBox2D Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FBox2D_IsInside(FBox2D Self, FVector2D TestPoint);
		
		#endregion
		
		#region ExternMethods
		public float ComputeSquaredDistanceToPoint(FVector2D Point)
		{
			return E_FBox2D_ComputeSquaredDistanceToPoint(this, Point);
		}

		public FBox2D ExpandBy(float W)
		{
			return E_FBox2D_ExpandBy(this, W);
		}

		public float GetArea()
		{
			return E_FBox2D_GetArea(this);
		}

		public FVector2D GetCenter()
		{
			return E_FBox2D_GetCenter(this);
		}

		public void GetCenterAndExtents(FVector2D center, FVector2D Extents)
		{
			E_FBox2D_GetCenterAndExtents(this, center, Extents);
		}

		public FVector2D GetClosestPointTo(FVector2D Point)
		{
			return E_FBox2D_GetClosestPointTo(this, Point);
		}

		public void Init()
		{
			E_FBox2D_Init(this);
		}

		public bool IsInside(FVector2D TestPoint)
		{
			return E_FBox2D_IsInside(this, TestPoint);
		}

		#endregion
		
	}}
