using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FVector : NativeStructWrapper
	{
		internal FVector(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FVector() :
			base(E_CreateStruct_FVector(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor initializing all components to a single float value. </para>
		/// <param name="InF">Value to set all components to. </param>
		/// </summary>
		public FVector(float InF) :
			base(E_CreateStruct_FVector_float(InF), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor using initial values for each component. </para>
		/// <param name="InX">X Coordinate. </param>
		/// <param name="InY">Y Coordinate. </param>
		/// <param name="InZ">Z Coordinate. </param>
		/// </summary>
		public FVector(float InX, float InY, float InZ) :
			base(E_CreateStruct_FVector_float_float_float(InX, InY, InZ), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_float(float InF);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector_float_float_float(float InX, float InY, float InZ);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector_X_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector_Y_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector_Z_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector_Z_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_AllComponentsEqual(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_BoundToCube(IntPtr Self, float Radius);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ClampMaxSize(IntPtr Self, float MaxSize);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ClampMaxSize2D(IntPtr Self, float MaxSize);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ClampSize(IntPtr Self, float Min, float Max);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ClampSize2D(IntPtr Self, float Min, float Max);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_ContainsNaN(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_CosineAngle2D(IntPtr Self, IntPtr B);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetAbs(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_GetAbsMax(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_GetAbsMin(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetClampedToMaxSize(IntPtr Self, float MaxSize);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetClampedToMaxSize2D(IntPtr Self, float MaxSize);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetClampedToSize(IntPtr Self, float Min, float Max);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetClampedToSize2D(IntPtr Self, float Min, float Max);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_GetMax(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_GetMin(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetSafeNormal(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetSafeNormal2D(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetSignVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GetUnsafeNormal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_GridSnap(IntPtr Self, float GridSz);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_HeadingAngle(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_InitFromString(IntPtr Self, string InSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsNearlyZero(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsNormalized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsUniform(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsUnit(IntPtr Self, float LengthSquaredTolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_IsZero(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector_Normalize(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_Projection(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_Reciprocal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_Rotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_SafeNormal(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_SafeNormal2D(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_Set(IntPtr Self, float InX, float InY, float InZ);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_Size(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_Size2D(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_SizeSquared(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector_SizeSquared2D(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector_ToCompactString(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector_ToCompactText(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ToOrientationQuat(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_ToOrientationRotator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector_ToString(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector_ToText(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_UnitCartesianToSpherical(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector_UnsafeNormal(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector_UnwindEuler(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Vector's X component. </para>
		/// </summary>
		public float X
		{
			get => E_PROP_FVector_X_GET(NativePointer);
			set => E_PROP_FVector_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Vector's Y component. </para>
		/// </summary>
		public float Y
		{
			get => E_PROP_FVector_Y_GET(NativePointer);
			set => E_PROP_FVector_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Vector's Z component. </para>
		/// </summary>
		public float Z
		{
			get => E_PROP_FVector_Z_GET(NativePointer);
			set => E_PROP_FVector_Z_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Checks whether all components of this vector are the same, within a tolerance. </para>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if the vectors are equal within tolerance limits, false otherwise. </return>
		/// </summary>
		public bool AllComponentsEqual(float Tolerance)
			=> E_FVector_AllComponentsEqual(this, Tolerance);
		
		
		/// <summary>
		/// <para>Get a copy of this vector, clamped inside of a cube. </para>
		/// <param name="Radius">Half size of the cube. </param>
		/// <return>A copy of this vector, bound by cube. </return>
		/// </summary>
		public FVector BoundToCube(float Radius)
			=> E_FVector_BoundToCube(this, Radius);
		
		public FVector ClampMaxSize(float MaxSize)
			=> E_FVector_ClampMaxSize(this, MaxSize);
		
		public FVector ClampMaxSize2D(float MaxSize)
			=> E_FVector_ClampMaxSize2D(this, MaxSize);
		
		public FVector ClampSize(float Min, float Max)
			=> E_FVector_ClampSize(this, Min, Max);
		
		public FVector ClampSize2D(float Min, float Max)
			=> E_FVector_ClampSize2D(this, Min, Max);
		
		
		/// <summary>
		/// <para>Utility to check if there are any non-finite values (NaN or Inf) in this vector. </para>
		/// <return>true if there are any non-finite values in this vector, false otherwise. </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FVector_ContainsNaN(this);
		
		
		/// <summary>
		/// <para>Returns the cosine of the angle between this vector and another projected onto the XY plane (no Z). </para>
		/// <param name="B">the other vector to find the 2D cosine of the angle with. </param>
		/// <return>The cosine. </return>
		/// </summary>
		public float CosineAngle2D(FVector B)
			=> E_FVector_CosineAngle2D(this, B);
		
		
		/// <summary>
		/// <para>Get a copy of this vector with absolute value of each component. </para>
		/// <return>A copy of this vector with absolute value of each component. </return>
		/// </summary>
		public FVector GetAbs()
			=> E_FVector_GetAbs(this);
		
		
		/// <summary>
		/// <para>Get the maximum absolute value of the vector's components. </para>
		/// <return>The maximum absolute value of the vector's components. </return>
		/// </summary>
		public float GetAbsMax()
			=> E_FVector_GetAbsMax(this);
		
		
		/// <summary>
		/// <para>Get the minimum absolute value of the vector's components. </para>
		/// <return>The minimum absolute value of the vector's components. </return>
		/// </summary>
		public float GetAbsMin()
			=> E_FVector_GetAbsMin(this);
		
		
		/// <summary>
		/// <para>Create a copy of this vector, with its maximum magnitude clamped to MaxSize. </para>
		/// </summary>
		public FVector GetClampedToMaxSize(float MaxSize)
			=> E_FVector_GetClampedToMaxSize(this, MaxSize);
		
		
		/// <summary>
		/// <para>Create a copy of this vector, with the maximum 2D magnitude clamped to MaxSize. Z is unchanged. </para>
		/// </summary>
		public FVector GetClampedToMaxSize2D(float MaxSize)
			=> E_FVector_GetClampedToMaxSize2D(this, MaxSize);
		
		
		/// <summary>
		/// <para>Create a copy of this vector, with its magnitude clamped between Min and Max. </para>
		/// </summary>
		public FVector GetClampedToSize(float Min, float Max)
			=> E_FVector_GetClampedToSize(this, Min, Max);
		
		
		/// <summary>
		/// <para>Create a copy of this vector, with the 2D magnitude clamped between Min and Max. Z is unchanged. </para>
		/// </summary>
		public FVector GetClampedToSize2D(float Min, float Max)
			=> E_FVector_GetClampedToSize2D(this, Min, Max);
		
		
		/// <summary>
		/// <para>Get the maximum value of the vector's components. </para>
		/// <return>The maximum value of the vector's components. </return>
		/// </summary>
		public float GetMax()
			=> E_FVector_GetMax(this);
		
		
		/// <summary>
		/// <para>Get the minimum value of the vector's components. </para>
		/// <return>The minimum value of the vector's components. </return>
		/// </summary>
		public float GetMin()
			=> E_FVector_GetMin(this);
		
		
		/// <summary>
		/// <para>Gets a normalized copy of the vector, checking it is safe to do so based on the length. </para>
		/// <para>Returns zero vector if vector length is too small to safely normalize. </para>
		/// <param name="Tolerance">Minimum squared vector length. </param>
		/// <return>A normalized copy if safe, (0,0,0) otherwise. </return>
		/// </summary>
		public FVector GetSafeNormal(float Tolerance)
			=> E_FVector_GetSafeNormal(this, Tolerance);
		
		
		/// <summary>
		/// <para>Gets a normalized copy of the 2D components of the vector, checking it is safe to do so. Z is set to zero. </para>
		/// <para>Returns zero vector if vector length is too small to normalize. </para>
		/// <param name="Tolerance">Minimum squared vector length. </param>
		/// <return>Normalized copy if safe, otherwise returns zero vector. </return>
		/// </summary>
		public FVector GetSafeNormal2D(float Tolerance)
			=> E_FVector_GetSafeNormal2D(this, Tolerance);
		
		
		/// <summary>
		/// <para>Get a copy of the vector as sign only. </para>
		/// <para>Each component is set to +1 or -1, with the sign of zero treated as +1. </para>
		/// <param name="A">copy of the vector with each component set to +1 or -1 </param>
		/// </summary>
		public FVector GetSignVector()
			=> E_FVector_GetSignVector(this);
		
		
		/// <summary>
		/// <para>Calculates normalized version of vector without checking for zero length. </para>
		/// <return>Normalized version of vector. </return>
		/// <para>@see GetSafeNormal() </para>
		/// </summary>
		public FVector GetUnsafeNormal()
			=> E_FVector_GetUnsafeNormal(this);
		
		
		/// <summary>
		/// <para>Gets a copy of this vector snapped to a grid. </para>
		/// <param name="GridSz">Grid dimension. </param>
		/// <return>A copy of this vector snapped to a grid. </return>
		/// <para>@see FMath::GridSnap() </para>
		/// </summary>
		public FVector GridSnap(float GridSz)
			=> E_FVector_GridSnap(this, GridSz);
		
		
		/// <summary>
		/// <para>Convert a direction vector into a 'heading' angle. </para>
		/// <return>Heading' angle between +/-PI. 0 is pointing down +X. </return>
		/// </summary>
		public float HeadingAngle()
			=> E_FVector_HeadingAngle(this);
		
		
		/// <summary>
		/// <para>Initialize this Vector based on an FString. The String is expected to contain X=, Y=, Z=. </para>
		/// <para>The FVector will be bogus when InitFromString returns false. </para>
		/// <param name="InSourceString">FString containing the vector values. </param>
		/// <return>true if the X,Y,Z values were read successfully; false otherwise. </return>
		/// </summary>
		public bool InitFromString(string InSourceString)
			=> E_FVector_InitFromString(this, InSourceString);
		
		
		/// <summary>
		/// <para>Checks whether vector is near to zero within a specified tolerance. </para>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if the vector is near to zero, false otherwise. </return>
		/// </summary>
		public bool IsNearlyZero(float Tolerance)
			=> E_FVector_IsNearlyZero(this, Tolerance);
		
		
		/// <summary>
		/// <para>Checks whether vector is normalized. </para>
		/// <return>true if Normalized, false otherwise. </return>
		/// </summary>
		public bool IsNormalized()
			=> E_FVector_IsNormalized(this);
		
		
		/// <summary>
		/// <para>Check whether X, Y and Z are nearly equal. </para>
		/// <param name="Tolerance">Specified Tolerance. </param>
		/// <return>true if X == Y == Z within the specified tolerance. </return>
		/// </summary>
		public bool IsUniform(float Tolerance)
			=> E_FVector_IsUniform(this, Tolerance);
		
		
		/// <summary>
		/// <para>Check if the vector is of unit length, with specified tolerance. </para>
		/// <param name="LengthSquaredTolerance">Tolerance against squared length. </param>
		/// <return>true if the vector is a unit vector within the specified tolerance. </return>
		/// </summary>
		public bool IsUnit(float LengthSquaredTolerance)
			=> E_FVector_IsUnit(this, LengthSquaredTolerance);
		
		
		/// <summary>
		/// <para>Checks whether all components of the vector are exactly zero. </para>
		/// <return>true if the vector is exactly zero, false otherwise. </return>
		/// </summary>
		public bool IsZero()
			=> E_FVector_IsZero(this);
		
		
		/// <summary>
		/// <para>Normalize this vector in-place if it is larger than a given tolerance. Leaves it unchanged if not. </para>
		/// <param name="Tolerance">Minimum squared length of vector for normalization. </param>
		/// <return>true if the vector was normalized correctly, false otherwise. </return>
		/// </summary>
		public bool Normalize(float Tolerance)
			=> E_FVector_Normalize(this, Tolerance);
		
		
		/// <summary>
		/// <para>Projects 2D components of vector based on Z. </para>
		/// <return>Projected version of vector based on Z. </return>
		/// </summary>
		public FVector Projection()
			=> E_FVector_Projection(this);
		
		
		/// <summary>
		/// <para>Gets the reciprocal of this vector, avoiding division by zero. </para>
		/// <para>Zero components are set to BIG_NUMBER. </para>
		/// <return>Reciprocal of this vector. </return>
		/// </summary>
		public FVector Reciprocal()
			=> E_FVector_Reciprocal(this);
		
		
		/// <summary>
		/// <para>Return the FRotator orientation corresponding to the direction in which the vector points. </para>
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets Roll to zero because the roll can't be determined from a vector. </para>
		/// <para>@note Identical to 'ToOrientationRotator()' and preserved for legacy reasons. </para>
		/// <return>FRotator from the Vector's direction. </return>
		/// <para>@see ToOrientationRotator(), ToOrientationQuat() </para>
		/// </summary>
		public FRotator Rotation()
			=> E_FVector_Rotation(this);
		
		public FVector SafeNormal(float Tolerance)
			=> E_FVector_SafeNormal(this, Tolerance);
		
		public FVector SafeNormal2D(float Tolerance)
			=> E_FVector_SafeNormal2D(this, Tolerance);
		
		
		/// <summary>
		/// <para>Set the values of the vector directly. </para>
		/// <param name="InX">New X coordinate. </param>
		/// <param name="InY">New Y coordinate. </param>
		/// <param name="InZ">New Z coordinate. </param>
		/// </summary>
		public void Set(float InX, float InY, float InZ)
			=> E_FVector_Set(this, InX, InY, InZ);
		
		
		/// <summary>
		/// <para>Get the length (magnitude) of this vector. </para>
		/// <return>The length of this vector. </return>
		/// </summary>
		public float Size()
			=> E_FVector_Size(this);
		
		
		/// <summary>
		/// <para>Get the length of the 2D components of this vector. </para>
		/// <return>The 2D length of this vector. </return>
		/// </summary>
		public float Size2D()
			=> E_FVector_Size2D(this);
		
		
		/// <summary>
		/// <para>Get the squared length of this vector. </para>
		/// <return>The squared length of this vector. </return>
		/// </summary>
		public float SizeSquared()
			=> E_FVector_SizeSquared(this);
		
		
		/// <summary>
		/// <para>Get the squared length of the 2D components of this vector. </para>
		/// <return>The squared 2D length of this vector. </return>
		/// </summary>
		public float SizeSquared2D()
			=> E_FVector_SizeSquared2D(this);
		
		
		/// <summary>
		/// <para>Get a short textural representation of this vector, for compact readable logging. </para>
		/// </summary>
		public string ToCompactString()
			=> E_FVector_ToCompactString(this);
		
		
		/// <summary>
		/// <para>Get a short locale aware textural representation of this vector, for compact readable logging. </para>
		/// </summary>
		public string ToCompactText()
			=> E_FVector_ToCompactText(this);
		
		
		/// <summary>
		/// <para>Return the Quaternion orientation corresponding to the direction in which the vector points. </para>
		/// <para>Similar to the FRotator version, returns a result without roll such that it preserves the up vector. </para>
		/// <para>@note If you don't care about preserving the up vector and just want the most direct rotation, you can use the faster </para>
		/// <para>'FQuat::FindBetweenVectors(FVector::ForwardVector, YourVector)' or 'FQuat::FindBetweenNormals(...)' if you know the vector is of unit length. </para>
		/// <return>Quaternion from the Vector's direction, without any roll. </return>
		/// <para>@see ToOrientationRotator(), FQuat::FindBetweenVectors() </para>
		/// </summary>
		public FQuat ToOrientationQuat()
			=> E_FVector_ToOrientationQuat(this);
		
		
		/// <summary>
		/// <para>Return the FRotator orientation corresponding to the direction in which the vector points. </para>
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets Roll to zero because the roll can't be determined from a vector. </para>
		/// <return>FRotator from the Vector's direction, without any roll. </return>
		/// <para>@see ToOrientationQuat() </para>
		/// </summary>
		public FRotator ToOrientationRotator()
			=> E_FVector_ToOrientationRotator(this);
		
		
		/// <summary>
		/// <para>Get a textual representation of this vector. </para>
		/// <return>A string describing the vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FVector_ToString(this);
		
		
		/// <summary>
		/// <para>Get a locale aware textual representation of this vector. </para>
		/// <return>A string describing the vector. </return>
		/// </summary>
		public string ToText()
			=> E_FVector_ToText(this);
		
		
		/// <summary>
		/// <para>Converts a Cartesian unit vector into spherical coordinates on the unit sphere. </para>
		/// <return>Output Theta will be in the range [0, PI], and output Phi will be in the range [-PI, PI]. </return>
		/// </summary>
		public FVector2D UnitCartesianToSpherical()
			=> E_FVector_UnitCartesianToSpherical(this);
		
		public FVector UnsafeNormal()
			=> E_FVector_UnsafeNormal(this);
		
		
		/// <summary>
		/// <para>When this vector contains Euler angles (degrees), ensure that angles are between +/-180 </para>
		/// </summary>
		public void UnwindEuler()
			=> E_FVector_UnwindEuler(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVector Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FVector(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector(Adress, false);
		}}}
