using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FInterpControlPoint : NativeStructWrapper
	{
		internal FInterpControlPoint(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInterpControlPoint() :
			base(E_CreateStruct_FInterpControlPoint(), false)
		{
		}

		public FInterpControlPoint(FVector InPosition, bool bIsRelative) :
			base(E_CreateStruct_FInterpControlPoint_FVector_bool(InPosition, bIsRelative), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInterpControlPoint();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInterpControlPoint_FVector_bool(IntPtr InPosition, bool bIsRelative);
		
		#endregion
		
		public static implicit operator IntPtr(FInterpControlPoint Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FInterpControlPoint(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInterpControlPoint(Adress, false);
		}}}
