// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\AudioComponent.h:110

namespace UnrealEngine
{
	[ManageType("ManageAudioComponent")]
	public partial class ManageAudioComponent : UAudioComponent
	{
		public ManageAudioComponent(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageAudioComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageAudioComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageAudioComponent>(PtrDesc);
		}}}
