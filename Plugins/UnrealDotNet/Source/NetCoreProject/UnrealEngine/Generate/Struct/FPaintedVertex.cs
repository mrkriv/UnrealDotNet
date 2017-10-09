using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPaintedVertex : NativeStructWrapper
	{
		internal FPaintedVertex(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPaintedVertex() :
			base(E_CreateStruct_FPaintedVertex(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPaintedVertex();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FPaintedVertex_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPaintedVertex_Position_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public FVector Position
		{
			get => E_PROP_FPaintedVertex_Position_GET(NativePointer);
			set => E_PROP_FPaintedVertex_Position_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPaintedVertex Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPaintedVertex(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPaintedVertex(Adress, false);
		}}}
