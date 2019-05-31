// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameUserSettings.h:38

namespace UnrealEngine
{
	[ManageType("ManageGameUserSettings")]
	public partial class ManageGameUserSettings : UGameUserSettings
	{
		public ManageGameUserSettings(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageGameUserSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameUserSettings(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameUserSettings>(PtrDesc);
		}}}
