// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameSession.h:27

namespace UnrealEngine
{
	[ManageType("ManageGameSession")]
	public partial class ManageGameSession : AGameSession
	{
		public ManageGameSession(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ManageGameSession self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageGameSession(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameSession>(PtrDesc);
		}}}
