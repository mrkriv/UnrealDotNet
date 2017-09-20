using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FSkelMeshComponentLODInfo : NativeStructWrapper
	{
		internal FSkelMeshComponentLODInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSkelMeshComponentLODInfo() :
			base(E_CreateStruct_FSkelMeshComponentLODInfo(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSkelMeshComponentLODInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSkelMeshComponentLODInfo_BeginReleaseOverrideSkinWeights(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSkelMeshComponentLODInfo_BeginReleaseOverrideVertexColors(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSkelMeshComponentLODInfo_CleanUp(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSkelMeshComponentLODInfo_ReleaseOverrideSkinWeightsAndBlock(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FSkelMeshComponentLODInfo_ReleaseOverrideVertexColorsAndBlock(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public void BeginReleaseOverrideSkinWeights()
			=> E_FSkelMeshComponentLODInfo_BeginReleaseOverrideSkinWeights(this);
		
		public void BeginReleaseOverrideVertexColors()
			=> E_FSkelMeshComponentLODInfo_BeginReleaseOverrideVertexColors(this);
		
		public void CleanUp()
			=> E_FSkelMeshComponentLODInfo_CleanUp(this);
		
		public void ReleaseOverrideSkinWeightsAndBlock()
			=> E_FSkelMeshComponentLODInfo_ReleaseOverrideSkinWeightsAndBlock(this);
		
		public void ReleaseOverrideVertexColorsAndBlock()
			=> E_FSkelMeshComponentLODInfo_ReleaseOverrideVertexColorsAndBlock(this);
		
		#endregion
		
		public static implicit operator IntPtr(FSkelMeshComponentLODInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FSkelMeshComponentLODInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSkelMeshComponentLODInfo(Adress, false);
		}}}
