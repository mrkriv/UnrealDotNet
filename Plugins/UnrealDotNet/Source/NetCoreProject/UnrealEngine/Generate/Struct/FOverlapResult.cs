using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FOverlapResult : NativeStructWrapper
	{
		internal FOverlapResult(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FOverlapResult() :
			base(E_CreateStruct_FOverlapResult(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FOverlapResult();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FOverlapResult_ItemIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FOverlapResult_ItemIndex_SET(IntPtr Ptr, int Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>This is the index of the overlapping item. </para>
		/// <para>For DestructibleComponents, this is the ChunkInfo index. </para>
		/// <para>For SkeletalMeshComponents this is the Body index or INDEX_NONE for single body </para>
		/// </summary>
		public int ItemIndex
		{
			get => E_PROP_FOverlapResult_ItemIndex_GET(NativePointer);
			set => E_PROP_FOverlapResult_ItemIndex_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FOverlapResult Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FOverlapResult(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FOverlapResult(Adress, false);
		}}}
