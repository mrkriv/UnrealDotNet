using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PointLightComponent.h:18

namespace UnrealEngine
{
	public  partial class UPointLightComponent : ULightComponent
	{
		public UPointLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPointLightComponent(UObject Parent = null, string Name = "PointLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPointLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPointLightComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UPointLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPointLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPointLightComponent>(PtrDesc);
		}}}
