using System;
using System.Runtime.InteropServices;

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
		private static extern bool E_FQuat_ContainsNaN(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Euler(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FQuat_Exp(IntPtr Self);
		
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
		private static extern StringWrapper E_FQuat_ToString(IntPtr Self);
		
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
		/// <para>Utility to check if there are any non-finite values (NaN or Inf) in this Quat. </para>
		/// <return>true if there are any non-finite values in this Quaternion, otherwise false. </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FQuat_ContainsNaN(this);
		
		
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
		/// <para>Get a textual representation of the vector. </para>
		/// <return>Text describing the vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FQuat_ToString(this);
		
		
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
