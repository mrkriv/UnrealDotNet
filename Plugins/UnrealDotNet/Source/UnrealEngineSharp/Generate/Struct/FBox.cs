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
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FBox() :
			base(E_CreateStruct_FBox(), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new box with zero extent and marks it as invalid. </para>
		/// </summary>
		public FBox(int _p0) :
			base(E_CreateStruct_FBox_int32(_p0), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new box from the specified extents. </para>
		/// <param name="InMin">The box's minimum point. </param>
		/// <param name="InMax">The box's maximum point. </param>
		/// </summary>
		public FBox(FVector inMin, FVector inMax) :
			base(E_CreateStruct_FBox_FVector_FVector(inMin, inMax), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new box from the given set of points. </para>
		/// <param name="Points">Array of Points to create for the bounding volume. </param>
		/// <param name="Count">The number of points. </param>
		/// </summary>
		public FBox(FVector points, int count) :
			base(E_CreateStruct_FBox_FVector_int32(points, count), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new box from an array of points. </para>
		/// <param name="Points">Array of Points to create for the bounding volume. </param>
		/// </summary>
		public FBox(TArray<FVector> points) :
			base(E_CreateStruct_FBox_TArray__FVector(points), false)
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
		private static extern IntPtr E_CreateStruct_FBox_TArray__FVector(IntPtr points);
		
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
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Holds a flag indicating whether this box is valid. </para>
		/// </summary>
		public byte IsValid
		{
			get => E_PROP_FBox_IsValid_GET(NativePointer);
			set => E_PROP_FBox_IsValid_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the box's maximum point. </para>
		/// </summary>
		public FVector Max
		{
			get => E_PROP_FBox_Max_GET(NativePointer);
			set => E_PROP_FBox_Max_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the box's minimum point. </para>
		/// </summary>
		public FVector Min
		{
			get => E_PROP_FBox_Min_GET(NativePointer);
			set => E_PROP_FBox_Min_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Utility function to build an AABB from Origin and Extent </para>
		/// <param name="Origin">The location of the bounding box. </param>
		/// <param name="Extent">Half size of the bounding box. </param>
		/// <return>A new axis-aligned bounding box. </return>
		/// </summary>
		public FBox BuildAABB(FVector origin, FVector extent)
			=> E_FBox_BuildAABB(this, origin, extent);
		
		
		/// <summary>
		/// <para>Calculates the distance of a point to this box. </para>
		/// <param name="Point">The point. </param>
		/// <return>The distance. </return>
		/// </summary>
		public float ComputeSquaredDistanceToPoint(FVector point)
			=> E_FBox_ComputeSquaredDistanceToPoint(this, point);
		
		
		/// <summary>
		/// <para>Increases the box size. </para>
		/// <param name="W">The size to increase the volume by. </param>
		/// <return>A new bounding box. </return>
		/// </summary>
		public FBox ExpandBy(float w)
			=> E_FBox_ExpandBy(this, w);
		
		
		/// <summary>
		/// <para>Increases the box size. </para>
		/// <param name="V">The size to increase the volume by. </param>
		/// <return>A new bounding box. </return>
		/// </summary>
		public FBox ExpandBy(FVector v)
			=> E_FBox_ExpandBy_o1(this, v);
		
		
		/// <summary>
		/// <para>Increases the box size. </para>
		/// <param name="Neg">The size to increase the volume by in the negative direction (positive values move the bounds outwards) </param>
		/// <param name="Pos">The size to increase the volume by in the positive direction (positive values move the bounds outwards) </param>
		/// <return>A new bounding box. </return>
		/// </summary>
		public FBox ExpandBy(FVector neg, FVector pos)
			=> E_FBox_ExpandBy_o2(this, neg, pos);
		
		
		/// <summary>
		/// <para>Gets the center point of this box. </para>
		/// <return>The center point. </return>
		/// <para>@see GetCenterAndExtents, GetExtent, GetSize, GetVolume </para>
		/// </summary>
		public FVector GetCenter()
			=> E_FBox_GetCenter(this);
		
		
		/// <summary>
		/// <para>Gets the center and extents of this box. </para>
		/// <param name="center">out] Will contain the box center point. </param>
		/// <param name="Extents">out] Will contain the extent around the center. </param>
		/// <para>@see GetCenter, GetExtent, GetSize, GetVolume </para>
		/// </summary>
		public void GetCenterAndExtents(FVector center, FVector extents)
			=> E_FBox_GetCenterAndExtents(this, center, extents);
		
		
		/// <summary>
		/// <para>Calculates the closest point on or inside the box to a given point in space. </para>
		/// <param name="Point">The point in space. </param>
		/// <return>The closest point on or inside the box. </return>
		/// </summary>
		public FVector GetClosestPointTo(FVector point)
			=> E_FBox_GetClosestPointTo(this, point);
		
		
		/// <summary>
		/// <para>Gets the extents of this box. </para>
		/// <return>The box extents. </return>
		/// <para>@see GetCenter, GetCenterAndExtents, GetSize, GetVolume </para>
		/// </summary>
		public FVector GetExtent()
			=> E_FBox_GetExtent(this);
		
		
		/// <summary>
		/// <para>Gets a reference to the specified point of the bounding box. </para>
		/// <param name="PointIndex">The index of the extrema point to return. </param>
		/// <return>A reference to the point. </return>
		/// </summary>
		public FVector GetExtrema(int pointIndex)
			=> E_FBox_GetExtrema(this, pointIndex);
		
		
		/// <summary>
		/// <para>Gets the size of this box. </para>
		/// <return>The box size. </return>
		/// <para>@see GetCenter, GetCenterAndExtents, GetExtent, GetVolume </para>
		/// </summary>
		public FVector GetSize()
			=> E_FBox_GetSize(this);
		
		
		/// <summary>
		/// <para>Gets the volume of this box. </para>
		/// <return>The box volume. </return>
		/// <para>@see GetCenter, GetCenterAndExtents, GetExtent, GetSize </para>
		/// </summary>
		public float GetVolume()
			=> E_FBox_GetVolume(this);
		
		
		/// <summary>
		/// <para>Set the initial values of the bounding box to Zero. </para>
		/// </summary>
		public void Init()
			=> E_FBox_Init(this);
		
		
		/// <summary>
		/// <para>Checks whether the given bounding box intersects this bounding box. </para>
		/// <param name="Other">The bounding box to intersect with. </param>
		/// <return>true if the boxes intersect, false otherwise. </return>
		/// </summary>
		public bool Intersect(FBox other)
			=> E_FBox_Intersect(this, other);
		
		
		/// <summary>
		/// <para>Checks whether the given bounding box intersects this bounding box in the XY plane. </para>
		/// <param name="Other">The bounding box to test intersection. </param>
		/// <return>true if the boxes intersect in the XY Plane, false otherwise. </return>
		/// </summary>
		public bool IntersectXY(FBox other)
			=> E_FBox_IntersectXY(this, other);
		
		
		/// <summary>
		/// <para>Gets a bounding volume transformed by an inverted FTransform object. </para>
		/// <param name="M">The transformation object to perform the inversely transform this box with. </param>
		/// <return>The transformed box. </return>
		/// </summary>
		public FBox InverseTransformBy(FTransform m)
			=> E_FBox_InverseTransformBy(this, m);
		
		
		/// <summary>
		/// <para>Checks whether the given location is inside this box. </para>
		/// <param name="In">The location to test for inside the bounding volume. </param>
		/// <return>true if location is inside this volume. </return>
		/// <para>@see IsInsideXY </para>
		/// </summary>
		public bool IsInside(FVector @in)
			=> E_FBox_IsInside(this, @in);
		
		
		/// <summary>
		/// <para>Checks whether a given box is fully encapsulated by this box. </para>
		/// <param name="Other">The box to test for encapsulation within the bounding volume. </param>
		/// <return>true if box is inside this volume. </return>
		/// </summary>
		public bool IsInside(FBox other)
			=> E_FBox_IsInside_o1(this, other);
		
		
		/// <summary>
		/// <para>Checks whether the given location is inside or on this box. </para>
		/// <param name="In">The location to test for inside the bounding volume. </param>
		/// <return>true if location is inside this volume. </return>
		/// <para>@see IsInsideXY </para>
		/// </summary>
		public bool IsInsideOrOn(FVector @in)
			=> E_FBox_IsInsideOrOn(this, @in);
		
		
		/// <summary>
		/// <para>Checks whether the given location is inside this box in the XY plane. </para>
		/// <param name="In">The location to test for inside the bounding box. </param>
		/// <return>true if location is inside this box in the XY plane. </return>
		/// <para>@see IsInside </para>
		/// </summary>
		public bool IsInsideXY(FVector @in)
			=> E_FBox_IsInsideXY(this, @in);
		
		
		/// <summary>
		/// <para>Checks whether the given box is fully encapsulated by this box in the XY plane. </para>
		/// <param name="Other">The box to test for encapsulation within the bounding box. </param>
		/// <return>true if box is inside this box in the XY plane. </return>
		/// </summary>
		public bool IsInsideXY(FBox other)
			=> E_FBox_IsInsideXY_o1(this, other);
		
		
		/// <summary>
		/// <para>Moves the center of bounding box to new destination. </para>
		/// <param name="The">destination point to move center of box to. </param>
		/// <return>A new bounding box. </return>
		/// </summary>
		public FBox MoveTo(FVector destination)
			=> E_FBox_MoveTo(this, destination);
		
		
		/// <summary>
		/// <para>Returns the overlap FBox of two box </para>
		/// <param name="Other">The bounding box to test overlap </param>
		/// <return>the overlap box. It can be 0 if they don't overlap </return>
		/// </summary>
		public FBox Overlap(FBox other)
			=> E_FBox_Overlap(this, other);
		
		
		/// <summary>
		/// <para>Shifts the bounding box position. </para>
		/// <param name="Offset">The vector to shift the box by. </param>
		/// <return>A new bounding box. </return>
		/// </summary>
		public FBox ShiftBy(FVector offset)
			=> E_FBox_ShiftBy(this, offset);
		
		
		/// <summary>
		/// <para>Get a textual representation of this box. </para>
		/// <return>A string describing the box. </return>
		/// </summary>
		public override string ToString()
			=> E_FBox_ToString(this);
		
		
		/// <summary>
		/// <para>Gets a bounding volume transformed by a FTransform object. </para>
		/// <param name="M">The transformation object. </param>
		/// <return>The transformed box. </return>
		/// <para>@see TransformProjectBy </para>
		/// </summary>
		public FBox TransformBy(FTransform m)
			=> E_FBox_TransformBy(this, m);
		
		#endregion
		
		public static implicit operator IntPtr(FBox self)
		{
			return self.NativePointer;
		}

		public static implicit operator FBox(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBox(Adress, false);
		}}}
