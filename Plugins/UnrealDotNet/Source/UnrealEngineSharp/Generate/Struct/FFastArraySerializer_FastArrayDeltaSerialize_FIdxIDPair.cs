// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\NetSerialization.h:465

namespace UnrealEngine
{
	public partial class FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair : NativeStructWrapper
	{
		public FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair(int _idx, int _id) :
			base(E_CreateStruct_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_int32_int32(_idx, _id), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_ID_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_ID_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_Idx_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_Idx_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_int32_int32(int _idx, int _id);
		
		#endregion
		
		#region Property
		public int ID
		{
			get => E_PROP_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_ID_GET(NativePointer);
			set => E_PROP_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_ID_SET(NativePointer, value);
		}

		public int Idx
		{
			get => E_PROP_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_Idx_GET(NativePointer);
			set => E_PROP_FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair_Idx_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FFastArraySerializer_FastArrayDeltaSerialize_FIdxIDPair(adress, false);
		}}}
