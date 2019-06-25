// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\CrowdAgentInterface.h:17

namespace UnrealEngine
{
	public partial class ICrowdAgentInterface : NativeWrapper
	{
		public ICrowdAgentInterface(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(ICrowdAgentInterface self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ICrowdAgentInterface(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ICrowdAgentInterface>(PtrDesc);
		}}}
