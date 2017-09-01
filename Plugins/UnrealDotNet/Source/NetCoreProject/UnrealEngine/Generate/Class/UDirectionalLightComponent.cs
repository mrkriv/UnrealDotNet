using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A light component that has parallel rays. Will provide a uniform lighting across any affected surface (eg. The Sun). This will affect all objects in the defined light-mass importance volume.
	/// </summary>
	public partial class UDirectionalLightComponent : ULightComponent
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
			return Adress == IntPtr.Zero ? null : new UDirectionalLightComponent(Adress);
		}}}
