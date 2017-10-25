using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\MaterialBillboardComponent.h:61

namespace UnrealEngine
{
	public  partial class UMaterialBillboardComponent : UPrimitiveComponent
	{
		public UMaterialBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UMaterialBillboardComponent(UObject Parent = null, string Name = "MaterialBillboardComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UMaterialBillboardComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UMaterialBillboardComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UMaterialBillboardComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UMaterialBillboardComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UMaterialBillboardComponent>(PtrDesc);
		}}}
