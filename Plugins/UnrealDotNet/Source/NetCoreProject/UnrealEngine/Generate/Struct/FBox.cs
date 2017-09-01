using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Implements an axis-aligned box.
	/// Boxes describe an axis-aligned extent in three dimensions. They are used for many different things in the
	/// Engine and in games, such as bounding volumes, collision detection and visibility calculation.
	/// </summary>
	public partial class FBox
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FBox()
		{
			NativePointer = E_CreateStruct_FBox();
			IsRef = false;
		}

		internal FBox(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FBox();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FBox_Min_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBox_Min_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FBox_Max_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBox_Max_SET(IntPtr Ptr, FVector Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_FBox_IsValid_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FBox_IsValid_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FBox_ComputeSquaredDistanceToPoint(FBox Self, IntPtr Point);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_GetCenter(FBox Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FBox_GetCenterAndExtents(FBox Self, IntPtr center, IntPtr Extents);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_GetClosestPointTo(FBox Self, IntPtr Point);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FBox_GetVolume(FBox Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FBox_Init(FBox Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_InverseTransformBy(FBox Self, IntPtr M);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FBox_IsInside(FBox Self, IntPtr In);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_ToString(FBox Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FBox_BuildAABB(FBox Self, IntPtr Origin, IntPtr Extent);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Holds the box's minimum point.
		/// </summary>
		public FVector Min
		{
			get => E_PROP_FBox_Min_GET(NativePointer);
			set => E_PROP_FBox_Min_SET(NativePointer, value);
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
		/// Holds a flag indicating whether this box is valid.
		/// </summary>
		public byte IsValid
		{
			get => E_PROP_FBox_IsValid_GET(NativePointer);
			set => E_PROP_FBox_IsValid_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Calculates the distance of a point to this box.
		/// @param Point The point.
		/// @return The distance.
		/// </summary>
		public float ComputeSquaredDistanceToPoint(FVector Point)
			=> E_FBox_ComputeSquaredDistanceToPoint(this, Point);
		
		
		/// <summary>
		/// Gets the center point of this box.
		/// @return The center point.
		/// @see GetCenterAndExtents, GetExtent, GetSize, GetVolume
		/// </summary>
		public FVector GetCenter()
			=> E_FBox_GetCenter(this);
		
		
		/// <summary>
		/// Gets the center and extents of this box.
		/// @param center[out] Will contain the box center point.
		/// @param Extents[out] Will contain the extent around the center.
		/// @see GetCenter, GetExtent, GetSize, GetVolume
		/// </summary>
		public void GetCenterAndExtents(FVector center, FVector Extents)
			=> E_FBox_GetCenterAndExtents(this, center, Extents);
		
		
		/// <summary>
		/// Calculates the closest point on or inside the box to a given point in space.
		/// @param Point The point in space.
		/// @return The closest point on or inside the box.
		/// </summary>
		public FVector GetClosestPointTo(FVector Point)
			=> E_FBox_GetClosestPointTo(this, Point);
		
		
		/// <summary>
		/// Gets the volume of this box.
		/// @return The box volume.
		/// @see GetCenter, GetCenterAndExtents, GetExtent, GetSize
		/// </summary>
		public float GetVolume()
			=> E_FBox_GetVolume(this);
		
		
		/// <summary>
		/// Set the initial values of the bounding box to Zero.
		/// </summary>
		public void Init()
			=> E_FBox_Init(this);
		
		
		/// <summary>
		/// Gets a bounding volume transformed by an inverted FTransform object.
		/// @param M The transformation object to perform the inversely transform this box with.
		/// @return	The transformed box.
		/// </summary>
		public FBox InverseTransformBy(FTransform M)
			=> E_FBox_InverseTransformBy(this, M);
		
		
		/// <summary>
		/// Checks whether the given location is inside this box.
		/// @param In The location to test for inside the bounding volume.
		/// @return true if location is inside this volume.
		/// @see IsInsideXY
		/// </summary>
		public bool IsInside(FVector In)
			=> E_FBox_IsInside(this, In);
		
		
		/// <summary>
		/// Get a textual representation of this box.
		/// @return A string describing the box.
		/// </summary>
		public override string ToString()
			=> Marshal.PtrToStringUTF8(E_FBox_ToString(this, out int ResultStringLen), ResultStringLen);
		
		
		/// <summary>
		/// Utility function to build an AABB from Origin and Extent
		/// @param Origin The location of the bounding box.
		/// @param Extent Half size of the bounding box.
		/// @return A new axis-aligned bounding box.
		/// </summary>
		public FBox BuildAABB(FVector Origin, FVector Extent)
			=> E_FBox_BuildAABB(this, Origin, Extent);
		
		#endregion
		
		public static implicit operator IntPtr(FBox Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FBox(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBox(Adress, false);
		}}}
