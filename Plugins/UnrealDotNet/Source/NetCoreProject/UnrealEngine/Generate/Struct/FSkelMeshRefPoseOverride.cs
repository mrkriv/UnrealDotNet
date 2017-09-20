using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSkelMeshRefPoseOverride : NativeStructWrapper
	{
		internal FSkelMeshRefPoseOverride(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSkelMeshRefPoseOverride() :
			base(E_CreateStruct_FSkelMeshRefPoseOverride(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSkelMeshRefPoseOverride();
		
		#endregion
		
		public static implicit operator IntPtr(FSkelMeshRefPoseOverride Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSkelMeshRefPoseOverride(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSkelMeshRefPoseOverride(Adress, false);
		}
}
}
