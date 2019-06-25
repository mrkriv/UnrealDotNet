// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_Wait.h:9

namespace UnrealEngine
{
	public partial class FBTWaitTaskMemory : NativeStructWrapper
	{
		public FBTWaitTaskMemory(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FBTWaitTaskMemory() :
			base(E_CreateStruct_FBTWaitTaskMemory(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FBTWaitTaskMemory_RemainingWaitTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBTWaitTaskMemory_RemainingWaitTime_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBTWaitTaskMemory();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// time left
		/// </summary>
		public float RemainingWaitTime
		{
			get => E_PROP_FBTWaitTaskMemory_RemainingWaitTime_GET(NativePointer);
			set => E_PROP_FBTWaitTaskMemory_RemainingWaitTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FBTWaitTaskMemory self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FBTWaitTaskMemory(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FBTWaitTaskMemory(adress, false);
		}}}
