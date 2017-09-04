using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPointLightComponent : ULightComponent
	{
		public UPointLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UPointLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPointLightComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UPointLightComponent ?? new UPointLightComponent(Adress);
		}}}
