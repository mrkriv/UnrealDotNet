using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManagePointLightComponent
	/// <para>A light component which emits light from a single point equally in all directions. </para>
	/// </summary>
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
