using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class ULightmassPortalComponent : USceneComponent
	{
		public ULightmassPortalComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(ULightmassPortalComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULightmassPortalComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ULightmassPortalComponent ?? new ULightmassPortalComponent(Adress);
		}}}
