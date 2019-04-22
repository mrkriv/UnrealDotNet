// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LocalLightComponent.h:17

namespace UnrealEngine
{
	[ManageType("ManageLocalLightComponent")]
	public partial class ManageLocalLightComponent : ULocalLightComponent
	{
		public ManageLocalLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageLocalLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageLocalLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLocalLightComponent>(PtrDesc);
		}}}
