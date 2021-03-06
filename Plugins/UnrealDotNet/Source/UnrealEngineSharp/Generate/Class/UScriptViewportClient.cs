// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\ScriptViewportClient.h:17

namespace UnrealEngine
{
	public partial class UScriptViewportClient : UObject
	{
		public UScriptViewportClient(IntPtr adress)
			: base(adress)
		{
		}

		public static implicit operator IntPtr(UScriptViewportClient self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UScriptViewportClient(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UScriptViewportClient>(PtrDesc);
		}}}
