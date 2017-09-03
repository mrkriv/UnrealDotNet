using System;
using System.Runtime.InteropServices;

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

		public static implicit operator UEngineBaseTypes(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UEngineBaseTypes ?? new UEngineBaseTypes(Adress);
		}}}
