using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FAsyncPreRegisterDDCRequest : NativeWrapper
	{
		public FAsyncPreRegisterDDCRequest(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(FAsyncPreRegisterDDCRequest Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAsyncPreRegisterDDCRequest(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as FAsyncPreRegisterDDCRequest ?? new FAsyncPreRegisterDDCRequest(Adress);
		}}}
