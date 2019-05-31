// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

namespace UnrealEngine
{
	[ManageType("ManageDecalComponent")]
	public partial class ManageDecalComponent : UDecalComponent
	{
		public ManageDecalComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageDecalComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageDecalComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageDecalComponent>(PtrDesc);
		}}}
