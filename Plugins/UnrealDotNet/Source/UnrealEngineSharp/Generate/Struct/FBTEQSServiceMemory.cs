// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Services\BTService_RunEQS.h:14

namespace UnrealEngine
{
	public partial class FBTEQSServiceMemory : NativeStructWrapper
	{
		public FBTEQSServiceMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTEQSServiceMemory() :
			base(E_CreateStruct_FBTEQSServiceMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FBTEQSServiceMemory_RequestID_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTEQSServiceMemory_RequestID_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTEQSServiceMemory();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Query request ID
		/// </summary>
		public int RequestID
		{
			get => E_PROP_FBTEQSServiceMemory_RequestID_GET(NativePointer);
			set => E_PROP_FBTEQSServiceMemory_RequestID_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTEQSServiceMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTEQSServiceMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTEQSServiceMemory(adress, false);
		}}}
