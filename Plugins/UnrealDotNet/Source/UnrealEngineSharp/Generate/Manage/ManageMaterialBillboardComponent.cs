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
	[ManageType("ManageMaterialBillboardComponent")]
	public partial class ManageMaterialBillboardComponent : UMaterialBillboardComponent
	{
		public ManageMaterialBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageMaterialBillboardComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator ManageMaterialBillboardComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageMaterialBillboardComponent>(PtrDesc);
		}}}
