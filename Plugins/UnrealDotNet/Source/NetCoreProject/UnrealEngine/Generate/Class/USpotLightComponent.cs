using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A spot light component emits a directional cone shaped light (Eg a Torch).
	/// </summary>
	public partial class USpotLightComponent : UPointLightComponent
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
			return Adress == IntPtr.Zero ? null : new USpotLightComponent(Adress);
		}}}
