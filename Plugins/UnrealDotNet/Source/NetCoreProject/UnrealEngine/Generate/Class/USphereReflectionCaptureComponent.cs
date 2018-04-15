using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SphereReflectionCaptureComponent.h:13

namespace UnrealEngine
{
	public  partial class USphereReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public USphereReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USphereReflectionCaptureComponent(UObject Parent = null, string Name = "SphereReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USphereReflectionCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USphereReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USphereReflectionCaptureComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USphereReflectionCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USphereReflectionCaptureComponent>(PtrDesc);
		}}}
