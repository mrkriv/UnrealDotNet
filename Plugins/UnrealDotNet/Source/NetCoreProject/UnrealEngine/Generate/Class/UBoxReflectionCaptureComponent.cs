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

		public UBoxReflectionCaptureComponent(UObject Parent = null, string Name = "BoxReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBoxReflectionCaptureComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UBoxReflectionCaptureComponent(IntPtr Parent, string Name);
		
		#endregion
		
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
