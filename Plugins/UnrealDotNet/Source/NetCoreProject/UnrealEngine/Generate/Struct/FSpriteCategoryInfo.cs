using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSpriteCategoryInfo : NativeStructWrapper
	{
		internal FSpriteCategoryInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSpriteCategoryInfo() :
			base(E_CreateStruct_FSpriteCategoryInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSpriteCategoryInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FSpriteCategoryInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSpriteCategoryInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSpriteCategoryInfo(Adress, false);
		}}}
