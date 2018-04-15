using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\ArrowComponent.h:19

namespace UnrealEngine
{
	public  partial class UArrowComponent : UPrimitiveComponent
	{
		public UArrowComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UArrowComponent(UObject Parent = null, string Name = "ArrowComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UArrowComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UArrowComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UArrowComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UArrowComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UArrowComponent>(PtrDesc);
		}}}
