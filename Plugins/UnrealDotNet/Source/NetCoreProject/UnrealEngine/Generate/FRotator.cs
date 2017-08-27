using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Implements a container for rotation information.
	/// All rotation values are stored in degrees.
	/// </summary>
	public partial struct FRotator
	{
		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_OP_FRotator_p(FRotator Self, FRotator R);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_OP_FRotator_m(FRotator Self, float Scale);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FRotator_IsNearlyZero(FRotator Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FRotator_IsZero(FRotator Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FRotator_Equals(FRotator Self, FRotator R, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_FRotator_Add(FRotator Self, float DeltaPitch, float DeltaYaw, float DeltaRoll);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FRotator_Vector(FRotator Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FQuat E_FRotator_Quaternion(FRotator Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FVector E_FRotator_RotateVector(FRotator Self, FVector V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FRotator_Normalize(FRotator Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FRotator_GetWindingAndRemainder(FRotator Self, FRotator Winding, FRotator Remainder);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FRotator_ClampAxis(FRotator Self, float Angle);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern byte E_FRotator_CompressAxisToByte(FRotator Self, float Angle);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern FRotator E_FRotator_MakeFromEuler(FRotator Self, FVector Euler);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Rotation around the right axis (around Y axis), Looking up and down (0=Straight Ahead, +Up, -Down)
		/// </summary>
		public float Pitch { get; set; } 
		
		/// <summary>
		/// Rotation around the up axis (around Z axis), Running in circles 0=East, +North, -South.
		/// </summary>
		public float Yaw { get; set; } 
		
		/// <summary>
		/// Rotation around the forward axis (around X axis), Tilting your head, 0=Straight, +Clockwise, -CCW.
		/// </summary>
		public float Roll { get; set; } 
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Get the result of adding a rotator to this.
		/// @param R The other rotator.
		/// @return The result of adding a rotator to this.
		/// </summary>
		public static FRotator operator+(FRotator Self, FRotator R)
			=> E_OP_FRotator_p(Self, R);
		
		
		/// <summary>
		/// Get the result of scaling this rotator.
		/// @param Scale The scaling factor.
		/// @return The result of scaling.
		/// </summary>
		public static FRotator operator*(FRotator Self, float Scale)
			=> E_OP_FRotator_m(Self, Scale);
		
		
		/// <summary>
		/// Checks whether rotator is nearly zero within specified tolerance, when treated as an orientation.
		/// This means that FRotator(0, 0, 360) is "zero", because it is the same final orientation as the zero rotator.
		/// @param Tolerance Error Tolerance.
		/// @return true if rotator is nearly zero, within specified tolerance, otherwise false.
		/// </summary>
		public bool IsNearlyZero(float Tolerance)
			=> E_FRotator_IsNearlyZero(this, Tolerance);
		
		
		/// <summary>
		/// Checks whether this has exactly zero rotation, when treated as an orientation.
		/// This means that FRotator(0, 0, 360) is "zero", because it is the same final orientation as the zero rotator.
		/// @return true if this has exactly zero rotation, otherwise false.
		/// </summary>
		public bool IsZero()
			=> E_FRotator_IsZero(this);
		
		
		/// <summary>
		/// Checks whether two rotators are equal within specified tolerance, when treated as an orientation.
		/// This means that FRotator(0, 0, 360).Equals(FRotator(0,0,0)) is true, because they represent the same final orientation.
		/// @param R The other rotator.
		/// @param Tolerance Error Tolerance.
		/// @return true if two rotators are equal, within specified tolerance, otherwise false.
		/// </summary>
		public bool Equals(FRotator R, float Tolerance)
			=> E_FRotator_Equals(this, R, Tolerance);
		
		
		/// <summary>
		/// Adds to each component of the rotator.
		/// @param DeltaPitch Change in pitch. (+/-)
		/// @param DeltaYaw Change in yaw. (+/-)
		/// @param DeltaRoll Change in roll. (+/-)
		/// @return Copy of rotator after addition.
		/// </summary>
		public FRotator Add(float DeltaPitch, float DeltaYaw, float DeltaRoll)
			=> E_FRotator_Add(this, DeltaPitch, DeltaYaw, DeltaRoll);
		
		
		/// <summary>
		/// Convert a rotation into a unit vector facing in its direction.
		/// @return Rotation as a unit direction vector.
		/// </summary>
		public FVector Vector()
			=> E_FRotator_Vector(this);
		
		
		/// <summary>
		/// Get Rotation as a quaternion.
		/// @return Rotation as a quaternion.
		/// </summary>
		public FQuat Quaternion()
			=> E_FRotator_Quaternion(this);
		
		
		/// <summary>
		/// Rotate a vector rotated by this rotator.
		/// @param V The vector to rotate.
		/// @return The rotated vector.
		/// </summary>
		public FVector RotateVector(FVector V)
			=> E_FRotator_RotateVector(this, V);
		
		
		/// <summary>
		/// In-place normalize, removes all winding and creates the "shortest route" rotation.
		/// </summary>
		public void Normalize()
			=> E_FRotator_Normalize(this);
		
		
		/// <summary>
		/// Decompose this Rotator into a Winding part (multiples of 360) and a Remainder part.
		/// Remainder will always be in [-180, 180] range.
		/// @param Winding[Out] the Winding part of this Rotator
		/// @param Remainder[Out] the Remainder
		/// </summary>
		public void GetWindingAndRemainder(FRotator Winding, FRotator Remainder)
			=> E_FRotator_GetWindingAndRemainder(this, Winding, Remainder);
		
		
		/// <summary>
		/// Clamps an angle to the range of [0, 360).
		/// @param Angle The angle to clamp.
		/// @return The clamped angle.
		/// </summary>
		public float ClampAxis(float Angle)
			=> E_FRotator_ClampAxis(this, Angle);
		
		
		/// <summary>
		/// Compresses a floating point angle into a byte.
		/// @param Angle The angle to compress.
		/// @return The angle as a byte.
		/// </summary>
		public byte CompressAxisToByte(float Angle)
			=> E_FRotator_CompressAxisToByte(this, Angle);
		
		
		/// <summary>
		/// Convert a vector of floating-point Euler angles (in degrees) into a Rotator. Rotator now stored in degrees
		/// @param Euler Euler angle vector.
		/// @return A rotator from a Euler angle.
		/// </summary>
		public FRotator MakeFromEuler(FVector Euler)
			=> E_FRotator_MakeFromEuler(this, Euler);
		
		#endregion
		
	}}
