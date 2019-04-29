// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\EngineMessage.h:11

namespace UnrealEngine
{
	public  partial class UEngineMessage : ULocalMessage
	{
		public UEngineMessage(IntPtr Adress)
			: base(Adress)
		{
		}

		public UEngineMessage(UObject Parent = null, string Name = "EngineMessage")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEngineMessage(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngineMessage_EnteredMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngineMessage_EnteredMessage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngineMessage_FailedPlaceMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngineMessage_FailedPlaceMessage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngineMessage_GlobalNameChange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngineMessage_GlobalNameChange_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngineMessage_LeftMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngineMessage_LeftMessage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngineMessage_MaxedOutMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngineMessage_MaxedOutMessage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngineMessage_NewPlayerMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngineMessage_NewPlayerMessage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngineMessage_NewSpecMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngineMessage_NewSpecMessage_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEngineMessage_SpecEnteredMessage_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEngineMessage_SpecEnteredMessage_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEngineMessage(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		public string EnteredMessage
		{
			get => E_PROP_UEngineMessage_EnteredMessage_GET(NativePointer);
			set => E_PROP_UEngineMessage_EnteredMessage_SET(NativePointer, value);
		}

		public string FailedPlaceMessage
		{
			get => E_PROP_UEngineMessage_FailedPlaceMessage_GET(NativePointer);
			set => E_PROP_UEngineMessage_FailedPlaceMessage_SET(NativePointer, value);
		}

		public string GlobalNameChange
		{
			get => E_PROP_UEngineMessage_GlobalNameChange_GET(NativePointer);
			set => E_PROP_UEngineMessage_GlobalNameChange_SET(NativePointer, value);
		}

		public string LeftMessage
		{
			get => E_PROP_UEngineMessage_LeftMessage_GET(NativePointer);
			set => E_PROP_UEngineMessage_LeftMessage_SET(NativePointer, value);
		}

		public string MaxedOutMessage
		{
			get => E_PROP_UEngineMessage_MaxedOutMessage_GET(NativePointer);
			set => E_PROP_UEngineMessage_MaxedOutMessage_SET(NativePointer, value);
		}

		public string NewPlayerMessage
		{
			get => E_PROP_UEngineMessage_NewPlayerMessage_GET(NativePointer);
			set => E_PROP_UEngineMessage_NewPlayerMessage_SET(NativePointer, value);
		}

		public string NewSpecMessage
		{
			get => E_PROP_UEngineMessage_NewSpecMessage_GET(NativePointer);
			set => E_PROP_UEngineMessage_NewSpecMessage_SET(NativePointer, value);
		}

		public string SpecEnteredMessage
		{
			get => E_PROP_UEngineMessage_SpecEnteredMessage_GET(NativePointer);
			set => E_PROP_UEngineMessage_SpecEnteredMessage_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UEngineMessage self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEngineMessage(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngineMessage>(PtrDesc);
		}}}
