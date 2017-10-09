using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineTypes.h:1814

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPrimitiveMaterialRef();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPrimitiveMaterialRef_ElementIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPrimitiveMaterialRef_ElementIndex_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		public int ElementIndex
		{
			get => E_PROP_FPrimitiveMaterialRef_ElementIndex_GET(NativePointer);
			set => E_PROP_FPrimitiveMaterialRef_ElementIndex_SET(NativePointer, value);
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
