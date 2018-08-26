// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3102

namespace UnrealEngine
{
	public  partial class FRepAttachment : NativeStructWrapper
	{
		internal FRepAttachment(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FRepAttachment() :
			base(E_CreateStruct_FRepAttachment(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRepAttachment();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FRepAttachment_AttachComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepAttachment_AttachComponent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FRepAttachment_AttachParent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepAttachment_AttachParent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FRepAttachment_AttachSocket_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepAttachment_AttachSocket_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FRepAttachment_RotationOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FRepAttachment_RotationOffset_SET(IntPtr Ptr, IntPtr Value);
		
		#endregion
		
		#region Property
		public USceneComponent AttachComponent
		{
			get => E_PROP_FRepAttachment_AttachComponent_GET(NativePointer);
			set => E_PROP_FRepAttachment_AttachComponent_SET(NativePointer, value);
		}

		public AActor AttachParent
		{
			get => E_PROP_FRepAttachment_AttachParent_GET(NativePointer);
			set => E_PROP_FRepAttachment_AttachParent_SET(NativePointer, value);
		}

		public string AttachSocket
		{
			get => E_PROP_FRepAttachment_AttachSocket_GET(NativePointer);
			set => E_PROP_FRepAttachment_AttachSocket_SET(NativePointer, value);
		}

		public FRotator RotationOffset
		{
			get => E_PROP_FRepAttachment_RotationOffset_GET(NativePointer);
			set => E_PROP_FRepAttachment_RotationOffset_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FRepAttachment self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRepAttachment(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRepAttachment(Adress, false);
		}}}
