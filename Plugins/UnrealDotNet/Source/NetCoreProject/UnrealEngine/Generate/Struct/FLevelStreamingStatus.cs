using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:140

namespace UnrealEngine
{
	public  partial class FLevelStreamingStatus : NativeStructWrapper
	{
		internal FLevelStreamingStatus(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructors </para>
		/// </summary>
		public FLevelStreamingStatus(string InPackageName, bool bInShouldBeLoaded, bool bInShouldBeVisible, int InLODIndex) :
			base(E_CreateStruct_FLevelStreamingStatus_FName_bool_bool_int32(InPackageName, bInShouldBeLoaded, bInShouldBeVisible, InLODIndex), false)
		{
		}

		public FLevelStreamingStatus() :
			base(E_CreateStruct_FLevelStreamingStatus(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelStreamingStatus_FName_bool_bool_int32(string InPackageName, bool bInShouldBeLoaded, bool bInShouldBeVisible, int InLODIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLevelStreamingStatus();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FLevelStreamingStatus_PackageName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLevelStreamingStatus_PackageName_SET(IntPtr Ptr, string Value);
		
		#endregion
		
		#region Property
		public string PackageName
		{
			get => E_PROP_FLevelStreamingStatus_PackageName_GET(NativePointer);
			set => E_PROP_FLevelStreamingStatus_PackageName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLevelStreamingStatus Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FLevelStreamingStatus(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLevelStreamingStatus(Adress, false);
		}}}
