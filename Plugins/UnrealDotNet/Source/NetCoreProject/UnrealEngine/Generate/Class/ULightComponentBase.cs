using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class ULightComponentBase : USceneComponent
	{
		public ULightComponentBase(IntPtr Adress)
			: base(Adress)
		{
		}

		public ULightComponentBase(UObject Parent = null, string Name = "LightComponentBase")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULightComponentBase(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULightComponentBase(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ULightComponentBase Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULightComponentBase(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ULightComponentBase ?? new ULightComponentBase(Adress);
		}
}
}
