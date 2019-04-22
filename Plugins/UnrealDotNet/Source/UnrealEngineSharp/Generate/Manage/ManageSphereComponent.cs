// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SphereComponent.h:17

namespace UnrealEngine
{
	[ManageType("ManageSphereComponent")]
	public partial class ManageSphereComponent : USphereComponent
	{
		public ManageSphereComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSphereComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSphereComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSphereComponent>(PtrDesc);
		}}}
