// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ChildActorComponent.h:16

namespace UnrealEngine
{
	public  partial class FChildActorAttachedActorInfo : NativeStructWrapper
	{
		internal FChildActorAttachedActorInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FChildActorAttachedActorInfo() :
			base(E_CreateStruct_FChildActorAttachedActorInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FChildActorAttachedActorInfo_RelativeTransform_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FChildActorAttachedActorInfo_RelativeTransform_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FChildActorAttachedActorInfo_SocketName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FChildActorAttachedActorInfo_SocketName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FChildActorAttachedActorInfo();
		
		#endregion
		
		#region Property
		public FTransform RelativeTransform
		{
			get => E_PROP_FChildActorAttachedActorInfo_RelativeTransform_GET(NativePointer);
			set => E_PROP_FChildActorAttachedActorInfo_RelativeTransform_SET(NativePointer, value);
		}

		public string SocketName
		{
			get => E_PROP_FChildActorAttachedActorInfo_SocketName_GET(NativePointer);
			set => E_PROP_FChildActorAttachedActorInfo_SocketName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FChildActorAttachedActorInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FChildActorAttachedActorInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FChildActorAttachedActorInfo(Adress, false);
		}}}
