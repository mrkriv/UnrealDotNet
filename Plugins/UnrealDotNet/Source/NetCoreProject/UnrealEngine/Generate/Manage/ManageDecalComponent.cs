using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

namespace UnrealEngine
{
	public partial class ManageDecalComponent : UDecalComponent
	{
		public ManageDecalComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageDecalComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageDecalComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDecalComponent>(PtrDesc);
		}}}
