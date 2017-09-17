using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UScene : UObject
	{
		public UScene(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(UScene Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UScene(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UScene ?? new UScene(Adress);
		}}}
