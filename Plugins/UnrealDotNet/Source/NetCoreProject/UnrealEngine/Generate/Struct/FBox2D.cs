using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FBox2D : NativeStructWrapper
	{
		public FBox2D() : base(E_CreateStruct_FBox2D(), false)
		{
		}

		internal FBox2D(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FBox2D();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FBox2D_bIsValid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBox2D_bIsValid_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FBox2D_Max_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBox2D_Max_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FBox2D_Min_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBox2D_Min_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FBox2D_ComputeSquaredDistanceToPoint(FBox2D Self, IntPtr Point);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox2D_ExpandBy(FBox2D Self, float W);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FBox2D_GetArea(FBox2D Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox2D_GetCenter(FBox2D Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FBox2D_GetCenterAndExtents(FBox2D Self, IntPtr center, IntPtr Extents);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox2D_GetClosestPointTo(FBox2D Self, IntPtr Point);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox2D_GetExtent(FBox2D Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox2D_GetSize(FBox2D Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FBox2D_Init(FBox2D Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FBox2D_Intersect(FBox2D Self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox2D_ShiftBy(FBox2D Self, IntPtr Offset);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox2D_ToString(FBox2D Self, out int ResultStringLen);
		
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
		/// <para>@param center[out] reference to center point </para>
		/// <para>@param Extents[out] reference to the extent around the center </para>
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
			=> Marshal.PtrToStringUTF8(E_FBox2D_ToString(this, out int ResultStringLen), ResultStringLen);
		
		#endregion
		
		public static implicit operator IntPtr(FBox2D Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBox2D(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBox2D(Adress, false);
		}}}
