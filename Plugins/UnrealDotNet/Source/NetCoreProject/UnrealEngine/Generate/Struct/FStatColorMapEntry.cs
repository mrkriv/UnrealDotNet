using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FStatColorMapEntry : NativeStructWrapper
	{
		internal FStatColorMapEntry(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FStatColorMapEntry() :
			base(E_CreateStruct_FStatColorMapEntry(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStatColorMapEntry();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FStatColorMapEntry_In_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FStatColorMapEntry_In_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public float In
		{
			get => E_PROP_FStatColorMapEntry_In_GET(NativePointer);
			set => E_PROP_FStatColorMapEntry_In_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FStatColorMapEntry Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FStatColorMapEntry(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStatColorMapEntry(Adress, false);
		}
}
}
