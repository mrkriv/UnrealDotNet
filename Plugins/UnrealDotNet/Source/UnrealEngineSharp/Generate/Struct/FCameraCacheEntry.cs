// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Camera\PlayerCameraManager.h:43

namespace UnrealEngine
{
	public partial class FCameraCacheEntry : NativeStructWrapper
	{
		public FCameraCacheEntry(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FCameraCacheEntry() :
			base(E_CreateStruct_FCameraCacheEntry(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FCameraCacheEntry_POV_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCameraCacheEntry_POV_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCameraCacheEntry_TimeStamp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCameraCacheEntry_TimeStamp_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCameraCacheEntry();
		
		#endregion
		
		#region Property
		public FMinimalViewInfo POV
		{
			get => E_PROP_FCameraCacheEntry_POV_GET(NativePointer);
			set => E_PROP_FCameraCacheEntry_POV_SET(NativePointer, value);
		}

		public float TimeStamp
		{
			get => E_PROP_FCameraCacheEntry_TimeStamp_GET(NativePointer);
			set => E_PROP_FCameraCacheEntry_TimeStamp_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FCameraCacheEntry self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCameraCacheEntry(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FCameraCacheEntry(adress, false);
		}}}
