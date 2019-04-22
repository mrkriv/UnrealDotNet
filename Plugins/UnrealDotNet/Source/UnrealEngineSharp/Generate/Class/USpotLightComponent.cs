// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SpotLightComponent.h:16

namespace UnrealEngine
{
	public  partial class USpotLightComponent : UPointLightComponent
	{
		public USpotLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USpotLightComponent(UObject Parent = null, string Name = "SpotLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USpotLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USpotLightComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USpotLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USpotLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USpotLightComponent>(PtrDesc);
		}}}
