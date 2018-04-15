using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\BoxComponent.h:17

namespace UnrealEngine
{
	public partial class ManageBoxComponent : UBoxComponent
	{
		public ManageBoxComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageBoxComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageBoxComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageBoxComponent>(PtrDesc);
		}}}
