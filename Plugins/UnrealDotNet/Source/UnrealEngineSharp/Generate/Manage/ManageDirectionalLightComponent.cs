// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DirectionalLightComponent.h:18

namespace UnrealEngine
{
	[ManageType("ManageDirectionalLightComponent")]
	public partial class ManageDirectionalLightComponent : UDirectionalLightComponent
	{
		public ManageDirectionalLightComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageDirectionalLightComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageDirectionalLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDirectionalLightComponent>(PtrDesc);
		}}}
