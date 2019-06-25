// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeComponent.h:69

namespace UnrealEngine
{
	public partial class FBTTreeStartInfo : NativeStructWrapper
	{
		public FBTTreeStartInfo(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTTreeStartInfo() :
			base(E_CreateStruct_FBTTreeStartInfo(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBTTreeStartInfo_Asset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTTreeStartInfo_Asset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FBTTreeStartInfo_bPendingInitialize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTTreeStartInfo_bPendingInitialize_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTTreeStartInfo();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBTTreeStartInfo_HasPendingInitialize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FBTTreeStartInfo_IsSet(IntPtr self);
		
		#endregion
		
		#region Property
		public UBehaviorTree Asset
		{
			get => E_PROP_FBTTreeStartInfo_Asset_GET(NativePointer);
			set => E_PROP_FBTTreeStartInfo_Asset_SET(NativePointer, value);
		}

		public byte bPendingInitialize
		{
			get => E_PROP_FBTTreeStartInfo_bPendingInitialize_GET(NativePointer);
			set => E_PROP_FBTTreeStartInfo_bPendingInitialize_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool HasPendingInitialize()
			=> E_FBTTreeStartInfo_HasPendingInitialize(this);
		
		public bool IsSet()
			=> E_FBTTreeStartInfo_IsSet(this);
		
		#endregion
		
		public static implicit operator IntPtr(FBTTreeStartInfo self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTTreeStartInfo(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTTreeStartInfo(adress, false);
		}}}
