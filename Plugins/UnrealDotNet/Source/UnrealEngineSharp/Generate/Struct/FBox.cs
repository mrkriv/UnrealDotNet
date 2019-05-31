// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Box.h:17

namespace UnrealEngine
{
	public  partial class FBox : NativeStructWrapper
	{
		internal FBox(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FBox() :
			base(E_CreateStruct_FBox(), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new box with zero extent and marks it as invalid.
		/// </summary>
		public FBox(int _p0) :
			base(E_CreateStruct_FBox_int32(_p0), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new box from the specified extents.
		/// </summary>
		/// <param name="inMin">The box's minimum point.</param>
		/// <param name="inMax">The box's maximum point.</param>
		public FBox(FVector inMin, FVector inMax) :
			base(E_CreateStruct_FBox_FVector_FVector(inMin, inMax), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new box from the given set of points.
		/// </summary>
		/// <param name="points">Array of Points to create for the bounding volume.</param>
		/// <param name="count">The number of points.</param>
		public FBox(FVector points, int count) :
			base(E_CreateStruct_FBox_FVector_int32(points, count), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBox_IsValid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBox_IsValid_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBox_Max_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBox_Max_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBox_Min_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBox_Min_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox_int32(int _p0);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox_FVector_FVector(IntPtr inMin, IntPtr inMax);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox_FVector_int32(IntPtr points, int count);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_BuildAABB(IntPtr self, IntPtr origin, IntPtr extent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FBox_ComputeSquaredDistanceToPoint(IntPtr self, IntPtr point);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_ExpandBy(IntPtr self, float w);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_ExpandBy_o1(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_ExpandBy_o2(IntPtr self, IntPtr neg, IntPtr pos);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_GetCenter(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBox_GetCenterAndExtents(IntPtr self, IntPtr center, IntPtr extents);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_GetClosestPointTo(IntPtr self, IntPtr point);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_GetExtent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_GetExtrema(IntPtr self, int pointIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_GetSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FBox_GetVolume(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBox_Init(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox_Intersect(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox_IntersectXY(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_InverseTransformBy(IntPtr self, IntPtr m);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox_IsInside(IntPtr self, IntPtr @in);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox_IsInside_o1(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox_IsInsideOrOn(IntPtr self, IntPtr @in);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox_IsInsideXY(IntPtr self, IntPtr @in);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox_IsInsideXY_o1(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_MoveTo(IntPtr self, IntPtr destination);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_Overlap(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_ShiftBy(IntPtr self, IntPtr offset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FBox_ToString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_TransformBy(IntPtr self, IntPtr m);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_TransformBy_o1(IntPtr self, IntPtr m);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox_TransformProjectBy(IntPtr self, IntPtr projM);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Holds a flag indicating whether this box is valid.
		/// </summary>
		public byte IsValid
		{
			get => E_PROP_FBox_IsValid_GET(NativePointer);
			set => E_PROP_FBox_IsValid_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the box's maximum point.
		/// </summary>
		public FVector Max
		{
			get => E_PROP_FBox_Max_GET(NativePointer);
			set => E_PROP_FBox_Max_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the box's minimum point.
		/// </summary>
		public FVector Min
		{
			get => E_PROP_FBox_Min_GET(NativePointer);
			set => E_PROP_FBox_Min_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Utility function to build an AABB from Origin and Extent
		/// </summary>
		/// <param name="origin">The location of the bounding box.</param>
		/// <param name="extent">Half size of the bounding box.</param>
		/// <return>A</return>
		public FBox BuildAABB(FVector origin, FVector extent)
			=> E_FBox_BuildAABB(this, origin, extent);
		
		
		/// <summary>
		/// Calculates the distance of a point to this box.
		/// </summary>
		/// <param name="point">The point.</param>
		/// <return>The</return>
		public float ComputeSquaredDistanceToPoint(FVector point)
			=> E_FBox_ComputeSquaredDistanceToPoint(this, point);
		
		
		/// <summary>
		/// Increases the box size.
		/// </summary>
		/// <param name="w">The size to increase the volume by.</param>
		/// <return>A</return>
		public FBox ExpandBy(float w)
			=> E_FBox_ExpandBy(this, w);
		
		
		/// <summary>
		/// Increases the box size.
		/// </summary>
		/// <param name="v">The size to increase the volume by.</param>
		/// <return>A</return>
		public FBox ExpandBy(FVector v)
			=> E_FBox_ExpandBy_o1(this, v);
		
		
		/// <summary>
		/// Increases the box size.
		/// </summary>
		/// <param name="neg">The size to increase the volume by in the negative direction (positive values move the bounds outwards)</param>
		/// <param name="pos">The size to increase the volume by in the positive direction (positive values move the bounds outwards)</param>
		/// <return>A</return>
		public FBox ExpandBy(FVector neg, FVector pos)
			=> E_FBox_ExpandBy_o2(this, neg, pos);
		
		
		/// <summary>
		/// Gets the center point of this box.
		/// <see cref="GetCenterAndExtents"/>
		/// </summary>
		/// <return>The</return>
		public FVector GetCenter()
			=> E_FBox_GetCenter(this);
		
		
		/// <summary>
		/// Gets the center and extents of this box.
		/// <see cref="GetCenter"/>
		/// </summary>
		/// <param name="center">out] Will contain the box center point.</param>
		/// <param name="extents">out] Will contain the extent around the center.</param>
		public void GetCenterAndExtents(FVector center, FVector extents)
			=> E_FBox_GetCenterAndExtents(this, center, extents);
		
		
		/// <summary>
		/// Calculates the closest point on or inside the box to a given point in space.
		/// </summary>
		/// <param name="point">The point in space.</param>
		/// <return>The</return>
		public FVector GetClosestPointTo(FVector point)
			=> E_FBox_GetClosestPointTo(this, point);
		
		
		/// <summary>
		/// Gets the extents of this box.
		/// <see cref="GetCenter"/>
		/// </summary>
		/// <return>The</return>
		public FVector GetExtent()
			=> E_FBox_GetExtent(this);
		
		
		/// <summary>
		/// Gets a reference to the specified point of the bounding box.
		/// </summary>
		/// <param name="pointIndex">The index of the extrema point to return.</param>
		/// <return>A</return>
		public FVector GetExtrema(int pointIndex)
			=> E_FBox_GetExtrema(this, pointIndex);
		
		
		/// <summary>
		/// Gets the size of this box.
		/// <see cref="GetCenter"/>
		/// </summary>
		/// <return>The</return>
		public FVector GetSize()
			=> E_FBox_GetSize(this);
		
		
		/// <summary>
		/// Gets the volume of this box.
		/// <see cref="GetCenter"/>
		/// </summary>
		/// <return>The</return>
		public float GetVolume()
			=> E_FBox_GetVolume(this);
		
		
		/// <summary>
		/// Set the initial values of the bounding box to Zero.
		/// </summary>
		public void Init()
			=> E_FBox_Init(this);
		
		
		/// <summary>
		/// Checks whether the given bounding box intersects this bounding box.
		/// </summary>
		/// <param name="other">The bounding box to intersect with.</param>
		/// <return>true</return>
		public bool Intersect(FBox other)
			=> E_FBox_Intersect(this, other);
		
		
		/// <summary>
		/// Checks whether the given bounding box intersects this bounding box in the XY plane.
		/// </summary>
		/// <param name="other">The bounding box to test intersection.</param>
		/// <return>true</return>
		public bool IntersectXY(FBox other)
			=> E_FBox_IntersectXY(this, other);
		
		
		/// <summary>
		/// Gets a bounding volume transformed by an inverted FTransform object.
		/// </summary>
		/// <param name="m">The transformation object to perform the inversely transform this box with.</param>
		/// <return>The</return>
		public FBox InverseTransformBy(FTransform m)
			=> E_FBox_InverseTransformBy(this, m);
		
		
		/// <summary>
		/// Checks whether the given location is inside this box.
		/// <para>@see IsInsideXY </para>
		/// </summary>
		/// <param name="@in">The location to test for inside the bounding volume.</param>
		/// <return>true</return>
		public bool IsInside(FVector @in)
			=> E_FBox_IsInside(this, @in);
		
		
		/// <summary>
		/// Checks whether a given box is fully encapsulated by this box.
		/// </summary>
		/// <param name="other">The box to test for encapsulation within the bounding volume.</param>
		/// <return>true</return>
		public bool IsInside(FBox other)
			=> E_FBox_IsInside_o1(this, other);
		
		
		/// <summary>
		/// Checks whether the given location is inside or on this box.
		/// <para>@see IsInsideXY </para>
		/// </summary>
		/// <param name="@in">The location to test for inside the bounding volume.</param>
		/// <return>true</return>
		public bool IsInsideOrOn(FVector @in)
			=> E_FBox_IsInsideOrOn(this, @in);
		
		
		/// <summary>
		/// Checks whether the given location is inside this box in the XY plane.
		/// <para>@see IsInside </para>
		/// </summary>
		/// <param name="@in">The location to test for inside the bounding box.</param>
		/// <return>true</return>
		public bool IsInsideXY(FVector @in)
			=> E_FBox_IsInsideXY(this, @in);
		
		
		/// <summary>
		/// Checks whether the given box is fully encapsulated by this box in the XY plane.
		/// </summary>
		/// <param name="other">The box to test for encapsulation within the bounding box.</param>
		/// <return>true</return>
		public bool IsInsideXY(FBox other)
			=> E_FBox_IsInsideXY_o1(this, other);
		
		
		/// <summary>
		/// Moves the center of bounding box to new destination.
		/// </summary>
		/// <param name="the">destination point to move center of box to.</param>
		/// <return>A</return>
		public FBox MoveTo(FVector destination)
			=> E_FBox_MoveTo(this, destination);
		
		
		/// <summary>
		/// Returns the overlap FBox of two box
		/// </summary>
		/// <param name="other">The bounding box to test overlap</param>
		/// <return>the</return>
		public FBox Overlap(FBox other)
			=> E_FBox_Overlap(this, other);
		
		
		/// <summary>
		/// Shifts the bounding box position.
		/// </summary>
		/// <param name="offset">The vector to shift the box by.</param>
		/// <return>A</return>
		public FBox ShiftBy(FVector offset)
			=> E_FBox_ShiftBy(this, offset);
		
		
		/// <summary>
		/// Get a textual representation of this box.
		/// </summary>
		/// <return>A</return>
		public override string ToString()
			=> E_FBox_ToString(this);
		
		
		/// <summary>
		/// Gets a bounding volume transformed by a matrix.
		/// <para>@see TransformProjectBy </para>
		/// </summary>
		/// <param name="m">The matrix to transform by.</param>
		/// <return>The</return>
		public FBox TransformBy(FMatrix m)
			=> E_FBox_TransformBy(this, m);
		
		
		/// <summary>
		/// Gets a bounding volume transformed by a FTransform object.
		/// <para>@see TransformProjectBy </para>
		/// </summary>
		/// <param name="m">The transformation object.</param>
		/// <return>The</return>
		public FBox TransformBy(FTransform m)
			=> E_FBox_TransformBy_o1(this, m);
		
		
		/// <summary>
		/// Transforms and projects a world bounding box to screen space
		/// <para>@see TransformBy </para>
		/// </summary>
		/// <param name="projM">The projection matrix.</param>
		/// <return>The</return>
		public FBox TransformProjectBy(FMatrix projM)
			=> E_FBox_TransformProjectBy(this, projM);
		
		#endregion
		
		public static implicit operator IntPtr(FBox self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBox(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBox(adress, false);
		}}}
