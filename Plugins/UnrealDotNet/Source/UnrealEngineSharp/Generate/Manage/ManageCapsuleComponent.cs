// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\CapsuleComponent.h:16

namespace UnrealEngine
{
	[ManageType("ManageCapsuleComponent")]
	public partial class ManageCapsuleComponent : UCapsuleComponent
	{
		public ManageCapsuleComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageCapsuleComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageCapsuleComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCapsuleComponent>(PtrDesc);
		}}}
