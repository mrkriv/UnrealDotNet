// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerInput.h:30

namespace UnrealEngine
{
	public  partial class FKeyBind : NativeStructWrapper
	{
		internal FKeyBind(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FKeyBind() :
			base(E_CreateStruct_FKeyBind(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FKeyBind_Alt_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_Alt_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FKeyBind_bDisabled_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_bDisabled_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FKeyBind_bIgnoreAlt_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_bIgnoreAlt_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FKeyBind_bIgnoreCmd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_bIgnoreCmd_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FKeyBind_bIgnoreCtrl_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_bIgnoreCtrl_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FKeyBind_bIgnoreShift_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_bIgnoreShift_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FKeyBind_Cmd_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_Cmd_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FKeyBind_Command_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_Command_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FKeyBind_Control_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_Control_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FKeyBind_Shift_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FKeyBind_Shift_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FKeyBind();
		
		#endregion
		
		#region Property
		public byte Alt
		{
			get => E_PROP_FKeyBind_Alt_GET(NativePointer);
			set => E_PROP_FKeyBind_Alt_SET(NativePointer, value);
		}

		public byte bDisabled
		{
			get => E_PROP_FKeyBind_bDisabled_GET(NativePointer);
			set => E_PROP_FKeyBind_bDisabled_SET(NativePointer, value);
		}

		public byte bIgnoreAlt
		{
			get => E_PROP_FKeyBind_bIgnoreAlt_GET(NativePointer);
			set => E_PROP_FKeyBind_bIgnoreAlt_SET(NativePointer, value);
		}

		public byte bIgnoreCmd
		{
			get => E_PROP_FKeyBind_bIgnoreCmd_GET(NativePointer);
			set => E_PROP_FKeyBind_bIgnoreCmd_SET(NativePointer, value);
		}

		public byte bIgnoreCtrl
		{
			get => E_PROP_FKeyBind_bIgnoreCtrl_GET(NativePointer);
			set => E_PROP_FKeyBind_bIgnoreCtrl_SET(NativePointer, value);
		}

		public byte bIgnoreShift
		{
			get => E_PROP_FKeyBind_bIgnoreShift_GET(NativePointer);
			set => E_PROP_FKeyBind_bIgnoreShift_SET(NativePointer, value);
		}

		public byte Cmd
		{
			get => E_PROP_FKeyBind_Cmd_GET(NativePointer);
			set => E_PROP_FKeyBind_Cmd_SET(NativePointer, value);
		}

		public string Command
		{
			get => E_PROP_FKeyBind_Command_GET(NativePointer);
			set => E_PROP_FKeyBind_Command_SET(NativePointer, value);
		}

		public byte Control
		{
			get => E_PROP_FKeyBind_Control_GET(NativePointer);
			set => E_PROP_FKeyBind_Control_SET(NativePointer, value);
		}

		public byte Shift
		{
			get => E_PROP_FKeyBind_Shift_GET(NativePointer);
			set => E_PROP_FKeyBind_Shift_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FKeyBind self)
		{
			return self.NativePointer;
		}

		public static implicit operator FKeyBind(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FKeyBind(Adress, false);
		}}}
