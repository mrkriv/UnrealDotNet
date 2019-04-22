// This file was created automatically, do not modify the contents of this file.

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
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FPlane() :
			base(E_CreateStruct_FPlane(), false)
		{
		}

		
		/// <summary>
		/// <para>Copy Constructor. </para>
		/// <param name="P">Plane to copy from. </param>
		/// </summary>
		public FPlane(FPlane p) :
			base(E_CreateStruct_FPlane_FPlane(p), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="V">4D vector to set up plane. </param>
		/// </summary>
		public FPlane(FVector4 v) :
			base(E_CreateStruct_FPlane_FVector4(v), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InX">X-coefficient. </param>
		/// <param name="InY">Y-coefficient. </param>
		/// <param name="InZ">Z-coefficient. </param>
		/// <param name="InW">W-coefficient. </param>
		/// </summary>
		public FPlane(float inX, float inY, float inZ, float inW) :
			base(E_CreateStruct_FPlane_float_float_float_float(inX, inY, inZ, inW), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InNormal">Plane Normal Vector. </param>
		/// <param name="InW">Plane W-coefficient. </param>
		/// </summary>
		public FPlane(FVector inNormal, float inW) :
			base(E_CreateStruct_FPlane_FVector_float(inNormal, inW), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InBase">Base point in plane. </param>
		/// <param name="InNormal">Plane Normal Vector. </param>
		/// </summary>
		public FPlane(FVector inBase, FVector inNormal) :
			base(E_CreateStruct_FPlane_FVector_FVector(inBase, inNormal), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="A">First point in the plane. </param>
		/// <param name="B">Second point in the plane. </param>
		/// <param name="C">Third point in the plane. </param>
		/// </summary>
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
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The w-component. </para>
		/// </summary>
		public float W
		{
			get => E_PROP_FPlane_W_GET(NativePointer);
			set => E_PROP_FPlane_W_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Checks whether two planes are equal within specified tolerance. </para>
		/// <param name="V">The other plane. </param>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if the two planes are equal within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool Equals(FPlane v, float tolerance)
			=> E_FPlane_Equals(this, v, tolerance);
		
		
		/// <summary>
		/// <para>Get a flipped version of the plane. </para>
		/// <return>A flipped version of the plane. </return>
		/// </summary>
		public FPlane Flip()
			=> E_FPlane_Flip(this);
		
		
		/// <summary>
		/// <para>Normalize this plane in-place if it is larger than a given tolerance. Leaves it unchanged if not. </para>
		/// <param name="Tolerance">Minimum squared length of vector for normalization. </param>
		/// <return>true if the plane was normalized correctly, false otherwise. </return>
		/// </summary>
		public bool Normalize(float tolerance)
			=> E_FPlane_Normalize(this, tolerance);
		
		
		/// <summary>
		/// <para>Calculates distance between plane and a point. </para>
		/// <param name="P">The other point. </param>
		/// <return>The distance from the plane to the point. 0: Point is on the plane. >0: Point is in front of the plane. <0: Point is behind the plane. </return>
		/// </summary>
		public float PlaneDot(FVector p)
			=> E_FPlane_PlaneDot(this, p);
		
		#endregion
		
		public static implicit operator IntPtr(FPlane self)
		{
			return self.NativePointer;
		}

		public static implicit operator FPlane(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPlane(Adress, false);
		}}}
