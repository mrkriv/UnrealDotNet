using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\Components\MaterialBillboardComponent.h:61

namespace UnrealEngine
{
	public partial class ManageMaterialBillboardComponent : UMaterialBillboardComponent
	{
		public ManageMaterialBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageMaterialBillboardComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageMaterialBillboardComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageMaterialBillboardComponent>(PtrDesc);
		}}}
