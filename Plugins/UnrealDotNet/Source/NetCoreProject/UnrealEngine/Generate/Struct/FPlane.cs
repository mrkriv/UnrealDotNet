using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Structure for three dimensional planes.
	/// Stores the coeffecients as Xx+Yy+Zz=W.
	/// Note that this is different from many other Plane classes that use Xx+Yy+Zz+W=0.
	/// </summary>
	public partial class FPlane : FVector
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FPlane()
		{
			NativePointer = E_CreateStruct_FPlane();
			IsRef = false;
		}

		internal FPlane(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FPlane();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FPlane_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FPlane_W_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FPlane_PlaneDot(FPlane Self, IntPtr P);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FPlane_Flip(FPlane Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FPlane_Equals(FPlane Self, IntPtr V, float Tolerance);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The w-component.
		/// </summary>
		public float W
		{
			get => E_PROP_FPlane_W_GET(NativePointer);
			set => E_PROP_FPlane_W_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Calculates distance between plane and a point.
		/// @param P The other point.
		/// @return >0: point is in front of the plane, <0: behind, =0: on the plane.
		/// </summary>
		public float PlaneDot(FVector P)
			=> E_FPlane_PlaneDot(this, P);
		
		
		/// <summary>
		/// Get a flipped version of the plane.
		/// @return A flipped version of the plane.
		/// </summary>
		public FPlane Flip()
			=> E_FPlane_Flip(this);
		
		
		/// <summary>
		/// Checks whether two planes are equal within specified tolerance.
		/// @param V The other plane.
		/// @param Tolerance Error Tolerance.
		/// @return true if the two planes are equal within specified tolerance, otherwise false.
		/// </summary>
		public bool Equals(FPlane V, float Tolerance)
			=> E_FPlane_Equals(this, V, Tolerance);
		
		#endregion
		
		public static implicit operator IntPtr(FPlane Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPlane(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPlane(Adress, false);
		}}}
