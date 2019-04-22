// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\BoxSphereBounds.h:16

namespace UnrealEngine
{
	public  partial class FBoxSphereBounds : NativeStructWrapper
	{
		internal FBoxSphereBounds(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor. </para>
		/// </summary>
		public FBoxSphereBounds() :
			base(E_CreateStruct_FBoxSphereBounds(), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance from the specified parameters. </para>
		/// <param name="InOrigin">origin of the bounding box and sphere. </param>
		/// <param name="InBoxExtent">half size of box. </param>
		/// <param name="InSphereRadius">radius of the sphere. </param>
		/// </summary>
		public FBoxSphereBounds(FVector inOrigin, FVector inBoxExtent, float inSphereRadius) :
			base(E_CreateStruct_FBoxSphereBounds_FVector_FVector_float(inOrigin, inBoxExtent, inSphereRadius), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance from the given Box and Sphere. </para>
		/// <param name="Box">The bounding box. </param>
		/// <param name="Sphere">The bounding sphere. </param>
		/// </summary>
		public FBoxSphereBounds(FBox box, FSphere sphere) :
			base(E_CreateStruct_FBoxSphereBounds_FBox_FSphere(box, sphere), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance the given Box. </para>
		/// <para>The sphere radius is taken from the extent of the box. </para>
		/// <param name="Box">The bounding box. </param>
		/// </summary>
		public FBoxSphereBounds(FBox box) :
			base(E_CreateStruct_FBoxSphereBounds_FBox(box), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance for the given sphere. </para>
		/// </summary>
		public FBoxSphereBounds(FSphere sphere) :
			base(E_CreateStruct_FBoxSphereBounds_FSphere(sphere), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBoxSphereBounds_BoxExtent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBoxSphereBounds_BoxExtent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBoxSphereBounds_Origin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBoxSphereBounds_Origin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBoxSphereBounds_SphereRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBoxSphereBounds_SphereRadius_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBoxSphereBounds();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBoxSphereBounds_FVector_FVector_float(IntPtr inOrigin, IntPtr inBoxExtent, float inSphereRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBoxSphereBounds_FBox_FSphere(IntPtr box, IntPtr sphere);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBoxSphereBounds_FBox(IntPtr box);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBoxSphereBounds_FSphere(IntPtr sphere);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBoxSphereBounds_BoxesIntersect(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FBoxSphereBounds_ComputeSquaredDistanceFromBoxToPoint(IntPtr self, IntPtr point);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBoxSphereBounds_ContainsNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBoxSphereBounds_DiagnosticCheckNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBoxSphereBounds_ExpandBy(IntPtr self, float expandAmount);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBoxSphereBounds_GetBox(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBoxSphereBounds_GetSphere(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBoxSphereBounds_SpheresIntersect(IntPtr self, IntPtr a, IntPtr b, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FBoxSphereBounds_ToString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBoxSphereBounds_TransformBy(IntPtr self, IntPtr m);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBoxSphereBounds_TransformBy_o1(IntPtr self, IntPtr m);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Holds the extent of the bounding box. </para>
		/// </summary>
		public FVector BoxExtent
		{
			get => E_PROP_FBoxSphereBounds_BoxExtent_GET(NativePointer);
			set => E_PROP_FBoxSphereBounds_BoxExtent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the origin of the bounding box and sphere. </para>
		/// </summary>
		public FVector Origin
		{
			get => E_PROP_FBoxSphereBounds_Origin_GET(NativePointer);
			set => E_PROP_FBoxSphereBounds_Origin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the radius of the bounding sphere. </para>
		/// </summary>
		public float SphereRadius
		{
			get => E_PROP_FBoxSphereBounds_SphereRadius_GET(NativePointer);
			set => E_PROP_FBoxSphereBounds_SphereRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Test whether the boxes from two BoxSphereBounds intersect/overlap. </para>
		/// <param name="A">First BoxSphereBounds to test. </param>
		/// <param name="B">Second BoxSphereBounds to test. </param>
		/// <return>true if boxes intersect, false otherwise. </return>
		/// </summary>
		public bool BoxesIntersect(FBoxSphereBounds a, FBoxSphereBounds b)
			=> E_FBoxSphereBounds_BoxesIntersect(this, a, b);
		
		
		/// <summary>
		/// <para>Calculates the squared distance from a point to a bounding box </para>
		/// <param name="Point">The point. </param>
		/// <return>The distance. </return>
		/// </summary>
		public float ComputeSquaredDistanceFromBoxToPoint(FVector point)
			=> E_FBoxSphereBounds_ComputeSquaredDistanceFromBoxToPoint(this, point);
		
		public bool ContainsNaN()
			=> E_FBoxSphereBounds_ContainsNaN(this);
		
		public void DiagnosticCheckNaN()
			=> E_FBoxSphereBounds_DiagnosticCheckNaN(this);
		
		
		/// <summary>
		/// <para>Increase the size of the box and sphere by a given size. </para>
		/// <param name="ExpandAmount">The size to increase by. </param>
		/// <return>A new box with the expanded size. </return>
		/// </summary>
		public FBoxSphereBounds ExpandBy(float expandAmount)
			=> E_FBoxSphereBounds_ExpandBy(this, expandAmount);
		
		
		/// <summary>
		/// <para>Gets the bounding box. </para>
		/// <return>The bounding box. </return>
		/// </summary>
		public FBox GetBox()
			=> E_FBoxSphereBounds_GetBox(this);
		
		
		/// <summary>
		/// <para>Gets the bounding sphere. </para>
		/// <return>The bounding sphere. </return>
		/// </summary>
		public FSphere GetSphere()
			=> E_FBoxSphereBounds_GetSphere(this);
		
		
		/// <summary>
		/// <para>Test whether the spheres from two BoxSphereBounds intersect/overlap. </para>
		/// <param name="A">First BoxSphereBounds to test. </param>
		/// <param name="B">Second BoxSphereBounds to test. </param>
		/// <param name="Tolerance">Error tolerance added to test distance. </param>
		/// <return>true if spheres intersect, false otherwise. </return>
		/// </summary>
		public bool SpheresIntersect(FBoxSphereBounds a, FBoxSphereBounds b, float tolerance)
			=> E_FBoxSphereBounds_SpheresIntersect(this, a, b, tolerance);
		
		
		/// <summary>
		/// <para>Get a textual representation of this bounding box. </para>
		/// <return>Text describing the bounding box. </return>
		/// </summary>
		public override string ToString()
			=> E_FBoxSphereBounds_ToString(this);
		
		
		/// <summary>
		/// <para>Gets a bounding volume transformed by a matrix. </para>
		/// <param name="M">The matrix. </param>
		/// <return>The transformed volume. </return>
		/// </summary>
		public FBoxSphereBounds TransformBy(FMatrix m)
			=> E_FBoxSphereBounds_TransformBy(this, m);
		
		
		/// <summary>
		/// <para>Gets a bounding volume transformed by a FTransform object. </para>
		/// <param name="M">The FTransform object. </param>
		/// <return>The transformed volume. </return>
		/// </summary>
		public FBoxSphereBounds TransformBy(FTransform m)
			=> E_FBoxSphereBounds_TransformBy_o1(this, m);
		
		#endregion
		
		public static implicit operator IntPtr(FBoxSphereBounds self)
		{
			return self.NativePointer;
		}

		public static implicit operator FBoxSphereBounds(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBoxSphereBounds(Adress, false);
		}}}
