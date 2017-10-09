using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\UObject\UObjectBase.h:16

namespace UnrealEngine
{
	public  partial class UObjectBase : NativeWrapper
	{
		public UObjectBase(IntPtr Adress)
			: base(Adress)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UObjectBase_GetFName(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UObjectBase_GetOuter(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBase_IsValidLowLevel(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UObjectBase_IsValidLowLevelFast(IntPtr Self, bool bRecursive);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBase_LowLevelRename(IntPtr Self, string NewName, IntPtr NewOuter);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UObjectBase_RegisterDependencies(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public string GetFName()
			=> E_UObjectBase_GetFName(this);
		
		public UObject GetOuter()
			=> E_UObjectBase_GetOuter(this);
		
		
		/// <summary>
		/// <para>Checks to see if the object appears to be valid </para>
		/// <return>true if this appears to be a valid object </return>
		/// </summary>
		public bool IsValidLowLevel()
			=> E_UObjectBase_IsValidLowLevel(this);
		
		
		/// <summary>
		/// <para>Faster version of IsValidLowLevel. </para>
		/// <para>Checks to see if the object appears to be valid by checking pointers and their alignment. </para>
		/// <para>Name and InternalIndex checks are less accurate than IsValidLowLevel. </para>
		/// <param name="bRecursive">true if the Class pointer should be checked with IsValidLowLevelFast </param>
		/// <return>true if this appears to be a valid object </return>
		/// </summary>
		public bool IsValidLowLevelFast(bool bRecursive = true)
			=> E_UObjectBase_IsValidLowLevelFast(this, bRecursive);
		
		
		/// <summary>
		/// <para>Just change the FName and Outer and rehash into name hash tables. For use by higher level rename functions. </para>
		/// <param name="NewName">new name for this object </param>
		/// <param name="NewOuter">new outer for this object, if NULL, outer will be unchanged </param>
		/// </summary>
		protected void LowLevelRename(string NewName, UObject NewOuter = null)
			=> E_UObjectBase_LowLevelRename(this, NewName, NewOuter);
		
		
		/// <summary>
		/// <para>Force any base classes to be registered first </para>
		/// </summary>
		protected virtual void RegisterDependencies()
			=> E_UObjectBase_RegisterDependencies(this);
		
		#endregion
		
		public static implicit operator IntPtr(UObjectBase Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UObjectBase(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UObjectBase>(PtrDesc);
		}}}
