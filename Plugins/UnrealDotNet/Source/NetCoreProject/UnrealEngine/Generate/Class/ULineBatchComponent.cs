using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class ULineBatchComponent : UPrimitiveComponent
	{
		public ULineBatchComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public ULineBatchComponent(UObject Parent = null, string Name = "LineBatchComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_ULineBatchComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_ULineBatchComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(ULineBatchComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ULineBatchComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as ULineBatchComponent ?? new ULineBatchComponent(Adress);
		}
}
}
