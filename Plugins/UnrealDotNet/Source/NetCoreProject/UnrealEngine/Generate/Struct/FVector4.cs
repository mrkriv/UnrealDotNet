using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A 4D homogeneous vector, 4x1 FLOATs, 16-byte aligned.
	/// </summary>
	public partial class FVector4
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FVector4()
		{
			NativePointer = E_CreateStruct_FVector4();
			IsRef = false;
		}

		internal FVector4(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FVector4();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FVector4_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FVector4_X_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FVector4_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FVector4_Y_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FVector4_Z_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FVector4_Z_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FVector4_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FVector4_W_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FVector4_Equals(FVector4 Self, IntPtr V, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FVector4_IsUnit3(FVector4 Self, float LengthSquaredTolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FVector4_ToString(FVector4 Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FVector4_InitFromString(FVector4 Self, string InSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FVector4_ToOrientationRotator(FVector4 Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FVector4_ToOrientationQuat(FVector4 Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FVector4_Set(FVector4 Self, float InX, float InY, float InZ, float InW);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FVector4_Size3(FVector4 Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FVector4_ContainsNaN(FVector4 Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FVector4_FindBestAxisVectors3(FVector4 Self, IntPtr Axis1, IntPtr Axis2);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FVector4_DiagnosticCheckNaN(FVector4 Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The vector's X-component.
		/// </summary>
		public float X
		{
			get => E_PROP_FVector4_X_GET(NativePointer);
			set => E_PROP_FVector4_X_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The vector's Y-component.
		/// </summary>
		public float Y
		{
			get => E_PROP_FVector4_Y_GET(NativePointer);
			set => E_PROP_FVector4_Y_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The vector's Z-component.
		/// </summary>
		public float Z
		{
			get => E_PROP_FVector4_Z_GET(NativePointer);
			set => E_PROP_FVector4_Z_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The vector's W-component.
		/// </summary>
		public float W
		{
			get => E_PROP_FVector4_W_GET(NativePointer);
			set => E_PROP_FVector4_W_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Error tolerant comparison.
		/// @param V Vector to compare against.
		/// @param Tolerance Error Tolerance.
		/// @return true if the two vectors are equal within specified tolerance, otherwise false.
		/// </summary>
		public bool Equals(FVector4 V, float Tolerance)
			=> E_FVector4_Equals(this, V, Tolerance);
		
		
		/// <summary>
		/// Check if the vector is of unit length, with specified tolerance.
		/// @param LengthSquaredTolerance Tolerance against squared length.
		/// @return true if the vector is a unit vector within the specified tolerance.
		/// </summary>
		public bool IsUnit3(float LengthSquaredTolerance)
			=> E_FVector4_IsUnit3(this, LengthSquaredTolerance);
		
		
		/// <summary>
		/// Get a textual representation of the vector.
		/// @return Text describing the vector.
		/// </summary>
		public override string ToString()
			=> Marshal.PtrToStringUTF8(E_FVector4_ToString(this, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// Initialize this Vector based on an FString. The String is expected to contain X=, Y=, Z=, W=.
		/// The FVector4 will be bogus when InitFromString returns false.
		/// @param InSourceString	FString containing the vector values.
		/// @return true if the X,Y,Z values were read successfully; false otherwise.
		/// </summary>
		public bool InitFromString(string InSourceString)
			=> E_FVector4_InitFromString(this, InSourceString);
		
		
		/// <summary>
		/// Return the FRotator orientation corresponding to the direction in which the vector points.
		/// Sets Yaw and Pitch to the proper numbers, and sets roll to zero because the roll can't be determined from a vector.
		/// @return FRotator from the Vector's direction.
		/// </summary>
		public FRotator ToOrientationRotator()
			=> E_FVector4_ToOrientationRotator(this);
		
		
		/// <summary>
		/// Return the Quaternion orientation corresponding to the direction in which the vector points.
		/// @return Quaternion from the Vector's direction.
		/// </summary>
		public FQuat ToOrientationQuat()
			=> E_FVector4_ToOrientationQuat(this);
		
		
		/// <summary>
		/// Set all of the vectors coordinates.
		/// @param InX New X Coordinate.
		/// @param InY New Y Coordinate.
		/// @param InZ New Z Coordinate.
		/// @param InW New W Coordinate.
		/// </summary>
		public void Set(float InX, float InY, float InZ, float InW)
			=> E_FVector4_Set(this, InX, InY, InZ, InW);
		
		
		/// <summary>
		/// Get the length of this vector not taking W component into account.
		/// @return The length of this vector.
		/// </summary>
		public float Size3()
			=> E_FVector4_Size3(this);
		
		
		/// <summary>
		/// Utility to check if there are any non-finite values (NaN or Inf) in this vector.
		/// </summary>
		public bool ContainsNaN()
			=> E_FVector4_ContainsNaN(this);
		
		
		/// <summary>
		/// Find good arbitrary axis vectors to represent U and V axes of a plane,
		/// given just the normal.
		/// </summary>
		public void FindBestAxisVectors3(FVector4 Axis1, FVector4 Axis2)
			=> E_FVector4_FindBestAxisVectors3(this, Axis1, Axis2);
		
		public void DiagnosticCheckNaN()
			=> E_FVector4_DiagnosticCheckNaN(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVector4 Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FVector4(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector4(Adress, false);
		}}}
