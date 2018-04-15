using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\PostProcessComponent.h:21

namespace UnrealEngine
{
	public  partial class UPostProcessComponent : USceneComponent
	{
		public UPostProcessComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPostProcessComponent(UObject Parent = null, string Name = "PostProcessComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPostProcessComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPostProcessComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UPostProcessComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPostProcessComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPostProcessComponent>(PtrDesc);
		}}}
