using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UDrawFrustumComponent : UPrimitiveComponent
	{
		public UDrawFrustumComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UDrawFrustumComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDrawFrustumComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UDrawFrustumComponent ?? new UDrawFrustumComponent(Adress);
		}}}
