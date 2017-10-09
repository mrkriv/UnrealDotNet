using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\ChildActorComponent.h:44

namespace UnrealEngine
{
	public partial class ManageChildActorComponent : UChildActorComponent
	{
		public ManageChildActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageChildActorComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageChildActorComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageChildActorComponent>(PtrDesc);
		}}}
