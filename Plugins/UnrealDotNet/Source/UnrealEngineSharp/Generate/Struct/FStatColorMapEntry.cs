// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:426

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FStatColorMapEntry();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FStatColorMapEntry_In_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FStatColorMapEntry_In_SET(IntPtr Ptr, float Value);
		
		#endregion
		
		#region Property
		public float In
		{
			get => E_PROP_FStatColorMapEntry_In_GET(NativePointer);
			set => E_PROP_FStatColorMapEntry_In_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FStatColorMapEntry self)
		{
			return self.NativePointer;
		}

		public static implicit operator FStatColorMapEntry(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FStatColorMapEntry(Adress, false);
		}}}
