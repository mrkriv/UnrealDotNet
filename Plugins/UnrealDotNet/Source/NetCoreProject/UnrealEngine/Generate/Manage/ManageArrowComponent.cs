using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\ArrowComponent.h:19

namespace UnrealEngine
{
	public partial class ManageArrowComponent : UArrowComponent
	{
		public ManageArrowComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageArrowComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageArrowComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageArrowComponent>(PtrDesc);
		}}}
