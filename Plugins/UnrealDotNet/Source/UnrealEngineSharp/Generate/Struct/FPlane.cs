// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Plane.h:17

namespace UnrealEngine
{
	public  partial class FPlane : FVector
	{
		internal FPlane(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FPlane() :
			base(E_CreateStruct_FPlane(), false)
		{
		}

		
		/// <summary>
		/// Copy Constructor.
		/// </summary>
		/// <param name="p">Plane to copy from.</param>
		public FPlane(FPlane p) :
			base(E_CreateStruct_FPlane_FPlane(p), false)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="v">4D vector to set up plane.</param>
		public FPlane(FVector4 v) :
			base(E_CreateStruct_FPlane_FVector4(v), false)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="inX">X-coefficient.</param>
		/// <param name="inY">Y-coefficient.</param>
		/// <param name="inZ">Z-coefficient.</param>
		/// <param name="inW">W-coefficient.</param>
		public FPlane(float inX, float inY, float inZ, float inW) :
			base(E_CreateStruct_FPlane_float_float_float_float(inX, inY, inZ, inW), false)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="inNormal">Plane Normal Vector.</param>
		/// <param name="inW">Plane W-coefficient.</param>
		public FPlane(FVector inNormal, float inW) :
			base(E_CreateStruct_FPlane_FVector_float(inNormal, inW), false)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="inBase">Base point in plane.</param>
		/// <param name="inNormal">Plane Normal Vector.</param>
		public FPlane(FVector inBase, FVector inNormal) :
			base(E_CreateStruct_FPlane_FVector_FVector(inBase, inNormal), false)
		{
		}

		
		/// <summary>
		/// Constructor.
		/// </summary>
		/// <param name="a">First point in the plane.</param>
		/// <param name="b">Second point in the plane.</param>
		/// <param name="c">Third point in the plane.</param>
		public FPlane(FVector a, FVector b, FVector c) :
			base(E_CreateStruct_FPlane_FVector_FVector_FVector(a, b, c), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPlane_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPlane_W_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FPlane(IntPtr p);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FVector4(IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_float_float_float_float(float inX, float inY, float inZ, float inW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FVector_float(IntPtr inNormal, float inW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FVector_FVector(IntPtr inBase, IntPtr inNormal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FVector_FVector_FVector(IntPtr a, IntPtr b, IntPtr c);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FPlane_Equals(IntPtr self, IntPtr v, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FPlane_Flip(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FPlane_Normalize(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FPlane_PlaneDot(IntPtr self, IntPtr p);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FPlane_TransformBy(IntPtr self, IntPtr m);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FPlane_TransformByUsingAdjointT(IntPtr self, IntPtr m, float detM, IntPtr tA);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The w-component.
		/// </summary>
		public float W
		{
			get => E_PROP_FPlane_W_GET(NativePointer);
			set => E_PROP_FPlane_W_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Checks whether two planes are equal within specified tolerance.
		/// </summary>
		/// <param name="v">The other plane.</param>
		/// <param name="tolerance">Error Tolerance.</param>
		/// <return>true</return>
		public bool Equals(FPlane v, float tolerance)
			=> E_FPlane_Equals(this, v, tolerance);
		
		
		/// <summary>
		/// Get a flipped version of the plane.
		/// </summary>
		/// <return>A</return>
		public FPlane Flip()
			=> E_FPlane_Flip(this);
		
		
		/// <summary>
		/// Normalize this plane in-place if it is larger than a given tolerance. Leaves it unchanged if not.
		/// </summary>
		/// <param name="tolerance">Minimum squared length of vector for normalization.</param>
		/// <return>true</return>
		public bool Normalize(float tolerance)
			=> E_FPlane_Normalize(this, tolerance);
		
		
		/// <summary>
		/// Calculates distance between plane and a point.
		/// </summary>
		/// <param name="p">The other point.</param>
		/// <return>The</return>
		public float PlaneDot(FVector p)
			=> E_FPlane_PlaneDot(this, p);
		
		
		/// <summary>
		/// Get the result of transforming the plane by a Matrix.
		/// </summary>
		/// <param name="m">The matrix to transform plane with.</param>
		/// <return>The</return>
		public FPlane TransformBy(FMatrix m)
			=> E_FPlane_TransformBy(this, m);
		
		
		/// <summary>
		/// You can optionally pass in the matrices transpose-adjoint, which save it recalculating it.
		/// <para>MSM: If we are going to save the transpose-adjoint we should also save the more expensive </para>
		/// determinant.
		/// </summary>
		/// <param name="m">The Matrix to transform plane with.</param>
		/// <param name="detM">Determinant of Matrix.</param>
		/// <param name="tA">Transpose-adjoint of Matrix.</param>
		/// <return>The</return>
		public FPlane TransformByUsingAdjointT(FMatrix m, float detM, FMatrix tA)
			=> E_FPlane_TransformByUsingAdjointT(this, m, detM, tA);
		
		#endregion
		
		public static implicit operator IntPtr(FPlane self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPlane(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPlane(Adress, false);
		}}}
