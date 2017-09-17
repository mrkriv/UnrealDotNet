using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPlane : FVector
	{
		public FPlane() : base(E_CreateStruct_FPlane(), false)
		{
		}

		internal FPlane(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FPlane();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_FPlane_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FPlane_W_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FPlane_Equals(IntPtr Self, IntPtr V, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_FPlane_Flip(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_FPlane_PlaneDot(IntPtr Self, IntPtr P);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The w-component. </para>
		/// </summary>
		public float W
		{
			get => E_PROP_FPlane_W_GET(NativePointer);
			set => E_PROP_FPlane_W_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Checks whether two planes are equal within specified tolerance. </para>
		/// <param name="V">The other plane. </param>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if the two planes are equal within specified tolerance, otherwise false. </return>
		/// </summary>
		public bool Equals(FPlane V, float Tolerance)
			=> E_FPlane_Equals(this, V, Tolerance);
		
		
		/// <summary>
		/// <para>Get a flipped version of the plane. </para>
		/// <return>A flipped version of the plane. </return>
		/// </summary>
		public FPlane Flip()
			=> E_FPlane_Flip(this);
		
		
		/// <summary>
		/// <para>Calculates distance between plane and a point. </para>
		/// <param name="P">The other point. </param>
		/// <return>>0: point is in front of the plane, <0: behind, =0: on the plane. </return>
		/// </summary>
		public float PlaneDot(FVector P)
			=> E_FPlane_PlaneDot(this, P);
		
		#endregion
		
		public static implicit operator IntPtr(FPlane Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPlane(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPlane(Adress, false);
		}}}
