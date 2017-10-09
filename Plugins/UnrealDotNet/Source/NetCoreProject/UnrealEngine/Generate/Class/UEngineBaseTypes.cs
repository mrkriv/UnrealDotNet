using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Engine\EngineBaseTypes.h:1000

namespace UnrealEngine
{
	public  partial class UEngineBaseTypes : UObject
	{
		public UEngineBaseTypes(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(UEngineBaseTypes Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UEngineBaseTypes(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngineBaseTypes>(PtrDesc);
		}}}
