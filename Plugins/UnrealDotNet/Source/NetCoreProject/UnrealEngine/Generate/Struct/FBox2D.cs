using System;
using System.Runtime.InteropServices;

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBox2D_int32(int _p0);
		
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
		private static extern IntPtr E_FBox2D_ExpandBy(IntPtr Self, float W);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FBox2D_GetArea(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetCenter(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FBox2D_GetSize(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBox2D_Init(IntPtr Self);
		
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
