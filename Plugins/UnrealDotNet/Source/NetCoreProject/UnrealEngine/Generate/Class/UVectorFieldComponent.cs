using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UVectorFieldComponent : UPrimitiveComponent
	{
		public UVectorFieldComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UVectorFieldComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UVectorFieldComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UVectorFieldComponent ?? new UVectorFieldComponent(Adress);
		}}}
