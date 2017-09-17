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

		public ASpectatorPawn(UObject Parent = null, string Name = "SpectatorPawn")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ASpectatorPawn(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_ASpectatorPawn(IntPtr Parent, string Name);
		
		#endregion
		
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
