// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PointLightComponent.h:18

namespace UnrealEngine
{
	[ManageType("ManagePointLightComponent")]
	public partial class ManagePointLightComponent : UPointLightComponent
	{
		public ManagePointLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManagePointLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManagePointLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePointLightComponent>(PtrDesc);
		}}}
