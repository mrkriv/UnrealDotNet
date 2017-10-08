using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FFullyLoadedPackagesInfo : NativeStructWrapper
	{
		internal FFullyLoadedPackagesInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FFullyLoadedPackagesInfo() :
			base(E_CreateStruct_FFullyLoadedPackagesInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFullyLoadedPackagesInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FFullyLoadedPackagesInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFullyLoadedPackagesInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFullyLoadedPackagesInfo(Adress, false);
		}}}
