using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A precomputed visibility cell, whose data is stored in FCompressedVisibilityChunk.
	/// </summary>
	public partial class FPrecomputedVisibilityCell
	{
		protected readonly IntPtr NativePointer;
		
		public FPrecomputedVisibilityCell(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern FVector E_PROP_FPrecomputedVisibilityCell_Min_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FPrecomputedVisibilityCell_Min_SET(IntPtr Ptr, FVector Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// World space min of the cell.
		/// </summary>
		public FVector Min
		{
			get => E_PROP_FPrecomputedVisibilityCell_Min_GET(NativePointer);
			set => E_PROP_FPrecomputedVisibilityCell_Min_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPrecomputedVisibilityCell Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPrecomputedVisibilityCell(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPrecomputedVisibilityCell(Adress);
		}}}
