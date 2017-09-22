using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class ManagePointLightComponent : UPointLightComponent
	{
		public ManagePointLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManagePointLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManagePointLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePointLightComponent>(PtrDesc);
		}}}
