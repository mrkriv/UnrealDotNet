// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\TextRenderComponent.h:44

namespace UnrealEngine
{
	public  partial class UTextRenderComponent : UPrimitiveComponent
	{
		public UTextRenderComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UTextRenderComponent(UObject Parent = null, string Name = "TextRenderComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UTextRenderComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UTextRenderComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UTextRenderComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UTextRenderComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UTextRenderComponent>(PtrDesc);
		}}}
