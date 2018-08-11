using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:165

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
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
