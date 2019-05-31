// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameStateBase.h:29

namespace UnrealEngine
{
	[ManageType("ManageGameStateBase")]
	public partial class ManageGameStateBase : AGameStateBase
	{
		public ManageGameStateBase(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageGameStateBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameStateBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameStateBase>(PtrDesc);
		}}}
