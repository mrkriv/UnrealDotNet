using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSkelMeshRefPoseOverride : NativeStructWrapper
	{
		public FSkelMeshRefPoseOverride() : base(E_CreateStruct_FSkelMeshRefPoseOverride(), false)
		{
		}

		internal FSkelMeshRefPoseOverride(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FSkelMeshRefPoseOverride();
		
		#endregion
		
		public static implicit operator IntPtr(FSkelMeshRefPoseOverride Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSkelMeshRefPoseOverride(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSkelMeshRefPoseOverride(Adress, false);
		}}}
