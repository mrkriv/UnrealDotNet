using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FAsyncPreRegisterDDCRequest
	{
		protected readonly IntPtr NativePointer;
		
		public FAsyncPreRegisterDDCRequest(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		public static implicit operator IntPtr(FAsyncPreRegisterDDCRequest Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAsyncPreRegisterDDCRequest(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAsyncPreRegisterDDCRequest(Adress);
		}}}
