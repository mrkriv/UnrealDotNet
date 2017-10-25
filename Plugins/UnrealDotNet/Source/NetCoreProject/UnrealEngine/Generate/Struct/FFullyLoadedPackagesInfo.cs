using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:109

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
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FFullyLoadedPackagesInfo_Tag_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
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
