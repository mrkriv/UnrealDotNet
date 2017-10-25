using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Core\Public\Math\Quat.h:28

namespace UnrealEngine
{
	public  partial class FQuat : NativeStructWrapper
	{
		internal FQuat(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FQuat() :
			base(E_CreateStruct_FQuat(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InX">X component of the quaternion </param>
		/// <param name="InY">Y component of the quaternion </param>
		/// <param name="InZ">Z component of the quaternion </param>
		/// <param name="InW">W component of the quaternion </param>
		/// </summary>
		public FQuat(float InX, float InY, float InZ, float InW) :
			base(E_CreateStruct_FQuat_float_float_float_float(InX, InY, InZ, InW), false)
		{
		}

		
		/// <summary>
		/// <para>Copy constructor. </para>
		/// <param name="Q">A FQuat object to use to create new quaternion from. </param>
		/// </summary>
		public FQuat(FQuat Q) :
			base(E_CreateStruct_FQuat_FQuat(Q), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new quaternion from the given rotator. </para>
		/// <param name="R">The rotator to initialize from. </param>
		/// </summary>
		public FQuat(FRotator R) :
			base(E_CreateStruct_FQuat_FRotator(R), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new quaternion from the a rotation around the given axis. </para>
		/// <param name="Axis">assumed to be a normalized vector </param>
		/// <param name="Angle">angle to rotate above the given axis (in radians) </param>
		/// </summary>
		public FQuat(FVector Axis, float AngleRad) :
			base(E_CreateStruct_FQuat_FVector_float(Axis, AngleRad), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat_float_float_float_float(float InX, float InY, float InZ, float InW);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat_FQuat(IntPtr Q);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat_FRotator(IntPtr R);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FQuat_FVector_float(IntPtr Axis, float AngleRad);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQuat_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuat_W_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQuat_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuat_X_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQuat_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuat_Y_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FQuat_Z_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FQuat_Z_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_AngularDistance(IntPtr Self, IntPtr Q);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_CalcTangents(IntPtr Self, IntPtr PrevP, IntPtr P, IntPtr NextP, float Tension, IntPtr OutTan);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FQuat_ContainsNaN(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_EnforceShortestArcWith(IntPtr Self, IntPtr OtherQuat);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FQuat_Equals(IntPtr Self, IntPtr Q, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_Error(IntPtr Self, IntPtr Q1, IntPtr Q2);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_ErrorAutoNormalize(IntPtr Self, IntPtr A, IntPtr B);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Euler(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Exp(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FastBilerp(IntPtr Self, IntPtr P00, IntPtr P10, IntPtr P01, IntPtr P11, float FracX, float FracY);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FastLerp(IntPtr Self, IntPtr A, IntPtr B, float Alpha);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FindBetween(IntPtr Self, IntPtr Vector1, IntPtr Vector2);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FindBetweenNormals(IntPtr Self, IntPtr Normal1, IntPtr Normal2);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_FindBetweenVectors(IntPtr Self, IntPtr Vector1, IntPtr Vector2);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetAxisX(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetAxisY(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetAxisZ(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetForwardVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetNormalized(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetRightVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetRotationAxis(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_GetUpVector(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Inverse(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FQuat_IsIdentity(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FQuat_IsNormalized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Log(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_MakeFromEuler(IntPtr Self, IntPtr Euler);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_Normalize(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_RotateVector(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Rotator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_Size(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FQuat_SizeSquared(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Slerp(IntPtr Self, IntPtr Quat1, IntPtr Quat2, float Slerp);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Slerp_NotNormalized(IntPtr Self, IntPtr Quat1, IntPtr Quat2, float Slerp);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_SlerpFullPath(IntPtr Self, IntPtr quat1, IntPtr quat2, float Alpha);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_SlerpFullPath_NotNormalized(IntPtr Self, IntPtr quat1, IntPtr quat2, float Alpha);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Squad(IntPtr Self, IntPtr quat1, IntPtr tang1, IntPtr quat2, IntPtr tang2, float Alpha);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_SquadFullPath(IntPtr Self, IntPtr quat1, IntPtr tang1, IntPtr quat2, IntPtr tang2, float Alpha);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_ToAxisAndAngle(IntPtr Self, IntPtr Axis, float Angle);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FQuat_ToString(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FQuat_ToSwingTwist(IntPtr Self, IntPtr InTwistAxis, IntPtr OutSwing, IntPtr OutTwist);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_UnrotateVector(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Vector(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The quaternion's W-component. </para>
		/// </summary>
		public float W
		{
			get => E_PROP_FQuat_W_GET(NativePointer);
			set => E_PROP_FQuat_W_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The quaternion's X-component. </para>
		/// </summary>
		public float X
		{
			get => E_PROP_FQuat_X_GET(NativePointer);
			set => E_PROP_FQuat_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The quaternion's Y-component. </para>
		/// </summary>
		public float Y
		{
			get => E_PROP_FQuat_Y_GET(NativePointer);
			set => E_PROP_FQuat_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The quaternion's Z-component. </para>
		/// </summary>
		public float Z
		{
			get => E_PROP_FQuat_Z_GET(NativePointer);
			set => E_PROP_FQuat_Z_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Find the angular distance between two rotation quaternions (in radians) </para>
		/// </summary>
		public float AngularDistance(FQuat Q)
			=> E_FQuat_AngularDistance(this, Q);
		
		
		/// <summary>
		/// <para>Calculate tangents between given points </para>
		/// <param name="PrevP">quaternion at P-1 </param>
		/// <param name="P">quaternion to return the tangent </param>
		/// <param name="NextP">quaternion P+1 </param>
		/// <param name="Tension">todo document </param>
		/// <param name="OutTan">Out control point </param>
		/// </summary>
		public void CalcTangents(FQuat PrevP, FQuat P, FQuat NextP, float Tension, FQuat OutTan)
			=> E_FQuat_CalcTangents(this, PrevP, P, NextP, Tension, OutTan);
		
		
		/// <summary>
		/// <para>Utility to check if there are any non-finite values (NaN or Inf) in this Quat. </para>
		/// <return>true if there are any non-finite values in this Quaternion, otherwise false. </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FQuat_ContainsNaN(this);
		
		
		/// <summary>
		/// <para>Enforce that the delta between this Quaternion and another one represents </para>
		/// <para>the shortest possible rotation angle </para>
		/// </summary>
		public void EnforceShortestArcWith(FQuat OtherQuat)
			=> E_FQuat_EnforceShortestArcWith(this, OtherQuat);
		
		
		/// <summary>
		/// <para>Checks whether another Quaternion is equal to this, within specified tolerance. </para>
		/// <param name="Q">The other Quaternion. </param>
		/// <param name="Tolerance">Error tolerance for comparison with other Quaternion. </param>
		/// <return>true if two Quaternions are equal, within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool Equals(FQuat Q, float Tolerance)
			=> E_FQuat_Equals(this, Q, Tolerance);
		
		
		/// <summary>
		/// <para>Error measure (angle) between two quaternions, ranged [0..1]. </para>
		/// <para>Returns the hypersphere-angle between two quaternions; alignment shouldn't matter, though </para>
		/// <para>@note normalized input is expected. </para>
		/// </summary>
		public float Error(FQuat Q1, FQuat Q2)
			=> E_FQuat_Error(this, Q1, Q2);
		
		
		/// <summary>
		/// <para>FQuat::Error with auto-normalization. </para>
		/// </summary>
		public float ErrorAutoNormalize(FQuat A, FQuat B)
			=> E_FQuat_ErrorAutoNormalize(this, A, B);
		
		
		/// <summary>
		/// <para>Convert a Quaternion into floating-point Euler angles (in degrees). </para>
		/// </summary>
		public FVector Euler()
			=> E_FQuat_Euler(this);
		
		
		/// <summary>
		/// <para>@note Exp should really only be used after Log. </para>
		/// <para>Assumes a quaternion with W=0 and V=theta*v (where |v| = 1). </para>
		/// <para>Exp(q) = (sin(theta)*v, cos(theta)) </para>
		/// </summary>
		public FQuat Exp()
			=> E_FQuat_Exp(this);
		
		
		/// <summary>
		/// <para>Bi-Linear Quaternion interpolation. </para>
		/// <para>Result is NOT normalized. </para>
		/// </summary>
		public FQuat FastBilerp(FQuat P00, FQuat P10, FQuat P01, FQuat P11, float FracX, float FracY)
			=> E_FQuat_FastBilerp(this, P00, P10, P01, P11, FracX, FracY);
		
		
		/// <summary>
		/// <para>Fast Linear Quaternion Interpolation. </para>
		/// <para>Result is NOT normalized. </para>
		/// </summary>
		public FQuat FastLerp(FQuat A, FQuat B, float Alpha)
			=> E_FQuat_FastLerp(this, A, B, Alpha);
		
		
		/// <summary>
		/// <para>Generates the 'smallest' (geodesic) rotation between two vectors of arbitrary length. </para>
		/// </summary>
		public FQuat FindBetween(FVector Vector1, FVector Vector2)
			=> E_FQuat_FindBetween(this, Vector1, Vector2);
		
		
		/// <summary>
		/// <para>Generates the 'smallest' (geodesic) rotation between two normals (assumed to be unit length). </para>
		/// </summary>
		public FQuat FindBetweenNormals(FVector Normal1, FVector Normal2)
			=> E_FQuat_FindBetweenNormals(this, Normal1, Normal2);
		
		
		/// <summary>
		/// <para>Generates the 'smallest' (geodesic) rotation between two vectors of arbitrary length. </para>
		/// </summary>
		public FQuat FindBetweenVectors(FVector Vector1, FVector Vector2)
			=> E_FQuat_FindBetweenVectors(this, Vector1, Vector2);
		
		
		/// <summary>
		/// <para>Get the forward direction (X axis) after it has been rotated by this Quaternion. </para>
		/// </summary>
		public FVector GetAxisX()
			=> E_FQuat_GetAxisX(this);
		
		
		/// <summary>
		/// <para>Get the right direction (Y axis) after it has been rotated by this Quaternion. </para>
		/// </summary>
		public FVector GetAxisY()
			=> E_FQuat_GetAxisY(this);
		
		
		/// <summary>
		/// <para>Get the up direction (Z axis) after it has been rotated by this Quaternion. </para>
		/// </summary>
		public FVector GetAxisZ()
			=> E_FQuat_GetAxisZ(this);
		
		
		/// <summary>
		/// <para>Get the forward direction (X axis) after it has been rotated by this Quaternion. </para>
		/// </summary>
		public FVector GetForwardVector()
			=> E_FQuat_GetForwardVector(this);
		
		
		/// <summary>
		/// <para>Get a normalized copy of this quaternion. </para>
		/// <para>If it is too small, returns an identity quaternion. </para>
		/// <param name="Tolerance">Minimum squared length of quaternion for normalization. </param>
		/// </summary>
		public FQuat GetNormalized(float Tolerance)
			=> E_FQuat_GetNormalized(this, Tolerance);
		
		
		/// <summary>
		/// <para>Get the right direction (Y axis) after it has been rotated by this Quaternion. </para>
		/// </summary>
		public FVector GetRightVector()
			=> E_FQuat_GetRightVector(this);
		
		
		/// <summary>
		/// <para>Get the axis of rotation of the Quaternion. </para>
		/// <para>This is the axis around which rotation occurs to transform the canonical coordinate system to the target orientation. </para>
		/// <para>For the identity Quaternion which has no such rotation, FVector(1,0,0) is returned. </para>
		/// </summary>
		public FVector GetRotationAxis()
			=> E_FQuat_GetRotationAxis(this);
		
		
		/// <summary>
		/// <para>Get the up direction (Z axis) after it has been rotated by this Quaternion. </para>
		/// </summary>
		public FVector GetUpVector()
			=> E_FQuat_GetUpVector(this);
		
		
		/// <summary>
		/// <return>inverse of this quaternion </return>
		/// </summary>
		public FQuat Inverse()
			=> E_FQuat_Inverse(this);
		
		
		/// <summary>
		/// <para>Checks whether this Quaternion is an Identity Quaternion. </para>
		/// <para>Assumes Quaternion tested is normalized. </para>
		/// <param name="Tolerance">Error tolerance for comparison with Identity Quaternion. </param>
		/// <return>true if Quaternion is a normalized Identity Quaternion. </return>
		/// </summary>
		public bool IsIdentity(float Tolerance)
			=> E_FQuat_IsIdentity(this, Tolerance);
		
		public bool IsNormalized()
			=> E_FQuat_IsNormalized(this);
		
		
		/// <summary>
		/// <return>quaternion with W=0 and V=theta*v. </return>
		/// </summary>
		public FQuat Log()
			=> E_FQuat_Log(this);
		
		
		/// <summary>
		/// <para>Convert a vector of floating-point Euler angles (in degrees) into a Quaternion. </para>
		/// <param name="Euler">the Euler angles </param>
		/// <return>constructed FQuat </return>
		/// </summary>
		public FQuat MakeFromEuler(FVector Euler)
			=> E_FQuat_MakeFromEuler(this, Euler);
		
		
		/// <summary>
		/// <para>Normalize this quaternion if it is large enough. </para>
		/// <para>If it is too small, returns an identity quaternion. </para>
		/// <param name="Tolerance">Minimum squared length of quaternion for normalization. </param>
		/// </summary>
		public void Normalize(float Tolerance)
			=> E_FQuat_Normalize(this, Tolerance);
		
		
		/// <summary>
		/// <para>Rotate a vector by this quaternion. </para>
		/// <param name="V">the vector to be rotated </param>
		/// <return>vector after rotation </return>
		/// </summary>
		public FVector RotateVector(FVector V)
			=> E_FQuat_RotateVector(this, V);
		
		
		/// <summary>
		/// <para>Get the FRotator representation of this Quaternion. </para>
		/// </summary>
		public FRotator Rotator()
			=> E_FQuat_Rotator(this);
		
		
		/// <summary>
		/// <para>Get the length of this quaternion. </para>
		/// <return>The length of this quaternion. </return>
		/// </summary>
		public float Size()
			=> E_FQuat_Size(this);
		
		
		/// <summary>
		/// <para>Get the length squared of this quaternion. </para>
		/// <return>The length of this quaternion. </return>
		/// </summary>
		public float SizeSquared()
			=> E_FQuat_SizeSquared(this);
		
		
		/// <summary>
		/// <para>Spherical interpolation. Will correct alignment. Result is normalized. </para>
		/// </summary>
		public FQuat Slerp(FQuat Quat1, FQuat Quat2, float Slerp)
			=> E_FQuat_Slerp(this, Quat1, Quat2, Slerp);
		
		
		/// <summary>
		/// <para>Spherical interpolation. Will correct alignment. Result is NOT normalized. </para>
		/// </summary>
		public FQuat Slerp_NotNormalized(FQuat Quat1, FQuat Quat2, float Slerp)
			=> E_FQuat_Slerp_NotNormalized(this, Quat1, Quat2, Slerp);
		
		
		/// <summary>
		/// <para>Simpler Slerp that doesn't do any checks for 'shortest distance' etc. </para>
		/// <para>We need this for the cubic interpolation stuff so that the multiple Slerps dont go in different directions. </para>
		/// <para>Result is normalized. </para>
		/// </summary>
		public FQuat SlerpFullPath(FQuat quat1, FQuat quat2, float Alpha)
			=> E_FQuat_SlerpFullPath(this, quat1, quat2, Alpha);
		
		
		/// <summary>
		/// <para>Simpler Slerp that doesn't do any checks for 'shortest distance' etc. </para>
		/// <para>We need this for the cubic interpolation stuff so that the multiple Slerps dont go in different directions. </para>
		/// <para>Result is NOT normalized. </para>
		/// </summary>
		public FQuat SlerpFullPath_NotNormalized(FQuat quat1, FQuat quat2, float Alpha)
			=> E_FQuat_SlerpFullPath_NotNormalized(this, quat1, quat2, Alpha);
		
		
		/// <summary>
		/// <para>Given start and end quaternions of quat1 and quat2, and tangents at those points tang1 and tang2, calculate the point at Alpha (between 0 and 1) between them. Result is normalized. </para>
		/// <para>This will correct alignment by ensuring that the shortest path is taken. </para>
		/// </summary>
		public FQuat Squad(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, float Alpha)
			=> E_FQuat_Squad(this, quat1, tang1, quat2, tang2, Alpha);
		
		
		/// <summary>
		/// <para>Simpler Squad that doesn't do any checks for 'shortest distance' etc. </para>
		/// <para>Given start and end quaternions of quat1 and quat2, and tangents at those points tang1 and tang2, calculate the point at Alpha (between 0 and 1) between them. Result is normalized. </para>
		/// </summary>
		public FQuat SquadFullPath(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, float Alpha)
			=> E_FQuat_SquadFullPath(this, quat1, tang1, quat2, tang2, Alpha);
		
		
		/// <summary>
		/// <para>get the axis and angle of rotation of this quaternion </para>
		/// <param name="Axis">out] vector of axis of the quaternion </param>
		/// <param name="Angle">out] angle of the quaternion </param>
		/// <para>@warning : assumes normalized quaternions. </para>
		/// </summary>
		public void ToAxisAndAngle(FVector Axis, float Angle)
			=> E_FQuat_ToAxisAndAngle(this, Axis, Angle);
		
		
		/// <summary>
		/// <para>Get a textual representation of the vector. </para>
		/// <return>Text describing the vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FQuat_ToString(this);
		
		
		/// <summary>
		/// <para>Get the swing and twist decomposition for a specified axis </para>
		/// <param name="InTwistAxis">Axis to use for decomposition </param>
		/// <param name="OutSwing">swing component quaternion </param>
		/// <param name="OutTwist">Twist component quaternion </param>
		/// <para>@warning assumes normalised quaternion and twist axis </para>
		/// </summary>
		public void ToSwingTwist(FVector InTwistAxis, FQuat OutSwing, FQuat OutTwist)
			=> E_FQuat_ToSwingTwist(this, InTwistAxis, OutSwing, OutTwist);
		
		
		/// <summary>
		/// <para>Rotate a vector by the inverse of this quaternion. </para>
		/// <param name="V">the vector to be rotated </param>
		/// <return>vector after rotation by the inverse of this quaternion. </return>
		/// </summary>
		public FVector UnrotateVector(FVector V)
			=> E_FQuat_UnrotateVector(this, V);
		
		
		/// <summary>
		/// <para>Convert a rotation into a unit vector facing in its direction. Equivalent to GetForwardVector(). </para>
		/// </summary>
		public FVector Vector()
			=> E_FQuat_Vector(this);
		
		#endregion
		
		public static implicit operator IntPtr(FQuat Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FQuat(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FQuat(Adress, false);
		}}}
