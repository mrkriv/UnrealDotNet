using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class UObjectBase
	{
		protected readonly IntPtr NativePointer;
		
		public UObjectBase(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObjectBase_LowLevelRename(IntPtr Self, string NewName, IntPtr NewOuter);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UObjectBase_RegisterDependencies(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObjectBase_IsValidLowLevel(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_UObjectBase_IsValidLowLevelFast(IntPtr Self, bool bRecursive);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObjectBase_GetOuter(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UObjectBase_GetFName(IntPtr Self, out int ResultStringLen);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Just change the FName and Outer and rehash into name hash tables. For use by higher level rename functions.
		/// @param NewName	new name for this object
		/// @param NewOuter	new outer for this object, if NULL, outer will be unchanged
		/// </summary>
		protected void LowLevelRename(string NewName, UObject NewOuter = null)
			=> E_UObjectBase_LowLevelRename(NativePointer, NewName, NewOuter);
		
		
		/// <summary>
		/// Force any base classes to be registered first
		/// </summary>
		protected void RegisterDependencies()
			=> E_UObjectBase_RegisterDependencies(NativePointer);
		
		
		/// <summary>
		/// Checks to see if the object appears to be valid
		/// @return true if this appears to be a valid object
		/// </summary>
		public bool IsValidLowLevel()
			=> E_UObjectBase_IsValidLowLevel(NativePointer);
		
		
		/// <summary>
		/// Faster version of IsValidLowLevel.
		/// Checks to see if the object appears to be valid by checking pointers and their alignment.
		/// Name and InternalIndex checks are less accurate than IsValidLowLevel.
		/// @param bRecursive true if the Class pointer should be checked with IsValidLowLevelFast
		/// @return true if this appears to be a valid object
		/// </summary>
		public bool IsValidLowLevelFast(bool bRecursive = true)
			=> E_UObjectBase_IsValidLowLevelFast(NativePointer, bRecursive);
		
		public UObject GetOuter()
			=> E_UObjectBase_GetOuter(NativePointer);
		
		public string GetFName()
			=> Marshal.PtrToStringUTF8(E_UObjectBase_GetFName(NativePointer, out int ResultStringLen), ResultStringLen);
		
		#endregion
		
		public static implicit operator IntPtr(UObjectBase Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObjectBase(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UObjectBase(Adress);
		}}}
