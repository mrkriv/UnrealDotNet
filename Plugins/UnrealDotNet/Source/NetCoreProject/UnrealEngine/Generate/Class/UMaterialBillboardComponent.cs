using System;
using System.Runtime.InteropServices;

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
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UMaterialBillboardComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UMaterialBillboardComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UMaterialBillboardComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UMaterialBillboardComponent ?? new UMaterialBillboardComponent(Adress);
		}}}
