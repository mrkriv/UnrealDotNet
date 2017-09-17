using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FFullyLoadedPackagesInfo : NativeStructWrapper
	{
		public FFullyLoadedPackagesInfo() : base(E_CreateStruct_FFullyLoadedPackagesInfo(), false)
		{
		}

		internal FFullyLoadedPackagesInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FFullyLoadedPackagesInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FFullyLoadedPackagesInfo_Tag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FFullyLoadedPackagesInfo_Tag_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string Tag
		{
			get => E_PROP_FFullyLoadedPackagesInfo_Tag_GET(NativePointer);
			set => E_PROP_FFullyLoadedPackagesInfo_Tag_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FFullyLoadedPackagesInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFullyLoadedPackagesInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFullyLoadedPackagesInfo(Adress, false);
		}}}
