using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\VectorFieldComponent.h:18

namespace UnrealEngine
{
	public  partial class UVectorFieldComponent : UPrimitiveComponent
	{
		public UVectorFieldComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UVectorFieldComponent(UObject Parent = null, string Name = "VectorFieldComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UVectorFieldComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UVectorFieldComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UVectorFieldComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UVectorFieldComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UVectorFieldComponent>(PtrDesc);
		}}}
