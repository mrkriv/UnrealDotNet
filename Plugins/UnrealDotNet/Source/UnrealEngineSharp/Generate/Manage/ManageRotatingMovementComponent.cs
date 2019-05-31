// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

namespace UnrealEngine
{
	[ManageType("ManageRotatingMovementComponent")]
	public partial class ManageRotatingMovementComponent : URotatingMovementComponent
	{
		public ManageRotatingMovementComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageRotatingMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageRotatingMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageRotatingMovementComponent>(PtrDesc);
		}}}
