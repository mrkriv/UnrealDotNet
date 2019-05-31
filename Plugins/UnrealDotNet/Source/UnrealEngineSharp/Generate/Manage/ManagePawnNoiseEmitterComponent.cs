// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PawnNoiseEmitterComponent.h:19

namespace UnrealEngine
{
	[ManageType("ManagePawnNoiseEmitterComponent")]
	public partial class ManagePawnNoiseEmitterComponent : UPawnNoiseEmitterComponent
	{
		public ManagePawnNoiseEmitterComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManagePawnNoiseEmitterComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManagePawnNoiseEmitterComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePawnNoiseEmitterComponent>(PtrDesc);
		}}}
