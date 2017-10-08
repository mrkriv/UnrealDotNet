using System;
using System.Runtime.InteropServices;

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
		public FVector2D(float InX, float InY) :
			base(E_CreateStruct_FVector2D_float_float(InX, InY), false)
		{
		}

		
		/// <summary>
		/// <para>Constructs a vector from an FVector. </para>
		/// <para>Copies the X and Y components from the FVector. </para>
		/// <param name="V">Vector to copy from. </param>
		/// </summary>
		public FVector2D(FVector V) :
			base(E_CreateStruct_FVector2D_FVector(V), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2D();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2D_float_float(float InX, float InY);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector2D_FVector(IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_ClampAxes(IntPtr Self, float MinAxisVal, float MaxAxisVal);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_ContainsNaN(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_CrossProduct(IntPtr Self, IntPtr A, IntPtr B);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector2D_DiagnosticCheckNaN(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_Distance(IntPtr Self, IntPtr V1, IntPtr V2);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_DistSquared(IntPtr Self, IntPtr V1, IntPtr V2);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_DotProduct(IntPtr Self, IntPtr A, IntPtr B);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_Equals(IntPtr Self, IntPtr V, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_GetAbs(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_GetAbsMax(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_GetMax(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_GetMin(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_GetRotated(IntPtr Self, float AngleDeg);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_GetSafeNormal(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_GetSignVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_InitFromString(IntPtr Self, string InSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_IsNearlyZero(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector2D_IsZero(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector2D_Normalize(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_RoundToVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_SafeNormal(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector2D_Set(IntPtr Self, float InX, float InY);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_Size(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector2D_SizeSquared(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector2D_SphericalToUnitCartesian(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector2D_ToDirectionAndLength(IntPtr Self, IntPtr OutDir, float OutLength);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector2D_ToString(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Creates a copy of this vector with both axes clamped to the given range. </para>
		/// <return>New vector with clamped axes. </return>
		/// </summary>
		public FVector2D ClampAxes(float MinAxisVal, float MaxAxisVal)
			=> E_FVector2D_ClampAxes(this, MinAxisVal, MaxAxisVal);
		
		
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
		public float CrossProduct(FVector2D A, FVector2D B)
			=> E_FVector2D_CrossProduct(this, A, B);
		
		public void DiagnosticCheckNaN()
			=> E_FVector2D_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// <para>Distance between two 2D points. </para>
		/// <param name="V1">The first point. </param>
		/// <param name="V2">The second point. </param>
		/// <return>The distance between two 2D points. </return>
		/// </summary>
		public float Distance(FVector2D V1, FVector2D V2)
			=> E_FVector2D_Distance(this, V1, V2);
		
		
		/// <summary>
		/// <para>Squared distance between two 2D points. </para>
		/// <param name="V1">The first point. </param>
		/// <param name="V2">The second point. </param>
		/// <return>The squared distance between two 2D points. </return>
		/// </summary>
		public float DistSquared(FVector2D V1, FVector2D V2)
			=> E_FVector2D_DistSquared(this, V1, V2);
		
		
		/// <summary>
		/// <para>Calculates the dot product of two vectors. </para>
		/// <param name="A">The first vector. </param>
		/// <param name="B">The second vector. </param>
		/// <return>The dot product. </return>
		/// </summary>
		public float DotProduct(FVector2D A, FVector2D B)
			=> E_FVector2D_DotProduct(this, A, B);
		
		
		/// <summary>
		/// <para>Checks for equality with error-tolerant comparison. </para>
		/// <param name="V">The vector to compare. </param>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if the vectors are equal within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool Equals(FVector2D V, float Tolerance)
			=> E_FVector2D_Equals(this, V, Tolerance);
		
		
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
		public FVector2D GetRotated(float AngleDeg)
			=> E_FVector2D_GetRotated(this, AngleDeg);
		
		
		/// <summary>
		/// <para>Gets a normalized copy of the vector, checking it is safe to do so based on the length. </para>
		/// <para>Returns zero vector if vector length is too small to safely normalize. </para>
		/// <param name="Tolerance">Minimum squared length of vector for normalization. </param>
		/// <return>A normalized copy of the vector if safe, (0,0) otherwise. </return>
		/// </summary>
		public FVector2D GetSafeNormal(float Tolerance)
			=> E_FVector2D_GetSafeNormal(this, Tolerance);
		
		
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
		public bool InitFromString(string InSourceString)
			=> E_FVector2D_InitFromString(this, InSourceString);
		
		
		/// <summary>
		/// <para>Checks whether vector is near to zero within a specified tolerance. </para>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if vector is in tolerance to zero, otherwise false. </return>
		/// </summary>
		public bool IsNearlyZero(float Tolerance)
			=> E_FVector2D_IsNearlyZero(this, Tolerance);
		
		
		/// <summary>
		/// <para>Checks whether all components of the vector are exactly zero. </para>
		/// <return>true if vector is exactly zero, otherwise false. </return>
		/// </summary>
		public bool IsZero()
			=> E_FVector2D_IsZero(this);
		
		
		/// <summary>
		/// <para>Normalize this vector in-place if it is large enough, set it to (0,0) otherwise. </para>
		/// <param name="Tolerance">Minimum squared length of vector for normalization. </param>
		/// <para>@see GetSafeNormal() </para>
		/// </summary>
		public void Normalize(float Tolerance)
			=> E_FVector2D_Normalize(this, Tolerance);
		
		
		/// <summary>
		/// <para>Get this vector as a vector where each component has been rounded to the nearest int. </para>
		/// <return>New FVector2D from this vector that is rounded. </return>
		/// </summary>
		public FVector2D RoundToVector()
			=> E_FVector2D_RoundToVector(this);
		
		public FVector2D SafeNormal(float Tolerance)
			=> E_FVector2D_SafeNormal(this, Tolerance);
		
		
		/// <summary>
		/// <para>Set the values of the vector directly. </para>
		/// <param name="InX">New X coordinate. </param>
		/// <param name="InY">New Y coordinate. </param>
		/// </summary>
		public void Set(float InX, float InY)
			=> E_FVector2D_Set(this, InX, InY);
		
		
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
		public void ToDirectionAndLength(FVector2D OutDir, float OutLength)
			=> E_FVector2D_ToDirectionAndLength(this, OutDir, OutLength);
		
		
		/// <summary>
		/// <para>Get a textual representation of the vector. </para>
		/// <return>Text describing the vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FVector2D_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVector2D Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FVector2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector2D(Adress, false);
		}}}
