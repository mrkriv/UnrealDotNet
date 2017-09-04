using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UMaterialBillboardComponent : UPrimitiveComponent
	{
		public UMaterialBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UMaterialBillboardComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UMaterialBillboardComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UMaterialBillboardComponent ?? new UMaterialBillboardComponent(Adress);
		}}}
