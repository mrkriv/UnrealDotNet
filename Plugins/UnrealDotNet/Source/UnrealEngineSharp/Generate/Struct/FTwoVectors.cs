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
		/// Default constructor.
		/// </summary>
		public FTwoVectors() :
			base(E_CreateStruct_FTwoVectors(), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new instance with the specified vectors.
		/// </summary>
		/// <param name="in1">The first Vector.</param>
		/// <param name="in2">The second Vector.</param>
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
		/// Holds the first vector.
		/// </summary>
		public FVector v1
		{
			get => E_PROP_FTwoVectors_v1_GET(NativePointer);
			set => E_PROP_FTwoVectors_v1_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Holds the second vector.
		/// </summary>
		public FVector v2
		{
			get => E_PROP_FTwoVectors_v2_GET(NativePointer);
			set => E_PROP_FTwoVectors_v2_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Error-tolerant comparison.
		/// </summary>
		/// <param name="v">The other pair.</param>
		/// <param name="tolerance">Error Tolerance.</param>
		/// <return>true</return>
		public bool Equals(FTwoVectors v, float tolerance)
			=> E_FTwoVectors_Equals(this, v, tolerance);
		
		
		/// <summary>
		/// Get the maximum value of all the vector coordinates.
		/// </summary>
		/// <return>The</return>
		public float GetMax()
			=> E_FTwoVectors_GetMax(this);
		
		
		/// <summary>
		/// Get the minimum value of all the vector coordinates.
		/// </summary>
		/// <return>The</return>
		public float GetMin()
			=> E_FTwoVectors_GetMin(this);
		
		
		/// <summary>
		/// Get a textual representation of this two-vector.
		/// </summary>
		/// <return>A</return>
		public override string ToString()
			=> E_FTwoVectors_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FTwoVectors self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTwoVectors(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTwoVectors(adress, false);
		}}}
