// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawn.h:16

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ASpectatorPawn(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ASpectatorPawn self)
		{
			return self.NativePointer;
		}

		public static implicit operator ASpectatorPawn(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ASpectatorPawn>(PtrDesc);
		}}}
