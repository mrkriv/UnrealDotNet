using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class ULightComponentBase : USceneComponent
	{
		public ULightComponentBase(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(ULightComponentBase Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULightComponentBase(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ULightComponentBase ?? new ULightComponentBase(Adress);
		}}}
