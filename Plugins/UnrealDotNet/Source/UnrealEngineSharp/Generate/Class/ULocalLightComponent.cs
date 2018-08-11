using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\LocalLightComponent.h:17

namespace UnrealEngine
{
	public  partial class ULocalLightComponent : ULightComponent
	{
		public ULocalLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public ULocalLightComponent(UObject Parent = null, string Name = "LocalLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULocalLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULocalLightComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ULocalLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULocalLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULocalLightComponent>(PtrDesc);
		}}}
