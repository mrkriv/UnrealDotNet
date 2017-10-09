using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Math\Range.h:48

namespace UnrealEngine
{
	public  partial class TRange : NativeWrapper
	{
		public TRange(IntPtr Adress)
			: base(Adress)
		{
		}

		public TRange(UObject Parent = null, string Name = "Range")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_TRange(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_TRange(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_TRange_All(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_TRange_Empty(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_HasLowerBound(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_HasUpperBound(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_IsDegenerate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_TRange_IsEmpty(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Creates an unbounded (open) range that contains all elements of the domain. </para>
		/// <return>A new range. </return>
		/// </summary>
		public TRange All()
			=> E_TRange_All(this);
		
		
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
		
		#endregion
		
		public static implicit operator IntPtr(TRange Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator TRange(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<TRange>(PtrDesc);
		}}}
