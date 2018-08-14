using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\ChildActorComponent.h:44

namespace UnrealEngine
{
	[ManageType("ManageChildActorComponent")]
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
