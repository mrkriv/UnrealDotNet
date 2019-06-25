// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BrainComponent.h:26

namespace UnrealEngine
{
	public partial class FAIMessage : NativeStructWrapper
	{
		public FAIMessage(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIMessage() :
			base(E_CreateStruct_FAIMessage(), false)
		{
		}

		public FAIMessage(string inMessage, UObject inSender) :
			base(E_CreateStruct_FAIMessage_FName_UObject(inMessage, inSender), false)
		{
		}

		public FAIMessage(string inMessage, UObject inSender, EStatus inStatus) :
			base(E_CreateStruct_FAIMessage_FName_UObject_EStatus(inMessage, inSender, (byte)inStatus), false)
		{
		}

		public FAIMessage(string inMessage, UObject inSender, bool bSuccess) :
			base(E_CreateStruct_FAIMessage_FName_UObject_bool(inMessage, inSender, bSuccess), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FAIMessage_MessageFlags_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIMessage_MessageFlags_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FAIMessage_MessageName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIMessage_MessageName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIMessage();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIMessage_FName_UObject(string inMessage, IntPtr inSender);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIMessage_FName_UObject_EStatus(string inMessage, IntPtr inSender, byte inStatus);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIMessage_FName_UObject_bool(string inMessage, IntPtr inSender, bool bSuccess);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIMessage_Broadcast(IntPtr self, IntPtr worldContextObject, IntPtr message);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIMessage_ClearFlag(IntPtr self, byte flag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIMessage_HasFlag(IntPtr self, byte flag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIMessage_Send(IntPtr self, IntPtr controller, IntPtr message);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIMessage_Send_o1(IntPtr self, IntPtr pawn, IntPtr message);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIMessage_Send_o2(IntPtr self, IntPtr brainComp, IntPtr message);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIMessage_SetFlag(IntPtr self, byte flag);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIMessage_SetFlags(IntPtr self, byte flags);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// message param: custom flags
		/// </summary>
		public byte MessageFlags
		{
			get => E_PROP_FAIMessage_MessageFlags_GET(NativePointer);
			set => E_PROP_FAIMessage_MessageFlags_SET(NativePointer, value);
		}

		
		/// <summary>
		/// type of message
		/// </summary>
		public string MessageName
		{
			get => E_PROP_FAIMessage_MessageName_GET(NativePointer);
			set => E_PROP_FAIMessage_MessageName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Broadcast(UObject worldContextObject, FAIMessage message)
			=> E_FAIMessage_Broadcast(this, worldContextObject, message);
		
		public void ClearFlag(byte flag)
			=> E_FAIMessage_ClearFlag(this, flag);
		
		public bool HasFlag(byte flag)
			=> E_FAIMessage_HasFlag(this, flag);
		
		public void Send(AController controller, FAIMessage message)
			=> E_FAIMessage_Send(this, controller, message);
		
		public void Send(APawn pawn, FAIMessage message)
			=> E_FAIMessage_Send_o1(this, pawn, message);
		
		public void Send(UBrainComponent brainComp, FAIMessage message)
			=> E_FAIMessage_Send_o2(this, brainComp, message);
		
		public void SetFlag(byte flag)
			=> E_FAIMessage_SetFlag(this, flag);
		
		public void SetFlags(byte flags)
			=> E_FAIMessage_SetFlags(this, flags);
		
		#endregion
		
		public static implicit operator IntPtr(FAIMessage self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIMessage(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIMessage(adress, false);
		}}}
