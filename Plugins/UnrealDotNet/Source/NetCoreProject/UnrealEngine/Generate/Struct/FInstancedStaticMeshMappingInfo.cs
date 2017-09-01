using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FInstancedStaticMeshMappingInfo
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FInstancedStaticMeshMappingInfo()
		{
			NativePointer = E_CreateStruct_FInstancedStaticMeshMappingInfo();
			IsRef = false;
		}

		internal FInstancedStaticMeshMappingInfo(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshMappingInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#endregion
		
		public static implicit operator IntPtr(FInstancedStaticMeshMappingInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FInstancedStaticMeshMappingInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInstancedStaticMeshMappingInfo(Adress, false);
		}}}
