// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\NetSerialization.h:290

namespace UnrealEngine
{
	public partial class FFastArraySerializerItem : NativeStructWrapper
	{
		public FFastArraySerializerItem(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FFastArraySerializerItem() :
			base(E_CreateStruct_FFastArraySerializerItem(), false)
		{
		}

		public FFastArraySerializerItem(FFastArraySerializerItem inItem) :
			base(E_CreateStruct_FFastArraySerializerItem_FFastArraySerializerItem(inItem), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FFastArraySerializerItem_MostRecentArrayReplicationKey_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFastArraySerializerItem_MostRecentArrayReplicationKey_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FFastArraySerializerItem_ReplicationID_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFastArraySerializerItem_ReplicationID_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FFastArraySerializerItem_ReplicationKey_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFastArraySerializerItem_ReplicationKey_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFastArraySerializerItem();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFastArraySerializerItem_FFastArraySerializerItem(IntPtr inItem);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FFastArraySerializerItem_GetDebugString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFastArraySerializerItem_PostReplicatedAdd(IntPtr self, IntPtr inArraySerializer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFastArraySerializerItem_PostReplicatedChange(IntPtr self, IntPtr inArraySerializer);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FFastArraySerializerItem_PreReplicatedRemove(IntPtr self, IntPtr inArraySerializer);
		
		#endregion
		
		#region Property
		public int MostRecentArrayReplicationKey
		{
			get => E_PROP_FFastArraySerializerItem_MostRecentArrayReplicationKey_GET(NativePointer);
			set => E_PROP_FFastArraySerializerItem_MostRecentArrayReplicationKey_SET(NativePointer, value);
		}

		public int ReplicationID
		{
			get => E_PROP_FFastArraySerializerItem_ReplicationID_GET(NativePointer);
			set => E_PROP_FFastArraySerializerItem_ReplicationID_SET(NativePointer, value);
		}

		public int ReplicationKey
		{
			get => E_PROP_FFastArraySerializerItem_ReplicationKey_GET(NativePointer);
			set => E_PROP_FFastArraySerializerItem_ReplicationKey_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Called when logging LogNetFastTArray (log or lower verbosity)
		/// <para>NOTE: intentionally not virtual; invoked via templated code, @see FExampleItemEntry </para>
		/// </summary>
		/// <param name="inArraySerializer">Array serializer that owns the item and has triggered the replication call</param>
		public string GetDebugString()
			=> E_FFastArraySerializerItem_GetDebugString(this);
		
		
		/// <summary>
		/// Called after adding and serializing a new element
		/// <para>NOTE: intentionally not virtual; invoked via templated code, @see FExampleItemEntry </para>
		/// </summary>
		/// <param name="inArraySerializer">Array serializer that owns the item and has triggered the replication call</param>
		public void PostReplicatedAdd(FFastArraySerializer inArraySerializer)
			=> E_FFastArraySerializerItem_PostReplicatedAdd(this, inArraySerializer);
		
		
		/// <summary>
		/// Called after updating an existing element with new data
		/// <para>NOTE: intentionally not virtual; invoked via templated code, @see FExampleItemEntry </para>
		/// </summary>
		/// <param name="inArraySerializer">Array serializer that owns the item and has triggered the replication call</param>
		public void PostReplicatedChange(FFastArraySerializer inArraySerializer)
			=> E_FFastArraySerializerItem_PostReplicatedChange(this, inArraySerializer);
		
		
		/// <summary>
		/// Called right before deleting element during replication.
		/// <para>NOTE: intentionally not virtual; invoked via templated code, @see FExampleItemEntry </para>
		/// </summary>
		/// <param name="inArraySerializer">Array serializer that owns the item and has triggered the replication call</param>
		public void PreReplicatedRemove(FFastArraySerializer inArraySerializer)
			=> E_FFastArraySerializerItem_PreReplicatedRemove(this, inArraySerializer);
		
		#endregion
		
		public static implicit operator IntPtr(FFastArraySerializerItem self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFastArraySerializerItem(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FFastArraySerializerItem(adress, false);
		}}}
