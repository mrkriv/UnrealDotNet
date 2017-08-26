using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial struct FVector2D
	{
		
		
		/// <summary>
		/// Vector's X component.
		/// </summary>
		public float X { get; set; }
		
		/// <summary>
		/// Vector's Y component.
		/// </summary>
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
		
		/// <summary>
		/// 
		/// Calculates the dot product of two vectors.
		/// 
		/// @param A The first vector.
		/// @param B The second vector.
		/// @return The dot product.
		/// 
		/// </summary>
		public float DotProduct(FVector2D A, FVector2D B)
		{
			return E_FVector2D_DotProduct(this, A, B);
		}

		
		/// <summary>
		/// 
		/// Checks for equality with error-tolerant comparison.
		/// 
		/// @param V The vector to compare.
		/// @param Tolerance Error tolerance.
		/// @return true if the vectors are equal within specified tolerance, otherwise false.
		/// 
		/// </summary>
		public bool Equals(FVector2D V, float Tolerance)
		{
			return E_FVector2D_Equals(this, V, Tolerance);
		}

		
		/// <summary>
		/// 
		/// Set the values of the vector directly.
		/// 
		/// @param InX New X coordinate.
		/// @param InY New Y coordinate.
		/// 
		/// </summary>
		public void Set(float InX, float InY)
		{
			E_FVector2D_Set(this, InX, InY);
		}

		
		/// <summary>
		/// 
		/// Get the maximum value of the vector's components.
		/// 
		/// @return The maximum value of the vector's components.
		/// 
		/// </summary>
		public float GetMax()
		{
			return E_FVector2D_GetMax(this);
		}

		
		/// <summary>
		/// 
		/// Normalize this vector in-place if it is large enough, set it to (0,0) otherwise.
		/// 
		/// @param Tolerance Minimum squared length of vector for normalization.
		/// @see GetSafeNormal()
		/// 
		/// </summary>
		public void Normalize(float Tolerance)
		{
			E_FVector2D_Normalize(this, Tolerance);
		}

		
		/// <summary>
		/// 
		/// Checks whether vector is near to zero within a specified tolerance.
		/// 
		/// @param Tolerance Error tolerance.
		/// @return true if vector is in tolerance to zero, otherwise false.
		/// 
		/// </summary>
		public bool IsNearlyZero(float Tolerance)
		{
			return E_FVector2D_IsNearlyZero(this, Tolerance);
		}

		
		/// <summary>
		/// 
		/// Util to convert this vector into a unit direction vector and its original length.
		/// 
		/// @param OutDir Reference passed in to store unit direction vector.
		/// @param OutLength Reference passed in to store length of the vector.
		/// 
		/// </summary>
		public void ToDirectionAndLength(FVector2D OutDir, float OutLength)
		{
			E_FVector2D_ToDirectionAndLength(this, OutDir, OutLength);
		}

		
		/// <summary>
		/// 
		/// Checks whether all components of the vector are exactly zero.
		/// 
		/// @return true if vector is exactly zero, otherwise false.
		/// 
		/// </summary>
		public bool IsZero()
		{
			return E_FVector2D_IsZero(this);
		}

		
		/// <summary>
		/// 
		/// Creates a copy of this vector with both axes clamped to the given range.
		/// @return New vector with clamped axes.
		/// 
		/// </summary>
		public FVector2D ClampAxes(float MinAxisVal, float MaxAxisVal)
		{
			return E_FVector2D_ClampAxes(this, MinAxisVal, MaxAxisVal);
		}

		public void DiagnosticCheckNaN()
		{
			E_FVector2D_DiagnosticCheckNaN(this);
		}

		
		/// <summary>
		/// Converts spherical coordinates on the unit sphere into a Cartesian unit length vector.
		/// </summary>
		public FVector SphericalToUnitCartesian()
		{
			return E_FVector2D_SphericalToUnitCartesian(this);
		}

		#endregion
		
	}}
