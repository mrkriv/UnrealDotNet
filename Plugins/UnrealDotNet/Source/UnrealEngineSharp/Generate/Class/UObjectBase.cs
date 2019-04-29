// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\CoreUObject\Public\UObject\UObjectBase.h:20

namespace UnrealEngine
{
	public  partial class UObjectBase : NativeWrapper
	{
		public UObjectBase(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(UObjectBase self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UObjectBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UObjectBase>(PtrDesc);
		}}}
