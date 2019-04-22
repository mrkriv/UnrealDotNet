// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\TwoVectors.h:14

namespace UnrealEngine
{
	public  partial class FTwoVectors : NativeStructWrapper
	{
		internal FTwoVectors(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor. </para>
		/// </summary>
		public FTwoVectors() :
			base(E_CreateStruct_FTwoVectors(), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new instance with the specified vectors. </para>
		/// <param name="In1">The first Vector. </param>
		/// <param name="In2">The second Vector. </param>
		/// </summary>
		public FTwoVectors(FVector in1, FVector in2) :
			base(E_CreateStruct_FTwoVectors_FVector_FVector(in1, in2), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FTwoVectors_v1_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTwoVectors_v1_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FTwoVectors_v2_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTwoVectors_v2_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTwoVectors();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTwoVectors_FVector_FVector(IntPtr in1, IntPtr in2);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTwoVectors_Equals(IntPtr self, IntPtr v, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTwoVectors_GetMax(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTwoVectors_GetMin(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FTwoVectors_ToString(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Holds the first vector. </para>
		/// </summary>
		public FVector v1
		{
			get => E_PROP_FTwoVectors_v1_GET(NativePointer);
			set => E_PROP_FTwoVectors_v1_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Holds the second vector. </para>
		/// </summary>
		public FVector v2
		{
			get => E_PROP_FTwoVectors_v2_GET(NativePointer);
			set => E_PROP_FTwoVectors_v2_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Error-tolerant comparison. </para>
		/// <param name="V">The other pair. </param>
		/// <param name="Tolerance">Error Tolerance. </param>
		/// <return>true if two pairs are equal within specified tolerance, false otherwise.. </return>
		/// </summary>
		public bool Equals(FTwoVectors v, float tolerance)
			=> E_FTwoVectors_Equals(this, v, tolerance);
		
		
		/// <summary>
		/// <para>Get the maximum value of all the vector coordinates. </para>
		/// <return>The maximum value of all the vector coordinates. </return>
		/// </summary>
		public float GetMax()
			=> E_FTwoVectors_GetMax(this);
		
		
		/// <summary>
		/// <para>Get the minimum value of all the vector coordinates. </para>
		/// <return>The minimum value of all the vector coordinates. </return>
		/// </summary>
		public float GetMin()
			=> E_FTwoVectors_GetMin(this);
		
		
		/// <summary>
		/// <para>Get a textual representation of this two-vector. </para>
		/// <return>A string describing the two-vector. </return>
		/// </summary>
		public override string ToString()
			=> E_FTwoVectors_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FTwoVectors self)
		{
			return self.NativePointer;
		}

		public static implicit operator FTwoVectors(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTwoVectors(Adress, false);
		}}}
