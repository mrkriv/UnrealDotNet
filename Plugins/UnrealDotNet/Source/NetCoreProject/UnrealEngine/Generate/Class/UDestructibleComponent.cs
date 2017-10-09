using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UDestructibleComponent : USkinnedMeshComponent
	{
		public UDestructibleComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UDestructibleComponent(UObject Parent = null, string Name = "DestructibleComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDestructibleComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDestructibleComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDestructibleComponent_SetChunkVisible(IntPtr Self, int ChunkIndex, bool bInVisible);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>This method makes a chunk (fractured piece) visible or invisible. </para>
		/// <param name="ChunkIndex">Which chunk to affect.  ChunkIndex must lie in the range: 0 <= ChunkIndex < ((DestructibleMesh*)USkeletalMesh)->ApexDestructibleAsset->chunkCount(). </param>
		/// <param name="bVisible">If true, the chunk will be made visible.  Otherwise, the chunk is made invisible. </param>
		/// </summary>
		public void SetChunkVisible(int ChunkIndex, bool bInVisible)
			=> E_UDestructibleComponent_SetChunkVisible(this, ChunkIndex, bInVisible);
		
		#endregion
		
		public static implicit operator IntPtr(UDestructibleComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDestructibleComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UDestructibleComponent>(PtrDesc);
		}}}
