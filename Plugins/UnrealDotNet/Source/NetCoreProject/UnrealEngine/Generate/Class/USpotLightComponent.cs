using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SpotLightComponent.h:16

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
		
		public static implicit operator IntPtr(USpotLightComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USpotLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USpotLightComponent>(PtrDesc);
		}}}
