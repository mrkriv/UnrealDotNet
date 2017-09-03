using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageBox
	/// <para>Implements an axis-aligned box. </para>
	/// <para>Boxes describe an axis-aligned extent in three dimensions. They are used for many different things in the </para>
	/// <para>Engine and in games, such as bounding volumes, collision detection and visibility calculation. </para>
	/// </summary>
	public  partial class FBox : NativeStructWrapper
	{
		public FBox() : base(E_CreateStruct_FBox(), false)
		{
		}

		internal FBox(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FBox();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_FBox_IsValid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBox_IsValid_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FBox_Max_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBox_Max_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FBox_Min_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBox_Min_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_BuildAABB(FBox Self, IntPtr Origin, IntPtr Extent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FBox_ComputeSquaredDistanceToPoint(FBox Self, IntPtr Point);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_GetCenter(FBox Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FBox_GetCenterAndExtents(FBox Self, IntPtr center, IntPtr Extents);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_GetClosestPointTo(FBox Self, IntPtr Point);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_GetExtent(FBox Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_GetSize(FBox Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FBox_GetVolume(FBox Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FBox_Init(FBox Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FBox_Intersect(FBox Self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FBox_IntersectXY(FBox Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_InverseTransformBy(FBox Self, IntPtr M);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FBox_IsInsideOrOn(FBox Self, IntPtr In);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_MoveTo(FBox Self, IntPtr Destination);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_Overlap(FBox Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_ShiftBy(FBox Self, IntPtr Offset);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_ToString(FBox Self, out int ResultStringLen);
		
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
		public FBox BuildAABB(FVector Origin, FVector Extent)
			=> E_FBox_BuildAABB(this, Origin, Extent);
		
		
		/// <summary>
		/// <para>Calculates the distance of a point to this box. </para>
		/// <param name="Point">The point. </param>
		/// <return>The distance. </return>
		/// </summary>
		public float ComputeSquaredDistanceToPoint(FVector Point)
			=> E_FBox_ComputeSquaredDistanceToPoint(this, Point);
		
		
		/// <summary>
		/// <para>Gets the center point of this box. </para>
		/// <return>The center point. </return>
		/// <para>@see GetCenterAndExtents, GetExtent, GetSize, GetVolume </para>
		/// </summary>
		public FVector GetCenter()
			=> E_FBox_GetCenter(this);
		
		
		/// <summary>
		/// <para>Gets the center and extents of this box. </para>
		/// <para>@param center[out] Will contain the box center point. </para>
		/// <para>@param Extents[out] Will contain the extent around the center. </para>
		/// <para>@see GetCenter, GetExtent, GetSize, GetVolume </para>
		/// </summary>
		public void GetCenterAndExtents(FVector center, FVector Extents)
			=> E_FBox_GetCenterAndExtents(this, center, Extents);
		
		
		/// <summary>
		/// <para>Calculates the closest point on or inside the box to a given point in space. </para>
		/// <param name="Point">The point in space. </param>
		/// <return>The closest point on or inside the box. </return>
		/// </summary>
		public FVector GetClosestPointTo(FVector Point)
			=> E_FBox_GetClosestPointTo(this, Point);
		
		
		/// <summary>
		/// <para>Gets the extents of this box. </para>
		/// <return>The box extents. </return>
		/// <para>@see GetCenter, GetCenterAndExtents, GetSize, GetVolume </para>
		/// </summary>
		public FVector GetExtent()
			=> E_FBox_GetExtent(this);
		
		
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
		public bool IntersectXY(FBox Other)
			=> E_FBox_IntersectXY(this, Other);
		
		
		/// <summary>
		/// <para>Gets a bounding volume transformed by an inverted FTransform object. </para>
		/// <param name="M">The transformation object to perform the inversely transform this box with. </param>
		/// <return>The transformed box. </return>
		/// </summary>
		public FBox InverseTransformBy(FTransform M)
			=> E_FBox_InverseTransformBy(this, M);
		
		
		/// <summary>
		/// <para>Checks whether the given location is inside or on this box. </para>
		/// <param name="In">The location to test for inside the bounding volume. </param>
		/// <return>true if location is inside this volume. </return>
		/// <para>@see IsInsideXY </para>
		/// </summary>
		public bool IsInsideOrOn(FVector In)
			=> E_FBox_IsInsideOrOn(this, In);
		
		
		/// <summary>
		/// <para>Moves the center of bounding box to new destination. </para>
		/// <param name="The">destination point to move center of box to. </param>
		/// <return>A new bounding box. </return>
		/// </summary>
		public FBox MoveTo(FVector Destination)
			=> E_FBox_MoveTo(this, Destination);
		
		
		/// <summary>
		/// <para>Returns the overlap FBox of two box </para>
		/// <param name="Other">The bounding box to test overlap </param>
		/// <return>the overlap box. It can be 0 if they don't overlap </return>
		/// </summary>
		public FBox Overlap(FBox Other)
			=> E_FBox_Overlap(this, Other);
		
		
		/// <summary>
		/// <para>Shifts the bounding box position. </para>
		/// <param name="Offset">The vector to shift the box by. </param>
		/// <return>A new bounding box. </return>
		/// </summary>
		public FBox ShiftBy(FVector Offset)
			=> E_FBox_ShiftBy(this, Offset);
		
		
		/// <summary>
		/// <para>Get a textual representation of this box. </para>
		/// <return>A string describing the box. </return>
		/// </summary>
		public override string ToString()
			=> Marshal.PtrToStringUTF8(E_FBox_ToString(this, out int ResultStringLen), ResultStringLen);
		
		#endregion
		
		public static implicit operator IntPtr(FBox Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBox(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBox(Adress, false);
		}}}
