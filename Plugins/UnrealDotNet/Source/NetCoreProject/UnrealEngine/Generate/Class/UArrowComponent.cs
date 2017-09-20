using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UArrowComponent : UPrimitiveComponent
	{
		public UArrowComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UArrowComponent(UObject Parent = null, string Name = "ArrowComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UArrowComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UArrowComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UArrowComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UArrowComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UArrowComponent ?? new UArrowComponent(Adress);
		}
}
}
