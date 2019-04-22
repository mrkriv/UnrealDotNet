// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:1034

namespace UnrealEngine
{
	public  partial class UEngineBaseTypes : UObject
	{
		public UEngineBaseTypes(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(UEngineBaseTypes self)
		{
			return self.NativePointer;
		}

		public static implicit operator UEngineBaseTypes(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngineBaseTypes>(PtrDesc);
		}}}
