using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FMaterialSpriteElement : NativeStructWrapper
	{
		internal FMaterialSpriteElement(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FMaterialSpriteElement() :
			base(E_CreateStruct_FMaterialSpriteElement(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMaterialSpriteElement();
		
		#endregion
		
		public static implicit operator IntPtr(FMaterialSpriteElement Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FMaterialSpriteElement(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FMaterialSpriteElement(Adress, false);
		}}}
