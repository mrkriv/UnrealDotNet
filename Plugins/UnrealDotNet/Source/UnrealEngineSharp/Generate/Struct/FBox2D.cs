// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Box2D.h:14

namespace UnrealEngine
{
	public  partial class FBox2D : NativeStructWrapper
	{
		internal FBox2D(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FBox2D() :
			base(E_CreateStruct_FBox2D(), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new box. </para>
		/// <para>The box extents are initialized to zero and the box is marked as invalid. </para>
		/// </summary>
		public FBox2D(int _p0) :
			base(E_CreateStruct_FBox2D_int32(_p0), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new box from the specified parameters. </para>
		/// <param name="InMin">The box's minimum point. </param>
		/// <param name="InMax">The box's maximum point. </param>
		/// </summary>
		public FBox2D(FVector2D inMin, FVector2D inMax) :
			base(E_CreateStruct_FBox2D_FVector2D_FVector2D(inMin, inMax), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new box from the given set of points. </para>
		/// <param name="Points">Array of Points to create for the bounding volume. </param>
		/// <param name="Count">The number of points. </param>
		/// </summary>
		public FBox2D(FVector2D points, int count) :
			base(E_CreateStruct_FBox2D_FVector2D_int32(points, count), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new box from an array of points. </para>
		/// <param name="Points">Array of Points to create for the bounding volume. </param>
		/// </summary>
		public FBox2D(TArray<FVector2D> points) :
			base(E_CreateStruct_FBox2D_TArray__FVector2D(points), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FBox2D_bIsValid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBox2D_bIsValid_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBox2D_Max_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBox2D_Max_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBox2D_Min_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBox2D_Min_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D_int32(int _p0);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D_FVector2D_FVector2D(IntPtr inMin, IntPtr inMax);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D_FVector2D_int32(IntPtr points, int count);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D_TArray__FVector2D(IntPtr points);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FBox2D_ComputeSquaredDistanceToPoint(IntPtr self, IntPtr point);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_ExpandBy(IntPtr self, float w);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FBox2D_GetArea(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetCenter(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBox2D_GetCenterAndExtents(IntPtr self, IntPtr center, IntPtr extents);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetClosestPointTo(IntPtr self, IntPtr point);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetExtent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBox2D_Init(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox2D_Intersect(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox2D_IsInside(IntPtr self, IntPtr testPoint);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox2D_IsInside_o1(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_ShiftBy(IntPtr self, IntPtr offset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FBox2D_ToString(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Holds a flag indicating whether this box is valid. </para>
		/// </summary>
		public bool bIsValid
		{
			get => E_PROP_FBox2D_bIsValid_GET(NativePointer);
			set => E_PROP_FBox2D_bIsValid_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the box's maximum point. </para>
		/// </summary>
		public FVector2D Max
		{
			get => E_PROP_FBox2D_Max_GET(NativePointer);
			set => E_PROP_FBox2D_Max_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the box's minimum point. </para>
		/// </summary>
		public FVector2D Min
		{
			get => E_PROP_FBox2D_Min_GET(NativePointer);
			set => E_PROP_FBox2D_Min_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Calculates the distance of a point to this box. </para>
		/// <param name="Point">The point. </param>
		/// <return>The distance. </return>
		/// </summary>
		public float ComputeSquaredDistanceToPoint(FVector2D point)
			=> E_FBox2D_ComputeSquaredDistanceToPoint(this, point);
		
		
		/// <summary>
		/// <para>Increase the bounding box volume. </para>
		/// <param name="W">The size to increase volume by. </param>
		/// <return>A new bounding box increased in size. </return>
		/// </summary>
		public FBox2D ExpandBy(float w)
			=> E_FBox2D_ExpandBy(this, w);
		
		
		/// <summary>
		/// <para>Gets the box area. </para>
		/// <return>Box area. </return>
		/// <para>@see GetCenter, GetCenterAndExtents, GetExtent, GetSize </para>
		/// </summary>
		public float GetArea()
			=> E_FBox2D_GetArea(this);
		
		
		/// <summary>
		/// <para>Gets the box's center point. </para>
		/// <return>Th center point. </return>
		/// <para>@see GetArea, GetCenterAndExtents, GetExtent, GetSize </para>
		/// </summary>
		public FVector2D GetCenter()
			=> E_FBox2D_GetCenter(this);
		
		
		/// <summary>
		/// <para>Get the center and extents </para>
		/// <param name="center">out] reference to center point </param>
		/// <param name="Extents">out] reference to the extent around the center </param>
		/// <para>@see GetArea, GetCenter, GetExtent, GetSize </para>
		/// </summary>
		public void GetCenterAndExtents(FVector2D center, FVector2D extents)
			=> E_FBox2D_GetCenterAndExtents(this, center, extents);
		
		
		/// <summary>
		/// <para>Calculates the closest point on or inside the box to a given point in space. </para>
		/// <param name="Point">The point in space. </param>
		/// <return>The closest point on or inside the box. </return>
		/// </summary>
		public FVector2D GetClosestPointTo(FVector2D point)
			=> E_FBox2D_GetClosestPointTo(this, point);
		
		
		/// <summary>
		/// <para>Gets the box extents around the center. </para>
		/// <return>Box extents. </return>
		/// <para>@see GetArea, GetCenter, GetCenterAndExtents, GetSize </para>
		/// </summary>
		public FVector2D GetExtent()
			=> E_FBox2D_GetExtent(this);
		
		
		/// <summary>
		/// <para>Gets the box size. </para>
		/// <return>Box size. </return>
		/// <para>@see GetArea, GetCenter, GetCenterAndExtents, GetExtent </para>
		/// </summary>
		public FVector2D GetSize()
			=> E_FBox2D_GetSize(this);
		
		
		/// <summary>
		/// <para>Set the initial values of the bounding box to Zero. </para>
		/// </summary>
		public void Init()
			=> E_FBox2D_Init(this);
		
		
		/// <summary>
		/// <para>Checks whether the given box intersects this box. </para>
		/// <param name="other">bounding box to test intersection </param>
		/// <return>true if boxes intersect, false otherwise. </return>
		/// </summary>
		public bool Intersect(FBox2D other)
			=> E_FBox2D_Intersect(this, other);
		
		
		/// <summary>
		/// <para>Checks whether the given point is inside this box. </para>
		/// <param name="Point">The point to test. </param>
		/// <return>true if the point is inside this box, otherwise false. </return>
		/// </summary>
		public bool IsInside(FVector2D testPoint)
			=> E_FBox2D_IsInside(this, testPoint);
		
		
		/// <summary>
		/// <para>Checks whether the given box is fully encapsulated by this box. </para>
		/// <param name="Other">The box to test for encapsulation within the bounding volume. </param>
		/// <return>true if box is inside this volume, false otherwise. </return>
		/// </summary>
		public bool IsInside(FBox2D other)
			=> E_FBox2D_IsInside_o1(this, other);
		
		
		/// <summary>
		/// <para>Shift bounding box position. </para>
		/// <param name="The">offset vector to shift by. </param>
		/// <return>A new shifted bounding box. </return>
		/// </summary>
		public FBox2D ShiftBy(FVector2D offset)
			=> E_FBox2D_ShiftBy(this, offset);
		
		
		/// <summary>
		/// <para>Get a textual representation of this box. </para>
		/// <return>A string describing the box. </return>
		/// </summary>
		public override string ToString()
			=> E_FBox2D_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBox2D self)
		{
			return self.NativePointer;
		}

		public static implicit operator FBox2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBox2D(Adress, false);
		}}}
