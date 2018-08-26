// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\RectLightComponent.h:18

namespace UnrealEngine
{
	public  partial class URectLightComponent : ULocalLightComponent
	{
		public URectLightComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public URectLightComponent(UObject Parent = null, string Name = "RectLightComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_URectLightComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_URectLightComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(URectLightComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator URectLightComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<URectLightComponent>(PtrDesc);
		}}}
