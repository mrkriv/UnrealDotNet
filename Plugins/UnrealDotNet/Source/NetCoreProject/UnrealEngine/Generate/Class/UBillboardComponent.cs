using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UBillboardComponent : UPrimitiveComponent
	{
		public UBillboardComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UBillboardComponent(UObject Parent = null, string Name = "BillboardComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBillboardComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UBillboardComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBillboardComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UBillboardComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UBillboardComponent ?? new UBillboardComponent(Adress);
		}}}
