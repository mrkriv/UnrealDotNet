using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FBox
	{
		
		public FVector Min { get; set; }
		public FVector Max { get; set; }
		public byte IsValid { get; set; }
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FBox_ComputeSquaredDistanceToPoint(FBox Self, FVector Point);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FBox_GetCenter(FBox Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FBox_GetCenterAndExtents(FBox Self, FVector center, FVector Extents);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FBox_GetClosestPointTo(FBox Self, FVector Point);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FBox_GetVolume(FBox Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FBox_Init(FBox Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FBox E_FBox_InverseTransformBy(FBox Self, FTransform M);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FBox_IsInside(FBox Self, FVector In);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FBox E_FBox_BuildAABB(FBox Self, FVector Origin, FVector Extent);
		
		#endregion
		
		#region ExternMethods
		public float ComputeSquaredDistanceToPoint(FVector Point)
		{
			return E_FBox_ComputeSquaredDistanceToPoint(this, Point);
		}

		public FVector GetCenter()
		{
			return E_FBox_GetCenter(this);
		}

		public void GetCenterAndExtents(FVector center, FVector Extents)
		{
			E_FBox_GetCenterAndExtents(this, center, Extents);
		}

		public FVector GetClosestPointTo(FVector Point)
		{
			return E_FBox_GetClosestPointTo(this, Point);
		}

		public float GetVolume()
		{
			return E_FBox_GetVolume(this);
		}

		public void Init()
		{
			E_FBox_Init(this);
		}

		public FBox InverseTransformBy(FTransform M)
		{
			return E_FBox_InverseTransformBy(this, M);
		}

		public bool IsInside(FVector In)
		{
			return E_FBox_IsInside(this, In);
		}

		public FBox BuildAABB(FVector Origin, FVector Extent)
		{
			return E_FBox_BuildAABB(this, Origin, Extent);
		}

		#endregion
		
	}}
