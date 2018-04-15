using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\TextRenderComponent.h:44

namespace UnrealEngine
{
	public partial class ManageTextRenderComponent : UTextRenderComponent
	{
		public ManageTextRenderComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageTextRenderComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageTextRenderComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageTextRenderComponent>(PtrDesc);
		}}}
