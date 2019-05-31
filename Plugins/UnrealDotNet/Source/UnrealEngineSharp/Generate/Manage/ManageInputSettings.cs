// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\InputSettings.h:20

namespace UnrealEngine
{
	[ManageType("ManageInputSettings")]
	public partial class ManageInputSettings : UInputSettings
	{
		public ManageInputSettings(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageInputSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageInputSettings(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageInputSettings>(PtrDesc);
		}}}
