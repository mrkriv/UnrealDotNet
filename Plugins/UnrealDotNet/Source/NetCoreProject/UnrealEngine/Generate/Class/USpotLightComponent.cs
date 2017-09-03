using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageSpotLightComponent
	/// <para>A spot light component emits a directional cone shaped light (Eg a Torch). </para>
	/// </summary>
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
