// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Sphere.h:12

namespace UnrealEngine
{
	public  partial class FSphere : NativeStructWrapper
	{
		internal FSphere(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FSphere() :
			base(E_CreateStruct_FSphere(), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new sphere. </para>
		/// <param name="int32">Passing int32 sets up zeroed sphere. </param>
		/// </summary>
		public FSphere(int _p0) :
			base(E_CreateStruct_FSphere_int32(_p0), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new sphere with the specified parameters. </para>
		/// <param name="InV">Center of sphere. </param>
		/// <param name="InW">Radius of sphere. </param>
		/// </summary>
		public FSphere(FVector inV, float inW) :
			base(E_CreateStruct_FSphere_FVector_float(inV, inW), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="Pts">Pointer to list of points this sphere must contain. </param>
		/// <param name="Count">How many points are in the list. </param>
		/// </summary>
		public FSphere(FVector pts, int count) :
			base(E_CreateStruct_FSphere_FVector_int32(pts, count), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FSphere_Center_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSphere_Center_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FSphere_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSphere_W_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSphere();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSphere_int32(int _p0);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSphere_FVector_float(IntPtr inV, float inW);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSphere_FVector_int32(IntPtr pts, int count);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FSphere_Equals(IntPtr self, IntPtr sphere, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FSphere_GetVolume(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FSphere_Intersects(IntPtr self, IntPtr other, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FSphere_IsInside(IntPtr self, IntPtr other, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FSphere_IsInside_o1(IntPtr self, IntPtr @in, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FSphere_TransformBy(IntPtr self, IntPtr m);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FSphere_TransformBy_o1(IntPtr self, IntPtr m);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The sphere's center point. </para>
		/// </summary>
		public FVector Center
		{
			get => E_PROP_FSphere_Center_GET(NativePointer);
			set => E_PROP_FSphere_Center_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The sphere's radius. </para>
		/// </summary>
		public float W
		{
			get => E_PROP_FSphere_W_GET(NativePointer);
			set => E_PROP_FSphere_W_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Check whether two spheres are the same within specified tolerance. </para>
		/// <param name="Sphere">The other sphere. </param>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if spheres are equal within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool Equals(FSphere sphere, float tolerance)
			=> E_FSphere_Equals(this, sphere, tolerance);
		
		
		/// <summary>
		/// <para>Get volume of the current sphere </para>
		/// <return>Volume (in Unreal units). </return>
		/// </summary>
		public float GetVolume()
			=> E_FSphere_GetVolume(this);
		
		
		/// <summary>
		/// <para>Test whether this sphere intersects another. </para>
		/// <param name="Other">The other sphere. </param>
		/// <param name="Tolerance">Error tolerance. </param>
		/// <return>true if spheres intersect, false otherwise. </return>
		/// </summary>
		public bool Intersects(FSphere other, float tolerance)
			=> E_FSphere_Intersects(this, other, tolerance);
		
		
		/// <summary>
		/// <para>Check whether sphere is inside of another. </para>
		/// <param name="Other">The other sphere. </param>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if sphere is inside another, otherwise false. </return>
		/// </summary>
		public bool IsInside(FSphere other, float tolerance)
			=> E_FSphere_IsInside(this, other, tolerance);
		
		
		/// <summary>
		/// <para>Checks whether the given location is inside this sphere. </para>
		/// <param name="In">The location to test for inside the bounding volume. </param>
		/// <return>true if location is inside this volume. </return>
		/// </summary>
		public bool IsInside(FVector @in, float tolerance)
			=> E_FSphere_IsInside_o1(this, @in, tolerance);
		
		
		/// <summary>
		/// <para>Get result of Transforming sphere by Matrix. </para>
		/// <param name="M">Matrix to transform by. </param>
		/// <return>Result of transformation. </return>
		/// </summary>
		public FSphere TransformBy(FMatrix m)
			=> E_FSphere_TransformBy(this, m);
		
		
		/// <summary>
		/// <para>Get result of Transforming sphere with Transform. </para>
		/// <param name="M">Transform information. </param>
		/// <return>Result of transformation. </return>
		/// </summary>
		public FSphere TransformBy(FTransform m)
			=> E_FSphere_TransformBy_o1(this, m);
		
		#endregion
		
		public static implicit operator IntPtr(FSphere self)
		{
			return self.NativePointer;
		}

		public static implicit operator FSphere(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSphere(Adress, false);
		}}}
