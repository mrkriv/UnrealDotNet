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
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ASpectatorPawn(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ASpectatorPawn Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ASpectatorPawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ASpectatorPawn>(PtrDesc);
		}}}
