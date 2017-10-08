using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FScreenMessageString : NativeStructWrapper
	{
		internal FScreenMessageString(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FScreenMessageString() :
			base(E_CreateStruct_FScreenMessageString(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScreenMessageString();
		
		#endregion
		
		public static implicit operator IntPtr(FScreenMessageString Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FScreenMessageString(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScreenMessageString(Adress, false);
		}}}
