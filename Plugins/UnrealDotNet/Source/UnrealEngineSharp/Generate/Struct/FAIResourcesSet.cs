// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AITypes.h:329

namespace UnrealEngine
{
	public partial class FAIResourcesSet : NativeStructWrapper
	{
		public FAIResourcesSet(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FAIResourcesSet_MaxFlags_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIResourcesSet_AddResourceIndex(IntPtr self, byte resourceIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIResourcesSet_Clear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIResourcesSet_ContainsResourceIndex(IntPtr self, byte resourceID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIResourcesSet_IsEmpty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAIResourcesSet_RemoveResourceIndex(IntPtr self, byte resourceIndex);
		
		#endregion
		
		#region Property
		public static byte MaxFlags
		{
			get => E_PROP_FAIResourcesSet_MaxFlags_GET();
		}

		#endregion
		
		#region ExternMethods
		public FAIResourcesSet AddResourceIndex(byte resourceIndex)
			=> E_FAIResourcesSet_AddResourceIndex(this, resourceIndex);
		
		public void Clear()
			=> E_FAIResourcesSet_Clear(this);
		
		public bool ContainsResourceIndex(byte resourceID)
			=> E_FAIResourcesSet_ContainsResourceIndex(this, resourceID);
		
		public bool IsEmpty()
			=> E_FAIResourcesSet_IsEmpty(this);
		
		public FAIResourcesSet RemoveResourceIndex(byte resourceIndex)
			=> E_FAIResourcesSet_RemoveResourceIndex(this, resourceIndex);
		
		#endregion
		
		public static implicit operator IntPtr(FAIResourcesSet self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIResourcesSet(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIResourcesSet(adress, false);
		}}}
