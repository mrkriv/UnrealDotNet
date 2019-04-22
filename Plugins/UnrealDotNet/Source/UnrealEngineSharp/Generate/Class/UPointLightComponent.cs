// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PointLightComponent.h:18

namespace UnrealEngine
{
	public  partial class UPointLightComponent : ULocalLightComponent
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
		
		public static implicit operator IntPtr(UPointLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UPointLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPointLightComponent>(PtrDesc);
		}}}
