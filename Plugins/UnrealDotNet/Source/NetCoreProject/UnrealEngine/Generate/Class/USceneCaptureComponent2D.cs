using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class USceneCaptureComponent2D : USceneCaptureComponent
	{
		public USceneCaptureComponent2D(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(USceneCaptureComponent2D Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent2D(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USceneCaptureComponent2D ?? new USceneCaptureComponent2D(Adress);
		}}}
