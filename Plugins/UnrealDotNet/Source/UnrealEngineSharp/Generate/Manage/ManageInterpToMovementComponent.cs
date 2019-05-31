// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InterpToMovementComponent.h:61

namespace UnrealEngine
{
	[ManageType("ManageInterpToMovementComponent")]
	public partial class ManageInterpToMovementComponent : UInterpToMovementComponent
	{
		public ManageInterpToMovementComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageInterpToMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageInterpToMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageInterpToMovementComponent>(PtrDesc);
		}}}
