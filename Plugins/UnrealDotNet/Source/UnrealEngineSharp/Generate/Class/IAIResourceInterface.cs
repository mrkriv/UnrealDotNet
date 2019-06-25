// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AIResourceInterface.h:17

namespace UnrealEngine
{
	public partial class IAIResourceInterface : NativeWrapper
	{
		public IAIResourceInterface(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(IAIResourceInterface self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator IAIResourceInterface(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<IAIResourceInterface>(PtrDesc);
		}}}
