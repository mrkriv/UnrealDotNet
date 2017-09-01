using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A bucket of visibility cells that have the same spatial hash.
	/// </summary>
	public partial class FPrecomputedVisibilityBucket
	{
		protected readonly IntPtr NativePointer;
		
		public FPrecomputedVisibilityBucket(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_PROP_FPrecomputedVisibilityBucket_CellDataSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FPrecomputedVisibilityBucket_CellDataSize_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Size in bytes of the data of each cell.
		/// </summary>
		public int CellDataSize
		{
			get => E_PROP_FPrecomputedVisibilityBucket_CellDataSize_GET(NativePointer);
			set => E_PROP_FPrecomputedVisibilityBucket_CellDataSize_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPrecomputedVisibilityBucket Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPrecomputedVisibilityBucket(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPrecomputedVisibilityBucket(Adress);
		}}}
