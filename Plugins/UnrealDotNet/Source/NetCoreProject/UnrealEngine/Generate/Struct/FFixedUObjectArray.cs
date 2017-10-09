using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\UObject\UObjectArray.h:208

namespace UnrealEngine
{
	public  partial class FFixedUObjectArray : NativeStructWrapper
	{
		internal FFixedUObjectArray(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Current number of UObject slots </para>
		/// </summary>
		public FFixedUObjectArray() :
			base(E_CreateStruct_FFixedUObjectArray(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFixedUObjectArray();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FFixedUObjectArray_AddRange(IntPtr Self, int Count);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FFixedUObjectArray_AddSingle(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FFixedUObjectArray_IsValidIndex(IntPtr Self, int Index);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FFixedUObjectArray_Num(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFixedUObjectArray_PreAllocate(IntPtr Self, int InMaxElements);
		
		#endregion
		
		#region ExternMethods
		public int AddRange(int Count)
			=> E_FFixedUObjectArray_AddRange(this, Count);
		
		public int AddSingle()
			=> E_FFixedUObjectArray_AddSingle(this);
		
		
		/// <summary>
		/// <para>Return if this index is valid </para>
		/// <para>Thread safe, if it is valid now, it is valid forever. Other threads might be adding during this call. </para>
		/// <param name="Index">Index to test </param>
		/// <return>true, if this is a valid </return>
		/// </summary>
		public bool IsValidIndex(int Index)
			=> E_FFixedUObjectArray_IsValidIndex(this, Index);
		
		
		/// <summary>
		/// <para>Return the number of elements in the array </para>
		/// <para>Thread safe, but you know, someone might have added more elements before this even returns </para>
		/// <return>the number of elements in the array </return>
		/// </summary>
		public int Num()
			=> E_FFixedUObjectArray_Num(this);
		
		
		/// <summary>
		/// <para>Expands the array so that Element[Index] is allocated. New pointers are all zero. </para>
		/// <param name="Index">The Index of an element we want to be sure is allocated </param>
		/// </summary>
		public void PreAllocate(int InMaxElements)
			=> E_FFixedUObjectArray_PreAllocate(this, InMaxElements);
		
		#endregion
		
		public static implicit operator IntPtr(FFixedUObjectArray Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFixedUObjectArray(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFixedUObjectArray(Adress, false);
		}}}
