using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPlane : FVector
	{
		internal FPlane(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public FPlane() :
			base(E_CreateStruct_FPlane(), false)
		{
		}

		
		/// <summary>
		/// <para>Copy Constructor. </para>
		/// <param name="P">Plane to copy from. </param>
		/// </summary>
		public FPlane(FPlane P) :
			base(E_CreateStruct_FPlane_FPlane(P), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="V">4D vector to set up plane. </param>
		/// </summary>
		public FPlane(FVector4 V) :
			base(E_CreateStruct_FPlane_FVector4(V), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InX">X-coefficient. </param>
		/// <param name="InY">Y-coefficient. </param>
		/// <param name="InZ">Z-coefficient. </param>
		/// <param name="InW">W-coefficient. </param>
		/// </summary>
		public FPlane(float InX, float InY, float InZ, float InW) :
			base(E_CreateStruct_FPlane_float_float_float_float(InX, InY, InZ, InW), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InNormal">Plane Normal Vector. </param>
		/// <param name="InW">Plane W-coefficient. </param>
		/// </summary>
		public FPlane(FVector InNormal, float InW) :
			base(E_CreateStruct_FPlane_FVector_float(InNormal, InW), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="InBase">Base point in plane. </param>
		/// <param name="InNormal">Plane Normal Vector. </param>
		/// </summary>
		public FPlane(FVector InBase, FVector InNormal) :
			base(E_CreateStruct_FPlane_FVector_FVector(InBase, InNormal), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor. </para>
		/// <param name="A">First point in the plane. </param>
		/// <param name="B">Second point in the plane. </param>
		/// <param name="C">Third point in the plane. </param>
		/// </summary>
		public FPlane(FVector A, FVector B, FVector C) :
			base(E_CreateStruct_FPlane_FVector_FVector_FVector(A, B, C), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FPlane(IntPtr P);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FVector4(IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_float_float_float_float(float InX, float InY, float InZ, float InW);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FVector_float(IntPtr InNormal, float InW);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FVector_FVector(IntPtr InBase, IntPtr InNormal);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlane_FVector_FVector_FVector(IntPtr A, IntPtr B, IntPtr C);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FPlane_W_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPlane_W_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FPlane_Equals(IntPtr Self, IntPtr V, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FPlane_Flip(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
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
		/// <return>0: point is in front of the plane, <0: behind, =0: on the plane. </return>
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
