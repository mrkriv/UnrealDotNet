// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:820

namespace UnrealEngine
{
	public partial class FResponseChannel : NativeStructWrapper
	{
		public FResponseChannel(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FResponseChannel() :
			base(E_CreateStruct_FResponseChannel(), false)
		{
		}

		public FResponseChannel(string inChannel, ECollisionResponse inResponse) :
			base(E_CreateStruct_FResponseChannel_FName_ECollisionResponse(inChannel, (byte)inResponse), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FResponseChannel_Channel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FResponseChannel_Channel_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FResponseChannel();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FResponseChannel_FName_ECollisionResponse(string inChannel, byte inResponse);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// This should match DisplayName of ECollisionChannel
		/// <para>Meta data of custom channels can be used as well </para>
		/// </summary>
		public string Channel
		{
			get => E_PROP_FResponseChannel_Channel_GET(NativePointer);
			set => E_PROP_FResponseChannel_Channel_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FResponseChannel self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FResponseChannel(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FResponseChannel(adress, false);
		}}}
