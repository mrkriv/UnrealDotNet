using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Components\LightmassPortalComponent.h:12

namespace UnrealEngine
{
	public  partial class ULightmassPortalComponent : USceneComponent
	{
		public ULightmassPortalComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public ULightmassPortalComponent(UObject Parent = null, string Name = "LightmassPortalComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULightmassPortalComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULightmassPortalComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ULightmassPortalComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULightmassPortalComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ULightmassPortalComponent>(PtrDesc);
		}}}
