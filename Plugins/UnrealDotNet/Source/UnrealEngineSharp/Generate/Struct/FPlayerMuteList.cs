// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\PlayerMuteList.h:17

namespace UnrealEngine
{
	public partial class FPlayerMuteList : NativeStructWrapper
	{
		public FPlayerMuteList(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPlayerMuteList() :
			base(E_CreateStruct_FPlayerMuteList(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_FPlayerMuteList_bHasVoiceHandshakeCompleted_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPlayerMuteList_bHasVoiceHandshakeCompleted_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FPlayerMuteList_VoiceChannelIdx_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FPlayerMuteList_VoiceChannelIdx_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPlayerMuteList();
		
		#endregion
		
		#region Property
		public bool bHasVoiceHandshakeCompleted
		{
			get => E_PROP_FPlayerMuteList_bHasVoiceHandshakeCompleted_GET(NativePointer);
			set => E_PROP_FPlayerMuteList_bHasVoiceHandshakeCompleted_SET(NativePointer, value);
		}

		public int VoiceChannelIdx
		{
			get => E_PROP_FPlayerMuteList_VoiceChannelIdx_GET(NativePointer);
			set => E_PROP_FPlayerMuteList_VoiceChannelIdx_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FPlayerMuteList self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPlayerMuteList(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPlayerMuteList(adress, false);
		}}}
