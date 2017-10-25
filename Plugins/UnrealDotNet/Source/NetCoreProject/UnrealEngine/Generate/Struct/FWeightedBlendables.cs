using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\Scene.h:545

namespace UnrealEngine
{
	public  partial class FWeightedBlendables : NativeStructWrapper
	{
		internal FWeightedBlendables(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FWeightedBlendables() :
			base(E_CreateStruct_FWeightedBlendables(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWeightedBlendables();
		
		#endregion
		
		public static implicit operator IntPtr(FWeightedBlendables Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FWeightedBlendables(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWeightedBlendables(Adress, false);
		}}}
