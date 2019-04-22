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
	public  partial class FVector2D : NativeStructWrapper
	{
		internal FVector2D(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FVector2D() :
			base(E_CreateStruct_FVector2D(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor using initial values for each component. </para>
		/// <param name="InX">X coordinate. </param>
		/// <param name="InY">Y coordinate. </param>
		/// </summary>
		public FVector2D(float inX, float inY) :
			base(E_CreateStruct_FVector2D_float_float(inX, inY), false)
		{
		}

		
		/// <summary>
		/// <para>Constructs a vector from an FIntPoint. </para>
		/// <param name="InPos">Integer point used to set this vector. </param>
		/// </summary>
		public FVector2D(FIntPoint inPos) :
			base(E_CreateStruct_FVector2D_FIntPoint(inPos), false)
		{
		}

		
		/// <summary>
		/// <para>Constructs a vector from an FVector. </para>
		/// <para>Copies the X and Y components from the FVector. </para>
		/// <param name="V">Vector to copy from. </param>
		/// </summary>
		public FVector2D(FVector v) :
			base(E_CreateStruct_FVector2D_FVector(v), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector2D_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector2D_X_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector2D_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector2D_Y_SET(IntPtr Ptr, float Value);
		
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
		/// <para>Vector's X component. </para>
		/// </summary>
		public float X
		{
			get => E_PROP_FVector2D_X_GET(NativePointer);
			set => E_PROP_FVector2D_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Vector's Y component. </para>
		/// </summary>
		public float Y
		{
			get => E_PROP_FVector2D_Y_GET(NativePointer);
			set => E_PROP_FVector2D_Y_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Creates a copy of this vector with both axes clamped to the given range. </para>
		/// <return>New vector with clamped axes. </return>
		/// </summary>
		public FVector2D ClampAxes(float minAxisVal, float maxAxisVal)
			=> E_FVector2D_ClampAxes(this, minAxisVal, maxAxisVal);
		
		
		/// <summary>
		/// <para>Gets a specific component of the vector. </para>
		/// <param name="Index">The index of the component required. </param>
		/// <return>Reference to the specified component. </return>
		/// </summary>
		public float Component(int index)
			=> E_FVector2D_Component(this, index);
		
		
		/// <summary>
		/// <para>Utility to check if there are any non-finite values (NaN or Inf) in this vector. </para>
		/// <return>true if there are any non-finite values in this vector, false otherwise. </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FVector2D_ContainsNaN(this);
		
		
		/// <summary>
		/// <para>Calculate the cross product of two vectors. </para>
		/// <param name="A">The first vector. </param>
		/// <param name="B">The second vector. </param>
		/// <return>The cross product. </return>
		/// </summary>
		public float CrossProduct(FVector2D a, FVector2D b)
			=> E_FVector2D_CrossProduct(this, a, b);
		
		public void DiagnosticCheckNaN()
			=> E_FVector2D_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// <para>Distance between two 2D points. </para>
		/// <param name="V1">The first point. </param>
		/// <param name="V2">The second point. </param>
		/// <return>The distance between two 2D points. </return>
		/// </summary>
		public float Distance(FVector2D v1, FVector2D v2)
			=> E_FVector2D_Distance(this, v1, v2);
		
		
		/// <summary>
		/// <para>Squared distance between two 2D points. </para>
		/// <param name="V1">The first point. </param>
		/// <param name="V2">The second point. </param>
		/// <return>The squared distance between two 2D points. </return>
		/// </summary>
		public float DistSquared(FVector2D v1, FVector2D v2)
			=> E_FVector2D_DistSquared(this, v1, v2);
		
		
		/// <summary>
		/// <para>Calculates the dot product of two vectors. </para>
		/// <param name="A">The first vector. </param>
		/// <param name="B">The second vector. </param>
		/// <return>The dot product. </return>
		/// </summary>
		public float DotProduct(FVector2D a, FVector2D b)
			=> E_FVector2D_DotProduct(this, a, b);
		
		
		/// <summary>
		/// <para>Checks for equality with error-tolerant comparison. </para>
		/// <param name="V">The vector to compare. </param>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if the vectors are equal within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool Equals(FVector2D v, float tolerance)
			=> E_FVector2D_Equals(this, v, tolerance);
		
		
		/// <summary>
		/// <para>Get a copy of this vector with absolute value of each component. </para>
		/// <return>A copy of this vector with absolute value of each component. </return>
		/// </summary>
		public FVector2D GetAbs()
			=> E_FVector2D_GetAbs(this);
		
		
		/// <summary>
		/// <para>Get the maximum absolute value of the vector's components. </para>
		/// <return>The maximum absolute value of the vector's components. </return>
		/// </summary>
		public float GetAbsMax()
			=> E_FVector2D_GetAbsMax(this);
		
		
		/// <summary>
		/// <para>Get the maximum value of the vector's components. </para>
		/// <return>The maximum value of the vector's components. </return>
		/// </summary>
		public float GetMax()
			=> E_FVector2D_GetMax(this);
		
		
		/// <summary>
		/// <para>Get the minimum value of the vector's components. </para>
		/// <return>The minimum value of the vector's components. </return>
		/// </summary>
		public float GetMin()
			=> E_FVector2D_GetMin(this);
		
		
		/// <summary>
		/// <para>Rotates around axis (0,0,1) </para>
		/// <param name="AngleDeg">Angle to rotate (in degrees) </param>
		/// <return>Rotated Vector </return>
		/// </summary>
		public FVector2D GetRotated(float angleDeg)
			=> E_FVector2D_GetRotated(this, angleDeg);
		
		
		/// <summary>
		/// <para>Gets a normalized copy of the vector, checking it is safe to do so based on the length. </para>
		/// <para>Returns zero vector if vector length is too small to safely normalize. </para>
		/// <param name="Tolerance">Minimum squared length of vector for normalization. </param>
		/// <return>A normalized copy of the vector if safe, (0,0) otherwise. </return>
		/// </summary>
		public FVector2D GetSafeNormal(float tolerance)
			=> E_FVector2D_GetSafeNormal(this, tolerance);
		
		
		/// <summary>
		/// <para>Get a copy of the vector as sign only. </para>
		/// <para>Each component is set to +1 or -1, with the sign of zero treated as +1. </para>
		/// <param name="A">copy of the vector with each component set to +1 or -1 </param>
		/// </summary>
		public FVector2D GetSignVector()
			=> E_FVector2D_GetSignVector(this);
		
		
		/// <summary>
		/// <para>Initialize this Vector based on an FString. The String is expected to contain X=, Y=. </para>
		/// <para>The FVector2D will be bogus when InitFromString returns false. </para>
		/// <param name="InSourceString">FString containing the vector values. </param>
		/// <return>true if the X,Y values were read successfully; false otherwise. </return>
		/// </summary>
		public bool InitFromString(string inSourceString)
			=> E_FVector2D_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// <para>Get this vector as an Int Point. </para>
		/// <return>New Int Point from this vector. </return>
		/// </summary>
		public FIntPoint IntPoint()
			=> E_FVector2D_IntPoint(this);
		
		
		/// <summary>
		/// <para>Checks whether vector is near to zero within a specified tolerance. </para>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if vector is in tolerance to zero, otherwise false. </return>
		/// </summary>
		public bool IsNearlyZero(float tolerance)
			=> E_FVector2D_IsNearlyZero(this, tolerance);
		
		
		/// <summary>
		/// <para>Checks whether all components of the vector are exactly zero. </para>
		/// <return>true if vector is exactly zero, otherwise false. </return>
		/// </summary>
		public bool IsZero()
			=> E_FVector2D_IsZero(this);
		
		
		/// <summary>
		/// <para>Returns a vector with the maximum component for each dimension from the pair of vectors. </para>
		/// <param name="A">The first vector. </param>
		/// <param name="B">The second vector. </param>
		/// <return>The max vector. </return>
		/// </summary>
		public FVector2D Max(FVector2D a, FVector2D b)
			=> E_FVector2D_Max(this, a, b);
		
		
		/// <summary>
		/// <para>Returns a vector with the minimum component for each dimension from the pair of vectors. </para>
		/// <param name="A">The first vector. </param>
		/// <param name="B">The second vector. </param>
		/// <return>The min vector. </return>
		/// </summary>
		public FVector2D Min(FVector2D a, FVector2D b)
			=> E_FVector2D_Min(this, a, b);
		
		
		/// <summary>
		/// <para>Normalize this vector in-place if it is large enough, set it to (0,0) otherwise. </para>
		/// <param name="Tolerance">Minimum squared length of vector for normalization. </param>
		/// <para>@see GetSafeNormal() </para>
		/// </summary>
		public void Normalize(float tolerance)
			=> E_FVector2D_Normalize(this, tolerance);
		
		
		/// <summary>
		/// <para>Get this vector as a vector where each component has been rounded to the nearest int. </para>
		/// <return>New FVector2D from this vector that is rounded. </return>
		/// </summary>
		public FVector2D RoundToVector()
			=> E_FVector2D_RoundToVector(this);
		
		
		/// <summary>
		/// <para>Set the values of the vector directly. </para>
		/// <param name="InX">New X coordinate. </param>
		/// <param name="InY">New Y coordinate. </param>
		/// </summary>
		public void Set(float inX, float inY)
			=> E_FVector2D_Set(this, inX, inY);
		
		
		/// <summary>
		/// <para>Get the length (magnitude) of this vector. </para>
		/// <return>The length of this vector. </return>
		/// </summary>
		public float Size()
			=> E_FVector2D_Size(this);
		
		
		/// <summary>
		/// <para>Get the squared length of this vector. </para>
		/// <return>The squared length of this vector. </return>
		/// </summary>
		public float SizeSquared()
			=> E_FVector2D_SizeSquared(this);
		
		
		/// <summary>
		/// <para>Converts spherical coordinates on the unit sphere into a Cartesian unit length vector. </para>
		/// </summary>
		public FVector SphericalToUnitCartesian()
			=> E_FVector2D_SphericalToUnitCartesian(this);
		
		
		/// <summary>
		/// <para>Util to convert this vector into a unit direction vector and its original length. </para>
		/// <param name="OutDir">Reference passed in to store unit direction vector. </param>
		/// <param name="OutLength">Reference passed in to store length of the vector. </param>
		/// </summary>
		public void ToDirectionAndLength(FVector2D outDir, float outLength)
			=> E_FVector2D_ToDirectionAndLength(this, outDir, outLength);
		
		
		/// <summary>
		/// <para>Get a textual representation of the vector. </para>
		/// <return>Text describing the vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FVector2D_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVector2D self)
		{
			return self.NativePointer;
		}

		public static implicit operator FVector2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector2D(Adress, false);
		}}}
