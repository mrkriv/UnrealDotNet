using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\CoreUObject\Public\UObject\UObjectBase.h:17

namespace UnrealEngine
{
	public  partial class UObjectBase : NativeWrapper
	{
		public UObjectBase(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(UObjectBase Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObjectBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UObjectBase>(PtrDesc);
		}}}
