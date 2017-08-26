using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FVector2D
	{
		
		public float X { get; set; }
		public float Y { get; set; }
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector2D_DotProduct(FVector2D Self, FVector2D A, FVector2D B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector2D_Equals(FVector2D Self, FVector2D V, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector2D_Set(FVector2D Self, float InX, float InY);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector2D_GetMax(FVector2D Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector2D_Normalize(FVector2D Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector2D_IsNearlyZero(FVector2D Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector2D_ToDirectionAndLength(FVector2D Self, FVector2D OutDir, float OutLength);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector2D_IsZero(FVector2D Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector2D E_FVector2D_ClampAxes(FVector2D Self, float MinAxisVal, float MaxAxisVal);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FVector2D_DiagnosticCheckNaN(FVector2D Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FVector2D_SphericalToUnitCartesian(FVector2D Self);
		
		#endregion
		
		#region ExternMethods
		public float DotProduct(FVector2D A, FVector2D B)
		{
			return E_FVector2D_DotProduct(this, A, B);
		}

		public bool Equals(FVector2D V, float Tolerance)
		{
			return E_FVector2D_Equals(this, V, Tolerance);
		}

		public void Set(float InX, float InY)
		{
			E_FVector2D_Set(this, InX, InY);
		}

		public float GetMax()
		{
			return E_FVector2D_GetMax(this);
		}

		public void Normalize(float Tolerance)
		{
			E_FVector2D_Normalize(this, Tolerance);
		}

		public bool IsNearlyZero(float Tolerance)
		{
			return E_FVector2D_IsNearlyZero(this, Tolerance);
		}

		public void ToDirectionAndLength(FVector2D OutDir, float OutLength)
		{
			E_FVector2D_ToDirectionAndLength(this, OutDir, OutLength);
		}

		public bool IsZero()
		{
			return E_FVector2D_IsZero(this);
		}

		public FVector2D ClampAxes(float MinAxisVal, float MaxAxisVal)
		{
			return E_FVector2D_ClampAxes(this, MinAxisVal, MaxAxisVal);
		}

		public void DiagnosticCheckNaN()
		{
			E_FVector2D_DiagnosticCheckNaN(this);
		}

		public FVector SphericalToUnitCartesian()
		{
			return E_FVector2D_SphericalToUnitCartesian(this);
		}

		#endregion
		
	}}
