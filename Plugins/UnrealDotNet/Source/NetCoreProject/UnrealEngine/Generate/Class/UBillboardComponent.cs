using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UBillboardComponent : UPrimitiveComponent
	{
		public UBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UBillboardComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UBillboardComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UBillboardComponent ?? new UBillboardComponent(Adress);
		}}}
