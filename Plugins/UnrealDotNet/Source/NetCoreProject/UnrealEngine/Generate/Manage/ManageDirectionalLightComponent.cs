using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\DirectionalLightComponent.h:18

namespace UnrealEngine
{
	public partial class ManageDirectionalLightComponent : UDirectionalLightComponent
	{
		public ManageDirectionalLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageDirectionalLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageDirectionalLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDirectionalLightComponent>(PtrDesc);
		}}}
