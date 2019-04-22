// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\LightComponentBase.h:14

namespace UnrealEngine
{
	public  partial class ULightComponentBase : USceneComponent
	{
		public ULightComponentBase(IntPtr Adress)
			: base(Adress)
		{
		}

		public ULightComponentBase(UObject Parent = null, string Name = "LightComponentBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULightComponentBase(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULightComponentBase(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ULightComponentBase self)
		{
			return self.NativePointer;
		}

		public static implicit operator ULightComponentBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULightComponentBase>(PtrDesc);
		}}}
