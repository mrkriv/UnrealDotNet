using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageDirectionalLightComponent
	/// <para>A light component that has parallel rays. Will provide a uniform lighting across any affected surface (eg. The Sun). This will affect all objects in the defined light-mass importance volume. </para>
	/// </summary>
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
