using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\LocalLightComponent.h:17

namespace UnrealEngine
{
	public partial class ManageLocalLightComponent : ULocalLightComponent
	{
		public ManageLocalLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageLocalLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageLocalLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLocalLightComponent>(PtrDesc);
		}}}
