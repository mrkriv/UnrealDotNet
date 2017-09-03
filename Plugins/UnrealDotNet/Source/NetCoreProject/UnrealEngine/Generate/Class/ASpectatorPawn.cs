using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageSpectatorPawn
	/// <para>SpectatorPawns are simple pawns that can fly around the world, used by </para>
	/// <para>PlayerControllers when in the spectator state. </para>
	/// </summary>
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
