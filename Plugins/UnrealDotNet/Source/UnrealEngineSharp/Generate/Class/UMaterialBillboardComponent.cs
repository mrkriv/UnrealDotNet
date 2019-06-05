// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\MaterialBillboardComponent.h:61

namespace UnrealEngine
{
	public partial class UMaterialBillboardComponent : UPrimitiveComponent
	{
		public UMaterialBillboardComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UMaterialBillboardComponent(UObject Parent = null, string Name = "MaterialBillboardComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UMaterialBillboardComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UMaterialBillboardComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UMaterialBillboardComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UMaterialBillboardComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UMaterialBillboardComponent>(PtrDesc);
		}}}
