using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USpotLightComponent : UPointLightComponent
	{
		public USpotLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(USpotLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USpotLightComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USpotLightComponent ?? new USpotLightComponent(Adress);
		}}}
