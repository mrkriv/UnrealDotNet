// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

namespace UnrealEngine
{
	[ManageType("ManageCheatManager")]
	public partial class ManageCheatManager : UCheatManager
	{
		public ManageCheatManager(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageCheatManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageCheatManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCheatManager>(PtrDesc);
		}}}
