// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SpotLightComponent.h:16

namespace UnrealEngine
{
	[ManageType("ManageSpotLightComponent")]
	public partial class ManageSpotLightComponent : USpotLightComponent
	{
		public ManageSpotLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSpotLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSpotLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSpotLightComponent>(PtrDesc);
		}}}
