using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UDrawSphereComponent : USphereComponent
	{
		public UDrawSphereComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UDrawSphereComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDrawSphereComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UDrawSphereComponent ?? new UDrawSphereComponent(Adress);
		}}}
