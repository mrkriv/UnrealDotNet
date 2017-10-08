using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FFilePath : NativeStructWrapper
	{
		internal FFilePath(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFilePath() :
			base(E_CreateStruct_FFilePath(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFilePath();
		
		#endregion
		
		public static implicit operator IntPtr(FFilePath Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFilePath(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFilePath(Adress, false);
		}}}
