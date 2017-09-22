using System;
using System.Runtime.InteropServices;

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
