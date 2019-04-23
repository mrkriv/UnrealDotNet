// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\SpectatorPawnMovement.h:15

namespace UnrealEngine
{
	public  partial class USpectatorPawnMovement : UFloatingPawnMovement
	{
		public USpectatorPawnMovement(IntPtr Adress)
			: base(Adress)
		{
		}

		public USpectatorPawnMovement(UObject Parent = null, string Name = "SpectatorPawnMovement")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USpectatorPawnMovement(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USpectatorPawnMovement(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USpectatorPawnMovement self)
		{
			return self.NativePointer;
		}

		public static implicit operator USpectatorPawnMovement(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USpectatorPawnMovement>(PtrDesc);
		}}}
