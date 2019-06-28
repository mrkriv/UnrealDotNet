// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:37

namespace UnrealEngine
{
	public partial class PingAvgDataV2 : NativeStructWrapper
	{
		public PingAvgDataV2(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor
		/// </summary>
		public PingAvgDataV2() :
			base(E_CreateStruct_PingAvgDataV2(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_PingAvgDataV2_AvgPingV2_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_PingAvgDataV2_AvgPingV2_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_PingAvgDataV2_MAX_PING_VALUES_SIZE_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_PingAvgDataV2();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The average of the values in PingValues, calculated after 1s.
		/// </summary>
		public float AvgPingV2
		{
			get => E_PROP_PingAvgDataV2_AvgPingV2_GET(NativePointer);
			set => E_PROP_PingAvgDataV2_AvgPingV2_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The maximum number of ping values we will keep track of
		/// </summary>
		public static byte MAX_PING_VALUES_SIZE
		{
			get => E_PROP_PingAvgDataV2_MAX_PING_VALUES_SIZE_GET();
		}

		#endregion
		
		public static implicit operator IntPtr(PingAvgDataV2 self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator PingAvgDataV2(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new PingAvgDataV2(adress, false);
		}}}
