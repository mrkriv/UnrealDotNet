using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UTextRenderComponent : UPrimitiveComponent
	{
		public UTextRenderComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UTextRenderComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UTextRenderComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UTextRenderComponent ?? new UTextRenderComponent(Adress);
		}}}
