using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1805

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
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FPrimitiveMaterialRef_Decal_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPrimitiveMaterialRef_Decal_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPrimitiveMaterialRef_ElementIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPrimitiveMaterialRef_ElementIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FPrimitiveMaterialRef_Primitive_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPrimitiveMaterialRef_Primitive_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public UDecalComponent Decal
		{
			get => E_PROP_FPrimitiveMaterialRef_Decal_GET(NativePointer);
			set => E_PROP_FPrimitiveMaterialRef_Decal_SET(NativePointer, value);
		}

		public int ElementIndex
		{
			get => E_PROP_FPrimitiveMaterialRef_ElementIndex_GET(NativePointer);
			set => E_PROP_FPrimitiveMaterialRef_ElementIndex_SET(NativePointer, value);
		}

		public UPrimitiveComponent Primitive
		{
			get => E_PROP_FPrimitiveMaterialRef_Primitive_GET(NativePointer);
			set => E_PROP_FPrimitiveMaterialRef_Primitive_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPrimitiveMaterialRef Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPrimitiveMaterialRef(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPrimitiveMaterialRef(Adress, false);
		}}}
