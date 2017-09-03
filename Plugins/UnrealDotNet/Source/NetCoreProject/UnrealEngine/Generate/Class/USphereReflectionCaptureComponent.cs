using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USphereReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public USphereReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(USphereReflectionCaptureComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USphereReflectionCaptureComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USphereReflectionCaptureComponent ?? new USphereReflectionCaptureComponent(Adress);
		}}}
