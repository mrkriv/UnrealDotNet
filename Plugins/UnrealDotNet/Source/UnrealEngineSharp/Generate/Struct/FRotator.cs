// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Rotator.h:18

namespace UnrealEngine
{
	public  partial class FRotator : NativeStructWrapper
	{
		internal FRotator(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FRotator() :
			base(E_CreateStruct_FRotator(), false)
		{
		}

		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="inF">Value to set all components to.</param>
		public FRotator(float inF) :
			base(E_CreateStruct_FRotator_float(inF), false)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="inPitch">Pitch in degrees.</param>
		/// <param name="inYaw">Yaw in degrees.</param>
		/// <param name="inRoll">Roll in degrees.</param>
		public FRotator(float inPitch, float inYaw, float inRoll) :
			base(E_CreateStruct_FRotator_float_float_float(inPitch, inYaw, inRoll), false)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="quat">Quaternion used to specify rotation.</param>
		public FRotator(FQuat quat) :
			base(E_CreateStruct_FRotator_FQuat(quat), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRotator_Pitch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRotator_Pitch_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRotator_Roll_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRotator_Roll_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRotator_Yaw_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRotator_Yaw_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotator();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotator_float(float inF);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotator_float_float_float(float inPitch, float inYaw, float inRoll);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotator_FQuat(IntPtr quat);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Add(IntPtr self, float deltaPitch, float deltaYaw, float deltaRoll);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Clamp(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRotator_ClampAxis(IntPtr self, float angle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FRotator_CompressAxisToByte(IntPtr self, float angle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_ContainsNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRotator_DecompressAxisFromByte(IntPtr self, byte angle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRotator_DiagnosticCheckNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_Equals(IntPtr self, IntPtr r, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Euler(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_GetDenormalized(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_GetEquivalentRotator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_GetInverse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRotator_GetManhattanDistance(IntPtr self, IntPtr rotator);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_GetNormalized(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRotator_GetWindingAndRemainder(IntPtr self, IntPtr winding, IntPtr remainder);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_GridSnap(IntPtr self, IntPtr rotGrid);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_InitFromString(IntPtr self, string inSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_IsNearlyZero(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_IsZero(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_MakeFromEuler(IntPtr self, IntPtr euler);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRotator_Normalize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRotator_NormalizeAxis(IntPtr self, float angle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Quaternion(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_RotateVector(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRotator_SetClosestToMe(IntPtr self, IntPtr makeClosest);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FRotator_ToCompactString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FRotator_ToString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_UnrotateVector(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Vector(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Rotation around the right axis (around Y axis), Looking up and down (0=Straight Ahead, +Up, -Down)
		/// </summary>
		public float Pitch
		{
			get => E_PROP_FRotator_Pitch_GET(NativePointer);
			set => E_PROP_FRotator_Pitch_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Rotation around the forward axis (around X axis), Tilting your head, 0=Straight, +Clockwise, -CCW.
		/// </summary>
		public float Roll
		{
			get => E_PROP_FRotator_Roll_GET(NativePointer);
			set => E_PROP_FRotator_Roll_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Rotation around the up axis (around Z axis), Running in circles 0=East, +North, -South.
		/// </summary>
		public float Yaw
		{
			get => E_PROP_FRotator_Yaw_GET(NativePointer);
			set => E_PROP_FRotator_Yaw_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Adds to each component of the rotator.
		/// </summary>
		/// <param name="deltaPitch">Change in pitch. (+/-)</param>
		/// <param name="deltaYaw">Change in yaw. (+/-)</param>
		/// <param name="deltaRoll">Change in roll. (+/-)</param>
		/// <return>Copy</return>
		public FRotator Add(float deltaPitch, float deltaYaw, float deltaRoll)
			=> E_FRotator_Add(this, deltaPitch, deltaYaw, deltaRoll);
		
		
		/// <summary>
		/// Gets the rotation values so they fall within the range [0,360]
		/// </summary>
		/// <return>Clamped</return>
		public FRotator Clamp()
			=> E_FRotator_Clamp(this);
		
		
		/// <summary>
		/// Clamps an angle to the range of [0, 360).
		/// </summary>
		/// <param name="angle">The angle to clamp.</param>
		/// <return>The</return>
		public float ClampAxis(float angle)
			=> E_FRotator_ClampAxis(this, angle);
		
		
		/// <summary>
		/// Compresses a floating point angle into a byte.
		/// </summary>
		/// <param name="angle">The angle to compress.</param>
		/// <return>The</return>
		public byte CompressAxisToByte(float angle)
			=> E_FRotator_CompressAxisToByte(this, angle);
		
		
		/// <summary>
		/// Utility to check if there are any non-finite values (NaN or Inf) in this Rotator.
		/// </summary>
		/// <return>true</return>
		public bool ContainsNaN()
			=> E_FRotator_ContainsNaN(this);
		
		
		/// <summary>
		/// Decompress a word into a floating point angle.
		/// </summary>
		/// <param name="angle">The word angle.</param>
		/// <return>The</return>
		public float DecompressAxisFromByte(byte angle)
			=> E_FRotator_DecompressAxisFromByte(this, angle);
		
		public void DiagnosticCheckNaN()
			=> E_FRotator_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// Checks whether two rotators are equal within specified tolerance, when treated as an orientation.
		/// <para>This means that FRotator(0, 0, 360).Equals(FRotator(0,0,0)) is true, because they represent the same final orientation. </para>
		/// </summary>
		/// <param name="r">The other rotator.</param>
		/// <param name="tolerance">Error Tolerance.</param>
		/// <return>true</return>
		public bool Equals(FRotator r, float tolerance)
			=> E_FRotator_Equals(this, r, tolerance);
		
		
		/// <summary>
		/// Convert a Rotator into floating-point Euler angles (in degrees). Rotator now stored in degrees.
		/// </summary>
		/// <return>Rotation</return>
		public FVector Euler()
			=> E_FRotator_Euler(this);
		
		
		/// <summary>
		/// Create a copy of this rotator and denormalize, clamping each axis to 0 - 360.
		/// </summary>
		/// <return>Denormalized</return>
		public FRotator GetDenormalized()
			=> E_FRotator_GetDenormalized(this);
		
		
		/// <summary>
		/// Return a Rotator that has the same rotation but has different degree values for Yaw, Pitch, and Roll.
		/// <para>This rotator should be within -180,180 range, </para>
		/// </summary>
		/// <return>A</return>
		public FRotator GetEquivalentRotator()
			=> E_FRotator_GetEquivalentRotator(this);
		
		
		/// <summary>
		/// Returns the inverse of the rotator.
		/// </summary>
		public FRotator GetInverse()
			=> E_FRotator_GetInverse(this);
		
		
		/// <summary>
		/// Return the manhattan distance in degrees between this Rotator and the passed in one.
		/// </summary>
		/// <param name="rotator">In] the Rotator we are comparing with.</param>
		/// <return>Distance</return>
		public float GetManhattanDistance(FRotator rotator)
			=> E_FRotator_GetManhattanDistance(this, rotator);
		
		
		/// <summary>
		/// Create a copy of this rotator and normalize, removes all winding and creates the "shortest route" rotation.
		/// </summary>
		/// <return>Normalized</return>
		public FRotator GetNormalized()
			=> E_FRotator_GetNormalized(this);
		
		
		/// <summary>
		/// Decompose this Rotator into a Winding part (multiples of 360) and a Remainder part.
		/// <para>Remainder will always be in [-180, 180] range. </para>
		/// </summary>
		/// <param name="winding">Out] the Winding part of this Rotator</param>
		/// <param name="remainder">Out] the Remainder</param>
		public void GetWindingAndRemainder(FRotator winding, FRotator remainder)
			=> E_FRotator_GetWindingAndRemainder(this, winding, remainder);
		
		
		/// <summary>
		/// Get the rotation, snapped to specified degree segments.
		/// </summary>
		/// <param name="rotGrid">A Rotator specifying how to snap each component.</param>
		/// <return>Snapped</return>
		public FRotator GridSnap(FRotator rotGrid)
			=> E_FRotator_GridSnap(this, rotGrid);
		
		
		/// <summary>
		/// Initialize this Rotator based on an FString. The String is expected to contain P=, Y=, R=.
		/// <para>The FRotator will be bogus when InitFromString returns false. </para>
		/// </summary>
		/// <param name="inSourceString">FString containing the rotator values.</param>
		/// <return>true</return>
		public bool InitFromString(string inSourceString)
			=> E_FRotator_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// Checks whether rotator is nearly zero within specified tolerance, when treated as an orientation.
		/// <para>This means that FRotator(0, 0, 360) is "zero", because it is the same final orientation as the zero rotator. </para>
		/// </summary>
		/// <param name="tolerance">Error Tolerance.</param>
		/// <return>true</return>
		public bool IsNearlyZero(float tolerance)
			=> E_FRotator_IsNearlyZero(this, tolerance);
		
		
		/// <summary>
		/// Checks whether this has exactly zero rotation, when treated as an orientation.
		/// <para>This means that FRotator(0, 0, 360) is "zero", because it is the same final orientation as the zero rotator. </para>
		/// </summary>
		/// <return>true</return>
		public bool IsZero()
			=> E_FRotator_IsZero(this);
		
		
		/// <summary>
		/// Convert a vector of floating-point Euler angles (in degrees) into a Rotator. Rotator now stored in degrees
		/// </summary>
		/// <param name="euler">Euler angle vector.</param>
		/// <return>A</return>
		public FRotator MakeFromEuler(FVector euler)
			=> E_FRotator_MakeFromEuler(this, euler);
		
		
		/// <summary>
		/// In-place normalize, removes all winding and creates the "shortest route" rotation.
		/// </summary>
		public void Normalize()
			=> E_FRotator_Normalize(this);
		
		
		/// <summary>
		/// Clamps an angle to the range of (-180, 180].
		/// </summary>
		/// <param name="angle">The Angle to clamp.</param>
		/// <return>The</return>
		public float NormalizeAxis(float angle)
			=> E_FRotator_NormalizeAxis(this, angle);
		
		
		/// <summary>
		/// Get Rotation as a quaternion.
		/// </summary>
		/// <return>Rotation</return>
		public FQuat Quaternion()
			=> E_FRotator_Quaternion(this);
		
		
		/// <summary>
		/// Rotate a vector rotated by this rotator.
		/// </summary>
		/// <param name="v">The vector to rotate.</param>
		/// <return>The</return>
		public FVector RotateVector(FVector v)
			=> E_FRotator_RotateVector(this, v);
		
		
		/// <summary>
		/// Modify if necessary the passed in rotator to be the closest rotator to it based upon it's equivalent.
		/// <para>This Rotator should be within (-180, 180], usually just constructed from a Matrix or a Quaternion. </para>
		/// (-180, 180]. This Rotator may change if we need to use different degree values to make it closer.
		/// </summary>
		/// <param name="makeClosest">In/Out] the Rotator we want to make closest to us. Should be between</param>
		public void SetClosestToMe(FRotator makeClosest)
			=> E_FRotator_SetClosestToMe(this, makeClosest);
		
		
		/// <summary>
		/// Get a short textural representation of this vector, for compact readable logging.
		/// </summary>
		public string ToCompactString()
			=> E_FRotator_ToCompactString(this);
		
		
		/// <summary>
		/// Get a textual representation of the vector.
		/// </summary>
		/// <return>Text</return>
		public override string ToString()
			=> E_FRotator_ToString(this);
		
		
		/// <summary>
		/// Returns the vector rotated by the inverse of this rotator.
		/// </summary>
		/// <param name="v">The vector to rotate.</param>
		/// <return>The</return>
		public FVector UnrotateVector(FVector v)
			=> E_FRotator_UnrotateVector(this, v);
		
		
		/// <summary>
		/// Convert a rotation into a unit vector facing in its direction.
		/// </summary>
		/// <return>Rotation</return>
		public FVector Vector()
			=> E_FRotator_Vector(this);
		
		#endregion
		
		public static implicit operator IntPtr(FRotator self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRotator(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRotator(Adress, false);
		}}}
