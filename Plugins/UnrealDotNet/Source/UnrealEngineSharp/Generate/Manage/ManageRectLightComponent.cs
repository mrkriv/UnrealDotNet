// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\RectLightComponent.h:18

namespace UnrealEngine
{
	[ManageType("ManageRectLightComponent")]
	public partial class ManageRectLightComponent : URectLightComponent
	{
		public ManageRectLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageRectLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageRectLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageRectLightComponent>(PtrDesc);
		}}}
