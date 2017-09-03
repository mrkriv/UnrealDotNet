using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UBoxReflectionCaptureComponent : UReflectionCaptureComponent
	{
		public UBoxReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(UBoxReflectionCaptureComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UBoxReflectionCaptureComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UBoxReflectionCaptureComponent ?? new UBoxReflectionCaptureComponent(Adress);
		}}}
