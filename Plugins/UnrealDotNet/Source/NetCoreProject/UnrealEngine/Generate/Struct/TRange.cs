using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Math\Range.h:48

namespace UnrealEngine
{
	public  partial class TRange : NativeStructWrapper
	{
		internal TRange(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor (no initialization). </para>
		/// </summary>
		public TRange() :
			base(E_CreateStruct_TRange(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_TRange();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_Adjoins(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_TRange_All(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_Conjoins(IntPtr Self, IntPtr X, IntPtr Y);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_Contiguous(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_TRange_Empty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_HasLowerBound(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_HasUpperBound(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_IsDegenerate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_IsEmpty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_Overlaps(IntPtr Self, IntPtr Other);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Checks whether this range adjoins to another. </para>
		/// <para>Two ranges are adjoint if they are next to each other without overlapping, i.e. </para>
		/// <para>[A, B) and [C, C) or </para>
		/// <para>[A, B] and (B, C) </para>
		/// <param name="Other">The other range. </param>
		/// <return>true if this range adjoins the other, false otherwise. </return>
		/// </summary>
		public bool Adjoins(TRange Other)
			=> E_TRange_Adjoins(this, Other);
		
		
		/// <summary>
		/// <para>Creates an unbounded (open) range that contains all elements of the domain. </para>
		/// <return>A new range. </return>
		/// </summary>
		public TRange All()
			=> E_TRange_All(this);
		
		
		/// <summary>
		/// <para>Checks whether this range conjoins the two given ranges. </para>
		/// <para>A range conjoins two non-overlapping ranges if it adjoins both of them, i.e. </para>
		/// <para>[B, C) conjoins the two ranges [A, B) and [C, D). </para>
		/// <param name="X">The first range. </param>
		/// <param name="Y">The second range. </param>
		/// <return>true if this range conjoins the two ranges, false otherwise. </return>
		/// </summary>
		public bool Conjoins(TRange X, TRange Y)
			=> E_TRange_Conjoins(this, X, Y);
		
		
		/// <summary>
		/// <para>Checks if this range is contiguous with another range. </para>
		/// <para>Two ranges are contiguous if they are adjoint or overlapping. </para>
		/// <param name="Other">The other range. </param>
		/// <return>true if the ranges are contiguous, false otherwise. </return>
		/// </summary>
		public bool Contiguous(TRange Other)
			=> E_TRange_Contiguous(this, Other);
		
		
		/// <summary>
		/// <para>Returns an empty range. </para>
		/// <return>Empty range. </return>
		/// </summary>
		public TRange Empty()
			=> E_TRange_Empty(this);
		
		
		/// <summary>
		/// <para>Checks whether the range has a lower bound. </para>
		/// <return>true if the range has a lower bound, false otherwise. </return>
		/// </summary>
		public bool HasLowerBound()
			=> E_TRange_HasLowerBound(this);
		
		
		/// <summary>
		/// <para>Checks whether the range has an upper bound. </para>
		/// <return>true if the range has an upper bound, false otherwise. </return>
		/// </summary>
		public bool HasUpperBound()
			=> E_TRange_HasUpperBound(this);
		
		
		/// <summary>
		/// <para>Checks whether this range is degenerate. </para>
		/// <para>A range is degenerate if it contains only a single element, i.e. has the following form: </para>
		/// <para>[A, A] </para>
		/// <return>true if the range is degenerate, false otherwise. </return>
		/// </summary>
		public bool IsDegenerate()
			=> E_TRange_IsDegenerate(this);
		
		
		/// <summary>
		/// <para>Checks whether this range is empty. </para>
		/// <para>A range is empty if it contains no elements, i.e. </para>
		/// <para>(A, A) </para>
		/// <para>(A, A] </para>
		/// <para>[A, A) </para>
		/// <return>true if the range is empty, false otherwise. </return>
		/// </summary>
		public bool IsEmpty()
			=> E_TRange_IsEmpty(this);
		
		
		/// <summary>
		/// <para>Checks whether this range overlaps with another. </para>
		/// <param name="Other">The other range. </param>
		/// <return>true if the ranges overlap, false otherwise. </return>
		/// </summary>
		public bool Overlaps(TRange Other)
			=> E_TRange_Overlaps(this, Other);
		
		#endregion
		
		public static implicit operator IntPtr(TRange Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator TRange(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new TRange(Adress, false);
		}}}
