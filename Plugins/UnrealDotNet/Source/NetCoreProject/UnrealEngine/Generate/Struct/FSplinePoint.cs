using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSplinePoint : NativeStructWrapper
	{
		internal FSplinePoint(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor </para>
		/// </summary>
		public FSplinePoint() :
			base(E_CreateStruct_FSplinePoint(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor taking a point position </para>
		/// </summary>
		public FSplinePoint(float InInputKey, FVector InPosition) :
			base(E_CreateStruct_FSplinePoint_float_FVector(InInputKey, InPosition), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplinePoint();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSplinePoint_float_FVector(float InInputKey, IntPtr InPosition);
		
		#endregion
		
		public static implicit operator IntPtr(FSplinePoint Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSplinePoint(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSplinePoint(Adress, false);
		}}}
