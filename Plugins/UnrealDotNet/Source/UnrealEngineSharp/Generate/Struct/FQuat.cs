// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Quat.h:28

namespace UnrealEngine
{
	public  partial class FQuat : NativeStructWrapper
	{
		internal FQuat(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FQuat() :
			base(E_CreateStruct_FQuat(), false)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="inX">X component of the quaternion</param>
		/// <param name="inY">Y component of the quaternion</param>
		/// <param name="inZ">Z component of the quaternion</param>
		/// <param name="inW">W component of the quaternion</param>
		public FQuat(float inX, float inY, float inZ, float inW) :
			base(E_CreateStruct_FQuat_float_float_float_float(inX, inY, inZ, inW), false)
		{
		}

		
		/// <summary>
		/// Copy constructor.
		/// </summary>
		/// <param name="q">A FQuat object to use to create new quaternion from.</param>
		public FQuat(FQuat q) :
			base(E_CreateStruct_FQuat_FQuat(q), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new quaternion from the given matrix.
		/// </summary>
		/// <param name="m">The rotation matrix to initialize from.</param>
		public FQuat(FMatrix m) :
			base(E_CreateStruct_FQuat_FMatrix(m), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new quaternion from the given rotator.
		/// </summary>
		/// <param name="r">The rotator to initialize from.</param>
		public FQuat(FRotator r) :
			base(E_CreateStruct_FQuat_FRotator(r), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new quaternion from the a rotation around the given axis.
		/// </summary>
		/// <param name="axis">assumed to be a normalized vector</param>
		/// <param name="angle">angle to rotate above the given axis (in radians)</param>
		public FQuat(FVector axis, float angleRad) :
			base(E_CreateStruct_FQuat_FVector_float(axis, angleRad), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQuat_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuat_W_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQuat_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuat_X_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQuat_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuat_Y_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQuat_Z_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuat_Z_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat_float_float_float_float(float inX, float inY, float inZ, float inW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat_FQuat(IntPtr q);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat_FMatrix(IntPtr m);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat_FRotator(IntPtr r);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat_FVector_float(IntPtr axis, float angleRad);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_AngularDistance(IntPtr self, IntPtr q);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_CalcTangents(IntPtr self, IntPtr prevP, IntPtr p, IntPtr nextP, float tension, IntPtr outTan);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FQuat_ContainsNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_DiagnosticCheckNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_EnforceShortestArcWith(IntPtr self, IntPtr otherQuat);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FQuat_Equals(IntPtr self, IntPtr q, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_Error(IntPtr self, IntPtr q1, IntPtr q2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_ErrorAutoNormalize(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Euler(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Exp(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FastBilerp(IntPtr self, IntPtr p00, IntPtr p10, IntPtr p01, IntPtr p11, float fracX, float fracY);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FastLerp(IntPtr self, IntPtr a, IntPtr b, float alpha);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FindBetween(IntPtr self, IntPtr vector1, IntPtr vector2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FindBetweenNormals(IntPtr self, IntPtr normal1, IntPtr normal2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FindBetweenVectors(IntPtr self, IntPtr vector1, IntPtr vector2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_GetAngle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetAxisX(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetAxisY(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetAxisZ(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetForwardVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetNormalized(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetRightVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetRotationAxis(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetUpVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FQuat_InitFromString(IntPtr self, string inSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Inverse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FQuat_IsIdentity(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FQuat_IsNormalized(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Log(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_MakeFromEuler(IntPtr self, IntPtr euler);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_Normalize(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_RotateVector(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Rotator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_Size(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_SizeSquared(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Slerp(IntPtr self, IntPtr quat1, IntPtr quat2, float slerp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Slerp_NotNormalized(IntPtr self, IntPtr quat1, IntPtr quat2, float slerp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_SlerpFullPath(IntPtr self, IntPtr quat1, IntPtr quat2, float alpha);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_SlerpFullPath_NotNormalized(IntPtr self, IntPtr quat1, IntPtr quat2, float alpha);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Squad(IntPtr self, IntPtr quat1, IntPtr tang1, IntPtr quat2, IntPtr tang2, float alpha);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_SquadFullPath(IntPtr self, IntPtr quat1, IntPtr tang1, IntPtr quat2, IntPtr tang2, float alpha);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_ToAxisAndAngle(IntPtr self, IntPtr axis, float angle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FQuat_ToString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_ToSwingTwist(IntPtr self, IntPtr inTwistAxis, IntPtr outSwing, IntPtr outTwist);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_UnrotateVector(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Vector(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The quaternion's W-component.
		/// </summary>
		public float W
		{
			get => E_PROP_FQuat_W_GET(NativePointer);
			set => E_PROP_FQuat_W_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The quaternion's X-component.
		/// </summary>
		public float X
		{
			get => E_PROP_FQuat_X_GET(NativePointer);
			set => E_PROP_FQuat_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The quaternion's Y-component.
		/// </summary>
		public float Y
		{
			get => E_PROP_FQuat_Y_GET(NativePointer);
			set => E_PROP_FQuat_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The quaternion's Z-component.
		/// </summary>
		public float Z
		{
			get => E_PROP_FQuat_Z_GET(NativePointer);
			set => E_PROP_FQuat_Z_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Find the angular distance between two rotation quaternions (in radians)
		/// </summary>
		public float AngularDistance(FQuat q)
			=> E_FQuat_AngularDistance(this, q);
		
		
		/// <summary>
		/// Calculate tangents between given points
		/// </summary>
		/// <param name="prevP">quaternion at P-1</param>
		/// <param name="p">quaternion to return the tangent</param>
		/// <param name="nextP">quaternion P+1</param>
		/// <param name="tension">todo document</param>
		/// <param name="outTan">Out control point</param>
		public void CalcTangents(FQuat prevP, FQuat p, FQuat nextP, float tension, FQuat outTan)
			=> E_FQuat_CalcTangents(this, prevP, p, nextP, tension, outTan);
		
		
		/// <summary>
		/// Utility to check if there are any non-finite values (NaN or Inf) in this Quat.
		/// </summary>
		/// <return>true</return>
		public bool ContainsNaN()
			=> E_FQuat_ContainsNaN(this);
		
		public void DiagnosticCheckNaN()
			=> E_FQuat_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// Enforce that the delta between this Quaternion and another one represents
		/// <para>the shortest possible rotation angle </para>
		/// </summary>
		public void EnforceShortestArcWith(FQuat otherQuat)
			=> E_FQuat_EnforceShortestArcWith(this, otherQuat);
		
		
		/// <summary>
		/// Checks whether another Quaternion is equal to this, within specified tolerance.
		/// </summary>
		/// <param name="q">The other Quaternion.</param>
		/// <param name="tolerance">Error tolerance for comparison with other Quaternion.</param>
		/// <return>true</return>
		public bool Equals(FQuat q, float tolerance)
			=> E_FQuat_Equals(this, q, tolerance);
		
		
		/// <summary>
		/// Error measure (angle) between two quaternions, ranged [0..1].
		/// <para>Returns the hypersphere-angle between two quaternions; alignment shouldn't matter, though </para>
		/// @note normalized input is expected.
		/// </summary>
		public float Error(FQuat q1, FQuat q2)
			=> E_FQuat_Error(this, q1, q2);
		
		
		/// <summary>
		/// FQuat::Error with auto-normalization.
		/// </summary>
		public float ErrorAutoNormalize(FQuat a, FQuat b)
			=> E_FQuat_ErrorAutoNormalize(this, a, b);
		
		
		/// <summary>
		/// Convert a Quaternion into floating-point Euler angles (in degrees).
		/// </summary>
		public FVector Euler()
			=> E_FQuat_Euler(this);
		
		
		/// <summary>
		/// @note Exp should really only be used after Log.
		/// <para>Assumes a quaternion with W=0 and V=theta*v (where |v| = 1). </para>
		/// Exp(q) = (sin(theta)*v, cos(theta))
		/// </summary>
		public FQuat Exp()
			=> E_FQuat_Exp(this);
		
		
		/// <summary>
		/// Bi-Linear Quaternion interpolation.
		/// <para>Result is NOT normalized. </para>
		/// </summary>
		public FQuat FastBilerp(FQuat p00, FQuat p10, FQuat p01, FQuat p11, float fracX, float fracY)
			=> E_FQuat_FastBilerp(this, p00, p10, p01, p11, fracX, fracY);
		
		
		/// <summary>
		/// Fast Linear Quaternion Interpolation.
		/// <para>Result is NOT normalized. </para>
		/// </summary>
		public FQuat FastLerp(FQuat a, FQuat b, float alpha)
			=> E_FQuat_FastLerp(this, a, b, alpha);
		
		
		/// <summary>
		/// Generates the 'smallest' (geodesic) rotation between two vectors of arbitrary length.
		/// </summary>
		public FQuat FindBetween(FVector vector1, FVector vector2)
			=> E_FQuat_FindBetween(this, vector1, vector2);
		
		
		/// <summary>
		/// Generates the 'smallest' (geodesic) rotation between two normals (assumed to be unit length).
		/// </summary>
		public FQuat FindBetweenNormals(FVector normal1, FVector normal2)
			=> E_FQuat_FindBetweenNormals(this, normal1, normal2);
		
		
		/// <summary>
		/// Generates the 'smallest' (geodesic) rotation between two vectors of arbitrary length.
		/// </summary>
		public FQuat FindBetweenVectors(FVector vector1, FVector vector2)
			=> E_FQuat_FindBetweenVectors(this, vector1, vector2);
		
		
		/// <summary>
		/// Get the angle of this quaternion
		/// </summary>
		public float GetAngle()
			=> E_FQuat_GetAngle(this);
		
		
		/// <summary>
		/// Get the forward direction (X axis) after it has been rotated by this Quaternion.
		/// </summary>
		public FVector GetAxisX()
			=> E_FQuat_GetAxisX(this);
		
		
		/// <summary>
		/// Get the right direction (Y axis) after it has been rotated by this Quaternion.
		/// </summary>
		public FVector GetAxisY()
			=> E_FQuat_GetAxisY(this);
		
		
		/// <summary>
		/// Get the up direction (Z axis) after it has been rotated by this Quaternion.
		/// </summary>
		public FVector GetAxisZ()
			=> E_FQuat_GetAxisZ(this);
		
		
		/// <summary>
		/// Get the forward direction (X axis) after it has been rotated by this Quaternion.
		/// </summary>
		public FVector GetForwardVector()
			=> E_FQuat_GetForwardVector(this);
		
		
		/// <summary>
		/// Get a normalized copy of this quaternion.
		/// <para>If it is too small, returns an identity quaternion. </para>
		/// </summary>
		/// <param name="tolerance">Minimum squared length of quaternion for normalization.</param>
		public FQuat GetNormalized(float tolerance)
			=> E_FQuat_GetNormalized(this, tolerance);
		
		
		/// <summary>
		/// Get the right direction (Y axis) after it has been rotated by this Quaternion.
		/// </summary>
		public FVector GetRightVector()
			=> E_FQuat_GetRightVector(this);
		
		
		/// <summary>
		/// Get the axis of rotation of the Quaternion.
		/// <para>This is the axis around which rotation occurs to transform the canonical coordinate system to the target orientation. </para>
		/// For the identity Quaternion which has no such rotation, FVector(1,0,0) is returned.
		/// </summary>
		public FVector GetRotationAxis()
			=> E_FQuat_GetRotationAxis(this);
		
		
		/// <summary>
		/// Get the up direction (Z axis) after it has been rotated by this Quaternion.
		/// </summary>
		public FVector GetUpVector()
			=> E_FQuat_GetUpVector(this);
		
		
		/// <summary>
		/// Initialize this FQuat from a FString.
		/// <para>The string is expected to contain X=, Y=, Z=, W=, otherwise </para>
		/// this FQuat will have indeterminate (invalid) values.
		/// </summary>
		/// <param name="inSourceString">FString containing the quaternion values.</param>
		/// <return>true</return>
		public bool InitFromString(string inSourceString)
			=> E_FQuat_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// </summary>
		/// <return>inverse</return>
		public FQuat Inverse()
			=> E_FQuat_Inverse(this);
		
		
		/// <summary>
		/// Checks whether this Quaternion is an Identity Quaternion.
		/// <para>Assumes Quaternion tested is normalized. </para>
		/// </summary>
		/// <param name="tolerance">Error tolerance for comparison with Identity Quaternion.</param>
		/// <return>true</return>
		public bool IsIdentity(float tolerance)
			=> E_FQuat_IsIdentity(this, tolerance);
		
		public bool IsNormalized()
			=> E_FQuat_IsNormalized(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>quaternion</return>
		public FQuat Log()
			=> E_FQuat_Log(this);
		
		
		/// <summary>
		/// Convert a vector of floating-point Euler angles (in degrees) into a Quaternion.
		/// </summary>
		/// <param name="euler">the Euler angles</param>
		/// <return>constructed</return>
		public FQuat MakeFromEuler(FVector euler)
			=> E_FQuat_MakeFromEuler(this, euler);
		
		
		/// <summary>
		/// Normalize this quaternion if it is large enough.
		/// <para>If it is too small, returns an identity quaternion. </para>
		/// </summary>
		/// <param name="tolerance">Minimum squared length of quaternion for normalization.</param>
		public void Normalize(float tolerance)
			=> E_FQuat_Normalize(this, tolerance);
		
		
		/// <summary>
		/// Rotate a vector by this quaternion.
		/// </summary>
		/// <param name="v">the vector to be rotated</param>
		/// <return>vector</return>
		public FVector RotateVector(FVector v)
			=> E_FQuat_RotateVector(this, v);
		
		
		/// <summary>
		/// Get the FRotator representation of this Quaternion.
		/// </summary>
		public FRotator Rotator()
			=> E_FQuat_Rotator(this);
		
		
		/// <summary>
		/// Get the length of this quaternion.
		/// </summary>
		/// <return>The</return>
		public float Size()
			=> E_FQuat_Size(this);
		
		
		/// <summary>
		/// Get the length squared of this quaternion.
		/// </summary>
		/// <return>The</return>
		public float SizeSquared()
			=> E_FQuat_SizeSquared(this);
		
		
		/// <summary>
		/// Spherical interpolation. Will correct alignment. Result is normalized.
		/// </summary>
		public FQuat Slerp(FQuat quat1, FQuat quat2, float slerp)
			=> E_FQuat_Slerp(this, quat1, quat2, slerp);
		
		
		/// <summary>
		/// Spherical interpolation. Will correct alignment. Result is NOT normalized.
		/// </summary>
		public FQuat Slerp_NotNormalized(FQuat quat1, FQuat quat2, float slerp)
			=> E_FQuat_Slerp_NotNormalized(this, quat1, quat2, slerp);
		
		
		/// <summary>
		/// Simpler Slerp that doesn't do any checks for 'shortest distance' etc.
		/// <para>We need this for the cubic interpolation stuff so that the multiple Slerps dont go in different directions. </para>
		/// Result is normalized.
		/// </summary>
		public FQuat SlerpFullPath(FQuat quat1, FQuat quat2, float alpha)
			=> E_FQuat_SlerpFullPath(this, quat1, quat2, alpha);
		
		
		/// <summary>
		/// Simpler Slerp that doesn't do any checks for 'shortest distance' etc.
		/// <para>We need this for the cubic interpolation stuff so that the multiple Slerps dont go in different directions. </para>
		/// Result is NOT normalized.
		/// </summary>
		public FQuat SlerpFullPath_NotNormalized(FQuat quat1, FQuat quat2, float alpha)
			=> E_FQuat_SlerpFullPath_NotNormalized(this, quat1, quat2, alpha);
		
		
		/// <summary>
		/// Given start and end quaternions of quat1 and quat2, and tangents at those points tang1 and tang2, calculate the point at Alpha (between 0 and 1) between them. Result is normalized.
		/// <para>This will correct alignment by ensuring that the shortest path is taken. </para>
		/// </summary>
		public FQuat Squad(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, float alpha)
			=> E_FQuat_Squad(this, quat1, tang1, quat2, tang2, alpha);
		
		
		/// <summary>
		/// Simpler Squad that doesn't do any checks for 'shortest distance' etc.
		/// <para>Given start and end quaternions of quat1 and quat2, and tangents at those points tang1 and tang2, calculate the point at Alpha (between 0 and 1) between them. Result is normalized. </para>
		/// </summary>
		public FQuat SquadFullPath(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, float alpha)
			=> E_FQuat_SquadFullPath(this, quat1, tang1, quat2, tang2, alpha);
		
		
		/// <summary>
		/// get the axis and angle of rotation of this quaternion
		/// <para>@warning : assumes normalized quaternions. </para>
		/// </summary>
		/// <param name="axis">out] vector of axis of the quaternion</param>
		/// <param name="angle">out] angle of the quaternion</param>
		public void ToAxisAndAngle(FVector axis, float angle)
			=> E_FQuat_ToAxisAndAngle(this, axis, angle);
		
		
		/// <summary>
		/// Get a textual representation of the vector.
		/// </summary>
		/// <return>Text</return>
		public override string ToString()
			=> E_FQuat_ToString(this);
		
		
		/// <summary>
		/// Get the swing and twist decomposition for a specified axis
		/// <para>@warning assumes normalised quaternion and twist axis </para>
		/// </summary>
		/// <param name="inTwistAxis">Axis to use for decomposition</param>
		/// <param name="outSwing">swing component quaternion</param>
		/// <param name="outTwist">Twist component quaternion</param>
		public void ToSwingTwist(FVector inTwistAxis, FQuat outSwing, FQuat outTwist)
			=> E_FQuat_ToSwingTwist(this, inTwistAxis, outSwing, outTwist);
		
		
		/// <summary>
		/// Rotate a vector by the inverse of this quaternion.
		/// </summary>
		/// <param name="v">the vector to be rotated</param>
		/// <return>vector</return>
		public FVector UnrotateVector(FVector v)
			=> E_FQuat_UnrotateVector(this, v);
		
		
		/// <summary>
		/// Convert a rotation into a unit vector facing in its direction. Equivalent to GetForwardVector().
		/// </summary>
		public FVector Vector()
			=> E_FQuat_Vector(this);
		
		#endregion
		
		public static implicit operator IntPtr(FQuat self)
		{
			return self.NativePointer;
		}

		public static implicit operator FQuat(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FQuat(Adress, false);
		}}}
