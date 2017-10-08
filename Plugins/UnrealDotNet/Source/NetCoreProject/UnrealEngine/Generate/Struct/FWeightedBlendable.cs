using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FWeightedBlendable : NativeStructWrapper
	{
		internal FWeightedBlendable(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FWeightedBlendable() :
			base(E_CreateStruct_FWeightedBlendable(), false)
		{
		}

		public FWeightedBlendable(float InWeight, UObject InObject) :
			base(E_CreateStruct_FWeightedBlendable_float_UObject(InWeight, InObject), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWeightedBlendable();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWeightedBlendable_float_UObject(float InWeight, IntPtr InObject);
		
		#endregion
		
		public static implicit operator IntPtr(FWeightedBlendable Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FWeightedBlendable(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWeightedBlendable(Adress, false);
		}}}
