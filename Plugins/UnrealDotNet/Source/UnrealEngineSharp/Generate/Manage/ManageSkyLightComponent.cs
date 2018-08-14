using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkyLightComponent.h:92

namespace UnrealEngine
{
	[ManageType("ManageSkyLightComponent")]
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
