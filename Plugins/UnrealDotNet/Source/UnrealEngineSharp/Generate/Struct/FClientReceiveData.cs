// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\LocalMessage.h:27

namespace UnrealEngine
{
	public  partial class FClientReceiveData : NativeStructWrapper
	{
		internal FClientReceiveData(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FClientReceiveData() :
			base(E_CreateStruct_FClientReceiveData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FClientReceiveData_LocalPC_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClientReceiveData_LocalPC_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FClientReceiveData_MessageIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClientReceiveData_MessageIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClientReceiveData_MessageString_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClientReceiveData_MessageString_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FClientReceiveData_MessageType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClientReceiveData_MessageType_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FClientReceiveData_OptionalObject_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClientReceiveData_OptionalObject_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FClientReceiveData_RelatedPlayerState_1_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClientReceiveData_RelatedPlayerState_1_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FClientReceiveData_RelatedPlayerState_2_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FClientReceiveData_RelatedPlayerState_2_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FClientReceiveData();
		
		#endregion
		
		#region Property
		public APlayerController LocalPC
		{
			get => E_PROP_FClientReceiveData_LocalPC_GET(NativePointer);
			set => E_PROP_FClientReceiveData_LocalPC_SET(NativePointer, value);
		}

		public int MessageIndex
		{
			get => E_PROP_FClientReceiveData_MessageIndex_GET(NativePointer);
			set => E_PROP_FClientReceiveData_MessageIndex_SET(NativePointer, value);
		}

		public string MessageString
		{
			get => E_PROP_FClientReceiveData_MessageString_GET(NativePointer);
			set => E_PROP_FClientReceiveData_MessageString_SET(NativePointer, value);
		}

		public string MessageType
		{
			get => E_PROP_FClientReceiveData_MessageType_GET(NativePointer);
			set => E_PROP_FClientReceiveData_MessageType_SET(NativePointer, value);
		}

		public UObject OptionalObject
		{
			get => E_PROP_FClientReceiveData_OptionalObject_GET(NativePointer);
			set => E_PROP_FClientReceiveData_OptionalObject_SET(NativePointer, value);
		}

		public APlayerState RelatedPlayerState_1
		{
			get => E_PROP_FClientReceiveData_RelatedPlayerState_1_GET(NativePointer);
			set => E_PROP_FClientReceiveData_RelatedPlayerState_1_SET(NativePointer, value);
		}

		public APlayerState RelatedPlayerState_2
		{
			get => E_PROP_FClientReceiveData_RelatedPlayerState_2_GET(NativePointer);
			set => E_PROP_FClientReceiveData_RelatedPlayerState_2_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FClientReceiveData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FClientReceiveData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FClientReceiveData(adress, false);
		}}}
