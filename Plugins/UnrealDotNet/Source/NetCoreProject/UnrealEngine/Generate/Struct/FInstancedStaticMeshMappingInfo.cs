using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FInstancedStaticMeshMappingInfo : NativeStructWrapper
	{
		public FInstancedStaticMeshMappingInfo() : base(E_CreateStruct_FInstancedStaticMeshMappingInfo(), false)
		{
		}

		internal FInstancedStaticMeshMappingInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshMappingInfo();
		
		#endregion
		
		public static implicit operator IntPtr(FInstancedStaticMeshMappingInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FInstancedStaticMeshMappingInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInstancedStaticMeshMappingInfo(Adress, false);
		}}}
