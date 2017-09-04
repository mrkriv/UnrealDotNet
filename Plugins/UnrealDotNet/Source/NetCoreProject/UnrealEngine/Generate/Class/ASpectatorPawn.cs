using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class ASpectatorPawn : ADefaultPawn
	{
		public ASpectatorPawn(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(ASpectatorPawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ASpectatorPawn(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ASpectatorPawn ?? new ASpectatorPawn(Adress);
		}}}
