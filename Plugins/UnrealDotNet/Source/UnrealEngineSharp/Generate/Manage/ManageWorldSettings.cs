// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:395

namespace UnrealEngine
{
	[ManageType("ManageWorldSettings")]
	public partial class ManageWorldSettings : AWorldSettings
	{
		public ManageWorldSettings(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageWorldSettings self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageWorldSettings(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageWorldSettings>(PtrDesc);
		}}}
