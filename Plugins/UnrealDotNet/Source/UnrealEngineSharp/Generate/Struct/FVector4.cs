// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Vector4.h:17

namespace UnrealEngine
{
	public  partial class FVector4 : NativeStructWrapper
	{
		internal FVector4(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="inVector">3D Vector to set first three components.</param>
		/// <param name="inW">W Coordinate.</param>
		public FVector4(FVector inVector, float inW) :
			base(E_CreateStruct_FVector4_FVector_float(inVector, inW), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new vector from a color value.
		/// </summary>
		/// <param name="inColour">Color used to set vector.</param>
		public FVector4(FLinearColor inColor) :
			base(E_CreateStruct_FVector4_FLinearColor(inColor), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new vector from the specified components.
		/// </summary>
		/// <param name="inX">X Coordinate.</param>
		/// <param name="inY">Y Coordinate.</param>
		/// <param name="inZ">Z Coordinate.</param>
		/// <param name="inW">W Coordinate.</param>
		public FVector4(float inX, float inY, float inZ, float inW) :
			base(E_CreateStruct_FVector4_float_float_float_float(inX, inY, inZ, inW), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new vector from the specified 2D vectors.
		/// </summary>
		/// <param name="inXY">A 2D vector holding the X- and Y-components.</param>
		/// <param name="inZW">A 2D vector holding the Z- and W-components.</param>
		public FVector4(FVector2D inXY, FVector2D inZW) :
			base(E_CreateStruct_FVector4_FVector2D_FVector2D(inXY, inZW), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector4_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector4_W_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector4_X_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector4_X_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector4_Y_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector4_Y_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FVector4_Z_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FVector4_Z_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector4_FVector_float(IntPtr inVector, float inW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector4_FLinearColor(IntPtr inColor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector4_float_float_float_float(float inX, float inY, float inZ, float inW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FVector4_FVector2D_FVector2D(IntPtr inXY, IntPtr inZW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector4_Component(IntPtr self, int index);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_ContainsNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector4_DiagnosticCheckNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_Equals(IntPtr self, IntPtr v, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector4_FindBestAxisVectors3(IntPtr self, IntPtr axis1, IntPtr axis2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_GetSafeNormal(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_GetUnsafeNormal3(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_InitFromString(IntPtr self, string inSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_IsNearlyZero3(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FVector4_IsUnit3(IntPtr self, float lengthSquaredTolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_Reflect3(IntPtr self, IntPtr normal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_Rotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FVector4_Set(IntPtr self, float inX, float inY, float inZ, float inW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector4_Size(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector4_Size3(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector4_SizeSquared(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FVector4_SizeSquared3(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_ToOrientationQuat(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FVector4_ToOrientationRotator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FVector4_ToString(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The vector's W-component.
		/// </summary>
		public float W
		{
			get => E_PROP_FVector4_W_GET(NativePointer);
			set => E_PROP_FVector4_W_SET(NativePointer, value);
		}

		
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

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Gets a specific component of the vector.
		/// </summary>
		/// <param name="index">The index of the component.</param>
		/// <return>Reference</return>
		public float Component(int index)
			=> E_FVector4_Component(this, index);
		
		
		/// <summary>
		/// Utility to check if there are any non-finite values (NaN or Inf) in this vector.
		/// </summary>
		public bool ContainsNaN()
			=> E_FVector4_ContainsNaN(this);
		
		public void DiagnosticCheckNaN()
			=> E_FVector4_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// Error tolerant comparison.
		/// </summary>
		/// <param name="v">Vector to compare against.</param>
		/// <param name="tolerance">Error Tolerance.</param>
		/// <return>true</return>
		public bool Equals(FVector4 v, float tolerance)
			=> E_FVector4_Equals(this, v, tolerance);
		
		
		/// <summary>
		/// Find good arbitrary axis vectors to represent U and V axes of a plane,
		/// <para>given just the normal. </para>
		/// </summary>
		public void FindBestAxisVectors3(FVector4 axis1, FVector4 axis2)
			=> E_FVector4_FindBestAxisVectors3(this, axis1, axis2);
		
		
		/// <summary>
		/// Returns a normalized copy of the vector if safe to normalize.
		/// </summary>
		/// <param name="tolerance">Minimum squared length of vector for normalization.</param>
		/// <return>A</return>
		public FVector4 GetSafeNormal(float tolerance)
			=> E_FVector4_GetSafeNormal(this, tolerance);
		
		
		/// <summary>
		/// Calculates normalized version of vector without checking if it is non-zero.
		/// </summary>
		/// <return>Normalized</return>
		public FVector4 GetUnsafeNormal3()
			=> E_FVector4_GetUnsafeNormal3(this);
		
		
		/// <summary>
		/// Initialize this Vector based on an FString. The String is expected to contain X=, Y=, Z=, W=.
		/// <para>The FVector4 will be bogus when InitFromString returns false. </para>
		/// </summary>
		/// <param name="inSourceString">FString containing the vector values.</param>
		/// <return>true</return>
		public bool InitFromString(string inSourceString)
			=> E_FVector4_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// Utility to check if all of the components of this vector are nearly zero given the tolerance.
		/// </summary>
		public bool IsNearlyZero3(float tolerance)
			=> E_FVector4_IsNearlyZero3(this, tolerance);
		
		
		/// <summary>
		/// Check if the vector is of unit length, with specified tolerance.
		/// </summary>
		/// <param name="lengthSquaredTolerance">Tolerance against squared length.</param>
		/// <return>true</return>
		public bool IsUnit3(float lengthSquaredTolerance)
			=> E_FVector4_IsUnit3(this, lengthSquaredTolerance);
		
		
		/// <summary>
		/// Reflect vector.
		/// </summary>
		public FVector4 Reflect3(FVector4 normal)
			=> E_FVector4_Reflect3(this, normal);
		
		
		/// <summary>
		/// Return the FRotator orientation corresponding to the direction in which the vector points.
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets roll to zero because the roll can't be determined from a vector. </para>
		/// Identical to 'ToOrientationRotator()'.
		/// <see cref="ToOrientationRotator"/>
		/// </summary>
		/// <return>FRotator</return>
		public FRotator Rotation()
			=> E_FVector4_Rotation(this);
		
		
		/// <summary>
		/// Set all of the vectors coordinates.
		/// </summary>
		/// <param name="inX">New X Coordinate.</param>
		/// <param name="inY">New Y Coordinate.</param>
		/// <param name="inZ">New Z Coordinate.</param>
		/// <param name="inW">New W Coordinate.</param>
		public void Set(float inX, float inY, float inZ, float inW)
			=> E_FVector4_Set(this, inX, inY, inZ, inW);
		
		
		/// <summary>
		/// Get the length (magnitude) of this vector, taking the W component into account
		/// </summary>
		/// <return>The</return>
		public float Size()
			=> E_FVector4_Size(this);
		
		
		/// <summary>
		/// Get the length of this vector not taking W component into account.
		/// </summary>
		/// <return>The</return>
		public float Size3()
			=> E_FVector4_Size3(this);
		
		
		/// <summary>
		/// Get the squared length of this vector, taking the W component into account
		/// </summary>
		/// <return>The</return>
		public float SizeSquared()
			=> E_FVector4_SizeSquared(this);
		
		
		/// <summary>
		/// Get the squared length of this vector not taking W component into account.
		/// </summary>
		/// <return>The</return>
		public float SizeSquared3()
			=> E_FVector4_SizeSquared3(this);
		
		
		/// <summary>
		/// Return the Quaternion orientation corresponding to the direction in which the vector points.
		/// </summary>
		/// <return>Quaternion</return>
		public FQuat ToOrientationQuat()
			=> E_FVector4_ToOrientationQuat(this);
		
		
		/// <summary>
		/// Return the FRotator orientation corresponding to the direction in which the vector points.
		/// <para>Sets Yaw and Pitch to the proper numbers, and sets roll to zero because the roll can't be determined from a vector. </para>
		/// </summary>
		/// <return>FRotator</return>
		public FRotator ToOrientationRotator()
			=> E_FVector4_ToOrientationRotator(this);
		
		
		/// <summary>
		/// Get a textual representation of the vector.
		/// </summary>
		/// <return>Text</return>
		public override string ToString()
			=> E_FVector4_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FVector4 self)
		{
			return self.NativePointer;
		}

		public static implicit operator FVector4(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FVector4(Adress, false);
		}}}
