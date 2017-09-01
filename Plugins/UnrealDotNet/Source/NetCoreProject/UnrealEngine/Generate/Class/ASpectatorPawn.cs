using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// SpectatorPawns are simple pawns that can fly around the world, used by
	/// PlayerControllers when in the spectator state.
	/// </summary>
	public partial class ASpectatorPawn : ADefaultPawn
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
			return Adress == IntPtr.Zero ? null : new ASpectatorPawn(Adress);
		}}}
