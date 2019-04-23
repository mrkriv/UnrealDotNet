// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameNetworkManager.h:27

namespace UnrealEngine
{
	public  partial class AGameNetworkManager : AInfo
	{
		public AGameNetworkManager(IntPtr Adress)
			: base(Adress)
		{
		}

		public AGameNetworkManager(UObject Parent = null, string Name = "GameNetworkManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AGameNetworkManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AGameNetworkManager(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(AGameNetworkManager self)
		{
			return self.NativePointer;
		}

		public static implicit operator AGameNetworkManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AGameNetworkManager>(PtrDesc);
		}}}
