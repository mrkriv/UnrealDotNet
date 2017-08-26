using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FVector4
	{
		
		public float X { get; set; }
		public float Y { get; set; }
		public float Z { get; set; }
		public float W { get; set; }
		
		#region DLLInmport
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
		
		#region ExternMethods
		public bool Equals(FVector4 V, float Tolerance)
		{
			return E_FVector4_Equals(this, V, Tolerance);
		}

		public bool IsUnit3(float LengthSquaredTolerance)
		{
			return E_FVector4_IsUnit3(this, LengthSquaredTolerance);
		}

		public FRotator ToOrientationRotator()
		{
			return E_FVector4_ToOrientationRotator(this);
		}

		public FQuat ToOrientationQuat()
		{
			return E_FVector4_ToOrientationQuat(this);
		}

		public void Set(float InX, float InY, float InZ, float InW)
		{
			E_FVector4_Set(this, InX, InY, InZ, InW);
		}

		public float Size3()
		{
			return E_FVector4_Size3(this);
		}

		public bool ContainsNaN()
		{
			return E_FVector4_ContainsNaN(this);
		}

		public void FindBestAxisVectors3(FVector4 Axis1, FVector4 Axis2)
		{
			E_FVector4_FindBestAxisVectors3(this, Axis1, Axis2);
		}

		public void DiagnosticCheckNaN()
		{
			E_FVector4_DiagnosticCheckNaN(this);
		}

		#endregion
		
	}}
