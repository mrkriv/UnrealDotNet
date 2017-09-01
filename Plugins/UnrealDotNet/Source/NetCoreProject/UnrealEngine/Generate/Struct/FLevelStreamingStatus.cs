using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// level streaming updates that should be applied immediately after committing the map change
	/// </summary>
	public partial class FLevelStreamingStatus
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FLevelStreamingStatus()
		{
			NativePointer = E_CreateStruct_FLevelStreamingStatus();
			IsRef = false;
		}

		internal FLevelStreamingStatus(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FLevelStreamingStatus();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FLevelStreamingStatus_PackageName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
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
