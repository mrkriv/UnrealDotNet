// This file was created automatically, do not modify the contents of this file.

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
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FRotator() :
			base(E_CreateStruct_FRotator(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor </para>
		/// <param name="InF">Value to set all components to. </param>
		/// </summary>
		public FRotator(float inF) :
			base(E_CreateStruct_FRotator_float(inF), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InPitch">Pitch in degrees. </param>
		/// <param name="InYaw">Yaw in degrees. </param>
		/// <param name="InRoll">Roll in degrees. </param>
		/// </summary>
		public FRotator(float inPitch, float inYaw, float inRoll) :
			base(E_CreateStruct_FRotator_float_float_float(inPitch, inYaw, inRoll), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="Quat">Quaternion used to specify rotation. </param>
		/// </summary>
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
		/// <para>Rotation around the right axis (around Y axis), Looking up and down (0=Straight Ahead, +Up, -Down) </para>
		/// </summary>
		public float Pitch
		{
			get => E_PROP_FRotator_Pitch_GET(NativePointer);
			set => E_PROP_FRotator_Pitch_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Rotation around the forward axis (around X axis), Tilting your head, 0=Straight, +Clockwise, -CCW. </para>
		/// </summary>
		public float Roll
		{
			get => E_PROP_FRotator_Roll_GET(NativePointer);
			set => E_PROP_FRotator_Roll_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Rotation around the up axis (around Z axis), Running in circles 0=East, +North, -South. </para>
		/// </summary>
		public float Yaw
		{
			get => E_PROP_FRotator_Yaw_GET(NativePointer);
			set => E_PROP_FRotator_Yaw_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Adds to each component of the rotator. </para>
		/// <param name="DeltaPitch">Change in pitch. (+/-) </param>
		/// <param name="DeltaYaw">Change in yaw. (+/-) </param>
		/// <param name="DeltaRoll">Change in roll. (+/-) </param>
		/// <return>Copy of rotator after addition. </return>
		/// </summary>
		public FRotator Add(float deltaPitch, float deltaYaw, float deltaRoll)
			=> E_FRotator_Add(this, deltaPitch, deltaYaw, deltaRoll);
		
		
		/// <summary>
		/// <para>Gets the rotation values so they fall within the range [0,360] </para>
		/// <return>Clamped version of rotator. </return>
		/// </summary>
		public FRotator Clamp()
			=> E_FRotator_Clamp(this);
		
		
		/// <summary>
		/// <para>Clamps an angle to the range of [0, 360). </para>
		/// <param name="Angle">The angle to clamp. </param>
		/// <return>The clamped angle. </return>
		/// </summary>
		public float ClampAxis(float angle)
			=> E_FRotator_ClampAxis(this, angle);
		
		
		/// <summary>
		/// <para>Compresses a floating point angle into a byte. </para>
		/// <param name="Angle">The angle to compress. </param>
		/// <return>The angle as a byte. </return>
		/// </summary>
		public byte CompressAxisToByte(float angle)
			=> E_FRotator_CompressAxisToByte(this, angle);
		
		
		/// <summary>
		/// <para>Utility to check if there are any non-finite values (NaN or Inf) in this Rotator. </para>
		/// <return>true if there are any non-finite values in this Rotator, otherwise false. </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FRotator_ContainsNaN(this);
		
		
		/// <summary>
		/// <para>Decompress a word into a floating point angle. </para>
		/// <param name="Angle">The word angle. </param>
		/// <return>The decompressed angle. </return>
		/// </summary>
		public float DecompressAxisFromByte(byte angle)
			=> E_FRotator_DecompressAxisFromByte(this, angle);
		
		public void DiagnosticCheckNaN()
			=> E_FRotator_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// <para>Checks whether two rotators are equal within specified tolerance, when treated as an orientation. </para>
		/// <para>This means that FRotator(0, 0, 360).Equals(FRotator(0,0,0)) is true, because they represent the same final orientation. </para>
		/// <param name="R">The other rotator. </param>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if two rotators are equal, within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool Equals(FRotator r, float tolerance)
			=> E_FRotator_Equals(this, r, tolerance);
		
		
		/// <summary>
		/// <para>Convert a Rotator into floating-point Euler angles (in degrees). Rotator now stored in degrees. </para>
		/// <return>Rotation as a Euler angle vector. </return>
		/// </summary>
		public FVector Euler()
			=> E_FRotator_Euler(this);
		
		
		/// <summary>
		/// <para>Create a copy of this rotator and denormalize, clamping each axis to 0 - 360. </para>
		/// <return>Denormalized copy of this rotator </return>
		/// </summary>
		public FRotator GetDenormalized()
			=> E_FRotator_GetDenormalized(this);
		
		
		/// <summary>
		/// <para>Return a Rotator that has the same rotation but has different degree values for Yaw, Pitch, and Roll. </para>
		/// <para>This rotator should be within -180,180 range, </para>
		/// <return>A Rotator with the same rotation but different degrees. </return>
		/// </summary>
		public FRotator GetEquivalentRotator()
			=> E_FRotator_GetEquivalentRotator(this);
		
		
		/// <summary>
		/// <para>Returns the inverse of the rotator. </para>
		/// </summary>
		public FRotator GetInverse()
			=> E_FRotator_GetInverse(this);
		
		
		/// <summary>
		/// <para>Return the manhattan distance in degrees between this Rotator and the passed in one. </para>
		/// <param name="Rotator">In] the Rotator we are comparing with. </param>
		/// <return>Distance(Manhattan) between the two rotators. </return>
		/// </summary>
		public float GetManhattanDistance(FRotator rotator)
			=> E_FRotator_GetManhattanDistance(this, rotator);
		
		
		/// <summary>
		/// <para>Create a copy of this rotator and normalize, removes all winding and creates the "shortest route" rotation. </para>
		/// <return>Normalized copy of this rotator </return>
		/// </summary>
		public FRotator GetNormalized()
			=> E_FRotator_GetNormalized(this);
		
		
		/// <summary>
		/// <para>Decompose this Rotator into a Winding part (multiples of 360) and a Remainder part. </para>
		/// <para>Remainder will always be in [-180, 180] range. </para>
		/// <param name="Winding">Out] the Winding part of this Rotator </param>
		/// <param name="Remainder">Out] the Remainder </param>
		/// </summary>
		public void GetWindingAndRemainder(FRotator winding, FRotator remainder)
			=> E_FRotator_GetWindingAndRemainder(this, winding, remainder);
		
		
		/// <summary>
		/// <para>Get the rotation, snapped to specified degree segments. </para>
		/// <param name="RotGrid">A Rotator specifying how to snap each component. </param>
		/// <return>Snapped version of rotation. </return>
		/// </summary>
		public FRotator GridSnap(FRotator rotGrid)
			=> E_FRotator_GridSnap(this, rotGrid);
		
		
		/// <summary>
		/// <para>Initialize this Rotator based on an FString. The String is expected to contain P=, Y=, R=. </para>
		/// <para>The FRotator will be bogus when InitFromString returns false. </para>
		/// <param name="InSourceString">FString containing the rotator values. </param>
		/// <return>true if the P,Y,R values were read successfully; false otherwise. </return>
		/// </summary>
		public bool InitFromString(string inSourceString)
			=> E_FRotator_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// <para>Checks whether rotator is nearly zero within specified tolerance, when treated as an orientation. </para>
		/// <para>This means that FRotator(0, 0, 360) is "zero", because it is the same final orientation as the zero rotator. </para>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if rotator is nearly zero, within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool IsNearlyZero(float tolerance)
			=> E_FRotator_IsNearlyZero(this, tolerance);
		
		
		/// <summary>
		/// <para>Checks whether this has exactly zero rotation, when treated as an orientation. </para>
		/// <para>This means that FRotator(0, 0, 360) is "zero", because it is the same final orientation as the zero rotator. </para>
		/// <return>true if this has exactly zero rotation, otherwise false. </return>
		/// </summary>
		public bool IsZero()
			=> E_FRotator_IsZero(this);
		
		
		/// <summary>
		/// <para>Convert a vector of floating-point Euler angles (in degrees) into a Rotator. Rotator now stored in degrees </para>
		/// <param name="Euler">Euler angle vector. </param>
		/// <return>A rotator from a Euler angle. </return>
		/// </summary>
		public FRotator MakeFromEuler(FVector euler)
			=> E_FRotator_MakeFromEuler(this, euler);
		
		
		/// <summary>
		/// <para>In-place normalize, removes all winding and creates the "shortest route" rotation. </para>
		/// </summary>
		public void Normalize()
			=> E_FRotator_Normalize(this);
		
		
		/// <summary>
		/// <para>Clamps an angle to the range of (-180, 180]. </para>
		/// <param name="Angle">The Angle to clamp. </param>
		/// <return>The clamped angle. </return>
		/// </summary>
		public float NormalizeAxis(float angle)
			=> E_FRotator_NormalizeAxis(this, angle);
		
		
		/// <summary>
		/// <para>Get Rotation as a quaternion. </para>
		/// <return>Rotation as a quaternion. </return>
		/// </summary>
		public FQuat Quaternion()
			=> E_FRotator_Quaternion(this);
		
		
		/// <summary>
		/// <para>Rotate a vector rotated by this rotator. </para>
		/// <param name="V">The vector to rotate. </param>
		/// <return>The rotated vector. </return>
		/// </summary>
		public FVector RotateVector(FVector v)
			=> E_FRotator_RotateVector(this, v);
		
		
		/// <summary>
		/// <para>Modify if necessary the passed in rotator to be the closest rotator to it based upon it's equivalent. </para>
		/// <para>This Rotator should be within (-180, 180], usually just constructed from a Matrix or a Quaternion. </para>
		/// <param name="MakeClosest">In/Out] the Rotator we want to make closest to us. Should be between </param>
		/// <para>(-180, 180]. This Rotator may change if we need to use different degree values to make it closer. </para>
		/// </summary>
		public void SetClosestToMe(FRotator makeClosest)
			=> E_FRotator_SetClosestToMe(this, makeClosest);
		
		
		/// <summary>
		/// <para>Get a short textural representation of this vector, for compact readable logging. </para>
		/// </summary>
		public string ToCompactString()
			=> E_FRotator_ToCompactString(this);
		
		
		/// <summary>
		/// <para>Get a textual representation of the vector. </para>
		/// <return>Text describing the vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FRotator_ToString(this);
		
		
		/// <summary>
		/// <para>Returns the vector rotated by the inverse of this rotator. </para>
		/// <param name="V">The vector to rotate. </param>
		/// <return>The rotated vector. </return>
		/// </summary>
		public FVector UnrotateVector(FVector v)
			=> E_FRotator_UnrotateVector(this, v);
		
		
		/// <summary>
		/// <para>Convert a rotation into a unit vector facing in its direction. </para>
		/// <return>Rotation as a unit direction vector. </return>
		/// </summary>
		public FVector Vector()
			=> E_FRotator_Vector(this);
		
		#endregion
		
		public static implicit operator IntPtr(FRotator self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRotator(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRotator(Adress, false);
		}}}
