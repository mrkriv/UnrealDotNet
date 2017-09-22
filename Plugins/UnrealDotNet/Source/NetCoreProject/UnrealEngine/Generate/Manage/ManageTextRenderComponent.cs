using System;
using System.Runtime.InteropServices;

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
