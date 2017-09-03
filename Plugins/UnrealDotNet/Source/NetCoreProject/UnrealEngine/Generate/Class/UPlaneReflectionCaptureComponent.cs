using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPlaneReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public UPlaneReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UPlaneReflectionCaptureComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPlaneReflectionCaptureComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UPlaneReflectionCaptureComponent ?? new UPlaneReflectionCaptureComponent(Adress);
		}}}
