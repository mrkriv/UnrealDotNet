// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerInput.h:270

namespace UnrealEngine
{
	[ManageType("ManagePlayerInput")]
	public partial class ManagePlayerInput : UPlayerInput
	{
		public ManagePlayerInput(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManagePlayerInput self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManagePlayerInput(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayerInput>(PtrDesc);
		}}}
