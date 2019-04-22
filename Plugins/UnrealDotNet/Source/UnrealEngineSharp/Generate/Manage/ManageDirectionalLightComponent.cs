// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DirectionalLightComponent.h:18

namespace UnrealEngine
{
	[ManageType("ManageDirectionalLightComponent")]
	public partial class ManageDirectionalLightComponent : UDirectionalLightComponent
	{
		public ManageDirectionalLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageDirectionalLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageDirectionalLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDirectionalLightComponent>(PtrDesc);
		}}}
