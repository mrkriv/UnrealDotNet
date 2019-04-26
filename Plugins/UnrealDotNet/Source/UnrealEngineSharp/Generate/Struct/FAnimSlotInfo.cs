// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2165

namespace UnrealEngine
{
	public  partial class FAnimSlotInfo : NativeStructWrapper
	{
		internal FAnimSlotInfo(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FAnimSlotInfo() :
			base(E_CreateStruct_FAnimSlotInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FAnimSlotInfo_SlotName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAnimSlotInfo_SlotName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAnimSlotInfo();
		
		#endregion
		
		#region Property
		public string SlotName
		{
			get => E_PROP_FAnimSlotInfo_SlotName_GET(NativePointer);
			set => E_PROP_FAnimSlotInfo_SlotName_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FAnimSlotInfo self)
		{
			return self.NativePointer;
		}

		public static implicit operator FAnimSlotInfo(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FAnimSlotInfo(Adress, false);
		}}}
