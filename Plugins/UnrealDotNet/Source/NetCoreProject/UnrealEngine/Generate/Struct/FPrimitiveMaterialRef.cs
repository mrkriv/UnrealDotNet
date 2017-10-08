using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FPrimitiveMaterialRef : NativeStructWrapper
	{
		internal FPrimitiveMaterialRef(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FPrimitiveMaterialRef() :
			base(E_CreateStruct_FPrimitiveMaterialRef(), false)
		{
		}

		public FPrimitiveMaterialRef(UPrimitiveComponent InPrimitive, int InElementIndex) :
			base(E_CreateStruct_FPrimitiveMaterialRef_UPrimitiveComponent_int32(InPrimitive, InElementIndex), false)
		{
		}

		public FPrimitiveMaterialRef(UDecalComponent InDecal, int InElementIndex) :
			base(E_CreateStruct_FPrimitiveMaterialRef_UDecalComponent_int32(InDecal, InElementIndex), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPrimitiveMaterialRef();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPrimitiveMaterialRef_UPrimitiveComponent_int32(IntPtr InPrimitive, int InElementIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPrimitiveMaterialRef_UDecalComponent_int32(IntPtr InDecal, int InElementIndex);
		
		#endregion
		
		public static implicit operator IntPtr(FPrimitiveMaterialRef Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPrimitiveMaterialRef(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPrimitiveMaterialRef(Adress, false);
		}}}
