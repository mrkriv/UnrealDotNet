// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameState.h:16

namespace UnrealEngine
{
	[ManageType("ManageGameState")]
	public partial class ManageGameState : AGameState
	{
		public ManageGameState(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageGameState self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameState(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameState>(PtrDesc);
		}}}
