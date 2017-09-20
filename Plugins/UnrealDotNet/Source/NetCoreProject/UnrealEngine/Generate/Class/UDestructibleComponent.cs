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
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDestructibleComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDestructibleComponent_SetChunkVisible(IntPtr Self, int ChunkIndex, bool bInVisible);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDestructibleComponent_SetChunkWorldRT(IntPtr Self, int ChunkIndex, IntPtr WorldRotation, IntPtr WorldTranslation);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>This method makes a chunk (fractured piece) visible or invisible. </para>
		/// <param name="ChunkIndex">- Which chunk to affect.  ChunkIndex must lie in the range: 0 <= ChunkIndex < ((DestructibleMesh*)USkeletalMesh)->ApexDestructibleAsset->chunkCount(). </param>
		/// <param name="bVisible">- If true, the chunk will be made visible.  Otherwise, the chunk is made invisible. </param>
		/// </summary>
		public void SetChunkVisible(int ChunkIndex, bool bInVisible)
			=> E_UDestructibleComponent_SetChunkVisible(this, ChunkIndex, bInVisible);
		
		
		/// <summary>
		/// <para>This method sets a chunk's (fractured piece's) world rotation and translation. </para>
		/// <param name="ChunkIndex">- Which chunk to affect.  ChunkIndex must lie in the range: 0 <= ChunkIndex < ((DestructibleMesh*)USkeletalMesh)->ApexDestructibleAsset->chunkCount(). </param>
		/// <param name="WorldRotation">- The orientation to give to the chunk in world space, represented as a quaternion. </param>
		/// <param name="WorldRotation">- The world space position to give to the chunk. </param>
		/// </summary>
		public void SetChunkWorldRT(int ChunkIndex, FQuat WorldRotation, FVector WorldTranslation)
			=> E_UDestructibleComponent_SetChunkWorldRT(this, ChunkIndex, WorldRotation, WorldTranslation);
		
		#endregion
		
		public static implicit operator IntPtr(UDestructibleComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDestructibleComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UDestructibleComponent>(PtrDesc);
		}}}
