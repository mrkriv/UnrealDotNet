using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\CoreUObject\Public\UObject\UObjectArray.h:198

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFixedUObjectArray();
		
		#endregion
		
		public static implicit operator IntPtr(FFixedUObjectArray Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FFixedUObjectArray(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FFixedUObjectArray(Adress, false);
		}}}
