using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ULightmassPortalComponent : USceneComponent
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
			return Adress == IntPtr.Zero ? null : new ULightmassPortalComponent(Adress);
		}}}
