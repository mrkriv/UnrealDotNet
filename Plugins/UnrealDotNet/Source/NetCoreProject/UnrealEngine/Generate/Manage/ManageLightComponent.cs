using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\LightComponent.h:40

namespace UnrealEngine
{
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
