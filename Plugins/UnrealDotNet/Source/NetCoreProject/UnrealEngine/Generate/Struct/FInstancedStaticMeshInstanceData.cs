using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FInstancedStaticMeshInstanceData : NativeStructWrapper
	{
		internal FInstancedStaticMeshInstanceData(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FInstancedStaticMeshInstanceData() :
			base(E_CreateStruct_FInstancedStaticMeshInstanceData(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FInstancedStaticMeshInstanceData();
		
		#endregion
		
		public static implicit operator IntPtr(FInstancedStaticMeshInstanceData Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FInstancedStaticMeshInstanceData(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FInstancedStaticMeshInstanceData(Adress, false);
		}}}
