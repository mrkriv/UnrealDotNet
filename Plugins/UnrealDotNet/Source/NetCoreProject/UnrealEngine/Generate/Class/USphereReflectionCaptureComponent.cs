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

		public USphereReflectionCaptureComponent(UObject Parent = null, string Name = "SphereReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USphereReflectionCaptureComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_USphereReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
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
