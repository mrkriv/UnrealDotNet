// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Public\CollisionQueryParams.h:346

namespace UnrealEngine
{
	public  partial class FCollisionObjectQueryParams : NativeStructWrapper
	{
		internal FCollisionObjectQueryParams(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCollisionObjectQueryParams() :
			base(E_CreateStruct_FCollisionObjectQueryParams(), false)
		{
		}

		public FCollisionObjectQueryParams(ECollisionChannel queryChannel) :
			base(E_CreateStruct_FCollisionObjectQueryParams_ECollisionChannel((byte)queryChannel), false)
		{
		}

		public FCollisionObjectQueryParams(int inObjectTypesToQuery) :
			base(E_CreateStruct_FCollisionObjectQueryParams_int32(inObjectTypesToQuery), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCollisionObjectQueryParams_DefaultObjectQueryParam_GET();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FCollisionObjectQueryParams_ObjectTypesToQuery_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCollisionObjectQueryParams_ObjectTypesToQuery_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionObjectQueryParams();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionObjectQueryParams_ECollisionChannel(byte queryChannel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCollisionObjectQueryParams_int32(int inObjectTypesToQuery);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionObjectQueryParams_AddObjectTypesToQuery(IntPtr self, byte queryChannel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionObjectQueryParams_DoVerify(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FCollisionObjectQueryParams_GetQueryBitfield(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FCollisionObjectQueryParams_IsValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FCollisionObjectQueryParams_IsValidObjectQuery(IntPtr self, byte queryChannel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCollisionObjectQueryParams_RemoveObjectTypesToQuery(IntPtr self, byte queryChannel);
		
		#endregion
		
		#region Property
		public static FCollisionObjectQueryParams DefaultObjectQueryParam
		{
			get => E_PROP_FCollisionObjectQueryParams_DefaultObjectQueryParam_GET();
		}

		
		/// <summary>
		/// Set of object type queries that it is interested in
		/// </summary>
		public int ObjectTypesToQuery
		{
			get => E_PROP_FCollisionObjectQueryParams_ObjectTypesToQuery_GET(NativePointer);
			set => E_PROP_FCollisionObjectQueryParams_ObjectTypesToQuery_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void AddObjectTypesToQuery(ECollisionChannel queryChannel)
			=> E_FCollisionObjectQueryParams_AddObjectTypesToQuery(this, (byte)queryChannel);
		
		public void DoVerify()
			=> E_FCollisionObjectQueryParams_DoVerify(this);
		
		public int GetQueryBitfield()
			=> E_FCollisionObjectQueryParams_GetQueryBitfield(this);
		
		public bool IsValid()
			=> E_FCollisionObjectQueryParams_IsValid(this);
		
		public bool IsValidObjectQuery(ECollisionChannel queryChannel)
			=> E_FCollisionObjectQueryParams_IsValidObjectQuery(this, (byte)queryChannel);
		
		public void RemoveObjectTypesToQuery(ECollisionChannel queryChannel)
			=> E_FCollisionObjectQueryParams_RemoveObjectTypesToQuery(this, (byte)queryChannel);
		
		#endregion
		
		public static implicit operator IntPtr(FCollisionObjectQueryParams self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCollisionObjectQueryParams(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FCollisionObjectQueryParams(adress, false);
		}}}
