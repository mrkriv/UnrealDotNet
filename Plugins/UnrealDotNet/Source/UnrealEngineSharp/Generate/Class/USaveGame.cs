// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\GameFramework\SaveGame.h:19

namespace UnrealEngine
{
	public  partial class USaveGame : UObject
	{
		public USaveGame(IntPtr Adress)
			: base(Adress)
		{
		}

		public USaveGame(UObject Parent = null, string Name = "SaveGame")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USaveGame(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USaveGame(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USaveGame self)
		{
			return self.NativePointer;
		}

		public static implicit operator USaveGame(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USaveGame>(PtrDesc);
		}}}
