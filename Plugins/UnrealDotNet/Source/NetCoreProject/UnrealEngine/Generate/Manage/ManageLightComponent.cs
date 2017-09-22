using System;
using System.Runtime.InteropServices;

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
