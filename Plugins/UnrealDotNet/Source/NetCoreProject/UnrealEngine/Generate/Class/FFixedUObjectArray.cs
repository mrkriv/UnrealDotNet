using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Fixed size UObject array.
	/// </summary>
	public partial class FFixedUObjectArray
	{
		protected readonly IntPtr NativePointer;
		
		public FFixedUObjectArray(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_FFixedUObjectArray_PreAllocate(IntPtr Self, int InMaxElements);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_FFixedUObjectArray_AddSingle(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_FFixedUObjectArray_AddRange(IntPtr Self, int Count);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_FFixedUObjectArray_Num(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FFixedUObjectArray_IsValidIndex(IntPtr Self, int Index);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Expands the array so that Element[Index] is allocated. New pointers are all zero.
		/// @param Index The Index of an element we want to be sure is allocated
		/// </summary>
		public void PreAllocate(int InMaxElements)
			=> E_FFixedUObjectArray_PreAllocate(NativePointer, InMaxElements);
		
		public int AddSingle()
			=> E_FFixedUObjectArray_AddSingle(NativePointer);
		
		public int AddRange(int Count)
			=> E_FFixedUObjectArray_AddRange(NativePointer, Count);
		
		
		/// <summary>
		/// Return the number of elements in the array
		/// Thread safe, but you know, someone might have added more elements before this even returns
		/// @return	the number of elements in the array
		/// </summary>
		public int Num()
			=> E_FFixedUObjectArray_Num(NativePointer);
		
		
		/// <summary>
		/// Return if this index is valid
		/// Thread safe, if it is valid now, it is valid forever. Other threads might be adding during this call.
		/// @param	Index	Index to test
		/// @return	true, if this is a valid
		/// </summary>
		public bool IsValidIndex(int Index)
			=> E_FFixedUObjectArray_IsValidIndex(NativePointer, Index);
		
		#endregion
		
		public static implicit operator IntPtr(FFixedUObjectArray Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFixedUObjectArray(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFixedUObjectArray(Adress);
		}}}
