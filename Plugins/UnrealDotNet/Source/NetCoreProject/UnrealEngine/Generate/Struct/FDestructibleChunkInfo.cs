using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FDestructibleChunkInfo : NativeStructWrapper
	{
		public FDestructibleChunkInfo() : base(E_CreateStruct_FDestructibleChunkInfo(), false)
		{
		}

		internal FDestructibleChunkInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FDestructibleChunkInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FDestructibleChunkInfo_ChunkIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDestructibleChunkInfo_ChunkIndex_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Index of the chunk this data belongs to </para>
		/// </summary>
		public int ChunkIndex
		{
			get => E_PROP_FDestructibleChunkInfo_ChunkIndex_GET(NativePointer);
			set => E_PROP_FDestructibleChunkInfo_ChunkIndex_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FDestructibleChunkInfo Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FDestructibleChunkInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDestructibleChunkInfo(Adress, false);
		}}}
