// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\HUD.h:36

namespace UnrealEngine
{
	[ManageType("ManageHUD")]
	public partial class ManageHUD : AHUD
	{
		public ManageHUD(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageHUD self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageHUD(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageHUD>(PtrDesc);
		}}}
