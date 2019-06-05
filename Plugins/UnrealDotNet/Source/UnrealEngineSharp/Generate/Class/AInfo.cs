// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\Info.h:20

namespace UnrealEngine
{
	public partial class AInfo : AActor
	{
		public AInfo(IntPtr adress)
			: base(adress)
		{
		}

		public AInfo(UObject Parent = null, string Name = "Info")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_AInfo(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_AInfo(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(AInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator AInfo(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<AInfo>(PtrDesc);
		}}}
