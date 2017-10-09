using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Math\Box2D.h:14

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
		public FBox2D(FVector2D InMin, FVector2D InMax) :
			base(E_CreateStruct_FBox2D_FVector2D_FVector2D(InMin, InMax), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new box from the given set of points. </para>
		/// <param name="Points">Array of Points to create for the bounding volume. </param>
		/// <param name="Count">The number of points. </param>
		/// </summary>
		public FBox2D(FVector2D Points, int Count) :
			base(E_CreateStruct_FBox2D_FVector2D_int32(Points, Count), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D_int32(int _p0);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D_FVector2D_FVector2D(IntPtr InMin, IntPtr InMax);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D_FVector2D_int32(IntPtr Points, int Count);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FBox2D_bIsValid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBox2D_bIsValid_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBox2D_Max_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBox2D_Max_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBox2D_Min_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBox2D_Min_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FBox2D_ComputeSquaredDistanceToPoint(IntPtr Self, IntPtr Point);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_ExpandBy(IntPtr Self, float W);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FBox2D_GetArea(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetCenter(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBox2D_GetCenterAndExtents(IntPtr Self, IntPtr center, IntPtr Extents);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetClosestPointTo(IntPtr Self, IntPtr Point);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetSize(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBox2D_Init(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBox2D_Intersect(IntPtr Self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_ShiftBy(IntPtr Self, IntPtr Offset);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FBox2D_ToString(IntPtr Self);
		
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
		public float ComputeSquaredDistanceToPoint(FVector2D Point)
			=> E_FBox2D_ComputeSquaredDistanceToPoint(this, Point);
		
		
		/// <summary>
		/// <para>Increase the bounding box volume. </para>
		/// <param name="W">The size to increase volume by. </param>
		/// <return>A new bounding box increased in size. </return>
		/// </summary>
		public FBox2D ExpandBy(float W)
			=> E_FBox2D_ExpandBy(this, W);
		
		
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
		public void GetCenterAndExtents(FVector2D center, FVector2D Extents)
			=> E_FBox2D_GetCenterAndExtents(this, center, Extents);
		
		
		/// <summary>
		/// <para>Calculates the closest point on or inside the box to a given point in space. </para>
		/// <param name="Point">The point in space. </param>
		/// <return>The closest point on or inside the box. </return>
		/// </summary>
		public FVector2D GetClosestPointTo(FVector2D Point)
			=> E_FBox2D_GetClosestPointTo(this, Point);
		
		
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
		/// <para>Shift bounding box position. </para>
		/// <param name="The">offset vector to shift by. </param>
		/// <return>A new shifted bounding box. </return>
		/// </summary>
		public FBox2D ShiftBy(FVector2D Offset)
			=> E_FBox2D_ShiftBy(this, Offset);
		
		
		/// <summary>
		/// <para>Get a textual representation of this box. </para>
		/// <return>A string describing the box. </return>
		/// </summary>
		public override string ToString()
			=> E_FBox2D_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBox2D Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBox2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBox2D(Adress, false);
		}}}
