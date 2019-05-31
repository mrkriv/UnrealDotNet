// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\CapsuleComponent.h:16

namespace UnrealEngine
{
	[ManageType("ManageCapsuleComponent")]
	public partial class ManageCapsuleComponent : UCapsuleComponent
	{
		public ManageCapsuleComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageCapsuleComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageCapsuleComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCapsuleComponent>(PtrDesc);
		}}}
