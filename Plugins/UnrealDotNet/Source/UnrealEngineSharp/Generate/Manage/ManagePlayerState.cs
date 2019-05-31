// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:64

namespace UnrealEngine
{
	[ManageType("ManagePlayerState")]
	public partial class ManagePlayerState : APlayerState
	{
		public ManagePlayerState(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManagePlayerState self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManagePlayerState(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayerState>(PtrDesc);
		}}}
