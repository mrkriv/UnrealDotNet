// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\InputSettings.h:20

namespace UnrealEngine
{
	public  partial class UInputSettings : UObject
	{
		public UInputSettings(IntPtr Adress)
			: base(Adress)
		{
		}

		public UInputSettings(UObject Parent = null, string Name = "InputSettings")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UInputSettings(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInputSettings(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UInputSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator UInputSettings(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UInputSettings>(PtrDesc);
		}}}
