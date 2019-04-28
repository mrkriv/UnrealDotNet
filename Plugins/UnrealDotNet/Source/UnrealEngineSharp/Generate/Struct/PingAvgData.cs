// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerState.h:18

namespace UnrealEngine
{
	public  partial class PingAvgData : NativeStructWrapper
	{
		internal PingAvgData(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor
		/// </summary>
		public PingAvgData() :
			base(E_CreateStruct_PingAvgData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_PingAvgData_PingCount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_PingAvgData_PingCount_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_PingAvgData();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The number of accumulated pings
		/// </summary>
		public byte PingCount
		{
			get => E_PROP_PingAvgData_PingCount_GET(NativePointer);
			set => E_PROP_PingAvgData_PingCount_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(PingAvgData self)
		{
			return self.NativePointer;
		}

		public static implicit operator PingAvgData(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new PingAvgData(Adress, false);
		}}}
