using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Mapping info for destructible chunk user data.
	/// </summary>
	public partial class FDestructibleChunkInfo
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FDestructibleChunkInfo()
		{
			NativePointer = E_CreateStruct_FDestructibleChunkInfo();
			IsRef = false;
		}

		internal FDestructibleChunkInfo(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FDestructibleChunkInfo();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FDestructibleChunkInfo_ChunkIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FDestructibleChunkInfo_ChunkIndex_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Index of the chunk this data belongs to
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
