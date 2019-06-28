// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Vector2D.h:17

namespace UnrealEngine
{
	public partial class FVector2D : NativeStructWrapper
	{
		public FVector2D(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FVector2D() :
			base(E_CreateStruct_FVector2D(), false)
		{
		}

		
		/// <summary>
		/// Constructor using initial values for each component.
		/// </summary>
		/// <param name="inX">X coordinate.</param>
		/// <param name="inY">Y coordinate.</param>
		public FVector2D(float inX, float inY) :
			base(E_CreateStruct_FVector2D_float_float(inX, inY), false)
		{
		}

		
		/// <summary>
		/// Constructs a vector from an FIntPoint.
		/// </summary>
		/// <param name="inPos">Integer point used to set this vector.</param>
		public FVector2D(FIntPoint inPos) :
			base(E_CreateStruct_FVector2D_FIntPoint(inPos), false)
		{
		}

		
		/// <summary>
		/// Constructs a vector from an FVector.
		/// <para>Copies the X and Y components from the FVector. </para>
		/// </summary>
		/// <param name="v">Vector to copy from.</param>
		public FVector2D(FVector v) :
			base(E_CreateStruct_FVector2D_FVector(v), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVector2D_Unit45Deg_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVector2D_UnitVector_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector2D_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector2D_X_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector2D_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector2D_Y_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FVector2D_ZeroVector_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2D();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2D_float_float(float inX, float inY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2D_FIntPoint(IntPtr inPos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2D_FVector(IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_ClampAxes(IntPtr self, float minAxisVal, float maxAxisVal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_Component(IntPtr self, int index);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_ContainsNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_CrossProduct(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector2D_DiagnosticCheckNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_Distance(IntPtr self, IntPtr v1, IntPtr v2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_DistSquared(IntPtr self, IntPtr v1, IntPtr v2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_DotProduct(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_Equals(IntPtr self, IntPtr v, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_GetAbs(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_GetAbsMax(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_GetMax(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_GetMin(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_GetRotated(IntPtr self, float angleDeg);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_GetSafeNormal(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_GetSignVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_InitFromString(IntPtr self, string inSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_IntPoint(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_IsNearlyZero(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_IsZero(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_Max(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_Min(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector2D_Normalize(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_RoundToVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector2D_Set(IntPtr self, float inX, float inY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_Size(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_SizeSquared(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_SphericalToUnitCartesian(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector2D_ToDirectionAndLength(IntPtr self, IntPtr outDir, float outLength);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector2D_ToString(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Global 2D unit vector constant along the 45 degree angle or symmetrical positive axes (sqrt(.5),sqrt(.5)) or (.707,.707). https://en.wikipedia.org/wiki/Unit_vector
		/// <para>@note The `UnitVector` above is actually a value with axes of 1 rather than a magnitude of one. </para>
		/// </summary>
		public static FVector2D Unit45Deg
		{
			get => E_PROP_FVector2D_Unit45Deg_GET();
		}

		
		/// <summary>
		/// Global 2D one vector (poorly named) constant (1,1).
		/// <para>@note Incorrectly named "unit" vector though its magnitude/length/size is not one. Would fix, though likely used all over the world. Use `Unit45Deg` below for an actual unit vector. </para>
		/// </summary>
		public static FVector2D UnitVector
		{
			get => E_PROP_FVector2D_UnitVector_GET();
		}

		
		/// <summary>
		/// Vector's X component.
		/// </summary>
		public float X
		{
			get => E_PROP_FVector2D_X_GET(NativePointer);
			set => E_PROP_FVector2D_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Vector's Y component.
		/// </summary>
		public float Y
		{
			get => E_PROP_FVector2D_Y_GET(NativePointer);
			set => E_PROP_FVector2D_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Global 2D zero vector constant (0,0)
		/// </summary>
		public static FVector2D ZeroVector
		{
			get => E_PROP_FVector2D_ZeroVector_GET();
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Creates a copy of this vector with both axes clamped to the given range.
		/// </summary>
		/// <return>New</return>
		public FVector2D ClampAxes(float minAxisVal, float maxAxisVal)
			=> E_FVector2D_ClampAxes(this, minAxisVal, maxAxisVal);
		
		
		/// <summary>
		/// Gets a specific component of the vector.
		/// </summary>
		/// <param name="index">The index of the component required.</param>
		/// <return>Reference</return>
		public float Component(int index)
			=> E_FVector2D_Component(this, index);
		
		
		/// <summary>
		/// Utility to check if there are any non-finite values (NaN or Inf) in this vector.
		/// </summary>
		/// <return>true</return>
		public bool ContainsNaN()
			=> E_FVector2D_ContainsNaN(this);
		
		
		/// <summary>
		/// Calculate the cross product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <return>The</return>
		public float CrossProduct(FVector2D a, FVector2D b)
			=> E_FVector2D_CrossProduct(this, a, b);
		
		public void DiagnosticCheckNaN()
			=> E_FVector2D_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// Distance between two 2D points.
		/// </summary>
		/// <param name="v1">The first point.</param>
		/// <param name="v2">The second point.</param>
		/// <return>The</return>
		public float Distance(FVector2D v1, FVector2D v2)
			=> E_FVector2D_Distance(this, v1, v2);
		
		
		/// <summary>
		/// Squared distance between two 2D points.
		/// </summary>
		/// <param name="v1">The first point.</param>
		/// <param name="v2">The second point.</param>
		/// <return>The</return>
		public float DistSquared(FVector2D v1, FVector2D v2)
			=> E_FVector2D_DistSquared(this, v1, v2);
		
		
		/// <summary>
		/// Calculates the dot product of two vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <return>The</return>
		public float DotProduct(FVector2D a, FVector2D b)
			=> E_FVector2D_DotProduct(this, a, b);
		
		
		/// <summary>
		/// Checks for equality with error-tolerant comparison.
		/// </summary>
		/// <param name="v">The vector to compare.</param>
		/// <param name="tolerance">Error tolerance.</param>
		/// <return>true</return>
		public bool Equals(FVector2D v, float tolerance)
			=> E_FVector2D_Equals(this, v, tolerance);
		
		
		/// <summary>
		/// Get a copy of this vector with absolute value of each component.
		/// </summary>
		/// <return>A</return>
		public FVector2D GetAbs()
			=> E_FVector2D_GetAbs(this);
		
		
		/// <summary>
		/// Get the maximum absolute value of the vector's components.
		/// </summary>
		/// <return>The</return>
		public float GetAbsMax()
			=> E_FVector2D_GetAbsMax(this);
		
		
		/// <summary>
		/// Get the maximum value of the vector's components.
		/// </summary>
		/// <return>The</return>
		public float GetMax()
			=> E_FVector2D_GetMax(this);
		
		
		/// <summary>
		/// Get the minimum value of the vector's components.
		/// </summary>
		/// <return>The</return>
		public float GetMin()
			=> E_FVector2D_GetMin(this);
		
		
		/// <summary>
		/// Rotates around axis (0,0,1)
		/// </summary>
		/// <param name="angleDeg">Angle to rotate (in degrees)</param>
		/// <return>Rotated</return>
		public FVector2D GetRotated(float angleDeg)
			=> E_FVector2D_GetRotated(this, angleDeg);
		
		
		/// <summary>
		/// Gets a normalized copy of the vector, checking it is safe to do so based on the length.
		/// <para>Returns zero vector if vector length is too small to safely normalize. </para>
		/// </summary>
		/// <param name="tolerance">Minimum squared length of vector for normalization.</param>
		/// <return>A</return>
		public FVector2D GetSafeNormal(float tolerance)
			=> E_FVector2D_GetSafeNormal(this, tolerance);
		
		
		/// <summary>
		/// Get a copy of the vector as sign only.
		/// <para>Each component is set to +1 or -1, with the sign of zero treated as +1. </para>
		/// </summary>
		/// <param name="a">copy of the vector with each component set to +1 or -1</param>
		public FVector2D GetSignVector()
			=> E_FVector2D_GetSignVector(this);
		
		
		/// <summary>
		/// Initialize this Vector based on an FString. The String is expected to contain X=, Y=.
		/// <para>The FVector2D will be bogus when InitFromString returns false. </para>
		/// </summary>
		/// <param name="inSourceString">FString containing the vector values.</param>
		/// <return>true</return>
		public bool InitFromString(string inSourceString)
			=> E_FVector2D_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// Get this vector as an Int Point.
		/// </summary>
		/// <return>New</return>
		public FIntPoint IntPoint()
			=> E_FVector2D_IntPoint(this);
		
		
		/// <summary>
		/// Checks whether vector is near to zero within a specified tolerance.
		/// </summary>
		/// <param name="tolerance">Error tolerance.</param>
		/// <return>true</return>
		public bool IsNearlyZero(float tolerance)
			=> E_FVector2D_IsNearlyZero(this, tolerance);
		
		
		/// <summary>
		/// Checks whether all components of the vector are exactly zero.
		/// </summary>
		/// <return>true</return>
		public bool IsZero()
			=> E_FVector2D_IsZero(this);
		
		
		/// <summary>
		/// Returns a vector with the maximum component for each dimension from the pair of vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <return>The</return>
		public FVector2D Max(FVector2D a, FVector2D b)
			=> E_FVector2D_Max(this, a, b);
		
		
		/// <summary>
		/// Returns a vector with the minimum component for each dimension from the pair of vectors.
		/// </summary>
		/// <param name="a">The first vector.</param>
		/// <param name="b">The second vector.</param>
		/// <return>The</return>
		public FVector2D Min(FVector2D a, FVector2D b)
			=> E_FVector2D_Min(this, a, b);
		
		
		/// <summary>
		/// Normalize this vector in-place if it is large enough, set it to (0,0) otherwise.
		/// <see cref="GetSafeNormal"/>
		/// </summary>
		/// <param name="tolerance">Minimum squared length of vector for normalization.</param>
		public void Normalize(float tolerance)
			=> E_FVector2D_Normalize(this, tolerance);
		
		
		/// <summary>
		/// Get this vector as a vector where each component has been rounded to the nearest int.
		/// </summary>
		/// <return>New</return>
		public FVector2D RoundToVector()
			=> E_FVector2D_RoundToVector(this);
		
		
		/// <summary>
		/// Set the values of the vector directly.
		/// </summary>
		/// <param name="inX">New X coordinate.</param>
		/// <param name="inY">New Y coordinate.</param>
		public void Set(float inX, float inY)
			=> E_FVector2D_Set(this, inX, inY);
		
		
		/// <summary>
		/// Get the length (magnitude) of this vector.
		/// </summary>
		/// <return>The</return>
		public float Size()
			=> E_FVector2D_Size(this);
		
		
		/// <summary>
		/// Get the squared length of this vector.
		/// </summary>
		/// <return>The</return>
		public float SizeSquared()
			=> E_FVector2D_SizeSquared(this);
		
		
		/// <summary>
		/// Converts spherical coordinates on the unit sphere into a Cartesian unit length vector.
		/// </summary>
		public FVector SphericalToUnitCartesian()
			=> E_FVector2D_SphericalToUnitCartesian(this);
		
		
		/// <summary>
		/// Util to convert this vector into a unit direction vector and its original length.
		/// </summary>
		/// <param name="outDir">Reference passed in to store unit direction vector.</param>
		/// <param name="outLength">Reference passed in to store length of the vector.</param>
		public void ToDirectionAndLength(FVector2D outDir, float outLength)
			=> E_FVector2D_ToDirectionAndLength(this, outDir, outLength);
		
		
		/// <summary>
		/// Get a textual representation of the vector.
		/// </summary>
		/// <return>Text</return>
		public override string ToString()
			=> E_FVector2D_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVector2D self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FVector2D(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FVector2D(adress, false);
		}}}
