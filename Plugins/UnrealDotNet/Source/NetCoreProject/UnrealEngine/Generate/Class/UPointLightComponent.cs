using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A light component which emits light from a single point equally in all directions.
	/// </summary>
	public partial class UPointLightComponent : ULightComponent
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
			return Adress == IntPtr.Zero ? null : new UPointLightComponent(Adress);
		}}}
