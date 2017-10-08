using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FAudioComponentParam : NativeStructWrapper
	{
		internal FAudioComponentParam(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAudioComponentParam(string Name) :
			base(E_CreateStruct_FAudioComponentParam_FName(Name), false)
		{
		}

		public FAudioComponentParam() :
			base(E_CreateStruct_FAudioComponentParam(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAudioComponentParam_FName(string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAudioComponentParam();
		
		#endregion
		
		public static implicit operator IntPtr(FAudioComponentParam Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FAudioComponentParam(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAudioComponentParam(Adress, false);
		}}}
