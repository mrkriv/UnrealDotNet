using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Core\Public\Math\Rotator.h:18

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
		public FRotator(float InF) :
			base(E_CreateStruct_FRotator_float(InF), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InPitch">Pitch in degrees. </param>
		/// <param name="InYaw">Yaw in degrees. </param>
		/// <param name="InRoll">Roll in degrees. </param>
		/// </summary>
		public FRotator(float InPitch, float InYaw, float InRoll) :
			base(E_CreateStruct_FRotator_float_float_float(InPitch, InYaw, InRoll), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="Quat">Quaternion used to specify rotation. </param>
		/// </summary>
		public FRotator(FQuat Quat) :
			base(E_CreateStruct_FRotator_FQuat(Quat), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotator();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotator_float(float InF);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotator_float_float_float(float InPitch, float InYaw, float InRoll);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRotator_FQuat(IntPtr Quat);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRotator_Pitch_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRotator_Pitch_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRotator_Roll_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRotator_Roll_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FRotator_Yaw_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRotator_Yaw_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Add(IntPtr Self, float DeltaPitch, float DeltaYaw, float DeltaRoll);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Clamp(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRotator_ClampAxis(IntPtr Self, float Angle);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FRotator_CompressAxisToByte(IntPtr Self, float Angle);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_ContainsNaN(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_Equals(IntPtr Self, IntPtr R, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Euler(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_GetDenormalized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_GetInverse(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_GetNormalized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRotator_GetWindingAndRemainder(IntPtr Self, IntPtr Winding, IntPtr Remainder);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_GridSnap(IntPtr Self, IntPtr RotGrid);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_InitFromString(IntPtr Self, string InSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_IsNearlyZero(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRotator_IsZero(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_MakeFromEuler(IntPtr Self, IntPtr Euler);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRotator_Normalize(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRotator_NormalizeAxis(IntPtr Self, float Angle);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Quaternion(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_RotateVector(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FRotator_ToCompactString(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FRotator_ToString(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_UnrotateVector(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRotator_Vector(IntPtr Self);
		
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
		public FRotator Add(float DeltaPitch, float DeltaYaw, float DeltaRoll)
			=> E_FRotator_Add(this, DeltaPitch, DeltaYaw, DeltaRoll);
		
		
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
		public float ClampAxis(float Angle)
			=> E_FRotator_ClampAxis(this, Angle);
		
		
		/// <summary>
		/// <para>Compresses a floating point angle into a byte. </para>
		/// <param name="Angle">The angle to compress. </param>
		/// <return>The angle as a byte. </return>
		/// </summary>
		public byte CompressAxisToByte(float Angle)
			=> E_FRotator_CompressAxisToByte(this, Angle);
		
		
		/// <summary>
		/// <para>Utility to check if there are any non-finite values (NaN or Inf) in this Rotator. </para>
		/// <return>true if there are any non-finite values in this Rotator, otherwise false. </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FRotator_ContainsNaN(this);
		
		
		/// <summary>
		/// <para>Checks whether two rotators are equal within specified tolerance, when treated as an orientation. </para>
		/// <para>This means that FRotator(0, 0, 360).Equals(FRotator(0,0,0)) is true, because they represent the same final orientation. </para>
		/// <param name="R">The other rotator. </param>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if two rotators are equal, within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool Equals(FRotator R, float Tolerance)
			=> E_FRotator_Equals(this, R, Tolerance);
		
		
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
		/// <para>Returns the inverse of the rotator. </para>
		/// </summary>
		public FRotator GetInverse()
			=> E_FRotator_GetInverse(this);
		
		
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
		public void GetWindingAndRemainder(FRotator Winding, FRotator Remainder)
			=> E_FRotator_GetWindingAndRemainder(this, Winding, Remainder);
		
		
		/// <summary>
		/// <para>Get the rotation, snapped to specified degree segments. </para>
		/// <param name="RotGrid">A Rotator specifying how to snap each component. </param>
		/// <return>Snapped version of rotation. </return>
		/// </summary>
		public FRotator GridSnap(FRotator RotGrid)
			=> E_FRotator_GridSnap(this, RotGrid);
		
		
		/// <summary>
		/// <para>Initialize this Rotator based on an FString. The String is expected to contain P=, Y=, R=. </para>
		/// <para>The FRotator will be bogus when InitFromString returns false. </para>
		/// <param name="InSourceString">FString containing the rotator values. </param>
		/// <return>true if the P,Y,R values were read successfully; false otherwise. </return>
		/// </summary>
		public bool InitFromString(string InSourceString)
			=> E_FRotator_InitFromString(this, InSourceString);
		
		
		/// <summary>
		/// <para>Checks whether rotator is nearly zero within specified tolerance, when treated as an orientation. </para>
		/// <para>This means that FRotator(0, 0, 360) is "zero", because it is the same final orientation as the zero rotator. </para>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if rotator is nearly zero, within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool IsNearlyZero(float Tolerance)
			=> E_FRotator_IsNearlyZero(this, Tolerance);
		
		
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
		public FRotator MakeFromEuler(FVector Euler)
			=> E_FRotator_MakeFromEuler(this, Euler);
		
		
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
		public float NormalizeAxis(float Angle)
			=> E_FRotator_NormalizeAxis(this, Angle);
		
		
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
		public FVector RotateVector(FVector V)
			=> E_FRotator_RotateVector(this, V);
		
		
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
		public FVector UnrotateVector(FVector V)
			=> E_FRotator_UnrotateVector(this, V);
		
		
		/// <summary>
		/// <para>Convert a rotation into a unit vector facing in its direction. </para>
		/// <return>Rotation as a unit direction vector. </return>
		/// </summary>
		public FVector Vector()
			=> E_FRotator_Vector(this);
		
		#endregion
		
		public static implicit operator IntPtr(FRotator Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FRotator(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRotator(Adress, false);
		}}}
