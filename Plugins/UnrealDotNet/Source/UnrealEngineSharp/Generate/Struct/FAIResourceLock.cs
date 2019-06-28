// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AITypes.h:356

namespace UnrealEngine
{
	public partial class FAIResourceLock : NativeStructWrapper
	{
		public FAIResourceLock(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// @note feel free to change the type if you need to support more then 16 lock sources
		/// </summary>
		public FAIResourceLock() :
			base(E_CreateStruct_FAIResourceLock(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIResourceLock();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIResourceLock_ForceClearAllLocks(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FAIResourceLock_GetLockPriorityName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIResourceLock_IsLocked(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIResourceLock_SetUseResourceLockCount(IntPtr self, bool inUseResourceLockCount);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// force-clears all locks
		/// </summary>
		public void ForceClearAllLocks()
			=> E_FAIResourceLock_ForceClearAllLocks(this);
		
		public string GetLockPriorityName()
			=> E_FAIResourceLock_GetLockPriorityName(this);
		
		public bool IsLocked()
			=> E_FAIResourceLock_IsLocked(this);
		
		
		/// <summary>
		/// set whether we should use resource lock count.  clears all existing locks.
		/// </summary>
		public void SetUseResourceLockCount(bool inUseResourceLockCount)
			=> E_FAIResourceLock_SetUseResourceLockCount(this, inUseResourceLockCount);
		
		#endregion
		
		public static implicit operator IntPtr(FAIResourceLock self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIResourceLock(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIResourceLock(adress, false);
		}}}
