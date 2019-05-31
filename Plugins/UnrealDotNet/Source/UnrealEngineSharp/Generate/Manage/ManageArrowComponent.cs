// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ArrowComponent.h:19

namespace UnrealEngine
{
	[ManageType("ManageArrowComponent")]
	public partial class ManageArrowComponent : UArrowComponent
	{
		public ManageArrowComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageArrowComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageArrowComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageArrowComponent>(PtrDesc);
		}}}
