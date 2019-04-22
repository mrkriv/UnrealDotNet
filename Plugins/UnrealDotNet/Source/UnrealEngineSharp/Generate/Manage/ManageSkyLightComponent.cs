// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkyLightComponent.h:96

namespace UnrealEngine
{
	[ManageType("ManageSkyLightComponent")]
	public partial class ManageSkyLightComponent : USkyLightComponent
	{
		public ManageSkyLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSkyLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSkyLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSkyLightComponent>(PtrDesc);
		}}}
