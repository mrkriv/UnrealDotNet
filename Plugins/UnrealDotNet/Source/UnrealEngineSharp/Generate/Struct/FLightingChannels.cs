// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:374

namespace UnrealEngine
{
	public  partial class FLightingChannels : NativeStructWrapper
	{
		internal FLightingChannels(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FLightingChannels() :
			base(E_CreateStruct_FLightingChannels(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FLightingChannels_bChannel0_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightingChannels_bChannel0_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FLightingChannels_bChannel1_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightingChannels_bChannel1_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FLightingChannels_bChannel2_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FLightingChannels_bChannel2_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FLightingChannels();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Default channel for all primitives and lights. </para>
		/// </summary>
		public byte bChannel0
		{
			get => E_PROP_FLightingChannels_bChannel0_GET(NativePointer);
			set => E_PROP_FLightingChannels_bChannel0_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>First custom channel </para>
		/// </summary>
		public byte bChannel1
		{
			get => E_PROP_FLightingChannels_bChannel1_GET(NativePointer);
			set => E_PROP_FLightingChannels_bChannel1_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Second custom channel </para>
		/// </summary>
		public byte bChannel2
		{
			get => E_PROP_FLightingChannels_bChannel2_GET(NativePointer);
			set => E_PROP_FLightingChannels_bChannel2_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FLightingChannels self)
		{
			return self.NativePointer;
		}

		public static implicit operator FLightingChannels(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FLightingChannels(Adress, false);
		}}}
