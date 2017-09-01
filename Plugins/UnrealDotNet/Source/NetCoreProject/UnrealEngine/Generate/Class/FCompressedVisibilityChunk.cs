using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A chunk of compressed visibility data from multiple FPrecomputedVisibilityCell's.
	/// </summary>
	public partial class FCompressedVisibilityChunk
	{
		protected readonly IntPtr NativePointer;
		
		public FCompressedVisibilityChunk(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_PROP_FCompressedVisibilityChunk_bCompressed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCompressedVisibilityChunk_bCompressed_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FCompressedVisibilityChunk_UncompressedSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FCompressedVisibilityChunk_UncompressedSize_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Whether the chunk is compressed.
		/// </summary>
		public bool bCompressed
		{
			get => E_PROP_FCompressedVisibilityChunk_bCompressed_GET(NativePointer);
			set => E_PROP_FCompressedVisibilityChunk_bCompressed_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Size of the uncompressed chunk.
		/// </summary>
		public int UncompressedSize
		{
			get => E_PROP_FCompressedVisibilityChunk_UncompressedSize_GET(NativePointer);
			set => E_PROP_FCompressedVisibilityChunk_UncompressedSize_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCompressedVisibilityChunk Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FCompressedVisibilityChunk(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCompressedVisibilityChunk(Adress);
		}}}
