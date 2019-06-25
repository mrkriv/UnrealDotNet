// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionTypes.h:35

namespace UnrealEngine
{
	public partial class FPerceptionChannelWhitelist : NativeStructWrapper
	{
		public FPerceptionChannelWhitelist(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPerceptionChannelWhitelist() :
			base(E_CreateStruct_FPerceptionChannelWhitelist(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPerceptionChannelWhitelist();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPerceptionChannelWhitelist_Clear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FPerceptionChannelWhitelist_IsEmpty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FPerceptionChannelWhitelist_MergeFilterIn(IntPtr self, IntPtr otherFilter);
		
		#endregion
		
		#region ExternMethods
		public void Clear()
			=> E_FPerceptionChannelWhitelist_Clear(this);
		
		public bool IsEmpty()
			=> E_FPerceptionChannelWhitelist_IsEmpty(this);
		
		public FPerceptionChannelWhitelist MergeFilterIn(FPerceptionChannelWhitelist otherFilter)
			=> E_FPerceptionChannelWhitelist_MergeFilterIn(this, otherFilter);
		
		#endregion
		
		public static implicit operator IntPtr(FPerceptionChannelWhitelist self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPerceptionChannelWhitelist(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPerceptionChannelWhitelist(adress, false);
		}}}
