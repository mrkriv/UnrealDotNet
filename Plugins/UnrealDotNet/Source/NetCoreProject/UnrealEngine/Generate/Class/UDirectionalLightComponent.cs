using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UDirectionalLightComponent : ULightComponent
	{
		public UDirectionalLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UDirectionalLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDirectionalLightComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UDirectionalLightComponent ?? new UDirectionalLightComponent(Adress);
		}}}
