using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Handles operations on precomputed visibility data for a level.
	/// </summary>
	public partial class FPrecomputedVisibilityHandler
	{
		protected readonly IntPtr NativePointer;
		
		public FPrecomputedVisibilityHandler(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FPrecomputedVisibilityHandler_UpdateVisibilityStats(IntPtr Self, bool bAllocating);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FPrecomputedVisibilityHandler_ApplyWorldOffset(IntPtr Self, IntPtr InOffset);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_FPrecomputedVisibilityHandler_GetId(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Updates visibility stats.
		/// </summary>
		public void UpdateVisibilityStats(bool bAllocating)
			=> E_FPrecomputedVisibilityHandler_UpdateVisibilityStats(NativePointer, bAllocating);
		
		
		/// <summary>
		/// Shifts origin of precomputed visibility volume by specified offset
		/// </summary>
		public void ApplyWorldOffset(FVector InOffset)
			=> E_FPrecomputedVisibilityHandler_ApplyWorldOffset(NativePointer, InOffset);
		
		
		/// <summary>
		/// @return the Id
		/// </summary>
		public int GetId()
			=> E_FPrecomputedVisibilityHandler_GetId(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(FPrecomputedVisibilityHandler Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FPrecomputedVisibilityHandler(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FPrecomputedVisibilityHandler(Adress);
		}}}
