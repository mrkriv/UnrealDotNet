using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USaveGame : UObject
	{
		public USaveGame(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(USaveGame Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USaveGame(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USaveGame ?? new USaveGame(Adress);
		}}}
