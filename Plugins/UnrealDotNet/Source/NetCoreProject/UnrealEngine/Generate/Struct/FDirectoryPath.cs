using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FDirectoryPath : NativeStructWrapper
	{
		internal FDirectoryPath(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FDirectoryPath() :
			base(E_CreateStruct_FDirectoryPath(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDirectoryPath();
		
		#endregion
		
		public static implicit operator IntPtr(FDirectoryPath Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDirectoryPath(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDirectoryPath(Adress, false);
		}}}
