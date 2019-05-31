// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpringArmComponent.h:19

namespace UnrealEngine
{
	[ManageType("ManageSpringArmComponent")]
	public partial class ManageSpringArmComponent : USpringArmComponent
	{
		public ManageSpringArmComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageSpringArmComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageSpringArmComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSpringArmComponent>(PtrDesc);
		}}}
