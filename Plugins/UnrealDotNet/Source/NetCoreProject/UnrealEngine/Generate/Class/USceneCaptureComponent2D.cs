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

		public USceneCaptureComponent2D(UObject Parent = null, string Name = "SceneCaptureComponent2D")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneCaptureComponent2D(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneCaptureComponent2D(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponent2D Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent2D(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USceneCaptureComponent2D ?? new USceneCaptureComponent2D(Adress);
		}
}
}
