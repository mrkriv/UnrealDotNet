using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class ULineBatchComponent : UPrimitiveComponent
	{
		public ULineBatchComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(ULineBatchComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULineBatchComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ULineBatchComponent ?? new ULineBatchComponent(Adress);
		}}}
