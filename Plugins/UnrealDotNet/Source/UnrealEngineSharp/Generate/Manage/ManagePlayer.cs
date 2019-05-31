// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

namespace UnrealEngine
{
	[ManageType("ManagePlayer")]
	public partial class ManagePlayer : UPlayer
	{
		public ManagePlayer(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManagePlayer self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManagePlayer(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayer>(PtrDesc);
		}}}
