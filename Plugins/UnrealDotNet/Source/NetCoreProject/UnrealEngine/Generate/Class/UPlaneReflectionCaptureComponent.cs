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

		public UPlaneReflectionCaptureComponent(UObject Parent = null, string Name = "PlaneReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPlaneReflectionCaptureComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UPlaneReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
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
