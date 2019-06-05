// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\Box2D.h:14

namespace UnrealEngine
{
	public partial class FBox2D : NativeStructWrapper
	{
		public FBox2D(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FBox2D() :
			base(E_CreateStruct_FBox2D(), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new box.
		/// <para>The box extents are initialized to zero and the box is marked as invalid. </para>
		/// </summary>
		public FBox2D(int _p0) :
			base(E_CreateStruct_FBox2D_int32(_p0), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new box from the specified parameters.
		/// </summary>
		/// <param name="inMin">The box's minimum point.</param>
		/// <param name="inMax">The box's maximum point.</param>
		public FBox2D(FVector2D inMin, FVector2D inMax) :
			base(E_CreateStruct_FBox2D_FVector2D_FVector2D(inMin, inMax), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new box from the given set of points.
		/// </summary>
		/// <param name="points">Array of Points to create for the bounding volume.</param>
		/// <param name="count">The number of points.</param>
		public FBox2D(FVector2D points, int count) :
			base(E_CreateStruct_FBox2D_FVector2D_int32(points, count), false)
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
		/// Holds a flag indicating whether this box is valid.
		/// </summary>
		public bool bIsValid
		{
			get => E_PROP_FBox2D_bIsValid_GET(NativePointer);
			set => E_PROP_FBox2D_bIsValid_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the box's maximum point.
		/// </summary>
		public FVector2D Max
		{
			get => E_PROP_FBox2D_Max_GET(NativePointer);
			set => E_PROP_FBox2D_Max_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the box's minimum point.
		/// </summary>
		public FVector2D Min
		{
			get => E_PROP_FBox2D_Min_GET(NativePointer);
			set => E_PROP_FBox2D_Min_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Calculates the distance of a point to this box.
		/// </summary>
		/// <param name="point">The point.</param>
		/// <return>The</return>
		public float ComputeSquaredDistanceToPoint(FVector2D point)
			=> E_FBox2D_ComputeSquaredDistanceToPoint(this, point);
		
		
		/// <summary>
		/// Increase the bounding box volume.
		/// </summary>
		/// <param name="w">The size to increase volume by.</param>
		/// <return>A</return>
		public FBox2D ExpandBy(float w)
			=> E_FBox2D_ExpandBy(this, w);
		
		
		/// <summary>
		/// Gets the box area.
		/// <see cref="GetCenter"/>
		/// </summary>
		/// <return>Box</return>
		public float GetArea()
			=> E_FBox2D_GetArea(this);
		
		
		/// <summary>
		/// Gets the box's center point.
		/// <see cref="GetArea"/>
		/// </summary>
		/// <return>Th</return>
		public FVector2D GetCenter()
			=> E_FBox2D_GetCenter(this);
		
		
		/// <summary>
		/// Get the center and extents
		/// <see cref="GetArea"/>
		/// </summary>
		/// <param name="center">out] reference to center point</param>
		/// <param name="extents">out] reference to the extent around the center</param>
		public void GetCenterAndExtents(FVector2D center, FVector2D extents)
			=> E_FBox2D_GetCenterAndExtents(this, center, extents);
		
		
		/// <summary>
		/// Calculates the closest point on or inside the box to a given point in space.
		/// </summary>
		/// <param name="point">The point in space.</param>
		/// <return>The</return>
		public FVector2D GetClosestPointTo(FVector2D point)
			=> E_FBox2D_GetClosestPointTo(this, point);
		
		
		/// <summary>
		/// Gets the box extents around the center.
		/// <see cref="GetArea"/>
		/// </summary>
		/// <return>Box</return>
		public FVector2D GetExtent()
			=> E_FBox2D_GetExtent(this);
		
		
		/// <summary>
		/// Gets the box size.
		/// <see cref="GetArea"/>
		/// </summary>
		/// <return>Box</return>
		public FVector2D GetSize()
			=> E_FBox2D_GetSize(this);
		
		
		/// <summary>
		/// Set the initial values of the bounding box to Zero.
		/// </summary>
		public void Init()
			=> E_FBox2D_Init(this);
		
		
		/// <summary>
		/// Checks whether the given box intersects this box.
		/// </summary>
		/// <param name="other">bounding box to test intersection</param>
		/// <return>true</return>
		public bool Intersect(FBox2D other)
			=> E_FBox2D_Intersect(this, other);
		
		
		/// <summary>
		/// Checks whether the given point is inside this box.
		/// </summary>
		/// <param name="point">The point to test.</param>
		/// <return>true</return>
		public bool IsInside(FVector2D testPoint)
			=> E_FBox2D_IsInside(this, testPoint);
		
		
		/// <summary>
		/// Checks whether the given box is fully encapsulated by this box.
		/// </summary>
		/// <param name="other">The box to test for encapsulation within the bounding volume.</param>
		/// <return>true</return>
		public bool IsInside(FBox2D other)
			=> E_FBox2D_IsInside_o1(this, other);
		
		
		/// <summary>
		/// Shift bounding box position.
		/// </summary>
		/// <param name="the">offset vector to shift by.</param>
		/// <return>A</return>
		public FBox2D ShiftBy(FVector2D offset)
			=> E_FBox2D_ShiftBy(this, offset);
		
		
		/// <summary>
		/// Get a textual representation of this box.
		/// </summary>
		/// <return>A</return>
		public override string ToString()
			=> E_FBox2D_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBox2D self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBox2D(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBox2D(adress, false);
		}}}
