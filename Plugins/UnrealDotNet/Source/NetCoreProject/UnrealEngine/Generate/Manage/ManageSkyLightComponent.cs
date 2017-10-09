using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\SkyLightComponent.h:99

namespace UnrealEngine
{
	public partial class ManageSkyLightComponent : USkyLightComponent
	{
		public ManageSkyLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSkyLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSkyLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSkyLightComponent>(PtrDesc);
		}}}
