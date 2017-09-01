using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class USphereReflectionCaptureComponent : UReflectionCaptureComponent
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
			return Adress == IntPtr.Zero ? null : new USphereReflectionCaptureComponent(Adress);
		}}}
