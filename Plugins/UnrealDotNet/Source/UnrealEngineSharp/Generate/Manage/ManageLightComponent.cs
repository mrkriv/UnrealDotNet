// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightComponent.h:40

namespace UnrealEngine
{
	[ManageType("ManageLightComponent")]
	public partial class ManageLightComponent : ULightComponent
	{
		public ManageLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageLightComponent>(PtrDesc);
		}}}
