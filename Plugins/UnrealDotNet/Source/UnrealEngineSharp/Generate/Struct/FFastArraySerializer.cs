// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\NetSerialization.h:370

namespace UnrealEngine
{
	public partial class FFastArraySerializer : NativeStructWrapper
	{
		public FFastArraySerializer(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FFastArraySerializer() :
			base(E_CreateStruct_FFastArraySerializer(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FFastArraySerializer_ArrayReplicationKey_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFastArraySerializer_ArrayReplicationKey_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FFastArraySerializer_IDCounter_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFastArraySerializer_IDCounter_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFastArraySerializer();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFastArraySerializer_IncrementArrayReplicationKey(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFastArraySerializer_MarkArrayDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFastArraySerializer_MarkItemDirty(IntPtr self, IntPtr item);
		
		#endregion
		
		#region Property
		public int ArrayReplicationKey
		{
			get => E_PROP_FFastArraySerializer_ArrayReplicationKey_GET(NativePointer);
			set => E_PROP_FFastArraySerializer_ArrayReplicationKey_SET(NativePointer, value);
		}

		public int IDCounter
		{
			get => E_PROP_FFastArraySerializer_IDCounter_GET(NativePointer);
			set => E_PROP_FFastArraySerializer_IDCounter_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void IncrementArrayReplicationKey()
			=> E_FFastArraySerializer_IncrementArrayReplicationKey(this);
		
		
		/// <summary>
		/// This must be called if you just remove something from the array
		/// </summary>
		public void MarkArrayDirty()
			=> E_FFastArraySerializer_MarkArrayDirty(this);
		
		
		/// <summary>
		/// This must be called if you add or change an item in the array
		/// </summary>
		public void MarkItemDirty(FFastArraySerializerItem item)
			=> E_FFastArraySerializer_MarkItemDirty(this, item);
		
		#endregion
		
		public static implicit operator IntPtr(FFastArraySerializer self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFastArraySerializer(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FFastArraySerializer(adress, false);
		}}}
