using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPostProcessComponent : USceneComponent
	{
		public UPostProcessComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UPostProcessComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPostProcessComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UPostProcessComponent ?? new UPostProcessComponent(Adress);
		}}}
