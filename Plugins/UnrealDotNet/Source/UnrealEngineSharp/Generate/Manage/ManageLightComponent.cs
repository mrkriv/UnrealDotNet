using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\LightComponent.h:40

namespace UnrealEngine
{
	[ManageType("ManageLightComponent")]
	public partial class ManageLightComponent : ULightComponent
	{
		public ManageLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLightComponent>(PtrDesc);
		}}}
