using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A vector in 2-D space composed of components (X, Y) with floating point precision.
	/// </summary>
	public partial class FVector2D
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FVector2D()
		{
			NativePointer = E_CreateStruct_FVector2D();
			IsRef = false;
		}

		internal FVector2D(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FVector2D();
		
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
		private static extern float E_Struct_FVector2D_X_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FVector2D_X_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_FVector2D_Y_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FVector2D_Y_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_OP_FVector2D_p(FVector2D Self, IntPtr V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_OP_FVector2D_m(FVector2D Self, float Scale);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_OP_FVector2D_i(FVector2D Self, IntPtr V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FVector2D_DotProduct(FVector2D Self, IntPtr A, IntPtr B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FVector2D_Equals(FVector2D Self, IntPtr V, float Tolerance);
		
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
		private static extern void E_FVector2D_ToDirectionAndLength(FVector2D Self, IntPtr OutDir, float OutLength);
		
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
		private static extern IntPtr E_FVector2D_ClampAxes(FVector2D Self, float MinAxisVal, float MaxAxisVal);
		
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
		private static extern IntPtr E_FVector2D_SphericalToUnitCartesian(FVector2D Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Vector's X component.
		/// </summary>
		public float X
		{
			get => E_Struct_FVector2D_X_GET(NativePointer);
			set => E_Struct_FVector2D_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Vector's Y component.
		/// </summary>
		public float Y
		{
			get => E_Struct_FVector2D_Y_GET(NativePointer);
			set => E_Struct_FVector2D_Y_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Gets the result of adding two vectors together.
		/// @param V The other vector to add to this.
		/// @return The result of adding the vectors together.
		/// </summary>
		public static FVector2D operator+(FVector2D Self, FVector2D V)
			=> E_OP_FVector2D_p(Self, V);
		
		
		/// <summary>
		/// Gets the result of scaling the vector (multiplying each component by a value).
		/// @param Scale How much to scale the vector by.
		/// @return The result of scaling this vector.
		/// </summary>
		public static FVector2D operator*(FVector2D Self, float Scale)
			=> E_OP_FVector2D_m(Self, Scale);
		
		
		/// <summary>
		/// Calculates dot product of this vector and another.
		/// @param V The other vector.
		/// @return The dot product.
		/// </summary>
		public static float operator|(FVector2D Self, FVector2D V)
			=> E_OP_FVector2D_i(Self, V);
		
		
		/// <summary>
		/// Calculates the dot product of two vectors.
		/// @param A The first vector.
		/// @param B The second vector.
		/// @return The dot product.
		/// </summary>
		public float DotProduct(FVector2D A, FVector2D B)
			=> E_FVector2D_DotProduct(this, A, B);
		
		
		/// <summary>
		/// Checks for equality with error-tolerant comparison.
		/// @param V The vector to compare.
		/// @param Tolerance Error tolerance.
		/// @return true if the vectors are equal within specified tolerance, otherwise false.
		/// </summary>
		public bool Equals(FVector2D V, float Tolerance)
			=> E_FVector2D_Equals(this, V, Tolerance);
		
		
		/// <summary>
		/// Set the values of the vector directly.
		/// @param InX New X coordinate.
		/// @param InY New Y coordinate.
		/// </summary>
		public void Set(float InX, float InY)
			=> E_FVector2D_Set(this, InX, InY);
		
		
		/// <summary>
		/// Get the maximum value of the vector's components.
		/// @return The maximum value of the vector's components.
		/// </summary>
		public float GetMax()
			=> E_FVector2D_GetMax(this);
		
		
		/// <summary>
		/// Normalize this vector in-place if it is large enough, set it to (0,0) otherwise.
		/// @param Tolerance Minimum squared length of vector for normalization.
		/// @see GetSafeNormal()
		/// </summary>
		public void Normalize(float Tolerance)
			=> E_FVector2D_Normalize(this, Tolerance);
		
		
		/// <summary>
		/// Checks whether vector is near to zero within a specified tolerance.
		/// @param Tolerance Error tolerance.
		/// @return true if vector is in tolerance to zero, otherwise false.
		/// </summary>
		public bool IsNearlyZero(float Tolerance)
			=> E_FVector2D_IsNearlyZero(this, Tolerance);
		
		
		/// <summary>
		/// Util to convert this vector into a unit direction vector and its original length.
		/// @param OutDir Reference passed in to store unit direction vector.
		/// @param OutLength Reference passed in to store length of the vector.
		/// </summary>
		public void ToDirectionAndLength(FVector2D OutDir, float OutLength)
			=> E_FVector2D_ToDirectionAndLength(this, OutDir, OutLength);
		
		
		/// <summary>
		/// Checks whether all components of the vector are exactly zero.
		/// @return true if vector is exactly zero, otherwise false.
		/// </summary>
		public bool IsZero()
			=> E_FVector2D_IsZero(this);
		
		
		/// <summary>
		/// Creates a copy of this vector with both axes clamped to the given range.
		/// @return New vector with clamped axes.
		/// </summary>
		public FVector2D ClampAxes(float MinAxisVal, float MaxAxisVal)
			=> E_FVector2D_ClampAxes(this, MinAxisVal, MaxAxisVal);
		
		public void DiagnosticCheckNaN()
			=> E_FVector2D_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// Converts spherical coordinates on the unit sphere into a Cartesian unit length vector.
		/// </summary>
		public FVector SphericalToUnitCartesian()
			=> E_FVector2D_SphericalToUnitCartesian(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVector2D Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FVector2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector2D(Adress, false);
		}}}
