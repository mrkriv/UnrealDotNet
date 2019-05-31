// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameMode.h:35

namespace UnrealEngine
{
	[ManageType("ManageGameMode")]
	public partial class ManageGameMode : AGameMode
	{
		public ManageGameMode(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageGameMode self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameMode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameMode>(PtrDesc);
		}}}
