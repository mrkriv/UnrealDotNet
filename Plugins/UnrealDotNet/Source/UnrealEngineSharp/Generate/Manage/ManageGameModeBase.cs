// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameModeBase.h:46

namespace UnrealEngine
{
	[ManageType("ManageGameModeBase")]
	public partial class ManageGameModeBase : AGameModeBase
	{
		public ManageGameModeBase(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageGameModeBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameModeBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameModeBase>(PtrDesc);
		}}}
