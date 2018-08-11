using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SpotLightComponent.h:16

namespace UnrealEngine
{
	public partial class ManageSpotLightComponent : USpotLightComponent
	{
		public ManageSpotLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSpotLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSpotLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSpotLightComponent>(PtrDesc);
		}}}
