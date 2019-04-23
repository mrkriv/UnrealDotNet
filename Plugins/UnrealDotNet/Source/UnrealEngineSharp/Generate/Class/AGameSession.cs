// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameSession.h:27

namespace UnrealEngine
{
	public  partial class AGameSession : AInfo
	{
		public AGameSession(IntPtr Adress)
			: base(Adress)
		{
		}

		public AGameSession(UObject Parent = null, string Name = "GameSession")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AGameSession(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AGameSession(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(AGameSession self)
		{
			return self.NativePointer;
		}

		public static implicit operator AGameSession(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AGameSession>(PtrDesc);
		}}}
