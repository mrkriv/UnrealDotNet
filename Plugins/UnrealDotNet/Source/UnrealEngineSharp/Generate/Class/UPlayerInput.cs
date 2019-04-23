// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerInput.h:270

namespace UnrealEngine
{
	public  partial class UPlayerInput : UObject
	{
		public UPlayerInput(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPlayerInput(UObject Parent = null, string Name = "PlayerInput")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPlayerInput(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPlayerInput(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UPlayerInput self)
		{
			return self.NativePointer;
		}

		public static implicit operator UPlayerInput(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPlayerInput>(PtrDesc);
		}}}
