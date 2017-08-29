using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Floating point quaternion that can represent a rotation about an axis in 3-D space.
	/// The X, Y, Z, W components also double as the Axis/Angle format.
	/// Order matters when composing quaternions: C = A * B will yield a quaternion C that logically
	/// first applies B then A to any subsequent transformation (right first, then left).
	/// Note that this is the opposite order of FTransform multiplication.
	/// Example: LocalToWorld = (LocalToWorld * DeltaRotation) will change rotation in local space by DeltaRotation.
	/// Example: LocalToWorld = (DeltaRotation * LocalToWorld) will change rotation in world space by DeltaRotation.
	/// </summary>
	public partial class FQuat
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FQuat()
		{
			NativePointer = E_CreateStruct_FQuat();
			IsRef = false;
		}

		internal FQuat(IntPtr NativePointer, bool IsRef)
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
		private static extern IntPtr E_CreateStruct_FQuat();
		
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
		private static extern float E_Struct_FQuat_X_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FQuat_X_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_FQuat_Y_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FQuat_Y_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_FQuat_Z_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FQuat_Z_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_Struct_FQuat_W_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FQuat_W_SET(IntPtr Ptr, float Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_OP_FQuat_p(FQuat Self, IntPtr Q);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FQuat_Equals(FQuat Self, IntPtr Q, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FQuat_IsIdentity(FQuat Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_OP_FQuat_i(FQuat Self, IntPtr Q);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_MakeFromEuler(FQuat Self, IntPtr Euler);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_Euler(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_Normalize(FQuat Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_GetNormalized(FQuat Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FQuat_IsNormalized(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FQuat_Size(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_ToAxisAndAngle(FQuat Self, IntPtr Axis, float Angle);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_ToSwingTwist(FQuat Self, IntPtr InTwistAxis, IntPtr OutSwing, IntPtr OutTwist);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_RotateVector(FQuat Self, IntPtr V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_Log(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_EnforceShortestArcWith(FQuat Self, IntPtr OtherQuat);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_Rotator(FQuat Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_FindBetween(FQuat Self, IntPtr Vector1, IntPtr Vector2);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FQuat_Error(FQuat Self, IntPtr Q1, IntPtr Q2);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_FastLerp(FQuat Self, IntPtr A, IntPtr B, float Alpha);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_FastBilerp(FQuat Self, IntPtr P00, IntPtr P10, IntPtr P01, IntPtr P11, float FracX, float FracY);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_Slerp_NotNormalized(FQuat Self, IntPtr Quat1, IntPtr Quat2, float Slerp);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FQuat_Squad(FQuat Self, IntPtr quat1, IntPtr tang1, IntPtr quat2, IntPtr tang2, float Alpha);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FQuat_CalcTangents(FQuat Self, IntPtr PrevP, IntPtr P, IntPtr NextP, float Tension, IntPtr OutTan);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The quaternion's X-component.
		/// </summary>
		public float X
		{
			get => E_Struct_FQuat_X_GET(NativePointer);
			set => E_Struct_FQuat_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The quaternion's Y-component.
		/// </summary>
		public float Y
		{
			get => E_Struct_FQuat_Y_GET(NativePointer);
			set => E_Struct_FQuat_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The quaternion's Z-component.
		/// </summary>
		public float Z
		{
			get => E_Struct_FQuat_Z_GET(NativePointer);
			set => E_Struct_FQuat_Z_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The quaternion's W-component.
		/// </summary>
		public float W
		{
			get => E_Struct_FQuat_W_GET(NativePointer);
			set => E_Struct_FQuat_W_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Gets the result of adding a Quaternion to this.
		/// This is a component-wise addition; composing quaternions should be done via multiplication.
		/// @param Q The Quaternion to add.
		/// @return The result of addition.
		/// </summary>
		public static FQuat operator+(FQuat Self, FQuat Q)
			=> E_OP_FQuat_p(Self, Q);
		
		
		/// <summary>
		/// Checks whether another Quaternion is equal to this, within specified tolerance.
		/// @param Q The other Quaternion.
		/// @param Tolerance Error tolerance for comparison with other Quaternion.
		/// @return true if two Quaternions are equal, within specified tolerance, otherwise false.
		/// </summary>
		public bool Equals(FQuat Q, float Tolerance)
			=> E_FQuat_Equals(this, Q, Tolerance);
		
		
		/// <summary>
		/// Checks whether this Quaternion is an Identity Quaternion.
		/// Assumes Quaternion tested is normalized.
		/// @param Tolerance Error tolerance for comparison with Identity Quaternion.
		/// @return true if Quaternion is a normalized Identity Quaternion.
		/// </summary>
		public bool IsIdentity(float Tolerance)
			=> E_FQuat_IsIdentity(this, Tolerance);
		
		
		/// <summary>
		/// Calculates dot product of two quaternions.
		/// @param Q The other quaternions.
		/// @return The dot product.
		/// </summary>
		public static float operator|(FQuat Self, FQuat Q)
			=> E_OP_FQuat_i(Self, Q);
		
		
		/// <summary>
		/// Convert a vector of floating-point Euler angles (in degrees) into a Quaternion.
		/// @param Euler the Euler angles
		/// @return constructed FQuat
		/// </summary>
		public FQuat MakeFromEuler(FVector Euler)
			=> E_FQuat_MakeFromEuler(this, Euler);
		
		
		/// <summary>
		/// Convert a Quaternion into floating-point Euler angles (in degrees).
		/// </summary>
		public FVector Euler()
			=> E_FQuat_Euler(this);
		
		
		/// <summary>
		/// Normalize this quaternion if it is large enough.
		/// If it is too small, returns an identity quaternion.
		/// @param Tolerance Minimum squared length of quaternion for normalization.
		/// </summary>
		public void Normalize(float Tolerance)
			=> E_FQuat_Normalize(this, Tolerance);
		
		
		/// <summary>
		/// Get a normalized copy of this quaternion.
		/// If it is too small, returns an identity quaternion.
		/// @param Tolerance Minimum squared length of quaternion for normalization.
		/// </summary>
		public FQuat GetNormalized(float Tolerance)
			=> E_FQuat_GetNormalized(this, Tolerance);
		
		public bool IsNormalized()
			=> E_FQuat_IsNormalized(this);
		
		
		/// <summary>
		/// Get the length of this quaternion.
		/// @return The length of this quaternion.
		/// </summary>
		public float Size()
			=> E_FQuat_Size(this);
		
		
		/// <summary>
		/// get the axis and angle of rotation of this quaternion
		/// @param Axis{out] vector of axis of the quaternion
		/// @param Angle{out] angle of the quaternion
		/// @warning : assumes normalized quaternions.
		/// </summary>
		public void ToAxisAndAngle(FVector Axis, float Angle)
			=> E_FQuat_ToAxisAndAngle(this, Axis, Angle);
		
		
		/// <summary>
		/// Get the swing and twist decomposition for a specified axis
		/// @param InTwistAxis Axis to use for decomposition
		/// @param OutSwing swing component quaternion
		/// @param OutTwist Twist component quaternion
		/// @warning assumes normalised quaternion and twist axis
		/// </summary>
		public void ToSwingTwist(FVector InTwistAxis, FQuat OutSwing, FQuat OutTwist)
			=> E_FQuat_ToSwingTwist(this, InTwistAxis, OutSwing, OutTwist);
		
		
		/// <summary>
		/// Rotate a vector by this quaternion.
		/// @param V the vector to be rotated
		/// @return vector after rotation
		/// </summary>
		public FVector RotateVector(FVector V)
			=> E_FQuat_RotateVector(this, V);
		
		
		/// <summary>
		/// @return quaternion with W=0 and V=theta*v.
		/// </summary>
		public FQuat Log()
			=> E_FQuat_Log(this);
		
		
		/// <summary>
		/// Enforce that the delta between this Quaternion and another one represents
		/// the shortest possible rotation angle
		/// </summary>
		public void EnforceShortestArcWith(FQuat OtherQuat)
			=> E_FQuat_EnforceShortestArcWith(this, OtherQuat);
		
		
		/// <summary>
		/// Get the FRotator representation of this Quaternion.
		/// </summary>
		public FRotator Rotator()
			=> E_FQuat_Rotator(this);
		
		
		/// <summary>
		/// Generates the 'smallest' (geodesic) rotation between two vectors of arbitrary length.
		/// </summary>
		public FQuat FindBetween(FVector Vector1, FVector Vector2)
			=> E_FQuat_FindBetween(this, Vector1, Vector2);
		
		
		/// <summary>
		/// Error measure (angle) between two quaternions, ranged [0..1].
		/// Returns the hypersphere-angle between two quaternions; alignment shouldn't matter, though
		/// @note normalized input is expected.
		/// </summary>
		public float Error(FQuat Q1, FQuat Q2)
			=> E_FQuat_Error(this, Q1, Q2);
		
		
		/// <summary>
		/// Fast Linear Quaternion Interpolation.
		/// Result is NOT normalized.
		/// </summary>
		public FQuat FastLerp(FQuat A, FQuat B, float Alpha)
			=> E_FQuat_FastLerp(this, A, B, Alpha);
		
		
		/// <summary>
		/// Bi-Linear Quaternion interpolation.
		/// Result is NOT normalized.
		/// </summary>
		public FQuat FastBilerp(FQuat P00, FQuat P10, FQuat P01, FQuat P11, float FracX, float FracY)
			=> E_FQuat_FastBilerp(this, P00, P10, P01, P11, FracX, FracY);
		
		
		/// <summary>
		/// Spherical interpolation. Will correct alignment. Result is NOT normalized.
		/// </summary>
		public FQuat Slerp_NotNormalized(FQuat Quat1, FQuat Quat2, float Slerp)
			=> E_FQuat_Slerp_NotNormalized(this, Quat1, Quat2, Slerp);
		
		
		/// <summary>
		/// Given start and end quaternions of quat1 and quat2, and tangents at those points tang1 and tang2, calculate the point at Alpha (between 0 and 1) between them. Result is normalized.
		/// This will correct alignment by ensuring that the shortest path is taken.
		/// </summary>
		public FQuat Squad(FQuat quat1, FQuat tang1, FQuat quat2, FQuat tang2, float Alpha)
			=> E_FQuat_Squad(this, quat1, tang1, quat2, tang2, Alpha);
		
		
		/// <summary>
		/// Calculate tangents between given points
		/// @param PrevP quaternion at P-1
		/// @param P quaternion to return the tangent
		/// @param NextP quaternion P+1
		/// @param Tension @todo document
		/// @param OutTan Out control point
		/// </summary>
		public void CalcTangents(FQuat PrevP, FQuat P, FQuat NextP, float Tension, FQuat OutTan)
			=> E_FQuat_CalcTangents(this, PrevP, P, NextP, Tension, OutTan);
		
		#endregion
		
		public static implicit operator IntPtr(FQuat Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FQuat(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FQuat(Adress, false);
		}}}
