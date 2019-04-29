// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InputComponent.h:675

namespace UnrealEngine
{
	[ManageType("ManageInputComponent")]
	public partial class ManageInputComponent : UInputComponent
	{
		public ManageInputComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageInputComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageInputComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageInputComponent>(PtrDesc);
		}}}
